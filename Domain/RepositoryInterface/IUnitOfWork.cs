using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterface
{
    /// <summary>
    /// 工作单元基类接口
    /// </summary>
    interface IUnitOfWork
    {
        bool Commit();
    }
}
