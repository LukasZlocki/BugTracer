using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class ResourceRole
    {
        public int RoleId { get; set; }

        [MaxLength(20)]
        public string Role { get; set; }

        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }
}
