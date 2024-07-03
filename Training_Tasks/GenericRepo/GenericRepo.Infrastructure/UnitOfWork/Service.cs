using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepo.Core.Contracts.IRepositories;
using GenericRepo.Core.Contracts.IUnitOfWork;
using GenericRepo.Infrastructure.Data;

namespace GenericRepo.Infrastructure.UnitOfWork
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository; // Change variable name to follow naming conventions

        // Inject IRepository<T> dependency via constructor injection
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        // Implementing GetWithId method to get an entity by its Id
        public async Task<T> GetWithId(int id)
        {
            return await _repository.GetById(id);
        }

        // Implementing GetAll method to get all entities
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.Get(); // Assuming GetAll() method is implemented in IRepository<T>
        }

        // Implementing Create method to add a new entity
        public async Task Create(T t)
        {
            await _repository.Post(t); // Assuming Add() method is implemented in IRepository<T>
        }

        // Implementing Update method to update an existing entity
        public async Task Update(T t)
        {
            await _repository.Put(t); // Assuming Update() method is implemented in IRepository<T>
        }

        // Implementing Remove method to delete an entity by its Id
        public async Task Remove(int id)
        {
            await _repository.Delete(id); // Assuming Delete() method is implemented in IRepository<T>
        }
    }
}
