namespace Framework
{
    partial class FrmMain1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.DockSiteMain = new DevComponents.DotNetBar.DockSite();
            this.BarMain = new DevComponents.DotNetBar.Bar();
            this.DockPanelMain = new DevComponents.DotNetBar.PanelDockContainer();
            this.DockItemMain = new DevComponents.DotNetBar.DockContainerItem();
            this.DockSiteView = new DevComponents.DotNetBar.DockSite();
            this.BarView = new DevComponents.DotNetBar.Bar();
            this.DockPanelView = new DevComponents.DotNetBar.PanelDockContainer();
            this.ChapterTree = new DevComponents.AdvTree.AdvTree();
            this.NodeConnector = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle = new DevComponents.DotNetBar.ElementStyle();
            this.DockItemView = new DevComponents.DotNetBar.DockContainerItem();
            this.DockSiteMenu = new DevComponents.DotNetBar.DockSite();
            this.BarMenu = new DevComponents.DotNetBar.Bar();
            this.BarTool = new DevComponents.DotNetBar.Bar();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.BtnOpen = new DevComponents.DotNetBar.ButtonItem();
            this.BtnSave = new DevComponents.DotNetBar.ButtonItem();
            this.BtnProperty = new DevComponents.DotNetBar.ButtonItem();
            this.BtnSetting = new DevComponents.DotNetBar.ButtonItem();
            this.BtnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BtnShortcut = new DevComponents.DotNetBar.ButtonItem();
            this.BtnDate = new DevComponents.DotNetBar.ButtonItem();
            this.BtnSoft = new DevComponents.DotNetBar.ButtonItem();
            this.MapItem = new DevComponents.DotNetBar.ButtonItem();
            this.BtnTheme = new DevComponents.DotNetBar.ButtonItem();
            this.BtnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.BtnRestart = new DevComponents.DotNetBar.ButtonItem();
            this.BtnQuit = new DevComponents.DotNetBar.ButtonItem();
            this.StyleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.DockSiteMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).BeginInit();
            this.BarMain.SuspendLayout();
            this.DockSiteView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarView)).BeginInit();
            this.BarView.SuspendLayout();
            this.DockPanelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChapterTree)).BeginInit();
            this.DockSiteMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarTool)).BeginInit();
            this.SuspendLayout();
            // 
            // MainManager
            // 
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.MainManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.MainManager.BottomDockSite = null;
            this.MainManager.EnableFullSizeDock = false;
            this.MainManager.FillDockSite = this.DockSiteMain;
            this.MainManager.LeftDockSite = null;
            this.MainManager.ParentForm = this;
            this.MainManager.RightDockSite = this.DockSiteView;
            this.MainManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MainManager.ToolbarTopDockSite = this.DockSiteMenu;
            this.MainManager.TopDockSite = null;
            // 
            // DockSiteMain
            // 
            this.DockSiteMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSiteMain.Controls.Add(this.BarMain);
            this.DockSiteMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockSiteMain.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.BarMain, 609, 435)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.DockSiteMain.Location = new System.Drawing.Point(0, 84);
            this.DockSiteMain.Name = "DockSiteMain";
            this.DockSiteMain.Size = new System.Drawing.Size(609, 435);
            this.DockSiteMain.TabIndex = 1;
            this.DockSiteMain.TabStop = false;
            // 
            // BarMain
            // 
            this.BarMain.AccessibleDescription = "DotNetBar Bar (BarMain)";
            this.BarMain.AccessibleName = "DotNetBar Bar";
            this.BarMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.BarMain.AlwaysDisplayDockTab = true;
            this.BarMain.CanCustomize = false;
            this.BarMain.CanDockBottom = false;
            this.BarMain.CanDockDocument = true;
            this.BarMain.CanDockLeft = false;
            this.BarMain.CanDockRight = false;
            this.BarMain.CanDockTop = false;
            this.BarMain.CanHide = true;
            this.BarMain.CanUndock = false;
            this.BarMain.Controls.Add(this.DockPanelMain);
            this.BarMain.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.BarMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BarMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.DockItemMain});
            this.BarMain.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.BarMain.Location = new System.Drawing.Point(0, 0);
            this.BarMain.Name = "BarMain";
            this.BarMain.SelectedDockTab = 0;
            this.BarMain.Size = new System.Drawing.Size(609, 435);
            this.BarMain.Stretch = true;
            this.BarMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarMain.TabIndex = 0;
            this.BarMain.TabNavigation = true;
            this.BarMain.TabStop = false;
            // 
            // DockPanelMain
            // 
            this.DockPanelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DockPanelMain.Location = new System.Drawing.Point(3, 28);
            this.DockPanelMain.Name = "DockPanelMain";
            this.DockPanelMain.Size = new System.Drawing.Size(603, 404);
            this.DockPanelMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.DockPanelMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DockPanelMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DockPanelMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.DockPanelMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.DockPanelMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.DockPanelMain.Style.GradientAngle = 90;
            this.DockPanelMain.TabIndex = 2;
            // 
            // DockItemMain
            // 
            this.DockItemMain.Control = this.DockPanelMain;
            this.DockItemMain.Name = "DockItemMain";
            // 
            // DockSiteView
            // 
            this.DockSiteView.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSiteView.Controls.Add(this.BarView);
            this.DockSiteView.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockSiteView.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.BarView, 243, 435)))}, DevComponents.DotNetBar.eOrientation.Horizontal);
            this.DockSiteView.Location = new System.Drawing.Point(609, 84);
            this.DockSiteView.Name = "DockSiteView";
            this.DockSiteView.Size = new System.Drawing.Size(246, 435);
            this.DockSiteView.TabIndex = 3;
            this.DockSiteView.TabStop = false;
            // 
            // BarView
            // 
            this.BarView.AccessibleDescription = "DotNetBar Bar (BarView)";
            this.BarView.AccessibleName = "DotNetBar Bar";
            this.BarView.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.BarView.AutoSyncBarCaption = true;
            this.BarView.CloseSingleTab = true;
            this.BarView.Controls.Add(this.DockPanelView);
            this.BarView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BarView.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.BarView.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.DockItemView});
            this.BarView.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.BarView.Location = new System.Drawing.Point(3, 0);
            this.BarView.Name = "BarView";
            this.BarView.Size = new System.Drawing.Size(243, 435);
            this.BarView.Stretch = true;
            this.BarView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarView.TabIndex = 0;
            this.BarView.TabStop = false;
            this.BarView.Text = "视图栏";
            // 
            // DockPanelView
            // 
            this.DockPanelView.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DockPanelView.Controls.Add(this.ChapterTree);
            this.DockPanelView.Location = new System.Drawing.Point(3, 23);
            this.DockPanelView.Name = "DockPanelView";
            this.DockPanelView.Size = new System.Drawing.Size(237, 409);
            this.DockPanelView.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.DockPanelView.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DockPanelView.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DockPanelView.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.DockPanelView.Style.GradientAngle = 90;
            this.DockPanelView.TabIndex = 4;
            // 
            // ChapterTree
            // 
            this.ChapterTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.ChapterTree.AllowDrop = true;
            this.ChapterTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ChapterTree.BackgroundStyle.Class = "TreeBorderKey";
            this.ChapterTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ChapterTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChapterTree.Location = new System.Drawing.Point(0, 0);
            this.ChapterTree.Name = "ChapterTree";
            this.ChapterTree.NodesConnector = this.NodeConnector;
            this.ChapterTree.NodeStyle = this.ElementStyle;
            this.ChapterTree.PathSeparator = ";";
            this.ChapterTree.Size = new System.Drawing.Size(237, 409);
            this.ChapterTree.Styles.Add(this.ElementStyle);
            this.ChapterTree.TabIndex = 5;
            // 
            // NodeConnector
            // 
            this.NodeConnector.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle
            // 
            this.ElementStyle.Class = "";
            this.ElementStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle.Name = "ElementStyle";
            this.ElementStyle.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // DockItemView
            // 
            this.DockItemView.Control = this.DockPanelView;
            this.DockItemView.Name = "DockItemView";
            this.DockItemView.Text = "视图栏";
            // 
            // DockSiteMenu
            // 
            this.DockSiteMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSiteMenu.Controls.Add(this.BarMenu);
            this.DockSiteMenu.Controls.Add(this.BarTool);
            this.DockSiteMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DockSiteMenu.Location = new System.Drawing.Point(0, 0);
            this.DockSiteMenu.Name = "DockSiteMenu";
            this.DockSiteMenu.Size = new System.Drawing.Size(855, 84);
            this.DockSiteMenu.TabIndex = 0;
            this.DockSiteMenu.TabStop = false;
            // 
            // BarMenu
            // 
            this.BarMenu.AccessibleDescription = "DotNetBar Bar (BarMenu)";
            this.BarMenu.AccessibleName = "DotNetBar Bar";
            this.BarMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BarMenu.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.BarMenu.Location = new System.Drawing.Point(0, 0);
            this.BarMenu.MenuBar = true;
            this.BarMenu.Name = "BarMenu";
            this.BarMenu.Size = new System.Drawing.Size(36, 24);
            this.BarMenu.Stretch = true;
            this.BarMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarMenu.TabIndex = 0;
            this.BarMenu.TabStop = false;
            // 
            // BarTool
            // 
            this.BarTool.AccessibleDescription = "DotNetBar Bar (BarTool)";
            this.BarTool.AccessibleName = "DotNetBar Bar";
            this.BarTool.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.BarTool.DockLine = 1;
            this.BarTool.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.BarTool.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.BarTool.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BtnAdd,
            this.BtnOpen,
            this.BtnSave,
            this.BtnProperty,
            this.BtnSetting,
            this.BtnSearch,
            this.BtnShortcut,
            this.BtnDate,
            this.BtnSoft,
            this.BtnTheme,
            this.buttonItem1,
            this.BtnHelp,
            this.BtnRestart,
            this.BtnQuit,
            });
            this.BarTool.Location = new System.Drawing.Point(0, 25);
            this.BarTool.Name = "BarTool";
            this.BarTool.Size = new System.Drawing.Size(855, 59);
            this.BarTool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarTool.TabIndex = 1;
            this.BarTool.TabStop = false;
            this.BarTool.Text = "工具栏";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = global::Framework.Properties.Resources.New;
            this.BtnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Text = "新建工程";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Image = global::Framework.Properties.Resources.Open;
            this.BtnOpen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Text = "打开工程";
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Framework.Properties.Resources.Save;
            this.BtnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Text = "保存工程";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnProperty
            // 
            this.BtnProperty.Image = global::Framework.Properties.Resources.Property;
            this.BtnProperty.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnProperty.Name = "BtnProperty";
            this.BtnProperty.Text = "工程属性";
            // 
            // BtnSetting
            // 
            this.BtnSetting.Image = global::Framework.Properties.Resources.Setting;
            this.BtnSetting.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Text = "系统设置";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::Framework.Properties.Resources.Search;
            this.BtnSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Text = "资源检索";
            // 
            // BtnShortcut
            // 
            this.BtnShortcut.Image = global::Framework.Properties.Resources.Shortcut;
            this.BtnShortcut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnShortcut.Name = "BtnShortcut";
            this.BtnShortcut.Text = "快捷方式";
            // 
            // BtnDate
            // 
            this.BtnDate.Image = global::Framework.Properties.Resources.Date;
            this.BtnDate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Text = "日期提示";
            // 
            // BtnSoft
            // 
            this.BtnSoft.Image = global::Framework.Properties.Resources.Calculator;
            this.BtnSoft.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnSoft.Name = "BtnSoft";
            this.BtnSoft.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MapItem});
            this.BtnSoft.Text = "工具软件";
            // 
            // MapItem
            // 
            this.MapItem.Name = "MapItem";
            this.MapItem.Text = "流程图生成软件";
            this.MapItem.Click += new System.EventHandler(this.MapItem_Click);
            // 
            // BtnTheme
            // 
            this.BtnTheme.Image = global::Framework.Properties.Resources.Theme;
            this.BtnTheme.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnTheme.Name = "BtnTheme";
            this.BtnTheme.Text = "主题风格";
            // 
            // BtnHelp
            // 
            this.BtnHelp.Image = global::Framework.Properties.Resources.Help;
            this.BtnHelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Text = "帮助文档";
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Image = global::Framework.Properties.Resources.Restart;
            this.BtnRestart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Text = "重启系统";
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Image = global::Framework.Properties.Resources.Quit;
            this.BtnQuit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Text = "退出系统";
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::Framework.Properties.Resources.f;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "综合评价";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // FrmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 519);
            this.Controls.Add(this.DockSiteMain);
            this.Controls.Add(this.DockSiteView);
            this.Controls.Add(this.DockSiteMenu);
            this.DoubleBuffered = true;
            this.Name = "FrmMain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统框架";
            this.Load += new System.EventHandler(this.FrmMain1_Load);
            this.DockSiteMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarMain)).EndInit();
            this.BarMain.ResumeLayout(false);
            this.DockSiteView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarView)).EndInit();
            this.BarView.ResumeLayout(false);
            this.DockPanelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChapterTree)).EndInit();
            this.DockSiteMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarTool)).EndInit();
            this.ResumeLayout(false);

        }
        private DevComponents.DotNetBar.DotNetBarManager MainManager;
        private DevComponents.DotNetBar.DockSite DockSiteMain;
        private DevComponents.DotNetBar.Bar BarMain;
        private DevComponents.DotNetBar.PanelDockContainer DockPanelMain;
        private DevComponents.DotNetBar.DockContainerItem DockItemMain;
        private DevComponents.DotNetBar.DockSite DockSiteView;
        private DevComponents.DotNetBar.Bar BarView;
        private DevComponents.DotNetBar.PanelDockContainer DockPanelView;
        private DevComponents.DotNetBar.DockContainerItem DockItemView;
        private DevComponents.DotNetBar.DockSite DockSiteMenu;
        private DevComponents.DotNetBar.Bar BarMenu;
        private DevComponents.DotNetBar.Bar BarTool;
        private DevComponents.DotNetBar.ButtonItem BtnAdd;
        private DevComponents.DotNetBar.ButtonItem BtnOpen;
        private DevComponents.DotNetBar.ButtonItem BtnProperty;
        private DevComponents.DotNetBar.ButtonItem BtnSetting;
        private DevComponents.DotNetBar.ButtonItem BtnSearch;
        private DevComponents.DotNetBar.ButtonItem BtnDate;
        private DevComponents.DotNetBar.ButtonItem BtnSoft;
        private DevComponents.DotNetBar.ButtonItem BtnTheme;
        private DevComponents.DotNetBar.ButtonItem BtnShortcut;
        private DevComponents.DotNetBar.ButtonItem BtnQuit;
        private DevComponents.DotNetBar.ButtonItem BtnSave;
        private DevComponents.AdvTree.AdvTree ChapterTree;
        private DevComponents.AdvTree.NodeConnector NodeConnector;
        private DevComponents.DotNetBar.ElementStyle ElementStyle;
        private DevComponents.DotNetBar.StyleManager StyleManager;
        private DevComponents.DotNetBar.ButtonItem BtnRestart;
        private DevComponents.DotNetBar.ButtonItem BtnHelp;
        private DevComponents.DotNetBar.ButtonItem MapItem;


        #endregion
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}