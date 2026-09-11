namespace PersonalWebsite.Api.Domain.Careers;

public class CareerTitle
{
  public const int MaxLength = 100;
  public string Value { get; }

  public CareerTitle(string value)
  {
    var cleanTitle = value;
    if (string.IsNullOrWhiteSpace(cleanTitle)) throw new Exception("Career title is required");
    cleanTitle = value.Trim(); // Can be upper and lower case!

    if (cleanTitle.Length > MaxLength) throw new Exception($"Career title cannot be longer than {MaxLength} characters");
    Value = cleanTitle;
  }

  public static implicit operator string(CareerTitle title)
  {
    return title.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}