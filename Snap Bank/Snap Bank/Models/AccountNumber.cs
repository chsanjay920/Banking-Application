using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Snap_Bank.Models
{
    [Table("AccountNumber")]
    public class AccountNumber
    {
        [Key]
        public int id { get; set; }
        public String Date { get; set; }
        public int number { get; set; }
    }
}