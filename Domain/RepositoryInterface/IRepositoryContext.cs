using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterface
{
    public interface IRepositoryContext:IUnitOfWork
    {
        /// <summary>
        /// 用来标识仓储上下文
        /// </summary>
        Guid Id { get; }

        void RegisterNew<TAggregateRoot>(TAggregateRoot entity)
            where TAggregateRoot : class, IAggregateRoot;

        void RegisterModified<TAggregateRoot>(TAggregateRoot entity)
            where TAggregateRoot : class, IAggregateRoot;

        void RegisterDeleted<TAggregateRoot>(TAggregateRoot entity)
            where TAggregateRoot : class, IAggregateRoot;
    }
}
