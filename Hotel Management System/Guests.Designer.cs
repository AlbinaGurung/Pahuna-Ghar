namespace Hotel_Management_System
{
    partial class Guests
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
            this.GuestID = new System.Windows.Forms.Label();
            this.GuestIDtbx = new System.Windows.Forms.TextBox();
            this.GuestNametbx = new System.Windows.Forms.TextBox();
            this.GuestNamelbl = new System.Windows.Forms.Label();
            this.GuestAddresstbx = new System.Windows.Forms.TextBox();
            this.GuestIDlbl = new System.Windows.Forms.Label();
            this.GuestContacttbx = new System.Windows.Forms.TextBox();
            this.GuestContactlbl = new System.Windows.Forms.Label();
            this.GuestEmailtbx = new System.Windows.Forms.TextBox();
            this.GuestEmaillbl = new System.Windows.Forms.Label();
            this.RoomNotbx = new System.Windows.Forms.TextBox();
            this.RoomNolbl = new System.Windows.Forms.Label();
            this.NoOfIndividualstbx = new System.Windows.Forms.TextBox();
            this.NoOfIndividualslbl = new System.Windows.Forms.Label();
            this.Checkinlbl = new System.Windows.Forms.Label();
            this.CheckOutlbl = new System.Windows.Forms.Label();
            this.guestDgv = new System.Windows.Forms.DataGridView();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.Searchtbx = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.CheckinTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckoutTimepicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Gharlbl = new System.Windows.Forms.Label();
            this.Pahunalbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gotoroombtn = new System.Windows.Forms.Button();
            this.gotomealsbtn = new System.Windows.Forms.Button();
            this.gotodrinksbtn = new System.Windows.Forms.Button();
            this.generatebillbtn = new System.Windows.Forms.Button();
            this.dgvrooms = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Guest_Pan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guestDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestID
            // 
            this.GuestID.AutoSize = true;
            this.GuestID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestID.Location = new System.Drawing.Point(38, 141);
            this.GuestID.Name = "GuestID";
            this.GuestID.Size = new System.Drawing.Size(69, 21);
            this.GuestID.TabIndex = 0;
            this.GuestID.Text = "Guest ID";
            // 
            // GuestIDtbx
            // 
            this.GuestIDtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestIDtbx.Location = new System.Drawing.Point(154, 133);
            this.GuestIDtbx.Name = "GuestIDtbx";
            this.GuestIDtbx.Size = new System.Drawing.Size(169, 29);
            this.GuestIDtbx.TabIndex = 1;
            this.GuestIDtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GuestNametbx
            // 
            this.GuestNametbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestNametbx.Location = new System.Drawing.Point(426, 133);
            this.GuestNametbx.Name = "GuestNametbx";
            this.GuestNametbx.Size = new System.Drawing.Size(169, 29);
            this.GuestNametbx.TabIndex = 3;
            // 
            // GuestNamelbl
            // 
            this.GuestNamelbl.AutoSize = true;
            this.GuestNamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestNamelbl.Location = new System.Drawing.Point(328, 141);
            this.GuestNamelbl.Name = "GuestNamelbl";
            this.GuestNamelbl.Size = new System.Drawing.Size(96, 21);
            this.GuestNamelbl.TabIndex = 2;
            this.GuestNamelbl.Text = "Guest Name";
            // 
            // GuestAddresstbx
            // 
            this.GuestAddresstbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestAddresstbx.Location = new System.Drawing.Point(748, 133);
            this.GuestAddresstbx.Name = "GuestAddresstbx";
            this.GuestAddresstbx.Size = new System.Drawing.Size(169, 29);
            this.GuestAddresstbx.TabIndex = 5;
            // 
            // GuestIDlbl
            // 
            this.GuestIDlbl.AutoSize = true;
            this.GuestIDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestIDlbl.Location = new System.Drawing.Point(632, 141);
            this.GuestIDlbl.Name = "GuestIDlbl";
            this.GuestIDlbl.Size = new System.Drawing.Size(110, 21);
            this.GuestIDlbl.TabIndex = 4;
            this.GuestIDlbl.Text = "Guest Address";
            // 
            // GuestContacttbx
            // 
            this.GuestContacttbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestContacttbx.Location = new System.Drawing.Point(154, 185);
            this.GuestContacttbx.Name = "GuestContacttbx";
            this.GuestContacttbx.Size = new System.Drawing.Size(169, 29);
            this.GuestContacttbx.TabIndex = 7;
            this.GuestContacttbx.TextChanged += new System.EventHandler(this.GuestContacttbx_TextChanged);
            // 
            // GuestContactlbl
            // 
            this.GuestContactlbl.AutoSize = true;
            this.GuestContactlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestContactlbl.Location = new System.Drawing.Point(22, 193);
            this.GuestContactlbl.Name = "GuestContactlbl";
            this.GuestContactlbl.Size = new System.Drawing.Size(107, 21);
            this.GuestContactlbl.TabIndex = 6;
            this.GuestContactlbl.Text = "Guest Contact";
            this.GuestContactlbl.Click += new System.EventHandler(this.GuestContactlbl_Click);
            // 
            // GuestEmailtbx
            // 
            this.GuestEmailtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestEmailtbx.Location = new System.Drawing.Point(426, 182);
            this.GuestEmailtbx.Name = "GuestEmailtbx";
            this.GuestEmailtbx.Size = new System.Drawing.Size(169, 29);
            this.GuestEmailtbx.TabIndex = 9;
            // 
            // GuestEmaillbl
            // 
            this.GuestEmaillbl.AutoSize = true;
            this.GuestEmaillbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestEmaillbl.Location = new System.Drawing.Point(337, 185);
            this.GuestEmaillbl.Name = "GuestEmaillbl";
            this.GuestEmaillbl.Size = new System.Drawing.Size(92, 21);
            this.GuestEmaillbl.TabIndex = 8;
            this.GuestEmaillbl.Text = "Guest Email";
            // 
            // RoomNotbx
            // 
            this.RoomNotbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNotbx.Location = new System.Drawing.Point(748, 182);
            this.RoomNotbx.Name = "RoomNotbx";
            this.RoomNotbx.Size = new System.Drawing.Size(169, 29);
            this.RoomNotbx.TabIndex = 11;
            this.RoomNotbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.RoomNotbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomNotbx_KeyPress);
            // 
            // RoomNolbl
            // 
            this.RoomNolbl.AutoSize = true;
            this.RoomNolbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNolbl.Location = new System.Drawing.Point(632, 182);
            this.RoomNolbl.Name = "RoomNolbl";
            this.RoomNolbl.Size = new System.Drawing.Size(77, 21);
            this.RoomNolbl.TabIndex = 10;
            this.RoomNolbl.Text = "Room No";
            this.RoomNolbl.Click += new System.EventHandler(this.RoomNolbl_Click);
            // 
            // NoOfIndividualstbx
            // 
            this.NoOfIndividualstbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoOfIndividualstbx.Location = new System.Drawing.Point(154, 225);
            this.NoOfIndividualstbx.Name = "NoOfIndividualstbx";
            this.NoOfIndividualstbx.Size = new System.Drawing.Size(169, 29);
            this.NoOfIndividualstbx.TabIndex = 13;
            // 
            // NoOfIndividualslbl
            // 
            this.NoOfIndividualslbl.AutoSize = true;
            this.NoOfIndividualslbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoOfIndividualslbl.Location = new System.Drawing.Point(17, 228);
            this.NoOfIndividualslbl.Name = "NoOfIndividualslbl";
            this.NoOfIndividualslbl.Size = new System.Drawing.Size(131, 21);
            this.NoOfIndividualslbl.TabIndex = 12;
            this.NoOfIndividualslbl.Text = "No Of Individuals";
            // 
            // Checkinlbl
            // 
            this.Checkinlbl.AutoSize = true;
            this.Checkinlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Checkinlbl.Location = new System.Drawing.Point(351, 267);
            this.Checkinlbl.Name = "Checkinlbl";
            this.Checkinlbl.Size = new System.Drawing.Size(69, 21);
            this.Checkinlbl.TabIndex = 14;
            this.Checkinlbl.Text = "Check In";
            // 
            // CheckOutlbl
            // 
            this.CheckOutlbl.AutoSize = true;
            this.CheckOutlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckOutlbl.Location = new System.Drawing.Point(632, 268);
            this.CheckOutlbl.Name = "CheckOutlbl";
            this.CheckOutlbl.Size = new System.Drawing.Size(82, 21);
            this.CheckOutlbl.TabIndex = 16;
            this.CheckOutlbl.Text = "Check Out";
            // 
            // guestDgv
            // 
            this.guestDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDgv.Location = new System.Drawing.Point(17, 434);
            this.guestDgv.Name = "guestDgv";
            this.guestDgv.RowTemplate.Height = 25;
            this.guestDgv.Size = new System.Drawing.Size(604, 148);
            this.guestDgv.TabIndex = 18;
            this.guestDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestDgv_CellClick);
            // 
            // ADDbtn
            // 
            this.ADDbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADDbtn.Location = new System.Drawing.Point(86, 393);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(115, 33);
            this.ADDbtn.TabIndex = 29;
            this.ADDbtn.Text = "ADD";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // Searchtbx
            // 
            this.Searchtbx.Location = new System.Drawing.Point(609, 406);
            this.Searchtbx.Name = "Searchtbx";
            this.Searchtbx.Size = new System.Drawing.Size(171, 23);
            this.Searchtbx.TabIndex = 31;
            this.Searchtbx.TextChanged += new System.EventHandler(this.Searchtbx_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearbtn.Location = new System.Drawing.Point(480, 380);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(115, 34);
            this.clearbtn.TabIndex = 32;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(786, 405);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 24);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebtn.Location = new System.Drawing.Point(222, 380);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(101, 34);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Updatebtn.Location = new System.Drawing.Point(351, 380);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(105, 34);
            this.Updatebtn.TabIndex = 35;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // CheckinTimePicker
            // 
            this.CheckinTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckinTimePicker.Location = new System.Drawing.Point(440, 267);
            this.CheckinTimePicker.Name = "CheckinTimePicker";
            this.CheckinTimePicker.Size = new System.Drawing.Size(169, 23);
            this.CheckinTimePicker.TabIndex = 36;
            // 
            // CheckoutTimepicker
            // 
            this.CheckoutTimepicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutTimepicker.Location = new System.Drawing.Point(748, 265);
            this.CheckoutTimepicker.Name = "CheckoutTimepicker";
            this.CheckoutTimepicker.Size = new System.Drawing.Size(169, 23);
            this.CheckoutTimepicker.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(426, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 30);
            this.label13.TabIndex = 38;
            this.label13.Text = "Live with joy !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Gharlbl);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Pahunalbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 80);
            this.panel1.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Gharlbl
            // 
            this.Gharlbl.AutoSize = true;
            this.Gharlbl.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gharlbl.ForeColor = System.Drawing.Color.White;
            this.Gharlbl.Location = new System.Drawing.Point(499, 9);
            this.Gharlbl.Name = "Gharlbl";
            this.Gharlbl.Size = new System.Drawing.Size(122, 37);
            this.Gharlbl.TabIndex = 40;
            this.Gharlbl.Text = "GHAR";
            // 
            // Pahunalbl
            // 
            this.Pahunalbl.AutoSize = true;
            this.Pahunalbl.Font = new System.Drawing.Font("Century Schoolbook", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pahunalbl.ForeColor = System.Drawing.Color.White;
            this.Pahunalbl.Location = new System.Drawing.Point(351, 9);
            this.Pahunalbl.Name = "Pahunalbl";
            this.Pahunalbl.Size = new System.Drawing.Size(156, 36);
            this.Pahunalbl.TabIndex = 39;
            this.Pahunalbl.Text = "PAHUNA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gender";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.GenderComboBox.Location = new System.Drawing.Point(154, 265);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 23);
            this.GenderComboBox.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gotoroombtn
            // 
            this.gotoroombtn.BackColor = System.Drawing.Color.MediumBlue;
            this.gotoroombtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gotoroombtn.ForeColor = System.Drawing.Color.White;
            this.gotoroombtn.Location = new System.Drawing.Point(943, 251);
            this.gotoroombtn.Name = "gotoroombtn";
            this.gotoroombtn.Size = new System.Drawing.Size(131, 48);
            this.gotoroombtn.TabIndex = 46;
            this.gotoroombtn.Text = "GoToRooms";
            this.gotoroombtn.UseVisualStyleBackColor = false;
            this.gotoroombtn.Click += new System.EventHandler(this.gotoroombtn_Click);
            // 
            // gotomealsbtn
            // 
            this.gotomealsbtn.BackColor = System.Drawing.Color.MediumBlue;
            this.gotomealsbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gotomealsbtn.ForeColor = System.Drawing.Color.White;
            this.gotomealsbtn.Location = new System.Drawing.Point(943, 305);
            this.gotomealsbtn.Name = "gotomealsbtn";
            this.gotomealsbtn.Size = new System.Drawing.Size(131, 43);
            this.gotomealsbtn.TabIndex = 47;
            this.gotomealsbtn.Text = "GoToMeals";
            this.gotomealsbtn.UseVisualStyleBackColor = false;
            this.gotomealsbtn.Click += new System.EventHandler(this.gotomealsbtn_Click);
            // 
            // gotodrinksbtn
            // 
            this.gotodrinksbtn.BackColor = System.Drawing.Color.MediumBlue;
            this.gotodrinksbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gotodrinksbtn.ForeColor = System.Drawing.Color.White;
            this.gotodrinksbtn.Location = new System.Drawing.Point(943, 348);
            this.gotodrinksbtn.Name = "gotodrinksbtn";
            this.gotodrinksbtn.Size = new System.Drawing.Size(131, 39);
            this.gotodrinksbtn.TabIndex = 48;
            this.gotodrinksbtn.Text = "GoToDrinks";
            this.gotodrinksbtn.UseVisualStyleBackColor = false;
            this.gotodrinksbtn.Click += new System.EventHandler(this.gotodrinksbtn_Click);
            // 
            // generatebillbtn
            // 
            this.generatebillbtn.BackColor = System.Drawing.Color.Green;
            this.generatebillbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generatebillbtn.ForeColor = System.Drawing.Color.White;
            this.generatebillbtn.Location = new System.Drawing.Point(911, 393);
            this.generatebillbtn.Name = "generatebillbtn";
            this.generatebillbtn.Size = new System.Drawing.Size(151, 38);
            this.generatebillbtn.TabIndex = 49;
            this.generatebillbtn.Text = "GenerateBill";
            this.generatebillbtn.UseVisualStyleBackColor = false;
            // 
            // dgvrooms
            // 
            this.dgvrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrooms.Location = new System.Drawing.Point(653, 435);
            this.dgvrooms.Name = "dgvrooms";
            this.dgvrooms.RowTemplate.Height = 25;
            this.dgvrooms.Size = new System.Drawing.Size(387, 150);
            this.dgvrooms.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(632, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guest_PAN no.";
            this.label2.Click += new System.EventHandler(this.RoomNolbl_Click);
            // 
            // Guest_Pan
            // 
            this.Guest_Pan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guest_Pan.Location = new System.Drawing.Point(748, 217);
            this.Guest_Pan.Name = "Guest_Pan";
            this.Guest_Pan.Size = new System.Drawing.Size(169, 29);
            this.Guest_Pan.TabIndex = 11;
            this.Guest_Pan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Guest_Pan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomNotbx_KeyPress);
            // 
            // Guests
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.dgvrooms);
            this.Controls.Add(this.generatebillbtn);
            this.Controls.Add(this.gotodrinksbtn);
            this.Controls.Add(this.gotomealsbtn);
            this.Controls.Add(this.gotoroombtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckoutTimepicker);
            this.Controls.Add(this.CheckinTimePicker);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.Searchtbx);
            this.Controls.Add(this.ADDbtn);
            this.Controls.Add(this.guestDgv);
            this.Controls.Add(this.CheckOutlbl);
            this.Controls.Add(this.Checkinlbl);
            this.Controls.Add(this.NoOfIndividualstbx);
            this.Controls.Add(this.NoOfIndividualslbl);
            this.Controls.Add(this.Guest_Pan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomNotbx);
            this.Controls.Add(this.RoomNolbl);
            this.Controls.Add(this.GuestEmailtbx);
            this.Controls.Add(this.GuestEmaillbl);
            this.Controls.Add(this.GuestContacttbx);
            this.Controls.Add(this.GuestContactlbl);
            this.Controls.Add(this.GuestAddresstbx);
            this.Controls.Add(this.GuestIDlbl);
            this.Controls.Add(this.GuestNametbx);
            this.Controls.Add(this.GuestNamelbl);
            this.Controls.Add(this.GuestIDtbx);
            this.Controls.Add(this.GuestID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GHAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Guests_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.guestDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Label GuestID;
        private TextBox GuestIDtbx;
        private TextBox GuestNametbx;
        private Label GuestNamelbl;
        private TextBox GuestAddresstbx;
        private Label GuestIDlbl;
        private TextBox GuestContacttbx;
        private Label GuestContactlbl;
        private TextBox GuestEmailtbx;
        private Label GuestEmaillbl;
        private TextBox RoomNotbx;
        private Label RoomNolbl;
        private TextBox NoOfIndividualstbx;
        private Label NoOfIndividualslbl;
        private Label Checkinlbl;
        private Label CheckOutlbl;
        private DataGridView guestDgv;
        private Button ADDbtn;
        private TextBox Searchtbx;
        private Button clearbtn;
        private Button btnSearch;
        private Button Deletebtn;
        private Button Updatebtn;
        private DateTimePicker CheckinTimePicker;
        private DateTimePicker CheckoutTimepicker;
        private Label label13;
        private Panel panel1;
        private Label Gharlbl;
        private Label Pahunalbl;
        private Label label1;
        private ComboBox GenderComboBox;
        private Button button1;
        private Button button2;
        private Button gotoroombtn;
        private Button gotomealsbtn;
        private Button gotodrinksbtn;
        private Button generatebillbtn;
        private DataGridView dgvrooms;
        private Label label2;
        private TextBox Guest_Pan;
    }
}