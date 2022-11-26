using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hotel_Management_System.Models;

public class GuestModel
{
    public int Guest_ID { get; set; }
    public  string Guest_Name { get; set; }
    public string Gender { get; set; }
    public string Guest_Address { get; set; }
    public string Guest_Contact { get; set; }
    public string Guest_Email { get; set; }
    public int Room_No{ get; set; }  
    public int No_Of_Individuals { get; set; }
    public  DateTime Checkin { get; set; }
    public DateTime Checkout { get; set; }
    public static GuestModel GetData()
    {
            GuestModel model = new GuestModel();
        return model;
    }

}
