using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopEntity.Entity
{
    public class AdminLogin
    {
        [Key]
        public int userID { get; set; }
        public string adminName { get; set; }
        public string adminPassword { get; set; }
    }
}
