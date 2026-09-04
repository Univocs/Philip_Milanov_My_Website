namespace PersonalWebsite.Api.Domain.Careers;

public class Career
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public required string Description { get; set; }
  public int StartYear { get; set; }
  public int? EndYear { get; set; }
  public int DisplayOrder { get; set; }
  public string? KeySkills { get; set; }
  public ICollection<Achievement> Achievements { get; set; } = [];
}