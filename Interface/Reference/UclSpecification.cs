namespace Framework.Interface.Reference
{
    public partial class UclSpecification : System.Windows.Forms.UserControl
    {
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chapter;

        public UclSpecification()
        {
            InitializeComponent();
        }

        private void UclSpecification_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            InitPanel();
        }

        private void InitPanel()
        {
            System.Collections.ArrayList templateList = contentService.GetTemplateByChapter(chapter.Id);
            foreach (Framework.Entity.Template template in templateList)
            {
                //DevComponents.DotNetBar.CheckBoxItem item = new DevComponents.DotNetBar.CheckBoxItem();
                //item.Text = template.Title;
                //item.Tag = template;
                //items.DoubleClick += new System.EventHandler(delegate(object o, System.EventArgs a)
                //{
                //    System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\demo.chm");
                //    /*     if (item.Text == "《混凝土结构工程施工质量验收规范》GB50204-20021")
                //         {
                //             System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\混凝土结构工程施工质量验收规范.chm");

                //         }
                //     */
                //});
                //IpnSource.Items.Add(item);
                //itemPanel1.Items.Add(item);
            }
        }

        private void checkedListBox1_DoubleClick(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\demo.chm");
            if (checkedListBox1.SelectedItems.ToString() == "2")
            {
                System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\混凝土结构工程施工质量验收规范.chm");
            }
        }
    }
}