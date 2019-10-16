using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Cuisine
    {
        public string Dish {get; set;}
        public string DishType {get; set;}
        public int DishId {get; set;}
        public Cuisine(string dish, string dishType)
        {
            Dish = dish;
            DishType = dishType;
        }
        public Cuisine(string dish, string dishType, int dishId)
        {
            Dish = dish;
            DishType = dishType;
            DishId = dishId;
        }
    }
}