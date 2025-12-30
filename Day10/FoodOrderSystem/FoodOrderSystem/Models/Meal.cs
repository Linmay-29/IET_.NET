using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem.Models
{
    [Table("Meals1")]
    public class Meal
    {
        [Key]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }
        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column("Type", TypeName = "varchar(50)")]
        public string Type { get; set; }
        [Column("Price", TypeName = "decimal(2,2)")]
        public decimal Price { get; set; }
    }
}
