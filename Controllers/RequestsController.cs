using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Repositories;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IRequestRepository _repo;

        public RequestsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _repo.GetRequests();
            return View(requests);
        }
    }
}
