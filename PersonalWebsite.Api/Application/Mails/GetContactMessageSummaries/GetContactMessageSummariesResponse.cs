namespace PersonalWebsite.Api.Application.Mails.GetContactMessageSummaries;

public class GetContactMessageSummariesResponse
{
  public required IReadOnlyList<ContactMessageSummary> Items { get; set; }
}