using FoodOrderSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem.DAL
{
    public class MealDBContext
    {
        string url = "Data Source=(localdb)\\ProjectModels;Initial Catalog=FoodOrderSystemDB;Integrated Security=True";
        public List<Meal> GetMeals() 
        {
            SqlConnection con = new SqlConnection(url);
            string selectQuery = "select * from meals";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Meal> mealList = new List<Meal>();
            while (reader.Read()) 
            {
                mealList.Add(new Meal 
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"].ToString(),
                    Type = (string)reader["type"].ToString(),
                    Price = (decimal)reader["price"]
                }); 
            }
            return mealList;
        }
    }
}
