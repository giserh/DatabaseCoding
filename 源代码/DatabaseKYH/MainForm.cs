using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseKYH
{
    public partial class MainForm : Form
    {
        User user;
        Site site = new Site();
        public MainForm()
        {
            InitializeComponent();
            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");
        }

        public void getUser(User user)
        {
            this.user = user;
            string name, password, sex, email;
            //获取个人信息，并载入个人信息表中
            user.GetUserInformation(out name, out password, out sex, out email);
            this.tbxName.Text = name;
            this.tbxPassword.Text = password;
            this.tbxSex.Text = sex;
            this.tbxEmail.Text = email;
        }

        public void GetSitesName()
        {
            //获取所有景点名称并载入景点表中
            Stack<string> names = site.GetSitesName();
            for (int i = 0; i < names.Count; i++)
            {
                object item = names.Pop();
                cmbSiteName.Items.Add(item);
                cmbCommentSite.Items.Add(item);
            }
        }

        private void btnModifyPersonal_Click(object sender, EventArgs e)
        {
            this.tbxPassword.ReadOnly = false;
            this.tbxSex.Visible = false;
            this.tbxEmail.ReadOnly = false;
            this.btnOkModifyPersonal.Visible = true;
            this.btnModifyPersonal.Visible = false;
        }

        private void btnOkModifyPersonal_Click(object sender, EventArgs e)
        {
            //点击修改按钮
            this.tbxPassword.ReadOnly = true;
            this.tbxSex.Visible = true;
            this.tbxEmail.ReadOnly = true;
            this.btnModifyPersonal.Visible = true;
            this.btnOkModifyPersonal.Visible = false;

            if (user.ModifyUser(tbxPassword.Text, cmbSex.Text, tbxEmail.Text))
            {
                MessageBox.Show("修改成功！");
                string name = null, pass = null, sex = null, email = null;
                user.GetUserInformation(out name, out pass, out sex, out email);
                tbxPassword.Text = pass;
                tbxSex.Text = sex;
                tbxEmail.Text = email;
                tbxName.Text = name;
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询地点信息
            string dish = null, price = null;
            double lat, lon;
            site.GetSitesProperties(cmbSiteName.SelectedItem.ToString(), out dish, out price, out lat, out lon);

            string properties = "推荐菜品：{0}\r\n人均价位：{1}\r\n\r\n相关留言:\r\n";
            tbxInformation.Text = string.Format(properties, dish, price);

            //查询相关留言
            Message message = new DatabaseKYH.Message();
            Stack<Message> messages = new Stack<DatabaseKYH.Message>();
            messages = message.QueryMessage(cmbSiteName.SelectedItem.ToString());

            while (messages.Count > 0)
            {
                string comment = "用户:{0}  时间:{1}\r\n{2}\r\n";
                message = messages.Pop();
                tbxInformation.Text += string.Format(comment, message.user, message.date, message.text);
            }
        }

        private void btnSubmitComment_Click(object sender, EventArgs e)
        {
            //留言
            string date = DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString();

            Message message = new DatabaseKYH.Message();
            if (message.CreateMessage(this.tbxName.Text, this.tbxComment.Text, date, this.cmbCommentSite.Text))
            {
                MessageBox.Show("留言成功！");
            }
            else MessageBox.Show("留言失败！");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //注销用户
            if (user.DeleteUser())
            {
                MessageBox.Show("注销成功！");
                this.Close();
            }
            else MessageBox.Show("注销失败！");
        }
    }
}
