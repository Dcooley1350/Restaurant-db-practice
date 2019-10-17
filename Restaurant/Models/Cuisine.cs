using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Stores = new HashSet<Store>();
        }
        public string DishType {get; set;}
        public int CuisineId {get; set;}
        public virtual ICollection<Store> Stores {get; set; }
    }
}