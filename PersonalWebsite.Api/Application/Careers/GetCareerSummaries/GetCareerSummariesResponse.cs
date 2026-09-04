namespace PersonalWebsite.Api.Application.Careers.GetCareerSummaries;

public class GetCareerSummariesResponse
{
  public required IReadOnlyList<CareerSummary> Items { get; set; }
}