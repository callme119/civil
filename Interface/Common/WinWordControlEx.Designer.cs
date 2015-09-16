namespace Framework.Interface.Common
{
    partial class WinWordControlEx
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
            this.ObjWinWordControl = new WinWordControl.WinWordControl();
            this.GroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPanel
            // 
            this.GroupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel.Controls.Add(this.ObjWinWordControl);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Size = new System.Drawing.Size(740, 550);
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
            // ObjWinWordControl
            // 
            this.ObjWinWordControl.BackColor = System.Drawing.Color.White;
            this.ObjWinWordControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjWinWordControl.Location = new System.Drawing.Point(0, 0);
            this.ObjWinWordControl.Name = "ObjWinWordControl";
            this.ObjWinWordControl.Size = new System.Drawing.Size(734, 544);
            this.ObjWinWordControl.TabIndex = 1;
            // 
            // WinWordControlEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPanel);
            this.Name = "WinWordControlEx";
            this.Size = new System.Drawing.Size(740, 550);
            this.GroupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel;
        private WinWordControl.WinWordControl ObjWinWordControl;

    }
}