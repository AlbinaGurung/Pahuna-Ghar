using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class roomsmodel
    {
        public int Room_No { get; set; }
        public string Room_Type { get; set; }
        public int Price { get; set; }
        public int No_Of_Individuals { get; set; }
        public string IsAvailable { get; set; }
    }
}
