using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class ResourceRole
    {
        [Key]
        public int ResourceRoleId { get; set; }
        [MaxLength(20)]
        public string Role { get; set; }
    }
}
