using GenericRepo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Core.Contracts.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);
        Task Post(T t);
        Task Put(T t);
        Task Delete(int id);
    }
}
