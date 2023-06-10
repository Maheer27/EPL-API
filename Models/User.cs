using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : IdentityUser
    {
      
        public string Mobile { get; set; }
        public string Account { get; set; }

        public virtual ICollection<Transaction> TransactionsTO { get; set; } = new HashSet<Transaction>();

    }
}
