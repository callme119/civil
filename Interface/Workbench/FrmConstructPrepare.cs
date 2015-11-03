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
                if (template.Title == "���ּܹ���")
                {
                    tempInsertText = template;
                }
            }

            {
                #region/*��е׼��*/
                object[,] machines = new object[,]{
                 {"���Ӱ���" , "���ӹ�����Ͳ��������"},
                 {"���ذ���","�����ӿۼ�š�������Ƿ�ﵽҪ��"},
                 {"����","��������ˮƽ������"},
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
                            case "���Ӱ���": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[0, 1]; break;
                            case "���ذ���": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[1, 1]; break;
                            case "����": DataGridView1.SelectedRows[0].Cells[3].Value = (string)machines[2, 1]; break;
                        }
                        DataGridView1.Refresh();
                    });
                    colChoice.SubItems.Add(btnItem);
                }
                #endregion
            }

            {
                #region /*����׼��*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "ѡ����ּ�";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "���ּ�����";
                colName.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colType = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colType.HeaderText = "�������";
                colType.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colFunction = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
                colFunction.HeaderText = "����˵��";
                colFunction.Width = 250;
                object[,] machines = new object[,]{ 
                    {"�ֹ���ؽ��ּ�_�ڽ��ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"�ֹ���ؽ��ּ�_����ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"�ֹ���ؽ��ּ�_����������",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"���ʽ�ֹܽ��ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"��ʽ�ֹܽ��ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"��ʽ���ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"�ۼ�ʽ�ֹܽ��ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"��ǽ�������ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"�����������ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"������������ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
                    {"�ֹܿۼ����ý��ּ�",new string[]{"�ֹ�&��48 �� 3.5","�ۼ�&����","��ǽ��&�������磬�ۼ�����","���ְ�&ľ���ְ�","��ȫ��&��Ŀ��ȫ��"}},
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
                #region /*�Ͷ�������*/
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colChoice.HeaderText = "ѡ����";
                colChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                colName.HeaderText = "��������";
                colName.Width = 250;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colNumber.HeaderText = "ÿ������";
                colNumber.Width = 250;
                object[] labor = new object[]{
                    "��������",
                    "��ȫ�ල",
                    "�������",
                    "��������",
                    "���ӹ�"
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
                #region/*���ּ�ʩ������*/
                //DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                //colChoice.HeaderText = "ѡ����ּ�ʩ������";
                //colChoice.Width = 200;
                //DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
                //colName.HeaderText = "���ּ�ʩ������";
                //colName.Width = 400;
                //object[,] machines = new object[,]{
                // {"���ʽ�ֹܽ��ּ�",new string[] {"�ڽ��ּ�","����������","����ּ�"}},
                // {"����ˮ�෢�ݱ��°�",new string[]{}},
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

            #region//��ѡ�еĶ��꼾ʩ��������ӵ��ĵ�����Ӧλ��
            object[] data = new object[12];
            for (int i = 1; i <= 11; i++)
            {
                selectState[i] = 0;
            }
            int numLength = 0;//����ȷ��һ��ѡ���˼������͵Ľ��ּ�
            for (int i = 0; i < DataGridView2.Rows.Count; i++)
            {
                switch (DataGridView2.Rows[i].Cells[1].Value.ToString())
                {
                    case "�ֹ���ؽ��ּ�_�ڽ��ּ�": if (selectState[1] == 0) { selectState[1] = 1; numLength++; } break;
                    case "�ֹ���ؽ��ּ�_����ּ�": if (selectState[2] == 0) { selectState[2] = 1; numLength++; } break;
                    case "�ֹ���ؽ��ּ�_����������": if (selectState[3] == 0) { selectState[3] = 1; numLength++; } break;
                    case "���ʽ�ֹܽ��ּ�": if (selectState[4] == 0) { selectState[4] = 1; numLength++; } break;
                    case "��ʽ�ֹܽ��ּ�": if (selectState[5] == 0) { selectState[5] = 1; numLength++; } break;
                    case "��ʽ���ּ�": if (selectState[6] == 0) { selectState[6] = 1; numLength++; } break;
                    case "�ۼ�ʽ�ֹܽ��ּ�": if (selectState[7] == 0) { selectState[7] = 1; numLength++; } break;
                    case "��ǽ�������ּ�": if (selectState[8] == 0) { selectState[8] = 1; numLength++; } break;
                    case "�����������ּ�": if (selectState[9] == 0) { selectState[9] = 1; numLength++; } break;
                    case "������������ּ�": if (selectState[10] == 0) { selectState[10] = 1; numLength++; } break;
                    case "�ֹܿۼ����ý��ּ�": if (selectState[11] == 0) { selectState[11] = 1; numLength++; } break;
                }
            }
            int dataNum = 0;//�ô˱���ʵ�ֽ� data[] �����е��������δ��
            for (int i = 1; i <= 11; i++)
            {
                Framework.Entity.Template b = new Framework.Entity.Template();//����һ����ģ�塱���͵ı���
                b = (Framework.Entity.Template)templateList[i];
                if (selectState[i] == 1)//���ѡ����ĳһ���ּܣ����䡰selectState[i]==1��,
                {
                    data[dataNum] = b.Title;
                    dataNum++;//ÿѡ��һ�����ּܣ���dataNum��ֵ�ͼ�һ
                    //object adata = b.Title;
                }
            }
            data[11] = numLength;//numLength����ֵ����ʾ����ѡ�еĽ��ּܵ����͵�����
            #endregion

            CreateModuleIntance(tempInsertText, array, @class, data);
            this.Close();
        }
    }
}