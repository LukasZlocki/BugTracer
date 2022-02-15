using BugTracer.Api.Serialization;
using Microsoft.AspNetCore.Mvc;
using IResourceService = BugTracer.Services.Resource_Service.IResourceService;

namespace BugTracer.Api.Controllers
{
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly ILogger<ResourceController> _logger;
        private readonly IResourceService _resourceService;

        public ResourceController(ILogger<ResourceController> logger, IResourceService resourceService)
        {
            _resourceService = resourceService;
            _logger = logger;   
        }

        [HttpGet("api/resources")]
        public ActionResult GetAllResources()
        {
            _logger.LogInformation("Get all resources");
            var resources = _resourceService.GetAllResources();
            var resourcesMapper = ResourceMapper.SerializeResourceModelListToResourceDtoModelList(resources);
            return Ok(resourcesMapper);
        }

        [HttpGet("api/resources/{id}")]
        public ActionResult GetResourceById(int id)
        {
            _logger.LogInformation("Get resource by id");
            var resource = _resourceService.GetResourceById(id);
            var resourceMapper = ResourceMapper.SerializeResourceModelToResourceReadDtoModel(resource);
            return Ok(resourceMapper);
        }

    }
}
