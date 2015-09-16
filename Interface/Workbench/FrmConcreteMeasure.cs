using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmConcreteMeasure : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Chapter chaptertemp;
        private System.Collections.ArrayList templateList;

        public FrmConcreteMeasure(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            chaptertemp = chapter;

        }

        private void Grp_Item1_Enter(object sender, System.EventArgs e)
        {

        }
        private void FrmConcreteMeasure_Load(object sender, System.EventArgs e)
        {
            comboBoxEx1.Items.Add("C15"); comboBoxEx1.Items.Add("C20"); comboBoxEx1.Items.Add("C25"); comboBoxEx1.Items.Add("C30");
            comboBoxEx1.Items.Add("C35"); comboBoxEx1.Items.Add("C40"); comboBoxEx1.Items.Add("C45"); comboBoxEx1.Items.Add("C50");
            comboBoxEx1.Items.Add("C55"); comboBoxEx1.Items.Add("C60"); comboBoxEx1.Items.Add("C65"); comboBoxEx1.Items.Add("C70");
            comboBoxEx1.Items.Add("C75"); comboBoxEx1.Items.Add("C80");
            comboBoxEx2.Items.Add("C15"); comboBoxEx2.Items.Add("C20"); comboBoxEx2.Items.Add("C25"); comboBoxEx2.Items.Add("C30");
            comboBoxEx2.Items.Add("C35"); comboBoxEx2.Items.Add("C40"); comboBoxEx2.Items.Add("C45"); comboBoxEx2.Items.Add("C50");
            comboBoxEx2.Items.Add("C55"); comboBoxEx2.Items.Add("C60"); comboBoxEx2.Items.Add("C65"); comboBoxEx2.Items.Add("C70");
            comboBoxEx2.Items.Add("C75"); comboBoxEx2.Items.Add("C80");
            comboBoxEx3.Items.Add("C15"); comboBoxEx3.Items.Add("C20"); comboBoxEx3.Items.Add("C25"); comboBoxEx3.Items.Add("C30");
            comboBoxEx3.Items.Add("C35"); comboBoxEx3.Items.Add("C40"); comboBoxEx3.Items.Add("C45"); comboBoxEx3.Items.Add("C50");
            comboBoxEx3.Items.Add("C55"); comboBoxEx3.Items.Add("C60"); comboBoxEx3.Items.Add("C65"); comboBoxEx3.Items.Add("C70");
            comboBoxEx3.Items.Add("C75"); comboBoxEx3.Items.Add("C80"); 
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            
           
                itemtext = "混凝土强度测定";

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
    }
}