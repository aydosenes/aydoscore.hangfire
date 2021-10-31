using Application.Hangfire.Services;
using Application.Results;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangfireController : ControllerBase
    {
        private readonly IHangService _hangService;
        public HangfireController(IHangService hangService)
        {
            _hangService = hangService;
        }

        [HttpGet("fire")]
        [ProducesResponseType(200, Type = typeof(BaseResult))]
        public void Fire()
        {
            BackgroundJob.Enqueue(() => _hangService.Fire());
        }
    }
}
