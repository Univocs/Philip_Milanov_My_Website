using PersonalWebsite.Api.Domain.Mails;

namespace PersonalWebsite.Api.Storage.ContactMessages;

public interface IContactMessagesRepository
{
  Task<IReadOnlyList<ContactMessage>> GetAllAsync();
  Task<ContactMessage?> GetByIdAsync(int id);
  Task<ContactMessage> AddAsync(ContactMessage contactMessage);
  Task<bool> DeleteAsync(int id);
}