using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopEntity.Entity
{
    public class CarRepo
    {
        [Key]
        public int carID { get; set; }
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public int carYear { get; set; }
        public int carKm { get; set; }
        public int carPrice { get; set; }
    }
}
