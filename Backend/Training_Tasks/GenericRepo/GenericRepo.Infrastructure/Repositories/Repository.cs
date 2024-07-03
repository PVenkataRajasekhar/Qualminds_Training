using GenericRepo.Core.Contracts.IRepositories;
using GenericRepo.Core.Models;
using GenericRepo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;
        public Repository(Context context)
        {
            _context = context;
        }
        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> GetById(int id)
        {
            var model = await _context.Set<T>().FindAsync(id);
            if (model == null)
                return null;
            return model;
        }
        public async Task Post(T t)
        {
            _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
        }
        public async Task Put(T t)
        {
            var entry = _context.Entry(t);
            if (entry.State == EntityState.Detached)
            {
                _context.Set<T>().Attach(t);
            }
            entry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var model = await _context.Set<T>().FindAsync(id);
            if (model != null)
            {
                _context.Set<T>().Remove(model);
                await _context.SaveChangesAsync();
                return;
            }
            return;
        }
    }
}
