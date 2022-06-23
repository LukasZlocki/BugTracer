using BugTracer.Api.Dtos;
using BugTracer.Data.Models;

namespace BugTracer.Api.Serialization
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

        public static List<TicketStatusReadDto> SerializeListOfTicketStatusModelsToListOfTicketStatusReadDtoModels(IEnumerable<TicketStatus> statuses)
        {
            return statuses.Select(t => new TicketStatusReadDto
            {
                StatusId = t.StatusId,
                Status = t.Status,
            }).ToList();
        }
        
    }
}