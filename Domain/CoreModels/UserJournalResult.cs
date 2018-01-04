using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CoreModels
{
    public class UserJournalResult:IEntity
    {
        public int RowID { get; set; }

        public Decimal AccountBalance { get; set; }

        public Decimal PrePayBalance { get; set; }

        public Decimal InvoiceableAmount { get; set; }

        public DateTime UpdateTime { get; set; }

        public byte[] RowVersion { get; set; }

        public virtual User User { get; set; }
    }
}
