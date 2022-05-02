using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook_Project.Forms;

namespace PhoneBook_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to leave?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if(result == DialogResult.OK)
                Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var RegisterForm = new RegisterData();
            RegisterForm.MdiParent = this;
            RegisterForm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            var SearchForm = new Search();
            SearchForm.MdiParent = this;
            SearchForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Users\estev\source\repos\Calculator\Calculator\bin\Debug\Calculator.exe";
            process1.Start();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var aboutUsForm = new AboutUs();
            aboutUsForm.MdiParent = this;
            aboutUsForm.Show();
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }
    }
}
