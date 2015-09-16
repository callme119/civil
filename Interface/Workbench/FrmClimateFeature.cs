namespace Framework.Interface.Workbench
{
    public partial class FrmClimateFeature : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;

        public FrmClimateFeature(Framework.Entity.Chapter chapter, object type)
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
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "选择城市";
                colChoice.Width = 50;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colCity = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colCity.HeaderText = "城市";
                colCity.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colYearAvgTemp = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colYearAvgTemp.HeaderText = "年平均气温";
                colYearAvgTemp.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colColdestMonth = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colColdestMonth.HeaderText = "最冷月份";
                colColdestMonth.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colColdAvgTemp = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colColdAvgTemp.HeaderText = "冷月平均气温";
                colColdAvgTemp.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colHottestMonth = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colHottestMonth.HeaderText = "最热月份";
                colHottestMonth.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colHotAvgTemp = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colHotAvgTemp.HeaderText = "热月平均气温";
                colHotAvgTemp.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colAvgMonthPrecipitation = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colAvgMonthPrecipitation.HeaderText = "月平均降水量";
                colAvgMonthPrecipitation.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colSummerPrecipitationAccounts = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colSummerPrecipitationAccounts.HeaderText = "夏季降水量占全年比例";
                colSummerPrecipitationAccounts.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWinterConstruction = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWinterConstruction.HeaderText = "冬期施工日期";
                colWinterConstruction.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colRainConstruction = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colRainConstruction.HeaderText = "雨期施工日期";
                colRainConstruction.Width = 100;
                DataGridView1.Columns.Add(colChoice);
                DataGridView1.Columns.Add(colCity);
                DataGridView1.Columns.Add(colYearAvgTemp);
                DataGridView1.Columns.Add(colColdestMonth);
                DataGridView1.Columns.Add(colColdAvgTemp);
                DataGridView1.Columns.Add(colHottestMonth);
                DataGridView1.Columns.Add(colHotAvgTemp);
                DataGridView1.Columns.Add(colAvgMonthPrecipitation);
                DataGridView1.Columns.Add(colSummerPrecipitationAccounts);
                DataGridView1.Columns.Add(colWinterConstruction);
                DataGridView1.Columns.Add(colRainConstruction);
                DataGridView1.Rows.Add();
                object[] strCity = new object[] { "北京", "天津", "上海", "广州" };
                string[] strYearAvgTemp = new string[] { "1℃", "2℃", "3℃", "4℃" };
                string[] strColdestMonth = new string[] { "1月", "2月", "3月", "4月" };
                string[] strColdAvgTemp = new string[] { "1℃", "2℃", "3℃", "4℃" };
                string[] strHottestMonth = new string[] { "1月", "2月", "3月", "4月" };
                string[] strHotAvgTemp = new string[] { "1℃", "2℃", "3℃", "4℃" };
                string[] strAvgMonthPrecipitation = new string[] { "10ml", "20ml", "30ml", "40ml" };
                string[] strSummerPrecipitationAccounts = new string[] { "10%", "20%", "30%", "40%" };
                string[] strWinterConstruction = new string[] { "1月", "2月", "3月", "4月" };
                string[] strRainConstruction = new string[] { "1月", "2月", "3月", "4月" };
                for (int i = 0; i < strCity.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strCity[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender, System.EventArgs args)
                    {
                        DataGridView1.SelectedRows[0].Cells[1].Value = btnItem.Text;
                        for (int j = 0; j < strCity.Length; j++)
                        {
                            if (btnItem.Text == strCity[j].ToString())
                            {
                                DataGridView1.Rows[0].Cells[2].Value = strYearAvgTemp[j];
                                DataGridView1.Rows[0].Cells[3].Value = strColdestMonth[j];
                                DataGridView1.Rows[0].Cells[4].Value = strColdAvgTemp[j];
                                DataGridView1.Rows[0].Cells[5].Value = strHottestMonth[j];
                                DataGridView1.Rows[0].Cells[6].Value = strHotAvgTemp[j];
                                DataGridView1.Rows[0].Cells[7].Value = strAvgMonthPrecipitation[j];
                                DataGridView1.Rows[0].Cells[8].Value = strSummerPrecipitationAccounts[j];
                                DataGridView1.Rows[0].Cells[9].Value = strWinterConstruction[j];
                                DataGridView1.Rows[0].Cells[10].Value = strRainConstruction[j];
                                break;
                            }
                        }
                        DataGridView1.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
            }
        }

        private void FrmClimateFeature_Load(object sender, System.EventArgs e)
        {
            string[] strName = new string[] { "土方工程", "砌体工程钢筋工程", "混凝土工程", "屋面工程", "装饰工程", "管道工程" };
            for (int i = 0; i < strName.Length; i++)
            {
                DataGridView3.Rows.Add();
                DataGridView3.Rows[i].Cells[0].Value = false;
                DataGridView3.Rows[i].Cells[1].Value = strName[i];
                DataGridView4.Rows.Add();
                DataGridView4.Rows[i].Cells[0].Value = false;
                DataGridView4.Rows[i].Cells[1].Value = strName[i];
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            // ateTime dt = dateTimePicker.Value;
            System.DateTime dtStart = dateTimeStart.Value;
            int timeStartYear = dtStart.Year;
            int timeStartMonth = dtStart.Month;
            int timeStartDay = dtStart.Day;
            System.DateTime dtEnd = dateTimeEnd.Value;
            int timeEndYear = dtEnd.Year;
            int timeEndMonth = dtEnd.Month;
            int timeEndDay = dtEnd.Day;
            int count = 0;
            for (int i = 0; i < DataGridView3.RowCount; i++)
            {
                if (DataGridView3.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {

                    array.Add(new object[] { DataGridView3.Rows[i].Cells[1].Value });
                    count++;
                }
            }
            for (int i = 0; i < DataGridView4.RowCount; i++)
            {
                if (DataGridView4.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    array.Add(new object[] { DataGridView4.Rows[i].Cells[1].Value });
                }
            }
            array.Add(new object[] { count });
            object[] data = new object[] { DataGridView1.Rows[0].Cells[1].Value, DataGridView1.Rows[0].Cells[2].Value, DataGridView1.Rows[0].Cells[3].Value, DataGridView1.Rows[0].Cells[4].Value, DataGridView1.Rows[0].Cells[5].Value, DataGridView1.Rows[0].Cells[6].Value, DataGridView1.Rows[0].Cells[7].Value, DataGridView1.Rows[0].Cells[8].Value, DataGridView1.Rows[0].Cells[9].Value, DataGridView1.Rows[0].Cells[10].Value, timeStartYear, timeStartMonth, timeStartDay, timeEndYear, timeEndMonth, timeEndDay };
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance((Framework.Entity.Template)item.Value, array, @class, data);
            this.Close();
        }
    }
}