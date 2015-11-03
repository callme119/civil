namespace Framework.Interface.Workbench
{
    public partial class UclCustom : System.Windows.Forms.UserControl
    {
        private Framework.Entity.Chapter chapter;
        private string path;
        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        Framework.Entity.Template tempInsertText;
        public UclCustom()
        {
            InitializeComponent();
            this.Height = 550;
            this.Width = 740;
        }

        private void UclCustom_Load(object sender, System.EventArgs e)
        {
            chapter = (Framework.Entity.Chapter)this.Tag;
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            if (!element.GetAttribute("DOC").Equals(""))
            {
                path = WinWordControlEx.RandomPath;
                WinWordControlEx.SetWordString(element.GetAttribute("DOC"), path);
            }
            else
            {
                Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
                System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));

                ShowFrmProfile(model, ass);
            }
        }

        private void CreateModule(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data)//2.定义Delegate将引用的静态方法或引用类实例及该类的实例方法
        {
            path = WinWordControlEx.RandomPath;

            WinWordControlEx.CreateTempFile(template.Content, path);
            WinWordControlEx.LoadWord(path);
            if (@class.GetType().Equals(new Framework.Model.UseWater().GetType()))
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);// //WinWordControlEx.InsertTable(1, 3, array);//表显示,括号内三项含义依次为“文档中第1个表；从该表的第3行开始插入；向表中插入的数据”
                }
                string[] keys = new string[] { "&K1", "&K2", "&K3", "&K4", "&K5", "&K6", "&T1", "&B1", "&B2", "&SUM1", "&SUM2", "&SUM3", "&SUM4", "&Q1", "&Q2", "&Q3", "&Q4", "&Q5", "&QSUM", "&V", "&D1", "&D2" };
                ReplaceString(keys, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.UsePower().GetType()))
            {
                string[] keys = new string[] { "&P1", "&P2", "&P3", "&P4", "&Cos", "&K1", "&K2", "&K3", "&K4", "&SUM" };
                ReplaceString(keys, data);
            }

            else if (@class.GetType().Equals(new Framework.Model.ConcreteProject().GetType()))
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }
                string[] keys = new string[] { "&D1", "&D2", "&D3" };
                ReplaceString(keys, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.ConstructPrepare().GetType()))
            {
                #region //选出“工序措施”后，与其对应的内容自动生成在文档中的相应位置。
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[11].ToString()) - 1; i++) //data[11] = numLength,通过data[11].ToString()确定选择的脚手架类型的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$"; //每添加一种脚手架类型，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord, path);
                for (int i = 0; i < System.Convert.ToInt16(data[11].ToString()); i++) //用文字图标等内容，把文档中的“$1$”替换掉
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$"); //调用的是Replace(byte[] buffByte, string strOldText, string path)
                }
                #endregion


                WinWordControlEx.InsertTable(1, 2, (System.Collections.ArrayList)array[0]);
                WinWordControlEx.InsertTable(3, 2, (System.Collections.ArrayList)array[1]);
                WinWordControlEx.InsertTable(4, 2, (System.Collections.ArrayList)array[2]);
            }
            else if (@class.GetType().Equals(new Framework.Model.ClimateFeature().GetType()))
            {
                #region //将选中的冬雨季施工工程添加到文档的相应位置
                object[] obj = (object[])array[array.Count - 1];
                int num1; //标示DatGridview3表的中选中的个数
                num1 = System.Convert.ToInt16(obj[0].ToString());
                for (int i = 0; i < num1; i++)
                {
                    object[] obj1 = (object[])array[i];
                    if (i == (num1 - 1))
                    {
                        WinWordControlEx.Replace("@1@", obj1[0].ToString());
                    }
                    else
                    {
                        WinWordControlEx.Replace("@1@", obj1[0].ToString() + "、@1@");
                    }
                }
                for (int i = num1; i < array.Count - 1; i++)
                {
                    object[] obj2 = (object[])array[i];
                    if (i == (array.Count - 2))
                    {
                        WinWordControlEx.Replace("@2@", obj2[0].ToString());
                    }
                    else
                    {
                        WinWordControlEx.Replace("@2@", obj2[0].ToString() + "、@2@");
                    }
                }
                #endregion

                string[] keys = new string[] { "&XX", "&aa", "&bb", "&cc", "&dd", "&ee", "&ff", "&gg", "&qq", "&ww", "&sY", "&sM", "&sD", "&endY", "&endM", "&endD" };
                ReplaceString(keys, data);

            }
            else if (@class.GetType().Equals(new Framework.Model.RainConstruct().GetType()))
            {
                #region //选出“工序措施”后，与其对应的内容自动生成在文档中的相应位置。
                string NewWord = "$1$";
                for (int i = 0; i < System.Convert.ToInt16(data[11].ToString()) - 1; i++) //data[11] = numLength,通过data[11].ToString()确定选择的脚手架类型的数目，从而确定需要几个“$1$”符
                {
                    NewWord += "\n$1$"; //每添加一种脚手架类型，模板文档中就多添加一个“$1$”符号
                }
                WinWordControlEx.Replace("$1$", NewWord, path);

                for (int i = 0; i < System.Convert.ToInt16(data[11].ToString()); i++) //用文字图标等内容，把文档中的“$1$”替换掉
                {
                    tempInsertText = contentService.GetTemplateByTitle(data[i].ToString());
                    WinWordControlEx.Replace(tempInsertText.Content, "$1$");
                }
                #endregion

                #region //以“表格版”“文字版”形式向文档中插入信息
                for (int i = 0; i < array.Count; i++) //雨季施工防雨材料以表格形式插入到文档中
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }

                string[] keys = new string[] { "&D1", "&D2", "&D3" };
                for (int i = 12; i < 15; i++) //工作组成员，以文字形式插入到文档中
                {
                    object[] dataNew = new object[] { data[12].ToString(), data[13].ToString(), data[14].ToString() };
                    ReplaceString(keys, dataNew);
                }
                #endregion
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldMaterialCalculate().GetType()))//4.2脚手架用料计算
            {
                #region
                if (template.Title == "双排脚手架用料计算")
                {
                    string[] keys = new string[] { "@DbInput_MaterialDSGD@", "@DbInput_MaterialDSCD@", "@DbInput_MaterialLGZJ@", 
                                                            "@DbInput_MaterialLGHJ@", "@DbInput_MaterialBJ@", "@DbInput_MaterialLQJL@", 
                                                            "@Tb_MaterialWCDHGQZ@", "@Cb_MaterialJDCSZ@", "@IntInput_MaterialJDCKYBJ@", 
                                                            "@IntInput_MaterialJDCKYLGZJ@", "@IntInput_MaterialJDCJGLGZJ@", "@DBIput_MaterialCLYLXS@",
                                                            "@LySum1" , "@LySum2" , "@LySum3" , "@LySum4" , "@LySum5" , "@LySum6" , "@LySum7" , "@LySum8" , "@LySum9" 
                                                          };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "单排脚手架用料计算")
                {
                    string[] keys = new string[] { "@DbInput_MaterialDSGD@", "@DbInput_MaterialDSCD@", "@DbInput_MaterialLGZJ@", 
                                                            "@DbInput_MaterialLGHJ@", "@DbInput_MaterialBJ@", "@DbInput_MaterialLQJL@", 
                                                            "@Tb_MaterialWCDHGQZ@", "@Cb_MaterialJDCSZ@", "@IntInput_MaterialJDCKYBJ@", 
                                                            "@IntInput_MaterialJDCKYLGZJ@", "@IntInput_MaterialJDCJGLGZJ@", "@DBIput_MaterialCLYLXS@",
                                                            "@LySum1" , "@LySum2" , "@LySum3" , "@LySum4" , "@LySum5" , "@LySum6" , "@LySum7" , "@LySum8" , "@LySum9" 
                                                          };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "碗扣式脚手架用料计算")
                {
                    string[] keys = new string[] { "@Ly2_1@", "@Ly2_2@", "@Ly2_3@", "@Ly2_4@", "@Ly2_5@", "@Gkzg@", "@Ly2_6@", "@Gkhg@", "@Gkjhg@", "@Ly2_7@", "@Gkl@", "@Gkl3@", "@Ly2_8@", "@Gkwg@", "@Ly2_9@", "@Gksg@", "@Ly2_10@", "@Gklg@", "@Ly2_11@", "@Gkdz@",
                                                                "@Ly2_12@", "@Ly2_13@", "@Ly2_14@", "@Ly2_15@", "@Ly2_16@", "@Ly2_17@", "@Ly2_18@", "@Ly2_19@", "@Ly2_20@",
                                                                "@Ly2Sum1@", "@Ly2Sum2@", "@Ly2Sum3@", "@Ly2Sum4@", "@Ly2Sum5@", "@Ly2Sum6@", "@Ly2Sum7@", "@Ly2Sum8@", "@Ly2Sum9@", "@Ly2Sum10@", "@Ly2Sum11@", "@Ly2Sum12@","Cbx_Item2JHG"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "吊篮脚手架用料计算")
                {
                    string[] keys = new string[] { "@Ly4_1@", "@Ly4_2@", "@Ly4_3@", "@Ly4_4@", "@Ly4_5@", "@Ly4_6@", "@Ly4_7@", "@Ly4_8@", "@Ly4_9@", "@Ly4_10@", "@Ly4_11@",
                                                                "@Ly4_12@", "@Ly4_13@", "@Ly4_14@", "@Ly4_15@", "@Ly4_16@", "@Ly4_17@", "@Ly4_18@", "@Ly4_19@", "@Ly4_20@","@Ly4_21@","@Ly4_22@","@Ly4_23@","@Ly4_24@","@Ly4_25@",
                                                                "@Ly4Sum1@", "@Ly4Sum2@", "@Ly4Sum3@", "@Ly4Sum4@", "@Ly4Sum5@", "@Ly4Sum6@", "@Ly4Sum7@", "@Ly4Sum8@", "@Ly4Sum9@", "@Ly4Sum10@", "@Ly4Sum11@", "@Ly4Sum12@","@Ly4Sum13@","@Ly4Sum14@","@Ly4Sum15@","@Ly4Sum16@",
                                                                "@compare1@","@compare2@","@compare3@","@compare4@","@compare5@"
                                                              };
                    ReplaceString(keys, data);
                }
                #endregion
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldPowerCalculate().GetType()))//4.1脚手架力学计算
            {
                #region 双排
                if (template.Title == "双排大横杆在上")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { 
                                                                    "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                    "@pc2_2@","@pc2_7@",
                                                                    "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                    "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                    "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                    "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                    "@pc7_1@","@μz@",
                                                                    "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                    "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                     "@Sum1D1P2@",  "@Sum1D1Q@",  "@Sum1D1q1@",  "@Sum1D1q2@",  "@Sum1D2M1@",  "@Sum1D2M2@",  "@Sum1D2δ@", "@CompareD2δ@",  "@Sum1D3q1@",  "@Sum1D3V@", "@CompareD3V@",
                                                                     "@Sum1X1P1@",  "@Sum1X1P2@",  "@Sum1X1Q@",  "@Sum1X1P@",  "@Sum1X1M@",  "@Sum1X2δ@",  "@CompareX2δ@", "@Sum1X3V1@",  "@Sum1X3P@",  "@Sum1X3V2@",  "@Sum1X3V@", "@CompareX3V1@",
                                                                     "@Sum1K1P1@", "@Sum1K1P2@" , "@Sum1K1Q@" ,  "@Sum1K1R@", "@CompareK1R@",
                                                                     "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                     "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                     "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                     "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                     "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "双排小横杆在上立杆纵距la2")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "双排小横杆在上立杆纵距la")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                #endregion
                #region 悬挑
                else if (template.Title == "悬挑大横杆在上")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { 
                                                                    "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                    "@pc2_2@","@pc2_7@",
                                                                    "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                    "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                    "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                    "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                    "@pc7_1@","@μz@",
                                                                    "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                    "@pc10_1@","@pc10_2@","@pc10_3@","@pc10_4@","@pc10_5@" ,
                                                                     "@pc11_1@","@pc11_2@","@pc11_3@",
                                                                     "@Sum1D1P2@",  "@Sum1D1Q@",  "@Sum1D1q1@",  "@Sum1D1q2@",  "@Sum1D2M1@",  "@Sum1D2M2@",  "@Sum1D2δ@", "@CompareD2δ@",  "@Sum1D3q1@",  "@Sum1D3V@", "@CompareD3V@",
                                                                     "@Sum1X1P1@",  "@Sum1X1P2@",  "@Sum1X1Q@",  "@Sum1X1P@",  "@Sum1X1M@",  "@Sum1X2δ@",  "@CompareX2δ@", "@Sum1X3V1@",  "@Sum1X3P@",  "@Sum1X3V2@",  "@Sum1X3V@", "@CompareX3V1@",
                                                                     "@Sum1K1P1@", "@Sum1K1P2@" , "@Sum1K1Q@" ,  "@Sum1K1R@", "@CompareK1R@",
                                                                     "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                     "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                     "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                     "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                      "@weightParam@",  "@wxParam@", "@Sum4N1@",  "@Sum4q1@",  "@Sum4k@",  "@Sum4k1@",  "@Sum4k2@",  "@Sum4RA@",  "@Sum4RB@",  "@Sum4MA@",  "@Sum4f@",  "@Sum4N2@",  "@Sum4q2@",  "@Sum4Vmax@",  "@CompareXgf@","@CompareVmax@",
                                                                      "@Sum4Φb1@","@Sum4Φb@",  "@Sum4σ1@" ,"@strSum4Φb@",  "@CompareΦbσ@",
                                                                      "@Sum4σ2@", "@Sum4Mgd@", "@Sum4d@",  "@fc@" , "@Sum4fc@", "@Sum4Lsll@" , "@CompareLhsl@" , "@CompareLsll@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "悬挑小横杆在上立杆纵距la2")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc10_1@","@pc10_2@","@pc10_3@","@pc10_4@","@pc10_5@" ,
                                                                "@pc11_1@","@pc11_2@","@pc11_3@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@weightParam@",  "@wxParam@", "@Sum4N1@",  "@Sum4q1@",  "@Sum4k@",  "@Sum4k1@",  "@Sum4k2@",  "@Sum4RA@",  "@Sum4RB@",  "@Sum4MA@",  "@Sum4f@",  "@Sum4N2@",  "@Sum4q2@",  "@Sum4Vmax@",   "@CompareXgf@", "@CompareVmax@",
                                                                  "@Sum4Φb1@","@Sum4Φb@",  "@Sum4σ1@" ,"@strSum4Φb@",  "@CompareΦbσ@",
                                                                  "@Sum4σ2@", "@Sum4Mgd@", "@Sum4d@",  "@fc@" , "@Sum4fc@", "@Sum4Lsll@" , "@CompareLhsl@" , "@CompareLsll@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "悬挑小横杆在上立杆纵距la")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc10_1@","@pc10_2@","@pc10_3@","@pc10_4@","@pc10_5@" ,
                                                                "@pc11_1@","@pc11_2@","@pc11_3@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@weightParam@",  "@wxParam@", "@Sum4N1@",  "@Sum4q1@",  "@Sum4k@",  "@Sum4k1@",  "@Sum4k2@",  "@Sum4RA@",  "@Sum4RB@",  "@Sum4MA@",  "@Sum4f@",  "@Sum4N2@",  "@Sum4q2@",  "@Sum4Vmax@",  "@CompareXgf@", "@CompareVmax@",
                                                                 "@Sum4Φb1@","@Sum4Φb@",  "@Sum4σ1@" ,"@strSum4Φb@",  "@CompareΦbσ@",
                                                                  "@Sum4σ2@", "@Sum4Mgd@", "@Sum4d@",  "@fc@" , "@Sum4fc@", "@Sum4Lsll@" , "@CompareLhsl@" , "@CompareLsll@"
                                                              };
                    ReplaceString(keys, data);
                }
                #endregion
                #region 单排
                else if (template.Title == "单排大横杆在上")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { 
                                                                    "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                    "@pc2_2@","@pc2_7@",
                                                                    "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                    "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                    "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                    "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                    "@pc7_1@","@μz@",
                                                                    "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                    "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                     "@Sum1D1P2@",  "@Sum1D1Q@",  "@Sum1D1q1@",  "@Sum1D1q2@",  "@Sum1D2M1@",  "@Sum1D2M2@",  "@Sum1D2δ@", "@CompareD2δ@",  "@Sum1D3q1@",  "@Sum1D3V@", "@CompareD3V@",
                                                                     "@Sum1X1P1@",  "@Sum1X1P2@",  "@Sum1X1Q@",  "@Sum1X1P@",  "@Sum1X1M@",  "@Sum1X2δ@",  "@CompareX2δ@", "@Sum1X3V1@",  "@Sum1X3P@",  "@Sum1X3V2@",  "@Sum1X3V@", "@CompareX3V1@",
                                                                     "@Sum1K1P1@", "@Sum1K1P2@" , "@Sum1K1Q@" ,  "@Sum1K1R@", "@CompareK1R@",
                                                                     "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                     "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                     "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                     "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                     "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "单排小横杆在上立杆纵距la2")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "单排小横杆在上立杆纵距la")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {
                                                                "@pc1_1@" , "@pc1_2@" , "@pc1_3@" ,"@pc1_4@", "@pc1_5@", "@pc1_6@", "@pc1_7@", "@pc1_8@", "@pc1_9@", "@pc1_10@",
                                                                "@pc2_1@","@pc2_4@","@pc2_5@",
                                                                "@pc3_1@","@pc3_2@","@pc3_3@",
                                                                "@pc4_1@","@pc4_2@","@pc4_3@","@pc4_4@","@pc4_5@","@pc4_6@","@gk@",
                                                                "@pc5_1@","@pc5_2@","@pc5_3@",
                                                                "@pc6_1@","@pc6_2@","@pc6_4@",
                                                                "@pc7_1@","@μz@",
                                                                "@pc8_1@","@pc8_2@","@pc8_3@","@pc8_12@","@pc8_13@","@μs@",
                                                                "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@",
                                                                 "@Sum2X1q2@" ,  "@Sum2X1dQ@",  "@Sum2X1xq@",  "@Sum2X2M@",  "@Sum2X2δ@",  "@Sum2X3V1@", "@Compare2X2δ@", "@Compare2X3V1@",
                                                                 "@Sum2D1Fk@",  "@Sum2D1F@",  "@Sum2D2Mmax@",  "@Sum2D2δ@",  "@Sum2D3V@", "@Compare2D2δ@", "@Compare2D3V@",
                                                                 "@Sum2KR@", "@Compare2K1R@",
                                                                 "@Sum1NG1@",  "@Sum1NG2@",  "@Sum1NG3@",  "@Sum1NG4@",  "@Sum1NG@",  "@Sum1NQ@",  "@Sum1Wk@",  "@Sum1YesN@",  "@Sum1NoN@",  "@Sum1MW@",
                                                                 "@LgU@",  "@LgL0@",  "@LgΦ@",  "@Sum1Noδ@", "@CompareNoδ@", "@Sum1Yesδ@", "@CompareYesδ@",
                                                                 "@Sum1NG2K@",  "@Sum1Mwk@" , "@Sum1NoHs@",  "@Sum1YesHs@", "@CompareHs@",
                                                                 "@Sum1Aw@",  "@Sum1Nlw@",  "@Sum1Nl@" , "@Sum1Lqjδ@", "@CompareF1@",  "@Sum1NlΦA@",  "@LqjΦ@", "@CompareF2@",
                                                                 "@Sum1NK@",  "@Sum1A@",  "@Sum1Pk@", "@Sum1fg@", "@Comparefg@"
                                                              };
                    ReplaceString(keys, data);
                }
                #endregion
                #region 门式
                else if (template.Title == "门式钢管脚手架(扣件连接)")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {"@k@",  "@MF@","@weightMF@", "@h0@", "@h1@", "@h2@", "@b@", "@b1@", "@r1@", "@r2@", "@r3@", "@r4@", "@i1@", "@I2@" , "@A@", "@A1@",
                                                                 "@pc12_5@", "@pc12_6@", "@pc12_7@", "@pc12_5@", "@pc12_8@", "@pc12_92" ,
                                                                 "@pc13_1@",  "@pc13_2@",  "@pc13_3@",  "@pc13_4@",  "@pc13_7@", "@pc13_8@",
                                                                  "@pc14_1@", "@pc14_2@", "@weightSPJ@", "@pc14_3@", "@weightJSB@", "@NG1@", "@pc14_4@", "@pc14_5@", "@pc14_6@", "@NG2@", "@NG@",  "@pc14_7@", "@pc14_8@", "@pc14_9@",
                                                                  "@pc6_1@", "@pc6_2@", "@pc6_4@",  "@pc7_1@", "@μz@", 
                                                                  "@μs@", "@pc15_5@", "@pc15_6@", "@pc15_7@", "@pc15_8@", "@pc15_9@",
                                                                   "@SumNQ@", "@SumN1@" ,"@SumWk@", "@SumQk@", "@SumN2@", "@maxN@", "@SumΦ1@", "@SumNd@", "@ComparerNdN@", 
                                                                    "@SumHd@", "@SumHdw@", "@SumHs@", "@ComparerHsH@",
                                                                    "@SumA@", "@SumP@", "@SumFg@", "@ComparerFgP@",
                                                                     "@SumNw@", "@SumNc@", "@SumΦ2@", "@SumNf@", "@ComparerLQJ@"
                                                                };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "门式钢管脚手架(焊缝连接)")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { "@k@",  "@MF@", "@weightMF@", "@h0@", "@h1@", "@h2@", "@b@", "@b1@", "@r1@", "@r2@", "@r3@", "@r4@", "@i1@", "@I2@" , "@A@", "@A1@",
                                                                 "@pc12_5@", "@pc12_6@", "@pc12_7@", "@pc12_5@", "@pc12_8@", "@pc12_92" ,
                                                                 "@pc13_1@",  "@pc13_2@",  "@pc13_3@",  "@pc13_4@",  "@pc13_7@", "@pc13_8@",
                                                                  "@pc14_1@", "@pc14_2@", "@weightSPJ@", "@pc14_3@", "@weightJSB@", "@NG1@", "@pc14_4@", "@pc14_5@", "@pc14_6@", "@NG2@", "@NG@",  "@pc14_7@", "@pc14_8@", "@pc14_9@",
                                                                  "@pc6_1@", "@pc6_2@", "@pc6_4@",  "@pc7_1@", "@μz@", 
                                                                  "@μs@", "@pc15_5@", "@pc15_6@", "@pc15_7@", "@pc15_8@", "@pc15_9@",
                                                                   "@SumNQ@", "@SumN1@" ,"@SumWk@", "@SumQk@", "@SumN2@", "@maxN@", "@SumΦ1@", "@SumNd@", "@ComparerNdN@", 
                                                                    "@SumHd@", "@SumHdw@", "@SumHs@", "@ComparerHsH@",
                                                                    "@SumA@", "@SumP@", "@SumFg@", "@ComparerFgP@",
                                                                   "@SumNw@", "@SumNc@",  "@ComparerLQJ@"
                                                                };
                    ReplaceString(keys, data);
                }
                #endregion
                #region 碗扣
                else if (template.Title == "碗扣式脚手架")
                {
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {  "@pc5_1@","@pc5_2@","@pc5_3@","@pc5_4@",
                                                    "@pc6_1@","@pc6_2@","@pc6_4@", "@DbInput_Item6Uz@","@pc7_1@","@μz@",
                                                    "@pc9_1@","@pc9_2@","@pc9_3@","@pc9_4@","@pc9_5@","@Cb_Item9DJLX@",
                                                    "@pc16_1@",  "@pc16_2@",  "@pc16_3@",  "@pc16_4@",  "@pc16_5@",  "@pc16_6@",  "@pc16_7@",  "@pc16_8@",  "@pc16_9@",  "@pc16_10@",  "@pc16_11@",  "@pc16_12@",  "@pc16_13@",  "@pc16_14@",  "@pc16_15@",  "@pc16_1@", 
                                                    "@pc17_1@", "@pc17_2@", "@pc17_3@", "@pc17_4@", "@pc17_5@", "@pc17_6@",  "@pc17_9@", "@pc17_10@", "@pc17_11@", 
                                                    "@Gkzg@", "@Gkhg@", "@Gkjhg@", "@Gkl@","@Gkl3@", "@Gkwg@", "@Gksg@", "@Gklg@",
                                                    "@sum10Hq1@", "@sum10Hq2@", "@sum10HMmax@", "@sum10Hσ@", "@sum10HVmax@", "@sum10HVmin@","@compareHσ@", "@compareHVmaxVmin@", "@compareHτdb@","@sum10HR1@","@sum10HR2@","@sum10Hτdb@",
                                                    "@sum10Jq1@", "@sum10Jq2@", "@sum10JMmax@", "@sum10Jσ@", "@sum10JVmax@", "@sum10JVmin@", "@sum10JR1@", "@sum10JR2@", "@sum10Jτdb@","@compareJσ@","@compareJVmaxVmin@","@compareJτdb@",
                                                    "@sum10Zq1@", "@sum10Zq2@", "@sum10Zτdb1@", "@sum10Zτdb2@","@str10Zσ@", "@str10Zτdb1@", "@compareZσ@", "@compareZτdb1@", "@compareZτdb2@" ,
                                                    "@NG1k1@", "@NG1k2@", "@NG1k3@", "@NG1k4@", "@NG1k5@", "@NG1k6@", "@NG1k7@", "@sum10NG1k@","@NG2k1@", "@NG2k2@", "@NG2k3@", "@sum10NG2k@","@NQ1k@", "@sum10Nw1@", "@sum10Nw2@", "@sum10N1@", "@sum10N2@", "@sum10Wk@",
                                                    "@pcWk@", "@Wkλ@", "@WkNoφ@", "@sum10Noσ@", "@sum10Mw@" , "@sum10NE@","@sum10Yesσ@","@strWkλ@", "@compareWKNoσ@", "@compareWKYesσ@",
                                                    "@sum10Nc@", "@wkLqjφ@", "@sum10NcN0Ac@", "@wkLqjλ@","@strNcN0Ac@", "@compareNcN0Ac@", "@strNcN0@","@compareNcN0@",
                                                    "@sum10h@" ,"@compareSum10h@",
                                                    "@compareNN0@",
                                                    "@sum10Ag@","@sum10fg@","@compareWkfg@"};
                    ReplaceString(keys, data);
                    if (data[7].ToString() == "岩石" || data[7].ToString() == "混凝土")
                    {
                        WinWordControlEx.DeleteText("$2$", "$2$");
                        WinWordControlEx.Replace("$1$", "");
                    }
                    else
                    {
                        WinWordControlEx.DeleteText("$1$", "$1$");
                        WinWordControlEx.Replace("$2$", "");
                    }

                }
                #endregion
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldRecommendSelect().GetType()))//2.2 脚手架推荐选型
            {
                SelectTjSelf(template, array, @class, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldSelfSelect().GetType()))//2.2脚手架自行选型
            {
                SelectTjSelf(template, array, @class, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldSchematicDiagram().GetType()))//5脚手架绘图
            {
                WinWordControlEx.InsertPic("$1$", path);
                string[] keys = new string[] { "@1@", "$1$" };
                ReplaceString(keys, data);
            }
            else if (@class.GetType().Equals(new Framework.Model.ScaffoldAssessment().GetType()))//5脚手架绘图
            { }
            else if (@class.GetType().Equals(new Framework.Model.Formwork().GetType()))//板模板
            {
                if (template.Title == "板模板(工具式)")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { "@fk1_1@","@fk1_2@","@fk1_3@","@fk1_4@","@fk1_5@","@fk1_6@","@fk1_7@","@fk1_8@","@fk1_9@","@fk1_10@",
                        "@fk1_11@","@fk1_12@","@fk1_13@","@fk1_13_2@","@fk1_14@","@fk2_1@","@fk2_2@","@fk2_3@","@fk2_4@","@fk2_5@","@fk3_1@","@fk3_2@",
                        "@fk3_3@","@fk3_4@","@fk3_5@","@fk3_6@","@fk3_7@","@fk3_8@","@fk3_9@","@fk3_10@","@fk4_1@","@fk4_2@","@fk4_3@","@fk4_4@","@fk4_5@",
                        "@fk4_6@","@fk4_7@","@fk4_8@","@fk4_9@","@fk4_10@","@fk5_1@","@fk5_2@","@fk5_3@","@fk5_4@","@fk5_5@","@fk5_6@","@fk5_7@","@fk5_8@",
                        "@fk5_9@","@fk5_10@","@fk5_11@","@fk5_12@","@fk5_13@","@fk5_14@","@fk5_15@","@fk5_16@","@fk5_17@","@fk7_1@","@fk7_2@","@fk7_3@",
                        "@fk7_4@","@fk7_5@","@fk7_6@","@fk7_7@","@fk8_1@","@fk8_2@","@fk8_3@","@fk8_4@","@fk8_5@","@fk8_6@","@fk8_7@","@fk8_8@","@fk8_9@",
                        "@fk8_10@","@fk8_11@","@sum1I@","@sum1W@","@sum1G1k@","@sum1G2k@","@sum1G3k@","@sum1Gk@","@sum1Q1k@","@sum1P@","@sum1q@","@sum1q11@",
                        "@sum1q22@","@sum1q1@","@sum1P1@","@sum1q2@","@sum1P2@","@sum1M@","@sum1MA@","@sum1MB1@","@sum1MB2@","@sum1σ@","@sum1ν@","@sum1ν2@",
                        "@compare1_1@","@compare1_2@","@sum2n@","@sum2min@","@sum2max@","@sum2G1k@","@sum2G2k@","@sum2G3k@","@sum2Gk@","@sum2Q1k@","@sum2P@",
                        "@sum2qa11@","@sum2qa12@","@sum2qa21@","@sum2qa22@","@sum2q1@","@sum2P1@","@sum2q2@","@sum2P2@","@sum2MA1@","@sum2MA2@","@sum2MB1@",
                        "@sum2MB2@","@sum2M@","@sum2σ@","@sum2VA1@","@sum2VA2@","@sum2VB1@","@sum2VB2@","@sum2V@","@sum2τ@","@sum2q@","@sum2kzν@","@sum2kzν2@",
                        "@sum2xbdν@","@sum2xbdν2@","@compare2_1@","@compare2_2@","@compare2_3@","@compare2_4@","@sum3G1k@","@sum3G2k@","@sum3G3k@","@sum3Gk@",
                        "@sum3Q1k@","@sum3q11@","@sum3q12@","@sum3q21@","@sum3q22@","@sum3F1@","@sum3F2@","@sum3FA@","@sum3FB@","@sum3q1@","@sum3q2@","@sum3n@",
                        "@sum3min@","@sum3M@","@sum3V@","@sum3ν@","@sum3σ@","@sum3τ@","@sum3ν2@","@compare3_1@","@compare3_2@","@compare3_3@","@sum4_1λ@",
                        "@sum4_1λ2@","@sum4_1φ@","@sum4_1G1k@","@sum4_1G2k@","@sum4_1G3k@","@sum4_1Gk@","@sum4_1Qk@","@sum4_1N@","@sum4_1NEX@","@sum4_1Mx@",
                        "@sum4_1f@","@sum4_1f2@","@sum4_2λ@","@sum4_2λ2@","@sum4_2φ@","@sum4_2G1k@","@sum4_2G2k@","@sum4_2G3k@","@sum4_2Gk@","@sum4_2Qk@",
                        "@sum4_2N@","@sum4_2f@","@sum4_2f2@","@compare4_1@","@compare4_2@","@compare4_3@","@compare4_4@","@sum5G1k@",
                        "@sum5G2k@","@sum5G3k@","@sum5Gk@","@sum5Qk@","@sum5N@","@sum5f@","@sum5fvb@","@sum5f2@","@sum5fcb@","@compare5_1@","@compare5_2@",
                        "@sum6N@","@compare6_1@","@sum7N@","@sum7p@","@compare7@" ,"@str2_τ@","@str3_τ@"};
                    ReplaceString(keys, data);
                }

            }
            else if (@class.GetType().Equals(new Framework.Model.BeamForm().GetType()))//梁模板
            {
                if (template.Title == "梁模板(碗扣)")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {"@ZCJJ@", "@bf1_1@","@bf1_2@","@bf1_3@","@bf1_4@","@bf1_5@","@bf1_6@","@bf1_7@","@bf1_8@","@bf1_9@","@bf1_10@","@bf1_11@","@bf1_12@",
                        "@bf1_13@","@bf1_14@","@bf1_15@","@bf2_1@","@bf2_2@","@bf2_3@","@bf2_4@","@bf2_5@","@bf3_1@","@bf3_2@","@bf3_5@","@bf3_6@","@bf3_7@","@bf3_8@","@bf3_9@",
                        "@bf4_1@","@bf4_2@","@bf4_5@","@bf4_6@","@bf4_7@","@bf4_8@","@bf4_9@","@bf5_1@","@bf5_2@","@bf5_3@","@bf5_4@","@bf5_5@","@bf6_1@","@bf6_2@","@bf6_3@",
                        "@bf6_4@","@bf6_5@","@bf6_6@","@bf6_7@","@bf7_1@","@bf7_2@","@bf7_3@","@bf7_4@","@bf7_5@","@bf7_6@","@bf7_7@","@bf8_1@","@bf8_2@","@bf8_3@","@bf8_4@",
                        "@bf8_5@","@bf8_6@","@bf8_7@","@bf8_8@","@sum1I@","@sum1W@","@sum1h@","@sum1L@","@sum1q1@","@sum1q1J@","@sum1q1H@","@sum1q2@","@sum1Mmax@","@sum1σ@",
                        "@compare1_1@","@sum1vmax@","@sum1ν@","@compare1_2@","@sum1R1@","@sum1R2@","@sum1R3@","@sum1r1@","@sum1r2@","@sum1r3@","@sum2q1@","@sum2q2@","@sum2Mmax@",
                        "@sum2σ@","@compare2_1@","@sum2Vmax@","@str_xlcz@","@compare2_2@","@sum2ν1@","@sum2ν@","@compare2_3@","@sum2ν2@","@sum2ν_2@","@compare2_4@","@sum3G2k@",
                        "@sum3G3k@","@sum3Gk@","@sum3q1@","@sum3q2@","@sum3q@","@sum3l@","@sum3M@","@sum3W@","@sum3σ@","@compare3_1@","@sum3qN@","@sum3v@","@min@","@sum3ν@",
                        "@compare3_2@","@sum4λ@","@compare4_1@","@sum4φ@","@sum4G1k@","@sum4G2k@","@sum4G3k@","@sum4Gk@","@sum4Qk@","@sum4ωk@","@sum4Mw@","@sum4Nw@","@sum4f@",
                        "@compare4_2@","@sum5N@","@compare5_1@","@sum6p@","@compare6_1@","@result1_1@","@result1_2@" ,"@result2_1@" ,"@result2_2@" ,"@result3_1@" ,"@result3_2@" ,
                        "@result4_1@" ,"@result4_2@" ,"@result5_1@" ,"@result6_1@"};
                    ReplaceString(keys, data);
                }
                else if (template.Title == "梁模板(扣件)计算书")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {"@ZCJJ@", "@bf1_1@","@bf1_2@","@bf1_3@","@bf1_4@","@bf1_5@","@bf1_6@","@bf1_7@","@bf1_8@","@bf1_9@","@bf1_10@","@bf1_11@","@bf1_12@",
                        "@bf1_13@","@bf1_14@","@bf1_15@","@bf1_18@","@bf1_19@","@bf2_1@","@bf2_2@","@bf2_3@","@bf2_4@","@bf2_5@","@bf3_1@","@bf3_2@","@bf3_5@","@bf3_6@","@bf3_7@","@bf3_8@","@bf3_9@",
                        "@bf4_1@","@bf4_2@","@bf4_5@","@bf4_6@","@bf4_7@","@bf4_8@","@bf4_9@","@bf5_1@","@bf5_2@","@bf5_3@","@bf5_4@","@bf5_5@","@bf6_1@","@bf6_2@","@bf6_3@",
                        "@bf6_4@","@bf6_5@","@bf6_6@","@bf6_7@","@bf7_1@","@bf7_2@","@bf7_3@","@bf7_4@","@bf7_5@","@bf7_6@","@bf7_7@","@bf8_1@","@bf8_2@","@bf8_3@","@bf8_4@",
                        "@bf8_5@","@bf8_6@","@bf8_7@","@bf8_8@","@bf8_9@","@sum1I@","@sum1W@","@sum1h@","@sum1L@","@sum1q1@","@sum1q1J@","@sum1q1H@","@sum1q2@","@sum1Mmax@","@sum1σ@",
                        "@compare1_1@","@sum1vmax@","@sum1ν@","@compare1_2@","@sum1R1@","@sum1R2@","@sum1R3@","@sum1r1@","@sum1r2@","@sum1r3@","@sum2q1@","@sum2q2@","@sum2Mmax@",
                        "@sum2σ@","@compare2_1@","@sum2Vmax@","@str_xlcz@","@compare2_2@","@sum2ν1@","@sum2ν@","@compare2_3@","@sum2ν2@","@sum2ν_2@","@compare2_4@","@sum3G2k@",
                        "@sum3G3k@","@sum3Gk@","@sum3q1@","@sum3q2@","@sum3q@","@sum3l@","@sum3M@","@sum3W@","@sum3σ@","@compare3_1@","@sum3qN@","@sum3v@","@min@","@sum3ν@",
                        "@compare3_2@","@sum4λ@","@compare4_1@","@sum4φ@","@sum4G1k@","@sum4G2k@","@sum4G3k@","@sum4Gk@","@sum4Qk@","@sum4ωk@","@sum4Mw@","@sum4Nw@","@sum4f@",
                        "@compare4_2@","@sum5N@","@compare5_1@","@sum6p@","@compare6_1@" };
                    ReplaceString(keys, data);
                }
                else if (template.Title == "梁测模板")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {  "@lca_1@","@lca_2@","@lca_3@","@lca_4@","@lca_5@","@lca_6@","@lca_7@","@lca_8@","@lca_9@",
                        "@lca_10@","@lca_11@","@lca_12@","@lca_13@","@lca_14@","@lca_15@","@lca_16@","@lca_17@",
                        "@lca_18@","@lcb_1@","@lcb_2@","@lcb_3@","@lcb_4@","@lcb_5@","@lcb_6@","@lcb_7@","@lcb_8@",
                        "@lcb_9@","@lcc_1@","@lcc_2@","@lcc_3@","@lcc_4@","@lcc_5@","@lcc_6@","@lcc_7@","@lcc_8@",
                        "@lcc_9@","@lcd_1@","@lcd_2@","@lcd_3@","@lcd_4@","@lcd_5@","@lcd_6@","@lcd_7@","@lcd_8@",
                        "@lcd_9@","@lcd_10@","@lcd_11@","@lcd_12@","@lcd_13@","@sum1g4k@","@sum1ss@","@sum1sz@",
                        "@sum2w@","@sum2i@","@sum2q1@","@sum2q1j@","@sum2q1h@","@sum2m@","@sum26@","@sum2q@",
                        "@sum2vmax@","@sum2v@","@sum2rmax@","@sum2r1max@","@compare_mb1@","@compare_mb2@","@sum3q@",
                        "@sum3mmax@","@sum36@","@sum3vmax@","@sum3t@","@sum3v1max@","@sum31v1@","@sum3v2max@",
                        "@sum31v12@","@sum3rmax@","@sum3r1max@","@compare_xl1@","@compare_xl2@","@compare_xl3@",
                        "@compare_xl4@","@sum4i@","@sum4q@","@sum4m@","@sum4w@",
                        "@sum46@","@sum4f@","@sum4qn@","@sum4v@","@sum41v1@","@compare_zl1@",
                        "@compare_zl2@","@sum5n@","@sum5ntb@","@compare_dlls1@","@str_3t@"};
                    ReplaceString(keys, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.ComprehensiveEvaluation().GetType()))//综合评价
            {
                if (template.Title == "AHP和法")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[]{"@u11@","@u12@","@u13@","@u14@","@u15@","@u21@","@u22@","@u23@","@u24@","@u25@","@u31@","@u32@","@u33@","@u34@","@u41@","@u42@",
                        "@u43@","@u44@","@u51@","@u52@","@u53@","@u54@","@u55@","@u61@","@u62@","@u63@","@u64@","@u65@","@u66@","@a12@","@a13@","@a14@","@a15@","@a16@","@a23@",
                        "@a24@","@a25@","@a26@","@a34@","@a35@","@a36@","@a45@","@a46@","@a56@","@a21@","@a31@","@a32@","@a41@","@a42@","@a43@","@a51@","@a52@","@a53@","@a54@",
                        "@a61@","@a62@","@a63@","@a64@","@a65@","@A1@","@A2@","@A3@","@A4@","@A5@","@A6@","@w1@","@w2@","@w3@","@w4@","@w5@","@w6@","@wa11@","@wa12@","@wa13@",
                        "@wa14@","@wa15@","@wa16@","@wa21@","@wa22@","@wa23@","@wa24@","@wa25@","@wa26@","@wa31@","@wa32@","@wa33@","@wa34@","@wa35@","@wa36@","@wa41@","@wa42@",
                        "@wa43@","@wa44@","@wa45@","@wa46@","@wa51@","@wa52@","@wa53@","@wa54@","@wa55@","@wa56@","@wa61@","@wa62@","@wa63@","@wa64@","@wa65@","@wa66@","@b12@",
                        "@b13@","@b14@","@b15@","@b21@","@b23@","@b24@","@b25@","@b31@","@b32@","@b34@","@b35@","@b41@","@b42@","@b43@","@b45@","@b51@","@b52@","@b53@","@b54@",
                        "@B1@","@B2@","@B3@","@B4@","@B5@","@Wb1@","@Wb2@","@Wb3@","@Wb4@","@Wb5@","@Cb@","@c12@","@c13@","@c14@","@c15@","@c21@","@c23@","@c24@","@c25@","@c31@",
                        "@c32@","@c34@","@c35@","@c41@","@c42@","@c43@","@c45@","@c51@","@c52@","@c53@","@c54@","@C1@","@C2@","@C3@","@C4@","@C5@","@Wc1@","@Wc2@","@Wc3@","@Wc4@",
                        "@Wc5@","@Cc@","@d12@","@d13@","@d14@","@d21@","@d23@","@d24@","@d31@","@d32@","@d34@","@d41@","@d42@","@d43@","@D1@","@D2@","@D3@","@D4@","@Wd1@","@Wd2@",
                        "@Wd3@","@Wd4@","@Cd@","@e12@","@e13@","@e14@","@e21@","@e23@","@e24@","@e31@","@e32@","@e34@","@e41@","@e42@","@e43@","@E1@","@E2@","@E3@","@E4@","@We1@",
                        "@We2@","@We3@","@We4@","@Ce@","@f12@","@f13@","@f14@","@f15@","@f21@","@f23@","@f24@","@f25@","@f31@","@f32@","@f34@","@f35@","@f41@","@f42@","@f43@","@f45@",
                        "@f51@","@f52@","@f53@","@f54@","@F1@","@F2@","@F3@","@F4@","@F5@","@Wf1@","@Wf2@","@Wf3@","@Wf4@","@Wf5@","@Cf@","@g12@","@g13@","@g14@","@g15@","@g16@",
                        "@g23@","@g24@","@g25@","@g26@","@g34@","@g35@","@g36@","@g45@","@g46@","@g56@","@g21@","@g31@","@g32@","@g41@","@g42@","@g43@","@g51@","@g52@","@g53@","@g54@",
                        "@g61@","@g62@","@g63@","@g64@","@g65@","@G1@","@G2@","@G3@","@G4@","@G5@","@G6@","@Wg1@","@Wg2@","@Wg3@","@Wg4@","@Wg5@","@Wg6@","@Cg@","@C@","@result@"};
                    ReplaceString(keys, data);
                }
                else if (template.Title == "AHP均值法")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[]{"@u11@","@u12@","@u13@","@u14@","@u15@","@u21@","@u22@","@u23@","@u24@","@u25@","@u31@","@u32@","@u33@","@u34@","@u41@","@u42@",
                        "@u43@","@u44@","@u51@","@u52@","@u53@","@u54@","@u55@","@u61@","@u62@","@u63@","@u64@","@u65@","@u66@","@a12@","@a13@","@a14@","@a15@","@a16@","@a23@",
                        "@a24@","@a25@","@a26@","@a34@","@a35@","@a36@","@a45@","@a46@","@a56@","@a21@","@a31@","@a32@","@a41@","@a42@","@a43@","@a51@","@a52@","@a53@","@a54@",
                        "@a61@","@a62@","@a63@","@a64@","@a65@","@A1@","@A2@","@A3@","@A4@","@A5@","@A6@","@w1@","@w2@","@w3@","@w4@","@w5@","@w6@","@wa11@","@wa12@","@wa13@",
                        "@wa14@","@wa15@","@wa16@","@wa21@","@wa22@","@wa23@","@wa24@","@wa25@","@wa26@","@wa31@","@wa32@","@wa33@","@wa34@","@wa35@","@wa36@","@wa41@","@wa42@",
                        "@wa43@","@wa44@","@wa45@","@wa46@","@wa51@","@wa52@","@wa53@","@wa54@","@wa55@","@wa56@","@wa61@","@wa62@","@wa63@","@wa64@","@wa65@","@wa66@","@b12@",
                        "@b13@","@b14@","@b15@","@b21@","@b23@","@b24@","@b25@","@b31@","@b32@","@b34@","@b35@","@b41@","@b42@","@b43@","@b45@","@b51@","@b52@","@b53@","@b54@",
                        "@B1@","@B2@","@B3@","@B4@","@B5@","@Wb1@","@Wb2@","@Wb3@","@Wb4@","@Wb5@","@Cb@","@c12@","@c13@","@c14@","@c15@","@c21@","@c23@","@c24@","@c25@","@c31@",
                        "@c32@","@c34@","@c35@","@c41@","@c42@","@c43@","@c45@","@c51@","@c52@","@c53@","@c54@","@C1@","@C2@","@C3@","@C4@","@C5@","@Wc1@","@Wc2@","@Wc3@","@Wc4@",
                        "@Wc5@","@Cc@","@d12@","@d13@","@d14@","@d21@","@d23@","@d24@","@d31@","@d32@","@d34@","@d41@","@d42@","@d43@","@D1@","@D2@","@D3@","@D4@","@Wd1@","@Wd2@",
                        "@Wd3@","@Wd4@","@Cd@","@e12@","@e13@","@e14@","@e21@","@e23@","@e24@","@e31@","@e32@","@e34@","@e41@","@e42@","@e43@","@E1@","@E2@","@E3@","@E4@","@We1@",
                        "@We2@","@We3@","@We4@","@Ce@","@f12@","@f13@","@f14@","@f15@","@f21@","@f23@","@f24@","@f25@","@f31@","@f32@","@f34@","@f35@","@f41@","@f42@","@f43@","@f45@",
                        "@f51@","@f52@","@f53@","@f54@","@F1@","@F2@","@F3@","@F4@","@F5@","@Wf1@","@Wf2@","@Wf3@","@Wf4@","@Wf5@","@Cf@","@g12@","@g13@","@g14@","@g15@","@g16@",
                        "@g23@","@g24@","@g25@","@g26@","@g34@","@g35@","@g36@","@g45@","@g46@","@g56@","@g21@","@g31@","@g32@","@g41@","@g42@","@g43@","@g51@","@g52@","@g53@","@g54@",
                        "@g61@","@g62@","@g63@","@g64@","@g65@","@G1@","@G2@","@G3@","@G4@","@G5@","@G6@","@Wg1@","@Wg2@","@Wg3@","@Wg4@","@Wg5@","@Wg6@","@Cg@","@C@","@result@"};
                    ReplaceString(keys, data);
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.LEC().GetType()))//LEC法
            {
                if (template.Title == "LEC")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] {"@D1_1@", "@D1_2@", "@D1_3@", "@D1_4@", "@D1_5@", "@D1_6@", "@D1_7@", "@D1_8@", "@D1_9@", "@D1_10@", "@D2_1@", "@D2_2@", "@D2_3@", "@D2_4@",
                        "@D2_5@", "@D2_6@", "@D2_7@", "@D2_8@", "@D3_1@", "@D3_2@", "@D3_3@", "@D3_4@", "@D4_1@", "@D4_2@", "@D5_1@", "@D5_2@", "@D5_3@", "@S1_1@", "@S1_2@", "@S1_3@", "@S1_4@",
                        "@S1_5@", "@S1_6@", "@S1_7@", "@S1_8@", "@S1_9@", "@S1_10@", "@S2_1@", "@S2_2@", "@S2_3@", "@S2_4@", "@S2_5@", "@S2_6@", "@S2_7@", "@S2_8@", "@S3_1@", "@S3_2@", "@S3_3@",
                        "@S3_4@", "@S4_1@", "@S4_2@", "@S5_1@", "@S5_2@", "@S5_3@" , "@L1_1@", "@L1_2@", "@L1_3@", "@L1_4@", "@L1_5@", "@L1_6@", "@L1_7@", "@L1_8@", "@L1_9@", "@L1_10@", "@E1_1@",
                        "@E1_2@", "@E1_3@", "@E1_4@", "@E1_5@", "@E1_6@", "@E1_7@", "@E1_8@", "@E1_9@", "@E1_10@", "@C1_1@", "@C1_2@", "@C1_3@", "@C1_4@", "@C1_5@", "@C1_6@", "@C1_7@", "@C1_8@",
                        "@C1_9@", "@C1_10@", "@L2_1@", "@L2_2@", "@L2_3@", "@L2_4@", "@L2_5@", "@L2_6@", "@L2_7@", "@L2_8@", "@E2_1@", "@E2_2@", "@E2_3@", "@E2_4@", "@E2_5@", "@E2_6@", "@E2_7@",
                        "@E2_8@", "@C2_1@", "@C2_2@", "@C2_3@", "@C2_4@", "@C2_5@", "@C2_6@", "@C2_7@", "@C2_8@", "@L3_1@", "@L3_2@", "@L3_3@", "@L3_4@", "@E3_1@", "@E3_2@", "@E3_3@", "@E3_4@", 
                        "@C3_1@", "@C3_2@", "@C3_3@", "@C3_4@", "@L4_1@", "@L4_2@", "@E4_1@", "@E4_2@", "@C4_1@", "@C4_2@", "@L5_1@", "@L5_2@", "@L5_3@", "@E5_1@", "@E5_2@", "@E5_3@", "@C5_1@", 
                        "@C5_2@", "@C5_3@"};
                    ReplaceString(keys, data);
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.FromSelect().GetType()))//模板选择
            {
                if (template.Title == "模板选择")
                {
                    SelectTjSelf(template, array, @class, data);
                    //WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { "@data1_1@", "@data1_2@", "@data1_3@", "@data1_4@", "@str1_1@", "@data2_1@", "@data2_2@", "@data2_3@", "@data2_4@", "@str2_1@" };
                    ReplaceString(keys, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.Conretestrength1().GetType()))//混凝土取样
            {
                
                if (template.Title == "混凝土取样")
                {
                    SelectTjSelf(template, array, @class, data);
                    
                }
            }
            else if (@class.GetType().Equals(new Framework.Model.ConcreteMeasure().GetType()))//混凝土强度测定
            {

                if (template.Title == "混凝土强度测定")
                {
                    SelectTjSelf(template, array, @class, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.FoundationPouring().GetType()))//混凝土基础浇筑
            {

                if (template.Title == "混凝土基础浇筑")
                {
                    SelectTjSelf(template, array, @class, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.Kjjg().GetType()))//混凝土主体浇筑
            {

                if (template.Title == "混凝土主体浇筑")
                {
                    SelectTjSelf(template, array, @class, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.hntzd1().GetType()))//混凝土振捣
            {

                if (template.Title == "混凝土振捣")
                {
                    SelectTjSelf(template, array, @class, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.ConcreteConstructionMachinery().GetType()))//混凝土施工机械选择
            {

                if (template.Title == "混凝土施工机械选择")
                {
                    SelectTjSelf(template, array, @class, data);

                }
            }
            else if (@class.GetType().Equals(new Framework.Model.Concretemaintain().GetType()))//混凝土试块的制作与养护
            {
                if (template.Title == "混凝土试块的制作与养护")
                {
                    WinWordControlEx.LoadWord(path);
                    string[] keys = new string[] { "@str1@", "@str2@", "@str3@", "@str4@", "@str5@", "@str6@", "@str7@", "@str8@" };
                    ReplaceString(keys, data);
                }
            }
            
            WinWordControlEx.MoveToTop();
        }

        private void SelectTjSelf(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data)
        {
            #region
            WinWordControlEx.LoadWord(path);
            if (template.Title == "扣件式钢管脚手架（落地）单排")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }
                string[] keys = new string[] { "@Tb_Item1DSGD@", "@Tb_Item1HJ@", "@Tb_Item1ZJ@", "@Tb_Item1BJ@", "@textLqj@", "@textDxhg@" };
                ReplaceString(keys, data);
            }
            else if (template.Title == "扣件式钢管脚手架（落地）双排")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }
                string[] keys = new string[] { "@Tb_Item1DSGD@", "@Tb_Item1HJ@", "@Tb_Item1ZJ@", "@Tb_Item1BJ@", "@Tb_Item1NLGJWQ.Text@", "@Tb_Item1XHGLDJQ.Text@", "@textLqj@", "@textDxhg@" };
                ReplaceString(keys, data);
            }
            else if (template.Title == "扣件式钢管脚手架（落地+悬挑）")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    if (i == 0)
                    {
                        WinWordControlEx.InsertTable(1, 4, arraylist);
                    }
                    else
                    {
                        WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                    }
                }
                string[] keys = new string[] {"@IntInput_Item1DSBW1@", "@IntInput_Item1DSBW2@","@IntInput_Item1DSGD@","@Tb_Item2HJ@", "@Tb_Item2ZJ@", "@Tb_Item2BJ@", "@Tb_Item2NLGJWQ.@", "@Tb_Item2XHGLDJQ@", "@textLqj2@", "@textDxhg2@" ,
                                             "@Cbx_Item3XGSPXTG@", "@Tb_Item3HJ@", "@Tb_Item3ZJ@", "@Tb_Item3BJ@", "@Tb_Item3NLGJWQ@", "@Tb_Item3XHGLDJQ@", "@textLqj3@", "@textDxhg3@" };
                ReplaceString(keys, data);
            }
            else if (template.Title == "碗扣式脚手架")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }
            }
            else if (template.Title == "承插型盘扣式钢管脚手架")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    if (i == 0)
                    {
                        WinWordControlEx.InsertTable(1, 2, arraylist);
                    }
                    else
                    {
                        WinWordControlEx.InsertTable(i + 2, 2, arraylist);
                    }
                }
            }
            else if (template.Title == "工门式钢管脚手架")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    if (i == 0)
                    {
                        WinWordControlEx.InsertTable(1, 2, arraylist);
                    }
                    if (i == 1)
                    {
                        WinWordControlEx.InsertTable(4, 2, arraylist);
                    }
                }
            }
            else if (template.Title == "液压升降式整体脚手架")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                }
            }
            else if (template.Title == "吊脚手架")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    WinWordControlEx.InsertTable(i + 1, 2, arraylist);
                    WinWordControlEx.InsertTable(i + 3, 2, arraylist);
                }
            }
            else if (template.Title == "模板选择")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    if (i == 0)
                    {
                        WinWordControlEx.InsertTable(1, 2, arraylist);
                    }
                    else
                    {
                        WinWordControlEx.InsertTable(2, 2, arraylist);
                    }
                }
            }
            else if (template.Title == "混凝土取样")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    System.Collections.ArrayList arraylist = (System.Collections.ArrayList)array[i];
                    if (i == 0)
                    {
                        WinWordControlEx.InsertTable(1, 2, arraylist);
                    }
                    if (i == 1)
                    {
                        WinWordControlEx.InsertTable(2, 2, arraylist);
                    }
                    if (i == 2)
                    {
                        WinWordControlEx.InsertTable(3, 2, arraylist);
                    }
                    if (i == 3)
                    {
                        WinWordControlEx.InsertTable(4, 2, arraylist);
                    }
                    if (i == 4)
                    {
                        WinWordControlEx.InsertTable(5, 2, arraylist);
                    }
                    if (i == 5)
                    {
                        WinWordControlEx.InsertTable(6, 2, arraylist);
                    }
                    if (i == 6)
                    {
                        WinWordControlEx.InsertTable(7, 2, arraylist);
                    }
                    if (i == 7)
                    {
                        WinWordControlEx.InsertTable(8, 2, arraylist);
                    }
                    
                }
            }
            #endregion
        }

        private void ReplaceString(string[] keys, object[] values)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                WinWordControlEx.Replace(keys[i], values[i].ToString());
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            System.Xml.XmlElement element = Framework.Class.XmlTool.FindChapterByCid(chapter.Id);
            element.SetAttribute("DOC", WinWordControlEx.GetWordString(path));
            DevComponents.DotNetBar.MessageBoxEx.Show("添加成功！", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
        }

        private void BtnRedo_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Model model = (Framework.Entity.Model)utilService.FindById(new Framework.Entity.Model(), chapter.Model);
            System.Reflection.Assembly ass = System.Reflection.Assembly.LoadFrom(System.Windows.Forms.Application.ExecutablePath.Replace("\\" + System.Windows.Forms.Application.StartupPath, ""));
            ShowFrmProfile(model, ass);
        }

        private void ShowFrmProfile(Framework.Entity.Model model, System.Reflection.Assembly ass)
        {

            if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.UseWater().GetType()))
            {
                FrmUseWater win = new FrmUseWater(chapter, ass.CreateInstance(model.Class));//3.Delegate数据变量指向实例方法
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmUseWater.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.UsePower().GetType()))
            {
                FrmUsePower win = new FrmUsePower(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmUsePower.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ConcreteProject().GetType()))
            {
                FrmConcreteProject win = new FrmConcreteProject(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConcreteProject.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ConstructPrepare().GetType()))
            {
                FrmConstructPrepare win = new FrmConstructPrepare(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConstructPrepare.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ClimateFeature().GetType()))
            {
                FrmClimateFeature win = new FrmClimateFeature(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmClimateFeature.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.RainConstruct().GetType()))
            {
                FrmRainConstruct win = new FrmRainConstruct(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmRainConstruct.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldPowerCalculate().GetType()))//脚手架力学计算
            {
                FrmScaffoldPowerCalculate win = new FrmScaffoldPowerCalculate(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldPowerCalculate.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldMaterialCalculate().GetType()))//脚手架用料计算
            {
                FrmScaffoldMaterialCalculate win = new FrmScaffoldMaterialCalculate(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldMaterialCalculate.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldRecommendSelect().GetType()))//脚手架 推荐选型
            {
                FrmScaffoldRecommendSelect win = new FrmScaffoldRecommendSelect(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldRecommendSelect.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldSelfSelect().GetType()))//脚手架 自行选型
            {
                FrmScaffoldSelfSelect win = new FrmScaffoldSelfSelect(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldSelfSelect.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldSchematicDiagram().GetType()))//脚手架绘图
            {
                FrmScaffoldSchematicDiagram win = new FrmScaffoldSchematicDiagram(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmScaffoldSchematicDiagram.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ScaffoldAssessment().GetType()))// 综合评价系统
            {
                FrmAssessment win = new FrmAssessment(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmAssessment.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.Formwork().GetType()))// 板模板
            {
                FrmFormwork win = new FrmFormwork(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmFormwork.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.BeamForm().GetType()))// 梁模板
            {
                FrmBeamForm win = new FrmBeamForm(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmBeamForm.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            

            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ComprehensiveEvaluation().GetType()))// 综合评价
            {
                FrmComprehensiveEvaluation win = new FrmComprehensiveEvaluation(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmComprehensiveEvaluation.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.LEC().GetType()))// LEC
            {
                FrmLEC win = new FrmLEC(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmLEC.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.FromSelect().GetType()))// 模板选择
            {
                FrmFromSelect win = new FrmFromSelect(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmFromSelect.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.Peiban().GetType()))//配板
            {
                Frmpeiban win = new Frmpeiban(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.Frmpeiban.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.Conretestrength1().GetType()))//混凝土强度
            {
                FrmConretestrength1 win = new FrmConretestrength1(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConretestrength1.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.Concretemaintain().GetType()))//混凝土制作与养护
            {
                FrmConcretemaintain win = new FrmConcretemaintain(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConcretemaintain.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.CompreStrength().GetType()))//混凝土抗压强度
            {
                FrmCompreStrength win = new FrmCompreStrength(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmCompreStrength.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ConcreteMeasure().GetType()))//混凝土强度测定
            {
                FrmConcreteMeasure win = new FrmConcreteMeasure(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConcreteMeasure.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.FoundationPouring().GetType()))//混凝土基础浇筑
            {
                FrmFoundationPouring win = new FrmFoundationPouring(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmFoundationPouring.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.hntzd1().GetType()))//混凝土振捣
            {
                Frmhntzd1 win = new Frmhntzd1(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.Frmhntzd1.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.Kjjg().GetType()))//混凝土强主体浇筑
            {
                FrmKjjg win = new FrmKjjg(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmKjjg.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
            else if (ass.CreateInstance(model.Class).GetType().Equals(new Framework.Model.ConcreteConstructionMachinery().GetType()))//混凝土施工机械选择
            {
                FrmConcreteConstructionMachinery win = new FrmConcreteConstructionMachinery(chapter, ass.CreateInstance(model.Class));
                win.CreateModuleIntance += new Framework.Interface.Workbench.FrmConcreteConstructionMachinery.CreateModuleHandle(CreateModule);
                win.ShowDialog();
            }
        }

    }
}