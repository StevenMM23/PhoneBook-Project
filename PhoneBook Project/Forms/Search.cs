using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook_Project.Forms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            string path = @"C:\Users\estev\Documents\Practing IO Files\PhoneBook_IDS\";

            if (System.IO.File.Exists(path + x + "_id.txt"))
            {
                string id;

                idtxt.Text = x;

                // ---------- First Name ----------//
                id = path + x + "_fn.txt";
                if (System.IO.File.Exists(id))
                    Fnametxt.Text = System.IO.File.ReadAllText(id);

                //---------- Last Name ---------------
                id = path + x + "_ln.txt";
                if (System.IO.File.Exists(id))
                    LastNametxt.Text = System.IO.File.ReadAllText(id);

                //---------- Telephone ---------------
                id = path + x + "_tel.txt";
                if (System.IO.File.Exists(id))
                    TelTxt.Text = System.IO.File.ReadAllText(id);


                //---------- CellPhone ---------------
                id = path + x + "_cell.txt";
                if (System.IO.File.Exists(id))
                    Celltxt.Text = System.IO.File.ReadAllText(id);

                //---------- Email ---------------
                id = path + x + "_email.txt";
                if (System.IO.File.Exists(id))
                    Emailtxt.Text = System.IO.File.ReadAllText(id);


                //---------- Address ---------------
                id = path + x + "_adress.txt";
                if (System.IO.File.Exists(id))
                    Addresstxt.Text = System.IO.File.ReadAllText(id);


                //---------- Comment ---------------
                id = path + x + "_comment.txt";
                if (System.IO.File.Exists(id))
                    commentxt.Text = System.IO.File.ReadAllText(id);
            }

            else MessageBox.Show("The ID dont exists");
        }
    }
    
}
