namespace Framework.Interface.Workbench
{
    public partial class UclSelect : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chapter;

        public UclSelect()
        {
            InitializeComponent();
        }

        private void UclSelect_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            InitProjectPanel();
            InitSourcePanel();
            BtnOut_Click(this, null);
        }
        private void Inite()//初始化一下复选框,有想法还没能实现
        {
        
        
        
        }


        private void InitProjectPanel()
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            string content = Framework.Class.ConvertTool.ConvertRtfToString(element.GetAttribute("RTF"));
            string[] contentLines = content.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < contentLines.Length; i++)
            {
                Framework.Entity.Template template = contentService.GetTemplateByTitle(contentLines[i]);
                DevComponents.DotNetBar.CheckBoxItem item = new DevComponents.DotNetBar.CheckBoxItem();
                //z自动生成的checkbox，所涉及的代码是从元数据，是微软自带的不能修改，所以改字体
                
                item.Text = template.Title;
                item.Tag = template;
                IpnProject.Items.Add(item);
            }
        }

        private void InitSourcePanel()
        {
            System.Collections.ArrayList templateList = contentService.GetTemplateByChapter(chapter.Id);
            foreach (Framework.Entity.Template template in templateList)
            {
                DevComponents.DotNetBar.CheckBoxItem item = new DevComponents.DotNetBar.CheckBoxItem();
                item.Text = template.Title;
                item.Tag = template;
                item.DoubleClick += new System.EventHandler(delegate(object o, System.EventArgs a)
                {
                    System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\demo.chm");
               /*     if (item.Text == "《混凝土结构工程施工质量验收规范》GB50204-20021")
                    {
                        System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\混凝土结构工程施工质量验收规范.chm");

                    }
                */
                });
                IpnSource.Items.Add(item);
            }
        }

        private void BtnIn_Click(object sender, System.EventArgs e)
        {
            IpnProject.Items.Clear();
            foreach (DevComponents.DotNetBar.CheckBoxItem item in IpnSource.SelectedItems)
            {
                DevComponents.DotNetBar.CheckBoxItem newItem = new DevComponents.DotNetBar.CheckBoxItem();
                newItem.Text = item.Text;
                
                newItem.Tag = item.Tag;
                IpnProject.Items.Add(newItem);
            }
            IpnProject.Refresh();
        }

        private void BtnOut_Click(object sender, System.EventArgs e)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in IpnProject.SelectedItems)
            {
                IpnProject.Items.Remove(item);
            }
            IpnProject.Refresh();
            foreach (DevComponents.DotNetBar.CheckBoxItem itemSource in IpnSource.Items)
            {
                itemSource.Checked = false;
                foreach (DevComponents.DotNetBar.CheckBoxItem itemProject in IpnProject.Items)
                {
                    if (itemProject.Text == itemSource.Text)
                    {
                        itemSource.Checked = true;
                    }
                }
            }
            IpnSource.Refresh();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            string str = "";
            foreach (DevComponents.DotNetBar.CheckBoxItem ipnProject in IpnProject.Items)
            {
                str += "   " + ipnProject.Text + System.Environment.NewLine + System.Environment.NewLine;
            }
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            element.SetAttribute("RTF", Framework.Class.ConvertTool.ConvertStringToRtf(str));
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

    }
} 