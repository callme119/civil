namespace Framework.Interface.Workbench
{
    partial class UclExcel
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
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.BtnRedo = new DevComponents.DotNetBar.ButtonX();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.WinWordControlEx = new Framework.Interface.Common.WinWordControlEx();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.BtnRedo);
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 292);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(547, 28);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 2;
            // 
            // BtnRedo
            // 
            this.BtnRedo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnRedo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnRedo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRedo.Location = new System.Drawing.Point(397, 0);
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(75, 28);
            this.BtnRedo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnRedo.TabIndex = 3;
            this.BtnRedo.Text = "重新生成";
            this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.Location = new System.Drawing.Point(472, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 28);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "保 存";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // WinWordControlEx
            // 
            this.WinWordControlEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinWordControlEx.Location = new System.Drawing.Point(0, 0);
            this.WinWordControlEx.Name = "WinWordControlEx";
            this.WinWordControlEx.Size = new System.Drawing.Size(547, 292);
            this.WinWordControlEx.TabIndex = 1;
            // 
            // UclExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WinWordControlEx);
            this.Controls.Add(this.PnlButton);
            this.Name = "UclExcel";
            this.Size = new System.Drawing.Size(547, 320);
            this.Load += new System.EventHandler(this.UclExcel_Load);
            this.PnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnAdd;
        private DevComponents.DotNetBar.ButtonX BtnRedo;
        private Framework.Interface.Common.WinWordControlEx WinWordControlEx;

    }
}