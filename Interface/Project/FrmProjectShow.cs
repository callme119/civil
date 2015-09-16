namespace Framework.Interface.Project
{
    public partial class FrmProjectShow : Framework.Interface.Common.FrmBase
    {
        private System.Xml.XmlDocument doc = Framework.Class.XmlTool.GetInstance();
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private System.Collections.Stack stack = new System.Collections.Stack();

        public FrmProjectShow()
        {
            InitializeComponent();
        }

        public void InitForm()
        {
            WinWordControlEx.CreateShowFile();
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(2);
            SearchChapter(Framework.Entity.Chapter.ROOT, 0, "");
            CreateDocument();
            //创建完doc后调出来再写好标题，最终解决办法了
            //WinWordControlEx.LoadWord(WinWordControlEx.ShowPath);
            //WinWordControlEx.SaveWord("Word.doc");
            WinWordControlEx.InsertBT();

            WinWordControlEx.LoadWord(WinWordControlEx.ShowPath);
            

            progressBar.Visible = false;//文档加载完成后，隐藏进度条
            lbl_waiter.Visible = false;//文档加载完成后，隐藏提示的lable标签
        }

        private void SearchChapter(int pid, int level, string prefix)
        {
            System.Collections.ArrayList templateList = contentService.GetChapterByPid(pid, Framework.Entity.Project.Type);
            int index = 0;
            foreach (Framework.Entity.Chapter chapter in templateList)
            {
                index++;
                System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
                element.SetAttribute("LEVEL", level.ToString());
                element.SetAttribute("INDEX", prefix + index.ToString());
                stack.Push(element);
                SearchChapter(chapter.Id, level + 1, prefix + (level + 1) + ".");
            }
        }

        private void CreateDocument()
        {
            object[] obj = stack.ToArray();
            for (int i = 0; i < obj.Length; i++)
            {
                System.Xml.XmlElement element = (System.Xml.XmlElement)obj[i];
                if (!"".Equals(element.GetAttribute("RTF")))
                {
                    WinWordControlEx.AddRtf(element.GetAttribute("RTF"));
                    WinWordControlEx.InsertTitle(element.GetAttribute("TITLE"), element.GetAttribute("INDEX"));
                }
                else if (!"".Equals(element.GetAttribute("DOC")))
                {
                    WinWordControlEx.AddDoc(element.GetAttribute("DOC"));
                    WinWordControlEx.InsertTitle(element.GetAttribute("TITLE"), element.GetAttribute("INDEX"));
                }
                else if ("0".Equals(element.GetAttribute("LEVEL")))
                {
                    WinWordControlEx.InsertTitle(element.GetAttribute("TITLE"), element.GetAttribute("INDEX"));
                }
                //element.("aaa.xml");
                
                progressBar.Value = (int)(i * 100 / obj.Length);//根据添加的内容的多少，进度条显示操作的执行进度

            }
        }
    }
}