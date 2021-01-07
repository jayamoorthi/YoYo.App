using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoYo.Domain.Entities.YoYoPerson;

namespace YoYo.Application.Interfaces.Repositories
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }

        Task<List<Person>> GetListAsync();

        Task<Person> GetByIdAsync(int Id);

        Task<int> InsertAsync(Person person);

        Task UpdateAsync(Person person);

        Task DeleteAsync(Person person);
    }
}
