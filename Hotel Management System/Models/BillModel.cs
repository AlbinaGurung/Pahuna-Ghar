using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    internal class BillModel
    {
        public int Bill_ID { get; set; }
        public string GuestContact { get; set; }
       public DateTime Date { get; set; }
        public string GuestName { get; set; }
        public string CustomerPan { get; set; }
        public string GuestAddress { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
