namespace Framework.Interface.Workbench
{
    partial class FrmAssessment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbProjectNum = new DevComponents.DotNetBar.LabelX();
            this.lbAssessNum = new DevComponents.DotNetBar.LabelX();
            this.intInputProjectNum = new DevComponents.Editors.IntegerInput();
            this.intInputAssessNum = new DevComponents.Editors.IntegerInput();
            this.lbFactorλ = new DevComponents.DotNetBar.LabelX();
            this.dbInputFactorλ = new DevComponents.Editors.DoubleInput();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnQuit = new DevComponents.DotNetBar.ButtonX();
            this.btnCalculate = new DevComponents.DotNetBar.ButtonX();
            this.dgAssessment = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbState = new DevComponents.DotNetBar.LabelX();
            this.pgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.dgChooseSmallIndex = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dbInputFactorλ1 = new DevComponents.Editors.DoubleInput();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.intInputProjectNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInputAssessNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInputFactorλ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssessment)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChooseSmallIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInputFactorλ1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjectNum
            // 
            // 
            // 
            // 
            this.lbProjectNum.BackgroundStyle.Class = "";
            this.lbProjectNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbProjectNum.Location = new System.Drawing.Point(1, 29);
            this.lbProjectNum.Name = "lbProjectNum";
            this.lbProjectNum.Size = new System.Drawing.Size(95, 23);
            this.lbProjectNum.TabIndex = 0;
            this.lbProjectNum.Text = "工程方案数量：";
            // 
            // lbAssessNum
            // 
            // 
            // 
            // 
            this.lbAssessNum.BackgroundStyle.Class = "";
            this.lbAssessNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbAssessNum.Location = new System.Drawing.Point(1, 58);
            this.lbAssessNum.Name = "lbAssessNum";
            this.lbAssessNum.Size = new System.Drawing.Size(95, 23);
            this.lbAssessNum.TabIndex = 0;
            this.lbAssessNum.Text = "评价指标数量：";
            // 
            // intInputProjectNum
            // 
            // 
            // 
            // 
            this.intInputProjectNum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInputProjectNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInputProjectNum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInputProjectNum.Location = new System.Drawing.Point(114, 29);
            this.intInputProjectNum.MinValue = 2;
            this.intInputProjectNum.Name = "intInputProjectNum";
            this.intInputProjectNum.ShowUpDown = true;
            this.intInputProjectNum.Size = new System.Drawing.Size(95, 21);
            this.intInputProjectNum.TabIndex = 1;
            this.intInputProjectNum.Value = 3;
            this.intInputProjectNum.ValueChanged += new System.EventHandler(this.intInputProjectNum_ValueChanged);
            // 
            // intInputAssessNum
            // 
            // 
            // 
            // 
            this.intInputAssessNum.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInputAssessNum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInputAssessNum.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInputAssessNum.Location = new System.Drawing.Point(114, 58);
            this.intInputAssessNum.MinValue = 2;
            this.intInputAssessNum.Name = "intInputAssessNum";
            this.intInputAssessNum.ShowUpDown = true;
            this.intInputAssessNum.Size = new System.Drawing.Size(95, 21);
            this.intInputAssessNum.TabIndex = 1;
            this.intInputAssessNum.Value = 3;
            this.intInputAssessNum.ValueChanged += new System.EventHandler(this.intInputAssessNum_ValueChanged);
            // 
            // lbFactorλ
            // 
            // 
            // 
            // 
            this.lbFactorλ.BackgroundStyle.Class = "";
            this.lbFactorλ.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFactorλ.Location = new System.Drawing.Point(0, 114);
            this.lbFactorλ.Name = "lbFactorλ";
            this.lbFactorλ.Size = new System.Drawing.Size(153, 23);
            this.lbFactorλ.TabIndex = 0;
            this.lbFactorλ.Text = "提升自身优势的权系数λ\'=";
            // 
            // dbInputFactorλ
            // 
            // 
            // 
            // 
            this.dbInputFactorλ.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbInputFactorλ.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dbInputFactorλ.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbInputFactorλ.Increment = 0.1;
            this.dbInputFactorλ.Location = new System.Drawing.Point(159, 116);
            this.dbInputFactorλ.MaxValue = 1;
            this.dbInputFactorλ.MinValue = 0;
            this.dbInputFactorλ.Name = "dbInputFactorλ";
            this.dbInputFactorλ.ShowUpDown = true;
            this.dbInputFactorλ.Size = new System.Drawing.Size(50, 21);
            this.dbInputFactorλ.TabIndex = 2;
            this.dbInputFactorλ.Value = 0.5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "强权数非独裁性条件";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "弱权数非独裁性条件";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuit.Location = new System.Drawing.Point(597, 6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 30);
            this.btnQuit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "退出";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCalculate.Location = new System.Drawing.Point(427, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "计算求解";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dgAssessment
            // 
            this.dgAssessment.AllowUserToAddRows = false;
            this.dgAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAssessment.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAssessment.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgAssessment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgAssessment.Location = new System.Drawing.Point(215, 0);
            this.dgAssessment.Name = "dgAssessment";
            this.dgAssessment.RowHeadersVisible = false;
            this.dgAssessment.RowTemplate.Height = 23;
            this.dgAssessment.Size = new System.Drawing.Size(604, 396);
            this.dgAssessment.TabIndex = 5;
            this.dgAssessment.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgAssessment_CellStateChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnQuit);
            this.panelEx1.Controls.Add(this.btnCalculate);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 396);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(819, 42);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // lbState
            // 
            // 
            // 
            // 
            this.lbState.BackgroundStyle.Class = "";
            this.lbState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbState.Location = new System.Drawing.Point(0, 373);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(819, 23);
            this.lbState.TabIndex = 8;
            this.lbState.Text = "正在计算综合评价值得取值范围";
            this.lbState.Visible = false;
            // 
            // pgBar
            // 
            // 
            // 
            // 
            this.pgBar.BackgroundStyle.Class = "";
            this.pgBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pgBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgBar.Location = new System.Drawing.Point(0, 350);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(819, 23);
            this.pgBar.TabIndex = 9;
            this.pgBar.Text = "progressBarX1";
            this.pgBar.Visible = false;
            // 
            // dgChooseSmallIndex
            // 
            this.dgChooseSmallIndex.AllowUserToAddRows = false;
            this.dgChooseSmallIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChooseSmallIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colState,
            this.colName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChooseSmallIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgChooseSmallIndex.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgChooseSmallIndex.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgChooseSmallIndex.Location = new System.Drawing.Point(656, 0);
            this.dgChooseSmallIndex.Name = "dgChooseSmallIndex";
            this.dgChooseSmallIndex.RowHeadersVisible = false;
            this.dgChooseSmallIndex.RowTemplate.Height = 23;
            this.dgChooseSmallIndex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChooseSmallIndex.Size = new System.Drawing.Size(163, 350);
            this.dgChooseSmallIndex.TabIndex = 10;
            // 
            // colState
            // 
            this.colState.HeaderText = "";
            this.colState.Name = "colState";
            this.colState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colState.Width = 30;
            // 
            // colName
            // 
            this.colName.HeaderText = "选择极小型指标";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.TextAlignment = System.Drawing.StringAlignment.Center;
            this.colName.Width = 130;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1, 87);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(153, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "提升自身优势的权系数λ =";
            // 
            // dbInputFactorλ1
            // 
            // 
            // 
            // 
            this.dbInputFactorλ1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dbInputFactorλ1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dbInputFactorλ1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dbInputFactorλ1.Increment = 0.1;
            this.dbInputFactorλ1.Location = new System.Drawing.Point(159, 87);
            this.dbInputFactorλ1.MaxValue = 1;
            this.dbInputFactorλ1.MinValue = 0;
            this.dbInputFactorλ1.Name = "dbInputFactorλ1";
            this.dbInputFactorλ1.ShowUpDown = true;
            this.dbInputFactorλ1.Size = new System.Drawing.Size(50, 21);
            this.dbInputFactorλ1.TabIndex = 12;
            this.dbInputFactorλ1.Value = 0.5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFactorλ);
            this.groupBox1.Controls.Add(this.dbInputFactorλ1);
            this.groupBox1.Controls.Add(this.lbProjectNum);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.lbAssessNum);
            this.groupBox1.Controls.Add(this.intInputProjectNum);
            this.groupBox1.Controls.Add(this.intInputAssessNum);
            this.groupBox1.Controls.Add(this.dbInputFactorλ);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 350);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(819, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgChooseSmallIndex);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.dgAssessment);
            this.DoubleBuffered = true;
            this.Name = "FrmAssessment";
            this.Text = "综合评价系统";
            this.Load += new System.EventHandler(this.FrmAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intInputProjectNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInputAssessNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInputFactorλ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssessment)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChooseSmallIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInputFactorλ1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbProjectNum;
        private DevComponents.DotNetBar.LabelX lbAssessNum;
        private DevComponents.Editors.IntegerInput intInputProjectNum;
        private DevComponents.Editors.IntegerInput intInputAssessNum;
        private DevComponents.DotNetBar.LabelX lbFactorλ;
        private DevComponents.Editors.DoubleInput dbInputFactorλ;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevComponents.DotNetBar.ButtonX btnQuit;
        private DevComponents.DotNetBar.ButtonX btnCalculate;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgAssessment;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbState;
        private DevComponents.DotNetBar.Controls.ProgressBarX pgBar;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgChooseSmallIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colState;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn colName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DoubleInput dbInputFactorλ1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
