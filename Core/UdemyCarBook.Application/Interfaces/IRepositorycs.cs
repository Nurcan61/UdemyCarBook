using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByAsync(int id);
        Task CreatAsync(T  entity);
        Task UpdateAsync(T  entity);
        Task RemoveAsync (T  entity);
        Task RemoveAsync(Task<About> value);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<object>> GetAllIdAsync();

    }
}
