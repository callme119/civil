using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend7 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);//1.����һ��delegate�������ݽṹ
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend7(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (stcRecommend7.SelectedTabIndex)
            {
                case 0: Dgv_Recommend7Material.Rows.Add(); break;
                case 1: Dgv_Recommend7Labor.Rows.Add(); break;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (stcRecommend7.SelectedTabIndex == 0)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend7Material.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend7Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend7.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend7Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend7Labor.Rows.Remove(row);
                    }
                }
            }
        }

        private void FrmRecommend7_Load(object sender, EventArgs e)
        {
            #region //7�����ּܡ����ϰ��ű�
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
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialRemark = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialRemark.HeaderText = "���";
                colMaterialRemark.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "ɾ����";
                colMaterialDelete.Width = 50;
                Dgv_Recommend7Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend7Material.Columns.Add(colMaterial);
                Dgv_Recommend7Material.Columns.Add(colMaterialNumber);
                Dgv_Recommend7Material.Columns.Add(colMaterialRemark);
                Dgv_Recommend7Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend7Material.Rows.Add();

                object[] strMaterial = new object[] { "�ְ��«", "���ָ�", "��˿����", "��Ŀ��", "��ȫ��", "��˿��" };
                string[] strNumber = new string[] { "         ��", "         m", "          ��", "           m2", "      ��", "         m" };
                for (int i = 0; i < strMaterial.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strMaterial[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_Recommend7Material.CurrentRow.Index;
                        Dgv_Recommend7Material.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strMaterial.Length; j++)
                        {
                            if (btnItem.Text == strMaterial[j].ToString())
                            {
                                Dgv_Recommend7Material.Rows[RowNum].Cells[2].Value = strNumber[j];
                                break;
                            }
                        }
                        Dgv_Recommend7Material.Refresh();
                    });
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //7�����ּܡ��Ͷ�������
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
                Dgv_Recommend7Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend7Labor.Columns.Add(colWorktype);
                Dgv_Recommend7Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend7Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend7Labor.Rows.Add();

                object[] strWork = new object[] { "��ȫԱ", "������ҵ��Ա", "���ӹ�" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend7Labor.CurrentRow.Index;
                        Dgv_Recommend7Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_Recommend7Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //��ȡģ�������
            string templatename = "�����ּ�";
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
            for (int i = 0; i < Dgv_Recommend7Material.Rows.Count; i++)
            {
                if (Dgv_Recommend7Material.Rows[i].Cells[1].Value != null)
                {
                    array1.Add(new object[] { i + 1, Dgv_Recommend7Material.Rows[i].Cells[1].Value, Dgv_Recommend7Material.Rows[i].Cells[2].Value, Dgv_Recommend7Material.Rows[i].Cells[3].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend7Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend7Labor.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend7Labor.Rows[i].Cells[1].Value, Dgv_Recommend7Labor.Rows[i].Cells[2].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            CreateModuleIntance(templatetemp, array, @class, null);
            this.Close();
        }

    }
}

