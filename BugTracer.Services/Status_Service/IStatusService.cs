using BugTracer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracer.Services.Status_Service
{
    public interface IStatusService
    {

        // READ
        public TicketStatus GetStatusById(int id);
        public List<TicketStatus> GetAllStatuses();

    }
}
