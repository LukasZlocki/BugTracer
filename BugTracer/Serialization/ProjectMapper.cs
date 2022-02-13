using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class ProjectMapper
    {
        public static ProjectReadDto SerializeProjectModelToProjectReadDtoModel(Project project)
        {
            return new ProjectReadDto
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                CreatedOn = project.CreatedOn,
                CreatedBy = project.CreatedBy,
                ClosedOn = project.ClosedOn,
                ClosedBy = project.ClosedBy,
                // TicketsDto = project.Tickets 
            };
        }

        public static Project SerializeProjectReadDtoModelToProjectModel(ProjectReadDto projectReadDto)
        {
            return new Project
            {
                Id = projectReadDto.Id,
                Name = projectReadDto.Name,
                Description = projectReadDto.Description,
                CreatedOn = projectReadDto.CreatedOn,
                CreatedBy = projectReadDto.CreatedBy,
                ClosedOn = projectReadDto.ClosedOn,
                ClosedBy = projectReadDto.ClosedBy,
                // Tickets = projectReadDto.TicketsDto
            };
        }

        public static List<ProjectReadDto> SerializeProjectModelListToProjectReadDtoList(IEnumerable<Project> projects)
        {
            return projects.Select(project => new ProjectReadDto 
            { 
                Id = project.Id,
                Name= project.Name,
                Description = project.Description,
                CreatedOn = project.CreatedOn,
                CreatedBy = project.CreatedBy,
                ClosedOn= project.ClosedOn,
                ClosedBy= project.ClosedBy,
                // TicketsDto = project.Tickets
            }).ToList();
        }

        public static List<Project> SerializeProjectReadDtoListToProjectList(IEnumerable<ProjectReadDto> projectsReadDto)
        {
            return projectsReadDto.Select(projectsDto => new Project 
            {
                Id = projectsDto.Id,
                Name = projectsDto.Name,
                Description = projectsDto.Description,
                CreatedOn = projectsDto.CreatedOn,
                CreatedBy = projectsDto.CreatedBy,
                ClosedOn = projectsDto.ClosedOn,
                ClosedBy = projectsDto.ClosedBy,
                // Tickets = projectsDto.TicketsDto              
            }).ToList();
        }


    }
}
