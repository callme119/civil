namespace Framework.Interface.Authority
{
    partial class UclModule
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
            this.GroupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.AdvTree = new DevComponents.AdvTree.AdvTree();
            this.NodeConnector = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle = new DevComponents.DotNetBar.ElementStyle();
            this.ContextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.TreeMenu = new DevComponents.DotNetBar.ButtonItem();
            this.MnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.MnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.MnModify = new DevComponents.DotNetBar.ButtonItem();
            this.cell1 = new DevComponents.AdvTree.Cell();
            this.cell2 = new DevComponents.AdvTree.Cell();
            this.GroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).BeginInit();
            this.AdvTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupPanel
            // 
            this.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.GroupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel.Controls.Add(this.AdvTree);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Padding = new System.Windows.Forms.Padding(4);
            this.GroupPanel.Size = new System.Drawing.Size(643, 380);
            // 
            // 
            // 
            this.GroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel.Style.BackColorGradientAngle = 90;
            this.GroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel.Style.BorderBottomWidth = 1;
            this.GroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel.Style.BorderLeftWidth = 1;
            this.GroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel.Style.BorderRightWidth = 1;
            this.GroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel.Style.BorderTopWidth = 1;
            this.GroupPanel.Style.Class = "";
            this.GroupPanel.Style.CornerDiameter = 4;
            this.GroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GroupPanel.StyleMouseDown.Class = "";
            this.GroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GroupPanel.StyleMouseOver.Class = "";
            this.GroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GroupPanel.TabIndex = 0;
            // 
            // AdvTree
            // 
            this.AdvTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree.AllowDrop = true;
            this.AdvTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ContextMenuBar.SetContextMenuEx(this.AdvTree, this.TreeMenu);
            this.AdvTree.Controls.Add(this.ContextMenuBar);
            this.AdvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.AdvTree.Location = new System.Drawing.Point(4, 4);
            this.AdvTree.Name = "AdvTree";
            this.AdvTree.NodesConnector = this.NodeConnector;
            this.AdvTree.NodeStyle = this.ElementStyle;
            this.AdvTree.PathSeparator = ";";
            this.AdvTree.Size = new System.Drawing.Size(629, 366);
            this.AdvTree.Styles.Add(this.ElementStyle);
            this.AdvTree.TabIndex = 1;
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
            // ContextMenuBar
            // 
            this.ContextMenuBar.AntiAlias = true;
            this.ContextMenuBar.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ContextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TreeMenu});
            this.ContextMenuBar.Location = new System.Drawing.Point(0, 0);
            this.ContextMenuBar.Name = "ContextMenuBar";
            this.ContextMenuBar.Size = new System.Drawing.Size(75, 25);
            this.ContextMenuBar.Stretch = true;
            this.ContextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar.TabIndex = 1;
            this.ContextMenuBar.TabStop = false;
            this.ContextMenuBar.Text = "contextMenuBar1";
            this.ContextMenuBar.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.ContextMenuBar_PopupOpen);
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
            // 
            // MnAdd
            // 
            this.MnAdd.Name = "MnAdd";
            this.MnAdd.Text = "添加模块";
            this.MnAdd.Click += new System.EventHandler(this.MnAdd_Click);
            // 
            // MnDelete
            // 
            this.MnDelete.Name = "MnDelete";
            this.MnDelete.Text = "删除模块";
            this.MnDelete.Click += new System.EventHandler(this.MnDelete_Click);
            // 
            // MnModify
            // 
            this.MnModify.Name = "MnModify";
            this.MnModify.Text = "修改模块";
            this.MnModify.Click += new System.EventHandler(this.MnModify_Click);
            // 
            // cell1
            // 
            this.cell1.Name = "cell1";
            this.cell1.StyleMouseOver = null;
            // 
            // cell2
            // 
            this.cell2.Name = "cell2";
            this.cell2.StyleMouseOver = null;
            // 
            // UclModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.GroupPanel);
            this.Name = "UclModule";
            this.Size = new System.Drawing.Size(643, 380);
            this.Load += new System.EventHandler(this.UclModule_Load);
            this.GroupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).EndInit();
            this.AdvTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel;
        private DevComponents.AdvTree.AdvTree AdvTree;
        private DevComponents.AdvTree.NodeConnector NodeConnector;
        private DevComponents.DotNetBar.ElementStyle ElementStyle;
        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar;
        private DevComponents.DotNetBar.ButtonItem TreeMenu;
        private DevComponents.DotNetBar.ButtonItem MnAdd;
        private DevComponents.DotNetBar.ButtonItem MnDelete;
        private DevComponents.DotNetBar.ButtonItem MnModify;
        private DevComponents.AdvTree.Cell cell1;
        private DevComponents.AdvTree.Cell cell2;

    }
}