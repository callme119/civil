namespace Framework.Interface.Project
{
    partial class FrmProjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectInfo));
            this.PnlMain = new DevComponents.DotNetBar.PanelEx();
            this.BtnSubmit = new DevComponents.DotNetBar.ButtonX();
            this.CbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbType = new DevComponents.DotNetBar.LabelX();
            this.LbName = new DevComponents.DotNetBar.LabelX();
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
            this.PnlMain.Controls.Add(this.BtnSubmit);
            this.PnlMain.Controls.Add(this.CbxType);
            this.PnlMain.Controls.Add(this.TbxName);
            this.PnlMain.Controls.Add(this.LbType);
            this.PnlMain.Controls.Add(this.LbName);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(338, 117);
            this.PnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlMain.Style.GradientAngle = 90;
            this.PnlMain.TabIndex = 0;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSubmit.Location = new System.Drawing.Point(223, 78);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "确 定";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CbxType
            // 
            this.CbxType.DisplayMember = "Text";
            this.CbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.ItemHeight = 15;
            this.CbxType.Location = new System.Drawing.Point(91, 46);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(132, 21);
            this.CbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxType.TabIndex = 4;
            // 
            // TbxName
            // 
            // 
            // 
            // 
            this.TbxName.Border.Class = "TextBoxBorder";
            this.TbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxName.Location = new System.Drawing.Point(91, 18);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(207, 21);
            this.TbxName.TabIndex = 2;
            this.SuperValidator.SetValidator1(this.TbxName, this.RequiredFieldValidator);
            // 
            // LbType
            // 
            // 
            // 
            // 
            this.LbType.BackgroundStyle.Class = "";
            this.LbType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbType.Location = new System.Drawing.Point(24, 47);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(75, 23);
            this.LbType.TabIndex = 3;
            this.LbType.Text = "工程类型：";
            // 
            // LbName
            // 
            // 
            // 
            // 
            this.LbName.BackgroundStyle.Class = "";
            this.LbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbName.Location = new System.Drawing.Point(24, 19);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(75, 23);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "工程名称：";
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
            // FrmProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 117);
            this.ControlBox = false;
            this.Controls.Add(this.PnlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工程信息";
            this.Load += new System.EventHandler(this.FrmProjectInfo_Load);
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlMain;
        private DevComponents.DotNetBar.ButtonX BtnSubmit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxType;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxName;
        private DevComponents.DotNetBar.LabelX LbType;
        private DevComponents.DotNetBar.LabelX LbName;
        private DevComponents.DotNetBar.Validator.SuperValidator SuperValidator;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter Highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator RequiredFieldValidator;

    }
}