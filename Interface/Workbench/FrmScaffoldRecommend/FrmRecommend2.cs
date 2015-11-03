using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend2 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend2(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (stcRecommend2.SelectedTabIndex)
            {
                case 0: Dgv_Recommend2Task.Rows.Add(); break;
                case 3: Dgv_Recommend2Material.Rows.Add(); break;
                case 4: Dgv_Recommend2Labor.Rows.Add(); break;
                case 5: Dgv_Recommend2Tool.Rows.Add(); break;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (stcRecommend2.SelectedTabIndex == 0)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend2Task.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend2Task.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend2.SelectedTabIndex == 3)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend2Material.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend2Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend2.SelectedTabIndex == 4)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend2Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend2Labor.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend2.SelectedTabIndex == 5)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend2Tool.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend2Tool.Rows.Remove(row);
                    }
                }
            }
        }

        private void stcRecommend2_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        { //�������С���ɾ���С�������ť������
            if (stcRecommend2.SelectedTabIndex == 2)
            {
                btnAddRow.Visible = false;
                btnDeleteRow.Visible = false;
            }
            if (stcRecommend2.SelectedTabIndex == 0 | stcRecommend2.SelectedTabIndex == 3 | stcRecommend2.SelectedTabIndex == 4 | stcRecommend2.SelectedTabIndex == 5)
            {
                btnAddRow.Visible = true;
                btnDeleteRow.Visible = true;
            }
        }

        private void FrmRecommend2_Load(object sender, EventArgs e)
        {
            #region //2�ۼ�ʽ�ֹܽ��ּܣ����+����)������������
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colTaskChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colTaskChoice.HeaderText = "ѡ����Ŀ";
                colTaskChoice.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTask = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTask.HeaderText = "��Ŀ����";
                colTask.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTaskPlace = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTaskPlace.HeaderText = "���貿λ";
                colTaskPlace.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTaskhigh = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTaskhigh.HeaderText = "����߶�";
                colTaskhigh.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colTaskDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colTaskDelete.HeaderText = "ɾ����";
                colTaskDelete.Width = 50;
                Dgv_Recommend2Task.Columns.Add(colTaskChoice);
                Dgv_Recommend2Task.Columns.Add(colTask);
                Dgv_Recommend2Task.Columns.Add(colTaskPlace);
                Dgv_Recommend2Task.Columns.Add(colTaskhigh);
                Dgv_Recommend2Task.Columns.Add(colTaskDelete);
                Dgv_Recommend2Task.Rows.Add();

                object[] strTask = new object[] { "��һ��", "�ڶ���", "������", "��X��"};
                string[] strTaskPlace = new string[] { "XX�㡫XX��", "XX�㡫XX��", "XX�㡫XX��", "XX�㡫����", };
                string[] strTaskHigh = new string[] { "         m", "         m", "           m", "           m" };
                for (int i = 0; i < strTask.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strTask[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_Recommend2Task.CurrentRow.Index;
                        Dgv_Recommend2Task.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strTask.Length; j++)
                        {
                            if (btnItem.Text == strTask[j].ToString())
                            {
                                Dgv_Recommend2Task.Rows[RowNum].Cells[2].Value = strTaskPlace[j];
                                Dgv_Recommend2Task.Rows[RowNum].Cells[3].Value = strTaskHigh[j];
                                break;
                            }
                        }
                        Dgv_Recommend2Task.Refresh();
                    });
                    colTaskChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //2�ۼ�ʽ�ֹܽ��ּܣ����+����)�����ϰ��ű�
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
                Dgv_Recommend2Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend2Material.Columns.Add(colMaterial);
                Dgv_Recommend2Material.Columns.Add(colMaterialNumber);
                Dgv_Recommend2Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend2Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend2Material.Rows.Add();

                object[] strMaterial = new object[] { "�޷�ֹ�", "ľ���ְ�", "��ѹ�ֽ��ְ�", "��Ƭ���ְ�", "��Ž��ְ�", "��Ŀ��ȫ��", "ˮƽ��ȫ��", "ֱ�ǿۼ�", "��ת�ۼ�", "�Խӿۼ�" };
                string[] strStandard = new string[] { "��48.3mm��3.6mm", "0.35 kN/m2", "0.30 kN/m2", "0.35 kN/m2", "0.10 kN/m2", "1.8m��6.0m", " ", " ", " ", " " };
                string[] strNumber = new string[] { "         m", "         m2", "           m2", "           m2", "      m2", "           m2", "           m2", "           ��", "           ��", "          ��" };
                for (int i = 0; i < strMaterial.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strMaterial[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_Recommend2Material.CurrentRow.Index;
                        Dgv_Recommend2Material.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strMaterial.Length; j++)
                        {
                            if (btnItem.Text == strMaterial[j].ToString())
                            {
                                Dgv_Recommend2Material.Rows[RowNum].Cells[2].Value = strNumber[j];
                                Dgv_Recommend2Material.Rows[RowNum].Cells[3].Value = strStandard[j];
                                break;
                            }
                        }
                        Dgv_Recommend2Material.Refresh();
                    });
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //2�ۼ�ʽ�ֹܽ��ּܣ����+����)���Ͷ������ű�
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
                Dgv_Recommend2Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend2Labor.Columns.Add(colWorktype);
                Dgv_Recommend2Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend2Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend2Labor.Rows.Add();

                object[] strWork = new object[] { "��������", "��ȫ�ල", "�������", "��������", "���ӹ�" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend2Labor.CurrentRow.Index;
                        Dgv_Recommend2Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_Recommend2Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //2�ۼ�ʽ�ֹܽ��ּܣ����+����)�����߰��ű�
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
                Dgv_Recommend2Tool.Columns.Add(colToolChoice);
                Dgv_Recommend2Tool.Columns.Add(colTool);
                Dgv_Recommend2Tool.Columns.Add(colToolNumber);
                Dgv_Recommend2Tool.Columns.Add(colToollRemark);
                Dgv_Recommend2Tool.Columns.Add(colToolDelete);
                Dgv_Recommend2Tool.Rows.Add();

                object[] strTool = new object[] { "���Ӱ���", "���ذ���", "��    ��" };
                string[] strRemark = new string[] { " ���ӹ�����Ͳ��������", " �����ӿۼ�š�������Ƿ�ﵽҪ��", "��������ˮƽ������ " };
                string[] strToolNumber = new string[] { "       ��", "       ��", "       ��", };
                for (int i = 0; i < strTool.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strTool[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend2Tool.CurrentRow.Index;
                        Dgv_Recommend2Tool.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strTool.Length; j++)
                        {
                            if (btnItem.Text == strTool[j].ToString())
                            {
                                Dgv_Recommend2Tool.Rows[RowNum].Cells[2].Value = strToolNumber[j];
                                Dgv_Recommend2Tool.Rows[RowNum].Cells[3].Value = strRemark[j];
                                break;
                            }
                        }
                        Dgv_Recommend2Tool.Refresh();
                    });
                    colToolChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //��ȡģ�������
            string templatename = "�ۼ�ʽ�ֹܽ��ּܣ����+������";
            Framework.Entity.Template templatetemp = new Framework.Entity.Template();
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
            System.Collections.ArrayList array3= new System.Collections.ArrayList();
            System.Collections.ArrayList array4 = new System.Collections.ArrayList();
            for (int i = 0; i < Dgv_Recommend2Task.Rows.Count; i++)
            {
                if (Dgv_Recommend2Task.Rows[i].Cells[1].Value != null)
                {
                    array1.Add(new object[] { i + 1, Dgv_Recommend2Task.Rows[i].Cells[1].Value, Dgv_Recommend2Task.Rows[i].Cells[2].Value, Dgv_Recommend2Task.Rows[i].Cells[3].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend2Material.Rows.Count; i++)
            {
                if (Dgv_Recommend2Material.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend2Material.Rows[i].Cells[1].Value, Dgv_Recommend2Material.Rows[i].Cells[2].Value, Dgv_Recommend2Material.Rows[i].Cells[3].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend2Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend2Labor.Rows[i].Cells[1].Value != null)
                {
                    array3.Add(new object[] { i + 1, Dgv_Recommend2Labor.Rows[i].Cells[1].Value, Dgv_Recommend2Labor.Rows[i].Cells[2].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend2Tool.Rows.Count; i++)
            {
                if (Dgv_Recommend2Tool.Rows[i].Cells[1].Value != null)
                {
                    array4.Add(new object[] { i + 1, Dgv_Recommend2Tool.Rows[i].Cells[1].Value, Dgv_Recommend2Tool.Rows[i].Cells[2].Value, Dgv_Recommend2Tool.Rows[i].Cells[3].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            array.Add(array4);

            string textDxhg2 = "", textDxhg3 = "";
            string textLqj2 = "",  textLqj3 = "";
            if (Rdo_Item2DHG.Checked) { textDxhg2 = Rdo_Item2DHG.Text; }
            else if (Rdo_Item2XHG.Checked) { textDxhg2 = Rdo_Item2XHG.Text; }
            if (Rdo_Item2LBSK.Checked) { textLqj2 = Rdo_Item2LBSK.Text; }
            else if (Rdo_Item2SBSK.Checked) { textLqj2 = Rdo_Item2SBSK.Text; }
            if (Rdo_Item3DHG.Checked) { textDxhg3 = Rdo_Item3DHG.Text; }
             else if (Rdo_Item3XHG.Checked) { textDxhg3 = Rdo_Item3XHG.Text; }
            if (Rdo_Item3LBSK.Checked) { textLqj3 = Rdo_Item3LBSK.Text; }
             else if (Rdo_Item3SBSK.Checked) { textLqj3 = Rdo_Item3SBSK.Text; }

            object[] data = new object[] {IntInput_Item1DSBW1.Value ,  IntInput_Item1DSBW2.Value , IntInput_Item1DSGD.Value , Tb_Item2HJ.Text, Tb_Item2ZJ.Text, Tb_Item2BJ.Text, Tb_Item2NLGJWQ.Text, Tb_Item2XHGLDJQ.Text, textLqj2, textDxhg2 ,
                                             Cbx_Item3XGSPXTG.Text, Tb_Item3HJ.Text, Tb_Item3ZJ.Text, Tb_Item3BJ.Text, Tb_Item3NLGJWQ.Text, Tb_Item3XHGLDJQ.Text, textLqj3, textDxhg3 };

            CreateModuleIntance(templatetemp, array, @class, data);
            this.Close();
        }

    }
}

