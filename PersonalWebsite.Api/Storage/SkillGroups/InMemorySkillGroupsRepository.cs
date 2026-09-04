using PersonalWebsite.Api.Domain.Skills;

namespace PersonalWebsite.Api.Storage.SkillGroups;

public class InMemorySkillGroupsRepository : ISkillGroupsRepository
{
  private readonly List<SkillGroup> skillGroups = [];
  private int nextId = 1;

  public Task<IReadOnlyList<SkillGroup>> GetAllAsync()
  {
    return Task.FromResult<IReadOnlyList<SkillGroup>>(skillGroups);
  }

  public Task<SkillGroup?> GetByIdAsync(int id)
  {
    var skillGroup = skillGroups.FirstOrDefault(skillGroup => skillGroup.Id == id);
    return Task.FromResult(skillGroup);
  }

  public Task<SkillGroup> AddAsync(SkillGroup skillGroup)
  {
    skillGroup.Id = nextId;
    nextId++;
    skillGroups.Add(skillGroup);
    return Task.FromResult(skillGroup);
  }

  public Task<bool> DeleteAsync(int id)
  {
    var skillGroup = skillGroups.FirstOrDefault(skillGroup => skillGroup.Id == id);
    if (skillGroup is null) return Task.FromResult(false);
    skillGroups.Remove(skillGroup);
    return Task.FromResult(true);
  }
}