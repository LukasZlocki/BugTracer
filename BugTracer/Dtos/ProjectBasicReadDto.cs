namespace BugTracer.Api.Dtos
{
    public class ProjectBasicReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ClosedOn { get; set; }
        public string ClosedBy { get; set; }

    }
}
