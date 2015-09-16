namespace Framework.Interface.Workbench
{
    public partial class UclEditor : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private Framework.Entity.Chapter chapter;
        private string path;

        public UclEditor()
        {
            InitializeComponent();
        }

        private void UclEditor_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            string doc = element.GetAttribute("DOC");
            if (!doc.Equals(""))
            {
                RichTextBoxEx.Visible = false;
                WinWordControlEx.Visible = true;
                path = WinWordControlEx.RandomPath;
                WinWordControlEx.SetWordString(element.GetAttribute("DOC"), path);
            }
            else
            {
                RichTextBoxEx.Visible = true;
                WinWordControlEx.Visible = false;
                RichTextBoxEx.SetContent(element.GetAttribute("RTF"));
            }
            CreateTemplateList();
        }

        private void CreateTemplateList()
        {
            DevComponents.AdvTree.Node rootNode = new DevComponents.AdvTree.Node(chapter.Title);
            rootNode.Expanded = true;
            AdvTree.Nodes.Add(rootNode);
            System.Collections.ArrayList templateList = contentService.GetTemplateByChapter(chapter.Id);
            foreach (Framework.Entity.Template template in templateList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(template.Title);
                node.Tag = template;
                
                node.Expanded = true;
                node.NodeDoubleClick += new System.EventHandler(delegate(object o, System.EventArgs a)
                {
                    foreach (Framework.Entity.Template template1 in templateList)//这层foreeach用于双击节点时，重新的到所有的节点
                    {
                        if (template1.Title == node.Text)//如果
                        {
                            DevComponents.AdvTree.Node nd = (DevComponents.AdvTree.Node)o;
                            Framework.Entity.Template tmp = (Framework.Entity.Template)nd.Tag;
                            if (template1.Type == Framework.Entity.Template.RTF)
                            {
                                RichTextBoxEx.Visible = true;
                                WinWordControlEx.Visible = false;
                                RichTextBoxEx.SetContent(System.Text.Encoding.Default.GetString(template1.Content));
                            }
                            else
                            {
                                RichTextBoxEx.Visible = false;
                                WinWordControlEx.Visible = true;
                                path = WinWordControlEx.RandomPath;
                                WinWordControlEx.SetWordStream(template1.Content, path);
                            }
                            break;
                        }
                    }

                });
                rootNode.Nodes.Add(node);
            }
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