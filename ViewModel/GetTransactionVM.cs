using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GetTransactionVM
    {

        public decimal amount { get; set; }
        public string? TransferTO { get; set; }
        public int ?TransferFrom  { get; set; }
        public DateTime? TransferDate { get; set; }

    }
}
