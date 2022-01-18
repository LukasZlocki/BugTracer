using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedOn { get; set; }
        public string ClosedBy { get; set; }

        // nav properties
        public List<Ticket> Tickets { get; set; }
    }
}
