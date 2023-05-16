using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CodeFirst.Models
{
   
    public class OrderItem
    {
        [Key]
        [Column("OrderItemID")]
        [Required]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        
        public virtual Order OrderID { get; set; }
    }
}