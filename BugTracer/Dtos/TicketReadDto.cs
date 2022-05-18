using System.ComponentModel.DataAnnotations;

namespace BugTracer.Api.Dtos
{
    public class TicketReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedOn { get; set; }
        public string ClosedBy { get; set; }

        // Foreign key - Ticket Status
        public int StatusId { get; set; }
        // inverse nav property
        public TicketStatusReadDto StatusReadDTO { get; set; }

        // Foreign key - Priority
        public int PriorityId { get; set; }
        // inverse nav property
        public TicketPriorityReadDto PriorityReadDTO { get; set; }

        // Foreign key - Resource
        public int ResourceId { get; set; }
        // inverse nav property
        public ResourceReadDto ResourceReadDTO { get; set; }


        /*
        // Foreign keys
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public int ResourceId { get; set; }
        public int ProjectId { get; set; }
        */

    }
}
