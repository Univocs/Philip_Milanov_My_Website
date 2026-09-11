namespace PersonalWebsite.Api.Domain.Careers;

public class AchievementTitle
{
  public const int MaxLength = 100;
  public string Value { get; }

  public AchievementTitle(string value)
  {
    var cleanTitle = value;
    if (string.IsNullOrWhiteSpace(cleanTitle)) throw new Exception("Achievement title is required");
    cleanTitle = value.Trim(); // Can be upper and lower case!

    if (cleanTitle.Length > MaxLength) throw new Exception($"Achievement title cannot be longer than {MaxLength} characters");
    Value = cleanTitle;
  }

  public static implicit operator string(AchievementTitle title)
  {
    return title.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}