using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CoreModels
{
    public class UserPersonalInfo:IEntity
    {
        public int RowID { get; set; }

        public string NickName { get; set; }

        public DateTime AddTime { get; set; }

        public Guid AddUserID { get; set; }

        public virtual User User { get; set; }
    }
}
