namespace PersonalWebsite.Api.Domain.Careers;

public class Achievement
{
  public int Id { get; set; }
  public int CareerId { get; set; }
  public Career? Career { get; set; }
  public required AchievementTitle Title { get; set; }
  public required AchievementDescription Description { get; set; }
  public int Year { get; set; }
  public int DisplayOrder { get; set; }
}
