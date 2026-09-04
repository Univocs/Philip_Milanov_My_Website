namespace PersonalWebsite.Api.Application.Projects.GetProjectSummaries;

public class GetProjectSummariesResponse
{
  public required IReadOnlyList<ProjectSummary> Items { get; set; }
}