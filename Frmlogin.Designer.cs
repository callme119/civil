namespace Framework
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AuthorityType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.butlogin = new DevComponents.DotNetBar.ButtonX();
            this.butquit = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 443);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(415, 172);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(108, 21);
            this.textBoxX1.TabIndex = 4;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(415, 199);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PasswordChar = '*';
            this.textBoxX2.Size = new System.Drawing.Size(108, 21);
            this.textBoxX2.TabIndex = 5;
            // 
            // AuthorityType
            // 
            this.AuthorityType.DisplayMember = "Text";
            this.AuthorityType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AuthorityType.FormattingEnabled = true;
            this.AuthorityType.ItemHeight = 15;
            this.AuthorityType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.AuthorityType.Location = new System.Drawing.Point(415, 226);
            this.AuthorityType.Name = "AuthorityType";
            this.AuthorityType.Size = new System.Drawing.Size(108, 21);
            this.AuthorityType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AuthorityType.TabIndex = 9;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "supuser";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "comuser";
            // 
            // butlogin
            // 
            this.butlogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butlogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butlogin.Image = ((System.Drawing.Image)(resources.GetObject("butlogin.Image")));
            this.butlogin.Location = new System.Drawing.Point(415, 253);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(44, 21);
            this.butlogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butlogin.TabIndex = 10;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butquit
            // 
            this.butquit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butquit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.butquit.Image = ((System.Drawing.Image)(resources.GetObject("butquit.Image")));
            this.butquit.Location = new System.Drawing.Point(480, 253);
            this.butquit.Name = "butquit";
            this.butquit.Size = new System.Drawing.Size(43, 21);
            this.butquit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butquit.TabIndex = 11;
            this.butquit.Click += new System.EventHandler(this.butquit_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(765, 442);
            this.Controls.Add(this.butquit);
            this.Controls.Add(this.butlogin);
            this.Controls.Add(this.AuthorityType);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx AuthorityType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX butlogin;
        private DevComponents.DotNetBar.ButtonX butquit;
    }
}