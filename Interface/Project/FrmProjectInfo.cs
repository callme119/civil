namespace Framework.Interface.Project
{
    public partial class FrmProjectInfo : Framework.Interface.Common.FrmBase
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private System.Xml.XmlDocument doc = Framework.Class.XmlTool.GetInstance();

        public FrmProjectInfo()
        {
            InitializeComponent();
        }

        private void FrmProjectInfo_Load(object sender, System.EventArgs e)
        {
            CbxType.Items.Add("基本工程类型");
            CbxType.Items.Add("脚手架专项工程");
            CbxType.SelectedIndex = 0;
        }

        private void CreateInfoNode(ref System.Xml.XmlNode node)
        {
            System.Xml.XmlNode infoNode = doc.CreateElement("INFO");
            System.Xml.XmlNode nameNode = doc.CreateElement("NAME");
            System.Xml.XmlNode typeNode = doc.CreateElement("TYPE");
            nameNode.InnerText = TbxName.Text;
            typeNode.InnerText = CbxType.SelectedItem.ToString();
            infoNode.AppendChild(nameNode);
            infoNode.AppendChild(typeNode);
            node.AppendChild(infoNode);
        }

        private void CreateContentNode(ref System.Xml.XmlNode node)
        {
            System.Xml.XmlNode content = doc.CreateElement("CONTENT");
            node.AppendChild(content);
            CreateChapterNode(0, content);
        }

        private void CreateChapterNode(int pid, System.Xml.XmlNode node)
        {
            System.Collections.ArrayList chapterList = contentService.GetChapterByPid(pid, Framework.Entity.Project.Type);
            foreach (Framework.Entity.Chapter chapter in chapterList)
            {
                System.Xml.XmlElement element = doc.CreateElement("CHAPTER");
                element.SetAttribute("CID", System.Convert.ToString(chapter.Id));
                element.SetAttribute("TITLE", chapter.Title);
                node.AppendChild(element);
                CreateChapterNode(chapter.Id, element);
            }
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            if (CbxType.SelectedIndex == 1)
            {
                Framework.Entity.Project.Type = 1;
            }
            else
                Framework.Entity.Project.Type = 0;
            System.Xml.XmlNode project = doc.SelectSingleNode("PROJECT"); ;
            CreateInfoNode(ref project);
            CreateContentNode(ref project);
            this.Close();
        }
    }
}