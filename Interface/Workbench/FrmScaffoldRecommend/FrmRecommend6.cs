using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend6 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);//1.定义一个delegate函数数据结构
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend6(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (stcRecommend6.SelectedTabIndex)
            {
                case 2: Dgv_Recommend6Material.Rows.Add(); break;
                case 3: Dgv_Recommend6Labor.Rows.Add(); break;
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (stcRecommend6.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend6Material.Rows)
                {
                    if (row.Cells[4].Value != null && Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        this.Dgv_Recommend6Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend6.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend6Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend6Labor.Rows.Remove(row);
                    }
                }
            }
        }

        private void FrmRecommend6_Load(object sender, EventArgs e)
        {
            #region //液压升降式整体脚手架技术指标
            DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colParaType1 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            colParaType1.HeaderText = "技术指标";
            colParaType1.Width = 180;
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colParaResult1 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            colParaResult1.HeaderText = "指标值";
            colParaResult1.Width = 100;
            DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colParaType2 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            colParaType2.HeaderText = "技术指标";
            colParaType2.Width = 180;
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colParaResult2 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            colParaResult2.HeaderText = "指标值";
            colParaResult2.Width = 100;

            Dgv_Recommend6Para.Columns.Add(colParaType1);
            Dgv_Recommend6Para.Columns.Add(colParaResult1);
            Dgv_Recommend6Para.Columns.Add(colParaType2);
            Dgv_Recommend6Para.Columns.Add(colParaResult2);
            Dgv_Recommend6Para.Rows.Add(9);
            string[] strParaType1 = new string[] { "架体高度", "立杆纵距", "架体允许悬挑长度", "主框架曲线间距离", "主框架间连墙点", "升降同步差", "单千斤顶提升力", "使用工况设计活荷载", "提升速度" };
            string[] strParaResult1 = new string[] { "Xm", "Xm", "Xm", "≤Xm", "≮X个", "≯Xmm", "XKN", "XKN/m2", "XM/小时"};
            string[] strParaType2 = new string[] { "架体宽度", "架体步距", "主框架直线间距离", "主框架间架体迎风面积", "用电总功率", "防坠落距离", "单层提升高度", "提升工况设计活荷载", ""};
            string[] strParaResult2 = new string[] { "Xm", "Xm", "≤Xm", "≯X㎡", "XKW", "≯Xcm", "Xm", "XKN/m2","" };

            for (int i = 0; i < strParaType1.Length; i++)
            {
                Dgv_Recommend6Para.Rows[i].Cells[0].Value = strParaType1[i];
                Dgv_Recommend6Para.Rows[i].Cells[1].Value = strParaResult1[i];
                Dgv_Recommend6Para.Rows[i].Cells[2].Value = strParaType2[i];
                Dgv_Recommend6Para.Rows[i].Cells[3].Value = strParaResult2[i];
            }
            #endregion

            #region //6液压升降式整体脚手架—材料安排表
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colMaterialChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colMaterialChoice.HeaderText = "选择材料";
                colMaterialChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterial = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterial.HeaderText = "材料名称";
                colMaterial.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialNumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialNumber.HeaderText = "数量";
                colMaterialNumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialStandard = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialStandard.HeaderText = "规格";
                colMaterialStandard.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "删除行";
                colMaterialDelete.Width = 50;
                Dgv_Recommend6Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend6Material.Columns.Add(colMaterial);
                Dgv_Recommend6Material.Columns.Add(colMaterialNumber);
                Dgv_Recommend6Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend6Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend6Material.Rows.Add();

                object[] strMaterial = new object[] { "无缝钢管", "木脚手板", "冲压钢脚手板", "竹串片脚手板", "竹芭脚手板", "密目安全网", "水平安全网", "直角扣件", "旋转扣件", "对接扣件" };
                string[] strStandard = new string[] { "ф48.3mm×3.6mm", "0.35 kN/m2", "0.30 kN/m2", "0.35 kN/m2", "0.10 kN/m2", "1.8m×6.0m", " ", " ", " ", " " };
                string[] strNumber = new string[] { "         m", "         m2", "           m2", "           m2", "      m2", "           m2", "           m2", "           个", "           个", "          个" };
                for (int i = 0; i < strMaterial.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strMaterial[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_Recommend6Material.CurrentRow.Index;
                        Dgv_Recommend6Material.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strMaterial.Length; j++)
                        {
                            if (btnItem.Text == strMaterial[j].ToString())
                            {
                                Dgv_Recommend6Material.Rows[RowNum].Cells[2].Value = strNumber[j];
                                Dgv_Recommend6Material.Rows[RowNum].Cells[3].Value = strStandard[j];
                                break;
                            }
                        }
                        Dgv_Recommend6Material.Refresh();
                    });
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //6液压升降式整体脚手架—人员安排表
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colWorktypeChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colWorktypeChoice.HeaderText = "选择职务";
                colWorktypeChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWorktype = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWorktype.HeaderText = "职务名称";
                colWorktype.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colWorkNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colWorkNumber.HeaderText = "人数";
                colWorkNumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWorkduty = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWorkduty.HeaderText = "职责";
                colWorkduty.Width = 200;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "删除行";
                colWorkDelete.Width = 60;
                Dgv_Recommend6Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend6Labor.Columns.Add(colWorktype);
                Dgv_Recommend6Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend6Labor.Columns.Add(colWorkduty);
                Dgv_Recommend6Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend6Labor.Rows.Add();

                object[] strWork = new object[] { "负责人", "项目经理", "安全员", "资料员", "操作工", "焊工", "机械工" };
                object[] strDuty = new object[] { "负责导轨式液压升降脚手架施工组织设计的编制、液压升降脚手架工程总协调", "负责与上级、兄弟单位有关的协调，架体安拆、升降、安全检查", "负责架体的安全检查、签证", "负责相应资料的收集和上报工作", "负责升降、支座位移、日常保养工作。", "负责现场特殊情况需要焊接的工作。", "设备维护保养工作。" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend6Labor.CurrentRow.Index;
                        Dgv_Recommend6Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strWork.Length; j++)
                        {
                            if (btnItem.Text == strWork[j].ToString())
                            {
                                Dgv_Recommend6Labor.Rows[RowNum].Cells[3].Value = strDuty[j];
                                break;
                            }
                        }
                        Dgv_Recommend6Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //获取模板的内容
            string templatename = "液压升降式整体脚手架"; 
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
            System.Collections.ArrayList array3 = new System.Collections.ArrayList();
            for (int i = 0; i < Dgv_Recommend6Para.RowCount; i++)
            {
                array1.Add(new object[] { Dgv_Recommend6Para.Rows[i].Cells[0].Value, Dgv_Recommend6Para.Rows[i].Cells[1].Value, Dgv_Recommend6Para.Rows[i].Cells[2].Value, Dgv_Recommend6Para.Rows[i].Cells[3].Value });
            }
            for (int i = 0; i < Dgv_Recommend6Material.Rows.Count; i++)
            {
                if (Dgv_Recommend6Material.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend6Material.Rows[i].Cells[1].Value, Dgv_Recommend6Material.Rows[i].Cells[2].Value, Dgv_Recommend6Material.Rows[i].Cells[3].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend6Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend6Labor.Rows[i].Cells[1].Value != null)
                {
                    array3.Add(new object[] { i + 1, Dgv_Recommend6Labor.Rows[i].Cells[1].Value, Dgv_Recommend6Labor.Rows[i].Cells[2].Value ,Dgv_Recommend6Labor.Rows[i].Cells[3].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            CreateModuleIntance(templatetemp, array, @class, null );
            this.Close();
        }

        private void stcRecommend6_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            #region
            //“增加行”“删除行”两个按钮的显隐
            if (stcRecommend6.SelectedTabIndex == 0)
            {
                btnAddRow.Visible = false;
                btnDeleteRow.Visible = false;
            }
            if (stcRecommend6.SelectedTabIndex == 1 | stcRecommend6.SelectedTabIndex == 2)
            {
                btnAddRow.Visible = true;
                btnDeleteRow.Visible = true;
            }
            #endregion
        }
    }
}

