using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System;

namespace Hotel_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guests g1 = new Guests();
            this.Hide();
            g1.ShowDialog();
            g1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            this.Hide();
            f1.ShowDialog();
            f1.Show();



        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dgv.SelectedRows.Count>=0)
                {

                }
            }
            catch(Exception)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard D1 = new Dashboard();
            RoomsForm f1 = new RoomsForm();
            D1.Hide();
            f1.ShowDialog();
            D1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DrinksModel f1 = new DrinksModel();
            this.Hide();
            f1.ShowDialog();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             MealsFrm f1 = new MealsFrm();
            this.Hide();
            f1.ShowDialog();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staffs f1 = new Staffs();
            this.Hide();
            f1.ShowDialog();
            f1.Show();
        }
    }
}
