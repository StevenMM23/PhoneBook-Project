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
    public partial class RegisterData : Form
    {
        public RegisterData()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InformationGroup.Enabled = true;
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // SAVE DATA
            string directoryPath = @"C:\Users\estev\Documents\Practing IO Files\PhoneBook_IDS\";

            var path = directoryPath;
            string id = "";
            toolStripButton1.Enabled = true;
            InformationGroup.Enabled = false;
            toolStripButton2.Enabled = false;


            if (idtxt.Text != String.Empty)
            {
                //ID FILE
                id = path + idtxt.Text + "_id.txt";
                System.IO.File.WriteAllText(id,idtxt.Text);

                //First Name
                id = path + idtxt.Text + "_fn.txt";
                System.IO.File.WriteAllText(id, Fnametxt.Text, Encoding.UTF8);


                //---------- Last Name ---------------
                id = path + idtxt.Text + "_ln.txt";
                System.IO.File.WriteAllText(id, LastNametxt.Text, Encoding.UTF8);

                //---------- Telephone ---------------
                id = path + idtxt.Text + "_tel.txt";
                System.IO.File.WriteAllText(id, TelTxt.Text, Encoding.UTF8);


                //---------- CellPhone ---------------
                id = path + idtxt.Text + "_cell.txt";
                System.IO.File.WriteAllText(id, Celltxt.Text, Encoding.UTF8);

                //---------- Email ---------------
                id = path + idtxt.Text + "_email.txt";
                System.IO.File.WriteAllText(id, Emailtxt.Text, Encoding.UTF8);


                //---------- Address ---------------
                id = path + idtxt.Text + "_adress.txt";
                System.IO.File.WriteAllText(id, Addresstxt.Text, Encoding.UTF8);


                //---------- Comment ---------------
                id = path + idtxt.Text + "_comment.txt";
                System.IO.File.WriteAllText(id, commentxt.Text, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("Complete the ID field");
                toolStripButton1_Click(sender, e);
                return;
            }
            //CLEAR TEXTBOX
            idtxt.Text = "";
            TelTxt.Text = "";
            Fnametxt.Text = "";
            LastNametxt.Text = "";
            Celltxt.Text = "";
            Emailtxt.Text = "";
            Addresstxt.Text = "";
            commentxt.Text = "";

            MessageBox.Show("Saved", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1);


        }
    }
}
