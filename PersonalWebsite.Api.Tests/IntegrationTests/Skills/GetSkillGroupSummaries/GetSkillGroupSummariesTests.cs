using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PersonalWebsite.Api.Application.Skills.GetSkillGroupSummaries;

namespace PersonalWebsite.Api.Tests.IntegrationTests.Skills.GetSkillGroupSummaries;

public class GetSkillGroupSummariesTests
{
  private readonly WebApplicationFactory<Program> factory = new();

  [Fact]
  public async Task Get_SkillGroups_Returns_SkillGroups()
  {
    var client = factory.CreateClient();

    var response = await client.GetAsync("/skill-groups");
    var result = await response.Content.ReadFromJsonAsync<GetSkillGroupSummariesResponse>();

    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

    Assert.NotNull(result);
    Assert.Empty(result.Items);
  }
}