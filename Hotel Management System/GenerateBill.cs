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

using Hotel_Management_System.Extensions;

namespace Hotel_Management_System
{
   
    public partial class GenerateBill : Form
    {
        private BindingList<Items> billingItems;
        public GenerateBill()
        {
            InitializeComponent();
            billingItems = new BindingList<Items>();
            dataGridView1.DataSource = billingItems;

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * from `customers`";

            var guests = conn.Query<GuestModel>(query ,new {});
            

           
        }

        private void GuestContacttbx_TextChanged(object sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection ();
           // var query = "SELECT * FROM customers WHERE Guest_Contact=@GuestContact;";
            
            var query2 = "SELECT *FROM `Transactions` WHERE Guest_Contact=@GuestContact;";
            
           

            var transactions = conn.Query<Items>(query2, new
            {
                GuestContact = GuestContacttbx.Text
            });
            dataGridView1.DataSource = transactions;
           
            
            //var guests= conn.Query<GuestModel>(query, new
           // { 
            //    GuestContact = GuestContacttbx.Text 
            //}); 




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
    }
}



