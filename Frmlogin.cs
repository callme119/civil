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
                com.CommandText = cmd;//commandtext����
                com.Connection = conn;//connection����
                int u = com.ExecuteNonQuery();//ִ��sql�ķ��������ķ���ֵ����Ϊint�͡�������ִ�����ӣ�ɾ�����޸����ݡ�������Ӱ�������
                //ExecuteReader()���ķ�������ΪSqlDataReader,�˷��������û����еĲ�ѯ������ʹ��SqlDataReader�����Read();�����������ж�ȡ
                Console.WriteLine(u + "====");//����Ӱ�����ݿ���м���
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())//�����ݿ��ȡ�û���Ϣ
                {
                    users = reader["U_Name"].ToString();
                    pwds = reader["U_Password"].ToString();
                    if (users.Trim() == textBoxX1.Text & pwds.Trim() == textBoxX2.Text)
                    {


                        flagshow = true; //�û������������ݿ⣬��Ϊtrue
                    }
                }
                reader.Close();
                conn.Close();
                if (flagshow == true)
                {
                    //MessageBox.Show("��¼�ɹ���");
                    this.Close();
                    new FrmMain().Show();
                }
                else
                {
                    MessageBox.Show("�û������ڻ��������", "��ʾ");
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
                com.CommandText = cmd;//commandtext����
                com.Connection = conn;//connection����
                int u = com.ExecuteNonQuery();//ִ��sql�ķ��������ķ���ֵ����Ϊint�͡�������ִ�����ӣ�ɾ�����޸����ݡ�������Ӱ�������
                //ExecuteReader()���ķ�������ΪSqlDataReader,�˷��������û����еĲ�ѯ������ʹ��SqlDataReader�����Read();�����������ж�ȡ
                Console.WriteLine(u + "====");//����Ӱ�����ݿ���м���
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())//�����ݿ��ȡ�û���Ϣ
                {
                    users = reader["U_Name"].ToString();
                    pwds = reader["U_Password"].ToString();
                    if (users.Trim() == textBoxX1.Text & pwds.Trim() == textBoxX2.Text)
                    {


                        flagshow = true; //�û������������ݿ⣬��Ϊtrue
                    }
                }
                reader.Close();
                conn.Close();
                if (flagshow == true)
                {
                    MessageBox.Show("��¼�ɹ���");
                    this.Close();
                    new FrmMain1().Show();
                }
                else
                {
                    MessageBox.Show("�û������ڻ��������", "��ʾ");
                    return;
                }




            }
            else if (AuthorityType.Text == "")
            {

                MessageBox.Show("��ѡ��Ȩ�ޣ�", "��ʾ");


            }

        }

        private void butquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}