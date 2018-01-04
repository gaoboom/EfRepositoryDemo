using Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEfRepoContext: IRepositoryContext
    {
        #region Properties
        EsbBaseDbContext DbContex { get; }
        #endregion
    }
}
