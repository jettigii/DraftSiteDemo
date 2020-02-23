using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<IActionResult> GetUserLobby()
        {
            try
            {
                int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
                var userLobby = await _draftService.GetUserLobby();
                return Ok(userLobby);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateDraft([FromBody]DraftInputModel draft)
        {
            try
            {
                int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
                draft.UserId = userId;
                var draftViewModel = await _draftService.CreateDraftAsync(draft);
                return Ok(draftViewModel);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("lookups")]
        public async Task<IActionResult> GetDraftLookups()
        {
            var draftData = await _draftService.GetDraftLookups();
            return Ok(draftData);
        }
    }
}
