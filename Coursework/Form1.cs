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
    
    public partial class Form1 : Form
    {
        
        private CreateNewNoteForm createNewForm = new CreateNewNoteForm();
        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(createNewForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CSqlFunctions.Refresh(listBox1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            createNewForm.Show();
            listBox1.Items.Clear();
            CSqlFunctions.Refresh(listBox1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CSqlFunctions.Refresh(listBox1);
        }
    }
}
