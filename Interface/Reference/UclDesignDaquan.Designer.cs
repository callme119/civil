namespace Framework.Interface.Reference
{
    partial class UclDesignDaquan
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
            this.winWordControlEx1 = new Framework.Interface.Common.WinWordControlEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // winWordControlEx1
            // 
            this.winWordControlEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winWordControlEx1.Location = new System.Drawing.Point(0, 0);
            this.winWordControlEx1.Name = "winWordControlEx1";
            this.winWordControlEx1.Size = new System.Drawing.Size(860, 365);
            this.winWordControlEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(271, 166);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(203, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "功能模块维护中......";
            // 
            // UclDesignDaquan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.winWordControlEx1);
            this.Name = "UclDesignDaquan";
            this.Size = new System.Drawing.Size(860, 365);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Interface.Common.WinWordControlEx winWordControlEx1;
        private DevComponents.DotNetBar.LabelX labelX1;

    }
}