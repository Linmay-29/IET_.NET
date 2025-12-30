using FoodOrderSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            
            SqlDataAdapter da = new SqlDataAdapter("select * from meals", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "meals");
            List<Meal> mealList = new List<Meal>();

            foreach (DataRow row in ds.Tables["meals"].Rows)
            {
                mealList.Add(new Meal
                {
                    Id = (int)row["id"],
                    Name = (string)row["name"].ToString(),
                    Type = (string)row["type"].ToString(),
                    Price = (decimal)row["price"]
                });
            }
            return mealList;
        }

        public int InsertMeal(Meal meal)
        {
            SqlConnection con = new SqlConnection(url);

            SqlDataAdapter da = new SqlDataAdapter("select * from meals", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "meals");
            DataRow newRow = ds.Tables["meals"].NewRow();
            newRow["Name"] = meal.Name;
            newRow["Type"] = meal.Type;
            newRow["Price"] = meal.Price;

            ds.Tables["meals"].Rows.Add(newRow);
            int noOfRowsAffected=da.Update(ds, "meals");  
            return noOfRowsAffected;
        }
    }
}
