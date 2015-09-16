namespace Framework.Interface.Content
{
    public partial class UclModel : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        public UclModel()
        {
            InitializeComponent();
        }

        private void UclModel_Load(object sender, System.EventArgs e)
        {
            RefreshList();
        }

        private void MnAdd_Click(object sender, System.EventArgs e)
        {
            FrmModel win = new FrmModel(false, new Framework.Entity.Model());
            win.RefreshIntance += new Framework.Interface.Content.FrmModel.RefreshHandle(RefreshList);
            win.ShowDialog();
        }

        private void MnDelete_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Model model = (Framework.Entity.Model)AdvTree.SelectedNode.Tag;
            utilService.Delete(model);
            RefreshList();
        }

        private void MnModify_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Model model = (Framework.Entity.Model)AdvTree.SelectedNode.Tag;
            FrmModel win = new FrmModel(true, model);
            win.RefreshIntance += new Framework.Interface.Content.FrmModel.RefreshHandle(RefreshList);
            win.ShowDialog();
        }

        private void RefreshList()
        {
            AdvTree.Nodes.Clear();
            System.Collections.ArrayList modelList = contentService.GetAllModel();
            int i = 1;
            foreach (Framework.Entity.Model model in modelList)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(System.Convert.ToString(i));
                node.Cells.Add(new DevComponents.AdvTree.Cell(model.Name));
                node.Cells.Add(new DevComponents.AdvTree.Cell(model.Description));
                node.Cells.Add(new DevComponents.AdvTree.Cell(GetState(model.State)));
                node.Tag = model;
                node.NodeDoubleClick += new System.EventHandler(MnModify_Click);
                AdvTree.Nodes.Add(node);
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

        private void ContextMenuBar_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
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