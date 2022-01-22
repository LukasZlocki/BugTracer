using System.ComponentModel.DataAnnotations;

namespace BugTracer.Data.Models
{
    public class Resource
    {   
        [Key]
        public int Id { get; set; }

        [MaxLength(15)]
        public string FirstName { get; set; }
        [MaxLength(15)]
        public string LastName { get; set; }
        [MaxLength(64)]
        public string Email { get; set; }

        // Foreign key - Resource Role
        public int ResourceRoleId { get; set; }
        // inverse nav property
        public ResourceRole Role { get; set; }
    }
}
