using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PersonalWebsite.Api.Application.Careers.GetCareerSummaries;

namespace PersonalWebsite.Api.Tests.IntegrationTests.Careers.GetCareerSummaries;

public class GetCareerSummariesTests
{
  private readonly WebApplicationFactory<Program> factory = new();

  [Fact]
  public async Task Get_Careers_Returns_Careers()
  {
    var client = factory.CreateClient();

    var response = await client.GetAsync("/careers");
    var result = await response.Content.ReadFromJsonAsync<GetCareerSummariesResponse>();

    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

    Assert.NotNull(result);
    Assert.Empty(result.Items);
  }
}