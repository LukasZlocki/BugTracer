using BugTracer.Api.Serialization;
using BugTracer.Api.ViewModels;
using BugTracer.Services.Priority_Service;
using BugTracer.Services.Resource_Service;
using BugTracer.Services.Status_Service;
using BugTracer.Services.Ticket_Service;
using Microsoft.AspNetCore.Mvc;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService _ticketService;
        private readonly IResourceService _resourceService;
        private readonly IPriorityService _priorityService;
        private readonly IStatusService _statusService;

        public TicketController(ILogger<TicketController> logger, ITicketService ticketService, IResourceService resourceService, IPriorityService priorityService, IStatusService statusService)
        {
            _logger = logger;
            _ticketService = ticketService;
            _resourceService = resourceService;
            _priorityService = priorityService;
            _statusService = statusService;
        }

        [HttpGet("api/project/ticket/{id}")]
        public ActionResult GetAllTicketsByProjectId(int id)
        {
            _logger.LogInformation("Get all tickets by project id");
            var tickets = _ticketService.GetTicketsByProjectId(id);
            var ticketsMapper = TicketMapper.SerializeTicketModelListToTicketReadDtoModelList(tickets);
            return Ok(ticketsMapper);
        }

        [HttpGet("api/ticket/{id}")]
        public ActionResult GetTicketbyId(int id)
        {
            _logger.LogInformation("Get ticket by its primary key");
            var ticket = _ticketService.GetTicketById(id);
            var ticketMapper = TicketMapper.SerializeTicketModelToTicketReadDtoModel(ticket);
            
            int _resourceId = ticket.ResourceId;
            var resource = _resourceService.GetResourceById(_resourceId);
            var resourceMapper = ResourceMapper.SerializeResourceModelToResourceReadDtoModel(resource);
           
            int _priorityId = ticket.PriorityId;
            var priority = _priorityService.GetPriorityById(_priorityId);
            var priorityMapper = PriorityMapper.SerializeTicketPriorityModelToTickePriorityReadDtoModel(priority);
            
            int _statusId = ticket.StatusId;
            var status = _statusService.GetStatusById(_statusId);
            var statusMapper = StatusMapper.SerializeTicketStatusModelToTicketStatusReadDtoModel(status);

            TicketDetailsViewModel ticketVM = new TicketDetailsViewModel(ticketMapper, resourceMapper, priorityMapper, statusMapper);

            return Ok(ticketVM);
        }


    }
}
