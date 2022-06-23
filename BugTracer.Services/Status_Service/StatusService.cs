using BugTracer.Data;
using BugTracer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services.Status_Service
{
    public class StatusService : IStatusService
    {
        private readonly BugTracerDbContext _db;

        public StatusService(BugTracerDbContext db)
        {
            _db = db;
        }

        List<TicketStatus> IStatusService.GetAllStatuses()
        {
            var service = _db.TicketStatuses.ToList();
            return service;
        }


        public TicketStatus GetStatusById(int id)
        {
            var service = _db.TicketStatuses.Find(id);
            return service;
        }


    }
}
