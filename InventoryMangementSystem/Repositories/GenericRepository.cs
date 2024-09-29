using InventoryMangementSystem.Intefaces;
using InventoryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace InventoryMangementSystem.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MyDbContext _db;
        private DbSet<T> _dbSet;
        public GenericRepository(MyDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var item = await GetByIdAsync(id);
            _dbSet.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
    string[] includes = null)
        {
            IQueryable<T> query = _dbSet;
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include).AsSplitQuery();
                }
            }
            if (expression != null)
            {
                return query.Where(expression);
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
