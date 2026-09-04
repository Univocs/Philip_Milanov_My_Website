using PersonalWebsite.Api.Domain.Projects;

namespace PersonalWebsite.Api.Storage.Projects;

public interface IProjectsRepository
{
  Task<IReadOnlyList<Project>> GetAllAsync();
  Task<Project?> GetByIdAsync(int id);
  Task<Project> AddAsync(Project project);
  Task<bool> DeleteAsync(int id);
}