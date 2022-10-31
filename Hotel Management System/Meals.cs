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
    public partial class MealsFrm : Form
    {
        public MealsFrm()
        {
            InitializeComponent();
        }
        private void loadmeals()
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * FROM `meals`";
            var Meals = conn.Query<MealsModel>(query, new { });
            mealsdgv.DataSource=Meals;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var name = nametbx.Text;
            var desc = desctbx.Text;
            var price = pricetbx.Text;

            using var conn = ConnectionProvider.GetDbConnection();
            var query = "INSERT INTO `meals` ( `Name`, `Description`, `Price`) VALUES ( @Name,@Description, @Price);";
            conn.Execute(query, new { Name = name, Description = desc, Price = price });
            conn.Close();
            MessageBox.Show("Data Added Successfully");
            loadmeals();
        }

        private void gobackbtn_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var mealid = idtbx.Text;
            using var conn = ConnectionProvider.GetDbConnection();

            var query = "DELETE FROM `drinks` WHERE `meals`.`ID` = @ID;";
            conn.Execute(query, new { ID = mealid});
            conn.Close();
            MessageBox.Show("Successfully Deleted");
            loadmeals();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var name = nametbx.Text;
            var desc = desctbx.Text;
            var price = pricetbx.Text;

            using var conn = ConnectionProvider.GetDbConnection();

            var query = "UPDATE `meals` SET `Name` = @Name, `Description` = @Description, `Price`=@Price;";

            conn.Execute(query, new { Name = name, Description = desc,Price = price });

            conn.Close();
            MessageBox.Show("Successfully Updated");
            loadmeals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchtbx.Text!=null)
            {
                var query = "SELECT * FROM `meals` WHERE ID = @ID or Name = @Name ";

                using var conn = ConnectionProvider.GetDbConnection();
                var meals = conn.Query<MealsModel>(query, new
                {
                   ID = searchtbx.Text,
                   Name = searchtbx.Text,

                });
              mealsdgv.DataSource = meals;
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
           idtbx.Clear();
            nametbx.Clear();
            desctbx.Clear();
            pricetbx.Clear();
            loadmeals();
        }

        private void mealsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mealsdgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                mealsdgv.CurrentRow.Selected=true;
                idtbx.Text=mealsdgv.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                nametbx.Text=mealsdgv.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                desctbx.Text=mealsdgv.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                pricetbx.Text=mealsdgv.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }

        private void MealsFrm_Load(object sender, EventArgs e)
        {
            loadmeals();
        }
    }
}
