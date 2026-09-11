namespace PersonalWebsite.Api.Domain.Skills;

public class SkillName
{
  public const int MaxLength = 100;
  public string Value { get; }

  public SkillName(string value)
  {
    var cleanName = value;
    if (string.IsNullOrWhiteSpace(cleanName)) throw new Exception("Skill name is required");
    cleanName = value.Trim(); // Can be upper and lower case!

    if (cleanName.Length > MaxLength) throw new Exception($"Skill name cannot be longer than {MaxLength} characters");
    Value = cleanName;
  }

  public static implicit operator string(SkillName name)
  {
    return name.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}