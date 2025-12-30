using FoodOrderSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem.DAL
{
    public class UserDBContext
    {
        string url = "Data Source=(localdb)\\ProjectModels;Initial Catalog=FoodOrderSystemDB;Integrated Security=True";
        //Data Source=(localdb)\ProjectModels;Initial Catalog=FoodOrderSystemDB;Integrated Security=True;

        public User ValidateUser(string unm, string pass)
        {
            SqlConnection con = new SqlConnection(url);
            string selectQuery = $"select * from users where Name = '{unm}' and Pass = '{pass}'";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            if (reader.Read()) 
            {
                user = new User 
                {
                    UId = Convert.ToInt32(reader["Id"]),
                    UName = reader["Name"].ToString(),
                    UPass = reader["Pass"].ToString(),
                    UEmail = reader["Email"].ToString(),
                    URole = reader["Role"].ToString()
                };
            }
            con.Close();
            return user;
        }

        public int InsertUser(User user)
        {
            SqlConnection con = new SqlConnection(url);
            string insertQuery = $"insert into users(Name,Pass,Email,Role) values( '{user.UName}', '{user.UPass}', '{user.UEmail}', 'user' )";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public User GetUserByEmail(string email)
        {
            SqlConnection con = new SqlConnection(url);
            string updateQuery = $"select * from users where Email = '{email}'";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            con.Open();
            User user = null;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new User();
                user.UId = Convert.ToInt32(reader["Id"]);
                user.UName = reader["Name"].ToString();
                user.UPass = reader["Pass"].ToString();
                user.UEmail = reader["Email"].ToString();
                user.URole = reader["Role"].ToString();
            }
            con.Close();
            return user;
        }

        public int ChangePassword(string email, string pass)
        {
            SqlConnection con = new SqlConnection(url);
            string updateQuery = $"update users set Pass = '{pass}' where Email = '{email}'";
            SqlCommand cmd = new SqlCommand( updateQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public int DeleteAccount(User user)
        {
            SqlConnection con = new SqlConnection(url);
            string deleteQuery = $"delete from users where Name = '{user.UName}' and Pass = '{user.UPass}'";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
    }
}
