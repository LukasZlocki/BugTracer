using Microsoft.AspNetCore.Mvc;
using BugTracer.Services.Project_Service;
using BugTracer.Api.Serialization;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectService _projectService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        [HttpGet("api/project")]
        public ActionResult GetAllProjects()
        {
            _logger.LogInformation("Get all projects");
            var projects = _projectService.GetAllProjects();
           // var projectsMapper = ProjectMapper.SerializeProjectModelListToProjectReadDtoList(projects);
           // return Ok(projectsMapper);
           return Ok(projects);
        }

        [HttpGet("api/project/{id}")]
        public ActionResult GetProjectById(int id)
        {
            _logger.LogInformation("Get project by id");
            var project = _projectService.GetProjectById(id);
            var projectMapper = ProjectMapper.SerializeProjectModelToProjectReadDtoModel(project);
            return Ok(projectMapper);

        }

        /*
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
