using PersonalWebsite.Api.Storage.SkillGroups;

namespace PersonalWebsite.Api.Application.Skills.GetSkillGroupSummaries;

public class GetSkillGroupSummariesQueryHandler(ISkillGroupsRepository skillGroupsRepository)
{
  public async Task<GetSkillGroupSummariesResponse> Execute()
  {
    var skillGroups = await skillGroupsRepository.GetAllAsync();
    var summaries = skillGroups.Select(career => new SkillGroupSummary
    {
      Id = career.Id,
      Name = career.Name,
      Skills = career.Skills.Select(skill => new SkillSummary
      {
        Id = skill.Id,
        Name = skill.Name,
        Description = skill.Description ?? string.Empty  // ?? reads as == if null, then string.Empty
                  //  same as skill.Description == null ? string.Empty : skill.Description
      }).ToList()
    }).ToList();
    return new GetSkillGroupSummariesResponse { Items = summaries };
  }
}