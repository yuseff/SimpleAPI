using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleAPI.Domain.Models;
using SimpleAPI.Domain.Services.Communication;

namespace SimpleAPI.Domain.Services
{
    public interface ISportService
    {
         Task<IEnumerable<Sport>> ListAsync();
         Task<SportResponse> SaveAsync(Sport sport);
         Task<SportResponse> UpdateAsync(int id, Sport sport);
         Task<SportResponse> DeleteAsync(int id);
    }
}