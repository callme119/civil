namespace Framework.Interface.Workbench
{
    public partial class UclProperty : System.Windows.Forms.UserControl
    {
        private Framework.Entity.Chapter chapter;
        private string path;

        public UclProperty()
        {
            InitializeComponent();
            this.Height = 550;
            this.Width = 740;
        }

        private void UclProperty_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            if (!element.GetAttribute("RTF").Equals(""))
            {
                RichTextBoxEx.Visible = true;
                WinWordControlEx.Visible = false;
                RichTextBoxEx.SetContent(element.GetAttribute("RTF"));
            }
            else if (!element.GetAttribute("DOC").Equals(""))
            {
                RichTextBoxEx.Visible = false;
                WinWordControlEx.Visible = true;
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
            FrmProperty win = new FrmProperty(chapter);
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmProperty.CreateModuleHandle(CreateModule);
            win.ShowDialog();
        }

        private void CreateModule(object obj, Framework.Entity.Template template)
        {
            System.Reflection.MethodInfo[] methods = obj.GetType().GetMethods();
            if (template.Type == Framework.Entity.Template.RTF)
            {
                RichTextBoxEx.SetContent(Framework.Class.ConvertTool.ConvertStringToRtf(""));
                string content = System.Text.Encoding.Default.GetString(template.Content);
                for (int i = 0, index = 0; i < methods.Length; i++)
                {
                    if (methods[i].Name.StartsWith("get"))
                    {
                        content = content.Replace("@" + index + "@", Framework.Class.ConvertTool.FormatRtf(Framework.Class.ConvertTool.ConvertStringToRtf(methods[i].Invoke(obj, null) + "")));
                        index++;
                    }
                }
                RichTextBoxEx.Visible = true;
                WinWordControlEx.Visible = false;
                RichTextBoxEx.SetContent(content);
            }
            else
            {
                RichTextBoxEx.Visible = false;
                WinWordControlEx.Visible = true;
                path = WinWordControlEx.RandomPath;
                WinWordControlEx.SetWordStream(template.Content, path);
                for (int i = 0, index = 0; i < methods.Length; i++)
                {
                    if (methods[i].Name.StartsWith("get"))
                    {
                        WinWordControlEx.Replace("@" + index + "@", methods[i].Invoke(obj, null) + "");
                        index++;
                    }
                }
            }
        }

        private void BtnRedo_Click(object sender, System.EventArgs e)
        {
            ShowFrmProfile();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            if (RichTextBoxEx.Visible == true)
            {
                element.SetAttribute("RTF", RichTextBoxEx.GetContent());
            }
            else
            {
                element.SetAttribute("DOC", WinWordControlEx.GetWordString(path));
            }
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }
    }
}