using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Infrastructure.Repositories
{
    public class ShuttleRepository : IShuttleRepository
    {
        private readonly IRepositoryAsync<Shuttle> _repository;
        public ShuttleRepository(IRepositoryAsync<Shuttle> repository)
        {
            _repository = repository;
        }

        public IQueryable<Shuttle> Shuttles => _repository.Entities;

        public async Task DeleteAsync(Shuttle shuttle)
        {
            await _repository.DeleteAsync(shuttle);
        }

        public async Task<Shuttle> GetByIdAsync(int id)
        {
            return await _repository.Entities.Where(p => p.ShuttleID == id).FirstOrDefaultAsync();
        }

        public async Task<List<Shuttle>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Shuttle shuttle)
        {
            await _repository.AddAsync(shuttle);
            return shuttle.ShuttleID;
        }

        public async Task UpdateAsync(Shuttle shuttle)
        {
            await _repository.UpdateAsync(shuttle);
        }
    }
}
