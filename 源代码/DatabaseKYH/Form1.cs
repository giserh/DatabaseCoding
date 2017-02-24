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
using System.IO;
using Npgsql;

namespace DatabaseKYH
{
    public partial class LoginForm : Form
    {
        static bool close = false;
        User user;
        MainForm mainForm = new MainForm();
        public LoginForm()
        {
            InitializeComponent();

            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");

            IsRegister(false);
        }

        private void IsRegister(bool register)
        {
            labSex.Visible = register;
            labEmail.Visible = register;
            tbxEmail.Visible = register;
            cmbSex.Visible = register;
            btnOk.Visible = register;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            IsRegister(true);
            btnLogin.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //点击确定按钮后，提交注册表
            IsRegister(false);
            btnOk.Visible = false;
            btnLogin.Visible = true;

            user = new User(tbxName.Text, tbxPassword.Text, cmbSex.Text, tbxEmail.Text);
            if (user.CreateUser())
                MessageBox.Show("注册成功！");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录
            string userName, password;
            userName = tbxName.Text;
            password = tbxPassword.Text;
            this.user = new User(userName, password);

            string userPassword;

            if (this.user.GetUserInformation(out userPassword))
            {
                if (password == userPassword)
                {
                    MessageBox.Show("登陆成功！");
                    mainForm.Show();
                    mainForm.getUser(this.user);
                    mainForm.GetSitesName();
                }
                else
                {
                    MessageBox.Show("密码错误！");
                }
            }
            else
            {
                MessageBox.Show("请注册！");
            }
        }
    }
}
