using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.Models;
using System.Data.SqlClient;
using Dapper;
using DGVPrinterHelper;

using Hotel_Management_System.Extensions;

namespace Hotel_Management_System
{
    

    public partial class GenerateBill : Form
    {
        private BindingList<Transaction> billingItems;
        public GenerateBill()
        {
            InitializeComponent();
            billingItems = new BindingList<Transaction>();
            dataGridView1.DataSource = billingItems;

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * from `guests`";

            var guests = conn.Query<GuestModel>(query ,new {});
            

           
        }

        private void GuestContacttbx_TextChanged(object sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection ();
           var query = "SELECT * FROM `guests` WHERE Guest_Contact=@GuestContact;";
            var item = conn.Query<GuestModel>(query, new
            {
                GuestContact = GuestContacttbx.Text
            });

                var guest = item.FirstOrDefault();

                if (guest!=null)
                {
                    guestNametbx.Text = guest.Guest_Name;
                    GuestAddresstbx.Text=guest.Guest_Address;
                    guestIDtbx.Text=Convert.ToString(guest.Guest_ID);
                    RoomNotbx.Text=Convert.ToString(guest.Room_No);
                    PanNotbx.Text=Convert.ToString(guest.Guest_Pan);


                var BillID = 0;
                var query2 = "SELECT * FROM `bill` WHERE GuestContact=@Guest_Contact;";

                var result = conn.Query<BillModel>(query2, new
                {
                    Guest_Contact = GuestContacttbx.Text
                });

                var Bill = result.FirstOrDefault();
                if (Bill!=null)
                {
                    BillID = Bill.Bill_ID;
                }
                


                var query3 = "SELECT * FROM `transactions` WHERE Bill_ID=@Billid;";
                var transactions = conn.Query<Transaction>(query3, new
                {
                    Billid = BillID
                });

                dataGridView1.DataSource = transactions;
                var totalamount = Bill.TotalAmount;
                TotalOfFoodandDrinkstbx.Text=Convert.ToString(totalamount);
                var nettotal = Convert.ToInt32(TotalOfFoodandDrinkstbx.Text)+Convert.ToInt32(RoomPricetbx.Text);
                NetTotaltbx.Text=Convert.ToString(nettotal);

            }
            else
                {
                    guestNametbx.Text = "";
                    GuestAddresstbx.Text="";
                    RoomNotbx.Text="";
                    PanNotbx.Text="";
                    guestIDtbx.Text="";
                }



           



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();
        }

        private void RoomPricetbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PanNotbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNotbx_TextChanged(object sender, EventArgs e)
        {
            var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT *FROM `room` WHERE Room_No=@roomno";
            var rooms = conn.Query<roomsmodel>(query, new
            {
                roomno = RoomNotbx.Text
            });
            var Rooms = rooms.FirstOrDefault();
            if (Rooms!=null)
            {
                RoomPricetbx.Text=Convert.ToString(Rooms.Price);

            }
            else
            {
                RoomPricetbx.Text="";
            }

        }

        private void ReceivedAmttbx_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void ReceivedAmttbx_TextChanged(object sender, EventArgs e)
        {
            
            


           
                int returnamt=(Convert.ToInt32(ReceivedAmttbx.Text)-Convert.ToInt32(NetTotaltbx.Text));
                ReturnAmttbx.Text=Convert.ToString(returnamt);

        }

        private void GenerateBillbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n\n\n\nPahuna Ghar";
            printer.SubTitle = $"\n\nBirtmode-4, Jhapa,Mechinagar\r\ntelephone: 023598 ph no:9806068043\n\n\n\n Date: {dateTimePicker1.Value.ToString("yyyy-mm-dd")}\n\n Customer Name: {guestNametbx.Text}   Customer Pan={PanNotbx.Text} Address: {GuestAddresstbx.Text} \n\n\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            // printer.Footer = $"Discount: {discounttbx.Text}%\r\nTAX:{taxtbx.Text}%\r\nVAT: {vattbx.Text}%\r\nGrand Total: {Totaltbx.Text} \r\nThank You!!";
            printer.Footer=$"Total Of Food and Drinks:{TotalOfFoodandDrinkstbx.Text}\r\n Net Total(along with Room charge):{NetTotaltbx.Text}\r\n Received Amount:{ReceivedAmttbx.Text}\r\n Return Amount:{ReturnAmttbx.Text}\r\n Thank You";
            printer.FooterSpacing = 10;
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}



