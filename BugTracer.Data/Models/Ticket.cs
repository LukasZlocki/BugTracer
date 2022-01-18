using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedBy { get; set; }

        // nav properties
        public TicketStatus Status { get; set; }
        public TicketPriority Priority { get; set; }
        public Resource Resource { get; set; }

        // Foreign key - Project
        public int ProjectId { get; set; }

        // inverse nav property
        public Project Project { get; set; }
    }
}