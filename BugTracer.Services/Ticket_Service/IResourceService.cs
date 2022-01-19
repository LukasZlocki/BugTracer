using BugTracer.Data.Models;

namespace BugTracer.Services.Ticket_Service
{
    public interface IResourceService
    {
        // CREATE
        public ServiceResponse<Resource> CreateResource(int id);

        // READ
        public List<Resource> GetAllResources();
        public Resource GetresourceById(int id);
        
        // UPDATE
        public ServiceResponse<bool> UpdateResource(Resource resource);

        // DELETE
        public ServiceResponse<bool> DeleteResource(int id);
    }
}
