using BugTracer.Api.Dtos;

namespace BugTracer.Api.ViewModels
{
    public class TicketDetailsViewModel
    {
        public TicketReadDto Ticket { get; set; }
        public ResourceReadDto Resource { get; set; } 
        //public TicketPriorityReadDto Priority { get; set; }
        //public TicketStatusReadDto TicketStatus { get; set; }

        public TicketDetailsViewModel( TicketReadDto ticket, ResourceReadDto resource) 
        {
            Ticket = ticket;
            Resource = resource;
            //Priority = priority;
            //TicketStatus = status;
        }

    }
}
