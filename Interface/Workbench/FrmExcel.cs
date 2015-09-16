namespace Framework.Interface.Workbench
{
    public partial class FrmExcel : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(string path);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();

        public FrmExcel(Framework.Entity.Chapter chapter)
        {
            InitializeComponent();
            System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            Framework.Entity.Template template = (Framework.Entity.Template)templateList[0];
            WinExcelControlEx.ShowExcel(template.Content, WinExcelControlEx.RandomPath);
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            CreateModuleIntance(WinExcelControlEx.CopyToWord());
            WinExcelControlEx.CloseExcel();
            this.Close();
        }
    }
}