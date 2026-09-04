using PersonalWebsite.Api.Storage.Projects;

namespace PersonalWebsite.Api.Application.Projects.GetProjectSummaries;

public class GetProjectSummariesQueryHandler(IProjectsRepository projectsRepository)
{
  public async Task<GetProjectSummariesResponse> Execute()
  {
    var projects = await projectsRepository.GetAllAsync();
     var summaries = projects.Select(project => new ProjectSummary
    {
      Id = project.Id,
      Title = project.Title,
      Description = project.Description,
      ProjectUrl = project.ProjectUrl,
      Tags = project.Tags.Select(tag => new TagSummary
      {
        Id = tag.Id,
        Name = tag.Name
      }).ToList()
    }).ToList();

    return new GetProjectSummariesResponse { Items = summaries };
  }
}