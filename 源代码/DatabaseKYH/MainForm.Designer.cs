namespace DatabaseKYH
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.tbxInformation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSiteName = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tpComment = new System.Windows.Forms.TabPage();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.cmbCommentSite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitComment = new System.Windows.Forms.Button();
            this.tpPersonal = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tbxSex = new System.Windows.Forms.TextBox();
            this.btnOkModifyPersonal = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnModifyPersonal = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.tpComment.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tpQuery);
            this.mainTabControl.Controls.Add(this.tpComment);
            this.mainTabControl.Controls.Add(this.tpPersonal);
            this.mainTabControl.Location = new System.Drawing.Point(13, 13);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(250, 287);
            this.mainTabControl.TabIndex = 0;
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.tbxInformation);
            this.tpQuery.Controls.Add(this.label1);
            this.tpQuery.Controls.Add(this.cmbSiteName);
            this.tpQuery.Controls.Add(this.btnQuery);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(242, 261);
            this.tpQuery.TabIndex = 0;
            this.tpQuery.Text = "查询地点信息";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // tbxInformation
            // 
            this.tbxInformation.Location = new System.Drawing.Point(6, 104);
            this.tbxInformation.Multiline = true;
            this.tbxInformation.Name = "tbxInformation";
            this.tbxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInformation.Size = new System.Drawing.Size(230, 151);
            this.tbxInformation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地点名称";
            // 
            // cmbSiteName
            // 
            this.cmbSiteName.FormattingEnabled = true;
            this.cmbSiteName.Location = new System.Drawing.Point(66, 6);
            this.cmbSiteName.Name = "cmbSiteName";
            this.cmbSiteName.Size = new System.Drawing.Size(170, 20);
            this.cmbSiteName.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(83, 55);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tpComment
            // 
            this.tpComment.Controls.Add(this.tbxComment);
            this.tpComment.Controls.Add(this.cmbCommentSite);
            this.tpComment.Controls.Add(this.label2);
            this.tpComment.Controls.Add(this.btnSubmitComment);
            this.tpComment.Location = new System.Drawing.Point(4, 22);
            this.tpComment.Name = "tpComment";
            this.tpComment.Padding = new System.Windows.Forms.Padding(3);
            this.tpComment.Size = new System.Drawing.Size(242, 261);
            this.tpComment.TabIndex = 1;
            this.tpComment.Text = "留言板";
            this.tpComment.UseVisualStyleBackColor = true;
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(6, 39);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxComment.Size = new System.Drawing.Size(230, 178);
            this.tbxComment.TabIndex = 3;
            // 
            // cmbCommentSite
            // 
            this.cmbCommentSite.FormattingEnabled = true;
            this.cmbCommentSite.Location = new System.Drawing.Point(115, 6);
            this.cmbCommentSite.Name = "cmbCommentSite";
            this.cmbCommentSite.Size = new System.Drawing.Size(121, 20);
            this.cmbCommentSite.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择留言地点";
            // 
            // btnSubmitComment
            // 
            this.btnSubmitComment.Location = new System.Drawing.Point(70, 223);
            this.btnSubmitComment.Name = "btnSubmitComment";
            this.btnSubmitComment.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitComment.TabIndex = 0;
            this.btnSubmitComment.Text = "留言";
            this.btnSubmitComment.UseVisualStyleBackColor = true;
            this.btnSubmitComment.Click += new System.EventHandler(this.btnSubmitComment_Click);
            // 
            // tpPersonal
            // 
            this.tpPersonal.Controls.Add(this.btnDeleteUser);
            this.tpPersonal.Controls.Add(this.tbxSex);
            this.tpPersonal.Controls.Add(this.btnOkModifyPersonal);
            this.tpPersonal.Controls.Add(this.cmbSex);
            this.tpPersonal.Controls.Add(this.labEmail);
            this.tpPersonal.Controls.Add(this.labSex);
            this.tpPersonal.Controls.Add(this.tbxEmail);
            this.tpPersonal.Controls.Add(this.labPassword);
            this.tpPersonal.Controls.Add(this.labUser);
            this.tpPersonal.Controls.Add(this.tbxName);
            this.tpPersonal.Controls.Add(this.tbxPassword);
            this.tpPersonal.Controls.Add(this.btnModifyPersonal);
            this.tpPersonal.Location = new System.Drawing.Point(4, 22);
            this.tpPersonal.Name = "tpPersonal";
            this.tpPersonal.Size = new System.Drawing.Size(242, 261);
            this.tpPersonal.TabIndex = 2;
            this.tpPersonal.Text = "个人信息";
            this.tpPersonal.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(133, 217);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 22;
            this.btnDeleteUser.Text = "注销用户";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tbxSex
            // 
            this.tbxSex.Location = new System.Drawing.Point(122, 116);
            this.tbxSex.Name = "tbxSex";
            this.tbxSex.ReadOnly = true;
            this.tbxSex.Size = new System.Drawing.Size(100, 21);
            this.tbxSex.TabIndex = 21;
            // 
            // btnOkModifyPersonal
            // 
            this.btnOkModifyPersonal.Location = new System.Drawing.Point(28, 217);
            this.btnOkModifyPersonal.Name = "btnOkModifyPersonal";
            this.btnOkModifyPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnOkModifyPersonal.TabIndex = 18;
            this.btnOkModifyPersonal.Text = "确定";
            this.btnOkModifyPersonal.UseVisualStyleBackColor = true;
            this.btnOkModifyPersonal.Visible = false;
            this.btnOkModifyPersonal.Click += new System.EventHandler(this.btnOkModifyPersonal_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(122, 117);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 20);
            this.cmbSex.TabIndex = 12;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(26, 169);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(29, 12);
            this.labEmail.TabIndex = 20;
            this.labEmail.Text = "邮箱";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(26, 120);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(29, 12);
            this.labSex.TabIndex = 19;
            this.labSex.Text = "性别";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(122, 166);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(100, 21);
            this.tbxEmail.TabIndex = 14;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(26, 68);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(29, 12);
            this.labPassword.TabIndex = 15;
            this.labPassword.Text = "密码";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(26, 19);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(41, 12);
            this.labUser.TabIndex = 13;
            this.labUser.Text = "用户名";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(122, 16);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 10;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(122, 65);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = true;
            this.tbxPassword.Size = new System.Drawing.Size(100, 21);
            this.tbxPassword.TabIndex = 11;
            // 
            // btnModifyPersonal
            // 
            this.btnModifyPersonal.Location = new System.Drawing.Point(28, 217);
            this.btnModifyPersonal.Name = "btnModifyPersonal";
            this.btnModifyPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPersonal.TabIndex = 16;
            this.btnModifyPersonal.Text = "修改";
            this.btnModifyPersonal.UseVisualStyleBackColor = true;
            this.btnModifyPersonal.Click += new System.EventHandler(this.btnModifyPersonal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 312);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainTabControl.ResumeLayout(false);
            this.tpQuery.ResumeLayout(false);
            this.tpQuery.PerformLayout();
            this.tpComment.ResumeLayout(false);
            this.tpComment.PerformLayout();
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.TabPage tpComment;
        private System.Windows.Forms.TabPage tpPersonal;
        private System.Windows.Forms.Button btnOkModifyPersonal;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnModifyPersonal;
        private System.Windows.Forms.TextBox tbxSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSiteName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbxInformation;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitComment;
        private System.Windows.Forms.ComboBox cmbCommentSite;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}