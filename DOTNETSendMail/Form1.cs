using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNETSendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void chkbox_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_showpwd.Checked == true)
            {
                txtbox_from_pwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtbox_from_pwd.UseSystemPasswordChar = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            //txtbox_from.Text = "";
            //txtbox_from_pwd.Text = "";
            txtbox_to.Text = "";
            txtbox_subject.Text = "";
            richtxtbox_text.Text = "";

            chkbox_showpwd.Checked = false;
            txtbox_from_pwd.UseSystemPasswordChar = true;

            txtbox_to.Focus();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }
    }
}