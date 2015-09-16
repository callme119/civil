namespace Framework.Interface.Workbench
{
    partial class FrmScaffoldProject
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
            this.TabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.TabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.TabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.TabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.TabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.TabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.TabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.TabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.TabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.LbType = new DevComponents.DotNetBar.LabelX();
            this.CbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BtnSubmit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabControlPanel1.SuspendLayout();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.TabControl.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.TabControl.ControlBox.MenuBox.AutoHide = true;
            this.TabControl.ControlBox.MenuBox.Name = "";
            this.TabControl.ControlBox.MenuBox.Visible = false;
            this.TabControl.ControlBox.Name = "";
            this.TabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TabControl.ControlBox.MenuBox,
            this.TabControl.ControlBox.CloseBox});
            this.TabControl.Controls.Add(this.TabControlPanel1);
            this.TabControl.Controls.Add(this.TabControlPanel3);
            this.TabControl.Controls.Add(this.TabControlPanel2);
            this.TabControl.Controls.Add(this.TabControlPanel5);
            this.TabControl.Controls.Add(this.TabControlPanel4);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.ReorderTabsEnabled = true;
            this.TabControl.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.TabControl.SelectedTabIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(635, 432);
            this.TabControl.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl.TabIndex = 1;
            this.TabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TabItem1,
            this.TabItem2,
            this.TabItem3});
            // 
            // TabControlPanel3
            // 
            this.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel3.Location = new System.Drawing.Point(0, 28);
            this.TabControlPanel3.Name = "TabControlPanel3";
            this.TabControlPanel3.Size = new System.Drawing.Size(635, 404);
            this.TabControlPanel3.TabIndex = 19;
            this.TabControlPanel3.TabItem = this.TabItem3;
            // 
            // TabItem3
            // 
            this.TabItem3.AttachedControl = this.TabControlPanel3;
            this.TabItem3.GlobalItem = false;
            this.TabItem3.Name = "TabItem3";
            this.TabItem3.Text = "劳动力安排";
            // 
            // TabControlPanel2
            // 
            this.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.TabControlPanel2.Name = "TabControlPanel2";
            this.TabControlPanel2.Size = new System.Drawing.Size(635, 404);
            this.TabControlPanel2.TabIndex = 12;
            this.TabControlPanel2.TabItem = this.TabItem2;
            // 
            // TabItem2
            // 
            this.TabItem2.AttachedControl = this.TabControlPanel2;
            this.TabItem2.GlobalItem = false;
            this.TabItem2.Name = "TabItem2";
            this.TabItem2.Text = "材料准备";
            // 
            // TabControlPanel1
            // 
            this.TabControlPanel1.Controls.Add(this.PnlButton);
            this.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.TabControlPanel1.Name = "TabControlPanel1";
            this.TabControlPanel1.Size = new System.Drawing.Size(635, 404);
            this.TabControlPanel1.TabIndex = 1;
            this.TabControlPanel1.TabItem = this.TabItem1;
            // 
            // TabItem1
            // 
            this.TabItem1.AttachedControl = this.TabControlPanel1;
            this.TabItem1.GlobalItem = false;
            this.TabItem1.Name = "TabItem1";
            this.TabItem1.Text = "机械准备";
            // 
            // TabControlPanel5
            // 
            this.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel5.Location = new System.Drawing.Point(0, 0);
            this.TabControlPanel5.Name = "TabControlPanel5";
            this.TabControlPanel5.Size = new System.Drawing.Size(635, 432);
            this.TabControlPanel5.TabIndex = 0;
            // 
            // TabControlPanel4
            // 
            this.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPanel4.Location = new System.Drawing.Point(0, 0);
            this.TabControlPanel4.Name = "TabControlPanel4";
            this.TabControlPanel4.Size = new System.Drawing.Size(635, 432);
            this.TabControlPanel4.TabIndex = 26;
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.LbType);
            this.PnlButton.Controls.Add(this.CbxType);
            this.PnlButton.Controls.Add(this.BtnSubmit);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 376);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(635, 28);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 37;
            // 
            // LbType
            // 
            this.LbType.AutoSize = true;
            // 
            // 
            // 
            this.LbType.BackgroundStyle.Class = "";
            this.LbType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbType.Location = new System.Drawing.Point(13, 6);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(68, 18);
            this.LbType.TabIndex = 37;
            this.LbType.Text = "模板类型：";
            // 
            // CbxType
            // 
            this.CbxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxType.DisplayMember = "Text";
            this.CbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.ItemHeight = 15;
            this.CbxType.Location = new System.Drawing.Point(148, 4);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(137, 21);
            this.CbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxType.TabIndex = 38;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSubmit.Location = new System.Drawing.Point(560, 0);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 28);
            this.BtnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSubmit.TabIndex = 39;
            this.BtnSubmit.Text = "确 定";
            // 
            // FrmScaffoldProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(635, 432);
            this.Controls.Add(this.TabControl);
            this.Name = "FrmScaffoldProject";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabControlPanel1.ResumeLayout(false);
            this.PnlButton.ResumeLayout(false);
            this.PnlButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl TabControl;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem TabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem TabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel5;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem TabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel TabControlPanel4;
        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.LabelX LbType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxType;
        private DevComponents.DotNetBar.ButtonX BtnSubmit;

    }
}
