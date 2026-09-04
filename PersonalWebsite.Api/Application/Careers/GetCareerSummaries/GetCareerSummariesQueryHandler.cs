using PersonalWebsite.Api.Storage.Careers;

namespace PersonalWebsite.Api.Application.Careers.GetCareerSummaries;

public class GetCareerSummariesQueryHandler(ICareersRepository careersRepository)
{
  public async Task<GetCareerSummariesResponse> Execute()
  {
    var careers = await careersRepository.GetAllAsync();
    var summaries = careers.Select(career => new CareerSummary
    {
      Id = career.Id,
      Title = career.Title,
      Description = career.Description,
      StartYear = career.StartYear,
      EndYear = career.EndYear,
      KeySkills = career.KeySkills,
      Achievements = career.Achievements.Select(achievement => new AchievementSummary
      {
        Id = achievement.Id,
        Title = achievement.Title,
        Description = achievement.Description,
        Year = achievement.Year
      }).ToList()
    }).ToList();

    return new GetCareerSummariesResponse { Items = summaries };
  }
}