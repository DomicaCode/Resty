﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Resty.Common;
using Resty.DAL.DBContext;
using Resty.Model.Common.Models;
using Resty.Repository.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resty.Repository
{
    public class BaseRepository<TEntity, TFilter> : IBaseRepository<TEntity, TFilter>
        where TEntity : class, IBaseModel, new()
        where TFilter : class, IGenericFilter, new()
    {
        #region Fields

        private readonly RestyContext _context;
        private readonly DbSet<TEntity> _dbSet;

        #endregion Fields

        #region Constructors

        protected BaseRepository(RestyContext context, IMapper mapper)
        {
            Mapper = mapper;
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        #endregion Constructors

        #region Properties

        private IMapper Mapper { get; }

        #endregion Properties

        #region Methods

        public virtual async Task<bool> DeleteAsync(Guid entityId)
        {
            var filter = new TFilter
            {
                Id = entityId
            };
            var entity = await GetAsync(filter);

            var result = _dbSet.Remove(entity);

            if (result.State != EntityState.Deleted) return false;

            await _context.SaveChangesAsync();

            return true;
        }

        public virtual async Task<bool> EditAsync(TEntity entity)
        {
            var filter = new TFilter
            {
                Id = entity.Id
            };

            var currentEntity = await GetAsync(filter);

            var foodItemToEdit = Mapper.Map(entity, currentEntity);

            var result = _dbSet.Update(foodItemToEdit);

            if (result.State != EntityState.Modified) return false;

            await _context.SaveChangesAsync();

            return true;
        }

        public virtual async Task<IList<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetAsync(TFilter filter)
        {
            if (filter.Id != null)
            {
                return await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == filter.Id);
            }
            else if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                return await _dbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Name == filter.Name);
            }

            return new TEntity();
        }

        public virtual async Task<bool> InsertAsync(TEntity entity)
        {
            var result = _dbSet.Add(entity);

            if (result.State != EntityState.Added) return false;

            await _context.SaveChangesAsync();

            return true;
        }

        #endregion Methods
    }
}