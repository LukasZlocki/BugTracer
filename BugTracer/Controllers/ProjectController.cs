using Microsoft.AspNetCore.Mvc;
using BugTracer.Services.Project_Service;
using BugTracer.Api.Serialization;
using BugTracer.Services.Ticket_Service;
using BugTracer.Api.ViewModels;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectService _projectService;
        private readonly ITicketService _ticketService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService, ITicketService ticketService)
        {
            _logger = logger;
            _projectService = projectService;
            _ticketService = ticketService;
        }

        /// <summary>
        /// Get all projects
        /// </summary>
        /// <returns>projectsMaper</returns>
        [HttpGet("api/projects")]
        public ActionResult GetAllProjects()
        {
            _logger.LogInformation("Get all projects");
            var projects = _projectService.GetAllProjects();
            var projectsMapper = ProjectMapper.SerializeProjectModelListToProjectReadDtoList(projects);
            return Ok(projectsMapper);

        }

        /// <summary>
        /// Return view model with project basis information and all its tickets by project id primary key
        /// </summary>
        /// <param name="id">project object primary key</param>
        /// <returns>ProjectTicketsviewModel</returns>
        [HttpGet("api/project/{id}")]
        public ActionResult GetProjectAndItsTasksById(int id)
        {
            _logger.LogInformation("Get project by id with all its tickets");

            // ToDo: code transfering data with all tasks information to view model
            // idea is to extract all data by project service(for basic data) and by tasks service(for full data) 

            // extracting project is done
            var project = _projectService.GetProjectById(id);
            var projectMapper = ProjectMapper.SerializeProjectModelToProjectReadDtoModel(project);

            // ToDo: Inprogress -> Recode to get all ticket information from ticket service
            var tickets = _ticketService.GetTicketsByProjectId(id);
            var ticketMapper = TicketMapper.SerializeTicketModelListToTicketReadDtoModelList(tickets);

            ProjectTicketsViewModel _viewModel = new ProjectTicketsViewModel(projectMapper, ticketMapper); 

            return Ok(_viewModel);
        }


    }
}
