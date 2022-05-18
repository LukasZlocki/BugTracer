using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Serialization
{
    public class StatusMapper
    {
        public static TicketStatusReadDto SerializeTicketStatusModelToTicketStatusReadDtoModel(TicketStatus status)
        {
            return new TicketStatusReadDto
            {
                StatusId = status.StatusId,
                Status = status.Status
            };
        }
        
    }
}