using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Services.Transactions
{
    public interface ITransServiceInterface1
    {
        bool Addtrans(AddTransactionVM transactionVM);
        public IEnumerable<GetTransactionVM> GetTrans(string UserID);
    }
}
