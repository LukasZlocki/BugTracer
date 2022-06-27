using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class ResourceRoleMapper
    {

        public static ResourceRoleReadDto SerializeResourceRoleModelToResourceRoleReadDtoModel(ResourceRole role)
        {
            return new ResourceRoleReadDto
            {
                ResourceRoleId = role.ResourceRoleId,
                Role = role.Role
            };
        }

    }
}
