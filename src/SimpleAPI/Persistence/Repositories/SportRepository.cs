using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleAPI.Domain.Models;
using SimpleAPI.Domain.Repositories;
using SimpleAPI.Persistence.Contexts;

namespace SimpleAPI.Persistence.Repositories
{
    public class SportRepository : BaseRepository, ISportRepository
    {
        public SportRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Sport>> ListAsync()
        {
            return await _context.Sports.ToListAsync();
        }

        public async Task AddAsync(Sport sport)
	    {
		    await _context.Sports.AddAsync(sport);
	    }

        public async Task<Sport> FindByIdAsync(int id)
        {
            return await _context.Sports.FindAsync(id);
        }

        public void Update(Sport sport)
        {
            _context.Sports.Update(sport);
        }

        public void Remove(Sport sport)
        {
            _context.Sports.Remove(sport);
        }
    }
}