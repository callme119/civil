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

            #region //����UclScaffold�ļ����µ�ucl�ؼ�
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
            if (tabControl_Self.SelectedTabIndex == 0) //�ۼ�ʽ�ֹܽ��ּܣ���أ�
            {
                FrmRecommend1 win = new FrmRecommend1(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend1.CreateModuleHandle(SubmitCreateModule); //3.Delegate���ݱ���ָ��ʵ������
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 1) //�ۼ�ʽ�ֹܽ��ּܣ����+������
            {
                FrmRecommend2 win = new FrmRecommend2(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend2.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 2) //���ʽ���ּ�
            {
                FrmRecommend3 win = new FrmRecommend3(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend3.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 3) //�в����̿�ʽ�ֹܽ��ּ�
            {
                FrmRecommend4 win = new FrmRecommend4(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend4.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 4) //����ʽ�ֹܽ��ּ�
            {
                FrmRecommend5 win = new FrmRecommend5(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend5.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 5) //Һѹ����������ּ�
            {
                FrmRecommend6 win = new FrmRecommend6(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend6.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
            if (tabControl_Self.SelectedTabIndex == 6) //�����ּ�
            {
                FrmRecommend7 win = new FrmRecommend7(chaptertemp, @class);
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommend.FrmRecommend7.CreateModuleHandle(SubmitCreateModule);
                win.ShowDialog();
            }
        }

        private void SubmitCreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data) //2.����Delegate�����õľ�̬������������ʵ���������ʵ�������������м䴫�ݲ������õ�һ������,�������ڡ�UclCustom.cs���е�"private void CreateModule()"
        {//�˷�����ί�и�FrmScaffoldRecommend�µ��߸������е�
            CreateModuleIntance(template, array, @class, data);
            this.Close();
        }
    }
}

