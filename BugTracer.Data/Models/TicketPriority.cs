using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class TicketPriority
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Priority { get; set; }

        // Foreign key - Ticket
        public int TicketId { get; set; }

        // inverse nav property
        public Ticket Ticket { get; set; }
    }
}