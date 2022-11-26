 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.Models;
using Dapper;
using BCrypt;
namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            var username=untbx.Text;
            

            var password=pwtbx.Text;
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username");
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password");
            }
            if(IsUserPasswordSame(username,password))
            {
                Dashboard f1 = new Dashboard();
                this.Hide();
                f1.ShowDialog();
                Show();
             }
            else
            {
                MessageBox.Show("Username/password incorrect");
            }
          }
        private bool IsUserPasswordSame(string username, string password)
        
        {

            using var conn = ConnectionProvider.GetDbConnection();
            //define query
            var query = $"SELECT * FROM `login` WHERE Username=@user_name;";

            // execute query
                var user = conn.QueryFirstOrDefault<User>(query, new { user_name = username });

            if (user == null) return false;
            else
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return true;
                }
                else return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            untbx.Clear();
            pwtbx.Clear();
            untbx.Focus();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            var username = untbx.Text;
            var password = pwtbx.Text;
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var conn = ConnectionProvider.GetDbConnection();
            var userCountQuery = "SELECT COUNT(*) FROM `login`;";

            var usercount = conn.QueryFirstOrDefault<int>(userCountQuery);
            if(usercount>0)
            {
                MessageBox.Show("Multiple User registration not supported");
                return;
            }

            var query = "INSERT INTO `login` (`ID`, `Username`, `Password`) VALUES (NULL, @user_name, @user_password)";

            conn.Execute(query, new { user_name = username ,user_password=hashedPassword});
            MessageBox.Show("Registration Complete");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pwtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}