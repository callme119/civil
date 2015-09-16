namespace Framework.Interface.Authority
{
    public partial class FrmModule : Framework.Interface.Common.FrmBase
    {
        public delegate void RefreshHandle();
        public RefreshHandle RefreshIntance;

        private Framework.Implement.AuthorityImpl authorityService = new Framework.Implement.AuthorityImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private Framework.Entity.Module module;
        private bool flag;

        public FrmModule(bool _flag, Framework.Entity.Module _module)
        {
            InitializeComponent();
            flag = _flag;
            module = _module;
        }

        private void FrmModule_Load(object sender, System.EventArgs e)
        {
            CbxType.Items.Add("根节点");
            CbxType.Items.Add("子节点");
            CbxPosition.Items.Add("主菜单");
            CbxPosition.Items.Add("内容页");
            CbxImage.Items.Add("系统默认");
            CbxType.SelectedIndex = 0;
            CbxPosition.SelectedIndex = 0;
            CbxImage.SelectedIndex = 0;
            if (flag)
            {
                TbxName.Text = module.Title;
                TbxClass.Text = module.Class;
                if (module.Level == Framework.Entity.Module.ROOT)
                {
                    CbxType.SelectedIndex = Framework.Entity.Module.ROOT;
                    CbxRoot.Enabled = false;
                }
                else
                {
                    CbxType.SelectedIndex = Framework.Entity.Module.CHILD;
                    CbxRoot.Enabled = true;
                    int i = 0;
                    foreach (Framework.Class.ComboItem item in CbxRoot.Items)
                    {
                        if (System.Convert.ToInt32(item.Value) == module.Pid)
                        {
                            CbxRoot.SelectedIndex = i;
                            break;
                        }
                        i++;
                    }
                }
                CbxPosition.SelectedIndex = module.Position;
                CbxImage.SelectedIndex = module.Image;
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            module.Title = TbxName.Text;
            module.Class = TbxClass.Text;
            module.Position = CbxPosition.SelectedIndex;
            module.Image = CbxImage.SelectedIndex;
            if (CbxType.SelectedIndex == Framework.Entity.Module.ROOT)
            {
                module.Pid = Framework.Entity.Module.ROOT;
                module.Level = Framework.Entity.Module.ROOT;
            }
            else
            {
                Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxRoot.SelectedItem;
                module.Pid = System.Convert.ToInt32(item.Value);
                module.Level = Framework.Entity.Module.CHILD;
            }
            if (flag)
            {
                utilService.Update(module);
            }
            else
            {
                utilService.Insert(module);
            }
            RefreshIntance();
            this.Close();
        }

        private void CbxType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (CbxType.SelectedIndex == Framework.Entity.Module.ROOT)
            {
                CbxRoot.Enabled = false;
                CbxRoot.Items.Clear();
            }
            else
            {
                CbxRoot.Enabled = true;
                System.Collections.ArrayList rootList = authorityService.GetRootModule(Framework.Entity.Module.ALL);
                foreach (Framework.Entity.Module root in rootList)
                {
                    Framework.Class.ComboItem item = new Framework.Class.ComboItem();
                    item.Text = root.Title;
                    item.Value = root.Id;
                    CbxRoot.Items.Add(item);
                }
                CbxRoot.SelectedIndex = 0;
            }
        }
    }
}