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
    public class PersonRepository : IPersonRepository
    {
        private readonly IRepositoryAsync<Person> _repository;
        public PersonRepository(IRepositoryAsync<Person> repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> Persons => _repository.Entities;

        public async Task DeleteAsync(Person person)
        {
            await _repository.DeleteAsync(person);
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _repository.Entities.Where(p => p.PersonID == id).FirstOrDefaultAsync();
        }

        public async Task<List<Person>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Person person)
        {
            await _repository.AddAsync(person);
            return person.PersonID;
        }

        public async Task UpdateAsync(Person person)
        {
            await _repository.UpdateAsync(person);
        }
    }
}
