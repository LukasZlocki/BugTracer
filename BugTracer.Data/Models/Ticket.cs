using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedBy { get; set; }

        // Foreign key - Ticket Status
        public int StatusId { get; set; }
        // inverse nav property
        public TicketStatus Status { get; set; }

        // Foreign key - Priority
        public int PriorityId { get; set; }
        // inverse nav property
        public TicketPriority Priority { get; set; }

        // Foreign key - Resource
        public int ResourceId { get; set; }
        // inverse nav property
        public Resource Resource { get; set; }


        // Foreign key - Project
        public int ProjectId { get; set; }
        // inverse nav property
        public Project Project { get; set; }
    }
}