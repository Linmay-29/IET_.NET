using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem.Models
{
    public class User
    {
        public int UId { get; set; }
        public string UName { get; set; }
        public string UPass { get; set; }
        public string UEmail { get; set; }
        public string URole { get; set; }
    }
}
