namespace PersonalWebsite.Api.Application.Skills.GetSkillGroupSummaries;

public class GetSkillGroupSummariesResponse
{
  public required IReadOnlyList<SkillGroupSummary> Items { get; set; }
}