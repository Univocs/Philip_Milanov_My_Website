namespace PersonalWebsite.Api.Domain.Skills;

public class SkillGroupName
{
  public const int MaxLength = 100;
  public string Value { get; }

  public SkillGroupName(string value)
  {
    var cleanName = value;
    if (string.IsNullOrWhiteSpace(cleanName)) throw new Exception("SkillGroup name is required");
    cleanName = value.Trim(); // Can be upper and lower case!

    if (cleanName.Length > MaxLength) throw new Exception($"SkillGroup name cannot be longer than {MaxLength} characters");
    Value = cleanName;
  }

  public static implicit operator string(SkillGroupName name)
  {
    return name.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}