using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class ProjectMapper
    {
        public static ProjectBasicReadDto SerializeProjectModelToProjectReadDtoModel(Project project)
        {
            return new ProjectBasicReadDto
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                CreatedOn = project.CreatedOn,
                CreatedBy = project.CreatedBy,
                ClosedOn = project.ClosedOn,
                ClosedBy = project.ClosedBy,
            };
        }


        public static List<ProjectBasicReadDto> SerializeProjectModelListToProjectReadDtoList(IEnumerable<Project> projects)
        {
            return projects.Select(project => new ProjectBasicReadDto 
            { 
                Id = project.Id,
                Name= project.Name,
                Description = project.Description,
                CreatedOn = project.CreatedOn,
                CreatedBy = project.CreatedBy,
                ClosedOn= project.ClosedOn,
                ClosedBy= project.ClosedBy,
            }).ToList();
        }


    }
}
