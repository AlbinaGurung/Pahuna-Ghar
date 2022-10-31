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
using Dapper;

namespace Hotel_Management_System
{
    public partial class DrinksModel : Form
    {
        public DrinksModel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var name = drinknametbx.Text;
            var desc = desctbx.Text;
            var price=drinkpricetbx.Text;
            
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "INSERT INTO `drinks` ( `Drink_Name`, `Drink_Description`, `Drink_Price`) VALUES ( @Drink_Name,@Drink_Description, @Drink_Price);";
            conn.Execute(query, new { Drink_Name = name,Drink_Description=desc,Drink_Price=price }) ;
            conn.Close();
            MessageBox.Show("Data Added Successfully");
            loaddrinks();
        }
        public void loaddrinks()
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * FROM `drinks`";
            var Drinks = conn.Query<DrinksModel>(query, new {});
            drinksdgv.DataSource=Drinks;

        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            loaddrinks();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var ID = drinkidtbx.Text;
            using var conn = ConnectionProvider.GetDbConnection();

            var query = "DELETE FROM `drinks` WHERE `drinks`.`Drink_ID` = @Drink_ID;";
            conn.Execute(query, new { Drink_ID = ID });
            conn.Close();
            MessageBox.Show("Successfully Deleted");


        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var name = drinknametbx.Text;
            var desc = desctbx.Text;
            var price = drinkpricetbx.Text;

            using var conn = ConnectionProvider.GetDbConnection();

            var query = "UPDATE `drinks` SET `Drink_Name` = @Drink_Name, `Drink_Description` = @Drink_Description, `Drink_Price`=@price;";

            conn.Execute(query, new {Drink_Name=name,Drink_Description=desc,Drink_Price=price });

            conn.Close();
            MessageBox.Show("Successfully Updated");
            loaddrinks();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            drinkidtbx.Clear();
            drinknametbx.Clear();
            desctbx.Clear();
            drinkpricetbx.Clear();
            loaddrinks();
        }

        private void searchtbx_TextChanged(object sender, EventArgs e)
        {
            if(searchtbx.Text!=null)
            {
                var query = "SELECT * FROM `drinks` WHERE Drink_ID = @Drink_ID or Drink_Name = @Drink_Name ";

                using var conn = ConnectionProvider.GetDbConnection();
                var drinks = conn.Query<DrinksModel>(query, new
                {
                    Drink_ID = searchtbx.Text,
                    Drink_Name = searchtbx.Text,
                    
                });
                drinksdgv.DataSource = drinks;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void drinkidtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void drinknametbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void desctbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void drinkpricetbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();

        }

        private void drinksdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (drinksdgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                drinksdgv.CurrentRow.Selected=true;
                drinkidtbx.Text=drinksdgv.Rows[e.RowIndex].Cells["Drink_ID"].FormattedValue.ToString();
                drinknametbx.Text=drinksdgv.Rows[e.RowIndex].Cells["Drink_Name"].FormattedValue.ToString();
                desctbx.Text=drinksdgv.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                drinkpricetbx.Text=drinksdgv.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            }
        }
    }
}
