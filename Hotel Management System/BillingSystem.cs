
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Dapper;
using Hotel_Management_System.Classes;
using Hotel_Management_System.Extensions;
using Hotel_Management_System.Models;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Hotel_Management_System
{
    public partial class Form5 : Form
    {
        private BindingList<Items> billingItems;

        public Form5()
        {
            InitializeComponent();
            Load += Form5_Load1;
            billingItems = new BindingList<Items>();
            dataGridView1.DataSource = billingItems;
        }

        private void Form5_Load1(object? sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * from items";

            var items = conn.Query<ItemsModel>(query);
            itemsCB.DataSource = items;
            itemsCB.DisplayMember = nameof(ItemsModel.Item);
            itemsCB.ValueMember = nameof(ItemsModel.Item_ID);
        }

       /* private void print()
        {
           
               dataGridView1 printer = new dataGridView1();
                printer.Title = "\r\n\r\n\n\n\nPahuna Ghar";
                printer.SubTitle = $"\n\nMechinagar-6, Jhapa\r\nPhone: 98xxxxxxxxxxx\n\n\n\n Date: {dateTimePickerBill.Value.ToString("yyyy-mm-dd")}\n\n Supplier Name: {textBoxSupplierName.Text}    Address: {textBoxAddress.Text}\n\n\n\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = $"Discount: {discounttbx.Value}%\r\nVAT: {vattbx.Value}%\r\nGrand Total: {Totaltbx.Value} \r\nThank You!!";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridViewAddedProducts);

            

        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoBackbtn_Click(object sender, EventArgs e)
        {

            Dashboard d1 = new Dashboard();
            this.Hide();
            d1.ShowDialog();
            d1.Show();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* try
             {
                 using var conn = ConnectionProvider.GetDbConnection();
                 string selectquery = "SELECT * FROM `items`";

                 MySqlCommand command = new MySqlCommand(selectquery, (MySqlConnection)conn);
                 MySqlDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     comboBox1.Items.Add(reader.GetString("Item"));
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/

            var selectedItem = (ItemsModel)itemsCB.SelectedItem;
            //using var conn = ConnectionProvider.GetDbConnection();
            //string selectquery = "SELECT * FROM `items` WHERE Item=@item;";
            //var item = conn.QueryFirstOrDefault<Items>(selectquery, new
            //{
            //    item = comboBox1.Text
            //});

            //if (item == null) return;

            var rate = selectedItem.Rate;
            var desc = selectedItem.Descriptions;

            Descriptiontbx.Text=desc;
            ratetbx.Text=rate.ToString();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // add to binding list

            var obj = new Items();

            obj.Item=itemsCB.Text;
            obj.Discount= GetValue(discounttbx.Text);
            obj.Tax=GetValue(taxtbx.Text);
            obj.VAT=GetValue(vattbx.Text);
            obj.Rate=GetValue(ratetbx.Text);
            obj.Qty=Convert.ToInt32(quantitytbx.Text.ValueOrProvided("0"));
            var TOTAL = obj.CalculateAmount();
            var fullTotal = GetTotalAmount();
            Totaltbx.Text = fullTotal.ToString();
            billingItems.Add(obj);
            Totaltbx.Text=Convert.ToString(TOTAL);
        }

        private decimal GetTotalAmount()
        {
            return billingItems.Sum(x => x.TotalAmount);
        }

        public decimal GetValue(string text)
        {
            if (!decimal.TryParse(text, out decimal result))
            {
                return 0;
            }
            return result;
        }

        private void savedatabtn_Click(object sender, EventArgs e)
        {
            using var tx = new TransactionScope();
            using var conn = ConnectionProvider.GetDbConnection();
            var customername = customernametbx.Text;
            var customeraddress = customeraddresstbx.Text;
            var customerpan = customerpantbx.Text;

            var billInsertQuery = @"INSERT INTO `bill`(`Date`, `CustomerName`, `CustomerAddress`, `CustomerPan`, `TotalAmount`) VALUES (@date, @CustomerName, @CustomerAddress, @CustomerPan,@TotalAmount); select last_insert_id()";

            var billId = conn.ExecuteScalar<int>(billInsertQuery, new
            {
                date = DateTime.Now,
                CustomerName = customername,
                customerAddress = customeraddress,
                CustomerPan = customerpan,
                TotalAmount = GetTotalAmount()
            });

            foreach(var item in billingItems)
            {
                var query = "INSERT INTO `transactions` (`Bill_ID`,`Item_ID`, `Items`,`Descriptions`,`Rate`,`Qty`,`Discount`,`TAX`,`VAT`,`TotalAmount`) VALUES (@billID,@Item_ID,@Items,@Descriptions,@Rate,@Qty,@Discount,@TAX,@VAT,@TotalAmount);";
                conn.Execute(query, new { 
                    Item_ID = item.Item_Id,
                    Items=item.Item,
                    Descriptions=Descriptiontbx.Text,
                    Rate=item.Rate,
                    Qty=item.Qty,
                    Discount=item.Discount,
                    TAX=item.Tax,
                    VAT=item.VAT,
                    TotalAmount=item.TotalAmount,
                    billID = billId
                });
            }
                                              /*
            for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {

                //var query= $"INSERT INTO `transactions` (`Item_ID`, `Items`,`Descriptions`,`Rate`,`Qtn`,`Discount`,`TAX`,`VAT`,`TotalAmount`) VALUES ('"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[1].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"','"+dataGridView1.Rows[i].Cells[4].Value+"','"+dataGridView1.Rows[i].Cells[5].Value+"','"+dataGridView1.Rows[i].Cells[6].Value+"','"+dataGridView1.Rows[i].Cells[7].Value+"','"+dataGridView1.Rows[i].Cells[8].Value+"')";
                var query = $"INSERT INTO `transactions` (`Item_ID`, `Items`,`Descriptions`,`Rate`,`Qtn`,`Discount`,`Tax`,`VAT`,`TotalAmount`) VALUES ('"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[1].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"','"+dataGridView1.Rows[i].Cells[4].Value+"','"+dataGridView1.Rows[i].Cells[5].Value+"','"+dataGridView1.Rows[i].Cells[6].Value+"','"+dataGridView1.Rows[i].Cells[7].Value+"','"+dataGridView1.Rows[i].Cells[8].Value+"')";
                conn.Execute(query);
            }*/
            tx.Complete();
            MessageBox.Show("Added Successfully");
            dataGridView1.Rows.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
