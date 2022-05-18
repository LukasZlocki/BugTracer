using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class PriorityMapper
    {
        public static TicketPriorityReadDto SerializeTicketPriorityModelToTickePriorityReadDtoModel(TicketPriority priority )
        {
            return new TicketPriorityReadDto
            {
                PriorityId = priority.PriorityId,
                Priority = priority.Priority
            };
        }
    }
}
