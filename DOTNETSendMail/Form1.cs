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
            //txtbox_smtp.Text = "";
            txtbox_to.Text = "";
            txtbox_subject.Text = "";
            richtxtbox_text.Text = "";

            chkbox_showpwd.Checked = false;
            txtbox_from_pwd.UseSystemPasswordChar = true;

            txtbox_to.Focus();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtbox_from.Text == "")
            {
                MessageBox.Show("收件人不能为空！");
                txtbox_from.Focus();
            }
            else if (txtbox_from_pwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                txtbox_from_pwd.Focus();
            }
            else if (txtbox_to.Text == "")
            {
                MessageBox.Show("收件人不能为空！");
                txtbox_to.Focus();
            }
            else if (txtbox_smtp.Text == "")
            {
                MessageBox.Show("SMTP不能为空！");
                txtbox_smtp.Focus();
            }
            else if (txtbox_subject.Text == "")
            {
                MessageBox.Show("主题不能为空！");
                txtbox_subject.Focus();
            }
            else
            {
                try
                {
                    EmailSend email = new EmailSend();
                    email.mailFrom = txtbox_from.Text;
                    email.mailPwd = txtbox_from_pwd.Text;
                    email.mailSubject = txtbox_subject.Text;
                    email.mailBody = richtxtbox_text.Text;
                    email.isbodyHtml = false;       //是否是HTML
                    email.host = txtbox_smtp.Text;  //如果是QQ邮箱则：smtp.qq.com,依次类推
                    email.mailToArray = txtbox_to.Text.Split(',');
                    //email.mailToArray = new string[] { "******@qq.com","******@qq.com" };//接收者邮件集合
                    //MessageBox.Show(email.mailToArray[1].ToString());
                    //email.mailCcArray = new string[] { "******@qq.com" };//抄送者邮件集合
                    if (email.Send())
                    {
                        MessageBox.Show("发送成功！");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("发送失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}