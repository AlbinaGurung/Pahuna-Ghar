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
            idtbx.Clear();
            nametbx.Clear();
            desctbx.Clear();
            pricetbx.Clear();
            loadmeals();
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
            
                DialogResult dialogResult = MessageBox.Show("Add meal", "You want to add the new meal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
                else if (dialogResult==DialogResult.No)
                {
                    loadmeals();

                }
           
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
           
                DialogResult dialogResult = MessageBox.Show("Delete meal", "You want to delete the meal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var mealid = idtbx.Text;
                    using var conn = ConnectionProvider.GetDbConnection();

                    var query = "DELETE FROM `meals` WHERE `ID` = @ID1;";
                    conn.Execute(query, new { ID1= mealid });
                    conn.Close();
                    MessageBox.Show("Successfully Deleted");
                    loadmeals();

                }
                else if (dialogResult==DialogResult.No)
                {

                }
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
           

                DialogResult dialogResult = MessageBox.Show("Update meal", "You want to Update the meal", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var name = nametbx.Text;
                    var desc = desctbx.Text;
                    var price = pricetbx.Text;

                    using var conn = ConnectionProvider.GetDbConnection();

                    var query = "UPDATE `meals` SET `Name` = @Name, `Description` = @Description, `Price`=@Price;";

                    conn.Execute(query, new { Name = name, Description = desc, Price = price });

                    conn.Close();
                    MessageBox.Show("Successfully Updated");
                    loadmeals();
                }
                else if (dialogResult==DialogResult.No)
                {

                }
          
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

        private void Pahunalbl_Click(object sender, EventArgs e)
        {

        }
    }
}
