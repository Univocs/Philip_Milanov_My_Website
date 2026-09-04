namespace PersonalWebsite.Api.Application.Careers;

public class CareerSummary
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public required string Description { get; set; }
  public int StartYear { get; set; }
  public int? EndYear { get; set; }
  public string? KeySkills { get; set; }
  public required List<AchievementSummary> Achievements { get; set; }
}