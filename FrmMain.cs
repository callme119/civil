namespace Framework
{
    public partial class FrmMain : DevComponents.DotNetBar.Office2007Form
    {
        private Framework.Implement.AuthorityImpl authorityService = new Framework.Implement.AuthorityImpl();
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private System.Xml.XmlDocument doc = null;

        public FrmMain()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
           
            
                System.Collections.ArrayList rootList = authorityService.GetRootModule(Framework.Entity.Module.MENU);
                foreach (Framework.Entity.Module root in rootList)
                {
                    DevComponents.DotNetBar.ButtonItem rootItem = new DevComponents.DotNetBar.ButtonItem();
                    rootItem.Text = root.Title;
                    BarMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { rootItem });
                    System.Collections.ArrayList childList = authorityService.GetModuleByPid(root.Id, Framework.Entity.Module.MENU);
                    DevComponents.DotNetBar.BaseItem[] baseItem = new DevComponents.DotNetBar.BaseItem[childList.Count];
                    int i = 0;
                    foreach (Framework.Entity.Module child in childList)
                    {
                        DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                        btnItem.Text = child.Title;
                        btnItem.Tag = child;
                        baseItem[i] = btnItem;
                        btnItem.Click += new System.EventHandler(delegate(object o, System.EventArgs a)
                        {
                            DevComponents.DotNetBar.ButtonItem btn = (DevComponents.DotNetBar.ButtonItem)o;
                            Framework.Entity.Module mod = (Framework.Entity.Module)btn.Tag;
                            CreateItem(mod.Title, mod.Class, null);
                        });
                        i++;
                    }
                    rootItem.SubItems.AddRange(baseItem);
                }
                CreateTheme("经典风格", DevComponents.DotNetBar.eStyle.Office2007VistaGlass);
                CreateTheme("淡蓝色风格", DevComponents.DotNetBar.eStyle.Office2007Blue);
                CreateTheme("银白色风格", DevComponents.DotNetBar.eStyle.Office2007Silver);
                CreateTheme("win7", DevComponents.DotNetBar.eStyle.Windows7Blue);

                ((DevComponents.DotNetBar.ButtonItem)BtnTheme.SubItems[0]).Checked = true;
            
           
               
            
        }

        private void CreateTheme(string title, DevComponents.DotNetBar.eStyle style)
        {
            DevComponents.DotNetBar.ButtonItem themeItem = new DevComponents.DotNetBar.ButtonItem();
            themeItem.Tag = style;
            themeItem.Text = title;
            themeItem.Click += new System.EventHandler(delegate(object o, System.EventArgs a)
            {
                foreach (DevComponents.DotNetBar.ButtonItem i in BtnTheme.SubItems)
                {
                    i.Checked = false;
                }
                DevComponents.DotNetBar.ButtonItem item = (DevComponents.DotNetBar.ButtonItem)o;
                item.Checked = true;
                StyleManager.ManagerStyle = (DevComponents.DotNetBar.eStyle)item.Tag;
            });
            BtnTheme.SubItems.AddRange(new DevComponents.DotNetBar.ButtonItem[] { themeItem });
        }

        private void CreateItem(string title, string @class, object arg)
        {
            if (!SelectItem(title))
            {
                DevComponents.DotNetBar.DockContainerItem dockItem = new DevComponents.DotNetBar.DockContainerItem();
                System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));
                System.Object obj;
                try
                {
                    obj = ass.CreateInstance(@class);
                    obj.GetType().GetProperty("Dock").SetValue(obj, System.Windows.Forms.DockStyle.Fill, null);
                    obj.GetType().GetProperty("Tag").SetValue(obj, arg, null);
                    if (arg != null)
                    {
                        System.Type type = ass.GetType(@class);
                        object @object = type.GetField("BtnAdd", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(obj);
                        if (@object != null)
                        {
                            DevComponents.DotNetBar.ButtonX btn = (DevComponents.DotNetBar.ButtonX)@object;
                            btn.Click += new System.EventHandler(delegate(object o, System.EventArgs a)
                            {
                                RefreshChapterTree();
                            });
                        }
                    }
                }
                catch
                {
                    obj = ass.CreateInstance("Framework.Interface.Common.UclError");
                    obj.GetType().GetProperty("Dock").SetValue(obj, System.Windows.Forms.DockStyle.Fill, null);
                }
                if ("".Equals(BarMain.Items[0].Text))
                {
                    DockPanelMain.Controls.Add((System.Windows.Forms.Control)obj);
               
                    DockItemMain.Text = title;
                }
                else
                {
                    DevComponents.DotNetBar.PanelDockContainer panel = new DevComponents.DotNetBar.PanelDockContainer();
                    panel.Controls.Add((System.Windows.Forms.Control)obj);
                    BarMain.Items.Add(dockItem);
                    BarMain.RecalcLayout();
                    dockItem.Text = title;
                    dockItem.Control = panel;
                    dockItem.Selected = true;
                }
            }
        }

        private bool SelectItem(string arg)
        {
            bool res = false;
            foreach (DevComponents.DotNetBar.DockContainerItem dock in BarMain.Items)
            {
                if (arg.Equals(dock.Text))
                {
                    dock.Visible = true;
                    dock.Selected = true;
                    res = true;
                }
            }
            return res;
        }

        private void MainManager_DockTabClosing(object sender, DevComponents.DotNetBar.DockTabClosingEventArgs e)
        {
            int i = 0;
            foreach (DevComponents.DotNetBar.DockContainerItem dock in BarMain.Items)
            {
                if (dock.Visible)
                {
                    i++;
                }
            }
            if (i == 1)
            {
                e.Cancel = true;
            }
        }

        private void RefreshChapterTree()
        {
            ChapterTree.Nodes.Clear();
            
            System.Xml.XmlNode content = doc.SelectSingleNode("PROJECT/CONTENT");
            
            DevComponents.AdvTree.Node rootNode = new DevComponents.AdvTree.Node(doc.SelectSingleNode("PROJECT/INFO/NAME").InnerText);
            rootNode.NodeDoubleClick += new System.EventHandler(delegate(object o, System.EventArgs a)//双击根节点，生成word文档
            {
                Framework.Interface.Project.FrmProjectShow win = new Framework.Interface.Project.FrmProjectShow();
                win.Show();  //显示生成文档的窗口
                win.InitForm();  //初始化.....
            });
            rootNode.Expanded = true;
            ChapterTree.Nodes.Add(rootNode);
            CreateChapterTree(content, rootNode);
        }

        private void CreateChapterTree(System.Xml.XmlNode xmlNode, DevComponents.AdvTree.Node treeNode)
        {
            foreach (System.Xml.XmlNode child in xmlNode.ChildNodes)
            {
                if (child.NodeType == System.Xml.XmlNodeType.Element)
                {
                    DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node(child.Value);
                    node.Text = child.Attributes["TITLE"].Value;
                    if (child.Attributes["RTF"] != null || child.Attributes["DOC"] != null)
                    {
                        node.Cells.Add(new DevComponents.AdvTree.Cell("(已编辑)"));
                    }
                    node.Tag = utilService.FindById(new Framework.Entity.Chapter(), System.Convert.ToInt32(child.Attributes["CID"].Value));
                    node.Expanded = false;
                    node.NodeDoubleClick += new System.EventHandler(delegate(object o, System.EventArgs a)
                    {
                        DevComponents.AdvTree.Node nd = (DevComponents.AdvTree.Node)o;
                        Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)nd.Tag;
                        System.Collections.ArrayList templateList = contentService.GetTemplateByChapter(chapter.Id);
                        if (templateList.Count != 0)
                        {
                            Framework.Entity.Module module = (Framework.Entity.Module)utilService.FindById(new Framework.Entity.Module(), chapter.Module);
                            CreateItem(chapter.Title, module.Class, ChapterTree.SelectedNode.Tag);
                        }
                    });
                    treeNode.Nodes.Add(node);
                    CreateChapterTree(child, node);

                }
                else
                {
                    CreateChapterTree(child, treeNode);
                }
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (doc == null)
            {
                doc = Framework.Class.XmlTool.GetInstance();
                System.Xml.XmlNode project = doc.CreateElement("PROJECT");
                doc.AppendChild(project);
                
                Framework.Interface.Project.FrmProjectInfo win = new Framework.Interface.Project.FrmProjectInfo();
                win.ShowDialog();
                //doc.Save("aaa.xml");
                RefreshChapterTree();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("不允许重复创建工程！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        private void BtnOpen_Click(object sender, System.EventArgs e)
        {
            if (doc == null)
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
                openFileDialog.FileName = "工程文档";
                openFileDialog.Filter = "工程文档(*.zm)|*.zm";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc = Framework.Class.XmlTool.GetInstance();
                    doc.Load(openFileDialog.FileName);
                    RefreshChapterTree();
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("已有工程打开！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (doc != null)
            {
                System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
                saveFileDialog.FileName = "工程文档";
                saveFileDialog.Filter = "工程文档(*.zm)|*.zm";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc.Save(saveFileDialog.FileName);
                    DevComponents.DotNetBar.MessageBoxEx.Show("保存完毕！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("工程未建立，无法保存！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        private void BtnHelp_Click(object sender, System.EventArgs e)
        {

        }

        private void SaveAlert()
        {
            if (doc != null)
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("尚未保存工程，是否立刻保存？", "提示", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    BtnSave_Click(this, null);
                }
            }
        }

        private void BtnRestart_Click(object sender, System.EventArgs e)//重启系统
        {
            SaveAlert();
            killProcess();
            System.Windows.Forms.Application.Restart();
        }

        private void BtnQuit_Click(object sender, System.EventArgs e)//退出系统
        {
            SaveAlert();
            killProcess();
            System.Windows.Forms.Application.Exit();
        }
        private void buttonItem1_Click(object sender, System.EventArgs e)//退出系统
        {
            
            Framework.Interface.Workbench.FrmAssessment win = new Framework.Interface.Workbench.FrmAssessment( );
            win.ShowDialog();
        }
        [System.Runtime.InteropServices.DllImport("User32.dll ", EntryPoint = "SetParent")]
        private static extern System.IntPtr SetParent(System.IntPtr hWndChild, System.IntPtr hWndNewParent);
        [System.Runtime.InteropServices.DllImport("user32.dll ", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(System.IntPtr hwnd, int nCmdShow);

        private void MapItem_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = System.Windows.Forms.Application.StartupPath + @"/soft/NetWorkEdit.exe";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            p.Start();
            System.Threading.Thread.Sleep(100);
            SetParent(p.MainWindowHandle, this.Handle);
            ShowWindow(p.MainWindowHandle, 3);
        }

        private void killProcess()
        {
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process item in ps)
            {
                //System.Windows.Forms.MessageBox.Show(item.ProcessName);
                if (item.ProcessName == "WINWORD" || item.ProcessName == "EXCEL.EXE")
                {
                    item.Kill();
                }
            }
        }

      

    }
}