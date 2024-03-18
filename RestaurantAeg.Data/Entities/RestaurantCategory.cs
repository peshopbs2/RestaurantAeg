using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAeg.Data.Entities
{
    public class RestaurantCategory
    {
        public int RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
