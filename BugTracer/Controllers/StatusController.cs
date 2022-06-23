using BugTracer.Api.Serialization;
using BugTracer.Services.Status_Service;
using Microsoft.AspNetCore.Mvc;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;
        private readonly IStatusService _statusService;

        public StatusController(ILogger<StatusController> logger, IStatusService statusService)
        {
            _logger = logger;
            _statusService = statusService;
        }

        [HttpGet("api/ticket/status")]
        public ActionResult GetAllStatuses()
        {
            _logger.LogInformation("Get all statuses");
            var statuses = _statusService.GetAllStatuses();
            var statusMapper = StatusMapper.SerializeListOfTicketStatusModelsToListOfTicketStatusReadDtoModels(statuses);
            return Ok(statusMapper);
        }


    }
}