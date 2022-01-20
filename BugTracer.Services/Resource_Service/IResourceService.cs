using BugTracer.Data.Models;

namespace BugTracer.Services.Resource_Service
{
    public interface IResourceService
    {
        // CREATE
        public ServiceResponse<Resource> CreateResource(Resource resource);

        // READ
        public List<Resource> GetAllResources();
        public Resource GetResourceById(int id);
        
        // UPDATE
        public ServiceResponse<bool> UpdateResource(Resource resource);

        // DELETE
        public ServiceResponse<bool> DeleteResource(int id);
    }
}
