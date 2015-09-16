namespace Framework.Interface.Workbench
{
    public partial class FrmConstructPrepare : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Entity.Template tempInsertText;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private int[] selectState = new int[12];
        private System.Collections.ArrayList templateList;

        public FrmConstructPrepare(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == "脚手架工程")
                {
                    tempInsertText = template;
                }
            }

            {
                #region/*机械准备*/
                object[,] machines = new object[,]{
                 {"架子扳手" , "架子工搭设和拆除架子用"},
                 {"力矩扳手","检查架子扣件拧紧力度是否达到要求"},
                 {"倒链","调整架子水平弯曲度"},
                 };
                for (int i = 0; i < 3; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)machines[i, 0];

                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView1.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        switch (btnItem.Text)
                        {
                            case "架子扳手": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[0, 1]; break;
                            case "力矩扳手": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[1, 1]; break;
                            case "倒链": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[2, 1]; break;
                        }
                        DataGridView1.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                #endregion
            }

            {
                #region /*材料准备*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择脚手架";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "脚手架名称";
                colName.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colType.HeaderText = "所需材料";
                colType.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colFunction = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
                colFunction.HeaderText = "材料说明";
                colFunction.Width = 250;
                object[,] machines = new object[,]{ 
                    {"钢管落地脚手架_内脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"钢管落地脚手架_外脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"钢管落地脚手架_物料提升架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"腕扣式钢管脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"门式钢管脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"门式脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"扣件式钢管脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"附墙升降脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"整体提升脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"整体提升外脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                    {"钢管扣件满堂脚手架",new string[]{"钢管&Φ48 × 3.5","扣件&配套","连墙件&二步三跨，扣件连接","脚手扳&木脚手板","安全网&密目安全网"}},
                };
                for (int i = 0; i < 11; i++)
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
                            DataGridView2.SelectedRows[0].Cells[1].Value = item.Parent.Text;
                            DataGridView2.SelectedRows[0].Cells[2].Value = info[0];
                            DataGridView2.SelectedRows[0].Cells[3].Value = info[1];
                            DataGridView2.Refresh();
                        });
                        btnItem.SubItems.Add(btnChildItem);
                    }
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView2.Columns.Add(colChoice);
                DataGridView2.Columns.Add(colName);
                DataGridView2.Columns.Add(colType);
                DataGridView2.Columns.Add(colFunction);
                #endregion
            }

            {
                #region /*劳动力需求*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择工种";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "工种名称";
                colName.Width = 250;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "每班人数";
                colNumber.Width = 250;
                object[] labor = new object[]{
                    "技术管理",
                    "安全监督",
                    "质量检查",
                    "测量放线",
                    "架子工"
                 };
                for (int i = 0; i < 5; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)labor[i];

                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView3.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        DataGridView3.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                DataGridView3.Columns.Add(colChoice);
                DataGridView3.Columns.Add(colName);
                DataGridView3.Columns.Add(colNumber);
                #endregion
            }

            {
                #region/*脚手架施工方案*/
                //DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                //colChoice.HeaderText = "选择脚手架施工方案";
                //colChoice.Width = 200;
                //DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                //colName.HeaderText = "脚手架施工方案";
                //colName.Width = 400;
                //object[,] machines = new object[,]{
                // {"腕扣式钢管脚手架",new string[] {"内脚手架","物料提升架","外脚手架"}},
                // {"复合水泥发泡保温板",new string[]{}},
                // };
                //for (int i = 0; i < 2; i++)
                //{
                //    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                //    btnItem.Text = (string)machines[i, 0];
                //    string[] types = (string[])machines[0, 1];
                //    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                //    {
                //        if (int i = 0)
                //        {
                //            for (int j = 0; j < types.Length; j++)
                //            {
                //                DevComponents.DotNetBar.ButtonItem btnChildItem = new DevComponents.DotNetBar.ButtonItem();
                //                //btnChildItem.Text = types[j].ToString();
                //                //btnChildItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                //                //{
                //                //    DevComponents.DotNetBar.ButtonItem item = sender as DevComponents.DotNetBar.ButtonItem;
                //                DataGridView2.SelectedRows[0].Cells[1].Value = types[j].ToString();
                //                    //DataGridView2.SelectedRows[0].Cells[2].Value = info[0];
                //                    //DataGridView2.SelectedRows[0].Cells[3].Value = info[1];
                //                    //DataGridView2.Refresh();
                //                //});
                //                btnItem.SubItems.Add(btnChildItem);
                //            }

                //        }
                //        else  
                //        {
                //            DataGridView4.SelectedRows[0].Cells[1].Value = btnItem.Text;
                //            DataGridView4.Refresh();

                //        }
                //    });
                //    colChoice.SubItems.Add(btnItem);
                //}
                //DataGridView4.Columns.Add(colChoice);
                //DataGridView4.Columns.Add(colName);
                #endregion
            }
        }

        private void FrmConstructPrepare_Load(object sender, System.EventArgs e)
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
            if (superTabControl1.SelectedTabIndex == 2)
            {
                DataGridView3.Rows.Add();
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            if (@class.GetType().Equals(new Framework.Model.ConstructPrepare().GetType()))
            {
                System.Collections.ArrayList array1 = new System.Collections.ArrayList();
                System.Collections.ArrayList array2 = new System.Collections.ArrayList();
                System.Collections.ArrayList array3 = new System.Collections.ArrayList();
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
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

            #region//将选中的冬雨季施工工程添加到文档的相应位置
            object[] data = new object[12];
            for (int i = 1; i <= 11; i++)
            {
                selectState[i] = 0;
            }
            int numLength = 0;//用于确定一共选择了几种类型的脚手架
            for (int i = 0; i < DataGridView2.Rows.Count; i++)
            {
                switch (DataGridView2.Rows[i].Cells[1].Value.ToString())
                {
                    case "钢管落地脚手架_内脚手架": if (selectState[1] == 0) { selectState[1] = 1; numLength++; } break;
                    case "钢管落地脚手架_外脚手架": if (selectState[2] == 0) { selectState[2] = 1; numLength++; } break;
                    case "钢管落地脚手架_物料提升架": if (selectState[3] == 0) { selectState[3] = 1; numLength++; } break;
                    case "腕扣式钢管脚手架": if (selectState[4] == 0) { selectState[4] = 1; numLength++; } break;
                    case "门式钢管脚手架": if (selectState[5] == 0) { selectState[5] = 1; numLength++; } break;
                    case "门式脚手架": if (selectState[6] == 0) { selectState[6] = 1; numLength++; } break;
                    case "扣件式钢管脚手架": if (selectState[7] == 0) { selectState[7] = 1; numLength++; } break;
                    case "附墙升降脚手架": if (selectState[8] == 0) { selectState[8] = 1; numLength++; } break;
                    case "整体提升脚手架": if (selectState[9] == 0) { selectState[9] = 1; numLength++; } break;
                    case "整体提升外脚手架": if (selectState[10] == 0) { selectState[10] = 1; numLength++; } break;
                    case "钢管扣件满堂脚手架": if (selectState[11] == 0) { selectState[11] = 1; numLength++; } break;
                }
            }
            int dataNum = 0;//用此变量实现将 data[] 数组中的数据依次存放
            for (int i = 1; i <= 11; i++)
            {
                Framework.Entity.Template b = new Framework.Entity.Template();//定义一个“模板”类型的变量
                b = (Framework.Entity.Template)templateList[i];
                if (selectState[i] == 1)//如果选中了某一脚手架，则其“selectState[i]==1”,
                {
                    data[dataNum] = b.Title;
                    dataNum++;//每选中一个脚手架，，dataNum的值就加一
                    //object adata = b.Title;
                }
            }
            data[11] = numLength;//numLength最后的值，表示的是选中的脚手架的类型的总数
            #endregion

            CreateModuleIntance(tempInsertText, array, @class, data);
            this.Close();
        }
    }
}