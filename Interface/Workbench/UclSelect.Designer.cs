namespace Framework.Interface.Workbench
{
    partial class UclSelect
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
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IpnSource = new DevComponents.DotNetBar.ItemPanel();
            this.IpnProject = new DevComponents.DotNetBar.ItemPanel();
            this.PnlChoice = new System.Windows.Forms.Panel();
            this.BtnOut = new DevComponents.DotNetBar.ButtonX();
            this.BtnIn = new DevComponents.DotNetBar.ButtonX();
            this.PnlButton.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.PnlChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 347);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(687, 29);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.Location = new System.Drawing.Point(612, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 29);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "保 存";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel.ColumnCount = 3;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TableLayoutPanel.Controls.Add(this.IpnSource, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.IpnProject, 2, 0);
            this.TableLayoutPanel.Controls.Add(this.PnlChoice, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(687, 347);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // IpnSource
            // 
            // 
            // 
            // 
            this.IpnSource.BackgroundStyle.Class = "ItemPanel";
            this.IpnSource.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpnSource.ContainerControlProcessDialogKey = true;
            this.IpnSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IpnSource.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.IpnSource.Location = new System.Drawing.Point(4, 4);
            this.IpnSource.Name = "IpnSource";
            this.IpnSource.Size = new System.Drawing.Size(301, 339);
            this.IpnSource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IpnSource.TabIndex = 1;
            // 
            // IpnProject
            // 
            // 
            // 
            // 
            this.IpnProject.BackgroundStyle.Class = "ItemPanel";
            this.IpnProject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IpnProject.ContainerControlProcessDialogKey = true;
            this.IpnProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IpnProject.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.IpnProject.Location = new System.Drawing.Point(381, 4);
            this.IpnProject.Name = "IpnProject";
            this.IpnProject.Size = new System.Drawing.Size(302, 339);
            this.IpnProject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IpnProject.TabIndex = 5;
            // 
            // PnlChoice
            // 
            this.PnlChoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlChoice.Controls.Add(this.BtnOut);
            this.PnlChoice.Controls.Add(this.BtnIn);
            this.PnlChoice.Location = new System.Drawing.Point(312, 144);
            this.PnlChoice.Name = "PnlChoice";
            this.PnlChoice.Size = new System.Drawing.Size(62, 58);
            this.PnlChoice.TabIndex = 2;
            // 
            // BtnOut
            // 
            this.BtnOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnOut.Location = new System.Drawing.Point(0, 35);
            this.BtnOut.Name = "BtnOut";
            this.BtnOut.Size = new System.Drawing.Size(62, 23);
            this.BtnOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnOut.TabIndex = 4;
            this.BtnOut.Text = "<<<<";
            this.BtnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // BtnIn
            // 
            this.BtnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIn.Location = new System.Drawing.Point(0, 0);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(62, 23);
            this.BtnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnIn.TabIndex = 3;
            this.BtnIn.Text = ">>>>";
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // UclSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.PnlButton);
            this.Name = "UclSelect";
            this.Size = new System.Drawing.Size(687, 376);
            this.Load += new System.EventHandler(this.UclSelect_Load);
            this.PnlButton.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.PnlChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnAdd;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private DevComponents.DotNetBar.ItemPanel IpnSource;
        private DevComponents.DotNetBar.ItemPanel IpnProject;
        private System.Windows.Forms.Panel PnlChoice;
        private DevComponents.DotNetBar.ButtonX BtnOut;
        private DevComponents.DotNetBar.ButtonX BtnIn;

    }
}