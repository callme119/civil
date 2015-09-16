namespace Framework.Interface.Workbench
{
    partial class FrmProperty
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
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.LbType = new DevComponents.DotNetBar.LabelX();
            this.CbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BtnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGrid.HelpVisible = false;
            this.PropertyGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(565, 292);
            this.PropertyGrid.TabIndex = 0;
            this.PropertyGrid.ToolbarVisible = false;
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.LbType);
            this.PnlButton.Controls.Add(this.CbxType);
            this.PnlButton.Controls.Add(this.BtnSubmit);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 264);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(565, 28);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 1;
            // 
            // LbType
            // 
            this.LbType.AutoSize = true;
            // 
            // 
            // 
            this.LbType.BackgroundStyle.Class = "";
            this.LbType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbType.Location = new System.Drawing.Point(12, 5);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(68, 18);
            this.LbType.TabIndex = 2;
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
            this.CbxType.Location = new System.Drawing.Point(81, 3);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(137, 21);
            this.CbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxType.TabIndex = 3;
         //   this.CbxType.SelectedIndexChanged += new System.EventHandler(this.CbxType_SelectedIndexChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSubmit.Location = new System.Drawing.Point(490, 0);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 28);
            this.BtnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "提 交";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FrmProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 292);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PropertyGrid);
            this.DoubleBuffered = true;
            this.Name = "FrmProperty";
            this.Text = "属性面板";
            this.PnlButton.ResumeLayout(false);
            this.PnlButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PropertyGrid;
        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnSubmit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxType;
        private DevComponents.DotNetBar.LabelX LbType;

    }
}