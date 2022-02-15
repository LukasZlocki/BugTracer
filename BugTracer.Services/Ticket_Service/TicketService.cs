using BugTracer.Data;
using BugTracer.Data.Models;

namespace BugTracer.Services.Ticket_Service
{
    public class TicketService : ITicketService
    {
        private readonly BugTracerDbContext _db;
        public TicketService(BugTracerDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Add new ticket record
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns>ServiceResponse<Ticket></returns>
        public ServiceResponse<Ticket> AddTicket(Ticket ticket)
        {
            try
            {
                _db.Tickets.Add(ticket);
                _db.SaveChanges();
                return new ServiceResponse<Ticket>
                {
                    IsSucess = true,
                    Message = "Ticket created",
                    Time = DateTime.UtcNow,
                    Data = ticket
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<Ticket> 
                { 
                    IsSucess = false, 
                    Message = e.StackTrace, 
                    Time = DateTime.UtcNow, 
                    Data = ticket
                };
            }
        }

        // READ
        /// <summary>
        /// Returns tickets object list refered to Project primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List<Ticket></tickets></returns>
        public List<Ticket> GetTicketsByProjectId(int id)
        {
            var service = _db.Tickets.Where(t => t.ProjectId == id).ToList();
            return service;
        }

        /// <summary>
        /// Returns ticket object by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns><Ticket></Ticket></returns>
        public Ticket GetTicketById(int id)
        {
            var service = _db.Tickets.Find(id);
            return service;
        }


        // UPDATE
        public ServiceResponse<bool> UpdateTicketStatuses(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        // DELETE
        /// <summary>
        /// Delete ticket by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteTicket(int id)
        {
            var ticket = _db.Tickets.Find(id);
            if(ticket == null)
            {
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "No ticket found.",
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
            try
            {
                _db.Tickets.Remove(ticket);
                _db.SaveChanges();
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = "Ticket removed",
                    Time = DateTime.UtcNow,
                    Data = true
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<bool>
                {
                    IsSucess = false,
                    Message = e.Message,
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
        }


    }
}
