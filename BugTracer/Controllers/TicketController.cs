using BugTracer.Api.Serialization;
using BugTracer.Services.Ticket_Service;
using Microsoft.AspNetCore.Mvc;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService _ticketService;

        public TicketController(ILogger<TicketController> logger, ITicketService ticketService)
        {
            _logger = logger;
            _ticketService = ticketService;
        }

        [HttpGet("api/project/ticket")]
        public ActionResult GetAllTicketsByProjectId(int id)
        {
            _logger.LogInformation("Get all tickets by project id");
            var tickets = _ticketService.GetTicketsByProjectId(id);
            var ticketsMapper = TicketMapper.SerializeTicketModelListToTicketReadDtoModelList(tickets);
            return Ok(ticketsMapper);
        }

        [HttpGet("api/tickets/{id}")]
        public ActionResult GetticketbyId(int id)
        {
            _logger.LogInformation("Get ticket by its primary key");
            var ticket = _ticketService.GetTicketById(id);
            var ticketMapper = TicketMapper.SerializeTicketModelToTicketReadDtoModel(ticket);
            return Ok(ticketMapper);
        }


    }
}
