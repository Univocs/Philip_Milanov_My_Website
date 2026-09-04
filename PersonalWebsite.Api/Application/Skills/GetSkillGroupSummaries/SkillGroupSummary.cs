namespace PersonalWebsite.Api.Application.Skills;

public class SkillGroupSummary
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required List<SkillSummary> Skills { get; set; }
}