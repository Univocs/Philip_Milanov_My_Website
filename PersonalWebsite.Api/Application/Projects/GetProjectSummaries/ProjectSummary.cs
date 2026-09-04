namespace PersonalWebsite.Api.Application.Projects;

public class ProjectSummary
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public required string Description { get; set; }
  public string? ProjectUrl { get; set; }
  public required IList<TagSummary> Tags { get; set; }
}