namespace Framework.Interface.Content
{
    public partial class FrmTemplate : Framework.Interface.Common.FrmBase
    {
        public delegate void RefreshHandle();
        public RefreshHandle RefreshIntance;

        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private Framework.Entity.Template template;
        private string path;
        private bool flag;

        public FrmTemplate(bool _flag, Framework.Entity.Template _template)
        {
            InitializeComponent();
            flag = _flag;
            template = _template;
        }

        public void InitForm()
        {
            RichTextBoxEx.Visible = true;
            WinWordControlEx.Visible = false;
            WinExcelControlEx.Visible = false;
            if (flag)
            {
                TbxTitle.Text = template.Title;
                TbxKey.Text = template.Key;
                CbxState.SelectedIndex = template.State;
                if (template.Type == Framework.Entity.Template.RTF)
                {
                    RichTextBoxEx.Visible = true;
                    WinWordControlEx.Visible = false;
                    WinExcelControlEx.Visible = false;
                    RichTextBoxEx.SetContent(System.Text.Encoding.Default.GetString(template.Content));
                }
                else if (template.Type == Framework.Entity.Template.DOC)
                {
                    RichTextBoxEx.Visible = false;
                    WinWordControlEx.Visible = true;
                    WinExcelControlEx.Visible = false;
                    path = WinWordControlEx.RandomPath;
                    WinWordControlEx.SetWordStream(template.Content, path);
                }
                else
                {
                    RichTextBoxEx.Visible = false;
                    WinWordControlEx.Visible = false;
                    WinExcelControlEx.Visible = true;
                    path = WinExcelControlEx.RandomPath;
                    WinExcelControlEx.ShowExcel(template.Content, path);
                }
            }
        }

        private void FrmTemplate_Load(object sender, System.EventArgs e)
        {
            CbxState.Items.Add("启用");
            CbxState.Items.Add("禁用");
            CbxState.SelectedIndex = 0;
        }

        private void BtnImportWord_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.FileName = "Word文档";
            openFileDialog.Filter = "Word文档(*.doc)|*.doc";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RichTextBoxEx.Visible = false;
                WinWordControlEx.Visible = true;
                WinExcelControlEx.Visible = false;
                path = openFileDialog.FileName;
                WinWordControlEx.LoadWord(path);
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            template.Title = TbxTitle.Text;
            template.Key = TbxKey.Text;
            if (RichTextBoxEx.Visible)
            {
                template.Content = System.Text.Encoding.UTF8.GetBytes(RichTextBoxEx.GetContent());
                template.Type = Framework.Entity.Template.RTF;
            }
            else if (WinWordControlEx.Visible)
            {
                template.Content = WinWordControlEx.GetWordStream(path);
                template.Type = Framework.Entity.Template.DOC;
            }
            else
            {
                template.Content = WinExcelControlEx.GetExcelStream(path);
                template.Type = Framework.Entity.Template.XLS;
            }
            template.State = CbxState.SelectedIndex;
            if (flag)
            {
                utilService.Update(template);
            }
            else
            {
                utilService.Insert(template);
            }
            RefreshIntance();
            this.Close();
        }

        private void BtnImportExcel_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.FileName = "Excel文档";
            openFileDialog.Filter = "Excel文档(*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RichTextBoxEx.Visible = false;
                WinWordControlEx.Visible = false;
                WinExcelControlEx.Visible = true;
                path = openFileDialog.FileName;
                WinExcelControlEx.ShowExcel(path);
            }
        }
    }
}