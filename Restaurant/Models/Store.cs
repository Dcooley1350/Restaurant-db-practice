namespace Restaurant.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int StoreId { get; set; }
        // public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; } 
    }
}