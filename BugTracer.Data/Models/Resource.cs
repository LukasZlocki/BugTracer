using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(64)]
        public string Email { get; set; }

        public ResourceRole Role { get; set; }

    }
}
