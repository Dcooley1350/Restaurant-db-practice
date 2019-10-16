using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int StoreId { get; set; }

        public Store(string name, string description, string location)
        {
            Name = name;
            Description = description;
            Location = location;
        }
        public Store(string name, string description, string location, int storeId)
        {
            Name = name;
            Description = description;
            Location = location;
            StoreId = storeId;
        }
    }
}