using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Status { get; set; }

        // Foreign key - Ticket
        public int TicketId { get; set; }

        // inverse nav property
        public Ticket Ticket { get; set; }

    }
}