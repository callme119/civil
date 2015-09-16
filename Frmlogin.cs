using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace Framework
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if (AuthorityType.Text == "supuser")
            {
                //string user = this.textBoxX1.Text.ToString();
                //string pwd = this.textBoxX2.Text.ToString();
                string users;
                string pwds;
                bool flagshow = false;
                string strConn = System.Windows.Forms.Application.StartupPath + "//Database.db";
                //string strConn = "C:/Users/dell/Desktop/renwu5/v3_4.9/Database.db";
                System.Data.SQLite.SQLiteConnectionStringBuilder strBuild = new System.Data.SQLite.SQLiteConnectionStringBuilder();
                strBuild.DataSource = strConn;
                System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(strBuild.ToString());
                
                conn.Open();
                string cmd = " select * from FW_User where U_Roles=='supuser'";
                SQLiteCommand com = new SQLiteCommand();
                //SqlCommand com = new SqlCommand();
                com.CommandText = cmd;//commandtext属性
                com.Connection = conn;//connection属性
                int u = com.ExecuteNonQuery();//执行sql的方法，它的返回值类型为int型。多用于执行增加，删除，修改数据。返回受影响的行数
                //ExecuteReader()它的返回类型为SqlDataReader,此方法用于用户进行的查询操作。使用SqlDataReader对象的Read();方法进行逐行读取
                Console.WriteLine(u + "====");//看看影响数据库表中几行
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())//从数据库读取用户信息
                {
                    users = reader["U_Name"].ToString();
                    pwds = reader["U_Password"].ToString();
                    if (users.Trim() == textBoxX1.Text & pwds.Trim() == textBoxX2.Text)
                    {


                        flagshow = true; //用户名存在于数据库，则为true
                    }
                }
                reader.Close();
                conn.Close();
                if (flagshow == true)
                {
                    //MessageBox.Show("登录成功！");
                    this.Close();
                    new FrmMain().Show();
                }
                else
                {
                    MessageBox.Show("用户不存在或密码错误！", "提示");
                    return;
                }


            }
            else if (AuthorityType.Text == "comuser")
            {
                string users;
                string pwds;
                bool flagshow = false;
                string strConn = System.Windows.Forms.Application.StartupPath + "//Database.db";
                //string strConn = "C:/Users/dell/Desktop/renwu5/v3_4.9/Database.db";
                System.Data.SQLite.SQLiteConnectionStringBuilder strBuild = new System.Data.SQLite.SQLiteConnectionStringBuilder();
                strBuild.DataSource = strConn;
                System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(strBuild.ToString());
               
                conn.Open();
                string cmd = " select * from FW_User where U_Roles=='comuser'";
                SQLiteCommand com = new SQLiteCommand();
                //SqlCommand com = new SqlCommand();
                com.CommandText = cmd;//commandtext属性
                com.Connection = conn;//connection属性
                int u = com.ExecuteNonQuery();//执行sql的方法，它的返回值类型为int型。多用于执行增加，删除，修改数据。返回受影响的行数
                //ExecuteReader()它的返回类型为SqlDataReader,此方法用于用户进行的查询操作。使用SqlDataReader对象的Read();方法进行逐行读取
                Console.WriteLine(u + "====");//看看影响数据库表中几行
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())//从数据库读取用户信息
                {
                    users = reader["U_Name"].ToString();
                    pwds = reader["U_Password"].ToString();
                    if (users.Trim() == textBoxX1.Text & pwds.Trim() == textBoxX2.Text)
                    {


                        flagshow = true; //用户名存在于数据库，则为true
                    }
                }
                reader.Close();
                conn.Close();
                if (flagshow == true)
                {
                    MessageBox.Show("登录成功！");
                    this.Close();
                    new FrmMain1().Show();
                }
                else
                {
                    MessageBox.Show("用户不存在或密码错误！", "提示");
                    return;
                }




            }
            else if (AuthorityType.Text == "")
            {

                MessageBox.Show("请选择权限！", "提示");


            }

        }

        private void butquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}