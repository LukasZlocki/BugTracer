using BugTracer.Api.Serialization;
using BugTracer.Api.ViewModels;
using BugTracer.Services.Resource_Service;
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

        public TicketController(ILogger<TicketController> logger, ITicketService ticketService, IResourceService resourceService)
        {
            _logger = logger;
            _ticketService = ticketService;
            _resourceService = resourceService;
        }

        [HttpGet("api/project/ticket")]
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

            // ToDo: extend constructor for rest of objects ex status, priority
            TicketDetailsViewModel ticketVM = new TicketDetailsViewModel(ticketMapper, resourceMapper);

            return Ok(ticketVM);
        }


    }
}
