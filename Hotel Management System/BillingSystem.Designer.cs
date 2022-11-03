namespace Hotel_Management_System
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ratetbx = new System.Windows.Forms.TextBox();
            this.Totaltbx = new System.Windows.Forms.TextBox();
            this.discounttbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantitytbx = new System.Windows.Forms.TextBox();
            this.taxtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vattbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Descriptiontbx = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoBackbtn = new System.Windows.Forms.Button();
            this.bsitems = new System.Windows.Forms.BindingSource(this.components);
            this.savedatabtn = new System.Windows.Forms.Button();
            this.customernametbx = new System.Windows.Forms.TextBox();
            this.customerpantbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.customeraddresstbx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.roomcb = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsitems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(345, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICE";
            // 
            // itemsCB
            // 
            this.itemsCB.FormattingEnabled = true;
            this.itemsCB.Location = new System.Drawing.Point(35, 162);
            this.itemsCB.Name = "itemsCB";
            this.itemsCB.Size = new System.Drawing.Size(66, 23);
            this.itemsCB.TabIndex = 1;
            this.itemsCB.Text = "ITEMS";
            this.itemsCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(775, 251);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ratetbx
            // 
            this.ratetbx.Location = new System.Drawing.Point(310, 162);
            this.ratetbx.Name = "ratetbx";
            this.ratetbx.Size = new System.Drawing.Size(59, 23);
            this.ratetbx.TabIndex = 3;
            this.ratetbx.Text = "0";
            this.ratetbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Totaltbx
            // 
            this.Totaltbx.Location = new System.Drawing.Point(680, 448);
            this.Totaltbx.Name = "Totaltbx";
            this.Totaltbx.Size = new System.Drawing.Size(120, 23);
            this.Totaltbx.TabIndex = 5;
            this.Totaltbx.Text = "TOTAL";
            this.Totaltbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // discounttbx
            // 
            this.discounttbx.Location = new System.Drawing.Point(446, 162);
            this.discounttbx.Name = "discounttbx";
            this.discounttbx.Size = new System.Drawing.Size(70, 23);
            this.discounttbx.TabIndex = 7;
            this.discounttbx.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(310, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(375, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(446, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // quantitytbx
            // 
            this.quantitytbx.Location = new System.Drawing.Point(375, 162);
            this.quantitytbx.Name = "quantitytbx";
            this.quantitytbx.Size = new System.Drawing.Size(65, 23);
            this.quantitytbx.TabIndex = 13;
            this.quantitytbx.Text = "0";
            // 
            // taxtbx
            // 
            this.taxtbx.Location = new System.Drawing.Point(522, 162);
            this.taxtbx.Name = "taxtbx";
            this.taxtbx.Size = new System.Drawing.Size(62, 23);
            this.taxtbx.TabIndex = 14;
            this.taxtbx.Tag = "";
            this.taxtbx.Text = "0";
            this.taxtbx.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(522, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tax:";
            // 
            // vattbx
            // 
            this.vattbx.Location = new System.Drawing.Point(590, 162);
            this.vattbx.Name = "vattbx";
            this.vattbx.Size = new System.Drawing.Size(50, 23);
            this.vattbx.TabIndex = 16;
            this.vattbx.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(587, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "VAT:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(107, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description:";
            // 
            // Descriptiontbx
            // 
            this.Descriptiontbx.Location = new System.Drawing.Point(107, 162);
            this.Descriptiontbx.Name = "Descriptiontbx";
            this.Descriptiontbx.Size = new System.Drawing.Size(95, 23);
            this.Descriptiontbx.TabIndex = 21;
            this.Descriptiontbx.Text = "Description";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addbtn.Location = new System.Drawing.Point(652, 162);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(137, 23);
            this.addbtn.TabIndex = 22;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(285, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(63, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = " PRINT BILL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(276, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 34);
            this.label12.TabIndex = 26;
            this.label12.Text = "PAHUNA GHAR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Papyrus", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(310, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 42);
            this.label13.TabIndex = 27;
            this.label13.Text = "Live with joy !";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(607, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 48);
            this.label11.TabIndex = 28;
            this.label11.Text = "Contact No.: 98xxxxxxxx\r\nAddress: Birtanode, Jhapa\r\nNEPAL, 57204\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 23);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.GoBackbtn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 91);
            this.panel1.TabIndex = 30;
            // 
            // GoBackbtn
            // 
            this.GoBackbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GoBackbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoBackbtn.ForeColor = System.Drawing.Color.White;
            this.GoBackbtn.Location = new System.Drawing.Point(63, 32);
            this.GoBackbtn.Name = "GoBackbtn";
            this.GoBackbtn.Size = new System.Drawing.Size(107, 35);
            this.GoBackbtn.TabIndex = 57;
            this.GoBackbtn.Text = "Go Back";
            this.GoBackbtn.UseVisualStyleBackColor = false;
            this.GoBackbtn.Click += new System.EventHandler(this.GoBackbtn_Click);
            // 
            // savedatabtn
            // 
            this.savedatabtn.BackColor = System.Drawing.Color.Lime;
            this.savedatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savedatabtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savedatabtn.Location = new System.Drawing.Point(485, 477);
            this.savedatabtn.Name = "savedatabtn";
            this.savedatabtn.Size = new System.Drawing.Size(189, 38);
            this.savedatabtn.TabIndex = 31;
            this.savedatabtn.Text = "Save Data";
            this.savedatabtn.UseVisualStyleBackColor = false;
            this.savedatabtn.Click += new System.EventHandler(this.savedatabtn_Click);
            // 
            // customernametbx
            // 
            this.customernametbx.Location = new System.Drawing.Point(932, 219);
            this.customernametbx.Name = "customernametbx";
            this.customernametbx.Size = new System.Drawing.Size(100, 23);
            this.customernametbx.TabIndex = 33;
            // 
            // customerpantbx
            // 
            this.customerpantbx.Location = new System.Drawing.Point(932, 280);
            this.customerpantbx.Name = "customerpantbx";
            this.customerpantbx.Size = new System.Drawing.Size(100, 23);
            this.customerpantbx.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(841, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(827, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "CustomerName";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(827, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "CustomerAddress";
            // 
            // customeraddresstbx
            // 
            this.customeraddresstbx.Location = new System.Drawing.Point(932, 248);
            this.customeraddresstbx.Name = "customeraddresstbx";
            this.customeraddresstbx.Size = new System.Drawing.Size(100, 23);
            this.customeraddresstbx.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(827, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "CustomerPan";
            // 
            // roomcb
            // 
            this.roomcb.FormattingEnabled = true;
            this.roomcb.Location = new System.Drawing.Point(932, 316);
            this.roomcb.Name = "roomcb";
            this.roomcb.Size = new System.Drawing.Size(96, 23);
            this.roomcb.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(853, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "Room:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(832, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1044, 527);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.roomcb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customeraddresstbx);
            this.Controls.Add(this.customerpantbx);
            this.Controls.Add(this.customernametbx);
            this.Controls.Add(this.savedatabtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Descriptiontbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vattbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taxtbx);
            this.Controls.Add(this.quantitytbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discounttbx);
            this.Controls.Add(this.Totaltbx);
            this.Controls.Add(this.ratetbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemsCB);
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox itemsCB;
        private DataGridView dataGridView1;
        private TextBox ratetbx;
        private TextBox Totaltbx;
        private TextBox discounttbx;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox quantitytbx;
        private TextBox taxtbx;
        private Label label7;
        private TextBox vattbx;
        private Label label8;
        private Label label10;
        private TextBox Descriptiontbx;
        private Button addbtn;
        private Button button2;
        private Button button3;
        private Label label12;
        private Label label13;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button GoBackbtn;
        private BindingSource bsitems;
        private Button savedatabtn;
        private TextBox customernametbx;
        private TextBox customerpantbx;
        private Label label9;
        private Label label14;
        private Label label15;
        private TextBox customeraddresstbx;
        private Label label16;
        private ComboBox roomcb;
        private Label label17;
        private DateTimePicker dateTimePicker2;
    }
}