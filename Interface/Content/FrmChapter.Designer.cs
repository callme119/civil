namespace Framework.Interface.Content
{
    partial class FrmChapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChapter));
            this.SuperValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.TbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.RequiredFieldValidator = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("不能为空！");
            this.PnlMain = new DevComponents.DotNetBar.PanelEx();
            this.CbxSpecialType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CbxBasicType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.CbxModel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbModule = new DevComponents.DotNetBar.LabelX();
            this.LbModel = new DevComponents.DotNetBar.LabelX();
            this.CbxModule = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbParent = new DevComponents.DotNetBar.LabelX();
            this.LbState = new DevComponents.DotNetBar.LabelX();
            this.LbDescription = new DevComponents.DotNetBar.LabelX();
            this.LbName = new DevComponents.DotNetBar.LabelX();
            this.LbBelong = new DevComponents.DotNetBar.LabelX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.CbxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TbxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuperValidator
            // 
            this.SuperValidator.ContainerControl = this;
            this.SuperValidator.ErrorProvider = this.ErrorProvider;
            this.SuperValidator.Highlighter = this.Highlighter;
            this.SuperValidator.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
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
            // TbxName
            // 
            // 
            // 
            // 
            this.TbxName.Border.Class = "TextBoxBorder";
            this.TbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxName.Location = new System.Drawing.Point(92, 39);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(337, 21);
            this.TbxName.TabIndex = 4;
            this.SuperValidator.SetValidator1(this.TbxName, this.RequiredFieldValidator);
            // 
            // RequiredFieldValidator
            // 
            this.RequiredFieldValidator.ErrorMessage = "不能为空！";
            this.RequiredFieldValidator.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // PnlMain
            // 
            this.PnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlMain.Controls.Add(this.CbxSpecialType);
            this.PnlMain.Controls.Add(this.CbxBasicType);
            this.PnlMain.Controls.Add(this.labelX1);
            this.PnlMain.Controls.Add(this.CbxModel);
            this.PnlMain.Controls.Add(this.LbModule);
            this.PnlMain.Controls.Add(this.LbModel);
            this.PnlMain.Controls.Add(this.CbxModule);
            this.PnlMain.Controls.Add(this.LbParent);
            this.PnlMain.Controls.Add(this.LbState);
            this.PnlMain.Controls.Add(this.LbDescription);
            this.PnlMain.Controls.Add(this.LbName);
            this.PnlMain.Controls.Add(this.LbBelong);
            this.PnlMain.Controls.Add(this.BtnSave);
            this.PnlMain.Controls.Add(this.CbxState);
            this.PnlMain.Controls.Add(this.TbxDescription);
            this.PnlMain.Controls.Add(this.TbxName);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(458, 188);
            this.PnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlMain.Style.GradientAngle = 90;
            this.PnlMain.TabIndex = 0;
            // 
            // CbxSpecialType
            // 
            // 
            // 
            // 
            this.CbxSpecialType.BackgroundStyle.Class = "";
            this.CbxSpecialType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CbxSpecialType.Location = new System.Drawing.Point(198, 146);
            this.CbxSpecialType.Name = "CbxSpecialType";
            this.CbxSpecialType.Size = new System.Drawing.Size(114, 23);
            this.CbxSpecialType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxSpecialType.TabIndex = 13;
            this.CbxSpecialType.Text = "脚手架专项工程";
            // 
            // CbxBasicType
            // 
            // 
            // 
            // 
            this.CbxBasicType.BackgroundStyle.Class = "";
            this.CbxBasicType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CbxBasicType.Location = new System.Drawing.Point(92, 145);
            this.CbxBasicType.Name = "CbxBasicType";
            this.CbxBasicType.Size = new System.Drawing.Size(100, 23);
            this.CbxBasicType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxBasicType.TabIndex = 13;
            this.CbxBasicType.Text = "基本工程类型";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 150);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 18);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "工程类型：";
            // 
            // CbxModel
            // 
            this.CbxModel.DisplayMember = "Text";
            this.CbxModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxModel.FormattingEnabled = true;
            this.CbxModel.ItemHeight = 15;
            this.CbxModel.Location = new System.Drawing.Point(92, 117);
            this.CbxModel.Name = "CbxModel";
            this.CbxModel.Size = new System.Drawing.Size(170, 21);
            this.CbxModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxModel.TabIndex = 10;
            // 
            // LbModule
            // 
            this.LbModule.AutoSize = true;
            // 
            // 
            // 
            this.LbModule.BackgroundStyle.Class = "";
            this.LbModule.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbModule.Location = new System.Drawing.Point(22, 94);
            this.LbModule.Name = "LbModule";
            this.LbModule.Size = new System.Drawing.Size(68, 18);
            this.LbModule.TabIndex = 11;
            this.LbModule.Text = "使用模块：";
            // 
            // LbModel
            // 
            this.LbModel.AutoSize = true;
            // 
            // 
            // 
            this.LbModel.BackgroundStyle.Class = "";
            this.LbModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbModel.Location = new System.Drawing.Point(22, 120);
            this.LbModel.Name = "LbModel";
            this.LbModel.Size = new System.Drawing.Size(68, 18);
            this.LbModel.TabIndex = 9;
            this.LbModel.Text = "选择模型：";
            // 
            // CbxModule
            // 
            this.CbxModule.DisplayMember = "Text";
            this.CbxModule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxModule.FormattingEnabled = true;
            this.CbxModule.ItemHeight = 15;
            this.CbxModule.Location = new System.Drawing.Point(92, 91);
            this.CbxModule.Name = "CbxModule";
            this.CbxModule.Size = new System.Drawing.Size(169, 21);
            this.CbxModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxModule.TabIndex = 10;
            // 
            // LbParent
            // 
            this.LbParent.AutoSize = true;
            // 
            // 
            // 
            this.LbParent.BackgroundStyle.Class = "";
            this.LbParent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbParent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbParent.ForeColor = System.Drawing.Color.Red;
            this.LbParent.Location = new System.Drawing.Point(96, 14);
            this.LbParent.Name = "LbParent";
            this.LbParent.Size = new System.Drawing.Size(36, 20);
            this.LbParent.TabIndex = 2;
            this.LbParent.Text = "顶级";
            // 
            // LbState
            // 
            this.LbState.AutoSize = true;
            // 
            // 
            // 
            this.LbState.BackgroundStyle.Class = "";
            this.LbState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbState.Location = new System.Drawing.Point(272, 94);
            this.LbState.Name = "LbState";
            this.LbState.Size = new System.Drawing.Size(68, 18);
            this.LbState.TabIndex = 7;
            this.LbState.Text = "使用状态：";
            // 
            // LbDescription
            // 
            this.LbDescription.AutoSize = true;
            // 
            // 
            // 
            this.LbDescription.BackgroundStyle.Class = "";
            this.LbDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbDescription.Location = new System.Drawing.Point(22, 68);
            this.LbDescription.Name = "LbDescription";
            this.LbDescription.Size = new System.Drawing.Size(68, 18);
            this.LbDescription.TabIndex = 5;
            this.LbDescription.Text = "详细描述：";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            // 
            // 
            // 
            this.LbName.BackgroundStyle.Class = "";
            this.LbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbName.Location = new System.Drawing.Point(22, 41);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(68, 18);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "章节名称：";
            // 
            // LbBelong
            // 
            this.LbBelong.AutoSize = true;
            // 
            // 
            // 
            this.LbBelong.BackgroundStyle.Class = "";
            this.LbBelong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbBelong.Location = new System.Drawing.Point(22, 16);
            this.LbBelong.Name = "LbBelong";
            this.LbBelong.Size = new System.Drawing.Size(68, 18);
            this.LbBelong.TabIndex = 1;
            this.LbBelong.Text = "所属章节：";
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Location = new System.Drawing.Point(354, 146);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "保 存";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbxState
            // 
            this.CbxState.DisplayMember = "Text";
            this.CbxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxState.FormattingEnabled = true;
            this.CbxState.ItemHeight = 15;
            this.CbxState.Location = new System.Drawing.Point(341, 91);
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(88, 21);
            this.CbxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxState.TabIndex = 8;
            // 
            // TbxDescription
            // 
            // 
            // 
            // 
            this.TbxDescription.Border.Class = "TextBoxBorder";
            this.TbxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxDescription.Location = new System.Drawing.Point(92, 65);
            this.TbxDescription.Name = "TbxDescription";
            this.TbxDescription.Size = new System.Drawing.Size(337, 21);
            this.TbxDescription.TabIndex = 6;
            // 
            // FrmChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 188);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmChapter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "章节管理";
            this.Load += new System.EventHandler(this.FrmChapter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Validator.SuperValidator SuperValidator;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter Highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator RequiredFieldValidator;
        private DevComponents.DotNetBar.PanelEx PnlMain;
        private DevComponents.DotNetBar.LabelX LbParent;
        private DevComponents.DotNetBar.LabelX LbState;
        private DevComponents.DotNetBar.LabelX LbDescription;
        private DevComponents.DotNetBar.LabelX LbName;
        private DevComponents.DotNetBar.LabelX LbBelong;
        private DevComponents.DotNetBar.ButtonX BtnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxState;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxName;
        private DevComponents.DotNetBar.LabelX LbModule;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxModule;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxModel;
        private DevComponents.DotNetBar.LabelX LbModel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX CbxSpecialType;
        private DevComponents.DotNetBar.Controls.CheckBoxX CbxBasicType;

    }
}