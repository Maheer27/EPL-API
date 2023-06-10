
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Exestention_Methods
{

   


        public static class Exestentions
    {

        #region User
        public static User UserVM_User(this AddUserVM userVM)
        {
            if (userVM == null)
            {
                return null;
            }
            else
            {
                User user = new User();
                user.UserName = userVM.Name;
                user.Mobile = userVM.Mobile;
                user.PasswordHash = userVM.Password;
                return user;
            }

        }
        public static GetuserdataVM GetUserDatatoVM(this User user)
        {
            if (user == null)
            {
                return null;
            }
            else
            {
                GetuserdataVM UserVM = new GetuserdataVM();
                UserVM.Account = user.Account;
                UserVM.Name= user.UserName;
                UserVM.Mobile = user.Mobile;

                UserVM.Transactions = user.TransactionsTO.Select(e=>e.TransactionVM()).ToList();
                return UserVM;
            }

        }
        #endregion
        #region
        public static Transaction AddTransactionVM(this AddTransactionVM Trans)
        {
            if (Trans == null)
            {
                return null;
            }
            else
            {
                Transaction Transaction = new Transaction();
                Transaction.Amount = Trans.amount;
                Transaction.TransferTo = Trans.TransferTO;
                Transaction.TransferFrom = Trans.TransferFrom;
                Transaction.CreadtedDate = DateTime.Now;
                return Transaction;
            }

        }
        public static GetTransactionVM TransactionVM(this Transaction Trans)
        {
            if (Trans == null)
            {
                return null;
            }
            else
            {
                GetTransactionVM TransactionVM = new GetTransactionVM();
                TransactionVM.amount = Trans.Amount;
                TransactionVM.TransferTO = Trans.TransferTo;
                TransactionVM.TransferFrom = Trans.TransferFrom;
                TransactionVM.TransferDate = Trans.CreadtedDate;
                return TransactionVM;
            }

        }
        #endregion

 

    }
}
