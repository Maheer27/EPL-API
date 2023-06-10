using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction:BaseModel
    {


       public decimal Amount { get; set; }
       public int Quantity { get; set; }

        public int? TransferFrom { get; set; } = null;

        public virtual User User { get; set; }
        [ForeignKey("User")]
        public string? TransferTo { get; set; } = null;






    }
}
