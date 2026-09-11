namespace PersonalWebsite.Api.Domain.Careers;

public class CareerDescription
{
  public const int MaxLength = 500;
  public string Value { get; }

  public CareerDescription(string value)
  {
    var cleanDescription = value;
    if (string.IsNullOrWhiteSpace(cleanDescription)) throw new Exception("Career description is required");
    cleanDescription = value.Trim(); // Can be upper and lower case!

    if (cleanDescription.Length > MaxLength) throw new Exception($"Career description cannot be longer than {MaxLength} characters");
    Value = cleanDescription;
  }

  public static implicit operator string(CareerDescription description)
  {
    return description.Value;
  }

  public override string ToString()
  {
    return Value;
  }
}