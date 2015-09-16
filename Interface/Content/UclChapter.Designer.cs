namespace Framework.Interface.Content
{
    partial class UclChapter
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
            this.AdvTree = new DevComponents.AdvTree.AdvTree();
            this.ColName = new DevComponents.AdvTree.ColumnHeader();
            this.ColDescription = new DevComponents.AdvTree.ColumnHeader();
            this.ColState = new DevComponents.AdvTree.ColumnHeader();
            this.ElementStyle = new DevComponents.DotNetBar.ElementStyle();
            this.ContextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.TreeMenu = new DevComponents.DotNetBar.ButtonItem();
            this.MnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.MnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.MnModify = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvTree
            // 
            this.AdvTree.AllowDrop = true;
            this.AdvTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree.Columns.Add(this.ColName);
            this.AdvTree.Columns.Add(this.ColDescription);
            this.AdvTree.Columns.Add(this.ColState);
            this.ContextMenuBar.SetContextMenuEx(this.AdvTree, this.TreeMenu);
            this.AdvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.AdvTree.ExpandWidth = 14;
            this.AdvTree.HotTracking = true;
            this.AdvTree.Location = new System.Drawing.Point(0, 0);
            this.AdvTree.Name = "AdvTree";
            this.AdvTree.NodeStyle = this.ElementStyle;
            this.AdvTree.PathSeparator = ";";
            this.AdvTree.Size = new System.Drawing.Size(671, 371);
            this.AdvTree.Styles.Add(this.ElementStyle);
            this.AdvTree.TabIndex = 0;
            // 
            // ColName
            // 
            this.ColName.Name = "ColName";
            this.ColName.Text = "标题";
            this.ColName.Width.Relative = 35;
            // 
            // ColDescription
            // 
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Text = "描述";
            this.ColDescription.Width.Relative = 55;
            // 
            // ColState
            // 
            this.ColState.Name = "ColState";
            this.ColState.Text = "状态";
            this.ColState.Width.Relative = 10;
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
            this.ContextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TreeMenu});
            this.ContextMenuBar.Location = new System.Drawing.Point(0, 0);
            this.ContextMenuBar.Name = "ContextMenuBar";
            this.ContextMenuBar.Size = new System.Drawing.Size(75, 25);
            this.ContextMenuBar.Stretch = true;
            this.ContextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ContextMenuBar.TabIndex = 0;
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
            this.MnAdd.Text = "添加章节";
            this.MnAdd.Click += new System.EventHandler(this.MnAdd_Click);
            // 
            // MnDelete
            // 
            this.MnDelete.Name = "MnDelete";
            this.MnDelete.Text = "删除章节";
            this.MnDelete.Click += new System.EventHandler(this.MnDelete_Click);
            // 
            // MnModify
            // 
            this.MnModify.Name = "MnModify";
            this.MnModify.Text = "修改章节";
            this.MnModify.Click += new System.EventHandler(this.MnModify_Click);
            // 
            // UclChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContextMenuBar);
            this.Controls.Add(this.AdvTree);
            this.Name = "UclChapter";
            this.Size = new System.Drawing.Size(671, 371);
            this.Load += new System.EventHandler(this.UclChapter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree AdvTree;
        private DevComponents.AdvTree.ColumnHeader ColName;
        private DevComponents.AdvTree.ColumnHeader ColDescription;
        private DevComponents.AdvTree.ColumnHeader ColState;
        private DevComponents.DotNetBar.ElementStyle ElementStyle;
        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar;
        private DevComponents.DotNetBar.ButtonItem TreeMenu;
        private DevComponents.DotNetBar.ButtonItem MnAdd;
        private DevComponents.DotNetBar.ButtonItem MnDelete;
        private DevComponents.DotNetBar.ButtonItem MnModify;

    }
}