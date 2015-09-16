namespace Framework.Interface.Content
{
    public partial class FrmModel : Framework.Interface.Common.FrmBase
    {
        public delegate void RefreshHandle();
        public RefreshHandle RefreshIntance;

        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private Framework.Entity.Model model;
        private bool flag;

        public FrmModel(bool _flag, Framework.Entity.Model _model)
        {
            InitializeComponent();
            flag = _flag;
            model = _model;
        }

        private void FrmModel_Load(object sender, System.EventArgs e)
        {
            CbxState.Items.Add("启用");
            CbxState.Items.Add("禁用");
            CbxState.SelectedIndex = 0;
            if (flag)
            {
                TbxName.Text = model.Name;
                TbxClass.Text = model.Class;
                TbxDescription.Text = model.Description;
                CbxState.SelectedIndex = model.State;
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            model.Name = TbxName.Text;
            model.Class = TbxClass.Text;
            model.Description = TbxDescription.Text;
            model.State = CbxState.SelectedIndex;
            if (flag)
            {
                utilService.Update(model);
            }
            else
            {
                utilService.Insert(model);
            }
            RefreshIntance();
            this.Close();
        }
    }
}