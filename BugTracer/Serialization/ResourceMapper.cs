using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class ResourceMapper
    {

        public static ResourceReadDto SerializeResourceModelToResourceReadDtoModel(Resource resource)
        {
            return new ResourceReadDto
            {
                Id = resource.Id,
                FirstName = resource.FirstName,
                LastName = resource.LastName,
                Email = resource.Email,
                ResourceRoleId = resource.ResourceRoleId
                // resource role read dto <-- add this if needed
            };
        }

        public static Resource SerializeResourceReadDtoModelToResourceModel(ResourceReadDto resource)
        {
            return new Resource
            {
                Id = resource.Id,
                FirstName = resource.FirstName,
                LastName = resource.LastName,
                Email = resource.Email,
                ResourceRoleId = resource.ResourceRoleId
                // resource role <-- add this if needed
            };

        }

        public static List<ResourceReadDto> SerializeResourceModelListToResourceDtoModelList(IEnumerable<Resource> resource)
        {
            return resource.Select(resourceReadDto => new ResourceReadDto
            {
                Id = resourceReadDto.Id,
                FirstName = resourceReadDto.FirstName,
                LastName = resourceReadDto.LastName,
                Email = resourceReadDto.Email,
                ResourceRoleId = resourceReadDto.ResourceRoleId
                // resource role <-- add this if needed
            }).ToList();
        }

    }
}
