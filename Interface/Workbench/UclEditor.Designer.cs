namespace Framework.Interface.Workbench
{
    partial class UclEditor
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
            this.PnlTree = new DevComponents.DotNetBar.ExpandablePanel();
            this.AdvTree = new DevComponents.AdvTree.AdvTree();
            this.NodeConnector = new DevComponents.AdvTree.NodeConnector();
            this.ElementStyle = new DevComponents.DotNetBar.ElementStyle();
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.RichTextBoxEx = new Framework.Interface.Common.RichTextBoxEx();
            this.WinWordControlEx = new Framework.Interface.Common.WinWordControlEx();
            this.PnlTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).BeginInit();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTree
            // 
            this.PnlTree.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlTree.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.PnlTree.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlTree.Controls.Add(this.AdvTree);
            this.PnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTree.Location = new System.Drawing.Point(0, 0);
            this.PnlTree.Name = "PnlTree";
            this.PnlTree.Size = new System.Drawing.Size(201, 370);
            this.PnlTree.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlTree.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlTree.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlTree.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
           // this.PnlTree.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BackedBorder;
            this.PnlTree.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PnlTree.Style.GradientAngle = 90;
            this.PnlTree.TabIndex = 0;
            this.PnlTree.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlTree.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlTree.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlTree.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlTree.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlTree.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlTree.TitleStyle.GradientAngle = 90;
            this.PnlTree.TitleText = "模板列表";
            // 
            // AdvTree
            // 
            this.AdvTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTree.AllowDrop = true;
            this.AdvTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTree.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AdvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvTree.Location = new System.Drawing.Point(0, 26);
            this.AdvTree.Name = "AdvTree";
            this.AdvTree.NodesConnector = this.NodeConnector;
            this.AdvTree.NodeStyle = this.ElementStyle;
            this.AdvTree.PathSeparator = ";";
            this.AdvTree.Size = new System.Drawing.Size(201, 344);
            this.AdvTree.Styles.Add(this.ElementStyle);
            this.AdvTree.TabIndex = 1;
            // 
            // NodeConnector
            // 
            this.NodeConnector.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ElementStyle
            // 
            this.ElementStyle.Class = "";
            this.ElementStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle.Name = "ElementStyle";
            this.ElementStyle.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.BtnSave);
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(201, 339);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(517, 31);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSave.Location = new System.Drawing.Point(367, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 31);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "另存为模板";
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.Location = new System.Drawing.Point(442, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 31);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "加入工程";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RichTextBoxEx
            // 
            this.RichTextBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxEx.Location = new System.Drawing.Point(201, 0);
            this.RichTextBoxEx.Name = "RichTextBoxEx";
            this.RichTextBoxEx.Size = new System.Drawing.Size(517, 339);
            this.RichTextBoxEx.TabIndex = 2;
            // 
            // WinWordControlEx
            // 
            this.WinWordControlEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinWordControlEx.Location = new System.Drawing.Point(201, 0);
            this.WinWordControlEx.Name = "WinWordControlEx";
            this.WinWordControlEx.Size = new System.Drawing.Size(517, 339);
            this.WinWordControlEx.TabIndex = 3;
            this.WinWordControlEx.Visible = false;
            // 
            // UclEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WinWordControlEx);
            this.Controls.Add(this.RichTextBoxEx);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PnlTree);
            this.Name = "UclEditor";
            this.Size = new System.Drawing.Size(718, 370);
            this.Load += new System.EventHandler(this.UclEditor_Load);
            this.PnlTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTree)).EndInit();
            this.PnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel PnlTree;
        private DevComponents.AdvTree.AdvTree AdvTree;
        private DevComponents.AdvTree.NodeConnector NodeConnector;
        private DevComponents.DotNetBar.ElementStyle ElementStyle;
        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnAdd;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private Framework.Interface.Common.RichTextBoxEx RichTextBoxEx;
        private Framework.Interface.Common.WinWordControlEx WinWordControlEx;

    }
}