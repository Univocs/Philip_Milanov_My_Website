namespace PersonalWebsite.Api.Domain.Projects;

public class ProjectDescription
{
  public const int MaxLength = 500;
  public string Value { get; }

  public ProjectDescription(string value)
  {
    var cleanDescription = value;
    if (string.IsNullOrWhiteSpace(cleanDescription)) throw new Exception("Project description is required");
    cleanDescription = value.Trim(); // Can be upper and lower case!

    if (cleanDescription.Length > MaxLength) throw new Exception($"Project description cannot be longer than {MaxLength} characters");
    Value = cleanDescription;
  }

  public static implicit operator string(ProjectDescription description)
  {
    return description.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}