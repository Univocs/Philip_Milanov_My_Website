using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PersonalWebsite.Api.Application.Mails.GetContactMessageSummaries;

namespace PersonalWebsite.Api.Tests.IntegrationTests.Mails.GetContactMessageSummaries;

public class GetContactMessageSummariesTests
{
  private readonly WebApplicationFactory<Program> factory = new();

  [Fact]
  public async Task Get_ContactMessages_Returns_ContactMessages()
  {
    var client = factory.CreateClient();

    var response = await client.GetAsync("/contact-messages");
    var result = await response.Content.ReadFromJsonAsync<GetContactMessageSummariesResponse>();

    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

    Assert.NotNull(result);
    Assert.Empty(result.Items);
  }
}