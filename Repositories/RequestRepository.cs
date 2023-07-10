using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using System;
using System.Threading.Tasks;

namespace MvcStartApp.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BlogContext _context;

        public RequestRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task LogRequest(string url)
        {
            var request = new Request
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Url = url
            };

            _context.Requests.Add(request);
            await _context.SaveChangesAsync();
        }
        public async Task<Request[]> GetRequests()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}
