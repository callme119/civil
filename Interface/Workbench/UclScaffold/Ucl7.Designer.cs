namespace Framework.Interface.Workbench.UclScaffold
{
    partial class Ucl7
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
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxX7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxX7.Location = new System.Drawing.Point(0, 0);
            this.textBoxX7.Multiline = true;
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.ReadOnly = true;
            this.textBoxX7.Size = new System.Drawing.Size(578, 468);
            this.textBoxX7.TabIndex = 3;
            this.textBoxX7.Text = "\r\n优点：\r\n搭设简易。\r\n\r\n缺点：\r\n安全性较差。\r\n\r\n适用性：\r\n主要用于建筑外立面装饰装修工程。\r\n";
            // 
            // Ucl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxX7);
            this.Name = "Ucl7";
            this.Size = new System.Drawing.Size(578, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
    }
}
