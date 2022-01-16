using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.EntityFramework.Repository;
using Northwind.Entity.Base;

namespace Northwind.Dal.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        #region Variables

        private readonly DbContext _context;
        private IDbContextTransaction _transaction;
        private bool _dispose;

        #endregion

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_dispose)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _dispose = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IGenericRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new GenericRepository<T>(_context);
        }

        public bool BeginTransaction()
        {
            try
            {
                _transaction = _context.Database.BeginTransaction();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RollBackTransaction()
        {
            try
            {
                _transaction.Rollback();
                _transaction = null;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SaveChanges()
        {
            var transaction = _transaction != null ? _transaction : _context.Database.BeginTransaction();

            using (transaction)
            {
                try
                {
                    if (_context == null)
                    {
                        throw new ArgumentException("Context is null!");
                    }

                    int result = _context.SaveChanges();

                    transaction.Commit();

                    return result;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }
    }
}