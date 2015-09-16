namespace Framework.Interface.Common
{
    public partial class RichTextBoxEx : System.Windows.Forms.UserControl
    {
        public RichTextBoxEx()
        {
            InitializeComponent();
            InitComboBoxItems();
        }

        public void LoadFile(string path)
        {
            RichTextBox.LoadFile(path);
        }

        public string GetContent()
        {
            return RichTextBox.Rtf;
        }

        public void SetContent(string content)
        {
            RichTextBox.Rtf = content;
        }

        private void InitComboBoxItems()
        {
            int counter = 0;
            int selected = 0;
            foreach (System.Drawing.FontFamily family in System.Drawing.FontFamily.Families)
            {
                this.ItemFamily.Items.Add(family.Name);
                if (family.Name.Equals("宋体")) selected = counter;
                counter++;
            }
            this.ItemFamily.SelectedIndex = selected;
            this.ItemSize.Items.AddRange(Framework.Class.FontSize.FontSizeList.ToArray());
            this.ItemSize.SelectedIndex = 1;
        }

        private void ItemFamily_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.RichTextBox.SelectionFont = new System.Drawing.Font(this.ItemFamily.Text, this.RichTextBox.SelectionFont.Size, this.RichTextBox.SelectionFont.Style);
        }

        private void ItemSize_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int size = (this.ItemSize.SelectedItem == null) ? 1 : (this.ItemSize.SelectedItem as Framework.Class.FontSize).Value;
            this.RichTextBox.SelectionFont = new System.Drawing.Font(this.RichTextBox.SelectionFont.FontFamily, size, this.RichTextBox.SelectionFont.Style);
        }

        private void ItemBold_Click(object sender, System.EventArgs e)
        {
            System.Drawing.Font oldFont = this.RichTextBox.SelectionFont;
            System.Drawing.Font newFont;
            if (oldFont.Bold)
            {
                newFont = new System.Drawing.Font(oldFont, oldFont.Style & ~System.Drawing.FontStyle.Bold);
            }
            else
            {
                newFont = new System.Drawing.Font(oldFont, oldFont.Style | System.Drawing.FontStyle.Bold);
            }
            RichTextBox.SelectionFont = newFont;
        }

        private void ItemItalic_Click(object sender, System.EventArgs e)
        {
            System.Drawing.Font licFont = this.RichTextBox.SelectionFont;
            System.Drawing.Font newFont;
            if (licFont.Italic)
            {
                newFont = new System.Drawing.Font(licFont, licFont.Style & ~System.Drawing.FontStyle.Italic);
            }
            else
            {
                newFont = new System.Drawing.Font(licFont, licFont.Style | System.Drawing.FontStyle.Italic);
            }
            this.RichTextBox.SelectionFont = newFont;
        }

        private void ItemUnder_Click(object sender, System.EventArgs e)
        {
            System.Drawing.Font lineFont = this.RichTextBox.SelectionFont;
            System.Drawing.Font newFont;
            if (lineFont.Underline)
            {
                newFont = new System.Drawing.Font(lineFont, lineFont.Style & ~System.Drawing.FontStyle.Underline);
            }
            else
            {
                newFont = new System.Drawing.Font(lineFont, lineFont.Style | System.Drawing.FontStyle.Underline);
            }
            this.RichTextBox.SelectionFont = newFont;
        }

        private void ItemColor_SelectedColorChanged(object sender, System.EventArgs e)
        {
            this.RichTextBox.SelectionColor = this.ItemColor.SelectedColor;
        }
    }
}