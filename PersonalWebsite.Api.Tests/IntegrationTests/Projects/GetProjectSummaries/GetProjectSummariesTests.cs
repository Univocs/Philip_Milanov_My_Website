using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PersonalWebsite.Api.Application.Projects.GetProjectSummaries;

namespace PersonalWebsite.Api.Tests.IntegrationTests.Projects.GetProjectSummaries;

public class GetProjectSummariesTests
{
  private readonly WebApplicationFactory<Program> factory = new();

  [Fact]
  public async Task Get_Projects_Returns_Projects()
  {
    var client = factory.CreateClient();

    var response = await client.GetAsync("/projects");
    var result = await response.Content.ReadFromJsonAsync<GetProjectSummariesResponse>();

    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

    Assert.NotNull(result);
    Assert.Empty(result.Items);
  }
}