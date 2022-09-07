using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopEntity.Entity
{
    public class CarShopUserData
    {
        [Key]
        public int userID { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userMail { get; set; }
        public DateTime userBirthDate { get; set; }

    }

 

}
