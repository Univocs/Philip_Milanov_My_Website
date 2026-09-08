using PersonalWebsite.Api.Storage.ContactMessages;

namespace PersonalWebsite.Api.Application.Mails.GetContactMessageSummaries;

public class GetContactMessageSummariesQueryHandler(IContactMessagesRepository contactMessagesRepository)
{
  public async Task<GetContactMessageSummariesResponse> Execute()
  {
    var contactMessages = await contactMessagesRepository.GetAllAsync();
    var summaries = contactMessages.Select(cm => new ContactMessageSummary
    {
      Id = cm.Id,
      Name = cm.Name,
      Email = cm.Email,
      Message = cm.Message,
      SentAt = cm.SentAt
    }).ToList();

    return new GetContactMessageSummariesResponse { Items = summaries };
  }
}