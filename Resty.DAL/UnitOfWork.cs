using Microsoft.EntityFrameworkCore;
using Resty.DAL.DBContext;
using System;
using System.Threading.Tasks;

namespace Resty.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Fields

        private readonly RestyContext _dbContext;
        private bool _disposed;

        #endregion Fields

        #region Constructors

        public UnitOfWork(RestyContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion Constructors

        #region Properties

        public string Message { get; private set; } = null!;
        public bool Success { get; private set; }

        #endregion Properties

        #region Methods

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public async Task<bool> Commit<T>(T entity) where T : class
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var dbEntityEntry = _dbContext.Entry(entity);

                    if (dbEntityEntry.State != EntityState.Detached)
                    {
                        dbEntityEntry.State = EntityState.Added;
                    }

                    await _dbContext.SaveChangesAsync();

                    transaction.Commit();

                    DetachAll();

                    Success = true;
                    // Message = Info.OperationSuccess;
                }
                catch (DbUpdateException ex)
                {
                    // transaction.Rollback();
                    Message = string.Format(ex.ToString());
                }
                catch (Exception ex)
                {
                    Message = string.Format(ex.ToString());
                    // transaction.Rollback();
                }
            }

            return Success;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        private void DetachAll()
        {
            foreach (var dbEntityEntry in _dbContext.ChangeTracker.Entries())
            {
                if (dbEntityEntry.Entity != null)
                {
                    dbEntityEntry.State = EntityState.Detached;
                }
            }
        }

        #endregion Methods
    }
}