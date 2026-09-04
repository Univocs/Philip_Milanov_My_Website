using PersonalWebsite.Api.Domain.Projects;

namespace PersonalWebsite.Api.Storage.Projects;

public class InMemoryProjectsRepository : IProjectsRepository
{
  private readonly List<Project> projects = [];
  private int nextId = 1;

  public Task<IReadOnlyList<Project>> GetAllAsync()
  {
    return Task.FromResult<IReadOnlyList<Project>>(projects);
  }

  public Task<Project?> GetByIdAsync(int id)
  {
    var project = projects.FirstOrDefault(project => project.Id == id);
    return Task.FromResult(project);
  }

  public Task<Project> AddAsync(Project project)
  {
    project.Id = nextId;
    nextId++;
    projects.Add(project);
    return Task.FromResult(project);
  }

  public Task<bool> DeleteAsync(int id)
  {
    var project = projects.FirstOrDefault(project => project.Id == id);
    if (project is null) return Task.FromResult(false);
    projects.Remove(project);
    return Task.FromResult(true);
  }
}