using System;
using System.Windows.Forms;
namespace Framework.Interface.Common
{
    public partial class WinWordControlEx : System.Windows.Forms.UserControl
    {
        public static string copyPath = System.Windows.Forms.Application.StartupPath + @"\tmp\copy.doc";
        public string CopyPath { get { return copyPath; } }

        public static string showPath = System.Windows.Forms.Application.StartupPath + @"\tmp\show.doc";
        public string ShowPath { get { return showPath; } }

        public static string randomPath;
        public string RandomPath { get { return System.Windows.Forms.Application.StartupPath + @"\tmp\" + System.DateTime.Now.ToFileTime() + ".doc"; } }

        public static string tempPath = System.Windows.Forms.Application.StartupPath + @"\tmp\temp.doc";

        private object missing = System.Reflection.Missing.Value;

        public WinWordControlEx()
        {
            InitializeComponent();
            ObjWinWordControl.CloseControl();
            ObjWinWordControl.document = null;
            WinWordControl.WinWordControl.wd = null;
            WinWordControl.WinWordControl.wordWnd = 0;
        }

        public void LoadWord(string path)
        {
            ObjWinWordControl.LoadDocument(path);
        }

        public void SaveWord(string path)
        {
            object FileName = path;
            ObjWinWordControl.document.SaveAs(ref FileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        public byte[] GetWordStream(string path)
        {
            SaveWord(path);
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

        public void CreateShowFile()
        {
            System.IO.File.Delete(showPath);//删除指定文件
            System.IO.File.Copy(System.Windows.Forms.Application.StartupPath + @"\tmp\Word.doc", showPath);//将现有文件复制到新文件
        }

        public void SetWordStream(byte[] buffByte, string path)
        {
            CreateTempFile(buffByte, path);
            LoadWord(path);
        }

        public string GetWordString(string path)
        {
            byte[] b = GetWordStream(path);
            return System.Convert.ToBase64String(b);
        }

        public void SetWordString(string str, string path)
        {
            SetWordStream(System.Convert.FromBase64String(str), path);
        }

        public bool Replace(string strOldText, string strNewText)
        {
            ObjWinWordControl.document.Content.Find.Text = strOldText;
            
            object FindText, ReplaceWith, Replace;
            FindText = strOldText;
            ReplaceWith = strNewText;
            Replace = Word.WdReplace.wdReplaceAll;
            ObjWinWordControl.document.Content.Find.ClearFormatting();
            if (ObjWinWordControl.document.Content.Find.Execute(ref FindText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref ReplaceWith, ref Replace, ref missing, ref missing, ref missing, ref missing))
            {
                return true;
            }
            return false;
        }

        public bool Replace(byte[] buffByte, string strOldText)
        {
            
            CreateTempFile(buffByte, tempPath);
            
            ObjWinWordControl.document.Content.Find.Text = strOldText;
            object FindText, ReplaceWith, Replace;
            FindText = strOldText;
            ReplaceWith = "";
            Replace = Word.WdReplace.wdReplaceOne;
            
           //ref Object Range,
            object ConfirmConversions = false, Link = false, Attachment = false;
      
            ObjWinWordControl.document.Words.Application.Selection.Find.ClearFormatting();
            if (ObjWinWordControl.document.Words.Application.Selection.Find.Execute(ref FindText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref ReplaceWith, ref Replace, ref missing, ref missing, ref missing, ref missing))
            {
                ObjWinWordControl.document.Words.Application.Selection.Range.InsertFile(tempPath, ref missing, ref ConfirmConversions, ref Link, ref Attachment);//定位起始位置
                return true;
            }
            return false;
        }


        public bool Replace(string strOldText, string strNewText, string path)
        {
            object missing = System.Reflection.Missing.Value;
            Word._Application wapp = new Word.ApplicationClass();
            wapp.Visible = false;
            object OBJpath = path;
            object text1 = strOldText;
            object text2 = strNewText;
            object Replace = Word.WdReplace.wdReplaceAll;
            wapp.Documents.Open(ref OBJpath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            wapp.Selection.Find.Execute(ref text1, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref text2, ref Replace, ref missing, ref missing, ref missing, ref missing);
            object SaveChangs = true;
            object OriginalFormat = System.Type.Missing;
            object RouteDocument = System.Type.Missing;
            wapp.Quit(ref SaveChangs, ref OriginalFormat, ref RouteDocument);
            return true;
        }
        /// <summary>
        /// 删除word文档中相应的内容
        /// </summary>
        /// <param name="startText">起始字符</param>
        /// <param name="endText">终止字符</param>
        /// <param name="path">文档路径</param>
        /// <returns></returns>
        public bool DeleteText(string startText, string endText, string path)
        {
            object OBJpath = path;
            object missing = System.Reflection.Missing.Value;
            Word._Application wapp = new Word.ApplicationClass();
            Word.Document wdoc = new Word.Document();
            wdoc = wapp.Documents.Open(ref OBJpath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            Word.Selection tihuanwenzi = wapp.Selection;
            
            wapp.Options.ReplaceSelection = true;
            wapp.Selection.Find.Forward = true;
            wapp.Selection.Find.MatchWholeWord = true;
            object startstr = startText;
            object endstr = endText;
            wapp.Selection.Find.ClearFormatting();
            wapp.Selection.Find.Execute(ref startstr, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            object start = wapp.Selection.Range.Start;//定位起始位置
            wapp.Selection.Find.ClearFormatting();
            wapp.Selection.Find.Execute(ref endstr, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            object end = wapp.Selection.Range.End;//定义终止位置
            object unit = Type.Missing;
            
            object count = Type.Missing;
            wdoc.Range(ref start, ref end).Delete(ref unit, ref count);//删除操作
            object SaveChangs = true;
            object OriginalFormat = System.Type.Missing;
            object RouteDocument = System.Type.Missing;
            wapp.Documents.Close(ref missing, ref missing, ref missing);
            wapp.Quit(ref SaveChangs, ref OriginalFormat, ref RouteDocument);
            return true;
        }
        /// <summary>
        /// 删除word文档中相应的内容
        /// </summary>
        /// <param name="startText">起始字符</param>
        /// <param name="endText">终止字符</param>
        /// <param name="path">文档路径</param>
        /// <returns></returns>
        public bool DeleteText(string startText, string endText)
        {
            ObjWinWordControl.document.Content.Find.Text = startText;
            object FindText, ReplaceWith, Replace;
            FindText = startText;
            ReplaceWith = "";
            Replace = Word.WdReplace.wdReplaceOne;
            object start, end;
            //ref Object Range,
            object ConfirmConversions = false, Link = false, Attachment = false;
            
            ObjWinWordControl.document.Words.Application.Selection.Find.ClearFormatting();
            if (ObjWinWordControl.document.Words.Application.Selection.Find.Execute(ref FindText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref ReplaceWith, ref Replace, ref missing, ref missing, ref missing, ref missing))
            {
                start = ObjWinWordControl.document.Words.Application.Selection.Range.Start;
                FindText = endText;
                if (ObjWinWordControl.document.Words.Application.Selection.Find.Execute(ref FindText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref ReplaceWith, ref Replace, ref missing, ref missing, ref missing, ref missing))
                {
                    object unit = Type.Missing;

                    object count = Type.Missing;
                    end = ObjWinWordControl.document.Words.Application.Selection.Range.End;
                    ObjWinWordControl.document.Range(ref start,ref end).Delete(ref unit, ref count);//删除操作
                
                    return true;
                }
            }
            return false;
            //object OBJpath = path;
            //object missing = System.Reflection.Missing.Value;
            //Word._Application wapp = new Word.ApplicationClass();
            //Word.Document wdoc = new Word.Document();
            //wdoc = wapp.Documents.Open(ref OBJpath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            //Word.Selection tihuanwenzi = wapp.Selection;

            //wapp.Options.ReplaceSelection = true;
            //wapp.Selection.Find.Forward = true;
            //wapp.Selection.Find.MatchWholeWord = true;
            //object startstr = startText;
            //object endstr = endText;
            //wapp.Selection.Find.ClearFormatting();
            //wapp.Selection.Find.Execute(ref startstr, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            //object start = wapp.Selection.Range.Start;//定位起始位置
            //wapp.Selection.Find.ClearFormatting();
            //wapp.Selection.Find.Execute(ref endstr, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            //object end = wapp.Selection.Range.End;//定义终止位置
            //object unit = Type.Missing;

            //object count = Type.Missing;
            //wdoc.Range(ref start, ref end).Delete(ref unit, ref count);//删除操作
            //object SaveChangs = true;
            //object OriginalFormat = System.Type.Missing;
            //object RouteDocument = System.Type.Missing;
            //wapp.Documents.Close(ref missing, ref missing, ref missing);
            //wapp.Quit(ref SaveChangs, ref OriginalFormat, ref RouteDocument);
            //return true;
        }
        public void MoveToTop()
        {
            //以下是设置光标在文档的最上端
            object unith = Word.WdUnits.wdStory;//表格行方式
            object extend = Word.WdMovementType.wdExtend;/**//**//**////extend对光标移动区域进行扩展选择
            ObjWinWordControl.document.Words.Application.Selection.HomeKey(ref unith, ref extend);

            return;
        }
        public void InsertFile(string path)
        {

            Word.ApplicationClass applicationClass = new Word.ApplicationClass();
            object fileName = showPath;
            Word.Document doct = applicationClass.Documents.Open(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            doct.Activate();
            object confirmConversion = false;
            object link = false;
            object attachment = false;
            applicationClass.Selection.InsertFile(path, ref missing, ref confirmConversion, ref link, ref attachment);
            object pBreak = (int)Word.WdBreakType.wdPageBreak;
            applicationClass.Selection.InsertBreak(ref pBreak);
            doct.SaveAs(ref   fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            ((Word._Document)doct).Close(ref missing, ref missing, ref missing);
        }

        public void AddRtf(string rtf)
        {
            string path = RandomPath;
            System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Rtf = rtf;
            richTextBox.SaveFile(path);
            InsertFile(path);
        }

        public void AddDoc(string doc)
        {
            string path = RandomPath;
            byte[] buffByte = System.Convert.FromBase64String(doc);
            CreateTempFile(buffByte, path);
            InsertFile(path);
        }

        public void InsertTable(int tableNum, int startRow, System.Collections.ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                ObjWinWordControl.document.Tables.Item(tableNum).Rows.Add(ref missing);
                object[] obj = (object[])array[i];
                for (int j = 0; j < obj.Length; j++)
                {
                    if (obj[j] == null)
                    {
                        ObjWinWordControl.document.Tables.Item(tableNum).Cell(startRow + i, j + 1).Range.Text = "";
                    }
                    else
                        ObjWinWordControl.document.Tables.Item(tableNum).Cell(startRow + i, j + 1).Range.Text = obj[j].ToString();
                }
            }
        }

        public void InsertChart(System.Data.DataTable dtsheet)
        {
            Graph.Chart wrdChart;
            Graph.Axis axis;
            object ClassType = "MSGraph.Chart";
            wrdChart = (Graph.Chart)ObjWinWordControl.document.InlineShapes.AddOLEObject(ref ClassType, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing).OLEFormat.Object;
            wrdChart.ChartType = Graph.XlChartType.xlXYScatterSmooth;
            axis = (Graph.Axis)wrdChart.Axes(2, 1);
            axis.MaximumScale = 1;
            int i, j;
            for (i = 0; i < dtsheet.Columns.Count; i++)
            {
                wrdChart.Application.DataSheet.Cells[i + 1, 1] = dtsheet.Columns[i].ColumnName;
            }
            for (i = 0; i < dtsheet.Rows.Count; i++)
            {
                for (j = 0; j < dtsheet.Columns.Count; j++)
                {
                    wrdChart.Application.DataSheet.Cells[i + 2, j + 1] = dtsheet.Rows[i][j];
                }
            }
            wrdChart.Application.PlotBy = Graph.XlRowCol.xlColumns;
            wrdChart.Height = 100;
            wrdChart.Application.Update();
            wrdChart.Application.Quit();
        }
        public void InsertPic(string text,string path)
        {
            ObjWinWordControl.document.Content.Find.Text = text;

            object FindText, ReplaceWith, Replace;
            FindText = text;
            ReplaceWith = "";
            Replace = Word.WdReplace.wdReplaceOne;
            ObjWinWordControl.document.Words.Application.Selection.Find.ClearFormatting();
            if (ObjWinWordControl.document.Words.Application.Selection.Find.Execute(ref FindText, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref ReplaceWith, ref Replace, ref missing, ref missing, ref missing, ref missing))
            {
                object Range = ObjWinWordControl.document.Words.Application.Selection.Range;//定位起始位置

                ObjWinWordControl.document.Words.Application.Selection.Font.Bold = 1;
                ObjWinWordControl.document.Words.Application.Selection.Font.Size = 18;

                ObjWinWordControl.document.Words.Application.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWinWordControl.document.Words.Application.Selection.InlineShapes.AddPicture(System.Windows.Forms.Application.StartupPath + @"\temp.jpg", ref missing, ref missing, ref Range);
                

            }
            //return false;

            #region 曾经用过
            //object OBJpath = path;
            //object missing = System.Reflection.Missing.Value;
            //Word._Application wapp = new Word.ApplicationClass();
            //Word.Document wdoc = new Word.Document();
            //wdoc = wapp.Documents.Open(ref OBJpath, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            //Word.Selection tihuanwenzi = wapp.Selection;
            //wapp.Visible = false;
            //wapp.Options.ReplaceSelection = true;
            //wapp.Selection.Find.Forward = true;
            //wapp.Selection.Find.MatchWholeWord = true;
            //object findstr = text;
            //wapp.Selection.Find.ClearFormatting();
            //wapp.Selection.Find.Execute(ref findstr, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            //object Range = wapp.Selection.Range;//定位起始位置

            //wapp.Visible = true;
            //wapp.Selection.Font.Bold = 1;
            //wapp.Selection.Font.Size = 18;

            //wapp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //wapp.Selection.InlineShapes.AddPicture(System.Windows.Forms.Application.StartupPath + @"\temp.jpg", ref missing, ref missing, ref Range);

            //object SaveChangs = true;
            //object OriginalFormat = System.Type.Missing;
            //object RouteDocument = System.Type.Missing;
            //wapp.Documents.Close(ref missing, ref missing, ref missing);
            //wapp.Quit(ref SaveChangs, ref OriginalFormat, ref RouteDocument);
            #endregion
            return;
        }
        public void InsertTitle(string title, string level)
        {
            object missing = System.Reflection.Missing.Value;
            Word._Application app = new Word.Application();
            object path = RandomPath;
            Word.Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            doc.Activate();
            Word.Range range = doc.Paragraphs.Last.Range;//定位到段尾
            //range.InsertParagraphAfter();
           
          

            range.Text = level + "." + title;
            range.Font.Italic = 1;
            range.Font.Color = Word.WdColor.wdColorBlue;

            //object styleName = "标题 3";
            //range.set_Style(ref styleName);
            doc.SaveAs(ref path, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            app.Quit(ref missing, ref missing, ref missing);
            InsertFile(path.ToString());
        }
        public void InsertBT()
        {
            object missing = System.Reflection.Missing.Value;
            Word._Application app = new Word.Application();
            object path = RandomPath;
            //object fileName = @"\tmp\show.doc";
            // Word.Document doc = app.Documents.Open(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            //doc.Activate();
            Word.Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            doc.Activate();
            Word.Range range = doc.Paragraphs.Last.Range;//定位到段尾
            range.Text = "脚手架专项施工方案";
            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;//文字居中
            //object styleName = "标题 2"; 
           // range.set_Style(ref styleName);
            range.Font.Size = 20;
            range.Font.Name = "黑体";
            range.Font.Bold = 1;

            doc.SaveAs(ref path, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            app.Quit(ref missing, ref missing, ref missing);
            InsertFile(path.ToString());

            //range.InsertParagraphAfter();
        }
    
    
    
    
    
    
     
    }
}