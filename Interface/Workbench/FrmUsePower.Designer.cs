namespace Framework.Interface.Workbench
{
    partial class FrmUsePower
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
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.LbType = new DevComponents.DotNetBar.LabelX();
            this.CbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BtnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.GroupPanel = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.IpCos = new DevComponents.Editors.DoubleInput();
            this.IpK4 = new DevComponents.Editors.DoubleInput();
            this.IpK3 = new DevComponents.Editors.DoubleInput();
            this.IpK2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.IpK1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbK3 = new DevComponents.DotNetBar.LabelX();
            this.LbK2 = new DevComponents.DotNetBar.LabelX();
            this.LbK1 = new DevComponents.DotNetBar.LabelX();
            this.LbK4 = new DevComponents.DotNetBar.LabelX();
            this.LbCos = new DevComponents.DotNetBar.LabelX();
            this.DataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ColType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColNumber = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.PnlButton.SuspendLayout();
            this.GroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpCos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpK4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpK3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.LbType);
            this.PnlButton.Controls.Add(this.CbxType);
            this.PnlButton.Controls.Add(this.BtnSubmit);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 314);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(503, 30);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 12;
            // 
            // LbType
            // 
            this.LbType.AutoSize = true;
            // 
            // 
            // 
            this.LbType.BackgroundStyle.Class = "";
            this.LbType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbType.Location = new System.Drawing.Point(18, 7);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(68, 18);
            this.LbType.TabIndex = 13;
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
            this.CbxType.Location = new System.Drawing.Point(89, 5);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(154, 21);
            this.CbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxType.TabIndex = 14;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSubmit.Location = new System.Drawing.Point(428, 0);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 30);
            this.BtnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSubmit.TabIndex = 15;
            this.BtnSubmit.Text = "确 定";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // GroupPanel
            // 
            this.GroupPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel.Controls.Add(this.IpCos);
            this.GroupPanel.Controls.Add(this.IpK4);
            this.GroupPanel.Controls.Add(this.IpK3);
            this.GroupPanel.Controls.Add(this.IpK2);
            this.GroupPanel.Controls.Add(this.IpK1);
            this.GroupPanel.Controls.Add(this.LbK3);
            this.GroupPanel.Controls.Add(this.LbK2);
            this.GroupPanel.Controls.Add(this.LbK1);
            this.GroupPanel.Controls.Add(this.LbK4);
            this.GroupPanel.Controls.Add(this.LbCos);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupPanel.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Size = new System.Drawing.Size(503, 76);
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
            // IpCos
            // 
            // 
            // 
            // 
            this.IpCos.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IpCos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpCos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IpCos.Increment = 0.01;
            this.IpCos.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IpCos.Location = new System.Drawing.Point(160, 9);
            this.IpCos.Name = "IpCos";
            this.IpCos.ShowUpDown = true;
            this.IpCos.Size = new System.Drawing.Size(80, 21);
            this.IpCos.TabIndex = 2;
            this.IpCos.Value = 0.75;
            // 
            // IpK4
            // 
            // 
            // 
            // 
            this.IpK4.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IpK4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpK4.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IpK4.Increment = 0.1;
            this.IpK4.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IpK4.Location = new System.Drawing.Point(394, 37);
            this.IpK4.Name = "IpK4";
            this.IpK4.ShowUpDown = true;
            this.IpK4.Size = new System.Drawing.Size(80, 21);
            this.IpK4.TabIndex = 10;
            this.IpK4.Value = 1;
            // 
            // IpK3
            // 
            // 
            // 
            // 
            this.IpK3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IpK3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpK3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IpK3.Increment = 0.1;
            this.IpK3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.IpK3.Location = new System.Drawing.Point(277, 37);
            this.IpK3.Name = "IpK3";
            this.IpK3.ShowUpDown = true;
            this.IpK3.Size = new System.Drawing.Size(80, 21);
            this.IpK3.TabIndex = 8;
            this.IpK3.Value = 0.8;
            // 
            // IpK2
            // 
            this.IpK2.DisplayMember = "Text";
            this.IpK2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IpK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IpK2.FormattingEnabled = true;
            this.IpK2.ItemHeight = 15;
            this.IpK2.Location = new System.Drawing.Point(160, 37);
            this.IpK2.Name = "IpK2";
            this.IpK2.Size = new System.Drawing.Size(80, 21);
            this.IpK2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IpK2.TabIndex = 6;
            // 
            // IpK1
            // 
            this.IpK1.DisplayMember = "Text";
            this.IpK1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IpK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IpK1.FormattingEnabled = true;
            this.IpK1.ItemHeight = 15;
            this.IpK1.Location = new System.Drawing.Point(43, 37);
            this.IpK1.Name = "IpK1";
            this.IpK1.Size = new System.Drawing.Size(80, 21);
            this.IpK1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IpK1.TabIndex = 4;
            // 
            // LbK3
            // 
            this.LbK3.AutoSize = true;
            this.LbK3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LbK3.BackgroundStyle.Class = "";
            this.LbK3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbK3.Location = new System.Drawing.Point(249, 40);
            this.LbK3.Name = "LbK3";
            this.LbK3.Size = new System.Drawing.Size(31, 18);
            this.LbK3.TabIndex = 7;
            this.LbK3.Text = "K3：";
            // 
            // LbK2
            // 
            this.LbK2.AutoSize = true;
            this.LbK2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LbK2.BackgroundStyle.Class = "";
            this.LbK2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbK2.Location = new System.Drawing.Point(132, 40);
            this.LbK2.Name = "LbK2";
            this.LbK2.Size = new System.Drawing.Size(31, 18);
            this.LbK2.TabIndex = 5;
            this.LbK2.Text = "K2：";
            // 
            // LbK1
            // 
            this.LbK1.AutoSize = true;
            this.LbK1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LbK1.BackgroundStyle.Class = "";
            this.LbK1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbK1.Location = new System.Drawing.Point(15, 40);
            this.LbK1.Name = "LbK1";
            this.LbK1.Size = new System.Drawing.Size(31, 18);
            this.LbK1.TabIndex = 3;
            this.LbK1.Text = "K1：";
            // 
            // LbK4
            // 
            this.LbK4.AutoSize = true;
            this.LbK4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LbK4.BackgroundStyle.Class = "";
            this.LbK4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbK4.Location = new System.Drawing.Point(366, 40);
            this.LbK4.Name = "LbK4";
            this.LbK4.Size = new System.Drawing.Size(31, 18);
            this.LbK4.TabIndex = 9;
            this.LbK4.Text = "K4：";
            // 
            // LbCos
            // 
            this.LbCos.AutoSize = true;
            this.LbCos.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LbCos.BackgroundStyle.Class = "";
            this.LbCos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbCos.Location = new System.Drawing.Point(15, 12);
            this.LbCos.Name = "LbCos";
            this.LbCos.Size = new System.Drawing.Size(142, 18);
            this.LbCos.TabIndex = 1;
            this.LbCos.Text = "电动机的平均功率因素：";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColType,
            this.ColNumber});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGridView.Location = new System.Drawing.Point(0, 76);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 23;
            this.DataGridView.Size = new System.Drawing.Size(503, 238);
            this.DataGridView.TabIndex = 11;
            //this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ColType
            // 
            this.ColType.HeaderText = "供电设备类型";
            this.ColType.Items.AddRange(new object[] {
            "电动机",
            "电焊机",
            "室内照明",
            "室外照明"});
            this.ColType.Name = "ColType";
            this.ColType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColType.Width = 300;
            // 
            // ColNumber
            // 
            // 
            // 
            // 
            this.ColNumber.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ColNumber.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.ColNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ColNumber.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.ColNumber.HeaderText = "供电设备容量";
            this.ColNumber.Increment = 1;
            this.ColNumber.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColNumber.Width = 200;
            // 
            // FrmUsePower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.GroupPanel);
            this.Controls.Add(this.PnlButton);
            this.Name = "FrmUsePower";
            this.Text = "施工临时用电布置";
            this.Load += new System.EventHandler(this.FrmUsePower_Load);
            this.PnlButton.ResumeLayout(false);
            this.PnlButton.PerformLayout();
            this.GroupPanel.ResumeLayout(false);
            this.GroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpCos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpK4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpK3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnSubmit;
        private DevComponents.DotNetBar.LabelX LbType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxType;
        private DevComponents.DotNetBar.Controls.GroupPanel GroupPanel;
        private DevComponents.DotNetBar.LabelX LbK3;
        private DevComponents.DotNetBar.LabelX LbK2;
        private DevComponents.DotNetBar.LabelX LbK1;
        private DevComponents.DotNetBar.LabelX LbK4;
        private DevComponents.DotNetBar.LabelX LbCos;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridView;
        private DevComponents.Editors.DoubleInput IpK3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx IpK2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx IpK1;
        private DevComponents.Editors.DoubleInput IpCos;
        private DevComponents.Editors.DoubleInput IpK4;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColType;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn ColNumber;
    }
}