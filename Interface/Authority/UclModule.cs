namespace Framework.Interface.Authority
{
    public partial class UclModule : System.Windows.Forms.UserControl
    {
        private Framework.Implement.AuthorityImpl authorityService = new Framework.Implement.AuthorityImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        
        
        
      public UclModule()
        {
            InitializeComponent();
        }

        private void UclModule_Load(object sender, System.EventArgs e)
        {
            RefreshTree();
        }

        private DevComponents.AdvTree.Node CreateChildNode(Framework.Entity.Module module, System.Drawing.Image image, DevComponents.DotNetBar.ElementStyle subItemStyle)
        {
            DevComponents.AdvTree.Node childNode = new DevComponents.AdvTree.Node(module.Title);
            childNode.Image = image;
            childNode.Cells.Add(new DevComponents.AdvTree.Cell(module.Title, subItemStyle));
            childNode.Tag = module;
            childNode.NodeDoubleClick += new System.EventHandler(MnModify_Click);
            return childNode;
        }

        private void RefreshTree()
        {
            AdvTree.Nodes.Clear();
            AdvTree.View = DevComponents.AdvTree.eView.Tile;
            DevComponents.DotNetBar.ElementStyle groupStyle = new DevComponents.DotNetBar.ElementStyle();
            groupStyle.TextColor = System.Drawing.Color.Navy;
            groupStyle.Font = new System.Drawing.Font(AdvTree.Font.FontFamily, 9f, System.Drawing.FontStyle.Bold);
            groupStyle.Name = "GroupStyle";
            AdvTree.Styles.Add(groupStyle);
            DevComponents.DotNetBar.ElementStyle subItemStyle = new DevComponents.DotNetBar.ElementStyle();
            subItemStyle.TextColor = System.Drawing.Color.Gray;
            subItemStyle.Name = "SubItemStyle";
            AdvTree.Styles.Add(subItemStyle);
            System.Collections.ArrayList rootList = authorityService.GetRootModule(Framework.Entity.Module.ALL);
            foreach (Framework.Entity.Module root in rootList)
            {
                DevComponents.AdvTree.Node groupNode = new DevComponents.AdvTree.Node(root.Title, groupStyle);
                groupNode.Expanded = true;
                groupNode.Tag = root;
                AdvTree.Nodes.Add(groupNode);
                System.Collections.ArrayList childList = authorityService.GetModuleByPid(root.Id, Framework.Entity.Module.ALL);
                foreach (Framework.Entity.Module child in childList)
                {
                    groupNode.Nodes.Add(CreateChildNode(child, global::Framework.Properties.Resources.Default, subItemStyle));
                }
            }
        }

        private void MnAdd_Click(object sender, System.EventArgs e)
        {
            FrmModule win = new FrmModule(false, new Framework.Entity.Module());
            win.RefreshIntance += new Framework.Interface.Authority.FrmModule.RefreshHandle(RefreshTree);
            win.ShowDialog();
        }

        private void MnDelete_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Module module = (Framework.Entity.Module)AdvTree.SelectedNode.Tag;
            utilService.Delete(module);
            RefreshTree();
        }

        private void MnModify_Click(object sender, System.EventArgs e)
        {
            FrmModule win = new FrmModule(true, (Framework.Entity.Module)AdvTree.SelectedNode.Tag);
            win.RefreshIntance += new Framework.Interface.Authority.FrmModule.RefreshHandle(RefreshTree);
            win.ShowDialog();
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