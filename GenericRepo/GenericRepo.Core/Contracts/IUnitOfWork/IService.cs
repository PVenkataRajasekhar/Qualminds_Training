using GenericRepo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Core.Contracts.IUnitOfWork
{
    public interface IService<T> where T : class
    {
        Task<T> GetWithId(int Id);
        Task<IEnumerable<T>> GetAll();
        Task Create(T t);
        Task Update(T t);
        Task Remove(int Id);
    }
}
