namespace PersonalWebsite.Api.Domain.Projects;

public class ProjectTitle
{
  public const int MaxLength = 100;
  public string Value { get; }

  public ProjectTitle(string value)
  {
    var cleanTitle = value;
    if (string.IsNullOrWhiteSpace(cleanTitle)) throw new Exception("Project title is required");
    cleanTitle = value.Trim(); // Can be upper and lower case!

    if (cleanTitle.Length > MaxLength) throw new Exception($"Project title cannot be longer than {MaxLength} characters");
    Value = cleanTitle;
  }

  public static implicit operator string(ProjectTitle title)
  {
    return title.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}