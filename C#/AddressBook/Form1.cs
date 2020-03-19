using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var f2=new Form2();
            f2.Show();
            Hide();
        }

        private void GuideButton_Click(object sender, EventArgs e)
        {
            EnterButton.Visible = false;
            GuideButton.Visible = false;
            BackButton.Visible = true;

            richTextBox1.Visible = true;
            richTextBox1.Text = @"-Add new contact:Click Add button,fill in the fields,select song and picture for your contact and click Ok."+Environment.NewLine+
                                @"-Edit a contact:Select the contact you want to edit from the contacts window,change previous contacts' info and then click ok"+Environment.NewLine+
                                @"-Remove a contact:Select the contact you want to remove from the contacts window and press the Remove button."+Environment.NewLine+
                                @"-Search a contact:Click Search button,choose the search criteria,fill in the field and then click Ok.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            BackButton.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EnterButton.Visible = true;
            GuideButton.Visible = true;
            BackButton.Visible = false;

            richTextBox1.Visible = false;
        }
    }
}
