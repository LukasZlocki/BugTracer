using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        [MaxLength(15)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        [MaxLength(64)]
        public string Email { get; set; }

        // nav property
        public ResourceRole Role { get; set; }

        // Foreign key - Ticket
        public int TicketId { get; set; }

        // inverse nav property
        public Ticket Ticket { get; set; }

    }
}
