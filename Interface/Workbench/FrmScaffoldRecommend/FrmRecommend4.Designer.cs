namespace Framework.Interface.Workbench.FrmScaffoldRecommend
{
    partial class FrmRecommend4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stcRecommend4 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Dgv_Recommend4Para = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Dgv_Recommend4Labor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Dgv_Recommend4Material = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAddRow = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteRow = new DevComponents.DotNetBar.ButtonX();
            this.btnSubmit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.stcRecommend4)).BeginInit();
            this.stcRecommend4.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Para)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Labor)).BeginInit();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Material)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stcRecommend4
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.stcRecommend4.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.stcRecommend4.ControlBox.MenuBox.Name = "";
            this.stcRecommend4.ControlBox.Name = "";
            this.stcRecommend4.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stcRecommend4.ControlBox.MenuBox,
            this.stcRecommend4.ControlBox.CloseBox});
            this.stcRecommend4.Controls.Add(this.superTabControlPanel1);
            this.stcRecommend4.Controls.Add(this.superTabControlPanel3);
            this.stcRecommend4.Controls.Add(this.superTabControlPanel2);
            this.stcRecommend4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stcRecommend4.Location = new System.Drawing.Point(0, 0);
            this.stcRecommend4.Name = "stcRecommend4";
            this.stcRecommend4.ReorderTabsEnabled = true;
            this.stcRecommend4.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.stcRecommend4.SelectedTabIndex = 0;
            this.stcRecommend4.Size = new System.Drawing.Size(544, 394);
            this.stcRecommend4.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stcRecommend4.TabIndex = 3;
            this.stcRecommend4.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3});
            this.stcRecommend4.Text = "superTabControl1";
            this.stcRecommend4.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.stcRecommend4_SelectedTabChanged);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.Dgv_Recommend4Para);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(544, 366);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // Dgv_Recommend4Para
            // 
            this.Dgv_Recommend4Para.AllowUserToAddRows = false;
            this.Dgv_Recommend4Para.AllowUserToDeleteRows = false;
            this.Dgv_Recommend4Para.AllowUserToResizeColumns = false;
            this.Dgv_Recommend4Para.AllowUserToResizeRows = false;
            this.Dgv_Recommend4Para.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Recommend4Para.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Recommend4Para.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Recommend4Para.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Dgv_Recommend4Para.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Recommend4Para.Name = "Dgv_Recommend4Para";
            this.Dgv_Recommend4Para.RowHeadersVisible = false;
            this.Dgv_Recommend4Para.RowTemplate.Height = 23;
            this.Dgv_Recommend4Para.Size = new System.Drawing.Size(544, 366);
            this.Dgv_Recommend4Para.TabIndex = 5;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "架体型式";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.Dgv_Recommend4Labor);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(544, 394);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // Dgv_Recommend4Labor
            // 
            this.Dgv_Recommend4Labor.AllowUserToAddRows = false;
            this.Dgv_Recommend4Labor.AllowUserToDeleteRows = false;
            this.Dgv_Recommend4Labor.AllowUserToResizeColumns = false;
            this.Dgv_Recommend4Labor.AllowUserToResizeRows = false;
            this.Dgv_Recommend4Labor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Recommend4Labor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Recommend4Labor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Recommend4Labor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Dgv_Recommend4Labor.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Recommend4Labor.Name = "Dgv_Recommend4Labor";
            this.Dgv_Recommend4Labor.RowHeadersVisible = false;
            this.Dgv_Recommend4Labor.RowTemplate.Height = 23;
            this.Dgv_Recommend4Labor.Size = new System.Drawing.Size(544, 394);
            this.Dgv_Recommend4Labor.TabIndex = 3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "劳动力安排";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.Dgv_Recommend4Material);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(544, 394);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // Dgv_Recommend4Material
            // 
            this.Dgv_Recommend4Material.AllowUserToAddRows = false;
            this.Dgv_Recommend4Material.AllowUserToDeleteRows = false;
            this.Dgv_Recommend4Material.AllowUserToResizeColumns = false;
            this.Dgv_Recommend4Material.AllowUserToResizeRows = false;
            this.Dgv_Recommend4Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Recommend4Material.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Recommend4Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Recommend4Material.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.Dgv_Recommend4Material.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Recommend4Material.Name = "Dgv_Recommend4Material";
            this.Dgv_Recommend4Material.RowHeadersVisible = false;
            this.Dgv_Recommend4Material.RowTemplate.Height = 23;
            this.Dgv_Recommend4Material.Size = new System.Drawing.Size(544, 394);
            this.Dgv_Recommend4Material.TabIndex = 4;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "材料安排";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnAddRow);
            this.panelEx1.Controls.Add(this.btnDeleteRow);
            this.panelEx1.Controls.Add(this.btnSubmit);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 395);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(544, 28);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRow.Location = new System.Drawing.Point(306, 1);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 24);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "增加行";
            this.btnAddRow.Visible = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteRow.Location = new System.Drawing.Point(387, 2);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 24);
            this.btnDeleteRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteRow.TabIndex = 2;
            this.btnDeleteRow.Text = "删除行";
            this.btnDeleteRow.Visible = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Location = new System.Drawing.Point(467, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmRecommend4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(544, 423);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.stcRecommend4);
            this.DoubleBuffered = true;
            this.Name = "FrmRecommend4";
            this.Text = "承插型盘扣式钢管脚手架";
            this.Load += new System.EventHandler(this.FrmRecommend4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stcRecommend4)).EndInit();
            this.stcRecommend4.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Para)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Labor)).EndInit();
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recommend4Material)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl stcRecommend4;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnAddRow;
        private DevComponents.DotNetBar.ButtonX btnDeleteRow;
        private DevComponents.DotNetBar.ButtonX btnSubmit;
        private DevComponents.DotNetBar.Controls.DataGridViewX Dgv_Recommend4Labor;
        private DevComponents.DotNetBar.Controls.DataGridViewX Dgv_Recommend4Material;
        private DevComponents.DotNetBar.Controls.DataGridViewX Dgv_Recommend4Para;
    }
}
