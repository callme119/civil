namespace Framework.Interface.Authority
{
    partial class FrmModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModule));
            this.PnlMain = new DevComponents.DotNetBar.PanelEx();
            this.CbxPosition = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbPosition = new DevComponents.DotNetBar.LabelX();
            this.CbxRoot = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbImage = new DevComponents.DotNetBar.LabelX();
            this.LbClass = new DevComponents.DotNetBar.LabelX();
            this.LbName = new DevComponents.DotNetBar.LabelX();
            this.CbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbRoot = new DevComponents.DotNetBar.LabelX();
            this.LbType = new DevComponents.DotNetBar.LabelX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.CbxImage = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TbxClass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuperValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.RequiredFieldValidator = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("不能为空！");
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlMain.Controls.Add(this.CbxPosition);
            this.PnlMain.Controls.Add(this.LbPosition);
            this.PnlMain.Controls.Add(this.CbxRoot);
            this.PnlMain.Controls.Add(this.LbImage);
            this.PnlMain.Controls.Add(this.LbClass);
            this.PnlMain.Controls.Add(this.LbName);
            this.PnlMain.Controls.Add(this.CbxType);
            this.PnlMain.Controls.Add(this.LbRoot);
            this.PnlMain.Controls.Add(this.LbType);
            this.PnlMain.Controls.Add(this.BtnSave);
            this.PnlMain.Controls.Add(this.CbxImage);
            this.PnlMain.Controls.Add(this.TbxClass);
            this.PnlMain.Controls.Add(this.TbxName);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(397, 163);
            this.PnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlMain.Style.GradientAngle = 90;
            this.PnlMain.TabIndex = 0;
            // 
            // CbxPosition
            // 
            this.CbxPosition.DisplayMember = "Text";
            this.CbxPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPosition.FormattingEnabled = true;
            this.CbxPosition.ItemHeight = 15;
            this.CbxPosition.Location = new System.Drawing.Point(85, 92);
            this.CbxPosition.Name = "CbxPosition";
            this.CbxPosition.Size = new System.Drawing.Size(110, 21);
            this.CbxPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxPosition.TabIndex = 10;
            // 
            // LbPosition
            // 
            this.LbPosition.AutoSize = true;
            // 
            // 
            // 
            this.LbPosition.BackgroundStyle.Class = "";
            this.LbPosition.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbPosition.Location = new System.Drawing.Point(15, 95);
            this.LbPosition.Name = "LbPosition";
            this.LbPosition.Size = new System.Drawing.Size(68, 18);
            this.LbPosition.TabIndex = 9;
            this.LbPosition.Text = "显示位置：";
            // 
            // CbxRoot
            // 
            this.CbxRoot.DisplayMember = "Text";
            this.CbxRoot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRoot.FormattingEnabled = true;
            this.CbxRoot.ItemHeight = 15;
            this.CbxRoot.Location = new System.Drawing.Point(259, 65);
            this.CbxRoot.Name = "CbxRoot";
            this.CbxRoot.Size = new System.Drawing.Size(110, 21);
            this.CbxRoot.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxRoot.TabIndex = 8;
            // 
            // LbImage
            // 
            this.LbImage.AutoSize = true;
            // 
            // 
            // 
            this.LbImage.BackgroundStyle.Class = "";
            this.LbImage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbImage.Location = new System.Drawing.Point(203, 95);
            this.LbImage.Name = "LbImage";
            this.LbImage.Size = new System.Drawing.Size(56, 18);
            this.LbImage.TabIndex = 11;
            this.LbImage.Text = "图  标：";
            // 
            // LbClass
            // 
            this.LbClass.AutoSize = true;
            // 
            // 
            // 
            this.LbClass.BackgroundStyle.Class = "";
            this.LbClass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbClass.Location = new System.Drawing.Point(15, 40);
            this.LbClass.Name = "LbClass";
            this.LbClass.Size = new System.Drawing.Size(68, 18);
            this.LbClass.TabIndex = 3;
            this.LbClass.Text = "模块路径：";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            // 
            // 
            // 
            this.LbName.BackgroundStyle.Class = "";
            this.LbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbName.Location = new System.Drawing.Point(15, 13);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(68, 18);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "模块名称：";
            // 
            // CbxType
            // 
            this.CbxType.DisplayMember = "Text";
            this.CbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.ItemHeight = 15;
            this.CbxType.Location = new System.Drawing.Point(85, 65);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(110, 21);
            this.CbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxType.TabIndex = 6;
            this.CbxType.SelectedIndexChanged += new System.EventHandler(this.CbxType_SelectedIndexChanged);
            // 
            // LbRoot
            // 
            this.LbRoot.AutoSize = true;
            // 
            // 
            // 
            this.LbRoot.BackgroundStyle.Class = "";
            this.LbRoot.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbRoot.Location = new System.Drawing.Point(203, 67);
            this.LbRoot.Name = "LbRoot";
            this.LbRoot.Size = new System.Drawing.Size(56, 18);
            this.LbRoot.TabIndex = 7;
            this.LbRoot.Text = "根节点：";
            // 
            // LbType
            // 
            this.LbType.AutoSize = true;
            // 
            // 
            // 
            this.LbType.BackgroundStyle.Class = "";
            this.LbType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbType.Location = new System.Drawing.Point(15, 68);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(68, 18);
            this.LbType.TabIndex = 5;
            this.LbType.Text = "所属类型：";
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Location = new System.Drawing.Point(294, 128);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "保 存";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbxImage
            // 
            this.CbxImage.DisplayMember = "Text";
            this.CbxImage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxImage.FormattingEnabled = true;
            this.CbxImage.ItemHeight = 15;
            this.CbxImage.Location = new System.Drawing.Point(259, 92);
            this.CbxImage.Name = "CbxImage";
            this.CbxImage.Size = new System.Drawing.Size(110, 21);
            this.CbxImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxImage.TabIndex = 12;
            // 
            // TbxClass
            // 
            // 
            // 
            // 
            this.TbxClass.Border.Class = "TextBoxBorder";
            this.TbxClass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxClass.Location = new System.Drawing.Point(85, 38);
            this.TbxClass.Name = "TbxClass";
            this.TbxClass.Size = new System.Drawing.Size(284, 21);
            this.TbxClass.TabIndex = 4;
            // 
            // TbxName
            // 
            // 
            // 
            // 
            this.TbxName.Border.Class = "TextBoxBorder";
            this.TbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxName.Location = new System.Drawing.Point(85, 11);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(284, 21);
            this.TbxName.TabIndex = 2;
            this.SuperValidator.SetValidator1(this.TbxName, this.RequiredFieldValidator);
            // 
            // SuperValidator
            // 
            this.SuperValidator.ContainerControl = this;
            this.SuperValidator.ErrorProvider = this.ErrorProvider;
            this.SuperValidator.Highlighter = this.Highlighter;
            this.SuperValidator.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // RequiredFieldValidator
            // 
            this.RequiredFieldValidator.ErrorMessage = "不能为空！";
            this.RequiredFieldValidator.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // FrmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 163);
            this.Controls.Add(this.PnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.FrmModule_Load);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlMain;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxClass;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxImage;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.Validator.SuperValidator SuperValidator;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter Highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator RequiredFieldValidator;
        private DevComponents.DotNetBar.LabelX LbRoot;
        private DevComponents.DotNetBar.LabelX LbType;
        private DevComponents.DotNetBar.LabelX LbImage;
        private DevComponents.DotNetBar.LabelX LbClass;
        private DevComponents.DotNetBar.LabelX LbName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxRoot;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxPosition;
        private DevComponents.DotNetBar.LabelX LbPosition;

    }
}