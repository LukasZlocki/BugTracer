using BugTracer.Api.Dtos;

namespace BugTracer.Api.ViewModels
{
    public class ProjectTicketsViewModel
    {
        public ProjectReadDto  ProjectBasicDataReadDto { get; set; }
        public List<TicketReadDto> ProjectTicketsReadDto { get; set; }

        // constructor
        public ProjectTicketsViewModel(ProjectReadDto project, List<TicketReadDto> ticketsList)
        {
            ProjectBasicDataReadDto = project;
            ProjectTicketsReadDto = ticketsList;
        }


    }
}
