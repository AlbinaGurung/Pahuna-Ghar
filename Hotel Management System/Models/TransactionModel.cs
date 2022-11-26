using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    internal class TransactionModel
    {
        public int Bill_ID { get; set; }
        public string Guest_Contact { get; set; }
        public int Item_ID { get; set; }
        public string Descriptions { get; set; }
        public int Rate { get; set; }
        public int Qty { get; set; }
        public decimal VAT { get; set; }
        public decimal TAX { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
