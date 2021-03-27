using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("product")]
        public int ProductId { get; set; }
        public virtual Product product { get; set; }

        [ForeignKey("customer")]
        public int CustomerId { get; set; }
        public virtual Customer customer { get; set; }


        public Decimal SaleAmount
        {
            get
            {
                if (Quantity !=0)
                    {
                    return Quantity * product.Price;
                }
                return 0;
            }
        }
    }
}