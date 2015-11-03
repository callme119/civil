using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend1 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);//1.����һ��delegate�������ݽṹ
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend1(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void stcRecommend1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            #region
            //�������С���ɾ���С�������ť������
            if (stcRecommend1.SelectedTabIndex == 0) 
            {
                btnAddRow.Visible = false;
                btnDeleteRow.Visible = false;
            }
            if (stcRecommend1.SelectedTabIndex == 1 | stcRecommend1.SelectedTabIndex == 2 | stcRecommend1.SelectedTabIndex == 3)
            {
                btnAddRow.Visible = true;
                btnDeleteRow.Visible = true;
            }
            #endregion
        }

        private void Rdo_Item1DP_CheckedChanged(object sender, EventArgs e)
        {//�����˾���ǽ(��ѡ����ʱ��������)��С�����˾�ǽ(��ѡ����ʱ��������)
            if (Rdo_Item1DP.Checked)
            {
                Lb_Item1NLGJWQ.Visible = false;
                Lb_Item1XHGLDJQ.Visible = false;
                Tb_Item1NLGJWQ.Visible = false;
                Tb_Item1XHGLDJQ.Visible = false;
            }
            if (Rdo_Item1SP.Checked)
            {
                Lb_Item1NLGJWQ.Visible = true ;
                Lb_Item1XHGLDJQ.Visible = true;
                Tb_Item1NLGJWQ.Visible = true;
                Tb_Item1XHGLDJQ.Visible = true;
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e) //������
        {
            switch (stcRecommend1.SelectedTabIndex )
            {
                case 1: Dgv_Recommend1Material.Rows.Add(); break;
                case 2: Dgv_Recommend1Labor.Rows.Add(); break;
                case 3: Dgv_Recommend1Tool.Rows.Add(); break;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)//ɾ����
        {
            if (stcRecommend1.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend1Material.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend1Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend1.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend1Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend1Labor.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend1.SelectedTabIndex == 3)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend1Tool.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend1Tool.Rows.Remove(row);
                    }
                }
            }
        }

        private void FrmRecommend1_Load(object sender, EventArgs e) 
        {
            #region //1�ۼ�ʽ�ֹܽ��ּܣ����)�����ϰ��ű�
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colMaterialChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colMaterialChoice.HeaderText = "ѡ�����";
                colMaterialChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterial = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterial.HeaderText = "��������";
                colMaterial.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialNumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialNumber.HeaderText = "����";
                colMaterialNumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialStandard = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialStandard.HeaderText = "���";
                colMaterialStandard.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "ɾ����";
                colMaterialDelete.Width = 50;
                Dgv_Recommend1Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend1Material.Columns.Add(colMaterial);
                Dgv_Recommend1Material.Columns.Add(colMaterialNumber);
                Dgv_Recommend1Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend1Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend1Material.Rows.Add();

                object[] strMaterial = new object[] { "�޷�ֹ�", "ľ���ְ�", "��ѹ�ֽ��ְ�", "��Ƭ���ְ�", "��Ž��ְ�", "��Ŀ��ȫ��", "ˮƽ��ȫ��", "ֱ�ǿۼ�", "��ת�ۼ�", "�Խӿۼ�" };
                string[] strStandard = new string[] { "��48.3mm��3.6mm", "0.35 kN/m2", "0.30 kN/m2", "0.35 kN/m2", "0.10 kN/m2", "1.8m��6.0m", " ", " ", " ", " " };
                string[] strNumber = new string[] { "         m", "         m2", "           m2", "           m2", "      m2", "           m2", "           m2", "           ��", "           ��", "          ��" };
                for (int i = 0; i < strMaterial.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strMaterial[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_Recommend1Material.CurrentRow.Index;
                        Dgv_Recommend1Material.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strMaterial.Length; j++)
                        {
                            if (btnItem.Text == strMaterial[j].ToString())
                            {
                                Dgv_Recommend1Material.Rows[RowNum].Cells[2].Value = strNumber[j];
                                Dgv_Recommend1Material.Rows[RowNum].Cells[3].Value = strStandard[j];
                                break;
                            }
                        }
                        Dgv_Recommend1Material.Refresh();
                    });
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //1�ۼ�ʽ�ֹܽ��ּܣ����)���Ͷ������ű�
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colWorktypeChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colWorktypeChoice.HeaderText = "ѡ����";
                colWorktypeChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWorktype = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWorktype.HeaderText = "��������";
                colWorktype.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colWorkNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colWorkNumber.HeaderText = "����";
                colWorkNumber.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "ɾ����";
                colWorkDelete.Width = 60;
                Dgv_Recommend1Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend1Labor.Columns.Add(colWorktype);
                Dgv_Recommend1Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend1Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend1Labor.Rows.Add();

                object[] strWork = new object[] { "��������", "��ȫ�ල", "�������", "��������", "���ӹ�" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend1Labor.CurrentRow.Index;
                        Dgv_Recommend1Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_Recommend1Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //1�ۼ�ʽ�ֹܽ��ּܣ����)�����߰��ű�
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colToolChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colToolChoice.HeaderText = "ѡ�����";
                colToolChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTool = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTool.HeaderText = "��������";
                colTool.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colToolNumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colToolNumber.HeaderText = "����";
                colToolNumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colToollRemark = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colToollRemark.HeaderText = "��ע";
                colToollRemark.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colToolDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colToolDelete.HeaderText = "ɾ����";
                colToolDelete.Width = 50;
                Dgv_Recommend1Tool.Columns.Add(colToolChoice);
                Dgv_Recommend1Tool.Columns.Add(colTool);
                Dgv_Recommend1Tool.Columns.Add(colToolNumber);
                Dgv_Recommend1Tool.Columns.Add(colToollRemark);
                Dgv_Recommend1Tool.Columns.Add(colToolDelete);
                Dgv_Recommend1Tool.Rows.Add();

                object[] strTool = new object[] { "���Ӱ���", "���ذ���", "��    ��"};
                string[] strRemark = new string[] { " ���ӹ�����Ͳ��������", " �����ӿۼ�š�������Ƿ�ﵽҪ��", "��������ˮƽ������ " };
                string[] strToolNumber = new string[] { "       ��", "       ��", "       ��",};
                for (int i = 0; i < strTool.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strTool[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend1Tool.CurrentRow.Index;
                        Dgv_Recommend1Tool.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strTool.Length; j++)
                        {
                            if (btnItem.Text == strTool[j].ToString())
                            {
                                Dgv_Recommend1Tool.Rows[RowNum].Cells[2].Value = strToolNumber[j];
                                Dgv_Recommend1Tool.Rows[RowNum].Cells[3].Value = strRemark[j];
                                break;
                            }
                        }
                        Dgv_Recommend1Tool.Refresh();
                    });
                    colToolChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //��ȡģ�������
            string templatename="";
            if (Rdo_Item1DP.Checked)
            { templatename = "�ۼ�ʽ�ֹܽ��ּܣ���أ�����"; }
            else if(Rdo_Item1SP.Checked)
            { templatename = "�ۼ�ʽ�ֹܽ��ּܣ���أ�˫��"; }
            Framework.Entity.Template templatetemp=new Framework.Entity.Template();       
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chaptertemp.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == templatename)
                {
                    templatetemp = template;
                    break;
                }
            }
            #endregion

            System.Collections.ArrayList array = new System.Collections.ArrayList();
            System.Collections.ArrayList array1 = new System.Collections.ArrayList();
            System.Collections.ArrayList array2 = new System.Collections.ArrayList();
            System.Collections.ArrayList array3 = new System.Collections.ArrayList();
            for (int i = 0; i < Dgv_Recommend1Material.Rows.Count; i++)
            {
                if (Dgv_Recommend1Material.Rows[i].Cells[1].Value != null)
                {
                    array1.Add(new object[] { i + 1, Dgv_Recommend1Material.Rows[i].Cells[1].Value, Dgv_Recommend1Material.Rows[i].Cells[2].Value, Dgv_Recommend1Material.Rows[i].Cells[3].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend1Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend1Labor.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend1Labor.Rows[i].Cells[1].Value, Dgv_Recommend1Labor.Rows[i].Cells[2].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend1Tool.Rows.Count; i++)
            {
                if (Dgv_Recommend1Tool.Rows[i].Cells[1].Value != null)
                {
                    array3.Add(new object[] { i + 1, Dgv_Recommend1Tool.Rows[i].Cells[1].Value, Dgv_Recommend1Tool.Rows[i].Cells[2].Value, Dgv_Recommend1Tool.Rows[i].Cells[3].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            

             string textDxhg = "";
             string textLqj = "";
             object[] data = new object[] { };
             if (Rdo_Item1DHG.Checked) { textDxhg = Rdo_Item1DHG.Text; }
             else if (Rdo_Item1XHG.Checked) { textDxhg = Rdo_Item1XHG.Text; }
             if (Rdo_Item1LBSK.Checked) { textLqj = Rdo_Item1LBSK.Text; }
             else if (Rdo_Item1SBSK.Checked) { textLqj = Rdo_Item1SBSK.Text; }

             if (Rdo_Item1DP.Checked)
             {
                data =new object[] { Tb_Item1DSGD.Text, Tb_Item1HJ.Text, Tb_Item1ZJ.Text, Tb_Item1BJ.Text, textLqj ,textDxhg };   
             }
             if (Rdo_Item1SP.Checked)
             {
                  data = new object[] { Tb_Item1DSGD.Text, Tb_Item1HJ.Text, Tb_Item1ZJ.Text, Tb_Item1BJ.Text, Tb_Item1NLGJWQ.Text, Tb_Item1XHGLDJQ.Text, textLqj ,textDxhg};
             }

             CreateModuleIntance(templatetemp, array, @class, data);//4.ͨ��delegate���ݱ���ִ��ʵ������
             this.Close();
        }

        
    }
}

