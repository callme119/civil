namespace Framework.Interface.Content
{
    partial class FrmTemplate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplate));
            this.PnlButton = new DevComponents.DotNetBar.PanelEx();
            this.BtnImportWord = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.PnlTitle = new DevComponents.DotNetBar.PanelEx();
            this.CbxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbState = new DevComponents.DotNetBar.LabelX();
            this.TbxKey = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbKey = new DevComponents.DotNetBar.LabelX();
            this.TbxTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbTitle = new DevComponents.DotNetBar.LabelX();
            this.SuperValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.RequiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("不能为空！");
            this.RequiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("不能为空！");
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.WinWordControlEx = new Framework.Interface.Common.WinWordControlEx();
            this.RichTextBoxEx = new Framework.Interface.Common.RichTextBoxEx();
            this.WinExcelControlEx = new Framework.Interface.Common.WinExcelControlEx();
            this.BtnImportExcel = new DevComponents.DotNetBar.ButtonX();
            this.PnlButton.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlButton
            // 
            this.PnlButton.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlButton.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlButton.Controls.Add(this.BtnImportExcel);
            this.PnlButton.Controls.Add(this.BtnImportWord);
            this.PnlButton.Controls.Add(this.BtnSave);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButton.Location = new System.Drawing.Point(0, 494);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(763, 30);
            this.PnlButton.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlButton.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlButton.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlButton.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlButton.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlButton.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlButton.Style.GradientAngle = 90;
            this.PnlButton.TabIndex = 9;
            // 
            // BtnImportWord
            // 
            this.BtnImportWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnImportWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnImportWord.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnImportWord.Location = new System.Drawing.Point(613, 0);
            this.BtnImportWord.Name = "BtnImportWord";
            this.BtnImportWord.Size = new System.Drawing.Size(75, 30);
            this.BtnImportWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnImportWord.TabIndex = 11;
            this.BtnImportWord.Text = "导入Word";
            this.BtnImportWord.Click += new System.EventHandler(this.BtnImportWord_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSave.Location = new System.Drawing.Point(688, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 30);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "保存模板";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlTitle
            // 
            this.PnlTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlTitle.Controls.Add(this.CbxState);
            this.PnlTitle.Controls.Add(this.LbState);
            this.PnlTitle.Controls.Add(this.TbxKey);
            this.PnlTitle.Controls.Add(this.LbKey);
            this.PnlTitle.Controls.Add(this.TbxTitle);
            this.PnlTitle.Controls.Add(this.LbTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(763, 98);
            this.PnlTitle.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlTitle.Style.GradientAngle = 90;
            this.PnlTitle.TabIndex = 0;
            // 
            // CbxState
            // 
            this.CbxState.DisplayMember = "Text";
            this.CbxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxState.FormattingEnabled = true;
            this.CbxState.ItemHeight = 15;
            this.CbxState.Location = new System.Drawing.Point(87, 65);
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(142, 21);
            this.CbxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxState.TabIndex = 6;
            // 
            // LbState
            // 
            this.LbState.AutoSize = true;
            // 
            // 
            // 
            this.LbState.BackgroundStyle.Class = "";
            this.LbState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbState.Location = new System.Drawing.Point(19, 67);
            this.LbState.Name = "LbState";
            this.LbState.Size = new System.Drawing.Size(68, 18);
            this.LbState.TabIndex = 5;
            this.LbState.Text = "模板状态：";
            // 
            // TbxKey
            // 
            // 
            // 
            // 
            this.TbxKey.Border.Class = "TextBoxBorder";
            this.TbxKey.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxKey.Location = new System.Drawing.Point(87, 38);
            this.TbxKey.Name = "TbxKey";
            this.TbxKey.Size = new System.Drawing.Size(395, 21);
            this.TbxKey.TabIndex = 4;
            this.SuperValidator.SetValidator1(this.TbxKey, this.RequiredFieldValidator2);
            // 
            // LbKey
            // 
            this.LbKey.AutoSize = true;
            // 
            // 
            // 
            this.LbKey.BackgroundStyle.Class = "";
            this.LbKey.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbKey.Location = new System.Drawing.Point(19, 40);
            this.LbKey.Name = "LbKey";
            this.LbKey.Size = new System.Drawing.Size(68, 18);
            this.LbKey.TabIndex = 3;
            this.LbKey.Text = "关 键 字：";
            // 
            // TbxTitle
            // 
            // 
            // 
            // 
            this.TbxTitle.Border.Class = "TextBoxBorder";
            this.TbxTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxTitle.Location = new System.Drawing.Point(87, 11);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(395, 21);
            this.TbxTitle.TabIndex = 2;
            this.SuperValidator.SetValidator1(this.TbxTitle, this.RequiredFieldValidator1);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            // 
            // 
            // 
            this.LbTitle.BackgroundStyle.Class = "";
            this.LbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbTitle.Location = new System.Drawing.Point(19, 13);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(68, 18);
            this.LbTitle.TabIndex = 1;
            this.LbTitle.Text = "模板名称：";
            // 
            // SuperValidator
            // 
            this.SuperValidator.ContainerControl = this;
            this.SuperValidator.ErrorProvider = this.ErrorProvider;
            this.SuperValidator.Highlighter = this.Highlighter;
            this.SuperValidator.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // RequiredFieldValidator2
            // 
            this.RequiredFieldValidator2.ErrorMessage = "不能为空！";
            this.RequiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // RequiredFieldValidator1
            // 
            this.RequiredFieldValidator1.ErrorMessage = "不能为空！";
            this.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // Highlighter
            // 
            this.Highlighter.ContainerControl = this;
            // 
            // WinWordControlEx
            // 
            this.WinWordControlEx.Location = new System.Drawing.Point(0, 98);
            this.WinWordControlEx.Name = "WinWordControlEx";
            this.WinWordControlEx.Size = new System.Drawing.Size(763, 396);
            this.WinWordControlEx.TabIndex = 7;
            // 
            // RichTextBoxEx
            // 
            this.RichTextBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxEx.Location = new System.Drawing.Point(0, 98);
            this.RichTextBoxEx.Name = "RichTextBoxEx";
            this.RichTextBoxEx.Size = new System.Drawing.Size(763, 396);
            this.RichTextBoxEx.TabIndex = 10;
            // 
            // WinExcelControlEx
            // 
            this.WinExcelControlEx.Location = new System.Drawing.Point(0, 98);
            this.WinExcelControlEx.Name = "WinExcelControlEx";
            this.WinExcelControlEx.Size = new System.Drawing.Size(763, 396);
            this.WinExcelControlEx.TabIndex = 13;
            // 
            // BtnImportExcel
            // 
            this.BtnImportExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnImportExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnImportExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnImportExcel.Location = new System.Drawing.Point(538, 0);
            this.BtnImportExcel.Name = "BtnImportExcel";
            this.BtnImportExcel.Size = new System.Drawing.Size(75, 30);
            this.BtnImportExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnImportExcel.TabIndex = 10;
            this.BtnImportExcel.Text = "导入Excel";
            this.BtnImportExcel.Click += new System.EventHandler(this.BtnImportExcel_Click);
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 524);
            this.Controls.Add(this.WinExcelControlEx);
            this.Controls.Add(this.RichTextBoxEx);
            this.Controls.Add(this.PnlTitle);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.WinWordControlEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmTemplate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑模板";
            this.Load += new System.EventHandler(this.FrmTemplate_Load);
            this.PnlButton.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlButton;
        private DevComponents.DotNetBar.ButtonX BtnImportWord;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.PanelEx PnlTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxTitle;
        private DevComponents.DotNetBar.LabelX LbTitle;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxKey;
        private DevComponents.DotNetBar.LabelX LbKey;
        private DevComponents.DotNetBar.Validator.SuperValidator SuperValidator;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter Highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator RequiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator RequiredFieldValidator2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxState;
        private DevComponents.DotNetBar.LabelX LbState;
        private Framework.Interface.Common.RichTextBoxEx RichTextBoxEx;
        private Framework.Interface.Common.WinWordControlEx WinWordControlEx;
        private Framework.Interface.Common.WinExcelControlEx WinExcelControlEx;
        private DevComponents.DotNetBar.ButtonX BtnImportExcel;

    }
}