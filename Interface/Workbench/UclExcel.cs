namespace Framework.Interface.Workbench
{
    public partial class UclExcel : System.Windows.Forms.UserControl
    {
        private Framework.Entity.Chapter chapter;
        private string path;

        public UclExcel()
        {
            InitializeComponent();
            this.Height = 550;
            this.Width = 740;
        }

        private void UclExcel_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            if (!element.GetAttribute("DOC").Equals(""))
            {
                path = WinWordControlEx.RandomPath;
                WinWordControlEx.SetWordString(element.GetAttribute("DOC"), path);
            }
            else
            {
                ShowFrmProfile();
            }
        }

        private void ShowFrmProfile()
        {
            FrmExcel win = new FrmExcel(chapter);
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmExcel.CreateModuleHandle(CreateModule);
            win.ShowDialog();
        }

        private void CreateModule(string path)
        {
            this.WinWordControlEx.LoadWord(path);
            this.path = path;
        }

        private void BtnRedo_Click(object sender, System.EventArgs e)
        {
            ShowFrmProfile();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            element.SetAttribute("DOC", WinWordControlEx.GetWordString(path));
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
    }
}