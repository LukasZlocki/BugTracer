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
                TicketsDto = TicketMapper.SerializeTicketModelListToTicketReadDtoModelList(project.Tickets)
            };
        }

        public static List<ProjectReadDto> SerializeBasicProjectModelListToBasicProjectReadDtoList(IEnumerable<Project> projects)
        {
            return projects.Select(project => new ProjectReadDto
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                CreatedOn = project.CreatedOn,
                CreatedBy = project.CreatedBy,
                ClosedOn = project.ClosedOn,
                ClosedBy = project.ClosedBy,
            }).ToList();
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
                TicketsDto = TicketMapper.SerializeTicketModelListToTicketReadDtoModelList(project.Tickets)
            }).ToList();
        }


    }
}
