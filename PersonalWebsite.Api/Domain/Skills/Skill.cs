namespace PersonalWebsite.Api.Domain.Skills;

public class Skill
{
  public int Id { get; set; }                 // primary key
  public int SkillGroupId { get; set; }       // foreign key
  public SkillGroup? SkillGroup { get; set; } // gets "SkillGroup"
  public required string Name { get; set; }   // name skill in group
  public required string Description { get; set; }
  public int DisplayOrder { get; set; }       // Order nr frontend
}