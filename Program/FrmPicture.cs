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
    public partial class FrmPicture : Form
    {
        public FrmPicture()
        {
            InitializeComponent();
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\A.jpg");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
