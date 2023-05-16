using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CodeFirst.Models
{
    public class Order
    {
        [Key]
        [Column("OrderID")]
        [Required]
        public int Id { get; set; }
        
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer CustomerID { get; set; }
        //public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}