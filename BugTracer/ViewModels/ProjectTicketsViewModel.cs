using BugTracer.Api.Dtos;

namespace BugTracer.Api.ViewModels
{
    public class ProjectTicketsViewModel
    {
        public ProjectBasicReadDto  ProjectBasicDataReadDto { get; set; }
        public List<TicketReadDto> ProjectTicketsReadDto { get; set; }

        // constructor
        public ProjectTicketsViewModel(ProjectBasicReadDto project, List<TicketReadDto> ticketsList)
        {
            ProjectBasicDataReadDto = project;
            ProjectTicketsReadDto = ticketsList;
        }


    }
}
