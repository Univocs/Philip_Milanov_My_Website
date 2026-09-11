namespace PersonalWebsite.Api.Domain.Mails;

public class ContactMessage
{
  public int Id { get; set; }
  public required ContactMessageName Name { get; set; }
  public required ContactMessageEmail Email { get; set; }
  public required ContactMessageText Message { get; set; }
  public DateTime SentAt { get; set; }
}