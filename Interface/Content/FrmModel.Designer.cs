namespace Framework.Interface.Content
{
    partial class FrmModel
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
            this.PnlMain = new DevComponents.DotNetBar.PanelEx();
            this.BtnAdd = new DevComponents.DotNetBar.ButtonX();
            this.CbxState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LbState = new DevComponents.DotNetBar.LabelX();
            this.TbxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbDescription = new DevComponents.DotNetBar.LabelX();
            this.TbxClass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbClass = new DevComponents.DotNetBar.LabelX();
            this.TbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LbName = new DevComponents.DotNetBar.LabelX();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PnlMain.Controls.Add(this.BtnAdd);
            this.PnlMain.Controls.Add(this.CbxState);
            this.PnlMain.Controls.Add(this.LbState);
            this.PnlMain.Controls.Add(this.TbxDescription);
            this.PnlMain.Controls.Add(this.LbDescription);
            this.PnlMain.Controls.Add(this.TbxClass);
            this.PnlMain.Controls.Add(this.LbClass);
            this.PnlMain.Controls.Add(this.TbxName);
            this.PnlMain.Controls.Add(this.LbName);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(362, 192);
            this.PnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlMain.Style.GradientAngle = 90;
            this.PnlMain.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnAdd.Location = new System.Drawing.Point(263, 151);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "保 存";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CbxState
            // 
            this.CbxState.DisplayMember = "Text";
            this.CbxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxState.FormattingEnabled = true;
            this.CbxState.ItemHeight = 15;
            this.CbxState.Location = new System.Drawing.Point(104, 126);
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(121, 21);
            this.CbxState.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxState.TabIndex = 8;
            // 
            // LbState
            // 
            this.LbState.AutoSize = true;
            // 
            // 
            // 
            this.LbState.BackgroundStyle.Class = "";
            this.LbState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbState.Location = new System.Drawing.Point(30, 129);
            this.LbState.Name = "LbState";
            this.LbState.Size = new System.Drawing.Size(68, 18);
            this.LbState.TabIndex = 7;
            this.LbState.Text = "使用状态：";
            // 
            // TbxDescription
            // 
            // 
            // 
            // 
            this.TbxDescription.Border.Class = "TextBoxBorder";
            this.TbxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxDescription.Location = new System.Drawing.Point(104, 90);
            this.TbxDescription.Name = "TbxDescription";
            this.TbxDescription.Size = new System.Drawing.Size(181, 21);
            this.TbxDescription.TabIndex = 6;
            // 
            // LbDescription
            // 
            this.LbDescription.AutoSize = true;
            // 
            // 
            // 
            this.LbDescription.BackgroundStyle.Class = "";
            this.LbDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbDescription.Location = new System.Drawing.Point(30, 93);
            this.LbDescription.Name = "LbDescription";
            this.LbDescription.Size = new System.Drawing.Size(68, 18);
            this.LbDescription.TabIndex = 5;
            this.LbDescription.Text = "模型描述：";
            // 
            // TbxClass
            // 
            // 
            // 
            // 
            this.TbxClass.Border.Class = "TextBoxBorder";
            this.TbxClass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxClass.Location = new System.Drawing.Point(104, 54);
            this.TbxClass.Name = "TbxClass";
            this.TbxClass.Size = new System.Drawing.Size(181, 21);
            this.TbxClass.TabIndex = 4;
            // 
            // LbClass
            // 
            this.LbClass.AutoSize = true;
            // 
            // 
            // 
            this.LbClass.BackgroundStyle.Class = "";
            this.LbClass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbClass.Location = new System.Drawing.Point(30, 57);
            this.LbClass.Name = "LbClass";
            this.LbClass.Size = new System.Drawing.Size(68, 18);
            this.LbClass.TabIndex = 3;
            this.LbClass.Text = "模型路径：";
            // 
            // TbxName
            // 
            // 
            // 
            // 
            this.TbxName.Border.Class = "TextBoxBorder";
            this.TbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TbxName.Location = new System.Drawing.Point(104, 18);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(181, 21);
            this.TbxName.TabIndex = 2;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            // 
            // 
            // 
            this.LbName.BackgroundStyle.Class = "";
            this.LbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbName.Location = new System.Drawing.Point(30, 21);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(68, 18);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "模型名称：";
            // 
            // FrmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 192);
            this.Controls.Add(this.PnlMain);
            this.Name = "FrmModel";
            this.Text = "模型管理";
            this.Load += new System.EventHandler(this.FrmModel_Load);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PnlMain;
        private DevComponents.DotNetBar.LabelX LbName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbxState;
        private DevComponents.DotNetBar.LabelX LbState;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxDescription;
        private DevComponents.DotNetBar.LabelX LbDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxClass;
        private DevComponents.DotNetBar.LabelX LbClass;
        private DevComponents.DotNetBar.Controls.TextBoxX TbxName;
        private DevComponents.DotNetBar.ButtonX BtnAdd;

    }
}