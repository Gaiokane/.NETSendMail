namespace DOTNETSendMail
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_from = new System.Windows.Forms.Label();
            this.txtbox_from = new System.Windows.Forms.TextBox();
            this.txtbox_from_pwd = new System.Windows.Forms.TextBox();
            this.lab_from_pwd = new System.Windows.Forms.Label();
            this.chkbox_showpwd = new System.Windows.Forms.CheckBox();
            this.txtbox_to = new System.Windows.Forms.TextBox();
            this.lab_to = new System.Windows.Forms.Label();
            this.txtbox_subject = new System.Windows.Forms.TextBox();
            this.lab_subject = new System.Windows.Forms.Label();
            this.lab_text = new System.Windows.Forms.Label();
            this.richtxtbox_text = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_from
            // 
            this.lab_from.AutoSize = true;
            this.lab_from.Location = new System.Drawing.Point(12, 15);
            this.lab_from.Name = "lab_from";
            this.lab_from.Size = new System.Drawing.Size(53, 12);
            this.lab_from.TabIndex = 0;
            this.lab_from.Text = "发件人：";
            // 
            // txtbox_from
            // 
            this.txtbox_from.Location = new System.Drawing.Point(71, 12);
            this.txtbox_from.Name = "txtbox_from";
            this.txtbox_from.Size = new System.Drawing.Size(177, 21);
            this.txtbox_from.TabIndex = 1;
            // 
            // txtbox_from_pwd
            // 
            this.txtbox_from_pwd.Location = new System.Drawing.Point(313, 12);
            this.txtbox_from_pwd.Name = "txtbox_from_pwd";
            this.txtbox_from_pwd.Size = new System.Drawing.Size(177, 21);
            this.txtbox_from_pwd.TabIndex = 3;
            // 
            // lab_from_pwd
            // 
            this.lab_from_pwd.AutoSize = true;
            this.lab_from_pwd.Location = new System.Drawing.Point(254, 15);
            this.lab_from_pwd.Name = "lab_from_pwd";
            this.lab_from_pwd.Size = new System.Drawing.Size(53, 12);
            this.lab_from_pwd.TabIndex = 2;
            this.lab_from_pwd.Text = "密  码：";
            // 
            // chkbox_showpwd
            // 
            this.chkbox_showpwd.AutoSize = true;
            this.chkbox_showpwd.Location = new System.Drawing.Point(496, 14);
            this.chkbox_showpwd.Name = "chkbox_showpwd";
            this.chkbox_showpwd.Size = new System.Drawing.Size(72, 16);
            this.chkbox_showpwd.TabIndex = 4;
            this.chkbox_showpwd.Text = "显示密码";
            this.chkbox_showpwd.UseVisualStyleBackColor = true;
            this.chkbox_showpwd.CheckedChanged += new System.EventHandler(this.chkbox_showpwd_CheckedChanged);
            // 
            // txtbox_to
            // 
            this.txtbox_to.Location = new System.Drawing.Point(71, 52);
            this.txtbox_to.Name = "txtbox_to";
            this.txtbox_to.Size = new System.Drawing.Size(177, 21);
            this.txtbox_to.TabIndex = 6;
            // 
            // lab_to
            // 
            this.lab_to.AutoSize = true;
            this.lab_to.Location = new System.Drawing.Point(12, 55);
            this.lab_to.Name = "lab_to";
            this.lab_to.Size = new System.Drawing.Size(53, 12);
            this.lab_to.TabIndex = 5;
            this.lab_to.Text = "收件人：";
            // 
            // txtbox_subject
            // 
            this.txtbox_subject.Location = new System.Drawing.Point(71, 93);
            this.txtbox_subject.Name = "txtbox_subject";
            this.txtbox_subject.Size = new System.Drawing.Size(177, 21);
            this.txtbox_subject.TabIndex = 8;
            // 
            // lab_subject
            // 
            this.lab_subject.AutoSize = true;
            this.lab_subject.Location = new System.Drawing.Point(12, 96);
            this.lab_subject.Name = "lab_subject";
            this.lab_subject.Size = new System.Drawing.Size(53, 12);
            this.lab_subject.TabIndex = 7;
            this.lab_subject.Text = "主  题：";
            // 
            // lab_text
            // 
            this.lab_text.AutoSize = true;
            this.lab_text.Location = new System.Drawing.Point(12, 137);
            this.lab_text.Name = "lab_text";
            this.lab_text.Size = new System.Drawing.Size(53, 12);
            this.lab_text.TabIndex = 9;
            this.lab_text.Text = "正  文：";
            // 
            // richtxtbox_text
            // 
            this.richtxtbox_text.Location = new System.Drawing.Point(71, 134);
            this.richtxtbox_text.Name = "richtxtbox_text";
            this.richtxtbox_text.Size = new System.Drawing.Size(717, 304);
            this.richtxtbox_text.TabIndex = 10;
            this.richtxtbox_text.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(256, 50);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(337, 50);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.richtxtbox_text);
            this.Controls.Add(this.lab_text);
            this.Controls.Add(this.txtbox_subject);
            this.Controls.Add(this.lab_subject);
            this.Controls.Add(this.txtbox_to);
            this.Controls.Add(this.lab_to);
            this.Controls.Add(this.chkbox_showpwd);
            this.Controls.Add(this.txtbox_from_pwd);
            this.Controls.Add(this.lab_from_pwd);
            this.Controls.Add(this.txtbox_from);
            this.Controls.Add(this.lab_from);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_from;
        private System.Windows.Forms.TextBox txtbox_from;
        private System.Windows.Forms.TextBox txtbox_from_pwd;
        private System.Windows.Forms.Label lab_from_pwd;
        private System.Windows.Forms.CheckBox chkbox_showpwd;
        private System.Windows.Forms.TextBox txtbox_to;
        private System.Windows.Forms.Label lab_to;
        private System.Windows.Forms.TextBox txtbox_subject;
        private System.Windows.Forms.Label lab_subject;
        private System.Windows.Forms.Label lab_text;
        private System.Windows.Forms.RichTextBox richtxtbox_text;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_reset;
    }
}

