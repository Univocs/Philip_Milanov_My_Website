namespace PersonalWebsite.Api.Application.Careers;

public class AchievementSummary
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public required string Description { get; set; }
  public int Year { get; set; }
}