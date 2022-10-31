namespace Hotel_Management_System
{
    partial class DrinksModel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Gharlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Pahunalbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinksdgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drinknametbx = new System.Windows.Forms.TextBox();
            this.desctbx = new System.Windows.Forms.TextBox();
            this.drinkpricetbx = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.drinkidtbx = new System.Windows.Forms.TextBox();
            this.searchtbx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinksdgv)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 40;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 48;
            this.label1.Text = "Drinks";
            // 
            // drinksdgv
            // 
            this.drinksdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinksdgv.Location = new System.Drawing.Point(305, 175);
            this.drinksdgv.Name = "drinksdgv";
            this.drinksdgv.RowTemplate.Height = 25;
            this.drinksdgv.Size = new System.Drawing.Size(483, 281);
            this.drinksdgv.TabIndex = 49;
            this.drinksdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drinksdgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Drink_Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Drink_Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // drinknametbx
            // 
            this.drinknametbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinknametbx.Location = new System.Drawing.Point(123, 259);
            this.drinknametbx.Name = "drinknametbx";
            this.drinknametbx.Size = new System.Drawing.Size(155, 29);
            this.drinknametbx.TabIndex = 54;
            this.drinknametbx.TextChanged += new System.EventHandler(this.drinknametbx_TextChanged);
            // 
            // desctbx
            // 
            this.desctbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desctbx.Location = new System.Drawing.Point(123, 316);
            this.desctbx.Name = "desctbx";
            this.desctbx.Size = new System.Drawing.Size(155, 29);
            this.desctbx.TabIndex = 55;
            this.desctbx.TextChanged += new System.EventHandler(this.desctbx_TextChanged);
            // 
            // drinkpricetbx
            // 
            this.drinkpricetbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinkpricetbx.Location = new System.Drawing.Point(123, 359);
            this.drinkpricetbx.Name = "drinkpricetbx";
            this.drinkpricetbx.Size = new System.Drawing.Size(155, 29);
            this.drinkpricetbx.TabIndex = 56;
            this.drinkpricetbx.TextChanged += new System.EventHandler(this.drinkpricetbx_TextChanged);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Location = new System.Drawing.Point(29, 418);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(83, 38);
            this.addbtn.TabIndex = 57;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Location = new System.Drawing.Point(118, 418);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(81, 38);
            this.deletebtn.TabIndex = 58;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebtn.Location = new System.Drawing.Point(205, 418);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(82, 38);
            this.updatebtn.TabIndex = 59;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrbtn.Location = new System.Drawing.Point(29, 462);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(82, 39);
            this.clrbtn.TabIndex = 60;
            this.clrbtn.Text = "CLEAR";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Drink_ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // drinkidtbx
            // 
            this.drinkidtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinkidtbx.Location = new System.Drawing.Point(123, 224);
            this.drinkidtbx.Name = "drinkidtbx";
            this.drinkidtbx.Size = new System.Drawing.Size(155, 29);
            this.drinkidtbx.TabIndex = 54;
            this.drinkidtbx.TextChanged += new System.EventHandler(this.drinkidtbx_TextChanged);
            // 
            // searchtbx
            // 
            this.searchtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtbx.Location = new System.Drawing.Point(535, 140);
            this.searchtbx.Name = "searchtbx";
            this.searchtbx.Size = new System.Drawing.Size(155, 29);
            this.searchtbx.TabIndex = 61;
            this.searchtbx.TextChanged += new System.EventHandler(this.searchtbx_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(696, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 62;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DrinksModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchtbx);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.drinkpricetbx);
            this.Controls.Add(this.desctbx);
            this.Controls.Add(this.drinkidtbx);
            this.Controls.Add(this.drinknametbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drinksdgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DrinksModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drinks";
            this.Load += new System.EventHandler(this.Drinks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinksdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label Gharlbl;
        private Label label13;
        private Label Pahunalbl;
        private Label label1;
        private DataGridView drinksdgv;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox drinknametbx;
        private TextBox desctbx;
        private TextBox drinkpricetbx;
        private Button addbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Button clrbtn;
        private Label label2;
        private TextBox drinkidtbx;
        private TextBox searchtbx;
        private Button button2;
    }
}