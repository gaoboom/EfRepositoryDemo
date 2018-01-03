using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CoreModels
{
    /// <summary>
    /// 用户聚合根类
    /// </summary>
    public class User: AggregateRoot
    {
        public int RowID { get; set; }

        public Guid UserID { get; set; }

        public string UserAccount { get; set; }

        public string UserPassword { get; set; }

        public int UserType { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
