namespace Framework.Interface.Workbench
{
    public partial class FrmConcreteProject : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;

        public FrmConcreteProject(Framework.Entity.Chapter chapter, object type)
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
            {
                #region /*�Ͷ���׼��*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "ѡ����";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "��������";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "ÿ������";
                colNumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "��ע";
                colRemarks.Width = 309;
                object[,] machines = new object[,]{
                 {"���鳤" , "�н�ǿʩ����֯��������Ϥ������ʩ��������"},
                 {"����","���񵷾��飬��֤�ϸڡ�"},
                 {"Ĩ��","�������߹�������Ĩ�澭�飬��֤�ϸڡ�"},
                 {"�ӹ�","�нӹܾ��飬����������"},
                 {"�չ�","�ܹ��Կ࣬�����࣬����ָ��"}
                 };
                for (int i = 0; i < 5; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i, 0];

                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView1.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        switch (btnItem.Text)
                        {
                            case "���鳤": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[0, 1]; break;
                            case "����": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[1, 1]; break;
                            case "Ĩ��": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[2, 1]; break;
                            case "�ӹ�": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[3, 1]; break;
                            case "�չ�": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[4, 1]; break;
                        }
                        DataGridView1.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView1.Columns.Add(colChoice);
                DataGridView1.Columns.Add(colName);
                DataGridView1.Columns.Add(colNumber);
                DataGridView1.Columns.Add(colRemarks);
                #endregion
            }

            {
                #region/*����׼�� */
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "ѡ���е";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "��е����";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "����";
                colNumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colPower = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colPower.HeaderText = "���ʣ�KW��";
                colPower.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "��ע";
                colRemarks.Width = 209;
                object[] machines2 = new object[]{
                "�������ó�","�������񶯰�","BL12���ϸ�","���ӳ�","ľĨ","��Ĩ�θ�","����","�־��","��ˢ"
                 };
                for (int i = 0; i < 9; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines2[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView2.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        DataGridView2.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView2.Columns.Add(colChoice);
                DataGridView2.Columns.Add(colName);
                DataGridView2.Columns.Add(colNumber);
                DataGridView2.Columns.Add(colPower);
                DataGridView2.Columns.Add(colRemarks);
                #endregion
            }

            {
                #region/*������ԭ����Ҫ�� */
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "ѡ��ԭ����";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "ԭ��������";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "��ע";
                colRemarks.Width = 409;
                object[,] machines3 = new object[,]{
                 {"ɰ" , "ѡ���д�ɰ��ƽ������������0.5mm����������1%����ɰ�ӵĺ�ʯ������ˮ���������������ҽ���վ�����ֳ�ȡ��ʵ�⣬��֤�������ϸ���ʩ����ϱ�ʩ����"},
                 {"ʯ��","ѡ����ʯ��Ҫ��������1%����麬����0.5%��ѹ��ָ��ֵ��10�����������ܾ�֮����1��3��1��4֮�䡣"},
                 {"ˮ��","������ͨ������ˮ�࣬ˮ�����������ȡ�����ԣ������Ժϸ�󷽿�ʹ�á�"},
                 {"���ͼ�","�������ͼ�Ӧ���г����ϸ�֤����Ʒ�������ϣ���������Ӧ���ұ�׼��Ҫ�󣬳�����Ч�ڻ��ܳ��ı��ͼ�����ʹ�á�"},
                 {"��ú��","ѡ�â򼶸��Żң��������ϱ�����߳����ϸ�֤"},
                 {"���ͼ�","ѡ��MEA��ʹ���������Բ������������ٻ�����������Ӧ����ǿ�ŵķ�ˮ�������������ϱ�����߳����ϸ�֤����������֤��"},
                 {"ˮ","������ˮ�����ྻ����ˮ"}
                 };
                for (int i = 0; i < 7; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines3[i, 0];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView3.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        switch (btnItem.Text)
                        {
                            case "ɰ": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[0, 1]; break;
                            case "ʯ��": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[1, 1]; break;
                            case "ˮ��": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[2, 1]; break;
                            case "���ͼ�": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[3, 1]; break;
                            case "��ú��": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[4, 1]; break;
                            case "���ͼ�": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[5, 1]; break;
                            case "ˮ": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[6, 1]; break;
                        }
                        DataGridView3.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView3.Columns.Add(colChoice);
                DataGridView3.Columns.Add(colName);
                DataGridView3.Columns.Add(colRemarks);
                #endregion
            }
        }

        private void FrmConcreteProject_Load(object sender, System.EventArgs e)
        {
            DataGridView1.Rows.Add();
            DataGridView2.Rows.Add();
            DataGridView3.Rows.Add();
        }

        private void BtnAddRow_Click(object sender, System.EventArgs e)
        {
            if (superTabControl1.SelectedTabIndex == 0)
            {
                DataGridView1.Rows.Add();
            }
            if (superTabControl1.SelectedTabIndex == 1)
            {
                DataGridView2.Rows.Add();
            }
            if (superTabControl1.SelectedTabIndex == 3)
            {
                DataGridView3.Rows.Add();
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            double sum1 = 0;
            if (@class.GetType().Equals(new Framework.Model.ConcreteProject().GetType()))
            {
                System.Collections.ArrayList array1 = new System.Collections.ArrayList();
                System.Collections.ArrayList array2 = new System.Collections.ArrayList();
                System.Collections.ArrayList array3 = new System.Collections.ArrayList();
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    sum1 = sum1 + System.Convert.ToDouble(DataGridView1.Rows[i].Cells[2].Value);
                    array1.Add(new object[] { i + 1, DataGridView1.Rows[i].Cells[1].Value, DataGridView1.Rows[i].Cells[2].Value, DataGridView1.Rows[i].Cells[3].Value });
                }
                for (int i = 0; i < DataGridView2.Rows.Count; i++)
                {
                    array2.Add(new object[] { i + 1, DataGridView2.Rows[i].Cells[1].Value, DataGridView2.Rows[i].Cells[2].Value, DataGridView2.Rows[i].Cells[3].Value });
                }
                for (int i = 0; i < DataGridView3.Rows.Count; i++)
                {
                    array3.Add(new object[] { i + 1, DataGridView3.Rows[i].Cells[1].Value, DataGridView3.Rows[i].Cells[2].Value });
                }
                array.Add(array1);
                array.Add(array2);
                array.Add(array3);
            }
            object[] data = new object[] { Data1.Value, Data2.Value, Data3.Value };
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance((Framework.Entity.Template)item.Value, array, @class, data);
            this.Close();
        }
    }
}