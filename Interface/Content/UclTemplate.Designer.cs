namespace Framework.Interface.Content
{
    partial class UclTemplate
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ContextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.TreeMenu = new DevComponents.DotNetBar.ButtonItem();
            this.MnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.MnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.MnModify = new DevComponents.DotNetBar.ButtonItem();
            this.TreeTemplate = new DevComponents.AdvTree.AdvTree();
            this.ColId = new DevComponents.AdvTree.ColumnHeader();
            this.ColTitle = new DevComponents.AdvTree.ColumnHeader();
            this.ColKey = new DevComponents.AdvTree.ColumnHeader();
            this.ColState = new DevComponents.AdvTree.ColumnHeader();
            this.StyleTemplate = new DevComponents.DotNetBar.ElementStyle();
            this.GpnChapter = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TreeChapter = new DevComponents.AdvTree.AdvTree();
            this.NodeConnector = new DevComponents.AdvTree.NodeConnector();
            this.StyleChapter = new DevComponents.DotNetBar.ElementStyle();
            this.Splitter = new DevComponents.DotNetBar.ExpandableSplitter();
            this.GpnTemplate = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTemplate)).BeginInit();
            this.GpnChapter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeChapter)).BeginInit();
            this.GpnTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuBar
            // 
            this.ContextMenuBar.AntiAlias = true;
            this.ContextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TreeMenu});
            this.ContextMenuBar.Location = new System.Drawing.Point(0, 0);
            this.ContextMenuBar.Name = "ContextMenuBar";
            this.ContextMenuBar.Size = new System.Drawing.Size(75, 25);
            this.ContextMenuBar.Stretch = true;
            this.ContextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar.TabIndex = 2;
            this.ContextMenuBar.TabStop = false;
            // 
            // TreeMenu
            // 
            this.TreeMenu.AutoExpandOnClick = true;
            this.TreeMenu.Name = "TreeMenu";
            this.TreeMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.MnAdd,
            this.MnDelete,
            this.MnModify});
            this.TreeMenu.Text = "菜单";
            this.TreeMenu.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.TreeMenu_PopupOpen);
            // 
            // MnAdd
            // 
            this.MnAdd.Name = "MnAdd";
            this.MnAdd.Text = "添加模板";
            this.MnAdd.Click += new System.EventHandler(this.MnAdd_Click);
            // 
            // MnDelete
            // 
            this.MnDelete.Name = "MnDelete";
            this.MnDelete.Text = "删除模板";
            this.MnDelete.Click += new System.EventHandler(this.MnDelete_Click);
            // 
            // MnModify
            // 
            this.MnModify.Name = "MnModify";
            this.MnModify.Text = "修改模板";
            this.MnModify.Click += new System.EventHandler(this.MnModify_Click);
            // 
            // TreeTemplate
            // 
            this.TreeTemplate.AllowDrop = true;
            this.TreeTemplate.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.TreeTemplate.BackgroundStyle.Class = "TreeBorderKey";
            this.TreeTemplate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TreeTemplate.Columns.Add(this.ColId);
            this.TreeTemplate.Columns.Add(this.ColTitle);
            this.TreeTemplate.Columns.Add(this.ColKey);
            this.TreeTemplate.Columns.Add(this.ColState);
            this.ContextMenuBar.SetContextMenuEx(this.TreeTemplate, this.TreeMenu);
            this.TreeTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeTemplate.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.TreeTemplate.ExpandWidth = 14;
            this.TreeTemplate.HotTracking = true;
            this.TreeTemplate.Location = new System.Drawing.Point(0, 0);
            this.TreeTemplate.Name = "TreeTemplate";
            this.TreeTemplate.NodeStyle = this.StyleTemplate;
            this.TreeTemplate.PathSeparator = ";";
            this.TreeTemplate.Size = new System.Drawing.Size(437, 346);
            this.TreeTemplate.Styles.Add(this.StyleTemplate);
            this.TreeTemplate.TabIndex = 4;
            // 
            // ColId
            // 
            this.ColId.Name = "ColId";
            this.ColId.Text = "序号";
            this.ColId.Width.Relative = 10;
            // 
            // ColTitle
            // 
            this.ColTitle.Name = "ColTitle";
            this.ColTitle.Text = "标题";
            this.ColTitle.Width.Relative = 45;
            // 
            // ColKey
            // 
            this.ColKey.Name = "ColKey";
            this.ColKey.Text = "关键字";
            this.ColKey.Width.Relative = 35;
            // 
            // ColState
            // 
            this.ColState.Name = "ColState";
            this.ColState.Text = "状态";
            this.ColState.Width.Relative = 10;
            // 
            // StyleTemplate
            // 
            this.StyleTemplate.Class = "";
            this.StyleTemplate.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StyleTemplate.Name = "StyleTemplate";
            this.StyleTemplate.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // GpnChapter
            // 
            this.GpnChapter.CanvasColor = System.Drawing.SystemColors.Control;
            this.GpnChapter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GpnChapter.Controls.Add(this.TreeChapter);
            this.GpnChapter.Dock = System.Windows.Forms.DockStyle.Left;
            this.GpnChapter.Location = new System.Drawing.Point(0, 0);
            this.GpnChapter.Name = "GpnChapter";
            this.GpnChapter.Size = new System.Drawing.Size(200, 352);
            // 
            // 
            // 
            this.GpnChapter.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GpnChapter.Style.BackColorGradientAngle = 90;
            this.GpnChapter.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GpnChapter.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnChapter.Style.BorderBottomWidth = 1;
            this.GpnChapter.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GpnChapter.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnChapter.Style.BorderLeftWidth = 1;
            this.GpnChapter.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnChapter.Style.BorderRightWidth = 1;
            this.GpnChapter.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnChapter.Style.BorderTopWidth = 1;
            this.GpnChapter.Style.Class = "";
            this.GpnChapter.Style.CornerDiameter = 4;
            this.GpnChapter.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GpnChapter.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GpnChapter.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GpnChapter.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GpnChapter.StyleMouseDown.Class = "";
            this.GpnChapter.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GpnChapter.StyleMouseOver.Class = "";
            this.GpnChapter.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GpnChapter.TabIndex = 0;
            // 
            // TreeChapter
            // 
            this.TreeChapter.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.TreeChapter.AllowDrop = true;
            this.TreeChapter.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.TreeChapter.BackgroundStyle.Class = "TreeBorderKey";
            this.TreeChapter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TreeChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeChapter.Location = new System.Drawing.Point(0, 0);
            this.TreeChapter.Name = "TreeChapter";
            this.TreeChapter.NodesConnector = this.NodeConnector;
            this.TreeChapter.NodeStyle = this.StyleChapter;
            this.TreeChapter.PathSeparator = ";";
            this.TreeChapter.Size = new System.Drawing.Size(194, 346);
            this.TreeChapter.Styles.Add(this.StyleChapter);
            this.TreeChapter.TabIndex = 1;
            // 
            // NodeConnector
            // 
            this.NodeConnector.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // StyleChapter
            // 
            this.StyleChapter.Class = "";
            this.StyleChapter.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StyleChapter.Name = "StyleChapter";
            this.StyleChapter.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // Splitter
            // 
            this.Splitter.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.Splitter.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Splitter.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Splitter.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.Splitter.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Splitter.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Splitter.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.Splitter.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Splitter.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.Splitter.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Splitter.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Splitter.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.Splitter.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(179)))), ((int)(((byte)(219)))));
            this.Splitter.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.Splitter.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.Splitter.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.Splitter.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Splitter.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Splitter.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.Splitter.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.Splitter.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Splitter.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Splitter.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Splitter.Location = new System.Drawing.Point(200, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(6, 352);
            this.Splitter.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.Splitter.TabIndex = 2;
            this.Splitter.TabStop = false;
            // 
            // GpnTemplate
            // 
            this.GpnTemplate.CanvasColor = System.Drawing.SystemColors.Control;
            this.GpnTemplate.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GpnTemplate.Controls.Add(this.TreeTemplate);
            this.GpnTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpnTemplate.Location = new System.Drawing.Point(206, 0);
            this.GpnTemplate.Name = "GpnTemplate";
            this.GpnTemplate.Size = new System.Drawing.Size(443, 352);
            // 
            // 
            // 
            this.GpnTemplate.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GpnTemplate.Style.BackColorGradientAngle = 90;
            this.GpnTemplate.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GpnTemplate.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnTemplate.Style.BorderBottomWidth = 1;
            this.GpnTemplate.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GpnTemplate.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnTemplate.Style.BorderLeftWidth = 1;
            this.GpnTemplate.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnTemplate.Style.BorderRightWidth = 1;
            this.GpnTemplate.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GpnTemplate.Style.BorderTopWidth = 1;
            this.GpnTemplate.Style.Class = "";
            this.GpnTemplate.Style.CornerDiameter = 4;
            this.GpnTemplate.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GpnTemplate.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GpnTemplate.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GpnTemplate.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GpnTemplate.StyleMouseDown.Class = "";
            this.GpnTemplate.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GpnTemplate.StyleMouseOver.Class = "";
            this.GpnTemplate.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GpnTemplate.TabIndex = 3;
            // 
            // UclTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GpnTemplate);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.ContextMenuBar);
            this.Controls.Add(this.GpnChapter);
            this.Name = "UclTemplate";
            this.Size = new System.Drawing.Size(649, 352);
            this.Load += new System.EventHandler(this.UclTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeTemplate)).EndInit();
            this.GpnChapter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreeChapter)).EndInit();
            this.GpnTemplate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar;
        private DevComponents.DotNetBar.ButtonItem TreeMenu;
        private DevComponents.DotNetBar.ButtonItem MnAdd;
        private DevComponents.DotNetBar.ButtonItem MnDelete;
        private DevComponents.DotNetBar.ButtonItem MnModify;
        private DevComponents.DotNetBar.Controls.GroupPanel GpnChapter;
        private DevComponents.DotNetBar.ExpandableSplitter Splitter;
        private DevComponents.DotNetBar.Controls.GroupPanel GpnTemplate;
        private DevComponents.AdvTree.AdvTree TreeTemplate;
        private DevComponents.AdvTree.ColumnHeader ColId;
        private DevComponents.AdvTree.ColumnHeader ColTitle;
        private DevComponents.AdvTree.ColumnHeader ColKey;
        private DevComponents.DotNetBar.ElementStyle StyleTemplate;
        private DevComponents.AdvTree.ColumnHeader ColState;
        private DevComponents.AdvTree.AdvTree TreeChapter;
        private DevComponents.AdvTree.NodeConnector NodeConnector;
        private DevComponents.DotNetBar.ElementStyle StyleChapter;

    }
}