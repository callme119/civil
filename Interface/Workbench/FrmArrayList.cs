namespace Framework.Interface.Workbench
{
    public partial class FrmArrayList : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;

        public FrmArrayList(Framework.Entity.Chapter chapter, object type)
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
            if (@class.GetType().Equals(new Framework.Model.PlanLabor().GetType()))
            {
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colType.HeaderText = "工种";
                colType.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colBase = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colBase.HeaderText = "基础施工阶段";
                colBase.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colMain = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colMain.HeaderText = "主体施工阶段";
                colMain.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colFitup = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colFitup.HeaderText = "基础施工阶段";
                colFitup.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colLast = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colLast.HeaderText = "收尾阶段";
                colLast.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colPrepare = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colPrepare.HeaderText = "准备阶段";
                colPrepare.Width = 100;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colType);
                DataGridView.Columns.Add(colBase);
                DataGridView.Columns.Add(colMain);
                DataGridView.Columns.Add(colFitup);
                DataGridView.Columns.Add(colLast);
                DataGridView.Columns.Add(colPrepare);
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMachine().GetType()))
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择设备";
                colChoice.Width = 70;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "设备名称";
                colName.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colType.HeaderText = "设备型号";
                colType.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colFunction = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colFunction.HeaderText = "性能";
                colFunction.Width = 180;
                object[,] machines = new object[,]{ 
                    {"塔吊",new string[]{"QTZ31.5&315-KN·m","QTZ40&400KN·m","QTZ50&500KN·m","QTZ63&630KN·m"}},
                    {"施工电梯",new string[]{"SCD200/200&100m/200m"}},                    
                    {"砼搅拌机",new string[]{"JDC350&350L/560L","JS500&500L/800L","JS75&750L/1200L"}},
                    {"挖掘机（反铲）",new string[]{"Atlas3306LC&31500&1.90","Atlas2606LC&25000&1.50","Atlas2006LC&18000&1.00","Atlas2306LC&22000&1.20","BonnyCE400-6&40000&2.00","BonnyCE650-6&66000&4.00"}}
                };
                for (int i = 0; i < 4; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i, 0];
                    string[] types = (string[])machines[i, 1];
                    for (int j = 0; j < types.Length; j++)
                    {
                        DevComponents.DotNetBar.ButtonItem btnChildItem = new DevComponents.DotNetBar.ButtonItem();
                        string[] info = types[j].ToString().Split('&');
                        btnChildItem.Text = info[0];
                        btnChildItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                        {
                            DevComponents.DotNetBar.ButtonItem item = sender as DevComponents.DotNetBar.ButtonItem;
                            DataGridView.SelectedRows[0].Cells[1].Value = item.Parent.Text;
                            DataGridView.SelectedRows[0].Cells[2].Value = info[0];
                            DataGridView.SelectedRows[0].Cells[3].Value = info[1];
                            DataGridView.Refresh();
                        });
                        btnItem.SubItems.Add(btnChildItem);
                    }
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView.Columns.Add(colChoice);
                DataGridView.Columns.Add(colName);
                DataGridView.Columns.Add(colType);
                DataGridView.Columns.Add(colFunction);
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMaterial().GetType()))
            {
                // DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
                System.Windows.Forms.DataGridViewComboBoxColumn colName = new System.Windows.Forms.DataGridViewComboBoxColumn();
                colName.HeaderText = "材料名称";
                colName.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "进场数量";
                colNumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colUnit = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colUnit.HeaderText = "单位";
                colUnit.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colPlan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colPlan.HeaderText = "进场计划";
                colPlan.Width = 160;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRemarks = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRemarks.HeaderText = "备注";
                colRemarks.Width = 150;
                DataGridView.Columns.Add(colName);
                DataGridView.Columns.Add(colNumber);
                DataGridView.Columns.Add(colUnit);
                DataGridView.Columns.Add(colPlan);
                DataGridView.Columns.Add(colRemarks);
            }
            else if (@class.GetType().Equals(new Framework.Model.ManageMember().GetType()))
            {
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                System.Windows.Forms.DataGridViewTextBoxColumn colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colName.HeaderText = "姓名";
                colName.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colWork = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colWork.HeaderText = "职务";
                colWork.Width = 120;
                System.Windows.Forms.DataGridViewComboBoxColumn colTitle = new System.Windows.Forms.DataGridViewComboBoxColumn();
                colTitle.HeaderText = "职称";
                colTitle.Width = 120;
                colTitle.Items.Add("高级工程师");
                colTitle.Items.Add("工程师");
                colTitle.Items.Add("助理工程师");
                colTitle.Items.Add("经济师");
                colTitle.Items.Add("会计师");
                System.Windows.Forms.DataGridViewTextBoxColumn colDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colDuty.HeaderText = "工作责任";
                colDuty.Width = 120;
                System.Windows.Forms.DataGridViewTextBoxColumn colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colRemarks.HeaderText = "备注";
                colRemarks.Width = 120;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colName);
                DataGridView.Columns.Add(colWork);
                DataGridView.Columns.Add(colTitle);
                DataGridView.Columns.Add(colDuty);
                DataGridView.Columns.Add(colRemarks);
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择材料";
                colChoice.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
                colName.HeaderText = "材料名称";
                colName.Width = 460;
                object[] machines = new object[]{
                 "发泡陶瓷保温板" ,   
                 "复合水泥发泡保温板",
                 "加气混凝土板",
                 "岩棉板（条）",
                 "蓝海板",
                 "其它"};
                for (int i = 0; i < 6; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        DataGridView.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView.Columns.Add(colChoice);
                DataGridView.Columns.Add(colName);
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMachineTool().GetType()))
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择机具";
                colChoice.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
                colName.HeaderText = "机具名称";
                colName.Width = 460;

                object[] machines = new object[]{
                "抹子","砂纸","2m靠尺","弹线墨盒","多用刀","铲刀","阴阳角抿子","电动搅拌机","角磨机","其它"};
                for (int i = 0; i < 10; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        DataGridView.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView.Columns.Add(colChoice);
                DataGridView.Columns.Add(colName);
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择屋面做法";
                colChoice.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
                colName.HeaderText = "屋面做法";
                colName.Width = 460;
                object[] machines = new object[]{
                 "发泡陶瓷保温板" ,   
                 "复合水泥发泡保温板",
                 "加气混凝土板",
                 "岩棉板（条）",
                 "蓝海板",
                 "其它"};
                for (int i = 0; i < 6; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        DataGridView.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView.Columns.Add(colChoice);
                DataGridView.Columns.Add(colName);
            }
        }

        private void FrmArrayList_Load(object sender, System.EventArgs e)
        {
            DataGridView.Rows.Clear();
            if (@class.GetType().Equals(new Framework.Model.PlanLabor().GetType()))
            {
                string[] strName = new string[] { "管理人员", "木工", "瓦工", "钢筋工", "砼工", "抹灰工", "电工", "水暖工", "油漆涂料工", "防水工", "综合工", "机械工", "电气焊工", "测量工", "试验工" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = true;
                    DataGridView.Rows[i].Cells[1].Value = strName[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMachine().GetType()))
            {
                BtnAddRow.Enabled = true;
                DataGridView.Rows.Add();
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMaterial().GetType()))
            {
                BtnAddRow.Enabled = true;
                object[] strName = new object[] { new string[] { "钢筋" }, new string[] { "混凝土" }, new string[] { "砖" }, new string[] { "填充砌块" }, new string[] { "钢材" }, new string[] { "Φ300试验桩", "Φ350试验桩", "Φ400试验桩", "Φ450试验桩", "Φ500试验桩", "Φ550试验桩", "Φ600试验桩", "Φ800试验桩", "Φ1000试验桩", "Φ300正式桩", "Φ350正式桩", "Φ400正式桩", "Φ450正式桩", "Φ500正式桩", "Φ550正式桩", "Φ600正式桩", "Φ800正式桩", "Φ1000正式桩" } };
                string[] strUnit = new string[] { "吨", "平方米", "块", "块", "吨", "米" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    System.Windows.Forms.DataGridViewComboBoxCell cell = (System.Windows.Forms.DataGridViewComboBoxCell)DataGridView.Rows[i].Cells[0];
                    // DevComponents.DotNetBar.Controls.DataGridViewComboBoxExCell cell = (DevComponents.DotNetBar.Controls.DataGridViewComboBoxExCell)DataGridView.Rows[i].Cells[0];
                    string[] strCell = (string[])strName[i];
                    for (int j = 0; j < strCell.Length; j++)
                    {
                        cell.Items.Add(strCell[j]);
                    }
                    DataGridView.Rows[i].Cells[2].Value = strUnit[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.ManageMember().GetType()))
            {
                string[] strWork = new string[] { "项目经理", "项目总工", "项目副（执行）经理", "土建部经理", "安装部经理", "土建工长", "土建工长", "水暖工程师", "电气工程师", "质检工程师", "安全工程师", "测量试验员", "现场材料员", "资料员", "材料主管", "预算员", "成本会计" };
                string[] strDuty = new string[] { "全面管理", "主管技术", "现场管理", "现场土建管理", "现场安装管理", "现场土建施工管理", "现场土建施工管理", "水暖安装施工管理", "电气施工管理", "现场质量检查", "安全管理", "现场测量试验", "现场材料管理", "资料管理", "材料管理", "预算", "成本管理" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = true;
                    DataGridView.Rows[i].Cells[2].Value = strWork[i];
                    DataGridView.Rows[i].Cells[4].Value = strDuty[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                BtnAddRow.Enabled = true;
                DataGridView.Rows.Add();
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMachineTool().GetType()))
            {
                BtnAddRow.Enabled = true;
                DataGridView.Rows.Add();
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            if (@class.GetType().Equals(new Framework.Model.PlanLabor().GetType()))
            {
                int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0;
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        for (int j = 2; j < 7; j++)
                        {
                            FormatValue(DataGridView.Rows[i].Cells[j], 0);
                        }
                        sum1 += System.Convert.ToInt32(DataGridView.Rows[i].Cells[2].Value);
                        sum2 += System.Convert.ToInt32(DataGridView.Rows[i].Cells[3].Value);
                        sum3 += System.Convert.ToInt32(DataGridView.Rows[i].Cells[4].Value);
                        sum4 += System.Convert.ToInt32(DataGridView.Rows[i].Cells[5].Value);
                        sum5 += System.Convert.ToInt32(DataGridView.Rows[i].Cells[6].Value);
                        array.Add(new object[] { DataGridView.Rows[i].Cells[1].Value, DataGridView.Rows[i].Cells[2].Value, DataGridView.Rows[i].Cells[3].Value, DataGridView.Rows[i].Cells[4].Value, DataGridView.Rows[i].Cells[5].Value });
                    }
                }
                if (array.Count > 0)
                {
                    array.Add(new object[] { "总和", sum1, sum2, sum3, sum4, sum5 });
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMachine().GetType()))
            {
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    array.Add(new object[] { i + 1, DataGridView.Rows[i].Cells[1].Value, DataGridView.Rows[i].Cells[2].Value, DataGridView.Rows[i].Cells[3].Value });
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMaterial().GetType()))
            {
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value != null)
                    {
                        FormatValue(DataGridView.Rows[i].Cells[1], 0);
                        FormatValue(DataGridView.Rows[i].Cells[3], "");
                        FormatValue(DataGridView.Rows[i].Cells[4], "");
                        array.Add(new object[] { i + 1, DataGridView.Rows[i].Cells[0].Value, DataGridView.Rows[i].Cells[1].Value, DataGridView.Rows[i].Cells[2].Value, DataGridView.Rows[i].Cells[3].Value, DataGridView.Rows[i].Cells[4].Value });
                    }
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.ManageMember().GetType()))
            {
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        for (int j = 1; j < 6; j++)
                        {
                            FormatValue(DataGridView.Rows[i].Cells[j], "");
                        }
                        array.Add(new object[] { i + 1, DataGridView.Rows[i].Cells[1].Value, DataGridView.Rows[i].Cells[2].Value, DataGridView.Rows[i].Cells[3].Value, DataGridView.Rows[i].Cells[4].Value, DataGridView.Rows[i].Cells[5].Value });
                    }
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    array.Add(new object[] { i + 1, DataGridView.Rows[i].Cells[1].Value });
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMachineTool().GetType()))
            {
                int MXindex = CbxType.SelectedIndex;
                array.Add(new object[] { 0, MXindex });
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    array.Add(new object[] { i + 1, DataGridView.Rows[i].Cells[1].Value });
                }
            }
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance((Framework.Entity.Template)item.Value, array, @class);
            this.Close();
        }

        private void FormatValue(System.Windows.Forms.DataGridViewCell cell, object value)
        {
            if (cell.Value == null)
            {
                cell.Value = value;
            }
        }

        private void BtnAddRow_Click(object sender, System.EventArgs e)
        {
            if (@class.GetType().Equals(new Framework.Model.PlanMachine().GetType()))
            {
                DataGridView.Rows.Add();
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMaterial().GetType()))
            {
                System.Windows.Forms.DataGridViewRow row = (System.Windows.Forms.DataGridViewRow)DataGridView.Rows[5].Clone();
                DataGridView.Rows.Add(row);
                DataGridView.Rows[DataGridView.RowCount - 1].Cells[2].Value = "米";
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                DataGridView.Rows.Add();
            }
            else if (@class.GetType().Equals(new Framework.Model.PrepareMachineTool().GetType()))
            {
                DataGridView.Rows.Add();
            }
        }
    }
}