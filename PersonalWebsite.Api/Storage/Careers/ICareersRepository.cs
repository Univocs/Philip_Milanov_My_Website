using PersonalWebsite.Api.Domain.Careers;

namespace PersonalWebsite.Api.Storage.Careers;

public interface ICareersRepository
{
  Task<IReadOnlyList<Career>> GetAllAsync();
  Task<Career?> GetByIdAsync(int id);
  Task<Career> AddAsync(Career career);
  Task<bool> DeleteAsync(int id);
}