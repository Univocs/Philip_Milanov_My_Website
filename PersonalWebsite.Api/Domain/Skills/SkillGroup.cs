namespace PersonalWebsite.Api.Domain.Skills;

public class SkillGroup
{
  public int Id { get; set; }                            // primary key
  public required string Name { get; set; }              // name group
  public int DisplayOrder { get; set; }                  // order nr frontend
  public ICollection<Skill> Skills { get; set; } = [];   // gets list of "Skill"s
}