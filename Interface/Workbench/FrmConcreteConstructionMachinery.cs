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
            string itemtext = "混凝土施工机械选择";
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
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmAllPlan.CreateModuleHandle(SubmitCreateModule); //3.Delegate数据变量指向实例方法
            win.ShowDialog();
        }
        private void SubmitCreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data) //2.定义Delegate将引用的静态方法或引用类实例及该类的实例方法。这是中间传递参数所用的一个方法,其类似于“UclCustom.cs”中的"private void CreateModule()"
        {//此方法将委托给FrmScaffoldRecommend下的七个窗体中的
            CreateModuleIntance(template, array, @class, data);
            this.Close();
        }
    

    }
}