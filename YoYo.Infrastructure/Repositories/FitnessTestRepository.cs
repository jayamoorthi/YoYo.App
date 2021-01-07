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
    public class FitnessTestRepository : IFitnessTestRepository
    {
        private readonly IRepositoryAsync<FitnessTest> _repository;
        public FitnessTestRepository( IRepositoryAsync<FitnessTest> repository)
        {
            _repository = repository;
        }

        public IQueryable<FitnessTest> Fitness => _repository.Entities;

        public async Task DeleteAsync(FitnessTest fitness)
        {
            await _repository.DeleteAsync(fitness);
        }

        public async Task<FitnessTest> GetByIdAsync(int id)
        {
            return await _repository.Entities.Where(p => p.FitnessTestID == id).FirstOrDefaultAsync();
        }

        public async Task<List<FitnessTest>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(FitnessTest fitnessTest)
        {
            await _repository.AddAsync(fitnessTest);
            return fitnessTest.FitnessTestID;
        }

        public async Task UpdateAsync(FitnessTest fitness)
        {
            await _repository.UpdateAsync(fitness);
        }
    }
}
