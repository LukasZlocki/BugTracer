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
            }).ToList();
        }


    }
}
