namespace PersonalWebsite.Api.Domain.User;

public class UserEmail
{
  public const int MaxLength = 200;
  public string Value { get; }

  public UserEmail(string value)
  {
    var cleanMail = value;
    if (string.IsNullOrWhiteSpace(cleanMail)) throw new Exception("Member email is required");
    cleanMail = value.Trim().ToLowerInvariant(); // email all lowercase! 

    if (cleanMail.Length > MaxLength) throw new Exception($"User email cannot be longer than {MaxLength} characters!");
    if (!cleanMail.Contains('@')) throw new Exception("User email must contain '@'!");
    Value = cleanMail;
  }

  //----------------------------------------------------------------

  public static implicit operator string(UserEmail email)
  {
    return email.Value;
  } // The value can now be used as string => "member.email.value" becomes "member.email"

  //------------------------------------------------------------------
  
  public override string ToString()
  {
    return Value;
  }
}