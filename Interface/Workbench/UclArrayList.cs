namespace Framework.Interface.Workbench
{
    public partial class UclArrayList : System.Windows.Forms.UserControl
    {
        private Framework.Entity.Chapter chapter;
        private string path;
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        public UclArrayList()
        {
            InitializeComponent();
            this.Height = 550;
            this.Width = 740;
        }

        private void UclArrayList_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            if (!element.GetAttribute("DOC").Equals(""))
            {
                path = WinWordControlEx.RandomPath;
                WinWordControlEx.SetWordString(element.GetAttribute("DOC"), path);
            }
            else
            {
                Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
                System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));

                ShowFrmProfile(model, ass);
            }
        }

        private void CreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class)
        {
            path = WinWordControlEx.RandomPath;
            WinWordControlEx.SetWordStream(template.Content, path);
            if (@class.GetType().Equals(new Framework.Model.PlanLabor().GetType()))
            {
                WinWordControlEx.InsertTable(1, 3, array);
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMachine().GetType()))
            {
                WinWordControlEx.InsertTable(1, 3, array);
            }
            else if (@class.GetType().Equals(new Framework.Model.PlanMaterial().GetType()))
            {
                WinWordControlEx.InsertTable(1, 2, array);
            }
            else if (@class.GetType().Equals(new Framework.Model.ManageMember().GetType()))
            {
                WinWordControlEx.InsertTable(1, 2, array);
            }

            else if (@class.GetType().Equals(new Framework.Model.PrepareMaterial().GetType()))
            {
                  //WinWordControlEx.InsertTable(1, 3, array);//表显示,括号内三项含义依次为“文档中第1个表；从该表的第3行开始插入；向表中插入的数据”
                for (int i = 0; i < array.Count; i++)
                {
                    object[] obj = (object[])array[i];
                    if (i == (array.Count - 1))
                    {
                        WinWordControlEx.Replace("@1@", obj[1].ToString());
                    }
                    else
                    {
                        WinWordControlEx.Replace("@1@", obj[1].ToString() + "、@1@");
                    }
                }
            }

            else if (@class.GetType().Equals(new Framework.Model.PrepareMachineTool().GetType()))
            {
                //WinWordControlEx.InsertTable(1, 3, array);//表显示,括号内三项含义依次为“文档中第1个表；从该表的第3行开始插入；向表中插入的数据”
                for (int i = 0; i < array.Count; i++)
                {
                    object[] obj = (object[])array[i];

                    if (i == (array.Count - 1))
                    {
                        WinWordControlEx.Replace("@1@", obj[1].ToString());
                    }
                    else
                    {
                        WinWordControlEx.Replace("@1@", obj[1].ToString() + "、@1@");
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            element.SetAttribute("DOC", WinWordControlEx.GetWordString(path));
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

        private void WinWordControlEx_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnRedo_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
            System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));
            ShowFrmProfile(model, ass);
        }

        private void ShowFrmProfile(Framework.Entity.Model model, System.Reflection.Assembly ass)
        {
            FrmArrayList win = new FrmArrayList(chapter, ass.CreateInstance(model.Class));
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmArrayList.CreateModuleHandle(CreateModule);
            win.ShowDialog();
        }
    }
}