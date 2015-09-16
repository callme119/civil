namespace Framework.Interface.Workbench
{
    public partial class FrmProperty : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(object obj, Framework.Entity.Template template);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        public FrmProperty(Framework.Entity.Chapter chapter)
        {
            InitializeComponent();
            Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
            System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));
            PropertyGrid.SelectedObject = ass.CreateInstance(model.Class);
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                Framework.Class.ComboItem item = new Framework.Class.ComboItem();
                item.Text = template.Title;
                item.Value = template;
                CbxType.Items.Add(item);
            }
            if (model.Name == "模板工程专项概况")
            {
                CbxType.SelectedIndex = 2;
                CbxType.Visible = false;
                LbType.Visible = false;
            }
            else {
                CbxType.Items.RemoveAt(2);
                CbxType.SelectedIndex = 0;

            }
            
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance(PropertyGrid.SelectedObject, (Framework.Entity.Template)item.Value);
            this.Close();
        }

    }
}