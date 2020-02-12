using DraftSiteApi.Hubs;
using DraftSiteModels.InputModels;
using DraftSiteService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DraftSiteApi.Controllers
{
    [Authorize]
    [EnableCors(Startup.VUE_CORS_POLICY)]
    [ApiController]
    [Route("api/[controller]")]
    public class PreDraftLobbyController : Controller
    {
        private readonly IDraftService _draftService;
        private readonly IHubContext<PreDraftLobbyHub> _hubContext;

        public PreDraftLobbyController(IDraftService draftService, IHubContext<PreDraftLobbyHub> hubContext)
        {
            _draftService = draftService;
            _hubContext = hubContext;
        }


        [HttpPost]
        public async Task<IActionResult> UpdateDraftSettings([FromBody]DraftInputModel draft)
        {
            try
            {
                int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
                draft.UserId = userId;
                var draftViewModel = await _draftService.UpdateDraftSettings(draft);
                return Ok(draftViewModel);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{draftId}")]
        public async Task<IActionResult> EnterPreDraftLobby()
        {
            try
            {
                //int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
                //draft.UserId = userId;
                //var draftViewModel = await _draftService.UpdateDraftSettings(draft);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}


//private readonly IDraftService _draftService;

//public DraftController(IDraftService draftService)
//{
//    _draftService = draftService;
//}

//[HttpGet]
//public async Task<IActionResult> GetUserLobby()
//{
//    try
//    {
//        int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
//        var userLobby = await _draftService.GetUserLobby();
//        return Ok(userLobby);
//    }
//    catch
//    {
//        return BadRequest();
//    }
//}


//[HttpPost]
//public async Task<IActionResult> CreateDraft([FromBody]DraftInputModel draft)
//{
//    try
//    {
//        int.TryParse(HttpContext.User.Claims.Single(claim => claim.Type == ClaimTypes.SerialNumber).Value, out var userId);
//        draft.UserId = userId;
//        var draftViewModel = await _draftService.CreateDraft(draft);
//        return Ok(draftViewModel);
//    }
//    catch
//    {
//        return BadRequest();
//    }
//}

//[AllowAnonymous]
//[HttpGet("lookups")]
//public async Task<IActionResult> GetDraftLookups()
//{
//    var draftData = await _draftService.GetDraftLookups();
//    return Ok(draftData);
//}