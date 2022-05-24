using BugTracer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services.Priority_Service
{
    public interface IPriorityService
    {
        // READ
        public List<TicketPriority> GetAllPriorities();

        // READ
        public TicketPriority GetPriorityById(int id);

    }
}
