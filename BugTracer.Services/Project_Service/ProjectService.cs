using BugTracer.Data;
using BugTracer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracer.Services.Project_Service
{
    public class ProjectService : IProjectService
    {
        private readonly BugTracerDbContext _db;

        public ProjectService(BugTracerDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Add new project record
        /// </summary>
        /// <param name="project">Project instance</param>
        /// <returns>ServiceResponse<Project></returns>
        public ServiceResponse<Project> AddProject(Project project)
        {
            try
            {
                _db.Projects.Add(project);
                _db.SaveChanges();
                return new ServiceResponse<Project>
                {
                    IsSucess = true,
                    Message = "Project added",
                    Time = DateTime.UtcNow,
                    Data = project
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Project>
                { 
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = project    
                };
            }
        }

        // READ
        /// <summary>
        /// returns list of Projects
        /// </summary>
        /// <returns>List<Project></Project></returns>
        public List<Project> GetAllProjects()
        {
            var service = _db.Projects.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Returns Project object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Project></returns>
        public Project GetProjectById(int id)
        {
            var service = _db.Projects
                    .FirstOrDefault(x => x.Id == id);
            return service;
        }

        // UPDATE
        public ServiceResponse<bool> UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        // DELETE
        /// <summary>
        /// Delete project object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteProject(int id)
        {
            var project = _db.Projects.Find(id);
            if (project == null)
            {
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "No project found",
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
            try
            {
                _db.Projects.Remove(project);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSucess = true,
                    Message = "Project removed.",
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch (Exception e)
            {
                Console.WriteLine("Erron, not able to remove project.");
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = false
                };

            }
        }


    }
}
