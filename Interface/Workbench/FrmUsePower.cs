namespace Framework.Interface.Workbench
{
    public partial class FrmUsePower : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;

        public FrmUsePower(Framework.Entity.Chapter chapter, object type)
        {
           
            InitializeComponent();
            @class = type;
            
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                Framework.Class.ComboItem item = new Framework.Class.ComboItem();
                item.Text = template.Title;
                item.Value = template;
                CbxType.Items.Add(item);
            }
            CbxType.SelectedIndex = 0;
            IpK1.Items.Add("0.7");
            IpK1.Items.Add("0.6");
            IpK1.Items.Add("0.5");
            IpK2.Items.Add("0.6");
            IpK2.Items.Add("0.5");
            IpK1.SelectedIndex = 1;
            IpK2.SelectedIndex = 1;
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                if (DataGridView.Rows[i].Cells[0].Value != null)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("电动机"))
                    {
                        p1 += System.Convert.ToDouble(DataGridView.Rows[i].Cells[1].Value);
                    }
                    else if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("电焊机"))
                    {
                        p2 += System.Convert.ToDouble(DataGridView.Rows[i].Cells[1].Value);
                    }
                    else if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("室内照明"))
                    {
                        p3 += System.Convert.ToDouble(DataGridView.Rows[i].Cells[1].Value);
                    }
                    else if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("室外照明"))
                    {
                        p4 += System.Convert.ToDouble(DataGridView.Rows[i].Cells[1].Value);
                    }
                }
            }
            double sum = System.Convert.ToDouble(IpK1.Text) * p1 / System.Convert.ToDouble(IpCos.Value) + System.Convert.ToDouble(IpK2.Text) * p2 + IpK3.Value * p3 + IpK4.Value * p4;
            object[] obj = new object[] { p1, p2, p3, p4, IpCos.Value, IpK1.Text, IpK2.Text, IpK3.Value, IpK4.Value, sum };
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance((Framework.Entity.Template)item.Value, null, @class, obj);
            this.Close();
        }

        private void FrmUsePower_Load(object sender, System.EventArgs e)
        {

        }
    }
}