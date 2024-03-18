using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAeg.Data.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            RestaurantCategories = new HashSet<RestaurantCategory>();
        }

        public string Name { get; set; }
        public ICollection<RestaurantCategory> RestaurantCategories { get; set; }
    }
}
