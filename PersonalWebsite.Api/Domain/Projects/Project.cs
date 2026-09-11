namespace PersonalWebsite.Api.Domain.Projects;

public class Project
{
  public int Id { get; set; }
  public required ProjectTitle Title { get; set; }
  public required ProjectDescription Description { get; set; }
  public string? ProjectUrl { get; set; }
  public ICollection<Tag> Tags { get; set; } = [];
  public int DisplayOrder { get; set; }
}