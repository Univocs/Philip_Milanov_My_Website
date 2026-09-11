namespace PersonalWebsite.Api.Domain.Mails;

public class ContactMessageText
{
  public const int MaxLength = 1000;
  public string Value { get; }

  public ContactMessageText(string value)
  {
    var cleanMessage = value;
    if (string.IsNullOrWhiteSpace(cleanMessage)) throw new Exception("Message is required");
    cleanMessage = value.Trim(); // Can be upper and lower case!

    if (cleanMessage.Length > MaxLength) throw new Exception($"Message cannot be longer than {MaxLength} characters");
    Value = cleanMessage;
  }

  public static implicit operator string(ContactMessageText message)
  {
    return message.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}