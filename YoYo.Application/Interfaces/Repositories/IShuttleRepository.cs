using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Interfaces.Repositories
{
    public interface IShuttleRepository
    {

        IQueryable<Shuttle> Shuttles { get; }

        Task<List<Shuttle>> GetListAsync();

        Task<Shuttle> GetByIdAsync(int Id);

        Task<int> InsertAsync(Shuttle shuttle);

        Task UpdateAsync(Shuttle shuttle);

        Task DeleteAsync(Shuttle shuttle);
    }
}
