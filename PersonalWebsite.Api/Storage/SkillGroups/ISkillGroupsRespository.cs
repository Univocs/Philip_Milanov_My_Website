using PersonalWebsite.Api.Domain.Skills;

namespace PersonalWebsite.Api.Storage.SkillGroups;

public interface ISkillGroupsRepository
{
  Task<IReadOnlyList<SkillGroup>> GetAllAsync();
  Task<SkillGroup?> GetByIdAsync(int id);
  Task<SkillGroup> AddAsync(SkillGroup skillgroup);
  Task<bool> DeleteAsync(int id);
}