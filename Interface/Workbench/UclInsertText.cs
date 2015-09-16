namespace Framework.Interface.Workbench
{
    public partial class UclInsertText : System.Windows.Forms.UserControl
    {
        private Framework.Entity.Chapter chapter;
        private string path;
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        Framework.Entity.Template tempInsertText;
        public UclInsertText()
        {
            InitializeComponent();
            this.Height = 550;
            this.Width = 740;
        }

        private void PnlButton_Click(object sender, System.EventArgs e)
        {

        }

        private void UclInsertText_Load(object sender, System.EventArgs e)
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

        private void CreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data)
        {
            path = WinWordControlEx.RandomPath;

            WinWordControlEx.CreateTempFile(template.Content, path);

            if (@class.GetType().Equals(new Framework.Model.InsertTextPileProject().GetType()))
            {
                WinWordControlEx.LoadWord(path);

                #region //选顶某“桩基工程”后，与其对应的内容自动生成在文档中的相应位置。
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[7].ToString()) - 1; i++)//data[7] = count,通过data[7].ToString()确定选择的工程的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$";//每添加一种工程，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord);//调用的是Replace(string strOldText,string strNewText, string path)

                for (int i = 0; i < System.Convert.ToInt16(data[7].ToString()); i++)//用文字图标等内容，把文档中的“$1$”替换掉
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$");//调用的是Replace(byte[] buffByte, string strOldText, string path)
                }
                #endregion


            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMeasure().GetType()))
            {
                WinWordControlEx.LoadWord(path);

                #region //选出“工程”后，与其对应的内容自动生成在文档中的相应位置。
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[7].ToString()) - 1; i++)//data[7] = count,通过data[7].ToString()确定选择的工程的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$";//每添加一种工程，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord, path);//调用的是Replace(string strOldText,string strNewText, string path)

                for (int i = 0; i < System.Convert.ToInt16(data[7].ToString()); i++)//用文字图标等内容，把文档中的“$1$”替换掉
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$");//调用的是Replace(byte[] buffByte, string strOldText, string path)
                }
                #endregion

                
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextWinterMaintain().GetType()))
            {
                WinWordControlEx.LoadWord(path);
                #region //选出“工程”后，与其对应的内容自动生成在文档中的相应位置。
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[2].ToString()) - 1; i++)//data[3] = count,通过data[7].ToString()确定选择的工程的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$";//每添加一种工程，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord, path);//调用的是Replace(string strOldText,string strNewText, string path)

                for (int i = 0; i < System.Convert.ToInt16(data[2].ToString()); i++)//用文字图标等内容，把文档中的“$1$”替换掉
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$");//调用的是Replace(byte[] buffByte, string strOldText, string path)
                }
                #endregion

                
            }
            else if (@class.GetType().Equals(new Framework.Model.InsertTextRoof().GetType()))
            {
                #region //确定有多少出要替换
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[8].ToString()) - 1; i++)//data[8] = count,通过data[8].ToString()确定选择的工程的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$";//每添加一种工程，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord, path);//调用的是Replace(string strOldText,string strNewText, string path)

                NewWord = "$2$";
                for (int i = 0; i < System.Convert.ToInt16(data[9].ToString()) - 1; i++)
                {
                    NewWord += "\n$2$";
                }
                WinWordControlEx.Replace("$2$", NewWord, path);

                NewWord = "$3$";
                for (int i = 0; i < System.Convert.ToInt16(data[9].ToString()) - 1; i++)
                {
                    NewWord += "\n$3$";
                }
                WinWordControlEx.Replace("$3$", NewWord, path);
                #endregion

                #region//替换文字
                for (int i = 0; i < System.Convert.ToInt16(data[8].ToString()); i++)
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$");//调用的是Replace(byte[] buffByte, string strOldText, string path)
                }

                for (int i = 0; i < System.Convert.ToInt16(data[9].ToString()); i++)
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i + 4].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$2$");
                }
                for (int i = 0; i < System.Convert.ToInt16(data[10].ToString()); i++)
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i + 6].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$3$");
                }
                #endregion

                WinWordControlEx.LoadWord(path);
            }
        }

        private void ReplaceString(string[] keys, object[] values)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                WinWordControlEx.Replace(keys[i], values[i].ToString());
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            element.SetAttribute("DOC", WinWordControlEx.GetWordString(path));
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

        private void BtnRedo_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
            System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));

            ShowFrmProfile(model, ass);
        }

        private void ShowFrmProfile(Framework.Entity.Model model, System.Reflection.Assembly ass)
        {
            FrmInsertText win = new FrmInsertText(chapter, ass.CreateInstance(model.Class));
            win.CreateModuleIntance += new Framework.Interface.Workbench.FrmInsertText.CreateModuleHandle(CreateModule);
            win.ShowDialog();

        }
    }
}