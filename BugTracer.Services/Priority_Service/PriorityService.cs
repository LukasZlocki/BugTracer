using BugTracer.Data;
using BugTracer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services.Priority_Service
{
    public class PriorityService : IPriorityService
    {
        private readonly BugTracerDbContext _db;

        public PriorityService(BugTracerDbContext db)
        {
            _db = db;    
        }
        
        // READ
        /// <summary>
        /// Returns priority list 
        /// </summary>
        /// <returns>List<TicketPriority></returns>
        public List<TicketPriority> GetAllPriorities()
        {
            var service = _db.TicketPriorities.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Returns priority object by its primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TicketPriority GetPriorityById(int id)
        {
            var service = _db.TicketPriorities.Find(id);
            return service;
        }
    }
}
