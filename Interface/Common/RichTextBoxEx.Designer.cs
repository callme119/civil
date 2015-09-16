namespace Framework.Interface.Common
{
    partial class RichTextBoxEx
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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.RibbonBar = new DevComponents.DotNetBar.RibbonBar();
            this.ItemFamily = new DevComponents.DotNetBar.ComboBoxItem();
            this.ItemSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.ItemBold = new DevComponents.DotNetBar.ButtonItem();
            this.ItemItalic = new DevComponents.DotNetBar.ButtonItem();
            this.ItemUnder = new DevComponents.DotNetBar.ButtonItem();
            this.ItemColor = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.GroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPanel
            // 
            this.GroupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.GroupPanel.Controls.Add(this.RichTextBox);
            this.GroupPanel.Controls.Add(this.RibbonBar);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Size = new System.Drawing.Size(623, 406);
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
            // RichTextBox
            // 
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Location = new System.Drawing.Point(0, 52);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(617, 348);
            this.RichTextBox.TabIndex = 2;
            this.RichTextBox.Text = "";
            // 
            // RibbonBar
            // 
            this.RibbonBar.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.RibbonBar.BackgroundMouseOverStyle.Class = "";
            this.RibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar.BackgroundStyle.Class = "";
            this.RibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RibbonBar.ContainerControlProcessDialogKey = true;
            this.RibbonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.RibbonBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ItemFamily,
            this.ItemSize,
            this.ItemBold,
            this.ItemItalic,
            this.ItemUnder,
            this.ItemColor});
            this.RibbonBar.Location = new System.Drawing.Point(0, 0);
            this.RibbonBar.Name = "RibbonBar";
            this.RibbonBar.Size = new System.Drawing.Size(617, 52);
            this.RibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RibbonBar.TabIndex = 1;
            // 
            // 
            // 
            this.RibbonBar.TitleStyle.Class = "";
            this.RibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.RibbonBar.TitleStyleMouseOver.Class = "";
            this.RibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ItemFamily
            // 
            this.ItemFamily.ComboWidth = 100;
            this.ItemFamily.DropDownHeight = 106;
            this.ItemFamily.ItemHeight = 16;
            this.ItemFamily.Name = "ItemFamily";
            this.ItemFamily.SelectedIndexChanged += new System.EventHandler(this.ItemFamily_SelectedIndexChanged);
            // 
            // ItemSize
            // 
            this.ItemSize.ComboWidth = 50;
            this.ItemSize.DropDownHeight = 106;
            this.ItemSize.ItemHeight = 16;
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.SelectedIndexChanged += new System.EventHandler(this.ItemSize_SelectedIndexChanged);
            // 
            // ItemBold
            // 
            this.ItemBold.Image = global::Framework.Properties.Resources.Bold;
            this.ItemBold.Name = "ItemBold";
            this.ItemBold.SubItemsExpandWidth = 14;
            this.ItemBold.Click += new System.EventHandler(this.ItemBold_Click);
            // 
            // ItemItalic
            // 
            this.ItemItalic.Image = global::Framework.Properties.Resources.Italic;
            this.ItemItalic.Name = "ItemItalic";
            this.ItemItalic.SubItemsExpandWidth = 14;
            this.ItemItalic.Click += new System.EventHandler(this.ItemItalic_Click);
            // 
            // ItemUnder
            // 
            this.ItemUnder.Image = global::Framework.Properties.Resources.Under;
            this.ItemUnder.Name = "ItemUnder";
            this.ItemUnder.SubItemsExpandWidth = 14;
            this.ItemUnder.Click += new System.EventHandler(this.ItemUnder_Click);
            // 
            // ItemColor
            // 
            this.ItemColor.DisplayMoreColors = false;
            this.ItemColor.DisplayStandardColors = false;
            this.ItemColor.Image = global::Framework.Properties.Resources.Color;
            this.ItemColor.Name = "ItemColor";
            this.ItemColor.SubItemsExpandWidth = 14;
            this.ItemColor.Text = "文字颜色";
            this.ItemColor.SelectedColorChanged += new System.EventHandler(this.ItemColor_SelectedColorChanged);
            // 
            // RichTextBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPanel);
            this.Name = "RichTextBoxEx";
            this.Size = new System.Drawing.Size(623, 406);
            this.GroupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private DevComponents.DotNetBar.RibbonBar RibbonBar;
        private DevComponents.DotNetBar.ComboBoxItem ItemFamily;
        private DevComponents.DotNetBar.ComboBoxItem ItemSize;
        private DevComponents.DotNetBar.ButtonItem ItemBold;
        private DevComponents.DotNetBar.ButtonItem ItemItalic;
        private DevComponents.DotNetBar.ButtonItem ItemUnder;
        private DevComponents.DotNetBar.ColorPickerDropDown ItemColor;

    }
}