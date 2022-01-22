using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class TicketPriority
    {   
        [Key]
        public int PriorityId { get; set; }
        [MaxLength(15)]
        public string Priority { get; set; }
    }
}