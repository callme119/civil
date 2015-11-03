namespace Framework.Interface.Workbench
{
    public partial class FrmRainConstruct : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Template tempInsertText;
        private int[] selectState = new int[12];
        private System.Collections.ArrayList templateList;

        public FrmRainConstruct(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == "����ʩ��")
                {
                    tempInsertText = template;
                }
            }
        }

        private void FrmRainConstruct_Load(object sender, System.EventArgs e)
        {
            {//�꼾ʩ���������
                DataGridView1.Rows.Add();
                if (@class.GetType().Equals(new Framework.Model.RainConstruct().GetType()))
                {
                    string[] strName1 = new string[] { "��ˮ��", "���ϲ�", "��֯��", "����", "��ˮ����", "��", "ɻ��" };
                    string[] strUnit = new string[] { "̨", "m2", "��", "��", "m", "��", "�O" };
                    for (int i = 0; i < strName1.Length; i++)
                    {
                        DataGridView2.Rows.Add();
                        DataGridView2.Rows[i].Cells[0].Value = false;
                        DataGridView2.Rows[i].Cells[1].Value = strName1[i];
                        DataGridView2.Rows[i].Cells[2].Value = strUnit[i];
                    }
                }
            }

            {//�꼾ʩ����Ҫ�����ʩ
                string[] strName2 = new string[] { "�������������", "����������", "�ֽ��", "ģ�幤��", "����������", "����Ĩ�ҹ���", "���湤��", "װ�ι���", "���ּܹ���", "�ٵ簲ȫ��ʩ", "������������װ��ȫ��ʩ" };
                for (int i = 0; i < strName2.Length; i++)
                {
                    DataGridViewX3.Rows.Add();
                    DataGridViewX3.Rows[i].Cells[0].Value = false;
                    DataGridViewX3.Rows[i].Cells[1].Value = strName2[i];
                }
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            System.Collections.ArrayList array2 = new System.Collections.ArrayList();
            for (int i = 0; i < DataGridView2.RowCount; i++)
            {
                if (DataGridView2.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    for (int j = 1; j < 5; j++)
                    {
                        FormatValue(DataGridView2.Rows[i].Cells[j], "");
                    }
                    array2.Add(new object[] { i + 1, DataGridView2.Rows[i].Cells[1].Value, DataGridView2.Rows[i].Cells[2].Value, DataGridView2.Rows[i].Cells[3].Value, DataGridView2.Rows[i].Cells[4].Value });
                }
            }
            array.Add(array2);
            object[] data = new object[15];
            //int[] selectState = new int[11];
            //System.Collections.ArrayList templateList;
            for (int i = 0; i < 11; i++)
            {
                selectState[i] = 0;
            }
            int count = 0;
            for (int i = 0; i < DataGridViewX3.RowCount; i++)
            {
                if (DataGridViewX3.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    //array.Add(new object[] { DataGridViewX3.Rows[i].Cells[1].Value });
                    selectState[i + 1] = 1;
                    count++;
                }
            }
            int dataNum = 0;
            for (int i = 1; i <= 11; i++)
            {
                Framework.Entity.Template b = new Framework.Entity.Template();
                b = (Framework.Entity.Template)templateList[i];

                if (selectState[i] == 1)
                {
                    data[dataNum] = b.Title;
                    dataNum++;
                }
            }
            data[11] = count;
            //array.Add(new object[] { count });
            data[12] = DataGridView1.Rows[0].Cells[0].Value;
            data[13] = DataGridView1.Rows[0].Cells[1].Value;
            data[14] = DataGridView1.Rows[0].Cells[2].Value;
            //object[] data = new object[] { DataGridView1.Rows[0].Cells[0].Value, DataGridView1.Rows[0].Cells[1].Value, DataGridView1.Rows[0].Cells[2].Value };
            //Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxType.SelectedItem;
            CreateModuleIntance(tempInsertText, array, @class, data);
            this.Close();
        }

        private void FormatValue(System.Windows.Forms.DataGridViewCell cell, object value)
        {
            if (cell.Value == null)
            {
                cell.Value = value;
            }
        }
    }
}