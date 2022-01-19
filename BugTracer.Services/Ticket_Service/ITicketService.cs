using BugTracer.Data.Models;

namespace BugTracer.Services.Ticket_Service
{
    public interface ITicketService
    {
        // CREATE
        public ServiceResponse<Ticket> AddTicket(Ticket ticket);

        // READ
        public List<Ticket> GetTicketsByProjectId(int id);

        // UPDATE
        public ServiceResponse<bool> UpdateTicketStatuses(Ticket ticket);

        // DELETE
        public ServiceResponse<bool> DeleteTicket(int id);
    }
}
