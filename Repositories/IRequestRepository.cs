using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStartApp.Repositories
{
    public interface IRequestRepository
    {
        Task LogRequest(string url);
        Task<Request[]> GetRequests();
    }
}
