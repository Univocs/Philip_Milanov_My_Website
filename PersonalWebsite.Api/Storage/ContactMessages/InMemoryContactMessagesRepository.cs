using PersonalWebsite.Api.Domain.Mails;

namespace PersonalWebsite.Api.Storage.ContactMessages;

public class InMemoryContactMessagesRepository : IContactMessagesRepository
{
  private readonly List<ContactMessage> contactMessages = [];
  private int nextId = 1;

  public Task<IReadOnlyList<ContactMessage>> GetAllAsync()
  {
    return Task.FromResult<IReadOnlyList<ContactMessage>>(contactMessages);
  }

  public Task<ContactMessage?> GetByIdAsync(int id)
  {
    var contactMessage = contactMessages.FirstOrDefault(cm => cm.Id == id);
    return Task.FromResult(contactMessage);
  }

  public Task<ContactMessage> AddAsync(ContactMessage contactMessage)
  {
    contactMessage.Id = nextId;
    nextId++;
    contactMessages.Add(contactMessage);
    return Task.FromResult(contactMessage);
  }

  public Task<bool> DeleteAsync(int id)
  {
    var contactMessage = contactMessages.FirstOrDefault(cm => cm.Id == id);
    if (contactMessage is null) return Task.FromResult(false);
    contactMessages.Remove(contactMessage);
    return Task.FromResult(true);
  }
}