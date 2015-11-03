using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmConretestrength1 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Chapter chaptertemp;
        private System.Collections.ArrayList templateList;

        public FrmConretestrength1(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            chaptertemp = chapter;
            
        }

        private void CbxBeamFormType_SelectedIndexChanged(object sender, EventArgs e)//��������ѡ�����
        {
            
            #region//�ڵ�һ����ǩ�²���һ��
            if (CbxBeamFormType.SelectedIndex == 1 && X_Base.Columns.Count==5)
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colimportance = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colimportance.HeaderText = "��Ҫ��";
                colimportance.Name = "��Ҫ��";
                colimportance.Width = 100;

                object[] strGrade = new object[] {"һ��","����","����"};
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Base.CurrentRow.Index;
                        X_Base.Rows[RowNum].Cells[2].Value = btnItem.Text;
                        X_Base.Refresh();
                    });
                    colimportance.SubItems.Add(btnItem);
                }

                this.X_Base.Columns.Insert(2, colimportance);
            }
            else if (CbxBeamFormType.SelectedIndex == 0 && X_Base.Columns.Count == 6)
            {
                X_Base.Columns.Remove("��Ҫ��");
            }
            #endregion
            #region//�ڵڶ�����ǩ�²���һ��
            if (CbxBeamFormType.SelectedIndex == 1 && X_Mainpart.Columns.Count == 6)
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colimportance = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colimportance.HeaderText = "��Ҫ��";
                colimportance.Name = "��Ҫ��";
                colimportance.Width = 70;

                object[] strGrade = new object[] { "һ��", "����", "����" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Mainpart.CurrentRow.Index;
                        X_Mainpart.Rows[RowNum].Cells[3].Value = btnItem.Text;
                        X_Mainpart.Refresh();
                    });
                    colimportance.SubItems.Add(btnItem);
                }

                this.X_Mainpart.Columns.Insert(3, colimportance);
            }
            else if (CbxBeamFormType.SelectedIndex == 0 && X_Mainpart.Columns.Count == 7)
            {
                X_Mainpart.Columns.Remove("��Ҫ��");
            }
            #endregion
            #region//�ڵ�������ǩ�²���һ��
            if (CbxBeamFormType.SelectedIndex == 1 && X_Concrete.Columns.Count == 4)
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colimportance = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colimportance.HeaderText = "��Ҫ��";
                colimportance.Name = "��Ҫ��";
                colimportance.Width = 100;

                object[] strGrade = new object[] { "һ��", "����", "����" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Concrete.CurrentRow.Index;
                        X_Concrete.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        X_Concrete.Refresh();
                    });
                    colimportance.SubItems.Add(btnItem);
                }

                this.X_Concrete.Columns.Insert(1, colimportance);
            }
            else if (CbxBeamFormType.SelectedIndex == 0 && X_Concrete.Columns.Count == 5)
            {
                X_Concrete.Columns.Remove("��Ҫ��");
            }
            #endregion
            #region//�ڵ��ĸ���ǩ�²���һ��
            if (CbxBeamFormType.SelectedIndex == 1 && X_Otherproject.Columns.Count == 5)
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colimportance = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colimportance.HeaderText = "��Ҫ��";
                colimportance.Name = "��Ҫ��";
                colimportance.Width = 100;

                object[] strGrade = new object[] { "һ��", "����", "����" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Otherproject.CurrentRow.Index;
                        X_Otherproject.Rows[RowNum].Cells[2].Value = btnItem.Text;
                        X_Otherproject.Refresh();
                    });
                    colimportance.SubItems.Add(btnItem);
                }

                this.X_Otherproject.Columns.Insert(2, colimportance);
            }
            else if (CbxBeamFormType.SelectedIndex == 0 && X_Otherproject.Columns.Count == 6)
            {
                X_Otherproject.Columns.Remove("��Ҫ��");
            }
          #endregion

        }
        private void btnAddRow_Click(object sender, EventArgs e)//������ǩ�������
        {
            if(X_FS1.SelectedTabIndex==0)
            {
            
            DataGridViewRow row = new DataGridViewRow();
            X_Base.Rows.Add();
            }
           else if (X_FS1.SelectedTabIndex == 1)
            {

                DataGridViewRow row = new DataGridViewRow();
                X_Mainpart.Rows.Add();
            }
           else if (X_FS1.SelectedTabIndex == 2)
            {

                DataGridViewRow row = new DataGridViewRow();
                X_Concrete.Rows.Add();
            }
            else if (X_FS1.SelectedTabIndex == 3)
            {

                DataGridViewRow row = new DataGridViewRow();
                X_Otherproject.Rows.Add();
            }
        }


        private void FrmConretestrength1_Load(object sender, EventArgs e)
        {
            CbxBeamFormType.SelectedIndex = 0;
            #region ���ݽ�������
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colbuildingfoundation = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colbuildingfoundation.HeaderText = "��������";
                colbuildingfoundation.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colconretestrength = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colconretestrength.HeaderText = "������ǿ�ȵȼ�";
                colconretestrength.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colconreteuse = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colconreteuse.HeaderText = "����������";
                colconreteuse.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colsamplingnumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colsamplingnumber.HeaderText = "ȡ���������飩";
                colsamplingnumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "ɾ����";
                colWorkDelete.Width = 60;
                X_Base.Columns.Add(colbuildingfoundation);
                X_Base.Columns.Add(colconretestrength);
                X_Base.Columns.Add(colconreteuse);
                X_Base.Columns.Add(colsamplingnumber);
                X_Base.Columns.Add(colWorkDelete);
                X_Base.Rows.Add();

                object[] strWork = new object[] { "��","���", "��","��", "ǽ" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Base.CurrentRow.Index;
                        X_Base.Rows[RowNum].Cells[0].Value = btnItem.Text;
                        X_Base.Refresh();
                    });
                    colbuildingfoundation.SubItems.Add(btnItem);
                }
                object[] strGrade = new object[] { "��", "C15", "C20", "C25", "C30", "C35", "C40", "C45", "C50", "C55", "C60", "C65", "C70", "C75", "C80" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Base.CurrentRow.Index;
                        X_Base.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        X_Base.Refresh();
                    });
                    colconretestrength.SubItems.Add(btnItem);
                }

            }
            #endregion
            #region //���ݽ�������
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colmainfloor = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colmainfloor.HeaderText = "�������";
                colmainfloor.Width = 90;
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colmaintype = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colmaintype.HeaderText = "��������";
                colmaintype.Width = 90;
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colconretestrength = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colconretestrength.HeaderText = "������ǿ�ȵȼ�";
                colconretestrength.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colconreteuse = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colconreteuse.HeaderText = "����������";
                colconreteuse.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colsamplingnumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colsamplingnumber.HeaderText = "ȡ���������飩";
                colsamplingnumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "ɾ����";
                colWorkDelete.Width = 60;
                X_Mainpart.Columns.Add(colmainfloor);
                X_Mainpart.Columns.Add(colmaintype);
                X_Mainpart.Columns.Add(colconretestrength);
                X_Mainpart.Columns.Add(colconreteuse);
                X_Mainpart.Columns.Add(colsamplingnumber);
                X_Mainpart.Columns.Add(colWorkDelete);
                X_Mainpart.Rows.Add();

                object[] strfloor = new object[] {"��","�ײ�","����","����","�Ĳ�","���","����","�߲�","�˲�","�Ų�","ʮ��",
                    "ʮһ��","ʮ����","ʮ����","ʮ�Ĳ�","ʮ���","ʮ����","ʮ�߲�","ʮ�˲�","ʮ�Ų�","��ʮһ��","��ʮ����","��ʮ����","��ʮ�Ĳ�","��ʮ���",
                    "��ʮ����","��ʮ�߲�","��ʮ�˲�","��ʮ�Ų�","��ʮ","����" };
                for (int i = 0; i < strfloor.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strfloor[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Mainpart.CurrentRow.Index;
                        X_Mainpart.Rows[RowNum].Cells[0].Value = btnItem.Text;
                        X_Mainpart.Refresh();
                    });
                    colmainfloor.SubItems.Add(btnItem);

                }
                object[] strtype = new object[] { "��", "ǽ", "��", "��", "��" };
                for (int i = 0; i < strtype.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strtype[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Mainpart.CurrentRow.Index;
                        X_Mainpart.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        X_Mainpart.Refresh();
                    });
                    colmaintype.SubItems.Add(btnItem);

                }
                object[] strGrade = new object[] { "��", "C15", "C20", "C25", "C30", "C35", "C40", "C45", "C50", "C55", "C60", "C65", "C70", "C75", "C80" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Mainpart.CurrentRow.Index;
                        X_Mainpart.Rows[RowNum].Cells[2].Value = btnItem.Text;
                        X_Mainpart.Refresh();
                    });
                    colconretestrength.SubItems.Add(btnItem);
                }

            }
            #endregion
            #region ���ݽ������ǻ�����
            {
               
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colconretestrength = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colconretestrength.HeaderText = "������ǿ�ȵȼ�";
                colconretestrength.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colconreteuse = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colconreteuse.HeaderText = "����������";
                colconreteuse.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colsamplingnumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colsamplingnumber.HeaderText = "ȡ���������飩";
                colsamplingnumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "ɾ����";
                colWorkDelete.Width = 60;
                X_Concrete.Columns.Add(colconretestrength);
                X_Concrete.Columns.Add(colconreteuse);
                X_Concrete.Columns.Add(colsamplingnumber);
                X_Concrete.Columns.Add(colWorkDelete);
                X_Concrete.Rows.Add();

                
                object[] strGrade = new object[] { "��","C15", "C20", "C25", "C30", "C35", "C40", "C45", "C50", "C55", "C60", "C65", "C70", "C75", "C80" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Concrete.CurrentRow.Index;
                        X_Concrete.Rows[RowNum].Cells[0].Value = btnItem.Text;
                        X_Concrete.Refresh();
                    });
                    colconretestrength.SubItems.Add(btnItem);
                }

            }
             #endregion
            #region ��������
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colbuildingfoundation = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colbuildingfoundation.HeaderText = "ȡ��λ��";
                colbuildingfoundation.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colconretestrength = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colconretestrength.HeaderText = "������ǿ�ȵȼ�";
                colconretestrength.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colconreteuse = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colconreteuse.HeaderText = "����������";
                colconreteuse.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colsamplingnumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colsamplingnumber.HeaderText = "ȡ���������飩";
                colsamplingnumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "ɾ����";
                colWorkDelete.Width = 60;
                X_Otherproject.Columns.Add(colbuildingfoundation);
                X_Otherproject.Columns.Add(colconretestrength);
                X_Otherproject.Columns.Add(colconreteuse);
                X_Otherproject.Columns.Add(colsamplingnumber);
                X_Otherproject.Columns.Add(colWorkDelete);
                X_Otherproject.Rows.Add();

               
                object[] strGrade = new object[] { "��","C15", "C20", "C25", "C30", "C35", "C40", "C45", "C50", "C55", "C60", "C65", "C70", "C75", "C80" };
                for (int i = 0; i < strGrade.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strGrade[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = X_Otherproject.CurrentRow.Index;
                        X_Otherproject.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        X_Otherproject.Refresh();
                    });
                    colconretestrength.SubItems.Add(btnItem);
                }

            }
             #endregion
        }
            
        

        private void btnDeleteRow_Click(object sender, EventArgs e)//������ǩ��ɾ����
        {
            if (CbxBeamFormType.SelectedIndex == 0 && X_FS1.SelectedTabIndex == 0)
            {
                foreach (DataGridViewRow row in this.X_Base.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.X_Base.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 1 && X_FS1.SelectedTabIndex == 0)
            {
                foreach (DataGridViewRow row in this.X_Base.Rows)
                {
                    if (row.Cells[5].Value != null && Convert.ToBoolean(row.Cells[5].Value) == true)
                    {
                        this.X_Base.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 0 && X_FS1.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.X_Mainpart.Rows)
                {
                    if (row.Cells[5].Value != null && Convert.ToBoolean(row.Cells[5].Value) == true)
                    {
                        this.X_Mainpart.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 1 && X_FS1.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.X_Mainpart.Rows)
                {
                    if (row.Cells[6].Value != null && Convert.ToBoolean(row.Cells[6].Value) == true)
                    {
                        this.X_Mainpart.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 0 && X_FS1.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.X_Concrete.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.X_Concrete.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 1 && X_FS1.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.X_Concrete.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.X_Concrete.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 0 && X_FS1.SelectedTabIndex == 3)
            {
                foreach (DataGridViewRow row in this.X_Otherproject.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.X_Otherproject.Rows.Remove(row);
                    }
                }
            }
            if (CbxBeamFormType.SelectedIndex == 1 && X_FS1.SelectedTabIndex == 3)
            {
                foreach (DataGridViewRow row in this.X_Otherproject.Rows)
                {
                    if (row.Cells[5].Value != null && Convert.ToBoolean(row.Cells[5].Value) == true)
                    {
                        this.X_Otherproject.Rows.Remove(row);
                    }
                }
            }
            
        }

        private void Dgv_FS_Staff_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (X_Base.Columns.Count==6)
            {
                
                if(e.ColumnIndex == 3)
                {
                    double j=0;
                    
                    double i=Convert.ToInt32(this.X_Base.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    switch ((string)X_Base.Rows[e.RowIndex].Cells[2].Value)
                    { 
                        case"һ��":
                           
                            j =1.5 ;
                            break;
                        case"����":
                            
                            j=1.2;
                            break;
                        case"����":

                            j=1.0;
                            break;
                        default:
                            j = 1.5;
                            break;
                    }

                    i *= j;
                    this.X_Base.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = ((i + 49) / 100);

                }

                

            }

            if (X_Base.Columns.Count == 5 )
            {
                if (e.ColumnIndex == 2)
                {
                    int i = Convert.ToInt32(this.X_Base.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    this.X_Base.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = (i + 99) / 100;

                }              
            }
           
        }

        private void X_Mainpart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (X_Mainpart.Columns.Count == 7)
            {

                if (e.ColumnIndex == 4)
                {
                    double j = 0;

                    double i = Convert.ToInt32(this.X_Mainpart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    switch ((string)X_Mainpart.Rows[e.RowIndex].Cells[3].Value)
                    {
                        case "һ��":

                            j = 1.5;
                            break;
                        case "����":

                            j = 1.2;
                            break;
                        case "����":

                            j = 1.0;
                            break;
                        default:
                            j = 1.5;
                            break;
                    }

                    i *= j;
                    this.X_Mainpart.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = ((i + 49) / 100);

                }



            }
            if (X_Mainpart.Columns.Count == 6 )
            {
                if (e.ColumnIndex == 3)
                {
                    int i = Convert.ToInt32(this.X_Mainpart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    this.X_Mainpart.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = (i + 99) / 100;

                }
            }

        }

        private void X_Concrete_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (X_Concrete.Columns.Count == 5)
            {

                if (e.ColumnIndex == 2)
                {
                    double j = 0;

                    double i = Convert.ToInt32(this.X_Concrete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    switch ((string)X_Concrete.Rows[e.RowIndex].Cells[1].Value)
                    {
                        case "һ��":

                            j = 1.5;
                            break;
                        case "����":

                            j = 1.2;
                            break;
                        case "����":

                            j = 1.0;
                            break;
                        default:
                            j = 1.5;
                            break;
                    }

                    i *= j;
                    this.X_Concrete.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = ((i + 49) / 100);

                }



            }
            if (X_Concrete.Columns.Count == 4)
            {
                if (e.ColumnIndex == 1)
                {
                    int i = Convert.ToInt32(this.X_Concrete.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    this.X_Concrete.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = (i + 99) / 100;

                }
            }

        }

        private void X_Otherproject_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (X_Otherproject.Columns.Count == 6)
            {

                if (e.ColumnIndex == 3)
                {
                    double j = 0;

                    double i = Convert.ToInt32(this.X_Otherproject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    switch ((string)X_Otherproject.Rows[e.RowIndex].Cells[2].Value)
                    {
                        case "һ��":

                            j = 1.5;
                            break;
                        case "����":

                            j = 1.2;
                            break;
                        case "����":

                            j = 1.0;
                            break;
                        default:
                            j = 1.5;
                            break;
                    }

                    i *= j;
                    this.X_Otherproject.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = ((i + 49) / 100);

                }



            }
            if (X_Otherproject.Columns.Count == 5 )
            {
                if (e.ColumnIndex == 2)
                {
                    int i = Convert.ToInt32(this.X_Otherproject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    this.X_Otherproject.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = (i + 99) / 100;

                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //��ȡģ�������
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string templatename = "������ȡ��";
            Framework.Entity.Template templatetemp = new Framework.Entity.Template();
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chaptertemp.Title);

            #endregion
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            System.Collections.ArrayList array1 = new System.Collections.ArrayList();
            System.Collections.ArrayList array2 = new System.Collections.ArrayList();
            System.Collections.ArrayList array3= new System.Collections.ArrayList();
            System.Collections.ArrayList array4 = new System.Collections.ArrayList();
            System.Collections.ArrayList array5 = new System.Collections.ArrayList();
            System.Collections.ArrayList array6 = new System.Collections.ArrayList();
            System.Collections.ArrayList array7 = new System.Collections.ArrayList();
            System.Collections.ArrayList array8 = new System.Collections.ArrayList();
            if (X_Base.Columns.Count == 5)//����
            {
            
             for (int i = 0; i < X_Base.Rows.Count; i++)
             {
                if (X_Base.Rows[i].Cells[0].Value != null)
                {
                    array1.Add(new object[] {  X_Base.Rows[i].Cells[0].Value, X_Base.Rows[i].Cells[1].Value, 
                        X_Base.Rows[i].Cells[2].Value, X_Base.Rows[i].Cells[3].Value });
                }
             }
            }
            if (X_Base.Columns.Count == 6)
            {

                for (int i = 0; i < X_Base.Rows.Count; i++)
                {
                    if (X_Base.Rows[i].Cells[0].Value != null)
                    {
                        array5.Add(new object[] {  X_Base.Rows[i].Cells[0].Value, X_Base.Rows[i].Cells[1].Value, 
                        X_Base.Rows[i].Cells[2].Value, X_Base.Rows[i].Cells[3].Value,Convert.ToInt32(X_Base.Rows[i].Cells[4].Value) });
                    }
                }
            }

            if (X_Mainpart.Columns.Count == 6)//����
            {

                for (int i = 0; i < X_Mainpart.Rows.Count; i++)
                {
                    if (X_Mainpart.Rows[i].Cells[0].Value != null)
                    {
                        array2.Add(new object[] {  X_Mainpart.Rows[i].Cells[0].Value, X_Mainpart.Rows[i].Cells[1].Value, 
                        X_Mainpart.Rows[i].Cells[2].Value, X_Mainpart.Rows[i].Cells[3].Value,X_Mainpart.Rows[i].Cells[4].Value });
                    }
                }
            }
            if (X_Mainpart.Columns.Count == 7)
            {

                for (int i = 0; i < X_Mainpart.Rows.Count; i++)
                {
                    if (X_Mainpart.Rows[i].Cells[0].Value != null)
                    {
                        array6.Add(new object[] {   X_Mainpart.Rows[i].Cells[0].Value, X_Mainpart.Rows[i].Cells[1].Value, 
                        X_Mainpart.Rows[i].Cells[2].Value, X_Mainpart.Rows[i].Cells[3].Value,X_Mainpart.Rows[i].Cells[4].Value,
                            Convert.ToInt32(X_Mainpart.Rows[i].Cells[5].Value) });
                    }
                }
            }

            if (X_Concrete.Columns.Count == 4)//���ǻ�����
            {

                for (int i = 0; i < X_Concrete.Rows.Count; i++)
                {
                    if (X_Concrete.Rows[i].Cells[0].Value != null)
                    {
                        array3.Add(new object[] {  X_Concrete.Rows[i].Cells[0].Value, X_Concrete.Rows[i].Cells[1].Value, 
                        X_Concrete.Rows[i].Cells[2].Value });
                    }
                }
            }
            if (X_Concrete.Columns.Count == 5)
            {

                for (int i = 0; i < X_Concrete.Rows.Count; i++)
                {
                    if (X_Concrete.Rows[i].Cells[0].Value != null)
                    {
                        array7.Add(new object[] {  X_Concrete.Rows[i].Cells[0].Value, X_Concrete.Rows[i].Cells[1].Value, 
                        X_Concrete.Rows[i].Cells[2].Value,Convert.ToInt32(X_Concrete.Rows[i].Cells[3].Value) });
                    }
                }
            }

            if (X_Otherproject.Columns.Count == 5)//��������
            {

                for (int i = 0; i < X_Otherproject.Rows.Count; i++)
                {
                    if (X_Otherproject.Rows[i].Cells[0].Value != null)
                    {
                        array4.Add(new object[] {  X_Otherproject.Rows[i].Cells[0].Value, X_Otherproject.Rows[i].Cells[1].Value, 
                        X_Otherproject.Rows[i].Cells[2].Value, X_Otherproject.Rows[i].Cells[3].Value });
                    }
                }
            }
            if (X_Otherproject.Columns.Count == 6)
            {

                for (int i = 0; i < X_Otherproject.Rows.Count; i++)
                {
                    if (X_Otherproject.Rows[i].Cells[0].Value != null)
                    {
                        array8.Add(new object[] {  X_Otherproject.Rows[i].Cells[0].Value, X_Otherproject.Rows[i].Cells[1].Value, 
                        X_Otherproject.Rows[i].Cells[2].Value, X_Otherproject.Rows[i].Cells[3].Value,Convert.ToInt32(X_Otherproject.Rows[i].Cells[4].Value) });
                    }
                }
            }

            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            array.Add(array4);
            array.Add(array5);
            array.Add(array6);
            array.Add(array7);
            array.Add(array8);
           

            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == templatename)
                {
                    templatetemp = template;
                    break;
                }
            }

            CreateModuleIntance(templatetemp, array, @class, obj);
            this.Close();

        }

       

    }
}