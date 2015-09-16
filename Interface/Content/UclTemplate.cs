namespace Framework.Interface.Content
{
    public partial class UclTemplate : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        public UclTemplate()
        {
            InitializeComponent();
        }

        private void UclTemplate_Load(object sender, System.EventArgs e)
        {
            DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node("目录结构");
            node.Expanded = true;
            TreeChapter.Nodes.Add(node);
            CreateChapterTree(0, node);
        }

        private void CreateChapterTree(int pid, DevComponents.AdvTree.Node rootNode)
        {
            System.Collections.ArrayList nodeList = contentService.GetChapterByPid(pid,Framework.Entity.Project.Type);
            foreach (Framework.Entity.Chapter child in nodeList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(child.Title);
                node.Tag = child;
                node.Expanded = false;
                node.NodeClick += new System.EventHandler(delegate(object o, System.EventArgs a)
                {
                    RefreshList();
                });
                rootNode.Nodes.Add(node);
                CreateChapterTree(child.Id, node);
            }
        }

        private void RefreshList()
        {
            TreeTemplate.Nodes.Clear();
            Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)TreeChapter.SelectedNode.Tag;
            System.Collections.ArrayList templateList = contentService.GetTemplateByChapter(chapter.Id);
            int i = 1;
            foreach (Framework.Entity.Template template in templateList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(System.Convert.ToString(i));
                node.Cells.Add(new DevComponents.AdvTree.Cell(template.Title));
                node.Cells.Add(new DevComponents.AdvTree.Cell(template.Key));
                node.Cells.Add(new DevComponents.AdvTree.Cell(GetState(template.State)));
                node.Tag = template;
                node.NodeDoubleClick += new System.EventHandler(MnModify_Click);
                TreeTemplate.Nodes.Add(node);
                i++;
            }
        }

        private string GetState(int state)
        {
            if (state == Framework.Entity.Chapter.UNLOCK)
            {
                return "启用";
            }
            else
            {
                return "禁用";
            }
        }

        private void MnAdd_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Template template = new Framework.Entity.Template();
            Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)TreeChapter.SelectedNode.Tag;
            template.Chapter = chapter.Id;
            FrmTemplate win = new FrmTemplate(false, template);
            win.RefreshIntance += new Framework.Interface.Content.FrmTemplate.RefreshHandle(RefreshList);
            win.Show();
            win.InitForm();
        }

        private void MnDelete_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Template template = (Framework.Entity.Template)TreeTemplate.SelectedNode.Tag;
            utilService.Delete(template);
            RefreshList();
        }

        private void MnModify_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Template template = (Framework.Entity.Template)TreeTemplate.SelectedNode.Tag;
            FrmTemplate win = new FrmTemplate(true, template);
            win.RefreshIntance += new Framework.Interface.Content.FrmTemplate.RefreshHandle(RefreshList);
            win.Show();
            win.InitForm();
        }

        private void TreeMenu_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            if (TreeChapter.SelectedNode == null)
            {
                MnAdd.Enabled = false;
            }
            else
            {
                MnAdd.Enabled = true;
            }
            if (TreeTemplate.SelectedNode == null)
            {
                MnDelete.Enabled = false;
                MnModify.Enabled = false;
            }
            else
            {
                MnDelete.Enabled = true;
                MnModify.Enabled = true;
            }
        }
    }
}