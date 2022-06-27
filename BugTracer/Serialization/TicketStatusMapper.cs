using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
{
    public class TicketStatusMapper
    {
        public static TaskStatusReadDto SerializeStatusModelToStatusReadDtoModel(TicketStatus status)
        {
            return new TaskStatusReadDto
            {
                StatusId = status.StatusId,
                Status = status.Status
            };
        }

    }
}
