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

using Hotel_Management_System.Models;

namespace Hotel_Management_System
{
    public partial class RoomsForm : Form
    {
        private object rooms;
        private object dgvrooms;

        public RoomsForm()
        {
            InitializeComponent();
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            var roomid=RoomIDtbx.Text;
            var roomtype=RoomTypetbx.Text;
            var price = Pricetbx.Text;
            var noofindividuals = noofindividualstbx.Text;
            var isavailable = IsAvailabletbx.Text;
            using var conn = ConnectionProvider.GetDbConnection();
            
            var query = "INSERT INTO `room` (`Room_No`, `Room_Type`, `Price`, `No_Of_Individuals`, `IsAvailable`) VALUES (@RoomID, @RoomType, @price, @NoOfIndividuals, @IsAvailable);";
            conn.Execute(query, new { RoomID = roomid, RoomType = roomtype, price = price, NoOfIndividuals = noofindividuals, IsAvailable = isavailable });

            conn.Close();
            MessageBox.Show("Successfully Added");


        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dgvRooms.CurrentRow.Selected=true;
                RoomIDtbx.Text=dgvRooms.Rows[e.RowIndex].Cells["Room_No"].FormattedValue.ToString();
                RoomTypetbx.Text=dgvRooms.Rows[e.RowIndex].Cells["Room_Type"].FormattedValue.ToString();
                Pricetbx.Text=dgvRooms.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                noofindividualstbx.Text=dgvRooms.Rows[e.RowIndex].Cells["No_Of_Individuals"].FormattedValue.ToString();
                IsAvailabletbx.Text=dgvRooms.Rows[e.RowIndex].Cells["IsAvailable"].FormattedValue.ToString();
               
            }




        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            loadrooms();
        }

        private void loadrooms()
        {
            var query = "SELECT * FROM `room`";
            using var conn = ConnectionProvider.GetDbConnection();
            var rooms = conn.Query<roomsmodel>(query, new
            {

            });
            dgvRooms.DataSource=rooms;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var query = "DELETE FROM `room` WHERE `room`.`Room_No` = @roomid;";
            var ID = RoomIDtbx.Text;
            using var conn = ConnectionProvider.GetDbConnection();

           
            conn.Execute(query, new { roomid = ID });
            conn.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            var roomid = RoomIDtbx.Text;    
            var roomtype = RoomTypetbx.Text;
            var price = Pricetbx.Text;
            var noofindividuals = noofindividualstbx.Text;
            var isavailable = IsAvailabletbx.Text;
            var conn= ConnectionProvider.GetDbConnection();
            var query = "UPDATE `room` SET `Room_Type` = @RoomType, `Price` = @Price, `No_Of_Individuals` = @NoOfIndividuals, `IsAvailable` = @IsAvailable WHERE `room`.`Room_No` = @RoomNo;";
            conn.Execute(query, new {RoomNo=roomid, RoomType=roomtype,Price=price,NoOfIndividuals=noofindividuals,IsAvailable=isavailable });

            conn.Close();
            MessageBox.Show("Successfully Updated");
            loadrooms();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            RoomIDtbx.Clear();
            RoomTypetbx.Clear();
            Pricetbx.Clear();
            noofindividualstbx.Clear();
            IsAvailabletbx.Clear();
            RoomTypetbx.Focus();
            loadrooms();
        }

        private void GoBackbtn_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();
        }
    }
}
