namespace Framework.Interface.Workbench
{
    public partial class FrmInsertText : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Template tempInsertText;
        private System.Collections.ArrayList templateList;

        public FrmInsertText(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == "冬期施工措施" | template.Title == "越冬工程的维护" | template.Title == "桩基工程" | template.Title == "屋面及防水施工方案")
                {
                    tempInsertText = template;
                }
            }
            if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMeasure().GetType()))
            {
                this.Text = "冬期施工措施";
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "冬期施工措施";
                colName.Width = 475;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colName);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMaintain().GetType()))
            {
                this.Text = "越冬工程的维护";
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "越冬工程的维护";
                colName.Width = 475;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colName);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextPileProject().GetType()))
            {
                this.Text = "常用桩基的施工方案";
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "桩基施工方案";
                colName.Width = 475;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colName);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextRoof().GetType()))
            {
                this.Text = "屋面及防水施工方案";
                System.Windows.Forms.DataGridViewCheckBoxColumn colState = new System.Windows.Forms.DataGridViewCheckBoxColumn(true);
                colState.ThreeState = false;
                colState.Width = 30;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "屋面的做法";
                colName.Width = 475;
                DataGridView.Columns.Add(colState);
                DataGridView.Columns.Add(colName);
            }
        }

        private void FrmInsertText_Load(object sender, System.EventArgs e)
        {
            if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMeasure().GetType()))
            {
                string[] strName = new string[] { "土方工程", "砌体工程", "钢筋工程", "砼工程", "屋面工程", "装饰工程", "管道工程" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = false;
                    DataGridView.Rows[i].Cells[1].Value = strName[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMaintain().GetType()))
            {
                string[] strName = new string[] { "在建工程", "停、缓建工程" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = false;
                    DataGridView.Rows[i].Cells[1].Value = strName[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextPileProject().GetType()))
            {
                string[] strName = new string[] { "沉管灌注桩", "钻孔灌注桩（泥浆护壁法）", "钻孔灌注桩（全套管施工法）", "钢筋混凝土预制实心方桩（静压法）", "钢筋混凝土预制实心方桩（锤击法）", "预应力混凝土管桩（静压法）", "预应力混凝土管桩（锤击法）" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = false;
                    DataGridView.Rows[i].Cells[1].Value = strName[i];
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextRoof().GetType()))
            {
                string[] strName = new string[] { "平瓦坡屋面", "水泥砂浆平屋面", "彩色水泥砖上人屋面", "小青瓦" };
                for (int i = 0; i < strName.Length; i++)
                {
                    DataGridView.Rows.Add();
                    DataGridView.Rows[i].Cells[0].Value = false;
                    DataGridView.Rows[i].Cells[1].Value = strName[i];
                }
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMeasure().GetType()))
            {
                object[] data = new object[8];
                int[] selectState = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    selectState[i] = 0;
                }
                int count = 0;
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        selectState[i + 1] = 1;
                        count++;
                    }
                }
                int dataNum = 0;
                for (int i = 1; i <= 7; i++)
                {
                    Framework.Entity.Template insertText1 = new Framework.Entity.Template();
                    insertText1 = (Framework.Entity.Template)templateList[i];
                    if (selectState[i] == 1)
                    {
                        data[dataNum] = insertText1.Title;
                        dataNum++;
                    }
                }
                data[7] = count;
                CreateModuleIntance(tempInsertText, array, @class, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMaintain().GetType()))
            {
                object[] data = new object[3];
                int[] selectState = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    selectState[i] = 0;
                }
                int count = 0;
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        selectState[i + 1] = 1;
                        count++;
                    }
                }
                int dataNum = 0;
                for (int i = 1; i <= 2; i++)
                {
                    Framework.Entity.Template insertText1 = new Framework.Entity.Template();
                    insertText1 = (Framework.Entity.Template)templateList[i];

                    if (selectState[i] == 1)
                    {
                        data[dataNum] = insertText1.Title;
                        dataNum++;
                    }
                }
                data[2] = count;
                CreateModuleIntance(tempInsertText, array, @class, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextPileProject().GetType()))
            {
                object[] data = new object[8];
                int[] selectState = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    selectState[i] = 0;
                }
                int count = 0;
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        selectState[i + 1] = 1;
                        count++;
                    }
                }
                int dataNum = 0;
                for (int i = 1; i <= 7; i++)
                {
                    Framework.Entity.Template insertText1 = new Framework.Entity.Template();
                    insertText1 = (Framework.Entity.Template)templateList[i];
                    if (selectState[i] == 1)
                    {
                        data[dataNum] = insertText1.Title;
                        dataNum++;
                    }
                }
                data[7] = count;
                CreateModuleIntance(tempInsertText, array, @class, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextRoof().GetType()))
            {
                object[] data = new object[11];
                int[] selectState = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    selectState[i] = 0;
                }
                int count1 = 0;
                for (int i = 0; i < DataGridView.RowCount; i++)
                {
                    if (DataGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        selectState[i + 1] = 1;
                        count1++;
                    }
                }
                int dataNum = 0;
                for (int i = 1; i <= 4; i++)
                {
                    Framework.Entity.Template insertText1 = new Framework.Entity.Template();
                    insertText1 = (Framework.Entity.Template)templateList[i];
                    if (selectState[i] == 1)
                    {
                        data[dataNum] = insertText1.Title;
                        dataNum++;
                    }
                }
                data[8] = count1;
                count1 = 0;
                if (selectState[1] == 1 | selectState[2] == 1)
                {
                    count1++;
                    Framework.Entity.Template insertText2 = new Framework.Entity.Template();
                    insertText2 = (Framework.Entity.Template)templateList[5];
                    data[4] = insertText2.Title;
                    insertText2 = (Framework.Entity.Template)templateList[7];
                    data[6] = insertText2.Title;
                    data[9] = count1;
                    data[10] = count1;
                }
                if (selectState[3] == 1 | selectState[4] == 1)
                {
                    count1++;
                    if (count1 == 1)
                    {
                        Framework.Entity.Template insertText3 = new Framework.Entity.Template();
                        insertText3 = (Framework.Entity.Template)templateList[6];
                        data[4] = insertText3.Title;
                        insertText3 = (Framework.Entity.Template)templateList[8];
                        data[6] = insertText3.Title;
                        data[9] = count1;
                        data[10] = count1;
                    }
                    else
                    {
                        Framework.Entity.Template insertText4 = new Framework.Entity.Template();
                        insertText4 = (Framework.Entity.Template)templateList[6];
                        data[5] = insertText4.Title;
                        insertText4 = (Framework.Entity.Template)templateList[8];
                        data[7] = insertText4.Title;
                        data[9] = count1;
                        data[10] = count1;
                    }
                }
                CreateModuleIntance(tempInsertText, array, @class, data);
            }
            this.Close();
        }
    }
}