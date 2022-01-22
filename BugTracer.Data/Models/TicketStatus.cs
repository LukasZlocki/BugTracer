using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class TicketStatus
    {  
        [Key]
        public int StatusId { get; set; }
        [MaxLength(10)]
        public string Status { get; set; }
    }
}