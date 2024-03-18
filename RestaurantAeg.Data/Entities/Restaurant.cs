using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAeg.Data.Entities
{
    public class Restaurant : BaseEntity
    {
        public Restaurant()
        {
            RestaurantCategories
                = new HashSet<RestaurantCategory>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public ICollection<RestaurantCategory> RestaurantCategories { get; set; }
    }
}
