namespace Framework.Interface.Workbench
{
    partial class UclChart
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
            this.WinWordControlEx = new Framework.Interface.Common.WinWordControlEx();
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.BtnCreate = new DevComponents.DotNetBar.ButtonX();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // WinWordControlEx
            // 
            this.WinWordControlEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinWordControlEx.Location = new System.Drawing.Point(0, 0);
            this.WinWordControlEx.Name = "WinWordControlEx";
            this.WinWordControlEx.Size = new System.Drawing.Size(500, 331);
            this.WinWordControlEx.TabIndex = 0;
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.BtnCreate);
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 304);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(500, 27);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 1;
            // 
            // BtnCreate
            // 
            this.BtnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCreate.Location = new System.Drawing.Point(350, 0);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 27);
            this.BtnCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "生成图表";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.Location = new System.Drawing.Point(425, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 27);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "加入工程";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // UclChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.WinWordControlEx);
            this.Name = "UclChart";
            this.Size = new System.Drawing.Size(500, 331);
            this.Load += new System.EventHandler(this.UclChart_Load);
            this.PnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Interface.Common.WinWordControlEx WinWordControlEx;
        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnAdd;
        private DevComponents.DotNetBar.ButtonX BtnCreate;

    }
}