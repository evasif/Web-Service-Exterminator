using Exterminator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Exterminator.WebApi.Controllers
{
    [Route("api/logs")]
    public class LogController : Controller
    {

        private readonly ILogService _logService;

        [HttpGet]
        [Route("")]
        public IActionResult GetAllLogs()
        {
            return Ok(_logService.GetAllLogs());
        }
    }
}