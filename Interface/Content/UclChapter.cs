namespace Framework.Interface.Content
{
    public partial class UclChapter : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        public UclChapter()
        {
            InitializeComponent();
        }

        private void UclChapter_Load(object sender, System.EventArgs e)
        {
            RefreshTree();
        }

        private void RefreshTree()
        {
            AdvTree.Nodes.Clear();
            System.Collections.ArrayList rootList = contentService.GetChapterByPid(0, Framework.Entity.Project.Type);
            foreach (Framework.Entity.Chapter root in rootList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(root.Title);
                node.Cells.Add(new DevComponents.AdvTree.Cell(root.Description));
                node.Cells.Add(new DevComponents.AdvTree.Cell(GetState(root.State)));
                node.Tag = root;
                node.Expanded = false;
                node.NodeDoubleClick += new System.EventHandler(MnModify_Click);
                AdvTree.Nodes.Add(node);
                CreateChapter(root.Id, node);
            }
        }

        private void CreateChapter(int pid, DevComponents.AdvTree.Node rootNode)
        {
            System.Collections.ArrayList nodeList = contentService.GetChapterByPid(pid, Framework.Entity.Project.Type);
            foreach (Framework.Entity.Chapter child in nodeList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(child.Title);
                node.Cells.Add(new DevComponents.AdvTree.Cell(child.Description));
                node.Cells.Add(new DevComponents.AdvTree.Cell(GetState(child.State)));
                node.Tag = child;
                node.Expanded = false;
                node.NodeDoubleClick += new System.EventHandler(MnModify_Click);
                rootNode.Nodes.Add(node);
                CreateChapter(child.Id, node);
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
            Framework.Entity.Chapter chapter = new Framework.Entity.Chapter();
            if (AdvTree.SelectedNode != null)
            {
                chapter = (Framework.Entity.Chapter)AdvTree.SelectedNode.Tag;
            }
            FrmChapter win = new FrmChapter(false, chapter);
            win.RefreshIntance += new Framework.Interface.Content.FrmChapter.RefreshHandle(RefreshTree);
            win.ShowDialog();
        }

        private void MnDelete_Click(object sender, System.EventArgs e)
        {
            utilService.Delete((Framework.Entity.Chapter)AdvTree.SelectedNode.Tag);
            RefreshTree();
        }

        private void MnModify_Click(object sender, System.EventArgs e)
        {
            AdvTree.SelectedNode.Expanded = true;
            FrmChapter win = new FrmChapter(true, (Framework.Entity.Chapter)AdvTree.SelectedNode.Tag);
            win.RefreshIntance += new Framework.Interface.Content.FrmChapter.RefreshHandle(RefreshTree);
            win.ShowDialog();
        }

        private void TreeMenu_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
        {
            if (AdvTree.SelectedNode == null)
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