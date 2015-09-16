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
        { //“增加行”“删除行”两个按钮的显隐
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
            #region //2扣件式钢管脚手架（落地+悬挑)—具体搭设情况
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colTaskChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colTaskChoice.HeaderText = "选择项目";
                colTaskChoice.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTask = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTask.HeaderText = "项目名称";
                colTask.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTaskPlace = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTaskPlace.HeaderText = "搭设部位";
                colTaskPlace.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTaskhigh = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTaskhigh.HeaderText = "搭设高度";
                colTaskhigh.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colTaskDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colTaskDelete.HeaderText = "删除行";
                colTaskDelete.Width = 50;
                Dgv_Recommend2Task.Columns.Add(colTaskChoice);
                Dgv_Recommend2Task.Columns.Add(colTask);
                Dgv_Recommend2Task.Columns.Add(colTaskPlace);
                Dgv_Recommend2Task.Columns.Add(colTaskhigh);
                Dgv_Recommend2Task.Columns.Add(colTaskDelete);
                Dgv_Recommend2Task.Rows.Add();

                object[] strTask = new object[] { "第一挑", "第二挑", "第三挑", "第X挑"};
                string[] strTaskPlace = new string[] { "XX层～XX层", "XX层～XX层", "XX层～XX层", "XX层～屋面", };
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

            #region //2扣件式钢管脚手架（落地+悬挑)—材料安排表
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
                Dgv_Recommend2Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend2Material.Columns.Add(colMaterial);
                Dgv_Recommend2Material.Columns.Add(colMaterialNumber);
                Dgv_Recommend2Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend2Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend2Material.Rows.Add();

                object[] strMaterial = new object[] { "无缝钢管", "木脚手板", "冲压钢脚手板", "竹串片脚手板", "竹芭脚手板", "密目安全网", "水平安全网", "直角扣件", "旋转扣件", "对接扣件" };
                string[] strStandard = new string[] { "ф48.3mm×3.6mm", "0.35 kN/m2", "0.30 kN/m2", "0.35 kN/m2", "0.10 kN/m2", "1.8m×6.0m", " ", " ", " ", " " };
                string[] strNumber = new string[] { "         m", "         m2", "           m2", "           m2", "      m2", "           m2", "           m2", "           个", "           个", "          个" };
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

            #region //2扣件式钢管脚手架（落地+悬挑)—劳动力安排表
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colWorktypeChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colWorktypeChoice.HeaderText = "选择工种";
                colWorktypeChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWorktype = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWorktype.HeaderText = "工种名称";
                colWorktype.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colWorkNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colWorkNumber.HeaderText = "人数";
                colWorkNumber.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "删除行";
                colWorkDelete.Width = 60;
                Dgv_Recommend2Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend2Labor.Columns.Add(colWorktype);
                Dgv_Recommend2Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend2Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend2Labor.Rows.Add();

                object[] strWork = new object[] { "技术管理", "安全监督", "质量检查", "测量放线", "架子工" };
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

            #region //2扣件式钢管脚手架（落地+悬挑)—机具安排表
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colToolChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colToolChoice.HeaderText = "选择材料";
                colToolChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colTool = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colTool.HeaderText = "机具名称";
                colTool.Width = 140;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colToolNumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colToolNumber.HeaderText = "数量";
                colToolNumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colToollRemark = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colToollRemark.HeaderText = "备注";
                colToollRemark.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colToolDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colToolDelete.HeaderText = "删除行";
                colToolDelete.Width = 50;
                Dgv_Recommend2Tool.Columns.Add(colToolChoice);
                Dgv_Recommend2Tool.Columns.Add(colTool);
                Dgv_Recommend2Tool.Columns.Add(colToolNumber);
                Dgv_Recommend2Tool.Columns.Add(colToollRemark);
                Dgv_Recommend2Tool.Columns.Add(colToolDelete);
                Dgv_Recommend2Tool.Rows.Add();

                object[] strTool = new object[] { "架子扳手", "力矩扳手", "倒    链" };
                string[] strRemark = new string[] { " 架子工搭设和拆除架子用", " 检查架子扣件拧紧力度是否达到要求", "调整架子水平弯曲度 " };
                string[] strToolNumber = new string[] { "       把", "       把", "       把", };
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
            #region  //获取模板的内容
            string templatename = "扣件式钢管脚手架（落地+悬挑）";
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

