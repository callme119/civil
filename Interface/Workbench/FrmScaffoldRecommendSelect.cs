using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Interface.Workbench.FrmScaffoldRecommend;
using Framework.Interface.Workbench.UclScaffold;

namespace Framework.Interface.Workbench
{
    public partial class FrmScaffoldRecommendSelect : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmScaffoldRecommendSelect(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;

            #region //调用UclScaffold文件夹下的ucl控件
            Framework.Interface.Workbench.UclScaffold.Ucl1 ucl1 = new Ucl1();
            Framework.Interface.Workbench.UclScaffold.Ucl2 ucl2 = new Ucl2();
            Framework.Interface.Workbench.UclScaffold.Ucl3 ucl3 = new Ucl3();
            Framework.Interface.Workbench.UclScaffold.Ucl4 ucl4 = new Ucl4();
            Framework.Interface.Workbench.UclScaffold.Ucl5 ucl5 = new Ucl5();
            Framework.Interface.Workbench.UclScaffold.Ucl6 ucl6 = new Ucl6();
            Framework.Interface.Workbench.UclScaffold.Ucl7 ucl7 = new Ucl7();
            tcPanel_Tj1.Controls.Add(ucl1);
            tcPanel_Tj1.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj1.Refresh();
            tcPanel_Tj2.Controls.Add(ucl2);
            tcPanel_Tj2.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj3.Controls.Add(ucl3);
            tcPanel_Tj3.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj4.Controls.Add(ucl4);
            tcPanel_Tj4.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj5.Controls.Add(ucl5);
            tcPanel_Tj5.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj6.Controls.Add(ucl6);
            tcPanel_Tj6.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Tj7.Controls.Add(ucl7);
            tcPanel_Tj7.Controls[0].Dock = DockStyle.Fill;
            #endregion
            tabControl_Tj.SelectedTabIndex = 7;
            Btn_TjBzsgsj.Enabled = false;
        }

        private void DbInput_TjDsgd_ValueChanged(object sender, EventArgs e) //7.8.1推荐选型，脚手架搭设高度
        {
            EnableSelectItem();
        }

        private void Cbx_TjDsyt_SelectedIndexChanged(object sender, EventArgs e)  //7.8.1推荐选型，脚手架搭设用途
        {
            EnableSelectItem();
        }

