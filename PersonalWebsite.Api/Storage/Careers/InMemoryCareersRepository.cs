using PersonalWebsite.Api.Domain.Careers;

namespace PersonalWebsite.Api.Storage.Careers;

public class InMemoryCareersRepository : ICareersRepository
{
  private readonly List<Career> careers = [];
  private int nextId = 1;

  public Task<IReadOnlyList<Career>> GetAllAsync()
  {
    return Task.FromResult<IReadOnlyList<Career>>(careers);
  }

  public Task<Career?> GetByIdAsync(int id)
  {
    var career = careers.FirstOrDefault(career => career.Id == id);
    return Task.FromResult(career);
  }

  public Task<Career> AddAsync(Career career)
  {
    career.Id = nextId;
    nextId++;
    careers.Add(career);
    return Task.FromResult(career);
  }

  public Task<bool> DeleteAsync(int id)
  {
    var career = careers.FirstOrDefault(career => career.Id == id);
    if (career is null) return Task.FromResult(false);
    careers.Remove(career);
    return Task.FromResult(true);
  }
}