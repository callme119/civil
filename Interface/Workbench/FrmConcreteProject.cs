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
                #region /*劳动力准备*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择工种";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "工种名称";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "每班人数";
                colNumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "备注";
                colRemarks.Width = 309;
                object[,] machines = new object[,]{
                 {"班组长" , "有较强施工组织能力，熟悉混凝土施工方法。"},
                 {"振捣手","有振捣经验，持证上岗。"},
                 {"抹面","必须是瓦工出身，有抹面经验，持证上岗。"},
                 {"接管","有接管经验，操作熟练。"},
                 {"普工","能够吃苦，不怕脏，听从指挥"}
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
                            case "班组长": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[0, 1]; break;
                            case "振捣手": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[1, 1]; break;
                            case "抹面": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[2, 1]; break;
                            case "接管": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[3, 1]; break;
                            case "普工": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[4, 1]; break;
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
                #region/*机具准备 */
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择机械";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "机械名称";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "数量";
                colNumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colPower = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colPower.HeaderText = "功率（KW）";
                colPower.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "备注";
                colRemarks.Width = 209;
                object[] machines2 = new object[]{
                "混凝土泵车","环保型振动棒","BL12布料杆","架子车","木抹","铁抹刮杠","线绳","钢卷尺","棕刷"
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
                #region/*混凝土原材料要求 */
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择原材料";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "原材料名称";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "备注";
                colRemarks.Width = 409;
                object[,] machines3 = new object[,]{
                 {"砂" , "选用中粗砂，平均粒径不大于0.5mm，含泥量≤1%，对砂子的含石量、含水量在商砼生产厂家搅拌站进行现场取样实测，保证混凝土严格按照施工配合比施工。"},
                 {"石子","选用砾石，要求含泥量≤1%，泥块含量≤0.5%，压碎指标值≤10，最大粒径与管径之比在1：3～1：4之间。"},
                 {"水泥","采用普通硅酸盐水泥，水泥进场后立即取样送试，安定性合格后方可使用。"},
                 {"泵送剂","进场泵送剂应具有出厂合格证及产品技术资料，并符合相应国家标准的要求，超过有效期或受潮的泵送剂不得使用。"},
                 {"粉煤灰","选用Ⅱ级干排灰，进场材料必须出具出厂合格证"},
                 {"膨胀剂","选用MEA，使混凝土得以补偿收缩，减少混凝土的收缩应力增强砼的防水能力。进场材料必须出具出厂合格证及厂家资质证书"},
                 {"水","市政供水管网洁净自来水"}
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
                            case "砂": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[0, 1]; break;
                            case "石子": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[1, 1]; break;
                            case "水泥": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[2, 1]; break;
                            case "泵送剂": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[3, 1]; break;
                            case "粉煤灰": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[4, 1]; break;
                            case "膨胀剂": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[5, 1]; break;
                            case "水": DataGridView3.SelectedRows[0].Cells[2].Value = (string)machines3[6, 1]; break;
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