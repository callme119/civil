using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend3 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend3(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (stcRecommend3.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend3Material.Rows)
                {
                    if (row.Cells[6].Value != null && Convert.ToBoolean(row.Cells[6].Value) == true)
                    {
                        this.Dgv_Recommend3Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend3.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend3Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend3Labor.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (stcRecommend3.SelectedTabIndex)
            {
                case 1: Dgv_Recommend3Material.Rows.Add(); break;
                case 2: Dgv_Recommend3Labor.Rows.Add(); break;
            }
        }

        private void FrmRecommend3_Load(object sender, EventArgs e)
        {
            #region //具体搭设情况
            DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colParaType1 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            colParaType1.HeaderText = "参数名称";
            colParaType1.Width = 180;
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colParaResult1 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            colParaResult1.HeaderText = "参数值";
            colParaResult1.Width = 100;
            DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colParaType2 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            colParaType2.HeaderText = "参数名称";
            colParaType2.Width = 180;
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colParaResult2 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            colParaResult2.HeaderText = "参数值";
            colParaResult2.Width = 100;

            Dgv_Recommend3Para.Columns.Add(colParaType1);
            Dgv_Recommend3Para.Columns.Add(colParaResult1);
            Dgv_Recommend3Para.Columns.Add(colParaType2);
            Dgv_Recommend3Para.Columns.Add(colParaResult2);
            Dgv_Recommend3Para.Rows.Add(6);
            string[] strParaType1 = new string[] { "脚手架搭设高度H(m)", "立杆纵向间距la(m)", "立杆步距h(m)", "顶部防护栏杆高h1(m)", "内立杆离建筑物距离a(mm)", "连墙件布置方式"};
            string[] strParaResult1 = new string[] { "X", "X", "X", "X", "X", "两步两跨/两步三跨" };
            string[] strParaType2 = new string[] { "脚手架沿纵向搭设长度L(m)", "立杆横向间距lb(m)", "脚手架总步数n", "纵横向扫地杆离地距离h2(mm)", "脚手板铺设方式",""};
            string[] strParaResult2 = new string[] { "X", "X", "X", "X", "X步1设", " " };
            
            for (int i = 0; i < strParaType1.Length; i++)
            {
                Dgv_Recommend3Para.Rows[i].Cells[0].Value = strParaType1[i];
                Dgv_Recommend3Para.Rows[i].Cells[1].Value = strParaResult1[i];
                Dgv_Recommend3Para.Rows[i].Cells[2].Value = strParaType2[i];
                Dgv_Recommend3Para.Rows[i].Cells[3].Value = strParaResult2[i];
            }
            #endregion

            #region //3碗扣式脚手架—劳动力安排表
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
                Dgv_Recommend3Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend3Labor.Columns.Add(colWorktype);
                Dgv_Recommend3Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend3Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend3Labor.Rows.Add();

                object[] strWork = new object[] { "技术管理", "安全监督", "质量检查", "测量放线", "架子工" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend3Labor.CurrentRow.Index;
                        Dgv_Recommend3Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_Recommend3Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region//3碗扣式脚手架—材料安排表
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colMaterialChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colMaterialChoice.HeaderText = "选择材料";
                colMaterialChoice.Width = 60;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialName = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialName.HeaderText = "名称";
                colMaterialName.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialType = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialType.HeaderText = "型号";
                colMaterialType.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialStandard= new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialStandard.HeaderText = "规格(mm)";
                colMaterialStandard.Width = 110;
                DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn  colMarketWeight= new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
                colMarketWeight.HeaderText = "市场重量(kg)";
                colMarketWeight.Width = 75;
                DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colDesignWeight = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
                colDesignWeight.HeaderText = "设计重量(kg)";
                colDesignWeight.Width = 75;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "删除行";
                colMaterialDelete.Width = 50;
                Dgv_Recommend3Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend3Material.Columns.Add(colMaterialName);
                Dgv_Recommend3Material.Columns.Add(colMaterialType);
                Dgv_Recommend3Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend3Material.Columns.Add(colMarketWeight);
                Dgv_Recommend3Material.Columns.Add(colDesignWeight);
                Dgv_Recommend3Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend3Material.Rows.Add();
                object[,] material = new object[,]{ 
                    {"立杆",new string[]{"LG-120&ф48×3.5×1200&7.41&7.05",  "LG-180&ф48×3.5×1800&10.67&10.19&", "LG-240&ф48×3.5×2400&14.02&13.34&", "LG-300&ф48×3.5×3000&17.31&16.48&"}},
                    {"横杆",new string[]{"HG-30&ф48×3.5×300&1.67&1.32", "HG-60&ф48×3.5×600&2.82&2.47", "HG-90&ф48×3.5×900&3.97&3.63", "HG-120&ф48×3.5×1200&5.12&4.78", "HG-150&ф48×3.5×1500&6.28&5.93", "HG-180&ф48×3.5×180&7.43&7.08"}},       
                    {"间横杆",new string[]{"JHG-90&ф48×3.5×900&5.28&4.37 ", "JHG-120	&ф48×3.5×1200	&6.43&5.52","JHG-120+30&ф48×3.5×(1200+300)&7.74	&6.85","JHG-120+60&ф48×3.5×(1200+600)&9.69&8.16"}},
                    {"专用斜杆",new string[]{"XG-0912&ф48×3.5×150&7.11&6.33", "XG-1212&ф48×3.5×170&7.87&7.03","XG-1218&ф48×3.5×2160&9.66&8.66","XG-1518&ф48×3.5×2340&10.34&9.30","XG-1818&ф48×3.5×2550	&11.13&10.04"}},
                    {"专用斜杆",new string[]{"ZXG-0912	&ф48×3.5×1270&0&5.89 ", " ZXG-1212	&ф48×3.5×1500&0&6.76"," ZXG-1218	&ф48×3.5×1920&0&8.73"}},
                    {"十字撑",new string[]{"XZC-0912&ф30×2.5×1390&0&4.72 ", " XZC-1212&ф30×2.5×1560&0&5.31"," XZC-1218	&ф30×2.5×2060&0&7"}},
                    {"窄挑梁",new string[]{"TL-30	&宽度300	&1.68	&1.53 "}},
                    {"宽挑梁",new string[]{" TL-60&宽度600	&9.30	&8.60" }},
                    {"立杆连接销",new string[]{"LLX	&ф12	&0&0.18" }},
                    {"可调底座",new string[]{"KTZ-45	&可调范围≤300	&0&5.82" , " KTZ-60&可调范围≤450&0&7.12" , "KTZ-75	&可调范围≤600	&0&8.5"}},
                    {"可调托座",new string[]{"KTC-45	&可调范围≤300	&0&7.01" , "KTC-60&可调范围≤450&0&8.31" , "KTC-75	&可调范围≤600	&0&9.69" }},
                    {"脚手板",new string[]{"JB-120&1200x270	&0&12.8" , "JB-150&1500x270	&0&15" , "JB-180&1800x270	&	0&17.9" }},
                    {"架梯",new string[]{"JT-255	&2546×530	&0&34.7"}},
                };
                for (int i = 0; i < 13; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)material[i, 0];
                    string[] types = (string[])material[i, 1];
                    for (int j = 0; j < types.Length; j++)
                    {
                        DevComponents.DotNetBar.ButtonItem btnChildItem = new DevComponents.DotNetBar.ButtonItem();
                        string[] info = types[j].ToString().Split('&');
                        btnChildItem.Text = info[0];
                        btnChildItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                        {
                            int RowNum = Dgv_Recommend3Material.CurrentRow.Index;
                            DevComponents.DotNetBar.ButtonItem item = sender1 as DevComponents.DotNetBar.ButtonItem;
                            Dgv_Recommend3Material.Rows[RowNum].Cells[1].Value = item.Parent.Text;
                            Dgv_Recommend3Material.Rows[RowNum].Cells[2].Value = info[0];
                            Dgv_Recommend3Material.Rows[RowNum].Cells[3].Value = info[1];
                            Dgv_Recommend3Material.Rows[RowNum].Cells[4].Value = info[2];
                            Dgv_Recommend3Material.Rows[RowNum].Cells[5].Value = info[3];
                            Dgv_Recommend3Material.Refresh();
                        });
                        btnItem.SubItems.Add(btnChildItem);
                    }
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //获取模板的内容
            string templatename = "碗扣式脚手架";
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
            for (int i = 0; i < Dgv_Recommend3Para.RowCount; i++)
            {
                array1.Add(new object[] { Dgv_Recommend3Para.Rows[i].Cells[0].Value, Dgv_Recommend3Para.Rows[i].Cells[1].Value, Dgv_Recommend3Para.Rows[i].Cells[2].Value, Dgv_Recommend3Para.Rows[i].Cells[3].Value });
            }
            for (int i = 0; i < Dgv_Recommend3Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend3Labor.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend3Material.Rows[i].Cells[1].Value, Dgv_Recommend3Material.Rows[i].Cells[2].Value, Dgv_Recommend3Material.Rows[i].Cells[3].Value, Dgv_Recommend3Material.Rows[i].Cells[4].Value, Dgv_Recommend3Material.Rows[i].Cells[5].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend3Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend3Labor.Rows[i].Cells[1].Value != null)
                {
                    array3.Add(new object[] { i + 1, Dgv_Recommend3Labor.Rows[i].Cells[1].Value, Dgv_Recommend3Labor.Rows[i].Cells[2].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            CreateModuleIntance(templatetemp, array, @class, null);
            this.Close();
        }

        private void stcRecommend3_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            #region
            //“增加行”“删除行”两个按钮的显隐
            if (stcRecommend3.SelectedTabIndex == 0)
            {
                btnAddRow.Visible = false;
                btnDeleteRow.Visible = false;
            }
            if (stcRecommend3.SelectedTabIndex == 1 | stcRecommend3.SelectedTabIndex == 2)
            {
                btnAddRow.Visible = true;
                btnDeleteRow.Visible = true;
            }
            #endregion
        }
    }
}

