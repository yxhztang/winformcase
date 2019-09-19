using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// using System.Data.SqlClient;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
 
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uername = this.name.Text.Trim();
            string pwd = password.Text;
            if(uername == "admin" && pwd == "admin"){
                MessageBox.Show("登录成功！", "提示");
                label_title.Visible = false;
                label_userName.Visible = false;
                label_userPwd.Visible = false;
                name.Visible = false;
                password.Visible = false;
                button_reg.Visible = false;
                loginBtn.Visible = false;
            }else{
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
                name.Text = "";
                password.Text = "";
                name.Focus();
            }
            // string constr = "Server=.;DataBase=Management;Integrated Security=True";
            // // 建立SqlConnection对象
            // SqlConnection con = new SqlConnection(constr);
            // // 打开连接
            // con.Open();
            // // 指定SQL语句
            // SqlCommand com = new SqlCommand("select account,password from register where account='" + uername + "' and password='" + pwd + "'", con);
            // // 建立SqlDataAdapter和DataSet对象
            // SqlDataAdapter da = new SqlDataAdapter(com);
            // DataSet ds = new DataSet();
 
            // int n = da.Fill(ds, "register");
            // if (n != 0)
            // {
            //     MessageBox.Show("登录成功！", "提示");
            //     label_title.Visible = false;
            //     label_userName.Visible = false;
            //     label_userPwd.Visible = false;
            //     name.Visible = false;
            //     password.Visible = false;
            //     button_reg.Visible = false;
            //     loginBtn.Visible = false;
            // }
            // else
            // {
            //     MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
            //     name.Text = "";
            //     password.Text = "";
            //     name.Focus();
            // }
            // con.Close();
        }


        //注册表单
        private void button_reg_Click(object sender, EventArgs e)
        {
            //隐藏当前界面        可以隐藏 可以 不写 留在原地不动 
            //this.Close();

            Register reg = new Register();
            // reg.Show();
            //Application.Run(new Register());
            reg.ShowDialog();//前置 在关闭和隐藏前无法切换到主窗体
            this.Dispose();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
 
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_userPwd = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(115, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(174, 23);
            this.name.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(115, 130);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(174, 23);
            this.password.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Menu;
            this.loginBtn.Location = new System.Drawing.Point(45, 186);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(335, 40);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "登  录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.SystemColors.Menu;
            this.button_reg.Location = new System.Drawing.Point(299, 86);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(81, 27);
            this.button_reg.TabIndex = 3;
            this.button_reg.Text = "注  册";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(46, 92);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(63, 14);
            this.label_userName.TabIndex = 4;
            this.label_userName.Text = "用 户 名";
            // 
            // label_userPwd
            // 
            this.label_userPwd.AutoSize = true;
            this.label_userPwd.Location = new System.Drawing.Point(46, 133);
            this.label_userPwd.Name = "label_userPwd";
            this.label_userPwd.Size = new System.Drawing.Size(63, 14);
            this.label_userPwd.TabIndex = 5;
            this.label_userPwd.Text = "密    码";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(66, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(292, 31);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "欢 迎 使 用 XX 管 理 系 统";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_userPwd);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.button_reg);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Login";
            this.Text = "XX 管理系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_userPwd;
        private System.Windows.Forms.Label label_title;

    }
}
