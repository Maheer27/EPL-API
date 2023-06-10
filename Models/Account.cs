using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account : BaseModel
    {

        public decimal PreviousAccount { get; set; }

        public decimal CurrentAccount { get; set; }

        [ForeignKey("User")]
        public string? UserID { get; set; } = null;

        public virtual User User { get; set; }

    }
}
