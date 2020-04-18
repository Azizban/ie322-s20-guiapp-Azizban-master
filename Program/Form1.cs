using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        string username = "Abdulaziz";
        string myPassword = "12345";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (!loggedIn)
            {

                while (attempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtPassword.Text != myPassword)
                        {
                            // Incorrect password
                            attempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            //Both are correct
                            attempt = 1; // reset the number of attempts
                            loggedIn = true;
                            // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          


                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            BtnLogin.Text = "Logout";
                           
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
            else
            {
                BtnLogin.Text = "Login";
                
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }
            }




        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPicture frm = new FrmPicture();
            frm.ShowDialog();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheckBox frm = new frmCheckBox();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
