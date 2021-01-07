using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Interfaces.Repositories
{
    public interface IFitnessTestRepository
    {

        IQueryable<FitnessTest> Fitness { get; }

        Task<List<FitnessTest>> GetListAsync();

        Task<FitnessTest> GetByIdAsync(int productId);

        Task<int> InsertAsync(FitnessTest fitness);

        Task UpdateAsync(FitnessTest fitness);

        Task DeleteAsync(FitnessTest fitness);
    }
}
