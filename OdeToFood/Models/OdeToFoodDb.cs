﻿using System.Data.Entity;

namespace OdeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb()
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}