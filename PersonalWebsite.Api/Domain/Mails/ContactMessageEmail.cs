namespace PersonalWebsite.Api.Domain.Mails;

public class ContactMessageEmail
{
  public const int MaxLength = 200;
  public string Value { get; }

  public ContactMessageEmail(string value)
  {
    var cleanMail = value;
    if (string.IsNullOrWhiteSpace(cleanMail)) throw new Exception("Contact email is required");
    cleanMail = value.Trim().ToLowerInvariant(); // email all lowercase! 

    if (cleanMail.Length > MaxLength) throw new Exception($"Contact email cannot be longer than {MaxLength} characters!");
    if (!cleanMail.Contains('@')) throw new Exception("Contact email must contain '@'!");
    Value = cleanMail;
  }

  public static implicit operator string(ContactMessageEmail email)
  {
    return email.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}