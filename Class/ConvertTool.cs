namespace Framework.Class
{
    public static class ConvertTool
    {
        public static string RTF_HEAD = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset134 \\'cb\\'ce\\'cc\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18";
        public static string RTF_TAIL = "\\par\r\n}\r\n";

        public static string ConvertRtfToString(string rtf)
        {
            System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Rtf = rtf;
            return richTextBox.Text;
        }

        public static string ConvertStringToRtf(string str)
        {
            System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Text = str;
            richTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            return richTextBox.Rtf;
        }

        public static string FormatRtf(string rtf)
        {
            rtf = rtf.Replace(RTF_HEAD, "");
            rtf = rtf.Replace(RTF_TAIL, "");
            return rtf;
        }
    }
}