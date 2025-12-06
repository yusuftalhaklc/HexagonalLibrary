using Library.Domain.Entities;
using Library.Domain.SecondaryPorts;
using Library.Persistence.EFContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.EFConcrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly LibraryDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(LibraryDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbSet
                .Where(x => x.Status != Domain.Enums.DataStatus.Deleted)
                .ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet
                .FirstOrDefaultAsync(x => x.Id == id && x.Status != Domain.Enums.DataStatus.Deleted);
        }

        public virtual async Task CreateAsync(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            entity.Status = Domain.Enums.DataStatus.Inserted;
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            entity.Status = Domain.Enums.DataStatus.Updated;
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                entity.DeletedDate = DateTime.UtcNow;
                entity.Status = Domain.Enums.DataStatus.Deleted;
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}

