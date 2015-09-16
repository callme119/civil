namespace Framework.Interface.Content
{
    partial class UclModel
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
            this.TreeMenu = new DevComponents.DotNetBar.ButtonItem();
            this.MnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.MnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.MnModify = new DevComponents.DotNetBar.ButtonItem();
            this.ContextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.AdvTree = new DevComponents.AdvTree.AdvTree();
            this.ColId = new DevComponents.AdvTree.ColumnHeader();
            this.ColName = new DevComponents.AdvTree.ColumnHeader();
            this.ColDescription = new DevComponents.AdvTree.ColumnHeader();
            this.ColState = new DevComponents.AdvTree.ColumnHeader();
            this.ElementStyle = new DevComponents.DotNetBar.ElementStyle();
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).BeginInit();
            this.SuspendLayout();
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
            this.MnAdd.Text = "添加模型";
            this.MnAdd.Click += new System.EventHandler(this.MnAdd_Click);
            // 
            // MnDelete
            // 
            this.MnDelete.Name = "MnDelete";
            this.MnDelete.Text = "删除模型";
            this.MnDelete.Click += new System.EventHandler(this.MnDelete_Click);
            // 
            // MnModify
            // 
            this.MnModify.Name = "MnModify";
            this.MnModify.Text = "修改模型";
            this.MnModify.Click += new System.EventHandler(this.MnModify_Click);
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
            this.ContextMenuBar.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.ContextMenuBar_PopupOpen);
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
            this.AdvTree.Columns.Add(this.ColId);
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
            this.AdvTree.Size = new System.Drawing.Size(559, 236);
            this.AdvTree.Styles.Add(this.ElementStyle);
            this.AdvTree.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.Name = "ColId";
            this.ColId.Text = "序号";
            this.ColId.Width.Relative = 10;
            // 
            // ColName
            // 
            this.ColName.Name = "ColName";
            this.ColName.Text = "标题";
            this.ColName.Width.Relative = 30;
            // 
            // ColDescription
            // 
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Text = "描述";
            this.ColDescription.Width.Relative = 50;
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
            // UclModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContextMenuBar);
            this.Controls.Add(this.AdvTree);
            this.Name = "UclModel";
            this.Size = new System.Drawing.Size(559, 236);
            this.Load += new System.EventHandler(this.UclModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContextMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem TreeMenu;
        private DevComponents.DotNetBar.ButtonItem MnAdd;
        private DevComponents.DotNetBar.ButtonItem MnDelete;
        private DevComponents.DotNetBar.ButtonItem MnModify;
        private DevComponents.DotNetBar.ContextMenuBar ContextMenuBar;
        private DevComponents.AdvTree.AdvTree AdvTree;
        private DevComponents.AdvTree.ColumnHeader ColName;
        private DevComponents.AdvTree.ColumnHeader ColDescription;
        private DevComponents.AdvTree.ColumnHeader ColState;
        private DevComponents.DotNetBar.ElementStyle ElementStyle;
        private DevComponents.AdvTree.ColumnHeader ColId;

    }
}