using System;
using System.Threading.Tasks;

namespace Resty.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        #region Methods

        Task<bool> Commit<T>(T entity) where T : class;

        #endregion Methods
    }
}