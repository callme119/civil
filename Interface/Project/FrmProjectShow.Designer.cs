namespace Framework.Interface.Project
{
    partial class FrmProjectShow
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
            this.WinWordControlEx = new Framework.Interface.Common.WinWordControlEx();
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lbl_waiter = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // WinWordControlEx
            // 
            this.WinWordControlEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinWordControlEx.Location = new System.Drawing.Point(0, 0);
            this.WinWordControlEx.Name = "WinWordControlEx";
            this.WinWordControlEx.Size = new System.Drawing.Size(677, 472);
            this.WinWordControlEx.TabIndex = 0;
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.Class = "";
            this.progressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBar.Location = new System.Drawing.Point(89, 222);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(491, 30);
            this.progressBar.TabIndex = 1;
            this.progressBar.Text = "progressBarX1";
            // 
            // lbl_waiter
            // 
            // 
            // 
            // 
            this.lbl_waiter.BackgroundStyle.Class = "";
            this.lbl_waiter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_waiter.Location = new System.Drawing.Point(190, 285);
            this.lbl_waiter.Name = "lbl_waiter";
            this.lbl_waiter.Size = new System.Drawing.Size(257, 23);
            this.lbl_waiter.TabIndex = 2;
            this.lbl_waiter.Text = "正在努力为您生成word文档，请耐心等待……";
            // 
            // FrmProjectShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 472);
            this.Controls.Add(this.lbl_waiter);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.WinWordControlEx);
            this.Name = "FrmProjectShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示工程文档";
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Interface.Common.WinWordControlEx WinWordControlEx;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
        private DevComponents.DotNetBar.LabelX lbl_waiter;

    }
}