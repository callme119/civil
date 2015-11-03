using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmConcreteConstructionMachinery : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Chapter chaptertemp;
        private System.Collections.ArrayList templateList;

        public FrmConcreteConstructionMachinery(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "������ʩ����еѡ��";
            foreach (Framework.Entity.Template template in templateList)
            {
                if (itemtext == template.Title)
                {
                    item = template;
                    break;
                }
            }
            CreateModuleIntance(item, null, @class, obj);
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FrmAllPlan win = new FrmAllPlan(chaptertemp, @class);
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmAllPlan.CreateModuleHandle(SubmitCreateModule); //3.Delegate���ݱ���ָ��ʵ������
            win.ShowDialog();
        }
        private void SubmitCreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data) //2.����Delegate�����õľ�̬������������ʵ���������ʵ�������������м䴫�ݲ������õ�һ������,�������ڡ�UclCustom.cs���е�"private void CreateModule()"
        {//�˷�����ί�и�FrmScaffoldRecommend�µ��߸������е�
            CreateModuleIntance(template, array, @class, data);
            this.Close();
        }
    

    }
}