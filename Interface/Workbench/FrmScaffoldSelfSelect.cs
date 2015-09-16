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
    public partial class FrmScaffoldSelfSelect : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;

        public FrmScaffoldSelfSelect(Framework.Entity.Chapter chapter, object type)
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
            tcPanel_Self1.Controls.Add(ucl1);
            tcPanel_Self1.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self1.Refresh();
            tcPanel_Self2.Controls.Add(ucl2);
            tcPanel_Self2.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self3.Controls.Add(ucl3);
            tcPanel_Self3.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self4.Controls.Add(ucl4);
            tcPanel_Self4.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self5.Controls.Add(ucl5);
            tcPanel_Self5.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self6.Controls.Add(ucl6);
            tcPanel_Self6.Controls[0].Dock = DockStyle.Fill;
            tcPanel_Self7.Controls.Add(ucl7);
            tcPanel_Self7.Controls[0].Dock = DockStyle.Fill;
            #endregion
            tabControl_Self.SelectedTabIndex = 7;
            //Btn_SelfBzsgsj.Enabled = false;
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked)
            {
                SELFtabItem1.Visible = true;
                tabControl_Self.SelectedTabIndex = 0;
            }
            if (checkBoxX2.Checked)
            {
                SELFtabItem2.Visible = true;
                tabControl_Self.SelectedTabIndex = 1;
            }
            if (checkBoxX3.Checked)
            {
                SELFtabItem3.Visible = true;
                tabControl_Self.SelectedTabIndex = 2;
            }
            if (checkBoxX4.Checked)
            {
                SELFtabItem4.Visible = true;
                tabControl_Self.SelectedTabIndex = 3;
            }
            if (checkBoxX5.Checked)
            {
                SELFtabItem5.Visible = true;
                tabControl_Self.SelectedTabIndex = 4;
            }
            if (checkBoxX6.Checked)
            {
                SELFtabItem6.Visible = true;
                tabControl_Self.SelectedTabIndex = 5;
            }
            if (checkBoxX7.Checked)
            {
                SELFtabItem7.Visible = true;
                tabControl_Self.SelectedTabIndex = 6;
            }
            tabItem8.Visible = false ;
            Btn_SelfBzsgsj.Enabled = true ;
        }

        private void Btn_SelfBzsgsj_Click(object sender, EventArgs e)
        {
            ShowFrmProfile();
        }
        private void ShowFrmProfile()
        {
            if (tabControl_Self.SelectedTabIndex == 0) //扣件式钢管脚手架（落地）
            {
                FrmRecommend1 win = new FrmRecommend1(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend1.CreateModuleHandle(SubmitCreateModule); //3.Delegate数据变量指向实例方法
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 1) //扣件式钢管脚手架（落地+悬挑）
            {
                FrmRecommend2 win = new FrmRecommend2(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend2.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 2) //碗扣式脚手架
            {
                FrmRecommend3 win = new FrmRecommend3(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend3.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 3) //承插型盘扣式钢管脚手架
            {
                FrmRecommend4 win = new FrmRecommend4(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend4.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 4) //工门式钢管脚手架
            {
                FrmRecommend5 win = new FrmRecommend5(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend5.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 5) //液压升降整体脚手架
            {
                FrmRecommend6 win = new FrmRecommend6(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend6.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 6) //吊脚手架
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

