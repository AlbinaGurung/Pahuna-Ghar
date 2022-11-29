using Hotel_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Transaction
{
        public int Bill_ID { get; set; }
       
        public int Item_ID { get; set; }
        public  string Items { get;  set; }
        public string Descriptions { get; set; }
       
        public decimal Rate { get; set; }
        public decimal Qty { get; set; }

        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal VAT { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal CalculateAmount()
        {
            var gross = (Qty * Rate) - Discount + Tax;
            TotalAmount = gross + (VAT * gross / 100);
            return TotalAmount;
        }
    }
}
