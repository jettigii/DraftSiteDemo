using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DraftSiteApi.Controllers
{
    [Authorize]
    [EnableCors(Startup.VUE_CORS_POLICY)]
    [ApiController]
    [Route("api/[controller]")]
    public class DraftController : ControllerBase
    {
        private readonly IDraftService _draftService;

        public DraftController(IDraftService draftService)
        {
            _draftService = draftService;
        }

        [HttpGet("{token}")]
        public async Task<IActionResult> GetUserLobby([FromRoute]string token)
        {
            var userLobby = await _draftService.GetUserLobby(token);

            if (string.IsNullOrWhiteSpace(userLobby.User.Username))
            {
                return NotFound();
            }

            return Ok(userLobby);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateDraft([FromBody]DraftInputModel draft)
        {
            try
            {
                var user = HttpContext.User.Identity.Name;
                draft.UserId = HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value;
                var draftViewModel = await _draftService.CreateDraft(draft);
                return Ok(draftViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpGet("lookups")]
        public IActionResult GetDraftLookups()
        {
            var draftData = _draftService.GetDraftLookups();
            return Ok(draftData);
        }
    }
}
