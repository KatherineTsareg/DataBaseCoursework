using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework
{
    public enum gender {MALE, FEMAIL };
   
    public partial class CreateNewNoteForm : Form
    {
        public CreateNewNoteForm()
        {
            InitializeComponent();
        }

        private void CreateNewNoteForm_Load(object sender, EventArgs e)
        {
     

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string personName = nameTextBox.Text;
            DateTime personBDDate = dateBDField.Value;
            string personGender = GetGender(genderBox.Text);
            string personPhone = PhoneField.Text;
            int personCashbox = (int)CashboxNumber.Value;
            string personImagePath = pictureBox1.ImageLocation;

            if (!string.IsNullOrEmpty(personName) && !string.IsNullOrEmpty(personPhone))
            {
                CSqlFunctions.InsertIntoSellerTable(personName, personBDDate, personPhone, personCashbox, personGender, personImagePath);
                this.Close();
            }
            else
            {
                errorLabe.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = OpenFd.ShowDialog();
            pictureBox1.Image = Image.FromFile(OpenFd.FileName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string GetGender(string inputString)
        {
            if (inputString == "мужской") return "male";
            return "female";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