        private void EnableSelectItem()
        {
            Btn_TjBzsgsj.Enabled = true;
            //tabItem1.Visible = false;
           #region
            if (Cbx_TjDsyt.SelectedIndex == 1)
            {
                Lb7_Tj.Enabled = true;
                Lb1_Tj.Enabled = Lb2_Tj.Enabled = Lb3_Tj.Enabled = Lb4_Tj.Enabled = Lb5_Tj.Enabled = Lb6_Tj.Enabled = false;

                TJtabItem7.Visible = true;
                tabControl_Tj.SelectedTabIndex = 6;
                TJtabItem1.Visible = TJtabItem2.Visible = TJtabItem3.Visible = TJtabItem4.Visible = TJtabItem5.Visible = TJtabItem6.Visible = false;
            }
            else if (Cbx_TjDsyt.SelectedIndex == 0)
            {
                if (DbInput_TjDsgd.Value <= 20)
                {
                    Lb1_Tj.Enabled = Lb3_Tj.Enabled = Lb4_Tj.Enabled = Lb5_Tj.Enabled = true;
                    Lb2_Tj.Enabled = Lb6_Tj.Enabled = Lb7_Tj.Enabled = false;
                    TJtabItem1.Visible = TJtabItem3.Visible = TJtabItem4.Visible = TJtabItem5.Visible = true;
                    TJtabItem2.Visible = TJtabItem6.Visible = TJtabItem7.Visible = false;
                }
                else if (20 < DbInput_TjDsgd.Value & DbInput_TjDsgd.Value <= 24)
                {
                    Lb1_Tj.Enabled = Lb4_Tj.Enabled = Lb5_Tj.Enabled = true;
                    Lb2_Tj.Enabled = Lb3_Tj.Enabled = Lb6_Tj.Enabled = Lb7_Tj.Enabled = false;
                    TJtabItem1.Visible = TJtabItem4.Visible = TJtabItem5.Visible = true;
                    TJtabItem2.Visible = TJtabItem3.Visible = TJtabItem6.Visible = TJtabItem7.Visible = false;
                }
                else if (24 < DbInput_TjDsgd.Value & DbInput_TjDsgd.Value <= 55)
                {
                    Lb1_Tj.Enabled = Lb2_Tj.Enabled = Lb5_Tj.Enabled = true;
                    Lb3_Tj.Enabled = Lb4_Tj.Enabled = Lb6_Tj.Enabled = Lb7_Tj.Enabled = false;
                    TJtabItem1.Visible = TJtabItem2.Visible = TJtabItem5.Visible = true;
                    TJtabItem3.Visible = TJtabItem4.Visible = TJtabItem6.Visible = TJtabItem7.Visible = false;
                }
                else if (55 < DbInput_TjDsgd.Value & DbInput_TjDsgd.Value <= 100)
                {
                    Lb2_Tj.Enabled = true;
                    Lb1_Tj.Enabled = Lb3_Tj.Enabled = Lb4_Tj.Enabled = Lb5_Tj.Enabled = Lb6_Tj.Enabled = Lb7_Tj.Enabled = false;
                    TJtabItem2.Visible = true;
                    TJtabItem1.Visible = TJtabItem3.Visible = TJtabItem4.Visible = TJtabItem5.Visible = TJtabItem6.Visible = TJtabItem7.Visible = false;
                }
                else if (DbInput_TjDsgd.Value > 100)
                {
                    Lb1_Tj.Enabled = Lb3_Tj.Enabled = Lb4_Tj.Enabled = Lb5_Tj.Enabled = Lb7_Tj.Enabled = false;
                    Lb2_Tj.Enabled = Lb6_Tj.Enabled = true;
                    TJtabItem1.Visible = TJtabItem3.Visible = TJtabItem4.Visible = TJtabItem5.Visible = TJtabItem7.Visible = false;
                    TJtabItem2.Visible = TJtabItem6.Visible = true;
                }
            }
            #endregion
        }

        private void Btn_TjBzsgsj_Click(object sender, EventArgs e)
        {
            ShowFrmProfile();
        }

        private void ShowFrmProfile()
        {
            if (tabControl_Tj.SelectedTabIndex == 0) //扣件式钢管脚手架（落地）
            {
                FrmRecommend1 win = new FrmRecommend1(chaptertemp,@class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend1.CreateModuleHandle(SubmitCreateModule); //3.Delegate数据变量指向实例方法
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 1) //扣件式钢管脚手架（落地+悬挑）
            {
                FrmRecommend2 win = new FrmRecommend2(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend2.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 2) //碗扣式脚手架
            {
                FrmRecommend3 win = new FrmRecommend3(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend3.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 3) //承插型盘扣式钢管脚手架
            {
                FrmRecommend4 win = new FrmRecommend4(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend4.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 4) //工门式钢管脚手架
            {
                FrmRecommend5 win = new FrmRecommend5(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend5.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 5) //液压升降整体脚手架
            {
                FrmRecommend6 win = new FrmRecommend6(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend6.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Tj.SelectedTabIndex == 6) //吊脚手架
            {
                FrmRecommend7 win = new FrmRecommend7(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend7.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
        }

        private void SubmitCreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data) //2.定义Delegate将引用的静态方法或引用类实例及该类的实例方法。这是中间传递参数所用的一个方法,其类似于“UclCustom.cs”中的"private void CreateModule()"
        {//此方法将委托给FrmScaffoldRecommend下的七个窗体中的
            CreateModuleIntance(template, array, @class, data);
            this.Close();
        }

      
    }
}

