using Microsoft.AspNetCore.Identity;
using Models;
using Services.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using ViewModel.Exestention_Methods;

namespace Services.Transactions
{
    public class TransService:ITransServiceInterface1
    {
        private readonly Irepository<Transaction> Transrepo;
        TransService(Irepository<Transaction> transrepo)
        {
            Transrepo = transrepo;
        }
        public bool Addtrans(AddTransactionVM TransVM)
        {
            Transrepo.Add(TransVM.AddTransactionVM());
            return true;

        }
        public IEnumerable<GetTransactionVM> GetTrans(string UserID)
        {
            return Transrepo.FindAll(w=>w.TransferTo==UserID).Select(w => w.TransactionVM()).ToList();
        }

    }
}
