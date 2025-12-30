using FoodOrderSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodOrderSystem.DAL
{
    public class MealDBContext : DbContext
    {
        //string url = "Data Source=(localdb)\\ProjectModels;Initial Catalog=FoodOrderSystemDB;Integrated Security=True";
        public DbSet<Meal> meals1 { set; get; }
        //{
        //    SqlConnection con = new SqlConnection(url);
        //    string selectQuery = "select * from meals";
        //    SqlCommand cmd = new SqlCommand(selectQuery, con);
        //    con.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<Meal> mealList = new List<Meal>();
        //    while (reader.Read()) 
        //    {
        //        mealList.Add(new Meal 
        //        {
        //            Id = (int)reader["id"],
        //            Name = (string)reader["name"].ToString(),
        //            Type = (string)reader["type"].ToString(),
        //            Price = (decimal)reader["price"]
        //        }); 
        //    }
        //    return mealList;
        //}

        public DbSet<Meal> meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var builder = new ConfigurationBuilder();


            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();


            optionsBuilder.UseSqlServer(config.GetConnectionString("FoodOrderSystemDB"));
        }

        
    }
}
