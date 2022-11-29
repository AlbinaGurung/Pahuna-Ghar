
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
using DGVPrinterHelper;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using Transaction = Hotel_Management_System.Models.Transaction;

namespace Hotel_Management_System
{
    public partial class Form5 : Form
    {
        private BindingList<Transaction> billingItems;

        public Form5()
        {
            InitializeComponent();
            Load += Form5_Load1;

            billingItems = new BindingList<Transaction>();
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

            var obj = new Transaction();

            obj.Items=itemsCB.Text;
            obj.Discount= GetValue(discounttbx.Text);
           
            obj.Tax=GetValue(taxtbx.Text);
            obj.VAT=GetValue(vattbx.Text);
            obj.Rate=GetValue(ratetbx.Text);
            obj.Qty=Convert.ToInt32(quantitytbx.Text.ValueOrProvided("0"));
            obj.TotalAmount=calulate_total_amount();
            billingItems.Add(obj);//The items should be added into the binding list before the GetFullTotal() is called otherwise the list of items amount wouldnot have contained any amt.
            var fullTotal = GetFullTotal();
            Totaltbx.Text = fullTotal.ToString();
            

            //var TOTAL = obj.CalculateAmount();
            //Totaltbx.Text=Convert.ToString(TOTAL);
        }
        private decimal calulate_total_amount()
        {
            var discount = GetValue(discounttbx.Text.ValueOrProvided("0"));
            var qtn = GetValue(quantitytbx.Text.ValueOrProvided("0"));
            var rate = GetValue(ratetbx.Text.ValueOrProvided("0"));
            var vat = GetValue(vattbx.Text.ValueOrProvided("0"));
            var tax = GetValue(taxtbx.Text.ValueOrProvided("0"));
            var TotalAmount=(qtn*rate);

            TotalAmount=TotalAmount - discount+(TotalAmount*(tax/100))+(TotalAmount*(vat/100));
            return TotalAmount;
        }

        private decimal GetFullTotal()
        {

           var FullTotal= billingItems.Sum(x => x.TotalAmount);
            return FullTotal;
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
            var guestname = guestnametbx.Text;
            var guestcontact = GuestContacttbx.Text;
            var guestaddress = guestaddresstbx.Text;
            var customerpan = customerpantbx.Text;

            var billInsertQuery = @"INSERT INTO `bill`(`Date`, `GuestName`,`GuestContact`, `GuestAddress`, `CustomerPan`, `TotalAmount`) VALUES (@date,@GuestName,@GuestContact, @GuestAddress, @CustomerPan,@TotalAmount); select last_insert_id()";

            var billId = conn.ExecuteScalar<int>(billInsertQuery, new
            {
                date = DateTime.Now,
                GuestName = guestname,
                GuestContact = guestcontact,
                GuestAddress = guestaddress,
                CustomerPan = customerpan,
                TotalAmount = GetFullTotal()
            });

            foreach(var item in billingItems)
            {
                var query = "INSERT INTO `transactions` (`Bill_ID`,`Item_ID`, `Items`,`Descriptions`,`Rate`,`Qty`,`Discount`,`TAX`,`VAT`,`TotalAmount`) VALUES (@billID,@Item_ID,@Items,@Descriptions,@Rate,@Qty,@Discount,@TAX,@VAT,@TotalAmount);";
                conn.Execute(query, new {
                    Item_ID = item.Item_ID,
                  
                    Items = item.Items,
                    Descriptions = Descriptiontbx.Text,
                    Rate = item.Rate,
                    Qty = item.Qty,
                    Discount = item.Discount,
                    TAX = item.Tax,
                    VAT = item.VAT,
                    TotalAmount = item.TotalAmount,
                    billID = billId
                }) ;
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

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n\n\n\nPahuna Ghar";
            printer.SubTitle = $"\n\nBirtmode-4, Jhapa,Mechinagar\r\ntelephone: 023598 ph no:9806068043\n\n\n\n Date: {dateTimePicker2.Value.ToString("yyyy-mm-dd")}\n\n Customer Name: {guestnametbx.Text}   Customer Pan={customerpantbx.Text} Address: {customerpantbx.Text} \n\n\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = $"Discount: {discounttbx.Text}%\r\nTAX:{taxtbx.Text}%\r\nVAT: {vattbx.Text}%\r\nGrand Total: {Totaltbx.Text} \r\nThank You!!";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);

           /* DGVPrinter printer = new DGVPrinter();
            printer.Title="Bill";
            printer.SubTitle=String.Format("Products", printer.SubTitleColor=Color.Black, printer);
            printer.SubTitleFormatFlags=StringFormatFlags.LineLimit|StringFormatFlags.NoClip;
            printer.PageNumberInHeader=false;
            printer.PorportionalColumns=true;
            printer.Footer="List of products";
            printer.FooterSpacing=1;
            printer.PrintPreviewDataGridView(dataGridView1);
           */
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void GuestContacttbx_TextChanged(object sender, EventArgs e)
        {
            using var conn = ConnectionProvider.GetDbConnection();
            var query = "SELECT * from guests where Guest_Contact = @guestContact";


            var item = conn.Query<GuestModel>(query, new
            {
                guestContact = GuestContacttbx.Text
            });
            var guest = item.FirstOrDefault();

            if (guest!=null)
            {
                guestnametbx.Text = guest.Guest_Name;
                guestaddresstbx.Text=guest.Guest_Address;
                GuestIDtbx.Text=Convert.ToString(guest.Guest_ID);
                RoomNotbx.Text=Convert.ToString(guest.Room_No);
                

            }
            else
            {
                guestnametbx.Text = "";


            }

        }
    }
}
