﻿using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories
{
    public class EfRepoContext:IEfRepoContext
    {
        // ThreadLocal代表线程本地存储，主要相当于一个静态变量
        // 但静态变量在多线程访问时需要显式使用线程同步技术。
        // 使用ThreadLocal变量，每个线程都会一个拷贝，从而避免了线程同步带来的性能开销

        private readonly ThreadLocal<EsbBaseDbContext> _localCtx = new ThreadLocal<EsbBaseDbContext>(() => new EsbBaseDbContext());
        public EsbBaseDbContext DbContex
        {
            get { return _localCtx.Value; }
        }

        private readonly Guid _id = Guid.NewGuid();

        #region IRepositoryContext Members
        public Guid Id
        {
            get { return _id; }
        }

        public void RegisterNew<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            _localCtx.Value.Set<TAggregateRoot>().Add(entity);
        }

        public void RegisterModified<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            _localCtx.Value.Entry<TAggregateRoot>(entity).State = EntityState.Modified;
        }

        public void RegisterDeleted<TAggregateRoot>(TAggregateRoot entity) where TAggregateRoot : class, IAggregateRoot
        {
            _localCtx.Value.Set<TAggregateRoot>().Remove(entity);
        }

        #endregion

        #region IUnitOfWork Members
        public bool Commit()
        {
            var validationError = _localCtx.Value.GetValidationErrors();
            return _localCtx.Value.SaveChanges() > 0;
        }
        #endregion
    }
}
