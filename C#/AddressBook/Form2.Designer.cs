namespace AddressBook
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhoneSearch = new System.Windows.Forms.RadioButton();
            this.LastNameSearch = new System.Windows.Forms.RadioButton();
            this.FirstNameSearch = new System.Windows.Forms.RadioButton();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StreetAddressTB = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NewContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ShowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Silver;
            this.WelcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(436, -6);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(174, 35);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Address Book";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.PhoneSearch);
            this.groupBox1.Controls.Add(this.LastNameSearch);
            this.groupBox1.Controls.Add(this.FirstNameSearch);
            this.groupBox1.Controls.Add(this.MusicLabel);
            this.groupBox1.Controls.Add(this.ImageLabel);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameTB);
            this.groupBox1.Controls.Add(this.LastNameTB);
            this.groupBox1.Controls.Add(this.DateOfBirthLabel);
            this.groupBox1.Controls.Add(this.PhoneLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.StreetAddressTB);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.StreetAddressLabel);
            this.groupBox1.Controls.Add(this.PhoneTB);
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 418);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(256, 211);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(217, 50);
            this.axWindowsMediaPlayer1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneSearch
            // 
            this.PhoneSearch.AutoSize = true;
            this.PhoneSearch.Location = new System.Drawing.Point(20, 382);
            this.PhoneSearch.Name = "PhoneSearch";
            this.PhoneSearch.Size = new System.Drawing.Size(197, 23);
            this.PhoneSearch.TabIndex = 69;
            this.PhoneSearch.TabStop = true;
            this.PhoneSearch.Text = "Search via phone number";
            this.PhoneSearch.UseVisualStyleBackColor = true;
            this.PhoneSearch.CheckedChanged += new System.EventHandler(this.PhoneSearch_CheckedChanged);
            // 
            // LastNameSearch
            // 
            this.LastNameSearch.AutoSize = true;
            this.LastNameSearch.Location = new System.Drawing.Point(20, 353);
            this.LastNameSearch.Name = "LastNameSearch";
            this.LastNameSearch.Size = new System.Drawing.Size(172, 23);
            this.LastNameSearch.TabIndex = 68;
            this.LastNameSearch.TabStop = true;
            this.LastNameSearch.Text = "Search via last name";
            this.LastNameSearch.UseVisualStyleBackColor = true;
            this.LastNameSearch.CheckedChanged += new System.EventHandler(this.LastNameSearch_CheckedChanged);
            // 
            // FirstNameSearch
            // 
            this.FirstNameSearch.AutoSize = true;
            this.FirstNameSearch.Location = new System.Drawing.Point(20, 324);
            this.FirstNameSearch.Name = "FirstNameSearch";
            this.FirstNameSearch.Size = new System.Drawing.Size(178, 23);
            this.FirstNameSearch.TabIndex = 67;
            this.FirstNameSearch.TabStop = true;
            this.FirstNameSearch.Text = "Search via first name";
            this.FirstNameSearch.UseVisualStyleBackColor = true;
            this.FirstNameSearch.CheckedChanged += new System.EventHandler(this.FirstNameSearch_CheckedChanged);
            // 
            // MusicLabel
            // 
            this.MusicLabel.AutoSize = true;
            this.MusicLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicLabel.Location = new System.Drawing.Point(287, 264);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(113, 19);
            this.MusicLabel.TabIndex = 66;
            this.MusicLabel.Text = "Select music...";
            this.MusicLabel.Click += new System.EventHandler(this.MusicLabel_Click);
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageLabel.Location = new System.Drawing.Point(113, 264);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(115, 19);
            this.ImageLabel.TabIndex = 65;
            this.ImageLabel.Text = "Select image...";
            this.ImageLabel.Click += new System.EventHandler(this.ImageLabel_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(16, 39);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(93, 19);
            this.FirstNameLabel.TabIndex = 44;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTB.Location = new System.Drawing.Point(152, 36);
            this.FirstNameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(296, 26);
            this.FirstNameTB.TabIndex = 45;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTB.Location = new System.Drawing.Point(152, 62);
            this.LastNameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(296, 26);
            this.LastNameTB.TabIndex = 47;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(16, 168);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 19);
            this.DateOfBirthLabel.TabIndex = 55;
            this.DateOfBirthLabel.Text = "Birthday:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 92);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 19);
            this.PhoneLabel.TabIndex = 46;
            this.PhoneLabel.Text = "Phone:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 162);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 26);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
            // 
            // StreetAddressTB
            // 
            this.StreetAddressTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddressTB.Location = new System.Drawing.Point(152, 135);
            this.StreetAddressTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StreetAddressTB.Name = "StreetAddressTB";
            this.StreetAddressTB.Size = new System.Drawing.Size(296, 26);
            this.StreetAddressTB.TabIndex = 53;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(16, 116);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 19);
            this.EmailLabel.TabIndex = 48;
            this.EmailLabel.Text = "Email:";
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddressLabel.Location = new System.Drawing.Point(16, 139);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(113, 19);
            this.StreetAddressLabel.TabIndex = 52;
            this.StreetAddressLabel.Text = "Street Address:";
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTB.Location = new System.Drawing.Point(152, 88);
            this.PhoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(296, 26);
            this.PhoneTB.TabIndex = 49;
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(152, 112);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(296, 26);
            this.EmailTB.TabIndex = 51;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(16, 65);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(89, 19);
            this.LastNameLabel.TabIndex = 50;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.ShowButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(497, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 500);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(6, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(833, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NewContactButton
            // 
            this.NewContactButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewContactButton.ForeColor = System.Drawing.Color.White;
            this.NewContactButton.Location = new System.Drawing.Point(11, 26);
            this.NewContactButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewContactButton.Name = "NewContactButton";
            this.NewContactButton.Size = new System.Drawing.Size(73, 32);
            this.NewContactButton.TabIndex = 61;
            this.NewContactButton.Text = "New";
            this.NewContactButton.UseVisualStyleBackColor = false;
            this.NewContactButton.Click += new System.EventHandler(this.NewContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditContactButton.ForeColor = System.Drawing.Color.White;
            this.EditContactButton.Location = new System.Drawing.Point(90, 26);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(73, 32);
            this.EditContactButton.TabIndex = 62;
            this.EditContactButton.Text = "Edit";
            this.EditContactButton.UseVisualStyleBackColor = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(248, 26);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(73, 32);
            this.SearchButton.TabIndex = 64;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveContactButton.ForeColor = System.Drawing.Color.White;
            this.RemoveContactButton.Location = new System.Drawing.Point(169, 26);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(73, 32);
            this.RemoveContactButton.TabIndex = 63;
            this.RemoveContactButton.Text = "Remove";
            this.RemoveContactButton.UseVisualStyleBackColor = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.ExitButton);
            this.groupBox3.Controls.Add(this.OkButton);
            this.groupBox3.Controls.Add(this.NewContactButton);
            this.groupBox3.Controls.Add(this.RemoveContactButton);
            this.groupBox3.Controls.Add(this.EditContactButton);
            this.groupBox3.Controls.Add(this.SearchButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 70);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(406, 26);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(73, 32);
            this.ExitButton.TabIndex = 66;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(327, 26);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(73, 32);
            this.OkButton.TabIndex = 65;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.ForeColor = System.Drawing.Color.White;
            this.ShowButton.Location = new System.Drawing.Point(370, 461);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(124, 32);
            this.ShowButton.TabIndex = 65;
            this.ShowButton.Text = "Show Contacts";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1354, 544);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox StreetAddressTB;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NewContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton PhoneSearch;
        private System.Windows.Forms.RadioButton LastNameSearch;
        private System.Windows.Forms.RadioButton FirstNameSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button ShowButton;
    }
}

