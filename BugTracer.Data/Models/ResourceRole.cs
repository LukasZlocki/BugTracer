using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class ResourceRole
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Role { get; set; }

        // Foreign key - Resource
        public int ResourceId { get; set; }

        // inverse nav property
        public Resource Resource { get; set; }
    }
}
