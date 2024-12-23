using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarBookContext _context;

        public Repository(CarBookContext context)
        {
            _context = context;
        }

        public async Task CreatAsync(T entity)
        {
            _context.Set<T>().Add(entity);
           await _context.SaveChangesAsync();
        }
        public async Task<List<T>>GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<IEnumerable<object>> GetAllIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task <T> GetByAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync(); 
        }

        Task<T> IRepository<T>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.RemoveAsync(Task<About> value)
        {
            throw new NotImplementedException();
        }
    }
}
