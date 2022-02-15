using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class TicketMapper
    {

        public static TicketReadDto SerializeTicketModelToTicketReadDtoModel(Ticket ticket)
        {
            return new TicketReadDto
            {
                Id = ticket.Id,
                Title = ticket.Title,
                Description = ticket.Description,
                CreatedOn = ticket.CreatedOn,
                CreatedBy = ticket.CreatedBy,
                ClosedOn = ticket.ClosedOn,
                ClosedBy = ticket.ClosedBy,

                StatusId = ticket.StatusId,
                PriorityId = ticket.PriorityId,
                ResourceId = ticket.ResourceId,
                ProjectId = ticket.ProjectId
            };
        }

        public static List<TicketReadDto> SerializeTicketModelListToTicketReadDtoModelList(IEnumerable<Ticket> tickets)
        {
            return tickets.Select(ticket => new TicketReadDto 
            { 
                Id = ticket.Id,
                Title = ticket.Title,
                Description = ticket.Description,
                CreatedOn = ticket.CreatedOn,
                CreatedBy = ticket.CreatedBy,
                ClosedOn = ticket.ClosedOn,
                ClosedBy = ticket.ClosedBy,

                StatusId = ticket.StatusId,
                PriorityId = ticket.PriorityId,
                ResourceId = ticket.ResourceId,
                ProjectId = ticket.ProjectId         
            }).ToList();
        }

    }
}
