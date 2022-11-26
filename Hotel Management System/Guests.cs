using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Hotel_Management_System.Extensions;
using Hotel_Management_System.Models;
using MySql.Data.MySqlClient;


namespace Hotel_Management_System
{
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
            Load +=Guests_Load1;
        }

        private void Guests_Load1(object? sender, EventArgs e)
        {
            loadguests();
        }

        private void Guests_Load(object sender, EventArgs e)
        {
            loadguests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var GuestID=guestidtbx.Text;
            //var name=guestnametbx.Text;
            //var address=guestaddresstbx.Text;
            //var phone = guestphonetbx.Text;
            //var email=guestemailtbx.Text;
            //var room_no = guestroomnotbx.Text;
            //var no_of_guests=noofguesttbx.Text;
            //var checkin = checkintbx.Text;
            //var checkout = checkouttbx.Text;
            //using var conn = ConnectionProvider.GetDbConnection();
            //var query = $"INSERT INTO `customers` (`C_ID`, `C_Name`, `C_Address`, `C_Phone`, `C_Email`, `RoomID`, `No_Of_Geusts`, `Checkin`, `Checkout`) VALUES (@ID, @gusetname, @guestaddress, @guestphone, @guestemail, @roomno, @noofguests, @checkin, @checkout);";
            //conn.Execute(query, new { ID = GuestID,guestname= name, guestaddress = address, guestphone = phone, guestemail = email, roomno = room_no, noofguests = no_of_guests, checkin = checkin, checkout = checkout });
            //conn.Close();
            //MessageBox.Show("Successfully Added");

        }

        private void Guests_Load_1(object sender, EventArgs e)
        {
            loadrooms();
            loadguests();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            check_if_room_available();
         
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
           // loadguests();
            var GuestID = this.GuestID.Text;
            var name = GuestNametbx.Text;
            var address = GuestAddresstbx.Text;
            var Gender = GenderComboBox.Text;
            var phone = GuestContacttbx.Text;
            var email = GuestEmailtbx.Text;
            var roomno = RoomNotbx.Text;
            var noofguests = NoOfIndividualstbx.Text;
            DateTime checkin = CheckinTimePicker.Value;
            DateTime checkout = CheckoutTimepicker.Value;
            using var conn = ConnectionProvider.GetDbConnection();

            /* MySqlDataReader reader;
             var query = $"SELECT COUNT(Room_No)  FROM `customers` WHERE Room_No=@RoomNo;";
             query.Parameters.AddWithValue("RoomNo",roomno);
             reader=query.Execute();                                                                                                                                                                                                                                                                                                                                
             */

            int count=0;
            count=check_if_room_available();
            if (count>0)
            {

                MessageBox.Show("The room no" + roomno + "is not available.\n Please Enter Another Roomno ");
                MessageBox.Show("The value of count is" +count);
            
            }
            else
            {
                var query1 = "INSERT INTO `guests` (`Guest_ID`, `Guest_Name`, `Gender`,`Guest_Address`, `Guest_Contact`, `Guest_Email`, `Room_No`, `No_Of_Individuals`, `Checkin`, `Checkout`) " +
                        "VALUES (@ID, @Name, @gender,@Address, @Phone, @Email, @RoomNo, @NoOfGuests, @Checkin, @Checkout);";
                conn.Execute(query1, new { ID = GuestID, Name = name, gender = Gender, Address = address, NoOfGuests = noofguests, Phone = phone, Email = email, RoomNo = roomno, Checkin = checkin, Checkout = checkout });
                conn.Close();

                MessageBox.Show("Added Successfully");
                MessageBox.Show("The value of count is" +count);

                var query2 = "UPDATE room SET IsAvailable = 'NO' WHERE Room_No = @RoomNo; ";
                conn.Execute(query2, new { RoomNo=RoomNotbx.Text});
                loadguests();   

            }
        }
        /*private void loadguests()
         {
            var GuestID = this.GuestIDtbx.Text.ValueOrNull();


             var name = GuestNametbx.Text.ValueOrNull();
             var address = GuestAddresstbx.Text.ValueOrNull();
             var phone = GuestContacttbx.Text.ValueOrNull();
             var email = GuestEmailtbx.Text.ValueOrNull();
             var room_no = RoomNotbx.Text.ValueOrNull();
             var no_of_guests = NoOfIndividualstbx.Text.ValueOrNull();
             var checkin = CheckinTimePicker.Text.ValueOrNull();
             var checkout = CheckoutTimepicker.Text.ValueOrNull();

             var query = "SELECT * FROM `customers` WHERE (@guestid is null or Guest_ID = @guestid) and (@name is null or Guest_Name = @name)";

             using var conn = ConnectionProvider.GetDbConnection();
             var guests = conn.Query<GuestModel>(query, new { 
                 guestId = GuestID,
                 name = name,
             });
             guestDgv.DataSource = guests;
         }*/
        private void loadrooms()
        {
            var query = "SELECT * FROM `room`";
            using var conn = ConnectionProvider.GetDbConnection();
            var rooms = conn.Query<roomsmodel>(query, new
            {

            });
            dgvrooms.DataSource=rooms;
        }
        private void loadguests()
        {
            var query = "SELECT * FROM `guests`";
                using var conn = ConnectionProvider.GetDbConnection();
            var guests = conn.Query<GuestModel>(query, new
            {
                
            });
            guestDgv.DataSource = guests;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            GuestIDtbx.Text=string.Empty;
            GuestNametbx.Text=string.Empty;
            GenderComboBox.Text=string.Empty;
            GuestAddresstbx.Text=string.Empty;
            GuestEmailtbx.Text=string.Empty;    
            GuestContacttbx.Text=string.Empty;
            RoomNotbx.Text=string.Empty;
            NoOfIndividualstbx.Text=string.Empty;
            CheckinTimePicker.Text=string.Empty;
            CheckoutTimepicker.Text=string.Empty;
            GuestNametbx.Focus();

            loadguests();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchQuery = Searchtbx.Text.ValueOrNull();
            var query = "SELECT * FROM `guests` WHERE (@guestid is null or Guest_ID = @guestid) and (@name is null or Guest_Name like '%@name' )";

            using var conn = ConnectionProvider.GetDbConnection();
            var guests = conn.Query<GuestModel>(query, new
            {
                guestid = searchQuery,
                name = searchQuery,
            });
            guestDgv.DataSource = guests;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var GuestID = GuestIDtbx.Text;
            var name = GuestNametbx.Text;
            var Gender=GenderComboBox.Text;
            var address = GuestAddresstbx.Text;
            var phone = GuestContacttbx.Text;
            var email = GuestEmailtbx.Text;
            var roomno = RoomNotbx.Text;
            var noofindividuals = NoOfIndividualstbx.Text;
            var checkin = CheckinTimePicker.Text;
            var checkout = CheckoutTimepicker.Text;
            using var conn = ConnectionProvider.GetDbConnection();

            var query = "UPDATE `guests` SET `Guest_Name` = @Name, `Guest_Address` = @address, `Gender`=@gender,`Guest_Contact` = @Contact, `Guest_Email` = @Email, `Room_No` = @RoomNo, `No_Of_Individuals` = @NoOfIndividuals, `Checkin` = @CheckIn, `Checkout` = @CheckOut WHERE `guests`.`Guest_ID` = @guestid;";

            
            conn.Execute(query, new { guestid=GuestID,Name=name,gender=Gender, Address=address,Contact=phone,RoomNo=roomno,Email=email,NoOfIndividuals=noofindividuals,CheckIn=checkin,CheckOut=checkout});
            
            conn.Close();
            MessageBox.Show("Successfully Updated");
            loadguests();
        }

        private void Searchtbx_TextChanged(object sender, EventArgs e)
        {
            if (Searchtbx.Text!=null)
            {
                var query = "SELECT * FROM `guests` WHERE Guest_ID = @guestid or Guest_Name = @name or  Guest_Address=@Address or Guest_Contact=@Contact";

                using var conn = ConnectionProvider.GetDbConnection();
                var guests = conn.Query<GuestModel>(query, new
                {
                    guestid = Searchtbx.Text,
                    name = Searchtbx.Text,
                    Address=Searchtbx.Text,Contact=Searchtbx.Text,
                });
                guestDgv.DataSource = guests;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var ID = GuestIDtbx.Text;
            using var conn = ConnectionProvider.GetDbConnection();

            var query = "DELETE FROM `guests` WHERE `customers`.`Guest_ID` = @Guest_ID;";
            conn.Execute(query, new { Guest_ID = ID });
            conn.Close();
            MessageBox.Show("Successfully Deleted");
           

        }

        private void guestDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guestDgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                guestDgv.CurrentRow.Selected=true;
                GuestIDtbx.Text=guestDgv.Rows[e.RowIndex].Cells["Guest_ID"].FormattedValue.ToString();
                GuestNametbx.Text=guestDgv.Rows[e.RowIndex].Cells["Guest_Name"].FormattedValue.ToString();
                GenderComboBox.Text=guestDgv.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                GuestAddresstbx.Text=guestDgv.Rows[e.RowIndex].Cells["Guest_Address"].FormattedValue.ToString();
                GuestContacttbx.Text=guestDgv.Rows[e.RowIndex].Cells["Guest_Contact"].FormattedValue.ToString();
                GuestEmailtbx.Text=guestDgv.Rows[e.RowIndex].Cells["Guest_Email"].FormattedValue.ToString();
                RoomNotbx.Text=guestDgv.Rows[e.RowIndex].Cells["Room_No"].FormattedValue.ToString();
                NoOfIndividualstbx.Text=guestDgv.Rows[e.RowIndex].Cells["No_Of_Individuals"].FormattedValue.ToString();
                CheckinTimePicker.Text=guestDgv.Rows[e.RowIndex].Cells["Checkin"].FormattedValue.ToString();
                CheckoutTimepicker.Text=guestDgv.Rows[e.RowIndex].Cells["Checkout"].FormattedValue.ToString();
            }
            /*var item = guestDgv.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(item.ToString());*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();

            
        }

        private void gotoroombtn_Click(object sender, EventArgs e)
        {
            RoomsForm f1 = new RoomsForm();
            this.Hide();
            f1.ShowDialog();
            this.Show();
            
        }

        private void gotomealsbtn_Click(object sender, EventArgs e)
        {
             MealsFrm f1 = new MealsFrm();
            this.Hide();
            f1.ShowDialog();
            this.Show();

        }

        private void gotodrinksbtn_Click(object sender, EventArgs e)
        {
            DrinksModel f1 = new DrinksModel();
           
            this.Hide();
            f1.ShowDialog();
            this.Show();
           

        }

        private void RoomNotbx_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public int check_if_room_available()
        {

            using var conn = ConnectionProvider.GetDbConnection();
            var roomno = (RoomNotbx.Text);
            var query = $"SELECT COUNT(Room_No)  FROM `guests` WHERE Room_No=@RoomNo;";
            var count = conn.ExecuteScalar(query, new { RoomNo = roomno });

            return Convert.ToInt32(count);
        }

        private void GuestContactlbl_Click(object sender, EventArgs e)
        {

        }

        private void GuestContacttbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNolbl_Click(object sender, EventArgs e)
        {

        }
    }
}

