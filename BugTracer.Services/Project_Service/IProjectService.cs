using BugTracer.Data.Models;

namespace BugTracer.Services.Project_Service
{
    public interface IProjectService
    {
        // CREATE
        public ServiceResponse<Project> AddProject(Project project);

        // READ
        public List<Project> GetAllProjectsBasicData();
        public Project GetProjectById(int id);

        // UPDATE
        public ServiceResponse<bool> UpdateProject(Project project);

        // DELETE
        public ServiceResponse<bool> DeleteProject(int id);
    }
}
