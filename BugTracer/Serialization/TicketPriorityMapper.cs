using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class TicketPriorityMapper
    {

        public static TaskPriorityReadDto SerializeTicketPriorityModelToTicketPriorityReadDtoModel(TicketPriority priority)
        {
            return new TaskPriorityReadDto
            {
                PriorityId = priority.PriorityId,
                Priority = priority.Priority
            };
        }

    }
}
