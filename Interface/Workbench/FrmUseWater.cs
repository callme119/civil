namespace Framework.Interface.Workbench
{
    public partial class FrmUseWater : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data); //1.定义一个Delegate函数数据结构
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();

        private object @class;

        public FrmUseWater(Framework.Entity.Chapter chapter, object type)
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
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;
            if (@class.GetType().Equals(new Framework.Model.UseWater().GetType()))
            {
                System.Collections.ArrayList array1 = new System.Collections.ArrayList();
                System.Collections.ArrayList array2 = new System.Collections.ArrayList();
                System.Collections.ArrayList array3 = new System.Collections.ArrayList();
                System.Collections.ArrayList array4 = new System.Collections.ArrayList();
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    if (DataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        sum1 = sum1 + System.Convert.ToDouble(DataGridView1.Rows[i].Cells[1].Value) * System.Convert.ToDouble(DataGridView1.Rows[i].Cells[2].Value);
                        array1.Add(new object[] { i + 1, DataGridView1.Rows[i].Cells[0].Value, DataGridView1.Rows[i].Cells[1].Value, DataGridView1.Rows[i].Cells[2].Value, DataGridView1.Rows[i].Cells[3].Value });
                    }
                }
                for (int i = 0; i < DataGridView2.Rows.Count; i++)
                {
                    if (DataGridView2.Rows[i].Cells[0].Value != null)
                    {
                        sum2 = sum2 + System.Convert.ToDouble(DataGridView2.Rows[i].Cells[1].Value) * System.Convert.ToDouble(DataGridView2.Rows[i].Cells[2].Value);
                        array2.Add(new object[] { i + 1, DataGridView2.Rows[i].Cells[0].Value, DataGridView2.Rows[i].Cells[1].Value, DataGridView2.Rows[i].Cells[2].Value });
                    }
                }
                for (int i = 0; i < DataGridView3.Rows.Count; i++)
                {
                    if (DataGridView3.Rows[i].Cells[0].Value != null)
                    {
                        sum3 = sum3 + System.Convert.ToDouble(DataGridView3.Rows[i].Cells[1].Value) * System.Convert.ToDouble(DataGridView3.Rows[i].Cells[2].Value);
                        array3.Add(new object[] { i + 1, DataGridView3.Rows[i].Cells[0].Value, DataGridView3.Rows[i].Cells[1].Value, DataGridView3.Rows[i].Cells[2].Value });
                    }
                }
                for (int i = 0; i < DataGridView4.Rows.Count; i++)
                {
                    if (DataGridView4.Rows[i].Cells[0].Value != null)
                    {
                        sum4 = sum4 + System.Convert.ToDouble(DataGridView4.Rows[i].Cells[1].Value) * System.Convert.ToDouble(DataGridView4.Rows[i].Cells[2].Value);
                        array4.Add(new object[] { i + 1, DataGridView4.Rows[i].Cells[0].Value, DataGridView4.Rows[i].Cells[1].Value, DataGridView4.Rows[i].Cells[2].Value });
                    }
                }

                if (array1.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("请添加工程用水量记录！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    TabControl.SelectedTabIndex = 0;
                    return;
                }
                else if (array2.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("请添加施工机械用水量记录！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    TabControl.SelectedTabIndex = 1;
                    return;
                }
                else if (array3.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("请添加工地生活用水量记录！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    TabControl.SelectedTabIndex = 2;
                    return;
                }
                else if (array4.Count == 0)
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("请添加生活区生活用水量记录！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    TabControl.SelectedTabIndex = 3;
                    return;
                }
                array.Add(array1);
                array.Add(array2);
                array.Add(array3);
                array.Add(array4);
            }
            double q1 = (IpK1.Value * sum1 * IpK2.Value) / (IpT1.Value * IpB1.Value * 8 * 3600);
            double q2 = (IpK3.Value * sum2 * IpK4.Value) / (8 * 3600);
            double q3 = (IpK5.Value * sum3) / (IpB2.Value * 8 * 3600);
            double q4 = (IpK6.Value * sum4) / (24 * 3600);
            double q5 = IpQ5.Value;
            double q = q5 + (q1 + q2 + q3 + q4) / 2;
            double d = System.Math.Sqrt((4 * q) / (System.Math.PI * IpV.Value * 1000));
            object[] data = new object[] { IpK1.Value, IpK2.Value, IpK3.Value, IpK4.Value, IpK5.Value, IpK6.Value, IpT1.Value, IpB1.Value, IpB2.Value, sum1, sum2, sum3, sum4, q1, q2, q3, q4, q5, q, IpV.Value, d, d * 1000 };
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance((Framework.Entity.Template)item.Value, array, @class, data);//4.通过delegate数据变量执行实例方法
            this.Close();
        }
    }
}