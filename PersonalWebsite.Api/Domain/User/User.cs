namespace PersonalWebsite.Api.Domain.User;

public class User
{
  public int Id { get; set; }
  public required UserEmail Email { get; set; }
  // Entity does not contain password property (in CreateMemberRequest), only hash!
  public string PasswordHash { get; set; } = string.Empty;
}