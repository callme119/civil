namespace Framework.Interface.Workbench
{
    partial class FrmAssessResultshow
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgAssessResultshow = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbProjectNum = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssessResultshow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAssessResultshow
            // 
            this.dgAssessResultshow.AllowUserToAddRows = false;
            this.dgAssessResultshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssessResultshow.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAssessResultshow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAssessResultshow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAssessResultshow.Location = new System.Drawing.Point(0, 34);
            this.dgAssessResultshow.Name = "dgAssessResultshow";
            this.dgAssessResultshow.RowHeadersVisible = false;
            this.dgAssessResultshow.RowTemplate.Height = 23;
            this.dgAssessResultshow.Size = new System.Drawing.Size(512, 280);
            this.dgAssessResultshow.TabIndex = 0;
            // 
            // lbProjectNum
            // 
            // 
            // 
            // 
            this.lbProjectNum.BackgroundStyle.Class = "";
            this.lbProjectNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbProjectNum.Location = new System.Drawing.Point(12, 6);
            this.lbProjectNum.Name = "lbProjectNum";
            this.lbProjectNum.Size = new System.Drawing.Size(171, 23);
            this.lbProjectNum.TabIndex = 1;
            this.lbProjectNum.Text = "���־�����Ұ�µ���������";
            // 
            // FrmAssessResultshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(512, 314);
            this.Controls.Add(this.lbProjectNum);
            this.Controls.Add(this.dgAssessResultshow);
            this.Name = "FrmAssessResultshow";
            this.Text = "���";
            ((System.ComponentModel.ISupportInitialize)(this.dgAssessResultshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgAssessResultshow;
        private DevComponents.DotNetBar.LabelX lbProjectNum;
    }
}
