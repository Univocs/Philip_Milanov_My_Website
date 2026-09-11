namespace PersonalWebsite.Api.Domain.Mails;

public class ContactMessageName
{
  public const int MaxLength = 100;
  public string Value { get; }

  public ContactMessageName(string value)
  {
    var cleanName = value;
    if (string.IsNullOrWhiteSpace(cleanName)) throw new Exception("Name is required");
    cleanName = value.Trim(); // Can be upper and lower case!

    if (cleanName.Length > MaxLength) throw new Exception($"Name cannot be longer than {MaxLength} characters");
    Value = cleanName;
  }

  public static implicit operator string(ContactMessageName name)
  {
    return name.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}