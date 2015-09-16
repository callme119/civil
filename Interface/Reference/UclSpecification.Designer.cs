namespace Framework.Interface.Reference
{
    partial class UclSpecification
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
            this.IpnSource = new DevComponents.DotNetBar.ItemPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.IpnSource.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.itemPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IpnSource
            // 
            // 
            // 
            // 
            this.IpnSource.BackgroundStyle.Class = "ItemPanel";
            this.IpnSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpnSource.ContainerControlProcessDialogKey = true;
            this.IpnSource.Controls.Add(this.panelEx1);
            this.IpnSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IpnSource.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.IpnSource.Location = new System.Drawing.Point(0, 0);
            this.IpnSource.Name = "IpnSource";
            this.IpnSource.Size = new System.Drawing.Size(618, 370);
            this.IpnSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IpnSource.TabIndex = 2;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.itemPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(618, 370);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.checkedListBox1);
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(618, 370);
            this.itemPanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.itemPanel1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "混凝土质量控制标准GB50164-1992(1)",
            "混凝土质量控制标准GB50164-1992",
            "工业安装工程施工质量验收统一标准(1)",
            "工业安装工程施工质量验收统一标准",
            "建设工程施工现场供用电安全规范ＧＢ５０１９４－９３(1)",
            "建设工程施工现场供用电安全规范ＧＢ５０１９４－９３",
            "民用建筑热工设计规范GB50176-93(1)",
            "民用建筑热工设计规范GB50176-93",
            "建筑地基基础设计规范GB50007-2002(1)",
            "建筑地基基础设计规范GB50007-2002",
            "无障碍设施设计标准DGJ08-103-2003(1)",
            "无障碍设施设计标准DGJ08-103-2003",
            "建筑中水设计规范(1)",
            "建筑中水设计规范",
            "建筑结构可靠度设计统一标准GB 50068-2001(1)"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(618, 364);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.DoubleClick += new System.EventHandler(this.checkedListBox1_DoubleClick);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // UclSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IpnSource);
            this.Name = "UclSpecification";
            this.Size = new System.Drawing.Size(618, 370);
            this.IpnSource.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.itemPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel IpnSource;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;

    }
}