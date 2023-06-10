﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public bool ?IsDeleted { get; set; }=false;
        public DateTime? CreadtedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
