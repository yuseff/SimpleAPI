using System.Threading.Tasks;

namespace SimpleAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}