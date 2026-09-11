namespace PersonalWebsite.Api.Domain.Skills;

public class SkillDescription
{
  public const int MaxLength = 500;
  public string Value { get; }

  public SkillDescription(string value)
  {
    var cleanDescription = value;
    if (string.IsNullOrWhiteSpace(cleanDescription)) throw new Exception("Skill description is required");
    cleanDescription = value.Trim();

    if (cleanDescription.Length > MaxLength) throw new Exception($"Skill description cannot be longer than {MaxLength} characters");
    Value = cleanDescription;
  }

  public static implicit operator string(SkillDescription description)
  {
    return description.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}