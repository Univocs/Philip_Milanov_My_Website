namespace PersonalWebsite.Api.Domain.Projects;

public class Tag
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public ICollection<Project> Projects { get; set; } = [];
}