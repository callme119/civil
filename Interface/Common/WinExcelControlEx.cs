namespace Framework.Interface.Common
{
    public partial class WinExcelControlEx : System.Windows.Forms.UserControl
    {
        private static Excel.Workbook wbb = null;
        private object missing = System.Reflection.Missing.Value;

        private static string copyPath = System.Windows.Forms.Application.StartupPath + @"\tmp\copy.xls";
        public string CopyPath { get { return copyPath; } }

        private static string showPath = System.Windows.Forms.Application.StartupPath + @"\tmp\show.xls";
        public string ShowPath { get { return showPath; } }

        public static string randomPath;
        public string RandomPath { get { return System.Windows.Forms.Application.StartupPath + @"\tmp\" + System.DateTime.Now.ToFileTime() + ".xls"; } }

        public WinExcelControlEx()
        {
            InitializeComponent();
        }

        private void WebBrowser_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            object[] args = new object[4];
            args[0] = SHDocVw.OLECMDID.OLECMDID_HIDETOOLBARS;
            args[1] = SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER;
            args[2] = missing;
            args[3] = missing;
            object axWebBrowser = this.WebBrowser.ActiveXInstance;
            axWebBrowser.GetType().InvokeMember("ExecWB", System.Reflection.BindingFlags.InvokeMethod, null, axWebBrowser, args);
            object oApplication = axWebBrowser.GetType().InvokeMember("Document", System.Reflection.BindingFlags.GetProperty, null, axWebBrowser, null);
            wbb = (Excel.Workbook)oApplication;
        }

        public void ShowExcel(string path)
        {
            this.WebBrowser.Navigate(path);
        }

        public void ShowExcel(byte[] buffByte, string path)
        {
            CreateTempFile(buffByte, path);
            ShowExcel(path);
        }

        public byte[] GetExcelStream(string path)
        {
            System.IO.File.Copy(path, CopyPath, true);
            System.IO.FileStream fs = new System.IO.FileStream(CopyPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] buffByte = new byte[fs.Length];
            fs.Read(buffByte, 0, (int)fs.Length);
            fs.Close();
            fs = null;
            System.IO.File.Delete(CopyPath);
            return buffByte;
        }

        public void CreateTempFile(byte[] buffByte, string path)
        {
            System.IO.FileStream fs;
            System.IO.FileInfo fi = new System.IO.FileInfo(path);
            fs = fi.OpenWrite();
            fs.Write(buffByte, 0, buffByte.Length);
            fs.Close();
        }

        public void CloseExcel()
        {
            wbb.Save();
            wbb.Close(true, System.Type.Missing, System.Type.Missing);
            wbb.Application.Quit();
        }

        public string CopyToWord()
        {
            object filename = @"C:\" + System.DateTime.Now.ToFileTime() + ".doc";
            Word._Application application = new Word.ApplicationClass();
            Word._Document document = application.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            foreach (Excel.Worksheet sheet in wbb.Sheets)
            {
                if (sheet.Index == wbb.Sheets.Count)
                {
                    continue;
                }
                for (int i = 1; i < sheet.UsedRange.Rows.Count; i++)
                {
                    Word.Paragraph para = document.Paragraphs.Add(ref missing);
                    string text = "";
                    for (int j = 1; j < sheet.UsedRange.Columns.Count; j++)
                    {
                        Excel.Range range = (Excel.Range)sheet.Cells[i, j];
                        if (range.Value2 != null)
                        {
                            text += range.Value2.ToString() + "\t";
                            if (range.Value2.ToString().StartsWith("#picture"))
                            {
                                string[] value = System.Text.RegularExpressions.Regex.Split(range.Value2.ToString(), "_");
                                Excel.Shape shape = sheet.Shapes.Item(int.Parse(value[1])) as Excel.Shape;
                                shape.CopyPicture(Excel.XlPictureAppearance.xlScreen, Excel.XlCopyPictureFormat.xlBitmap);
                                Word.Paragraph picture = document.Paragraphs.Add(ref missing);
                                picture.Range.Paste();
                                picture.Format.CharacterUnitFirstLineIndent = 2;
                                picture.Range.InsertParagraphAfter();
                                text = "";
                                i += int.Parse(value[2]) - 1;
                                break;
                            }
                        }
                    }
                    para.Range.Text = text;
                    para.Format.CharacterUnitFirstLineIndent = 2;
                    para.Range.InsertParagraphAfter();
                }
            }
            document.SaveAs(ref filename, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            document.Close(ref missing, ref missing, ref missing);
            application.Quit(ref missing, ref missing, ref missing);
            return filename.ToString();
        }
    }
}