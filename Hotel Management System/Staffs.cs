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
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
        }

        private void searchtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (staffdgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                staffdgv.CurrentRow.Selected=true;
                staffidtbx.Text=staffdgv.Rows[e.RowIndex].Cells["Staff_ID"].FormattedValue.ToString();
                staffnametbx.Text=staffdgv.Rows[e.RowIndex].Cells["Staff_Name"].FormattedValue.ToString();
                designationtbx.Text=staffdgv.Rows[e.RowIndex].Cells["Designation"].FormattedValue.ToString();
                salarytbx.Text=staffdgv.Rows[e.RowIndex].Cells["Salary"].FormattedValue.ToString();
            }
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();
        }
        private void loadstaff()
        {

            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * FROM `staff`";
            var staffs = conn.Query<StaffModel>(query, new { });
           staffdgv.DataSource=staffs;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Add staff", "You want to add the new staff", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var name = staffnametbx.Text;
                var designation = designationtbx.Text;
                var salary = salarytbx.Text;

                using var conn = ConnectionProvider.GetDbConnection();
                var query = "INSERT INTO `staff` ( `Staff_Name`, `Designation`, `Salary`) VALUES ( @Staff_Name,@Designation, @Salary);";
                conn.Execute(query, new { Staff_Name = name, Designation = designation, Salary = salary });
                conn.Close();
                MessageBox.Show("Data Added Successfully");
                loadstaff();
            }
            else if(dialogResult == DialogResult.No)
            {

            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Delete staff", "You want to delete the staff", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var ID = staffidtbx.Text;
                using var conn = ConnectionProvider.GetDbConnection();

                var query = "DELETE FROM `staff` WHERE `staff`.`Staff_ID` = @Staff_ID;";
                conn.Execute(query, new { Staff_ID = ID });
                conn.Close();
                MessageBox.Show("Successfully Deleted");
                loadstaff();
            }
            else if(dialogResult != DialogResult.No)
            {

            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update staff", "You want to Update the staff", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var name = staffnametbx.Text;
                var designation = designationtbx.Text;
                var salary = salarytbx.Text;

                using var conn = ConnectionProvider.GetDbConnection();

                var query = "UPDATE `staff` SET `Staff_Name` = @Staff_Name, `Designation` = @Designation, `Salary`=@Salary;";

                conn.Execute(query, new { Staff_Name = name, Designation = designation, Salary = salary });

                conn.Close();
                MessageBox.Show("Successfully Updated");
                loadstaff();
            }
            else if(dialogResult == DialogResult.No)
            {

            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            staffidtbx.Clear();
            staffnametbx.Clear();
            designationtbx.Clear();
            salarytbx.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchtbx.Text!=null)
            {
                var query = "SELECT * FROM `staff` WHERE Staff_ID = @Staff_ID or Staff_Name = @Staff_Name ";

                using var conn = ConnectionProvider.GetDbConnection();
                var staffs = conn.Query<StaffModel>(query, new
                {
                    Staff_ID = searchtbx.Text,
                    Staff_Name = searchtbx.Text,

                });
                staffdgv.DataSource = staffs;
            }
        }

        private void Staffs_Load(object sender, EventArgs e)
        {
            loadstaff();
        }
    }
}
