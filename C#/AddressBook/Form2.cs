//In order for the address book to be fully operational please insert your songs(mp3 format) into ~/AddressBook/Debug folder.﻿
using System;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AddressBook
{

    public partial class Form2 : Form
    {
        /*SOME GLOBAl VARIABLES*/

        //DB connection string.
        private readonly String _connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=info.mdb;";

        //conn is a variable of type OleDbConnection.
        private OleDbConnection _conn;

        //boolean that are true when a button is clicked.
        private bool _addButtonChecked;
        private bool _editButtonChecked;
        private bool _searchButtonChecked;
        private readonly DateTime _today = DateTime.Today;
        private DateTime _birthday;

        private String _fnDelete, _imgName, _songName;

        public Form2()
        {
            InitializeComponent();
        }

        class Contact
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Email { get; set; }

            public String Phone { get; set; }

            public String StreetAddress { get; set; }

            public String Birthday { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            dateTimePicker1.MaxDate = _today;
            dateTimePicker1.Value = _today;

            //Try to find the database.
            try
            {
                //Define connection string.
                _conn = new OleDbConnection(_connString);
            }

            //Else cath the error and warn the user.
            catch (Exception exception)
            {
                MessageBox.Show(@"Database not found!" + exception);
            }
            ShowContacts();
            BirthdayCheck();
        }

        

        /*BUTTON CLICK FUNCTIONS*/

        private void NewContactButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;

            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            dataGridView1.Enabled = false;

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    ClearTb();
                    pictureBox1.Image = null;
                    dateTimePicker1.Value = _today;
                    c.Enabled = true;
                    c.Visible = true;

                    FirstNameSearch.Visible = false;
                    LastNameSearch.Visible = false;
                    PhoneSearch.Visible = false;

                }
            }
            _addButtonChecked = true;
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;

            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            dataGridView1.Enabled = true;

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Visible = true;
                    c.Enabled = true;

                    FirstNameSearch.Visible = false;
                    LastNameSearch.Visible = false;
                    PhoneSearch.Visible = false;

                }
            }
            _editButtonChecked = true;
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            String query= "DELETE from ContactInfo WHERE FirstName='" + _fnDelete + "'";
            var cmd = new OleDbCommand(query,_conn);

            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
            MessageBox.Show(@"Successfully Deleted contact");
            ShowContacts();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;

            dataGridView1.Enabled = false;
            axWindowsMediaPlayer1.Enabled = false;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;

            ClearTb();
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Visible = false;
                }
            }

            FirstNameSearch.Visible = true;
            LastNameSearch.Visible = true;
            PhoneSearch.Visible = true;

            _searchButtonChecked = true;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_addButtonChecked)
            {
                InsertDb();
            }
            
            else if (_editButtonChecked)
            {
                EditDb();
            }
            else if (_searchButtonChecked)
            {
                SearchDb();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImageLabel_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.Filter = @"Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                var file = Image.FromFile(f.FileName);
                _imgName = f.SafeFileName;
                pictureBox1.Image = file;
            }
        }
        private void MusicLabel_Click(object sender, EventArgs e)
        {

            
            var f = new OpenFileDialog();
            f.Filter = @"Image files (*.mp3) | *.mp3";
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                 axWindowsMediaPlayer1.URL = f.FileName;
                _songName = f.SafeFileName;
            }
        }


        /*OTHER FUNCTIONS*/

        //Show contacts in datagrid.
        private void ShowContacts()
        { 
            String query = "SELECT FirstName,LastName,Email,Phone,StreetAddress,Birthday FROM ContactInfo ";

            var cmd = new OleDbCommand(query, _conn);
            try
            {
                _conn.Open();

                var adapter = new OleDbDataAdapter(cmd);

                var dt = new DataTable();
                adapter.Fill(dt);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                _conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _conn.Close();
            }
            
        }

        private void InsertDb()
        {
            var c = new Contact();

            c.FirstName = FirstNameTB.Text;
            c.LastName = LastNameTB.Text;
            c.Email = EmailTB.Text;
            c.Phone = PhoneTB.Text;
            c.StreetAddress = StreetAddressTB.Text;
            c.Birthday = dateTimePicker1.Value.ToShortDateString();

            //Check if all fields are filled and record new contact.
            if (c.FirstName.Equals("") || c.LastName.Equals("") || c.Email.Equals("") || c.Phone.Equals("") || c.StreetAddress.Equals("") || c.Birthday.Equals("")||_imgName.Equals("")||_songName.Equals(""))
            {
                MessageBox.Show(@"You need to fill all fields in order to add a new contact.");
            }
            else
            {
                if (IsValidEmail(c.Email)==false || IsPhoneNumber(c.Phone)==false)
                {
                    MessageBox.Show(@"No valid email/phone number");
                }
                else
                {
                    const String sql = "INSERT INTO ContactInfo(FirstName,LastName,Email,Phone,StreetAddress,Birthday,ImageName,SongName) VALUES(@FirstName,@LastName,@Email,@Phone,@StreetAddress,@Birthday,@ImageName,@SongName)";
                    var cmd = new OleDbCommand(sql, _conn);

                    //Add params
                    cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", c.LastName);
                    cmd.Parameters.AddWithValue("@Email", c.Email);
                    cmd.Parameters.AddWithValue("@Phone", c.Phone);
                    cmd.Parameters.AddWithValue("@StreerAddress", c.StreetAddress);
                    cmd.Parameters.AddWithValue("@Birthday", c.Birthday);
                    cmd.Parameters.AddWithValue("@ImageName", _imgName);
                    cmd.Parameters.AddWithValue("@SongName", _songName);

                    try
                    {
                        //Open connection and execute the insertion.
                        _conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(@"Successfully Inserted");
                        }
                        _conn.Close();
                        ClearTb();
                        pictureBox1.Image = null;
                        ShowContacts();

                    }
                    catch (Exception ex)
                    {
                        //Else warn user.
                        MessageBox.Show(ex.Message);
                        _conn.Close();
                    }

                }
            }
        }

        private void EditDb()
        {
            
            _conn.Open();

            string query = "UPDATE [ContactInfo] SET [FirstName] = ?,[LastName] = ? ,[Email] = ?,[Phone] = ?,[StreetAddress]=? ,[Birthday] =?,[ImageName]=?,[SongName]=? WHERE [FirstName] ='"+_fnDelete+"'";
            var cmd = new OleDbCommand(query, _conn);
            var da = new OleDbDataAdapter(query, _conn);

            cmd.Parameters.AddWithValue("FirstName",FirstNameTB.Text);
            cmd.Parameters.AddWithValue("LastName",LastNameTB.Text );
            cmd.Parameters.AddWithValue("Email",EmailTB.Text );
            cmd.Parameters.AddWithValue("Phone",PhoneTB.Text );
            cmd.Parameters.AddWithValue("StreetAddress",StreetAddressTB.Text );
            cmd.Parameters.AddWithValue("Birthday",dateTimePicker1.Value.ToShortDateString() );
            cmd.Parameters.AddWithValue("ImageName",_imgName);
            cmd.Parameters.AddWithValue("SongName", _songName);

            da.UpdateCommand = cmd;
            da.UpdateCommand.ExecuteNonQuery();

            _conn.Close();

            MessageBox.Show(@"Contact successfully edited!");
            ShowContacts();
        }

        private void SearchDb()
        {
            String query;
            var c = new Contact();

            c.FirstName = FirstNameTB.Text;
            c.LastName = LastNameTB.Text;
            c.Phone = PhoneTB.Text;

            //Search according with contact's first name.
            if (FirstNameSearch.Checked && !c.FirstName.Equals(""))
            {
                query = "SELECT FirstName,LastName,Email,Phone,StreetAddress,Birthday FROM ContactInfo WHERE FirstName LIKE '" + c.FirstName + "%'";
                OleDbCommand cmd = new OleDbCommand(query, _conn);
                _conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                _conn.Close();
            }

            //Search according with contact's last name.
            else if (LastNameSearch.Checked && !c.LastName.Equals(""))
            {
                

                query = "SELECT FirstName,LastName,Email,Phone,StreetAddress,Birthday FROM ContactInfo WHERE LastName LIKE '" + c.LastName + "%'";
                OleDbCommand cmd = new OleDbCommand(query, _conn);
                _conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                _conn.Close();
            }

            //Search according with contact's phone number.
            else if (PhoneSearch.Checked && !c.Phone.Equals(""))
            {
                

                query = "SELECT FirstName,LastName,Email,Phone,StreetAddress,Birthday FROM ContactInfo WHERE Phone LIKE '" + c.Phone + "%'";
                OleDbCommand cmd = new OleDbCommand(query, _conn);
                _conn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                _conn.Close();
            }
            else
            {
                MessageBox.Show(@"Please select your type of search");
            }
        }

        private void ClearTb()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    dateTimePicker1.ResetText();
                }
            }
        }


        
        private void BirthdayCheck()
        {
            var todayDate = _today.ToShortDateString();

            String query = "SELECT * FROM ContactInfo ";

            _conn.Open();

            var cmd = new OleDbCommand(query, _conn);

            OleDbDataReader objReader = cmd.ExecuteReader();

            while (objReader.Read())
            {
                var fn = objReader.GetValue(1).ToString();
                var ln = objReader.GetValue(2).ToString();
                _birthday = Convert.ToDateTime(objReader.GetValue(5).ToString());

                
                if ((_birthday.ToShortDateString()).Equals(todayDate))
                {
                    MessageBox.Show(@"Today it's " + fn + @" " + ln + @" 's Birthday!");
                }

            }

            _conn.Close();
        }
        

        private void FirstNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            _addButtonChecked = false;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Visible = false;
                }
            }

            FirstNameLabel.Visible = true;
            FirstNameTB.Visible = true;
        }

        private void LastNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            _addButtonChecked = false;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Visible = false;
                }
            }

            LastNameLabel.Visible = true;
            LastNameTB.Visible = true;
        }

        private void PhoneSearch_CheckedChanged(object sender, EventArgs e)
        {
            _addButtonChecked = false;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Visible = false;
                }
            }

            PhoneLabel.Visible = true;
            PhoneTB.Visible = true;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowContacts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                FirstNameTB.Text = row.Cells[0].Value.ToString();
                _fnDelete = row.Cells[0].Value.ToString();

                LastNameTB.Text = row.Cells[1].Value.ToString();
                EmailTB.Text = row.Cells[2].Value.ToString();
                PhoneTB.Text = row.Cells[3].Value.ToString();
                StreetAddressTB.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
            }
            
            String query = "SELECT * FROM ContactInfo WHERE FirstName LIKE '" + FirstNameTB.Text +"'";

            _conn.Open();

            var cmd = new OleDbCommand(query, _conn);

            OleDbDataReader objReader = cmd.ExecuteReader();

            while (objReader.Read())
            {
                _imgName = objReader.GetValue(6).ToString();
                _songName= objReader.GetValue(7).ToString();
            }

            var file = Image.FromFile(_imgName);

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is Label || c is DateTimePicker)
                {
                    c.Enabled = false;
                }
            }
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            axWindowsMediaPlayer1.Enabled = true;
            FirstNameSearch.Visible = false;
            LastNameSearch.Visible = false;
            PhoneSearch.Visible = false;

            pictureBox1.Visible = true;
            pictureBox1.Image = file;
            axWindowsMediaPlayer1.uiMode = "mini";
            axWindowsMediaPlayer1.URL = _songName;

            _conn.Close();

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(String number)
        {
            return Regex.Match(number, @"^\d{10}$").Success;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
