using System.ComponentModel.DataAnnotations;

namespace BugTracer.Api.Dtos
{
    public class TicketReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedOn { get; set; }
        public string ClosedBy { get; set; }

        // Foreign keys
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public int ResourceId { get; set; }
        public int ProjectId { get; set; }
        
    }
}
