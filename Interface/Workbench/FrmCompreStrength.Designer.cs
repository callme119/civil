namespace Framework.Interface.Workbench
{
    partial class FrmCompreStrength
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column4 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Column5 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Column6 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Column1 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(25, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(276, 245);
            this.dataGridViewX1.TabIndex = 6;
            // 
            // Column4
            // 
            // 
            // 
            // 
            this.Column4.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Column4.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column4.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Column4.HeaderText = "1";
            this.Column4.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            // 
            // 
            // 
            this.Column5.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Column5.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column5.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Column5.HeaderText = "2";
            this.Column5.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            // 
            // 
            // 
            this.Column6.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Column6.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column6.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Column6.HeaderText = "3";
            this.Column6.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            // 
            // 
            // 
            this.Column1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Column1.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Column1.HeaderText = "强度值";
            this.Column1.Increment = 1;
            this.Column1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "有效组数";
            // 
            // FrmCompreStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "FrmCompreStrength";
            this.Text = "FrmCompreStrength";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Column4;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Column5;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Column6;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Column1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}