using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    public partial class FrmRecommend4 : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmRecommend4(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (stcRecommend4.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend4Material.Rows)
                {
                    if (row.Cells[6].Value != null && Convert.ToBoolean(row.Cells[6].Value) == true)
                    {
                        this.Dgv_Recommend4Material.Rows.Remove(row);
                    }
                }
            }
            if (stcRecommend4.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.Dgv_Recommend4Labor.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_Recommend4Labor.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (stcRecommend4.SelectedTabIndex)
            {
                case 1: Dgv_Recommend4Material.Rows.Add(); break;
                case 2: Dgv_Recommend4Labor.Rows.Add(); break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //获取模板的内容
            string templatename = "承插型盘扣式钢管脚手架";
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
            for (int i = 0; i < Dgv_Recommend4Para.RowCount; i++)
            {
                array1.Add(new object[] { Dgv_Recommend4Para.Rows[i].Cells[0].Value, Dgv_Recommend4Para.Rows[i].Cells[1].Value, Dgv_Recommend4Para.Rows[i].Cells[2].Value, Dgv_Recommend4Para.Rows[i].Cells[3].Value });
            }
            for (int i = 0; i < Dgv_Recommend4Material.Rows.Count; i++)
            {
                if (Dgv_Recommend4Material.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_Recommend4Material.Rows[i].Cells[1].Value, Dgv_Recommend4Material.Rows[i].Cells[2].Value, Dgv_Recommend4Material.Rows[i].Cells[3].Value, Dgv_Recommend4Material.Rows[i].Cells[4].Value, Dgv_Recommend4Material.Rows[i].Cells[5].Value });
                }
            }
            for (int i = 0; i < Dgv_Recommend4Labor.Rows.Count; i++)
            {
                if (Dgv_Recommend4Labor.Rows[i].Cells[1].Value != null)
                {
                    array3.Add(new object[] { i + 1, Dgv_Recommend4Labor.Rows[i].Cells[1].Value, Dgv_Recommend4Labor.Rows[i].Cells[2].Value });
                }
            }
            array.Add(array1);
            array.Add(array2);
            array.Add(array3);
            CreateModuleIntance(templatetemp, array, @class, null);
            this.Close();
        }

        private void FrmRecommend4_Load(object sender, EventArgs e)
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

            Dgv_Recommend4Para.Columns.Add(colParaType1);
            Dgv_Recommend4Para.Columns.Add(colParaResult1);
            Dgv_Recommend4Para.Columns.Add(colParaType2);
            Dgv_Recommend4Para.Columns.Add(colParaResult2);
            Dgv_Recommend4Para.Rows.Add(6);
            string[] strParaType1 = new string[] { "脚手架搭设高度H(m)", "立杆纵向间距la(m)", "立杆步距h(m)", "顶部防护栏杆高h1(m)", "内立杆离建筑物距离a(mm)", "连墙件布置方式" };
            string[] strParaResult1 = new string[] { "X", "X", "X", "X", "X", "两步两跨/两步三跨" };
            string[] strParaType2 = new string[] { "脚手架沿纵向搭设长度L(m)", "立杆横向间距lb(m)", "脚手架总步数n", "纵横向扫地杆离地距离h2(mm)", "脚手板铺设方式", "" };
            string[] strParaResult2 = new string[] { "X", "X", "X", "X", "X步1设", " " };

            for (int i = 0; i < strParaType1.Length; i++)
            {
                Dgv_Recommend4Para.Rows[i].Cells[0].Value = strParaType1[i];
                Dgv_Recommend4Para.Rows[i].Cells[1].Value = strParaResult1[i];
                Dgv_Recommend4Para.Rows[i].Cells[2].Value = strParaType2[i];
                Dgv_Recommend4Para.Rows[i].Cells[3].Value = strParaResult2[i];
            }
            #endregion

            #region //4承插型盘扣式钢管脚手架—劳动力安排表
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
                Dgv_Recommend4Labor.Columns.Add(colWorktypeChoice);
                Dgv_Recommend4Labor.Columns.Add(colWorktype);
                Dgv_Recommend4Labor.Columns.Add(colWorkNumber);
                Dgv_Recommend4Labor.Columns.Add(colWorkDelete);
                Dgv_Recommend4Labor.Rows.Add();

                object[] strWork = new object[] { "技术管理", "安全监督", "质量检查", "测量放线", "架子工" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_Recommend4Labor.CurrentRow.Index;
                        Dgv_Recommend4Labor.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_Recommend4Labor.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region//4承插型盘扣式钢管脚手架—材料安排表
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
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialStandard = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialStandard.HeaderText = "规格(mm)";
                colMaterialStandard.Width = 110;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialQuality = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterialQuality.HeaderText = "材质 ";
                colMaterialQuality.Width = 75;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colDesignWeight = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colDesignWeight.HeaderText = "理论重量(kg)";
                colDesignWeight.Width = 75;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "删除行";
                colMaterialDelete.Width = 50;
                Dgv_Recommend4Material.Columns.Add(colMaterialChoice);
                Dgv_Recommend4Material.Columns.Add(colMaterialName);
                Dgv_Recommend4Material.Columns.Add(colMaterialType);
                Dgv_Recommend4Material.Columns.Add(colMaterialStandard);
                Dgv_Recommend4Material.Columns.Add(colMaterialQuality);
                Dgv_Recommend4Material.Columns.Add(colDesignWeight);
                Dgv_Recommend4Material.Columns.Add(colMaterialDelete);
                Dgv_Recommend4Material.Rows.Add();
                object[,] material = new object[,]{ 
                    {"立杆",new string[]{" A-LG-500	&	Φ60×3.2×500	&	Q345A	&	3.75 "," A-LG-1000	&	Φ60×3.2×1000	&	Q345A	&	6.65 "," A-LG-1500	&	Φ60×3.2×1500	&	Q345A	&	9.60 "," A-LG-2000	&	Φ60×3.2×2000	&	Q345A	&	12.50 "," A-LG-2500	&	Φ60×3.2×2500	&	Q345A	&	15.50 "," A-LG-3000	&	Φ60×3.2×3000	&	Q345A	&	18.40 "," B-LG-500	&	Φ48×3.2×500	&	Q345A	&	2.95 "," B-LG-1000	&	Φ48×3.2×1000	&	Q345A	&	5.30 "," B-LG-1500	&	Φ48×3.2×1500	&	Q345A	&	7.64 "," B-LG-2000	&	Φ48×3.2×2000	&	Q345A	&	9.90 "," B-LG-2500	&	Φ48×3.2×2500	&	Q345A	&	12.30 "," B-LG-3000	&	Φ48×3.2×3000	&	Q345A	&	14.65 "}},
                    {"水平杆",new string[]{" A-SG-300	&	Φ48×2.5×240	&	Q235B	&	1.40 "," A-SG-600	&	Φ48×2.5×540	&	Q235B	&	2.30 "," A-SG-900	&	Φ48×2.5×840	&	Q235B	&	3.20 "," A-SG-1200	&	Φ48×2.5×1140	&	Q235B	&	4.10 "," A-SG-1500	&	Φ48×2.5×1440	&	Q235B	&	5.00 "," A-SG-1800	&	Φ48×2.5×1740	&	Q235B	&	5.90 "," A-SG-2000	&	Φ48×2.5×1940	&	Q235B	&	6.50 "," B-SG-300	&	Φ42×2.5×240	&	Q235B	&	1.30 "," B-SG-600	&	Φ42×2.5×540	&	Q235B	&	2.00 "," B-SG-900	&	Φ42×2.5×840	&	Q235B	&	2.80 "," B-SG-1200	&	Φ42×2.5×1140	&	Q235B	&	3.60 "," B-SG-1500	&	Φ42×2.5×1440	&	Q235B	&	4.30 "," B-SG-1800	&	Φ42×2.5×1740	&	Q235B	&	5.10 "," B-SG-2000	&	Φ42×2.5×1940	&	Q235B	&	5.60 "}},       
                    {"竖向斜杆",new string[]{" A-XG-300×1000	&	Φ48×2.5×1008	&	Q195	&	4.10 "," A-XG-300×1500	&	Φ48×2.5×1506	&	Q195	&	5.50 "," A-XG-600×1000	&	Φ48×2.5×1089	&	Q195	&	4.30 "," A-XG-600×1500	&	Φ48×2.5×1560	&	Q195	&	5.60 "," A-XG-900×1000	&	Φ48×2.5×1238	&	Q195	&	4.70 "," A-XG-900×1500	&	Φ48×2.5×1668	&	Q195	&	5.90 "," A-XG-900×2000	&	Φ48×2.5×2129	&	Q195	&	7.20 "," A-XG-1200×1000	&	Φ48×2.5×1436	&	Q195	&	5.30 "," A-XG-1200×1500	&	Φ48×2.5×1820	&	Q195	&	6.40 "," A-XG-1200×2000	&	Φ48×2.5×2250	&	Q195	&	7.55 "," A-XG-1500×1000	&	Φ48×2.5×1664	&	Q195	&	5.90 "," A-XG-1500×1500	&	Φ48×2.5×2005	&	Q195	&	6.90 "," A-XG-1500×2000	&	Φ48×2.5×2402	&	Q195	&	8.00 "," A-XG-1800×1000	&	Φ48×2.5×1912	&	Q195	&	6.60 "," A-XG-1800×1500	&	Φ48×2.5×2215	&	Q195	&	7.40 "," A-XG-1800×2000	&	Φ48×2.5×2580	&	Q195	&	8.50 "," A-XG-2000×1000	&	Φ48×2.5×2085	&	Q195	&	7.00 "," A-XG-2000×1500	&	Φ48×2.5×2411	&	Q195	&	7.90 "," A-XG-2000×2000	&	Φ48×2.5×2756	&	Q195	&	8.80 "," B-XG-300×1000	&	Φ33×2.3×1057	&	Q195	&	2.95 "," B-XG-300×1500	&	Φ33×2.3×1555	&	Q195	&	3.82 "," B-XG-600×1000	&	Φ33×2.3×1131	&	Q195	&	3.10 "," B-XG-600×1500	&	Φ33×2.3×1606	&	Q195	&	3.92 "," B-XG-900×1000	&	Φ33×2.3×1277	&	Q195	&	3.36 "," B-XG-900×1500	&	Φ33×2.3×1710	&	Q195	&	4.10 "," B-XG-900×2000	&	Φ33×2.3×2173	&	Q195	&	4.90 "," B-XG-1200×1000	&	Φ33×2.3×1472	&	Q195	&	3.70 "," B-XG-1200×1500	&	Φ33×2.3×1859	&	Q195	&	4.40 "," B-XG-1200×2000	&	Φ33×2.3×2291	&	Q195	&	5.10 "," B-XG-1500×1000	&	Φ33×2.3×1699	&	Q195	&	4.09 "," B-XG-1500×1500	&	Φ33×2.3×2042	&	Q195	&	4.70 "," B-XG-1500×2000	&	Φ33×2.3×2402	&	Q195	&	5.40 "," B-XG-1800×1000	&	Φ33×2.3×1946	&	Q195	&	4.53 "," B-XG-1800×1500	&	Φ33×2.3×2251	&	Q195	&	5.05 "," B-XG-1800×2000	&	Φ33×2.3×2618	&	Q195	&	5.70 "," B-XG-2000×1000	&	Φ33×2.3×2119	&	Q195	&	4.82 "," B-XG-2000×1500	&	Φ33×2.3×2411	&	Q195	&	5.35 "," B-XG-2000×2000	&	Φ33×2.3×2756	&	Q195	&	5.95 "}},
                    {"水平斜杆",new string[]{" A-SXG-900×900	&	Φ48×2.5×1273	&	Q235B	&	4.30 "," A-SXG-900×1200	&	Φ48×2.5×1500	&	Q235B	&	5.00 "," A-SXG-900×1500	&	Φ48×2.5×1749	&	Q235B	&	5.70 "," A-SXG-1200×1200	&	Φ48×2.5×1697	&	Q235B	&	5.55 "," A-SXG-1200×1500	&	Φ48×2.5×1921	&	Q235B	&	6.20 "," A-SXG-1500×1500	&	Φ48×2.5×2121	&	Q235B	&	6.80 "," B-SXG-900×900	&	Φ42×2.5×1272	&	Q235B	&	3.80 "," B-SXG-900×1200	&	Φ42×2.5×1500	&	Q235B	&	4.30 "," B-SXG-900×1500	&	Φ42×2.5×1749	&	Q235B	&	5.00 "," B-SXG-1200×1200	&	Φ42×2.5×1697	&	Q235B	&	4.90 "," B-SXG-1200×1500	&	Φ42×2.5×1921	&	Q235B	&	5.50 "," B-SXG-1500×1500	&	Φ42×2.5×2121	&	Q235B	&	6.00 "}}
                };
                for (int i = 0; i < 4; i++)
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
                            int RowNum = Dgv_Recommend4Material.CurrentRow.Index;
                            DevComponents.DotNetBar.ButtonItem item = sender1 as DevComponents.DotNetBar.ButtonItem;
                            Dgv_Recommend4Material.Rows[RowNum].Cells[1].Value = item.Parent.Text;
                            Dgv_Recommend4Material.Rows[RowNum].Cells[2].Value = info[0];
                            Dgv_Recommend4Material.Rows[RowNum].Cells[3].Value = info[1];
                            Dgv_Recommend4Material.Rows[RowNum].Cells[4].Value = info[2];
                            Dgv_Recommend4Material.Rows[RowNum].Cells[5].Value = info[3];
                            Dgv_Recommend4Material.Refresh();
                        });
                        btnItem.SubItems.Add(btnChildItem);
                    }
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void stcRecommend4_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            #region
            //“增加行”“删除行”两个按钮的显隐
            if (stcRecommend4.SelectedTabIndex == 0)
            {
                btnAddRow.Visible = false;
                btnDeleteRow.Visible = false;
            }
            if (stcRecommend4.SelectedTabIndex == 1 | stcRecommend4.SelectedTabIndex == 2)
            {
                btnAddRow.Visible = true;
                btnDeleteRow.Visible = true;
            }
            #endregion
        }

    }
}

