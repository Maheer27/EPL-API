using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GetuserdataVM
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Account { get; set; }

       public ICollection<GetTransactionVM> Transactions { get; set; }

    }
}
