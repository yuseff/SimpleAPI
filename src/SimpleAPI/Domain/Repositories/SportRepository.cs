using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleAPI.Domain.Models;

namespace SimpleAPI.Domain.Repositories
{
    public interface ISportRepository
    {
         Task<IEnumerable<Sport>> ListAsync();
         Task AddAsync(Sport sport);
         Task<Sport> FindByIdAsync(int id);
         void Update(Sport sport);
         void Remove(Sport sport);
    }
}