using BugTracer.Data;
using BugTracer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services.Resource_Service
{
    public class ResourceService : IResourceService
    {
        private readonly BugTracerDbContext _db;
        public ResourceService(BugTracerDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Add a new recorce record
        /// </summary>
        /// <param name="resource"></param>
        /// <returns>ServiceResponse<Resource></returns>
        public ServiceResponse<Resource> CreateResource(Resource resource)
        {
            try
            {
                _db.Resources.Add(resource);
                _db.SaveChanges();
                return new ServiceResponse<Resource>
                {
                    IsSucess = true,
                    Message = "Resource created",
                    Time = DateTime.UtcNow,
                    Data = resource
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<Resource> 
                {
                    IsSucess = false, 
                    Message = e.Message,
                    Time = DateTime.UtcNow,
                    Data = resource
                };
            }
        }

        // READ
        /// <summary>
        /// Returns list with all resources
        /// </summary>
        /// <returns>List<Resources></returns>
        public List<Resource> GetAllResources()
        {
            var service = _db.Resources.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Returns resource object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns><Resource></Resource></returns>
        public Resource GetResourceById(int id)
        {
            var service = _db.Resources.Find(id);
            return service;
        }

        // UPDATE
        public ServiceResponse<bool> UpdateResource(Resource resource)
        {
            throw new NotImplementedException();
        }

        // DELETE
        /// <summary>
        /// Deletes resource object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteResource(int id)
        {
            var resource = _db.Resources.Find(id);
            if (resource == null)
            {
                Console.WriteLine("No resource found.");
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "No resource found.",
                    Time= DateTime.UtcNow,
                    Data = false                
                };
            }
            try
            {
                _db.Resources.Remove(resource);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "Resource removed.",
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch(Exception e)
            {
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
