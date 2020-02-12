using DraftSiteApi.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftSiteApi.Controllers
{
    [Authorize]
    [EnableCors(Startup.VUE_CORS_POLICY)]
    [ApiController]
    [Route("api/[controller]")]
    public class ActiveDraftController
    {
        //private readonly IHubContext<PreDraftLobbyHub> _hubContext;

        //public ActiveDraftController(IHubContext<PreDraftLobbyHub> hubContext)
        //{
        //    _hubContext = hubContext;
        //}


    }
}
