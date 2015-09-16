using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmScaffoldPowerCalculate : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private float weightMF = 0;
        private int  mfID = 0;
        private System.Collections.ArrayList templateList;
        public FrmScaffoldPowerCalculate(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            CbxScaffoldType.SelectedIndex = 0;
        }

        #region  脚手架力学计算窗体中添加的一些控件事件
            private void CbxScaffoldType_SelectedIndexChanged(object sender, EventArgs e) //脚手架力学计算窗体首页
            {
                if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 2)//单双排脚手架
                {
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem8.Visible = LXtabItem9.Visible = true;
                    LXtabItem10.Visible = LXtabItem11.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cb_Item5YT.Items.Clear();
                    Cb_Item5YT.Items.Add("装修施工脚手架"); Cb_Item5YT.Items.Add("结构施工脚手架"); Cb_Item5YT.Items.Add("其它用途脚手架");
                    Cb_Item9DJLX.Items.Clear();
                    Cb_Item9DJLX.Items.Add("天然地基"); Cb_Item9DJLX.Items.Add("回填土地基");
                    Cb_Item9DJTLX.SelectedIndex = Cb_Item9DJLX.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cb_Item3JJ.SelectedIndex =Cb_Item3FS.SelectedIndex = 0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = false;
                    DbInput_Item5HZBZ.Enabled = true;
                }
                else if (CbxScaffoldType.SelectedIndex == 1)//型钢悬挑脚手架
                {
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem8.Visible = LXtabItem10.Visible = LXtabItem11.Visible = true;
                    LXtabItem9.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cb_Item3JJ.SelectedIndex = Cb_Item3FS.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cb_Item10GLXH.SelectedIndex = Cb_Item10RXND.SelectedIndex = Cb_Item11ULSZJ.SelectedIndex = Cb_Item11LBHNTQD.SelectedIndex = 0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = false;
                }
                else if (CbxScaffoldType.SelectedIndex == 3)//门式脚手架
                {
                    LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LXtabItem6.Visible = true;
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible =  LXtabItem8.Visible = LXtabItem9.Visible = LXtabItem10.Visible = LXtabItem11.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cbx_Lx4Item3JSB.SelectedIndex = Cb_Lx4Item4DJTLX.SelectedIndex = Cbx_Lx4Item3JGJ.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cbx_Lx4Item2LJFS.SelectedIndex = Cbx_Lx4Item3YT.SelectedIndex  =0;//设置一些comboBox的默认index=0
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false ;
                }
                else if (CbxScaffoldType.SelectedIndex == 4)//碗扣式脚手架
                {
                    LX5tabItem1.Visible = LX5tabItem2.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem9.Visible = true;
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem8.Visible = LXtabItem10.Visible = LXtabItem11.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = false;
                    Cb_Item9DJLX.Items.Clear();
                    Cb_Item9DJLX.Items.Add("天然地基"); Cb_Item9DJLX.Items.Add("回填土地基"); Cb_Item9DJLX.Items.Add("碎石土地基"); Cb_Item9DJLX.Items.Add("砂土地基"); Cb_Item9DJLX.Items.Add("粘土地基");
                    Cb_Item7DMCCD.SelectedIndex = Cb_Item9DJLX.SelectedIndex =0;
                    Cb_Item5YT.Items.Clear();
                    Cb_Item5YT.Items.Add("装修施工脚手架"); Cb_Item5YT.Items.Add("结构施工脚手架");
                    Cbx_Lx5Item1ZJ.SelectedIndex = Cbx_Lx5Item1HJ.SelectedIndex = Cbx_Lx5Item1JHG.SelectedIndex = Cbx_Lx5Item1LGG.SelectedIndex = Cbx_Lx5Item1WXG.SelectedIndex = Cbx_Lx5Item1SPX.SelectedIndex = Cbx_Lx5Item1LDX.SelectedIndex = Cbx_Lx5Item1DKJ.SelectedIndex = Cbx_Lx5Item1WXGBZ.SelectedIndex = Cbx_Lx5Item1LGJXG.SelectedIndex = Cbx_Lx5Item2LQJ.SelectedIndex  =0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = true;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = true;
                    DbInput_Item5HZBZ.Enabled = false;
                    
                }
            }

            private void Cb_Item10RXND_SelectedIndexChanged(object sender, EventArgs e) //Item10 型钢悬挑脚手架
            {
                if (Cb_Item10RXND.SelectedIndex == 0)
                {
                    Tb_Item10RXND.Text = Convert.ToString(DbInput_Item10XTD.Value * 2 / 250);
                }
                else if (Cb_Item10RXND.SelectedIndex == 1)
                {
                    Tb_Item10RXND.Text = Convert.ToString(DbInput_Item10XTD.Value * 2 / 400);
                }
            }

            private void Rdo_Item2XHG_CheckedChanged(object sender, EventArgs e) //Item2大小横杆布置
            {
                if  (Rdo_Item2XHG.Checked == true)
                {
                    Grp_Item2XHG.Enabled = true;
                    Grp_Item2DHG.Enabled = false;
                }
                if (Rdo_Item2DHG.Checked == true) 
                {
                    Grp_Item2DHG.Enabled = true;
                    Grp_Item2XHG.Enabled = false;
                }    
            }

            private void Cb_Item2LGZJ_SelectedIndexChanged(object sender, EventArgs e)//Item2小横杆在上小横杆间距变化
            {
                if (Cb_Item2LGZJ.SelectedIndex == 0)
                {
                    Tb_Item2XHGJJ.Text = "2";
                }
                else
                    Tb_Item2XHGJJ.Text = "1";
            }
        
            private void Cb_Item3FS_SelectedIndexChanged(object sender, EventArgs e) //Item3连墙件设置
            {
                if (Cb_Item3FS.SelectedIndex == 0)
                {
                    Grp_Item3FSKJLJ.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                }
                else
                {
                    Grp_Item3FSKJLJ.Enabled = false;
                    radioButton1.Enabled = false ;
                    radioButton2.Enabled = false ;
                }
            }

            private void Cb_Item4JSBLB_SelectedIndexChanged(object sender, EventArgs e)//Item4永久荷载参数,脚手板类别
            {
                switch (Cb_Item4JSBLB.SelectedIndex)
                {
                    case 0: Tb_Item4JSBZZBZZ.Text = Convert.ToString(0.30); break;
                    case 1: Tb_Item4JSBZZBZZ.Text = Convert.ToString(0.35); break;
                    case 2: Tb_Item4JSBZZBZZ.Text = Convert.ToString(0.35); break;
                    case 3: Tb_Item4JSBZZBZZ.Text = Convert.ToString(0.10); break;
                    default: Tb_Item4JSBZZBZZ.Text = Convert.ToString(0.30); break;
                }
            }

            private void Cb_Item4JBLB_SelectedIndexChanged(object sender, EventArgs e) //Item4永久荷载参数,栏杆挡脚板类别
            {
                switch (Cb_Item4JBLB.SelectedIndex)
                {
                    case 0: Tb_Item4JBZZBZZ.Text = Convert.ToString(0.16); break;
                    case 1: Tb_Item4JBZZBZZ.Text = Convert.ToString(0.17); break;
                    case 2: Tb_Item4JBZZBZZ.Text = Convert.ToString(0.17); break;
                    default: Tb_Item4JBZZBZZ.Text = Convert.ToString(0.16); break;
                }
            }
            private void Chk_Item6Self_CheckedChanged(object sender, EventArgs e)
            {
                if (Chk_Item6Self.Checked) //如果选中复选框，则允许用户自己填写风压，否则不可自填风压
                {
                    Lb_Item6SelfJBFY.Enabled = true;
                    DbInput_Item6SelfJBFY.Enabled = true;
                    Grp_Item6SF.Enabled = false;
                }
                else
                {
                    Lb_Item6SelfJBFY.Enabled = false;
                    DbInput_Item6SelfJBFY.Enabled = false;
                    Grp_Item6SF.Enabled = true ;
                }
            }
     
             #region   // Item8风荷载体型系数
             private void Rdo_Item8WMMW_CheckedChanged(object sender, EventArgs e)
            {
                if (Rdo_Item8WMMW.Checked)
                {
                    //Grp_Item8CKS.Enabled = true;
                    Grp_Item8ADFMJ.Enabled = false;
                    Grp_Item8FBS.Enabled = false;
                    Rdo_Item8QMM.Checked = false;
                    Rdo_Item8ADFMJ.Checked = false;
                    double[,] valueArray = new double[,]{
                                                                            {	0.26	,	0.212	,	0.193	,	0.18	,	0.173	,	0.164	,	0.16	,	0.158	,	0.154	,	0.148	,	0.144	},
                                                                            {	0.241	,	0.192	,	0.173	,	0.161	,	0.154	,	0.144	,	0.141	,	0.139	,	0.135	,	0.128	,	0.125	},
                                                                            {	0.228	,	0.18	,	0.161	,	0.148	,	0.141	,	0.132	,	0.128	,	0.126	,	0.122	,	0.115	,	0.112	},
                                                                            {	0.219	,	0.171	,	0.151	,	0.138	,	0.132	,	0.122	,	0.119	,	0.117	,	0.113	,	0.106	,	0.103	},
                                                                            {	0.212	,	0.164	,	0.144	,	0.132	,	0.125	,	0.115	,	0.112	,	0.11	,	0.106	,	0.099	,	0.096	},
                                                                            {	0.207	,	0.158	,	0.139	,	0.126	,	0.12	,	0.11	,	0.106	,	0.105	,	0.1	,	0.094	,	0.091	},
                                                                            {	0.202	,	0.154	,	0.135	,	0.122	,	0.115	,	0.106	,	0.102	,	0.1	,	0.096	,	0.09	,	0.086	},
                                                                            {	0.2	,	0.152	,	0.132	,	0.119	,	0.113	,	0.103	,	0.1	,	0.098	,	0.094	,	0.087	,	0.084	},
                                                                            {	0.1959	,	0.148	,	0.128	,	0.115	,	0.109	,	0.099	,	0.096	,	0.094	,	0.09	,	0.083	,	0.08	},
                                                                            {	0.1927	,	0.144	,	0.125	,	0.112	,	0.106	,	0.096	,	0.092	,	0.091	,	0.086	,	0.08	,	0.077	}
                                                                        };
                    double[] xArray = new double[] { 0.4, 0.6, 0.75, 0.9, 1.0, 1.2, 1.3, 1.35, 1.5, 1.8, 2.0 };
                    double[] yArray = new double[] { 0.6, 0.75, 0.90, 1.05, 1.20, 1.35, 1.50, 1.6, 1.80, 2.0 };

                    Tb_Item8DFXS1.Text = ErweiShuzu(valueArray, xArray, yArray, DbInput_Item1LGZJ.Value, DbInput_Item1BJ.Value).ToString();
                }
                // else
                //Grp_Item8CKS.Enabled = false;
            }

            private void Rdo_Item8FBSK_CheckedChanged(object sender, EventArgs e)
            {
                if(Rdo_Item8FBSK.Checked == true)
                {                   
                    Grp_Item8FBS.Enabled  = true;
                    Rdo_Item8QMM.Checked = true;
                    DbIput_Item8DFMJ.Enabled = false;
                    Tb_Item8DFXS1.Text = "0.8";
                 }
            }

             private void Rdo_Item8FBSQ_CheckedChanged(object sender, EventArgs e)
            {
                if (Rdo_Item8FBSQ.Checked == true)
                {
                    Grp_Item8FBS.Enabled = true;
                    Rdo_Item8QMM.Checked = true;
                    DbIput_Item8DFMJ.Enabled = false;
                    Tb_Item8DFXS1.Text = "0.8";
                }
            }

                private void Rdo_Item8QMM_CheckedChanged(object sender, EventArgs e)
            {
                if (Rdo_Item8QMM.Checked == true)
                {
                    
                    Grp_Item8ADFMJ.Enabled = false;
                }
            }

             private void Rdo_Item8ADFMJ_CheckedChanged(object sender, EventArgs e)
            {
                if (Rdo_Item8ADFMJ.Checked)
                {
                    Grp_Item8ADFMJ.Enabled = true;
                    DbIput_Item8DFMJ.Enabled = true;
                }
                else
                    Grp_Item8ADFMJ.Enabled = false;
            }
           #endregion
       
        private void Cb_Item9DJTLX_SelectedIndexChanged(object sender, EventArgs e)//Item9立杆地基承载力
            {
                switch (Cb_Item9DJTLX.SelectedIndex)
                {
                    case 0: Tb_Item9DJCZL.Text = "200"; break; //岩石
                    case 1: Tb_Item9DJCZL.Text = "200"; break; //碎石土
                    case 2: Tb_Item9DJCZL.Text = "140"; break; // 砂土
                    case 3: Tb_Item9DJCZL.Text = "100"; break; //粉土
                    case 4: Tb_Item9DJCZL.Text = "80"; break; //素填土
                    case 5: Tb_Item9DJCZL.Text = "120"; break; //红粘土
                    case 6: Tb_Item9DJCZL.Text = "120"; break; //粘性土
                    case 7: Tb_Item9DJCZL.Text = "60"; break; //淤泥质土
                }
            }

            private void tabItem9_Click(object sender, EventArgs e)
            {
                Tb_Item9ZYCD.Text = DbInput_Item1LGZJ.Text;//tabItem9下“作用长度”依据“立杆纵距”来确定
            }

            #region  //Item6风荷载参数，由省份地区确定地区风压
            private string[] neimenggu1 = new string[] { "北京&0.30" };
            private string[] neimenggu2 = new string[] { "天津市&0.30", "塘沽&0.40" };
            private string[] neimenggu3 = new string[] { "上海&0.40" };
            private string[] neimenggu4 = new string[] { "重庆&0.25" };
            private string[] neimenggu5 = new string[] { "石家庄市&0.25", "蔚县&0.20", "邢台市&0.20 ", "丰宁&0.30", "围场&0.35", "张家口市&0.35", "怀来& 0.25", " 承德市& 0.30", " 遵化& 0.30", " 青龙&0.25 ", " 秦皇岛市&0.35", "霸县&0.25", "唐山市&0.30", "乐亭&0.30", "保定市&0.30", "饶阳&0.30", "沧州市&0.30", "黄骅&0.30", "南宫市&0.25" };
            private string[] neimenggu6 = new string[] { "太原市&0.30", "大同市&0.35", "河曲&0.30", "五寨&0.30", "兴县&0.25", "原平&0.30", "离石&0.30", "阳泉市&0.30", "榆社&0.20", "隰县&0.25", "介休&0.25", "临汾市&0.25", "长治县&0.30", "运城市&0.30", "阳城&0.30" };
            private string[] neimenggu7 = new string[] { "呼和浩特市&0.35", "额右旗拉布达林&0.35", "牙克石市图里河&0.30", "满洲里市&0.50", "海拉尔市&0.45", "鄂伦春小二沟&0.30", "新巴尔虎右旗&0.45", "新巴尔虎左旗阿木古朗&0.40", "牙克石市博克图&0.40", "扎兰屯市&0.30", "科右翼前旗阿尔山&0.35", "科右翼前旗索伦&0.45", "乌兰浩特市&0.40", "东乌珠穆沁旗&0.35", "额济纳旗&0.40", "额济纳旗拐子湖&0.45", "阿左旗巴彦毛道&0.40", "阿拉善右旗&0.45", "二连浩特市&0.55", "那仁宝力格&0.40", "达茂旗满都拉&0.50", "阿巴嘎旗&0.35", "苏尼特左旗&0.40", "乌拉特右旗海力素&0.45", "苏尼特右旗朱日和&0.50", "乌拉特中旗海流图&0.45", "百灵庙&0.50", "四子王旗&0.40", "化德&0.45", "杭棉后旗陕坝&0.30", "包头市&0.35", "集宁市&0.40", "阿拉善左旗吉兰泰&0.35", "临河市&0.30", "鄂托克旗&0.35", "东胜市&0.30", "阿腾席连&0.40", "巴彦浩特&0.40", "西乌珠穆沁旗&0.45", "扎鲁特鲁北&0.40", "巴林左旗林东&0.40", "锡林浩特市&0.40", "林西&0.45", "开鲁&0.40", "通辽市&0.40", "多伦&0.40", "赤峰市&0.30", "敖汉旗宝国图&0.40" };
            private string[] neimenggu8 = new string[] { "沈阳市&0.40", "彰武&0.35", "阜新市&0.40", "开原&0.30", "清原&0.25", "朝阳市&0.40", "建平县叶柏寿&0.30", "黑山&0.45", "锦州市&0.40", "鞍山市&0.30", "本溪市&0.35", "抚顺市章党&0.30", "恒仁&0.25", "绥中&0.25", "兴城市&0.35", "营口市&0.40", "盖县熊岳&0.30", "本溪县草河口&0.25", "岫岩&0.30", "宽甸&0.30", "丹东市&0.35", "瓦房店市&0.35", "新金县皮口&0.35", "庄河&0.35", "大连市&0.40" };
            private string[] neimenggu9 = new string[] { "长春市&0.45", "白城市&0.45", "乾安&0.35", "前郭尔罗斯&0.30", "通榆&0.35", "长岭&0.30", "扶余市三岔河&0.35", "双辽&0.35", "四平市&0.40", "磐石县烟筒山&0.30", "吉林市&0.40", "蛟河&0.30", "敦化市&0.30", "梅河口市&0.30", "桦甸&0.30", "靖宇&0.25", "抚松县东岗&0.30", "延吉市&0.35", "通化市&0.30", "浑江市临江&0.20", "集安市&0.20", "长白&0.35" };
            private string[] neimenggu10 = new string[] { "哈尔滨市&0.35", "漠河&0.25", "塔河&0.25", "新林&0.25", "呼玛&0.30", "加格达奇&0.25", "黑河市&0.35", "嫩江&0.40", "孙吴&0.40", "北安市&0.30", "克山&0.30", "富裕&0.30", "齐齐哈尔市&0.35", "海伦&0.35", "明水&0.35", "伊春市&0.25", "鹤岗市&0.30", "富锦&0.30", "泰来&0.30", "绥化市&0.35", "安达市&0.35", "铁力&0.25", "佳木斯市&0.40", "依兰&0.45", "宝清&0.30", "通河&0.35", "尚志&0.35", "鸡西市&0.40", "虎林&0.35", "牡丹江市&0.35", "绥芬河市&0.40" };
            private string[] neimenggu11 = new string[] { "济南市&0.30", "德州市&0.30", "惠民&0.40", "寿光县羊角沟&0.30", "龙口市&0.45", "烟台市&0.40", "威海市&0.45", "荣成市成山头&0.60", "莘县朝城&0.35", "泰安市泰山&0.65", "泰安市&0.30", "淄博市张店&0.30", "沂源&0.30", "潍坊市&0.30", "莱阳市&0.30", "青岛市&0.45", "海阳&0.40", "荣成市石岛&0.40", "菏泽市&0.25", "兖州&0.25", "莒县&0.25", "临沂&0.30", "日照市&0.30" };
            private string[] neimenggu12 = new string[] { "南京市&0.25", "徐州市&0.25", "赣榆&0.30", "盱眙&0.25", "淮阴市&0.25", "射阳&0.30", "镇江&0.30", "无锡&0.30", "泰州&0.25", "连万港&0.35", "盐城&0.25", "高邮&0.25", "东台市&0.30", "南通市&0.25", "溧阳&0.25", "吴县东山&0.30" };
            private string[] neimenggu13 = new string[] { "杭州市&0.30", "临安县天目山&0.55", "平湖县乍浦&0.35", "慈溪市&0.30", "嵊泗&0.85", "嵊泗县嵊山&0.95", "舟山市&0.50", "金华市&0.25", "嵊县&0.25", "宁波市&0.30", "象山县石浦&0.75", "衢州&0.25", "丽水市&0.20", "龙泉&0.20", "临海市括苍山&0.60", "温州市&0.35", "椒江市洪家&0.35", "椒江市下大陈&0.90", "玉环县坎门&0.70", "瑞安市北麂&0.95" };
            private string[] neimenggu14 = new string[] { "合肥&0.25", "砀山&0.25", "毫州市&0.25", "宿县&0.25", "寿县&0.25", "蚌埠市&0.25", "滁县&0.25", "六安市&0.20", "霍山&0.20", "巢县&0.25", "安庆市&0.25", "宁国&0.25", "毫州市&0.25", "黄山&0.50", "黄山市&0.25" };
            private string[] neimenggu15 = new string[] { "南昌市&0.30", "修水&0.20", "宜春市&0.20", "吉安&0.25", "宁冈&0.20", "遂川&0.20", "赣州市&0.20", "九江&0.25", "庐山&0.40", "波阳&0.25", "景德镇市&0.25", "樟树市&0.20", "贵溪&0.20", "玉山&0.20", "南城&0.25", "广昌&0.20", "寻乌&0.25" };
            private string[] neimenggu16 = new string[] { "福州市&0.40", "邵武市&0.20", "铅山县七仙山&0.55", "浦城&0.20", "建阳&0.25", "建瓯&0.25", "福鼎&0.35", "泰宁&0.20", "南平市&0.20", "福鼎县台山&0.75", "长汀&0.20", "上杭&0.25", "永安市&0.25", "龙岩市&0.20", "德化县九仙山&0.60", "屏南&0.20", "平潭&0.75", "崇武&0.55", "厦门市&0.55", "东山&0.80" };
            private string[] neimenggu17 = new string[] { "西安市&0.25", "榆林市&0.25", "吴旗&0.25", "衡山&0.30", "绥德&0.3", "延安市&0.25", "长武&0.20", "洛川&0.25", "铜川市&0.20", "宝鸡市&0.20", "武功&0.20", "华阳县华山&0.40", "略阳&0.25", "汉中市&0.20", "佛坪&0.25", "商州市&0.25", "镇安&0.20", "石泉&0.20", "安康市&0.30" };
            private string[] neimenggu18 = new string[] { "兰州市&0.20", "吉柯德&0.45", "安西&0.40", "酒泉市&0.40", "张掖市&0.30", "武威市&0.35", "民勤&0.40", "乌鞘岭&0.35", "景泰&0.25", "靖远&0.20", "临夏市&0.20", "临洮&0.20", "华家岭&0.30", "环县&0.20", "平凉市&0.25", "西峰镇&0.20", "玛曲&0.25", "夏河县合作&0.25", "武都&0.25", "天水市&0.20" };
            private string[] neimenggu19 = new string[] { "银川市&0.40", "惠农&0.45", "中卫&0.30", "中宁&0.30", "盐池&0.30", "海源&0.25", "同心&0.20", "固原&0.25", "西吉&0.20" };
            private string[] neimenggu20 = new string[] { "西宁市&0.25", "茫崖&0.30", "冷湖&0.40", "祁连县托勒&0.30", "祁连县野牛沟&0.30", "祁连&0.30", "格尔木市小灶火&0.30", "大柴旦&0.30", "德令哈市&0.25", "刚察&0.25", "门源&0.25", "格尔木市&0.30", "乌兰县茶卡&0.25", "共和县恰卜恰&0.25", "贵德&0.25", "民和&0.20", "唐古拉山五道梁&0.35", "兴海&0.25", "同德&0.25", "泽库&0.25", "格尔木市托托河&0.40", "治多&0.25", "杂多&0.25", "曲麻菜&0.25", "玉树&0.20", "玛多&0.30", "称多县清水河&0.25", "玛沁县仁峡姆&0.30", "达日县吉迈&0.25", "河南&0.25", "久治&0.20", "斑玛&0.20" };
            private string[] neimenggu21 = new string[] { "乌鲁木齐市&0.40", "阿泰勒市&0.40", "博乐市阿拉山口&0.95", "克拉玛依市&0.65", "伊宁市&0.40", "昭苏&0.25", "乌鲁木齐县达板城&0.55", "和静县巴音布鲁克&0.25", "吐鲁番市&0.50", "阿克苏市&0.30", "库车&0.35", "库尔勒市&0.30", "乌恰&0.25", "喀什市&0.35", "阿合奇&0.25", "皮山&0.20", "和田&0.25", "民丰&0.20", "民丰县安的河&0.20", "于田&0.20", "哈密&0.40" };
            private string[] neimenggu22 = new string[] { "郑州市&0.30", "安阳市&0.25", "新乡市&0.30", "三门峡市&0.25", "卢氏&0.20", "孟津&0.30", "洛阳市&0.25", "栾川&0.20", "许昌市&0.30", "开封市&0.30", "西峡&0.25", "南阳市&0.25", "宝丰&0.25", "西华&0.25", "驻马店市&0.25", "信阳市&0.25", "商丘市&0.20", "周始&0.20" };
            private string[] neimenggu23 = new string[] { "武汉市&0.25", "郧县&0.20", "房县&0.20", "老河口市&0.20", "枣阳市&0.25", "巴东&0.15", "钟祥&0.20", "麻城市&0.20", "恩施市&0.20", "巴东县绿葱坡&0.30", "五峰县&0.20", "宜昌市&0.20", "江陵县荆州&0.20", "天门市&0.20", "来风&0.20", "嘉鱼&0.20", "英山&0.20", "黄石市&0.25" };
            private string[] neimenggu24 = new string[] { "长沙市&0.25", "桑植&0.20", "石门&0.25", "南县&0.25", "岳阳市&0.25", "吉首市&0.20", "沅陵&0.20", "常德市&0.25", "安化&0.20", "沅江市&0.25", "平江&0.20", "芷江&0.20", "邵阳市&0.20", "双峰&0.20", "南岳&0.60", "通道&0.25", "武岗&0.20", "；零陵&0.25", "衡阳市&0.25", "道县&0.25", "郴州市&0.20" };
            private string[] neimenggu25 = new string[] { "广州市&0.30", "南雄&0.20", "连县&0.20", "韶关&0.20", "佛岗&0.20", "连平&0.20", "梅县&0.20", "广宁&0.20", "高要&0.30", "河源&0.20", "惠阳&0.35", "五华&0.20", "汕头市&0.50", "惠来&0.45", "南澳&0.50", "信宜&0.35", "罗定&0.20", "台山&0.35", "深圳市&0.45", "汕尾&0.50", "湛江市&0.50", "阳江&0.45", "电白&0.45", "台山县上川岛&0.75", "徐闻&0.45" };
            private string[] neimenggu26 = new string[] { "南宁市&0.25", "桂林市&0.20", "柳州市&0.20", "蒙山&0.20", "贺山&0.20", "百色市&0.25", "靖西&0.20", "桂平&0.20", "梧州市&0.20", "龙州&0.20", "灵山&0.20", "玉林&0.20", "东兴&0.45", "北海市&0.45", "涠州岛&0.70" };
            private string[] neimenggu27 = new string[] { "海口市&0.45", "东方&0.55", "儋县&0.40", "琼中&0.30", "琼海&0.50", "三亚市&0.50", "陵水&0.50", "西沙岛&1.05", "珊瑚岛&0.70" };
            private string[] neimenggu28 = new string[] { "成都市&0.20", "石渠&0.25", "若尔盖&0.25", "甘孜&0.35", "都江堰市&0.20", "绵阳市&0.20", "雅安市&0.20", "资阳&0.20", "康定&0.30", "汉源&0.20", "九龙&0.20", "越西&0.25", "昭觉&0.25", "雷波&0.20", "宜宾市&0.20", "盐源&0.20", "西昌市&0.20", "会理&0.20", "万源&0.20", "阎中&0.20", "巴中&0.20", "达县市&0.20", "奉节&0.25", "遂宁市&0.20", "南充市&0.20", "梁平&0.20", "万县市&0.15", "内江市&0.25", "涪陵市&0.20", "泸州市&0.20", "叙永&0.20" };
            private string[] neimenggu29 = new string[] { "贵阳市&0.20", "威宁&0.25", "盘县&0.25", "桐梓&0.20", "习水&0.20", "毕节&0.20", "遵义市&0.20", "湄潭&", "思南&0.20", "铜仁&0.20", "安顺市&0.20", "凯里市&0.20", "兴仁&0.20", "罗甸&0.20" };
            private string[] neimenggu30 = new string[] { "昆明市&0.20", "德钦&0.25", "贡山&0.20", "中甸&0.20", "维西&0.20", "昭通市&0.25", "丽江&0.25", "华坪&0.25", "会泽&0.25", "腾冲&0.20", "泸水&0.20", "保山市&0.20", "大理市&0.45", "元谋&0.25", "楚雄市&0.20", "曲靖市沾益&0.25", "瑞丽&0.20", "景东&0.20", "玉溪&0.20", "宜良&0.25", "泸西&0.25", "孟定&0.25", "临沧&0.20", "澜沧&0.20", "景洪&0.20", "思茅&0.25", "元江&0.25", "勐腊&0.20", "江城&0.20", "蒙自&0.25", "屏边&0.20", "文山&0.20", "广南&0.25" };
            private string[] neimenggu31 = new string[] { "拉萨市&0.20", "班戈&0.35", "安多&0.45", "那曲&0.30", "日喀则市&0.20", "乃东县则当&0.20", "隆子&0.30", "索县&0.25", "昌都&0.20", "林芝&0.25" };
            private string[] neimenggu32 = new string[] { "台北&0.40", "新竹&0.50", "宜兰&1.10", "台中&0.50", "花莲&0.40", "嘉义&0.50", "马公&0.85", "台东&0.65", "冈山&0.55", "恒春&0.70", "阿里山&0.25", "台南&0.60" };
            private string[] neimenggu33 = new string[] { "香港&0.80", "横澜岛&0.95" };
            private string[] neimenggu34 = new string[] { "澳门&0.75" };

            private void Cb_Item6SF_SelectedIndexChanged(object sender, EventArgs e)
            {//Item6中省份确定触发事件
                Cb_Item6DQ.Items.Clear();
                Cb_Item6DQ.Text = "";
                Tb_Item6SFDQFY.Text = "";
                string[] province = new string[] { };
                switch (Cb_Item6SF.SelectedItem.ToString())
                {
                    case "北京": province = neimenggu1; break;
                    case "天津": province = neimenggu2; break;
                    case "上海": province = neimenggu3; break;
                    case "重庆": province = neimenggu4; break;
                    case "河北": province = neimenggu5; break;
                    case "山西": province = neimenggu6; break;
                    case "内蒙古": province = neimenggu7; break;
                    case "辽宁": province = neimenggu8; break;
                    case "吉林": province = neimenggu9; break;
                    case "黑龙江": province = neimenggu10; break;
                    case "山东": province = neimenggu11; break;
                    case "江苏": province = neimenggu12; break;
                    case "浙江": province = neimenggu13; break;
                    case "安徽": province = neimenggu14; break;
                    case "江西": province = neimenggu15; break;
                    case "福建": province = neimenggu16; break;
                    case "陕西": province = neimenggu17; break;
                    case "甘肃": province = neimenggu18; break;
                    case "宁夏": province = neimenggu19; break;
                    case "青海": province = neimenggu20; break;
                    case "新疆": province = neimenggu21; break;
                    case "河南": province = neimenggu22; break;
                    case "湖北": province = neimenggu23; break;
                    case "湖南": province = neimenggu24; break;
                    case "广东": province = neimenggu25; break;
                    case "广西": province = neimenggu26; break;
                    case "海南": province = neimenggu27; break;
                    case "四川": province = neimenggu28; break;
                    case "贵州": province = neimenggu29; break;
                    case "云南": province = neimenggu30; break;
                    case "西藏": province = neimenggu31; break;
                    case "台湾": province = neimenggu32; break;
                    case "香港": province = neimenggu33; break;
                    case "澳门": province = neimenggu34; break;

                }
                for (int j = 0; j < province.Length; j++)
                {
                    string[] city_tempreture = province[j].ToString().Split('&');
                    //btnChildItem.Text = citys[0];
                    DevComponents.DotNetBar.ComboBoxItem item = new DevComponents.DotNetBar.ComboBoxItem();
                    item.Text = city_tempreture[0];
                    Cb_Item6DQ.Items.Add(item);
                }
                Cb_Item6DQ.Refresh();

            }

            private void Cb_Item6DQ_SelectedIndexChanged(object sender, EventArgs e)
            {//Item6中地区确定触发事件
                string[] province = new string[] { };
                switch (Cb_Item6SF.SelectedItem.ToString())
                {
                    case "北京": province = neimenggu1; break;
                    case "天津": province = neimenggu2; break;
                    case "上海": province = neimenggu3; break;
                    case "重庆": province = neimenggu4; break;
                    case "河北": province = neimenggu5; break;
                    case "山西": province = neimenggu6; break;
                    case "内蒙古": province = neimenggu7; break;
                    case "辽宁": province = neimenggu8; break;
                    case "吉林": province = neimenggu9; break;
                    case "黑龙江": province = neimenggu10; break;
                    case "山东": province = neimenggu11; break;
                    case "江苏": province = neimenggu12; break;
                    case "浙江": province = neimenggu13; break;
                    case "安徽": province = neimenggu14; break;
                    case "江西": province = neimenggu15; break;
                    case "福建": province = neimenggu16; break;
                    case "陕西": province = neimenggu17; break;
                    case "甘肃": province = neimenggu18; break;
                    case "宁夏": province = neimenggu19; break;
                    case "青海": province = neimenggu20; break;
                    case "新疆": province = neimenggu21; break;
                    case "河南": province = neimenggu22; break;
                    case "湖北": province = neimenggu23; break;
                    case "湖南": province = neimenggu24; break;
                    case "广东": province = neimenggu25; break;
                    case "广西": province = neimenggu26; break;
                    case "海南": province = neimenggu27; break;
                    case "四川": province = neimenggu28; break;
                    case "贵州": province = neimenggu29; break;
                    case "云南": province = neimenggu30; break;
                    case "西藏": province = neimenggu31; break;
                    case "台湾": province = neimenggu32; break;
                    case "香港": province = neimenggu33; break;
                    case "澳门": province = neimenggu34; break;
                }
                for (int j = 0; j < province.Length; j++)
                {
                    string[] city_tempreture = province[j].ToString().Split('&');
                    if (Cb_Item6DQ.SelectedItem.ToString() == city_tempreture[0])
                    {
                        Tb_Item6SFDQFY.Text = city_tempreture[1];
                        break;
                    }
                }
            }

            #endregion

        #endregion

        /// <summary>
        /// 风压高度变化系数μz,一维线性内插
        /// </summary>
        /// <param name="height">脚手架搭设高度</param>
        /// <param name="roughness">地面粗糙度</param>
         /// <returns>风压高度变化系数μz</returns>
        private double FengYaXiShu(double height, int roughness)
        {
            #region 风压高度变化系数μz ,求解过程
            double[,] uzArray = new double[,] { {1.17, 1.00, 0.74, 0.62 }, 
                                                                    {1.38, 1.00, 0.74, 0.62 } ,
                                                                    {1.52, 1.14, 0.74, 0.62 } ,
                                                                    {1.63, 1.25, 0.84, 0.62} ,
                                                                    { 1.80, 1.42, 1.00, 0.62} ,
                                                                    {1.92, 1.56, 1.13, 0.73 } ,
                                                                    { 2.03, 1.67, 1.25, 0.84} ,
                                                                    {2.12, 1.77, 1.35, 0.93 } ,
                                                                    {2.20, 1.86, 1.45, 1.02} ,
                                                                    { 2.27, 1.95, 1.54, 1.11} ,
                                                                    {2.34,2.02, 1.62, 1.19 } ,
                                                                    { 2.40, 2.09, 1.70, 1.27} ,
                                                                    {2.64,2.38,2.03,1.61},
                                                                    {2.83,2.61 ,2.30,1.92},
                                                                    {2.99,2.80 ,2.54,2.19},
                                                                    {3.12,2.97 ,2.75,2.45},
                                                                    {3.12,3.12,2.94,2.68},
                                                                    {3.12,3.12 ,3.12,2.91},
                                                                    {3.12,3.12 ,3.12,3.12}
                                                                  };
            double[] heightArray = new double[] { 5, 10, 15, 20, 30, 40, 50, 60, 70, 80, 90, 100 ,  150,200,250,300,350,400,450};
            int i = 0;
            int j = roughness;
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0, μz = 0;
            if (height >= 450)
            { μz = 3.12;  }
            else if (height >= 5 && height < 450)
            {
                for (i = 0; i < 19; i++)
                {//判断表中是否有对应的值
                    if (height == heightArray[i])//如果有，则直接读取
                    {
                        μz = uzArray[i, j];
                        break;
                    }
                    else if (height < heightArray[i]) //如果没有，则需用线性内插公式计算
                    {
                        x1 = heightArray[i - 1];
                        x2 = heightArray[i];
                        y1 = uzArray[i - 1, j];
                        y2 = uzArray[i, j];
                        μz = (y2 - y1) * (height - x1) / (x2 - x1) + y1; // 风压高度变化系数μz,由“脚手架搭设高度”和“地面粗糙度”得出.此为暂定值，以后还需修改
                        break;
                    }
                }
            }
            return μz;
              #endregion
        }

        /// <summary>
        /// 内插，求二维数组值
        /// </summary>
        /// <param name="valueArray">除去第一行和第一列后表中对应数值（二维数组）</param>
        /// <param name="xArray">表中第一行所有数值（一维数组）</param>
        /// <param name="yArray">表中第一列所有数值（一维数组）</param>
        /// <param name="x">用户输入的，第一行中内插的数值（数值）</param>
        /// <param name="y">用户输入的，第一列中内插的数值（数值）</param>
        /// <returns>内插结果</returns>
        private double ErweiShuzu(double[,] valueArray, double[] xArray,double[] yArray,double x,double y )
        {
            double value1_1, value1_2, value2_1, value2_2;
            double x1, x2;
            double y1, y2;
            double valueReturn=0;
            for (int i = 0; i < yArray.Length; i++)
            {
                if (y== yArray[i])//如果有步距
                {
                    for (int j = 0; j < xArray.Length; j++)
                    {//先判断表格中是否有对应的纵距值
                        if (x == xArray[j])//如果有纵距
                        {
                            valueReturn=valueArray[i, j];
                        }
                        else if (x < xArray[j])//如果没有纵距
                        {                           
                            value1_1 = valueArray[i, j - 1];
                            value1_2 = valueArray[i, j];
                            x1 = xArray[j - 1];
                            x2 = xArray[j];
                            valueReturn = (value1_2 - value1_1) * (x - x1) / (x2 - x1) + value1_1;
                            break;
                        }
                    }
                    break;
                }
                else if (y < yArray[i])//如果没有步距
                {
                    y1 = yArray[i - 1];//小步距
                    y2 = yArray[i];//大步距
                    for (int j = 0; j < xArray.Length; j++)
                    {
                        if (x == xArray[j])//如果有步距
                        {
                            value1_1 = valueArray[i - 1, j];
                            value2_1 = valueArray[i, j];
                            valueReturn = (value2_1 - value1_1) * (y - y1) / (y2 - y1) + value1_1;
                        }
                        else if (x < xArray[j])
                        {
                            value1_1 = valueArray[i-1, j-1];
                            value1_2 = valueArray[i-1, j];
                            value2_1 = valueArray[i, j-1];
                            value2_2= valueArray[i, j];
                            x1 = xArray[j - 1];
                            x2 = xArray[j];
                            double valueTemp1,valueTemp2;

                            valueTemp1 = (value2_1 - value1_1) * (y - y1) / (y2 - y1) + value1_1;
                            valueTemp2 = (value2_2 - value1_2) * (y - y1) / (y2 - y1) + value1_2;

                            valueReturn = (valueTemp2 - valueTemp1) * (x - x1) / (x2 - x1) + valueTemp1;
                            break;
                        }
                    }
                    break;
                }
            }
            return valueReturn;
      }

        /// <summary>
      /// 计算长度系数u,一维线性内插
        /// </summary>
        /// <param name="hengJv">立杆横距</param>
        /// <param name="LqjSet">连墙件布置</param>
        /// <returns>计算长度系数u</returns>
        private double YiweiShuzu(double hengJv,int LqjSet) 
        {
            #region 立杆计算长度系数u ,求解过程
            double[,] uArray = new double[,] { {1.50, 1.70}, {1.55, 1.75} ,{1.60, 1.80},{1.80, 2.0} };
            double[] hengJvArray = new double[] { 1.05, 1.30, 1.55};
            int ui = 0;
            int uj = LqjSet;
            double ux1 = 0, ux2 = 0, uy1 = 0, uy2 = 0, LgU = 0;
            if(CbxScaffoldType.SelectedIndex ==2)//单排脚手架
            {
                LgU = uArray[3,uj ];
            }
            else if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)// 双排悬挑脚手架
            {  
                for (ui = 0; ui < 3; ui++)
                {//判断表中是否有对应的立杆横距值
                    if (hengJv == hengJvArray[ui])//如果有，则直接读取
                    {
                        LgU = uArray[ui, uj];
                        break;
                    }
                    else if (hengJv < hengJvArray[ui]) //如果没有，则需用线性内插公式计算
                    {
                        ux1 = hengJvArray[ui - 1];
                        ux2 = hengJvArray[ui];
                        uy1 = uArray[ui - 1, uj];
                        uy2 = uArray[ui, uj];
                        LgU = (uy2 - uy1) * (hengJv - ux1) / (ux2 - ux1) + uy1; // 风压高度变化系数μz,由“脚手架搭设高度”和“地面粗糙度”得出.此为暂定值，以后还需修改
                        break;
                    }
                }
            }
            return LgU;
            #endregion
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            #region 全局变量
            #region LXtabItem6,五个脚手架都用到
            double pc6_3=0, pc6_4=0;
            string pc6_1 = "", pc6_2 = "", pc7_1 = "";
            pc6_1 = Cb_Item6SF.Text;  //省份
            pc6_2 = Cb_Item6DQ.Text; //地区
            pc6_3 = System.Convert.ToDouble(Tb_Item6SFDQFY.Text); //该地区风压是（kN/m2）
            if (Chk_Item6Self.Checked) //若用户勾选此处，则计算时将按用户自填的基本风压值计算;
            {
                pc6_4 = DbInput_Item6SelfJBFY.Value; //基本风压Wo（kN/m2）
                Lb_Item6SelfJBFY.Enabled = true;
                DbInput_Item6SelfJBFY.Enabled = true;
            }
            else //不勾选则按“省份”“地区”选择后得出的风压值计算。
            {
                pc6_4 = pc6_3;
                Lb_Item6SelfJBFY.Enabled = false;
                DbInput_Item6SelfJBFY.Enabled = false;
            }
            pc7_1 = Cb_Item7DMCCD.Text; //地面粗糙度
            double μz = 0;//风压高度变化系数
            #endregion
             #region 表B.0.6轴心受压构件的稳定系数Φ(Q235钢)
                double[,] λArray = new double[,] {  {	1	,	0.997	,	0.995	,	0.992	,	0.989	,	0.987	,	0.984	,	0.981	,	0.979	,	0.976	},
                                                                        {	0.974	,	0.971	,	0.968	,	0.966	,	0.963	,	0.96	,	0.958	,	0.955	,	0.952	,	0.949	},
                                                                        {	0.947	,	0.944	,	0.941	,	0.938	,	0.936	,	0.933	,	0.93	,	0.927	,	0.924	,	0.921	},
                                                                        {	0.918	,	0.915	,	0.912	,	0.909	,	0.906	,	0.903	,	0.899	,	0.896	,	0.893	,	0.889	},
                                                                        {	0.886	,	0.882	,	0.879	,	0.875	,	0.872	,	0.868	,	0.864	,	0.861	,	0.858	,	0.855	},
                                                                        {	0.852	,	0.849	,	0.846	,	0.843	,	0.839	,	0.836	,	0.832	,	0.829	,	0.825	,	0.822	},
                                                                        {	0.818	,	0.814	,	0.81	,	0.806	,	0.802	,	0.797	,	0.793	,	0.789	,	0.784	,	0.779	},
                                                                        {	0.775	,	0.77	,	0.765	,	0.76	,	0.755	,	0.75	,	0.744	,	0.739	,	0.733	,	0.728	},
                                                                        {	0.722	,	0.716	,	0.71	,	0.704	,	0.698	,	0.692	,	0.686	,	0.68	,	0.673	,	0.667	},
                                                                        {	0.661	,	0.654	,	0.648	,	0.641	,	0.634	,	0.626	,	0.618	,	0.611	,	0.603	,	0.595	},
                                                                        {	0.588	,	0.58	,	0.573	,	0.566	,	0.558	,	0.551	,	0.544	,	0.537	,	0.53	,	0.523	},
                                                                        {	0.516	,	0.509	,	0.502	,	0.496	,	0.489	,	0.483	,	0.476	,	0.47	,	0.464	,	0.458	},
                                                                        {	0.452	,	0.446	,	0.44	,	0.434	,	0.428	,	0.423	,	0.417	,	0.412	,	0.406	,	0.401	},
                                                                        {	0.396	,	0.391	,	0.386	,	0.381	,	0.376	,	0.371	,	0.367	,	0.362	,	0.357	,	0.353	},
                                                                        {	0.349	,	0.344	,	0.34	,	0.336	,	0.332	,	0.328	,	0.324	,	0.32	,	0.316	,	0.312	},
                                                                        {	0.308	,	0.305	,	0.301	,	0.298	,	0.294	,	0.291	,	0.287	,	0.284	,	0.281	,	0.277	},
                                                                        {	0.274	,	0.271	,	0.268	,	0.265	,	0.262	,	0.259	,	0.256	,	0.253	,	0.251	,	0.248	},
                                                                        {	0.245	,	0.243	,	0.24	,	0.237	,	0.235	,	0.232	,	0.23	,	0.227	,	0.225	,	0.223	},
                                                                        {	0.22	,	0.218	,	0.216	,	0.214	,	0.211	,	0.209	,	0.207	,	0.205	,	0.203	,	0.201	},
                                                                        {	0.199	,	0.197	,	0.195	,	0.193	,	0.191	,	0.189	,	0.188	,	0.186	,	0.184	,	0.182	},
                                                                        {	0.18	,	0.179	,	0.177	,	0.175	,	0.174	,	0.172	,	0.171	,	0.169	,	0.167	,	0.166	},
                                                                        {	0.164	,	0.163	,	0.161	,	0.16	,	0.159	,	0.157	,	0.156	,	0.154	,	0.153	,	0.152	},
                                                                        {	0.15	,	0.149	,	0.148	,	0.146	,	0.145	,	0.144	,	0.143	,	0.141	,	0.14	,	0.139	},
                                                                        {	0.138	,	0.137	,	0.136	,	0.135	,	0.133	,	0.132	,	0.131	,	0.13	,	0.129	,	0.128	},
                                                                        {	0.127	,	0.126	,	0.125	,	0.124	,	0.123	,	0.122	,	0.121	,	0.12	,	0.119	,	0.118	},
                                                                        {	0.117	,	0	,	0	,	0	,	0	,	0	,	0	,	0	,	0	,	0	}
                                                                    };
                #endregion
            #region 部分公用窗体变量定义
            //LXtabItem5
            string pc5_1 = "";
            double pc5_3=0;
            int pc5_2=0,pc5_4=0;
            //LXtabItem1
            double pc1_1 = 0, pc1_2 = 0, pc1_3 = 0, pc1_4 = 0, pc1_5 = 0, pc1_6 = 0, pc1_7 = 0, pc1_8 = 0, pc1_9 = 0, pc1_10 = 0;
            //LXtabItem2
            double pc2_7 = 0, pc2_5 = 0;
            string pc2_2="", pc2_1="", pc2_4="";
            //LXtabItem3
            string pc3_1 = "", pc3_2 = "";
            double pc3_3 = 0;
            //LXtabItem4
            string pc4_1 = "", pc4_3 = "";
            double pc4_2 = 0, pc4_4 = 0, pc4_6 = 0;
            int pc4_5 = 0;
            double gk = 0;//每米立杆自重标准值
            //LXtabItem8
            string pc8_1 = "", pc8_2 = "", pc8_3 = "";
            double  pc8_5 = 0, pc8_12 = 0, pc8_13 = 0 ;
            double μs = 0; //风荷载体型系数μs
            //LXtabItem9
            string pc9_1 = "";
            double pc9_2 = 0, pc9_3 = 0, pc9_4 = 0, pc9_5 = 1;
            //LXtabItem10
            string pc10_1 = "", pc10_4 = "";
            double pc10_2 = 0, pc10_3 = 0, pc10_5 = 0;
            //LXtabItem11
            double pc11_1 = 0, pc11_2 = 0;
            string pc11_3 = "";
            //LXtabItem16
            string pc16_5 = "", pc16_6 = "", pc16_7 = "", pc16_8 = "", pc16_9 = "", pc16_15 = "";
            double pc16_1 = 0, pc16_2 = 0, pc16_3 = 0, pc16_4 = 0;
            int pc16_10 = 0, pc16_11 = 0, pc16_12 = 0, pc16_13 = 0, pc16_14 = 0;
            //LXtabItem17
            string pc17_6 = "";
            double pc17_1 = 0, pc17_2 = 0, pc17_3 = 0, pc17_4 = 0, pc17_5 = 0, pc17_9 = 0, pc17_10 = 0, pc17_11 = 0;
            #endregion
            #endregion
            #region 前三个和碗扣式公用的
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1 || CbxScaffoldType.SelectedIndex == 2 || CbxScaffoldType.SelectedIndex == 4)
            {
                //LXtabItem5
                pc5_1 = Cb_Item5YT.Text;//脚手架用途
                pc5_2 = IntInput_Item5SGCS.Value;//同时施工层数
                pc5_3 = DbInput_Item5HZBZ.Value;//施工活荷载标准值
                pc5_4 = IntInput_Item5PSCS.Value;//脚手板、栏杆、挡脚板铺设层数,碗扣式专用
            }
            #endregion
            #region 前三个公共的
            if (CbxScaffoldType.SelectedIndex == 0||CbxScaffoldType.SelectedIndex == 1||CbxScaffoldType.SelectedIndex == 2)
            {
                //LXtabItem1
                pc1_1 = DbInput_Item1LGZJ.Value; //立杆纵距
                pc1_2 = DbInput_Item1LGHJ.Value;//立杆横距
                pc1_3 = DbInput_Item1BJ.Value;//立杆步距
                pc1_4 = DbInput_Item1DSGD.Value;//脚手架搭设高度
                pc1_5 = DbInput_Item1LQJL.Value;//脚手架内排的离墙距离
                pc1_6 = DbInput_Item1XHGWSCD.Value;//小横杆计算外伸长度
                pc1_7 = DbInput_Item1DKJ.Value;//单扣件抗滑承载力
                pc1_8 = DbInput_Item1SKJ.Value;//双扣件抗滑承载力
                pc1_9 = Convert.ToDouble(Tb_Item1BH.Text);//壁厚
                pc1_10 = Convert.ToDouble(Tb_Item1GGWJ.Text);//钢管外径
                //LXtabItem2
                pc2_2 = Rdo_Item2DHG.Text;
                pc2_7 = Convert.ToDouble(Cb_Item2DHGGS.Text);
                pc2_1 = Rdo_Item2XHG.Text;
                pc2_4 = Cb_Item2LGZJ.Text;
                pc2_5 = Convert.ToDouble(Tb_Item2XHGJJ.Text);
                //LXtabItem3
                pc3_1 = Cb_Item3JJ.Text; //连墙件间距
                pc3_2 = Cb_Item3FS.Text; //连墙件方式
                pc3_3 = DbInput_Item3ZXL.Value;//连墙件约束脚手架平面轴向力
                //LXtabItem4
                pc4_1 = Cb_Item4JSBLB.Text;//脚手板类别
                pc4_2 =Convert.ToDouble( Tb_Item4JSBZZBZZ.Text);//脚手板自重标准值
                pc4_3 = Cb_Item4JBLB.Text;//栏杆、挡脚板类别
                pc4_4 =Convert.ToDouble( Tb_Item4JBZZBZZ.Text);//栏杆、挡脚板自重标准值
                pc4_5 = IntInput_Item4PSCS.Value;//脚手板铺设层数
                pc4_6 = Convert.ToDouble(Tb_Item4AQW.Text);//安全网自重标准值
                #region 每米立杆自重标准值,调用函数ErweiShuzu()
                double[,] gksArray = new double[,] { { 0.1538, 0.1667, 0.1796, 0.1882, 0.1925 }, 
                                                                        { 0.1426, 0.1543, 0.1660, 0.1739, 0.1778}, 
                                                                        {0.1336, 0.1444, 0.1552, 0.1324, 0.1660 }, 
                                                                        { 0.1202, 0.1295, 0.1389, 0.1451, 0.1482}, 
                                                                        {0.1134, 0.1221, 0.1307, 0.1365, 0.1394} };//双排数组
                double[,] gkdArray = new double[,] { { 0.1642,0.1793,0.1945,0.2046,0.2097 }, 
                                                                        { 0.1530, 0.1670,	0.1809 ,0.1903, 0.1949 }, 
                                                                        {0.1440,0.1570,0.1701,0.1788 ,0.1831 }, 
                                                                        { 0.1305,0.1422 ,0.1538,	0.1615 ,0.1654 }, 
                                                                        {0.1238 ,0.1347 ,0.1456,	0.1529 ,0.1565 } };//单排数组
                double[] bjArray = new double[] { 1.20, 1.35, 1.50, 1.80, 2.00 };
                double[] zjArray = new double[] { 1.2, 1.5, 1.8, 2.0, 2.1 };
                if (CbxScaffoldType.SelectedIndex  == 0 || CbxScaffoldType.SelectedIndex  == 1)//双排脚手架
                { gk = ErweiShuzu(gksArray, zjArray, bjArray, pc1_1, pc1_3); }
                else if (CbxScaffoldType.SelectedIndex == 2)//单排脚手架
                { gk = ErweiShuzu(gkdArray, zjArray, bjArray, pc1_1, pc1_3); }
                Tb_Item4GK.Text = gk.ToString();
                #endregion 
                //LXtabItem6+7
                μz=FengYaXiShu(DbInput_Item1DSGD.Value, Cb_Item7DMCCD.SelectedIndex);//风压高度变化系数
               //LXtabItem8
                pc8_1 = Rdo_Item8WMMW.Text;//“敞开式脚手架（无密目网）”  
                pc8_2 = Rdo_Item8FBSK.Text;//“封闭式脚手架背靠敞开、框架和开洞墙”  
                pc8_3 = Rdo_Item8FBSQ.Text;//“封闭式脚手架背靠全封闭墙”            
                pc8_5 =Convert.ToDouble( Tb_Item8DFXS1.Text);//挡风系数                              
                pc8_12 =Convert.ToDouble( Tb_Item8YFMJ.Text);//迎风面积                              
                pc8_13 = DbIput_Item8DFMJ.Value; //挡风面积
                #region 利用挡风系数，求解风荷载体型系数μs的过程
                if (Rdo_Item8WMMW.Checked)
                {
                    μs = Convert.ToDouble(Tb_Item8DFXS1.Text) * 0.6;
                }
                else if (Rdo_Item8FBSK.Checked)
                {
                    if (Convert.ToDouble(Tb_Item8DFXS1.Text) >= 0.8)
                        μs = Convert.ToDouble(Tb_Item8DFXS1.Text) * 1.3;
                    else
                        μs = 0.8 * 1.3;
                }
                else if (Rdo_Item8FBSQ.Checked)
                {
                    if (Convert.ToDouble(Tb_Item8DFXS1.Text) >= 0.8)
                        μs = Convert.ToDouble(Tb_Item8DFXS1.Text);
                    else
                        μs = 0.8;
                }
                #endregion              
            }
            #endregion
            #region 双排、单排和碗扣式公用的
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 2 || CbxScaffoldType.SelectedIndex == 4)
            {
                //LXtabItem9
                pc9_1 = Cb_Item9DJTLX.Text;//地基土类型                            
                pc9_2 =Convert.ToDouble( Tb_Item9DJCZL.Text);//地基承载力标准值（kN/m2）
                pc9_3 = DbIput_Item9DBK.Value;//脚手架垫板宽（米） 
                pc9_4 =Convert.ToDouble( Tb_Item9ZYCD.Text);//作用长度（m）
                //地基类型
                double[] djArray = new double[] {1,0.4, 0.4 ,0.4, 0.5};
                pc9_5 = djArray[Cb_Item9DJLX.SelectedIndex];
            }
            #endregion
            #region 型钢悬挑专用
            if (CbxScaffoldType.SelectedIndex == 1) //2选择型钢悬挑脚手架
            {
                //LXtabItem10
                pc10_1 = Cb_Item10GLXH.Text;//钢梁型号 
                pc10_2 = DbInput_Item10MGD.Value;//悬挑梁锚固段长度（m）             	  
                pc10_3 = DbInput_Item10XTD.Value;//悬挑梁悬挑段长度（m）             	  
                pc10_4 = Cb_Item10RXND.Text;//悬挑梁容许挠度选择                    
                pc10_5 = Convert.ToDouble(Tb_Item10RXND.Text); //悬挑梁容许挠度（m） 
                //LXtabItem11
                pc11_1 = Convert.ToDouble(Cb_Item11ULSZJ.Text);// U 型钢筋拉环或螺栓直径（mm）      	  
                pc11_2 = Convert.ToDouble(Tb_Item11MGXGJL.Text);//锚固位置与型钢尾部距离（m）        	  
                pc11_3 = Cb_Item11LBHNTQD.Text;//楼板混凝土强度等级
            }
            #endregion
            #region 碗扣式专用
            if (CbxScaffoldType.SelectedIndex == 4) //5碗扣式脚手架
            {
                //LXtabItem16
                pc16_1 = DbInput_Lx5Item1BJ.Value;//	步距h(m)
                pc16_2 = DbInput_Lx5Item2GD.Value;//脚手架搭设高度
                pc16_3 = Convert.ToDouble(Cbx_Lx5Item1ZJ.Text);//立杆纵距la(m)
                pc16_4 = Convert.ToDouble(Cbx_Lx5Item1HJ.Text);//立杆横距lb(m)
                pc16_5 = Cbx_Lx5Item1JHG.Text;//间横杆钢管类型
                pc16_6 = Cbx_Lx5Item1LGG.Text;	//立杆钢管类型
                pc16_7 = Cbx_Lx5Item1WXG.Text;	//外斜杆钢管类型
                pc16_8 = Cbx_Lx5Item1SPX.Text;	//水平斜杆钢管类型
                pc16_9 = Cbx_Lx5Item1LDX.Text;//廊道斜杆钢管类型
                pc16_10 = Convert.ToInt32(Cbx_Lx5Item1DKJ.Text);	//单跨间横杆根数njg
                pc16_11 = Convert.ToInt32(Cbx_Lx5Item1WXGBZ.Text);	//外斜杆布置(几跨一设)
                pc16_12 = IntInput_Lx5Item1SPX.Value;	//水平斜杆布置(几步一设)
                pc16_13 = IntInput_Lx5Item1LDX.Value;	//廊道斜杆布置(几步一设)
                pc16_14 = IntInput_Lx5Item1NO.Value;	//可调底座承载力容许值N0(kN)
                pc16_15 = Cbx_Lx5Item1LGJXG.Text;	//立杆间斜杆设置
                //LXtabItem17
                pc17_1 = DbInput_Lx5Item2SX.Value;//	连墙件竖向间距H1（m）
                pc17_2 = DbInput_Lx5Item2SP.Value;//	连墙件水平间距L1（m）
                pc17_3 = DbInput_Lx5Item2L0.Value;//	连墙件计算长度l0 (mm)
                pc17_4 = DbInput_Lx5Item2BJ.Value;//	连墙件截面回转半径i(mm)
                pc17_5 = DbInput_Lx5Item2MJ.Value;//	连墙件截面面积Ac(mm2)
                pc17_6 = Cbx_Lx5Item2LQJ.Text;//	连墙件方式
                pc17_9 = DbInput_Lx5Item2KJ.Value;//	扣件抗滑移折减系数:
                pc17_10 = DbInput_Lx5Item2DJ.Value;//	对接焊缝的抗拉、压强度（N/mm2）
                pc17_11 = DbInput_Lx5Item2LJ.Value;//	拉接钢筋的抗拉强度（N/mm2）
            }
            #endregion

            #region 判断选择哪种脚手架模板, 总共五类脚手架, 11种模板(3+3+3+1+1)
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1 || CbxScaffoldType.SelectedIndex == 2)
            {
                #region (双排+悬挑+单排)公共计算过程,一二三
                #region  参数初始化
                //大横杆在上，一二三，参数初始化
                double Sum1D1P2 = 0, Sum1D1Q = 0, Sum1D1q1 = 0, Sum1D1q2 = 0;//一、1.均布荷载值计算
                double Sum1D2M1 = 0, Sum1D2M2 = 0, Sum1D2δ = 0; //一、2.抗弯强度计算
                string CompareD2δ = "";
                double Sum1D3q1 = 0, Sum1D3V = 0;//一、3.挠度计算
                string CompareD3V = "";
                double Sum1X1P1 = 0, Sum1X1P2 = 0, Sum1X1Q = 0, Sum1X1P = 0; //1.荷载值计算
                double Sum1X1M = 0, Sum1X2δ = 0; //二2.抗弯强度计算
                string CompareX2δ = "";
                double Sum1X3V1 = 0, Sum1X3P = 0, Sum1X3V2 = 0, Sum1X3V = 0;  //二3.挠度计算
                string CompareX3V1 = "";
                double Sum1K1P1 = 0, Sum1K1P2 = 0, Sum1K1Q = 0, Sum1K1R = 0;  //三、扣件抗滑力的计算:
                string CompareK1R = "";
                //小横杆在上，一二三，参数初始化
                double Sum2X1q2 = 0, Sum2X1dQ = 0, Sum2X1xq = 0, Sum2X2M = 0, Sum2X2δ = 0, Sum2X3V1 = 0;//一、小横杆在上,la2+la,公共参数定义
                string Compare2X2δ = "" , Compare2X3V1 = ""; //小横杆的计算强度，小横杆的最大挠度
                double Sum2D1Fk = 0, Sum2D1F = 0, Sum2D2Mmax = 0, Sum2D2δ = 0, Sum2D3V = 0, Sum2KR = 0;//二三、小横杆在上,la2+la,公共参数定义
                string Compare2D2δ = "",Compare2D3V = "",Compare2K1R = "";//大横杆的计算强度比较，大横杆的最大挠度比较，单扣件抗滑承载力
                #endregion
                #region 计算过程
                if (Rdo_Item2DHG.Checked) //大横杆在上
                {
                    #region 大横杆在上 ，计算过程一二三
                    //一、大横杆的计算:
                    //一、1.均布荷载值计算
                    Sum1D1P2 = pc4_2 * pc1_2 / (pc2_7 + 1);//脚手板的荷载标准值
                    Sum1D1Q = pc5_3 * pc1_2 / (pc2_7 + 1);// 活荷载标准值
                    Sum1D1q1 = 1.2 * 0.04 + 1.2 * Sum1D1P2;//静荷载的设计值
                    Sum1D1q2 = 1.4 * Sum1D1Q;// 活荷载的设计值
                    //一、2.抗弯强度计算
                    Sum1D2M1 = (0.08 * Sum1D1q1 + 0.10 * Sum1D1q2) * pc1_1 * pc1_1;// 跨中最大弯矩
                    Sum1D2M2 = -(0.10 * Sum1D1q1 + 0.117 * Sum1D1q2) * pc1_1 * pc1_1;//支座最大弯矩
                    Sum1D2δ = Math.Max(Math.Abs(Sum1D2M1), Math.Abs(Sum1D2M2)) * Math.Pow(10, 6) / 5260; //选择支座弯矩M2和跨中弯矩M1的最大值进行强度验算
                    if (Sum1D2δ <= 205) { CompareD2δ = "大横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum1D2δ == 205) { CompareD2δ = "大横杆的计算强度等于205.0N/mm2,满足要求!"; }
                    else if (Sum1D2δ >= 205) { CompareD2δ = "大横杆的计算强度小于205.0N/mm2,不满足要求!"; }
                    //一、3.挠度计算
                    Sum1D3q1 = 0.040 + Sum1D1P2;
                    Sum1D3V = (0.677 * Sum1D3q1 + 0.990 * Sum1D1Q) * (pc1_1) * 4 / (100 * 2.06 * 105 * 127100.0);
                    if ((Sum1D3V <= (pc1_1 / 150)) && (Sum1D3V <= 10)) { CompareD3V = "大横杆的最大挠度小于立杆纵距/150与10mm,满足要求!"; }
                    else if ((Sum1D3V == (pc1_1 / 150)) && (Sum1D3V == 10)) { CompareD3V = "大横杆的最大挠度等于立杆纵距/150与10mm,满足要求!"; }
                    else if ((Sum1D3V >= (pc1_1 / 150)) && (Sum1D3V >= 10)) { CompareD3V = "大横杆的最大挠度大于立杆纵距/150与10mm,不满足要求!"; }
                    //二、小横杆的计算:
                    //二1.荷载值计算
                    Sum1X1P1 = 0.040 * pc1_1;//大横杆的自重标准值
                    Sum1X1P2 = pc4_2 * pc1_2 * pc1_1 / (pc2_7 + 1);//脚手板的荷载标准值 
                    Sum1X1Q = pc5_3 * pc1_2 * pc1_1 / (pc2_7 + 1);  //活荷载标准值 
                    Sum1X1P = 1.2 * Sum1X1P1 + 1.2 * Sum1X1P2 + 1.4 * Sum1X1Q;//荷载的设计值 
                    //二2.抗弯强度计算
                    Sum1X1M = (1.2 * 0.040) * Math.Pow(pc1_2, 2) / 8 + (Sum1X1P * pc1_2) / (pc2_7 + 1);
                    Sum1X2δ = Sum1X1M * Math.Pow(10, 6) / 5260.0;
                    if (Sum1X2δ <= 205) { CompareX2δ = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum1X2δ == 205) { CompareX2δ = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum1X2δ >= 205) { CompareX2δ = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    //二3.挠度计算
                    Sum1X3V1 = 5.0 * 0.040 * Math.Pow(pc1_2, 4) / (384 * 2.060 * Math.Pow(10, 5) * 127100.000); //小横杆自重均布荷载引起的最大挠度
                    Sum1X3P = Sum1X1P1 + Sum1X1P2 + Sum1X1Q;//集中荷载标准值
                    Sum1X3V2 = Sum1X3P * 1000 * pc1_2 * (3 * Math.Pow(pc1_2, 2) - 4 * Math.Pow(pc1_2, 2) / 9) / (72 * 2.06 * Math.Pow(10, 5) * 127100.0);//集中荷载标准值最不利分配引起的最大挠度
                    Sum1X3V = Sum1X3V1 + Sum1X3V2;//最大挠度和
                    if ((Sum1X3V1 <= (pc1_2 / 150)) && (Sum1X3V1 <= 10)) { CompareX3V1 = " 小横杆的最大挠度小于 立杆横距/150与10mm,满足要求!"; }
                    else if ((Sum1X3V1 == (pc1_2 / 150)) && (Sum1X3V1 == 10)) { CompareX3V1 = "小横杆的最大挠度等于 立杆横距/150与10mm,满足要求!"; }
                    else if ((Sum1X3V1 >= (pc1_2 / 150)) && (Sum1X3V1 >= 10)) { CompareX3V1 = "小横杆的最大挠度大于 立杆横距/150与10mm,不满足要求!"; }
                    //三、扣件抗滑力的计算:
                    Sum1K1P1 = 0.040 * pc1_2; //横杆的自重标准值  
                    Sum1K1P2 = pc1_2 * pc1_2 * pc1_1 / 2;//脚手板的荷载标准值
                    Sum1K1Q = @pc5_3 * pc1_2 * pc1_1 / 2; //活荷载标准值
                    Sum1K1R = 1.2 * Sum1K1P1 + 1.2 * Sum1K1P2 + 1.4 * Sum1K1Q;//荷载的设计值
                    if (Sum1K1R <= pc1_7) { CompareK1R = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum1K1R == pc1_7) { CompareK1R = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    #region 大横杆在上数据转化
                    Sum1D1P2 = Convert.ToDouble(Sum1D1P2.ToString("f3"));
                    Sum1D1Q = Convert.ToDouble(Sum1D1Q.ToString("f3"));
                    Sum1D1q1 = Convert.ToDouble(Sum1D1q1.ToString("f3"));
                    Sum1D1q2 = Convert.ToDouble(Sum1D1q2.ToString("f3"));
                    Sum1D2M1 = Convert.ToDouble(Sum1D2M1.ToString("f3"));
                    Sum1D2M2 = Convert.ToDouble(Sum1D2M2.ToString("f3"));
                    Sum1D2δ = Convert.ToDouble(Sum1D2δ.ToString("f3"));
                    Sum1D3q1 = Convert.ToDouble(Sum1D3q1.ToString("f3"));
                    Sum1D3V = Convert.ToDouble(Sum1D3V.ToString("f3"));
                    Sum1X1P1 = Convert.ToDouble(Sum1X1P1.ToString("f3"));
                    Sum1X1P2 = Convert.ToDouble(Sum1X1P2.ToString("f3"));
                    Sum1X1Q = Convert.ToDouble(Sum1X1Q.ToString("f3"));
                    Sum1X1P = Convert.ToDouble(Sum1X1P.ToString("f3"));
                    Sum1X1M = Convert.ToDouble(Sum1X1M.ToString("f3"));
                    Sum1X2δ = Convert.ToDouble(Sum1X2δ.ToString("f3"));
                    Sum1X3V1 = Convert.ToDouble(Sum1X3V1.ToString("f3"));
                    Sum1X3P = Convert.ToDouble(Sum1X3P.ToString("f3"));
                    Sum1X3V2 = Convert.ToDouble(Sum1X3V2.ToString("f3"));
                    Sum1X3V = Convert.ToDouble(Sum1X3V.ToString("f3"));
                    Sum1K1P1 = Convert.ToDouble(Sum1K1P1.ToString("f3"));
                    Sum1K1P2 = Convert.ToDouble(Sum1K1P2.ToString("f3"));
                    Sum1K1Q = Convert.ToDouble(Sum1K1Q.ToString("f3"));
                    Sum1K1R = Convert.ToDouble(Sum1K1R.ToString("f3"));
                    #endregion

                    #endregion
                }
                else if(Rdo_Item2XHG.Checked==true ) //小横杆在上
                {
                    #region 一、小横杆在上,la2+la,公共的计算过程,一:
                    Sum2X1q2 = pc4_2 * pc1_2 / pc2_5;
                    Sum2X1dQ = pc5_3 * pc1_1 / pc2_5;
                    Sum2X1xq = 1.2 * 0.040 + 1.2 * Sum2X1q2 + 1.4 * Sum2X1dQ;
                    Sum2X2M = Sum2X1xq * pc1_2 * pc1_2 / 8;
                    Sum2X2δ = Sum2X2M * Math.Pow(10, 6) / 5260.0;
                    Sum2X3V1 = 5.0 * (0.040 + Sum2X1q2) * Math.Pow(pc1_2, 4) / (384 * 2.060 * Math.Pow(10, 5) * 127100.000);
                    if (Sum2X2δ <= 205) { Compare2X2δ = "小横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum2X2δ == 205) { Compare2X2δ = "小横杆的计算强度等于205.0N/mm2,满足要求!"; }
                    else if (Sum2X2δ >= 205) { Compare2X2δ = "小横杆的计算强度大于205.0N/mm2,不满足要求!"; }
                    if ((Sum2X3V1 <= (pc1_2 / 150)) && (Sum2X3V1 <= 10)) { Compare2X3V1 = "小横杆的最大挠度小于立杆横距/150与10mm,满足要求!"; }
                    else if ((Sum2X3V1 == (pc1_2 / 150)) && (Sum2X3V1 == 10)) { Compare2X3V1 = "小横杆的最大挠度等于立杆横距/150与10mm,满足要求!"; }
                    else if ((Sum2X3V1 >= (pc1_2 / 150)) && (Sum2X3V1 >= 10)) { Compare2X3V1 = "小横杆的最大挠度大于立杆横距/150与10mm,不满足要求!"; }
                    #endregion
                    if (Cb_Item2LGZJ.SelectedIndex == 0)//小横杆在上立杆纵距la2
                    {
                        #region 小横杆在上la2,计算过程二三
                        //二、大横杆的计算:
                        Sum2D1Fk = 0.5 * (0.040 + Sum2X1q2 + Sum2X1dQ) * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D1F = 0.5 * Sum2X1xq * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D2Mmax = 0.175 * Sum2D1F * pc1_1 + 0.1 * 0.040 * pc1_1 * pc1_1;
                        Sum2D2δ = Sum2D2Mmax * Math.Pow(10, 6) / 5260.0;
                        Sum2D3V = (0.677 * 0.04 * pc1_1 + 1.146 * Sum2D1Fk) * Math.Pow(pc1_1, 3) / (100 * 2.06 * Math.Pow(10, 5) * 127100.0);
                        //三、扣件抗滑力的计算:
                        Sum2KR = 2.15 * 3.412 + 0.040 * pc1_1 / 3;
                        #endregion
                    }
                    else if (Cb_Item2LGZJ.SelectedIndex == 1)//小横杆在上立杆纵距la
                    {
                        #region 小横杆在上la,计算过程二三
                        //二、大横杆的计算:
                        Sum2D1Fk = 0.5 * (0.040 + Sum2X1q2 + Sum2X1dQ) * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D1F = 0.5 * Sum2X1xq * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D2Mmax = 0.1 * 0.040 * pc1_1 * pc1_1;//不同于la2之处
                        Sum2D2δ = Sum2D2Mmax * Math.Pow(10, 6) / 5260.0;
                        Sum2D3V = (0.677 * 0.04 * Math.Pow(pc1_1, 4)) / (100 * 2.06 * Math.Pow(10, 5) * 127100.0);
                        //三、扣件抗滑力的计算:
                        Sum2KR = 3.412 + 0.040 * pc1_1 / 3;
                        #endregion
                    }
                    if (Sum2D2δ <= 205) { Compare2D2δ = "大横杆的计算强度小于205.0N/mm2,满足要求!"; }
                    else if (Sum2D2δ == 205) { Compare2D2δ = "大横杆的计算强度等于205.0N/mm2,满足要求!"; }
                    else if (Sum2D2δ >= 205) { Compare2D2δ = "大横杆的计算强度大于205.0N/mm2,不满足要求!"; }
                    if ((Sum2D3V <= (pc1_1 / 150)) && (Sum2D3V <= 10)) { Compare2D3V = "大横杆的最大挠度小于立杆纵距/150与10mm,满足要求!"; }
                    else if ((Sum2D3V == (pc1_1 / 150)) && (Sum2D3V == 10)) { Compare2D3V = "大横杆的最大挠度等于立杆纵距/150与10mm,满足要求!"; }
                    else if ((Sum2D3V >= (pc1_1 / 150)) && (Sum2D3V >= 10)) { Compare2D3V = "大横杆的最大挠度大于立杆纵距/150与10mm,不满足要求!"; }
                    if (Sum2KR <= pc1_7) { Compare2K1R = "单扣件抗滑承载力的设计计算满足要求!"; }
                    else if (Sum2KR == pc1_7) { Compare2K1R = "单扣件抗滑承载力的设计计算不满足要求!"; }
                }
                #endregion
                #region 小横杆在上数据转化
                Sum2X1q2 = Convert.ToDouble(Sum2X1q2.ToString("f3"));
                Sum2X1dQ = Convert.ToDouble(Sum2X1dQ.ToString("f3"));
                Sum2X1xq = Convert.ToDouble(Sum2X1xq.ToString("f3"));
                Sum2X2M = Convert.ToDouble(Sum2X2M.ToString("f3"));
                Sum2X2δ = Convert.ToDouble(Sum2X2δ.ToString("f3"));
                Sum2X3V1 = Convert.ToDouble(Sum2X3V1.ToString("f3"));
                Sum2D1Fk = Convert.ToDouble(Sum2D1Fk.ToString("f3"));
                Sum2D1F = Convert.ToDouble(Sum2D1F.ToString("f3"));
                Sum2D2Mmax = Convert.ToDouble(Sum2D2Mmax.ToString("f3"));
                Sum2D2δ = Convert.ToDouble(Sum2D2δ.ToString("f3"));
                Sum2D3V = Convert.ToDouble(Sum2D3V.ToString("f3"));
                Sum2KR = Convert.ToDouble(Sum2KR.ToString("f3"));
                #endregion

                #endregion

                #region (双排+悬挑+单排)公共计算过程,四五六七
                //四、脚手架荷载标准值:
                double Sum1NG1 = 0, Sum1NG2 = 0, Sum1NG3 = 0, Sum1NG4 = 0, Sum1NG = 0, Sum1NQ = 0, Sum1Wk = 0, Sum1YesN = 0, Sum1NoN = 0, Sum1MW = 0;
                Sum1NG1 = gk * pc1_4;
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//(双排+悬挑)脚手架
                {Sum1NG2 = pc4_2 * pc4_5 * pc1_1 * (pc1_2 + pc1_6) / 2;}
                else if (CbxScaffoldType.SelectedIndex == 2)//单排脚手架
                { Sum1NG2 = pc4_2 * pc4_5 * pc1_1 * pc1_2  / 2; }
                Sum1NG3 = pc4_4 * pc1_1 * pc4_5 / 2;
                Sum1NG4 = pc4_6 * pc1_1 * pc1_4;
                Sum1NG = Sum1NG1 + Sum1NG2 + Sum1NG3 + Sum1NG4; //静荷载标准值
                Sum1NQ = pc5_3 * pc5_2 * pc1_1 * pc1_2 / 2;
                Sum1Wk = 0.7 * pc6_4 * μz * μs;
                Sum1YesN = 1.2 * Sum1NG + 0.9 * 1.4 * Sum1NQ;//考虑风荷载时,立杆的轴向压力设计值
                Sum1NoN = 1.2 * Sum1NG + 1.4 * Sum1NQ;//不考虑风荷载时,立杆的轴向压力设计值
                Sum1MW = 0.9 * 1.4 * Sum1Wk * pc1_1 * Math.Pow(pc1_3, 2) / 10;
                //五、立杆的稳定性计算:
                double LgU = 0, LgL0 = 0, Lgλ = 0, LgΦ = 0, Sum1Noδ = 0, Sum1Yesδ = 0;
                LgU = YiweiShuzu(DbInput_Item1LGHJ.Value, Cb_Item3JJ.SelectedIndex);//调用函数,计算长度系数u
                LgL0 = 1.155 * LgU * pc1_3;
                Lgλ = LgL0 / 159;
                if (Lgλ > 250)
                {
                    LgΦ = 7320 / (Lgλ * Lgλ);
                }
                else
                {
                    int Lgλy1 = Convert.ToInt32(Lgλ / 10);//第λy1行
                    int Lgλx1 = Convert.ToInt32(Lgλ % 10);// 第λx1列
                    LgΦ = λArray[Lgλy1, Lgλx1]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                string CompareNoδ = ""; 
                Sum1Noδ = Sum1NoN / (LgΦ * 5.06);
                if (Sum1Noδ <= 205) { CompareNoδ = "不考虑风荷载时，立杆的稳定性计算δ< [f],满足要求!"; }
                else if (Sum1Noδ == 205) { CompareNoδ = "不考虑风荷载时，立杆的稳定性计算δ= [f],满足要求!"; }
                else if (Sum1Noδ >= 205) { CompareNoδ = "不考虑风荷载时，立杆的稳定性计算δ> [f],满足要求!"; }
                string CompareYesδ = "";
                Sum1Yesδ = Sum1YesN / (LgΦ * 5.06) + Sum1MW / 5.26;
                if (Sum1Yesδ <= 205) { CompareYesδ = "考虑风荷载时，立杆的稳定性计算δ< [f],满足要求!"; }
                else if (Sum1Yesδ == 205) { CompareYesδ = "考虑风荷载时，立杆的稳定性计算δ= [f],满足要求!"; }
                else if (Sum1Yesδ >= 205) { CompareYesδ = "考虑风荷载时，立杆的稳定性计算δ> [f],满足要求!"; }
                //六、最大搭设高度的计算:
                double Sum1NG2K = 0, Sum1Mwk = 0, Sum1NoHs = 0, Sum1YesHs = 0, Sum1compareH = 0;
                Sum1NG2K = Sum1NG2 + Sum1NG3 + Sum1NG4;
                Sum1Mwk = Sum1Wk * pc1_1 * (pc1_3 * pc1_3) / 10;
                Sum1NoHs = (LgΦ * 5.06 * 205 - (1.2 * Sum1NG2K + 1.4 * Sum1NQ)) / (1.2 * gk);
                Sum1YesHs = (LgΦ * 5.06 * 205 - (1.2 * Sum1NG2K + 0.9 * 1.4 * (Sum1NQ + (Sum1Mwk / 5.26) * (LgΦ * 5.06)))) / (1.2 * gk);
                Sum1compareH = Math.Min(Sum1NoHs, Sum1YesHs);
                string CompareHs = "";
                if (pc1_4 <= Sum1compareH) { CompareHs = "小于[H]，满足要求！"; }
                else if (pc1_4 == Sum1compareH) { CompareHs = "等于[H]，满足要求！"; }
                else if (pc1_4 >= Sum1compareH) { CompareHs = "大于[H]，不满足要求！"; }
                //七、连墙件的计算:
                int m = 0, n = 0;
                switch (Cb_Item3JJ.SelectedIndex)
                {
                    case 0: m = 2; n = 3; break;
                    case 1: m = n = 3; break;
                }
                double Sum1Aw = 0, Sum1Nlw = 0, Sum1Nl = 0, Sum1Lqjδ=0;
                Sum1Aw = m * pc1_3 * n * pc1_1;
                Sum1Nlw = 1.4 * Sum1Wk * Sum1Aw; //风荷载产生的连墙件轴向力设计值
                Sum1Nl = Sum1Nlw + pc3_3;//连墙件轴向力设计值
                Sum1Lqjδ = Sum1Nl / 506;// 连墙件的强度
                string CompareF1 = "";
                if (Sum1Lqjδ <= (0.85 * 205)) { CompareF1 = " 经计算得δ小于0.85f,满足要求！"; }
                else if (Sum1Lqjδ == (0.85 * 205)) { CompareF1 = " 经计算得δ等于0.85f,满足要求！"; }
                else if (Sum1Lqjδ >= (0.85 * 205)) { CompareF1 = " 经计算得δ大于0.85f,满足要求！"; }
                double Sum1NlΦA, LqjΦ;
                double Lqjλ = 0;
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//(双排+悬挑)脚手架
                { Lqjλ = pc1_5 / 159; }
                else if (CbxScaffoldType.SelectedIndex == 2)
                { Lqjλ = pc1_2 / 159; }
                if (Lqjλ > 250)
                {
                    LqjΦ = 7320 / (Lgλ * Lgλ);
                }
                else
                {
                    int Lqjλy1 = Convert.ToInt32(Lqjλ / 10);//第λy1行
                    int Lqjλx1 = Convert.ToInt32(Lqjλ % 10);// 第λx1列
                    LqjΦ = λArray[Lqjλy1, Lqjλx1]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                Sum1NlΦA = Sum1Nl / (LqjΦ * 1832);
                string CompareF2 = "";
                if (Sum1NlΦA <= (0.85 * 205)) { CompareF2 = " 小于0.85f,满足要求！"; }
                else if (Sum1NlΦA == (0.85 * 205)) { CompareF2 = " 等于0.85f,满足要求！"; }
                else if (Sum1NlΦA >= (0.85 * 205)) { CompareF2 = " 大于0.85f,满足要求！"; }
                #region (双排+悬挑+单排)公共计算过程,四五六七 数据转化
                Sum1NG1 = Convert.ToDouble(Sum1NG1.ToString("f3"));
                Sum1NG2 = Convert.ToDouble(Sum1NG2.ToString("f3"));
                Sum1NG3 = Convert.ToDouble(Sum1NG3.ToString("f3"));
                Sum1NG4 = Convert.ToDouble(Sum1NG4.ToString("f3"));
                Sum1NG = Convert.ToDouble(Sum1NG.ToString("f3"));
                Sum1NQ = Convert.ToDouble(Sum1NQ.ToString("f3"));
                Sum1Wk = Convert.ToDouble(Sum1Wk.ToString("f3"));
                Sum1YesN = Convert.ToDouble(Sum1YesN.ToString("f3"));
                Sum1NoN = Convert.ToDouble(Sum1NoN.ToString("f3"));
                Sum1MW = Convert.ToDouble(Sum1MW.ToString("f3"));
                LgL0 = Convert.ToDouble(LgL0.ToString("f3"));
                Lgλ = Convert.ToDouble(Lgλ.ToString("f3"));
                LgΦ = Convert.ToDouble(LgΦ.ToString("f3"));
                Sum1Noδ = Convert.ToDouble(Sum1Noδ.ToString("f3"));
                Sum1Yesδ = Convert.ToDouble(Sum1Yesδ.ToString("f3"));
                Sum1NG2K = Convert.ToDouble(Sum1NG2K.ToString("f3"));
                Sum1Mwk = Convert.ToDouble(Sum1Mwk.ToString("f3"));
                Sum1NoHs = Convert.ToDouble(Sum1NoHs.ToString("f3"));
                Sum1YesHs = Convert.ToDouble(Sum1YesHs.ToString("f3"));
                Sum1Aw = Convert.ToDouble(Sum1Aw.ToString("f3"));
                Sum1Nlw = Convert.ToDouble(Sum1Nlw.ToString("f3"));
                Sum1Nl = Convert.ToDouble(Sum1Nl.ToString("f3"));
                Sum1Lqjδ = Convert.ToDouble(Sum1Lqjδ.ToString("f3"));
                Sum1NlΦA = Convert.ToDouble(Sum1NlΦA.ToString("f3"));
                LqjΦ = Convert.ToDouble(LqjΦ.ToString("f3"));
                Lqjλ = Convert.ToDouble(Lqjλ.ToString("f3"));
                
                #endregion
                #endregion

                #region  (双排+单排)公共计算过程八；悬挑，计算过程八九十
                double Sum1NK = 0, Sum1A = 0, Sum1Pk = 0, Sum1fg = 0;   //单双排八、立杆的地基承载力计算,参数定义
                string Comparefg = "";
                #region 工字钢参数表
                double[] hArray = new double[] { 160, 180, 200, 200, 220, 220, 240, 240, 250, 250, 270, 270, 280, 280, 300, 300, 300, 320, 320, 320, 360, 360, 360, 400, 400, 400, 450, 450, 450, 500, 500, 500, 550, 550, 550, 560, 560, 560, 630, 630, 630 };
                double[] bArray = new double[] { 88, 94, 100, 102, 110, 112, 116, 118, 116, 118, 122, 124, 122, 124, 126, 128, 130, 130, 132, 134, 136, 138, 140, 142, 144, 146, 150, 152, 154, 158, 160, 162, 168, 168, 170, 166, 168, 170, 176, 178, 180 };
                double[] dArray = new double[] { 6, 6.5, 7, 9, 7.5, 9.5, 8, 10, 8, 10, 8.5, 10.5, 8.5, 10.5, 9, 11, 13, 9.5, 11.5, 13.5, 10, 12, 14, 10.5, 12.5, 14.5, 11.5, 13.5, 15.5, 12, 14, 16, 12.5, 14.5, 16.5, 12.5, 14.5, 16.5, 13, 15, 17 };
                double[] tArray = new double[] { 9.9, 10.7, 11.4, 11.4, 12.3, 12.3, 13, 13, 13, 13, 13.7, 13.7, 13.7, 13.7, 14.4, 14.4, 14.4, 15, 15, 15, 15.8, 15.8, 15.8, 16.5, 16.5, 16.5, 18, 18, 18, 20, 20, 20, 21, 21, 21, 21, 21, 21, 22, 22, 22 };
                double[] rArray = new double[] { 8, 8.5, 9, 9, 9.5, 9.5, 10, 10, 10, 10, 10.5, 10.5, 10.5, 10.5, 11, 11, 11, 11.5, 11.5, 11.5, 12, 12, 12, 12.5, 12.5, 12.5, 13.5, 13.5, 13.5, 14, 14, 14, 14.5, 14.5, 14.5, 14.5, 14.5, 14.5, 15, 15, 15 };
                double[] r1Array = new double[] { 4, 4.3, 4.5, 4.5, 4.8, 4.8, 5, 5, 5, 5, 5.3, 5.3, 5.3, 5.3, 5.5, 5.5, 5.5, 5.8, 5.8, 5.8, 6, 6, 6, 6.3, 6.3, 6.3, 6.8, 6.8, 6.8, 7, 7, 7, 7.3, 7.3, 7.3, 7.3, 7.3, 7.3, 7.5, 7.5, 7.5 };
                double[] aArray = new double[] { 26.131, 30.756, 35.578, 39.578, 42.128, 46.528, 47.741, 52.541, 48.541, 53.541, 54.554, 59.954, 55.404, 61.004, 61.254, 67.254, 73.254, 67.156, 73.556, 79.956, 76.48, 83.68, 90.88, 86.112, 94.112, 102.112, 102.446, 111.446, 120.446, 119.304, 129.304, 139.304, 134.185, 145.185, 156.185, 135.435, 146.635, 157.835, 154.658, 167.258, 179.858 };
                double[] weightArray = new double[] { 20.513, 24.143, 27.929, 31.069, 33.07, 36.524, 37.477, 41.245, 38.105, 42.03, 42.825, 47.064, 43.492, 47.888, 48.084, 52.794, 57.504, 52.717, 57.741, 62.765, 60.037, 65.689, 71.341, 67.598, 73.878, 80.158, 80.42, 87.485, 94.55, 93.654, 101.504, 109.354, 105.335, 113.97, 122.605, 106.316, 115.108, 123.9, 121.407, 131.298, 141.189 };
                double[] ix1Array = new double[] { 1130, 1660, 2370, 2500, 3400, 3570, 4570, 4800, 5020, 5280, 6550, 6870, 7110, 7480, 8950, 9400, 9850, 11100, 11600, 12200, 15800, 16500, 17300, 21700, 22800, 23900, 22200, 33800, 35300, 46500, 48600, 50600, 62900, 65600, 68400, 65600, 68500, 71400, 93900, 98100, 102000 };
                double[] iy1Array = new double[] { 93.1, 122, 158, 169, 225, 239, 280, 297, 280, 309, 345, 366, 345, 379, 400, 422, 445, 460, 502, 544, 552, 582, 612, 660, 692, 727, 855, 894, 938, 1120, 1170, 1220, 1370, 1420, 1480, 1370, 1490, 1560, 1700, 1810, 1920 };
                double[] ix2Array = new double[] { 6.58, 7.36, 8.15, 7.96, 8.99, 8.78, 9.77, 9.57, 10.2, 9.94, 10.9, 10.7, 11.3, 11.1, 12.1, 11.8, 11.6, 12.8, 12.6, 12.3, 14.4, 14.1, 13.8, 15.9, 15.6, 15.2, 17.7, 17.4, 17.1, 19.7, 19.4, 19, 21.6, 21.2, 20.9, 22, 21.6, 21.3, 24.5, 24.2, 23.8 };
                double[] iy2Array = new double[] { 1.89, 2, 2.12, 2.06, 2.31, 2.27, 2.42, 2.38, 2.4, 2.4, 2.51, 2.47, 2.5, 2.49, 2.55, 2.5, 2.46, 2.62, 2.61, 2.61, 2.69, 2.64, 2.6, 2.77, 2.71, 2.65, 2.89, 2.84, 2.79, 3.07, 3.01, 2.96, 3.19, 3.14, 3.08, 3.18, 3.16, 3.16, 3.31, 3.29, 3.27 };
                double[] wxArray = new double[] { 141, 185, 237, 250, 309, 325, 381, 400, 402, 423, 485, 509, 508, 534, 597, 627, 657, 692, 726, 760, 875, 919, 962, 1090, 1140, 1190, 1430, 1500, 1570, 1860, 1940, 2080, 2290, 2390, 2490, 2340, 2450, 2550, 2980, 3160, 3300 };
                double[] wyArray = new double[] { 21.2, 26, 31.5, 33.1, 40.9, 42.7, 48.4, 50.4, 48.3, 52.4, 56.6, 58.9, 56.6, 61.2, 63.5, 65.9, 68.5, 70.8, 76, 81.2, 81.2, 84.3, 87.4, 93.2, 96.2, 99.6, 114, 118, 122, 142, 146, 151, 164, 170, 175, 165, 174, 183, 193, 204, 214 };
                double hParam = 0, bParam = 0, dParam = 0, tParam = 0, rParam = 0, r1Param = 0, aParam = 0, weightParam = 0, ix1Param = 0, iy1Param = 0, ix2Param = 0, iy2Param = 0, wxParam = 0, wyParam = 0;
                
                #endregion
                double Sum4N1 = 0, Sum4q1 = 0, Sum4k = 0, Sum4k1 = 0, Sum4k2 = 0, Sum4RA = 0, Sum4RB = 0, Sum4MA = 0, Sum4f = 0, Sum4N2 = 0, Sum4q2 = 0, Sum4Vmax = 0;//悬挑,八(型钢悬挑梁受力)
                string CompareXgf="",CompareVmax = "";
                double Sum4Φb1 = 0, Sum4Φb = 0, Sum4σ1 = 0, ζParam = 0, βbParam = 0, λyParam = 0, fy = 235, ηb = 0;//九(悬挑梁整体稳定性)
                string strSum4Φb="", CompareΦbσ = "";
                double Sum4σ2 = 0, Sum4Mgd = 0, Sum4d = 0, fc = 0, Sum4fc = 0, Sum4Lsll = 0;//十(锚固段与楼板连接计算)
                string CompareLhsl = "" ,CompareLsll="";
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 2)//如果是单双排脚手架,计算,八(立杆的地基承载力计算)
                {
                    #region  单双排,公共计算过程，八、立杆的地基承载力计算:
                    Sum1NK = 1.2 * Sum1NG + 1.4 * Sum1NQ;
                    Sum1A = pc9_3 * pc1_1;
                    Sum1Pk = Sum1NK / Sum1A;
                    Sum1fg = pc9_2 * pc9_5;
                    if (Sum1Pk <= Sum1fg) { Comparefg = " 经计算得到地基承载力的计算,满足要求!"; }
                    else if (Sum1Pk > Sum1fg) { Comparefg = " 经计算得到地基承载力的计算,不满足要求!"; }
                    #region 单双排,公共计算过程，八、立杆的地基承载力计算数据转化
                    Sum1NK = Convert.ToDouble(Sum1NK.ToString("f3"));
                    Sum1A = Convert.ToDouble(Sum1A.ToString("f3"));
                    Sum1Pk = Convert.ToDouble(Sum1Pk.ToString("f3"));
                    Sum1fg = Convert.ToDouble(Sum1fg.ToString("f3"));
                   
                    #endregion
                    #endregion
                }
                else if (CbxScaffoldType.SelectedIndex == 1)//如果是悬挑脚手架,计算,八(型钢悬挑梁受力)、九(悬挑梁整体稳定性)、十(锚固段与楼板连接计算)
                {
                    int xinghaoNum = Cb_Item10GLXH.SelectedIndex;
                    hParam = hArray[xinghaoNum];
                    bParam = bArray[xinghaoNum];
                    dParam = dArray[xinghaoNum];
                    tParam = tArray[xinghaoNum];
                    rParam = rArray[xinghaoNum];
                    r1Param = r1Array[xinghaoNum];
                    aParam = aArray[xinghaoNum];
                    weightParam = weightArray[xinghaoNum];
                    ix1Param = ix1Array[xinghaoNum];
                    iy1Param = iy1Array[xinghaoNum];
                    ix2Param = ix2Array[xinghaoNum];
                    iy2Param = iy2Array[xinghaoNum];
                    wxParam = wxArray[xinghaoNum];
                    wyParam = wyArray[xinghaoNum];
                    //八(型钢悬挑梁受力)
                    double mParam = pc10_3, lParam = pc10_2, m1Param = pc1_5, m2Param = pc1_2;
                    Sum4N1 = 1.2 * Sum1NG + 1.4 * Sum1NQ;
                    Sum4q1 = 1.2 * weightParam * (pc10_3 + pc10_2 - 200) * 0.001 * 9.8 * 0.001;
                    Sum4k = pc10_3 / (pc10_2 - 200);
                    Sum4k1 = pc1_5 / (pc10_2 - 200);
                    Sum4k2 = pc1_2 / (pc10_2 - 200);
                    Sum4RA = Sum4N1 * (2 + Sum4k2 + Sum4k1) + (Sum4q1 * pc10_2 / 2) * Math.Pow((1 + Sum4k), 2);
                    Sum4RB = -Sum4N1 * (Sum4k2 + Sum4k1) + (Sum4q1 * pc10_2 / 2) * (1 - Math.Pow(Sum4k, 2));
                    Sum4MA = -Sum4N1 * (m2Param + m1Param) - Sum4q1 * Math.Pow(mParam, 2) / 2;
                    Sum4f = Sum4MA * Math.Pow(10, 6) / (1.05 * wxParam * 1000);
                    if (Sum4f < 205) { CompareXgf = " 型钢悬挑梁应力值小于205.0N/mm2,满足要求!"; }
                    else if (Sum4f == 205) { CompareXgf = "型钢悬挑梁应力值等于205.0N/mm2,满足要求!"; }
                    else if (Sum4f > 205) { CompareXgf = " 型钢悬挑梁应力值大于205.0N/mm2,不满足要求!"; }
                    Sum4N2 = Sum1NG + Sum1NQ;
                    Sum4q2 = weightParam * (pc10_3 + pc10_2 - 200) * 0.001 * 9.8 * 0.001;
                    Sum4Vmax = (Sum4N2 * Math.Pow(m2Param, 2) * lParam * (1 + Sum4k2) / (3 * 2.06 * ix1Param) + Sum4N2 * Math.Pow(m1Param, 2) * lParam * (1 + Sum4k1) / (3 * 2.06 * ix1Param) + mParam * Sum4q2 * Math.Pow(lParam, 3) * (-1 + 4 * Math.Pow(Sum4k, 2) + 3 * Math.Pow(Sum4k, 3)) / (3 * 2.06 * ix1Param * 8))*1000;       //还未完成
                    if (Sum4Vmax < pc10_5) { CompareVmax = " 水平支撑梁的最大挠度小于悬挑梁容许挠度，满足要求!"; }
                    else if (Sum4Vmax == pc10_5) { CompareVmax = "水平支撑梁的最大挠度等于悬挑梁容许挠度，满足要求!"; }
                    else if (Sum4Vmax > pc10_5) { CompareVmax = " 水平支撑梁的最大挠度大于悬挑梁容许挠度，不满足要求!"; }
                    //九(悬挑梁整体稳定性)
                    ζParam = pc10_3*1000 * tParam / (bParam * hParam);
                    if (ζParam >= 0.60 && ζParam <= 1.24){βbParam = 0.21 + 0.67 * ζParam;}
                    else if(ζParam >1.24 && ζParam <= 1.96){ βbParam = 0.72 + 0.26 * ζParam; }
                    else if (ζParam >1.96 && ζParam <= 3.10){ βbParam = 1.17 + 0.03 * ζParam; }
                    λyParam = pc10_3 / iy2Param;
                    Sum4Φb1 = (βbParam * 4320 / Math.Pow(λyParam, 2)) * (aParam * hParam / wxParam) * (Math.Sqrt(1 + Math.Pow(λyParam * tParam / (4.4 * hParam), 2)) + ηb) * 235 / fy;
                    if (Sum4Φb > 0.6)
                    {
                        double Sum4Φb2 = 1.07 - 0.282 / Sum4Φb1;
                        strSum4Φb = "由于 b大于0.6，按照《钢结构设计规范》(GB50017)进行修正，公式为Φb=1.07-0.282/Φb且≤1.0，计算得Φb '=" + Sum4Φb.ToString();
                        Sum4Φb = Sum4Φb2;
                    }
                    else 
                    {
                        Sum4Φb = Sum4Φb1;
                    }
                    Sum4σ1 = Sum4MA * Math.Pow(10, 6) / (Sum4Φb * wxParam * 1000);
                    if (Sum4σ1 < 205) { CompareΦbσ = " 水平钢梁的稳定性计算σ小于205.0N/mm2,满足要求!"; }
                    else if (Sum4σ1 == 205) { CompareΦbσ = "水平钢梁的稳定性计算σ等于205.0N/mm2,满足要求!"; }
                    else if (Sum4σ1 > 205) { CompareΦbσ = " 水平钢梁的稳定性计算σ大于205.0N/mm2,不满足要求!"; }
                    //十(锚固段与楼板连接计算)
                    Sum4σ2 = Sum4RB / (3.1416 * pc11_1 / 2 * pc11_1 / 2 * 2);
                    if (Sum4σ2 < 50) { CompareLhsl = " 拉环受拉应力σ小于50N/mm2,满足要求!"; }
                    else if (Sum4σ2 == 50) { CompareLhsl = "拉环受拉应力σ等于50N/mm2,满足要求!"; }
                    else if (Sum4σ2 > 50) { CompareLhsl = " 拉环受拉应力σ大于50N/mm2,不满足要求!"; }
                    Sum4Mgd = Sum4RB * 1000 / (3.1416 * pc11_1 * 1.5);
                    Sum4d = 5*dParam;
                    double[] fcArray=new double[]{9.6, 11.9, 14.3, 16.7, 19.1, 21.1, 23.1};
                    fc = fcArray[Cb_Item11LBHNTQD.SelectedIndex]; 
                    Sum4fc = 0.95 * fc;
                    Sum4Lsll = (bParam * bParam - Math.PI * dParam * dParam / 4) * Sum4fc;
                    if (Sum4RB <= Sum4Lsll) { CompareLsll = " 楼板混凝土局部承压计算满足要求!"; }
                    else { CompareLsll = "楼板混凝土局部承压计算不满足要求!"; }
                    #region 如果是悬挑脚手架,计算,八(型钢悬挑梁受力)、九(悬挑梁整体稳定性)、十(锚固段与楼板连接计算)数据转化
                    /*double Sum4N1 = 0, Sum4q1 = 0, Sum4k = 0, Sum4k1 = 0, Sum4k2 = 0, Sum4RA = 0, Sum4RB = 0, Sum4MA = 0, Sum4f = 0, Sum4N2 = 0, Sum4q2 = 0, Sum4Vmax = 0;//悬挑,八(型钢悬挑梁受力)
                     string CompareXgf="",CompareVmax = "";
                     double Sum4Φb1 = 0, Sum4Φb = 0, Sum4σ1 = 0, ζParam = 0, βbParam = 0, λyParam = 0, fy = 235, ηb = 0;//九(悬挑梁整体稳定性)
                     string strSum4Φb="", CompareΦbσ = "";
                     double Sum4σ2 = 0, Sum4Mgd = 0, Sum4d = 0, fc = 0, Sum4fc = 0, Sum4Lsll = 0;//十(锚固段与楼板连接计算)
                     
                    */
                    Sum4N1 = Convert.ToDouble(Sum4N1.ToString("f3"));
                    Sum4q1 = Convert.ToDouble(Sum4q1.ToString("f3"));
                    Sum4k = Convert.ToDouble(Sum4k.ToString("f3"));
                    Sum4k1 = Convert.ToDouble(Sum4k1.ToString("f3"));
                    Sum4k2 = Convert.ToDouble(Sum4k2.ToString("f3"));
                    Sum4RA = Convert.ToDouble(Sum4RA.ToString("f3"));
                    Sum4RB = Convert.ToDouble(Sum4RB.ToString("f3"));
                    Sum4MA = Convert.ToDouble(Sum4MA.ToString("f3"));
                    Sum4f = Convert.ToDouble(Sum4f.ToString("f3"));
                    Sum4N2 = Convert.ToDouble(Sum4N2.ToString("f3"));
                    Sum4q2 = Convert.ToDouble(Sum4q2.ToString("f3"));
                    Sum4Vmax = Convert.ToDouble(Sum4Vmax.ToString("f3"));
                    ζParam = Convert.ToDouble(ζParam.ToString("f3"));
                    λyParam = Convert.ToDouble(λyParam.ToString("f3"));
                    Sum4Φb1 = Convert.ToDouble(Sum4Φb1.ToString("f3"));
                    Sum4σ1 = Convert.ToDouble(Sum4σ1.ToString("f3"));
                    Sum4σ2 = Convert.ToDouble(Sum4σ2.ToString("f3"));
                    Sum4Mgd = Convert.ToDouble(Sum4Mgd.ToString("f3"));
                    Sum4d = Convert.ToDouble(Sum4d.ToString("f3"));
                    Sum4fc = Convert.ToDouble(Sum4fc.ToString("f3"));
                    Sum4Lsll = Convert.ToDouble(Sum4Lsll.ToString("f3"));
                   
                    #endregion
                }
                #endregion

                #region      1选择落地双排脚手架
                if (CbxScaffoldType.SelectedIndex == 0) //1选择落地双排脚手架
                {
                    if (Rdo_Item2DHG.Checked) //大横杆在上
                    {
                        itemtext = "双排大横杆在上";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,μz,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2δ,CompareD2δ, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2δ, CompareX2δ,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                    Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                    else if (Rdo_Item2XHG.Checked) //小横杆在上
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)//小横杆在上立杆纵距la2
                        {
                            itemtext = "双排小横杆在上立杆纵距la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)//小横杆在上立杆纵距la
                        {
                            itemtext = "双排小横杆在上立杆纵距la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,μz,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                        pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2δ, Sum2X3V1,Compare2X2δ,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2δ, Sum2D3V,Compare2D2δ,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                        Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                }
                #endregion

                #region       2选择型钢悬挑脚手架
                else if (CbxScaffoldType.SelectedIndex == 1) //2选择型钢悬挑脚手架
                {
                    if (Rdo_Item2DHG.Checked)
                    {
                        itemtext = "悬挑大横杆在上";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,μz,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                    pc10_1,pc10_2,pc10_3,pc10_4,pc10_5 ,
                                                    pc11_1,pc11_2,pc11_3,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2δ,CompareD2δ, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2δ, CompareX2δ,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                   weightParam, wxParam,Sum4N1, Sum4q1, Sum4k, Sum4k1, Sum4k2, Sum4RA, Sum4RB, Sum4MA, Sum4f, Sum4N2, Sum4q2, Sum4Vmax, CompareXgf, CompareVmax,
                                                   Sum4Φb1, Sum4Φb,Sum4σ1,strSum4Φb,CompareΦbσ,
                                                   Sum4σ2,Sum4Mgd,Sum4d, fc ,Sum4fc,Sum4Lsll ,CompareLhsl ,CompareLsll
                                                    };
                    }
                    if (Rdo_Item2XHG.Checked)
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)
                        {
                            itemtext = "悬挑小横杆在上立杆纵距la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)
                        {
                            itemtext = "悬挑小横杆在上立杆纵距la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,μz,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                        pc10_1,pc10_2,pc10_3,pc10_4,pc10_5 ,
                                                        pc11_1,pc11_2,pc11_3,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2δ, Sum2X3V1,Compare2X2δ,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2δ, Sum2D3V,Compare2D2δ,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                       weightParam, wxParam,Sum4N1, Sum4q1, Sum4k, Sum4k1, Sum4k2, Sum4RA, Sum4RB, Sum4MA, Sum4f, Sum4N2, Sum4q2, Sum4Vmax,CompareXgf, CompareVmax,
                                                        Sum4Φb1, Sum4Φb,Sum4σ1,strSum4Φb,CompareΦbσ,
                                                       Sum4σ2,Sum4Mgd,Sum4d, fc ,Sum4fc,Sum4Lsll ,CompareLhsl,CompareLsll
                                                        };
                    }
                }
                #endregion

                #region       3选择落地单排脚手架
                else if (CbxScaffoldType.SelectedIndex == 2) //3选择落地单排脚手架
                {
                    if (Rdo_Item2DHG.Checked)
                    {
                        itemtext = "单排大横杆在上";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,μz,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2δ,CompareD2δ, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2δ, CompareX2δ,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                    Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                    if (Rdo_Item2XHG.Checked)
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)
                        {
                            itemtext = "单排小横杆在上立杆纵距la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)
                        {
                            itemtext = "单排小横杆在上立杆纵距la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,μz,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,μs,
                                                        pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2δ, Sum2X3V1,Compare2X2δ,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2δ, Sum2D3V,Compare2D2δ,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, LgΦ, Sum1Noδ,CompareNoδ,Sum1Yesδ,CompareYesδ,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqjδ,CompareF1, Sum1NlΦA, LqjΦ,CompareF2,
                                                        Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                }
                #endregion
            }

            #region      4门式钢管脚手架
            else if (CbxScaffoldType.SelectedIndex == 3) //4门式钢管脚手架
            {
                //LX4tabItem1
                double  pc12_5, pc12_6, pc12_7, pc12_8, pc12_9;
                pc12_5 = System.Convert.ToDouble ( Tb_Lx4Item1BJ.Text) ; //门架步距
                pc12_6 = DbInput_Lx4Item1KJ.Value ; //门架跨距
                pc12_7 = DbInput_Lx4Item1GD.Value ; //脚手架搭设高度
                pc12_8 = DbInput_Lx4Item1D.Value ; //单扣件抗滑承载力
                pc12_9 = DbInput_Lx4Item1S.Value; //双扣件抗滑承载力
                μz = FengYaXiShu(pc12_7, Cb_Item7DMCCD.SelectedIndex);//μz：风压高度变化系数
                double k = 0;
                if (pc12_7 <= 30) { k = 1.13; }
                else if (30 < pc12_7 && pc12_7 <= 45) { k = 1.17; }
                else if (45 < pc12_7 && pc12_7 <= 55) { k = 1.22; }
                #region 设计要求文档中第一个表
                string[] MFItem = new string[] {"MF1219(1)", 	"MF1219(2)", "MF0817", "MF1017"};
                string MF = MFItem[mfID];
                int[] h0Item = new int[] {1930,1900,1750,1750};
                int h0 = h0Item[mfID];
                int[] h1Item = new int[] { 1536,1550, 1260,1291};
                int h1 = h1Item[mfID];
                int[] h2Item = new int[] { 80, 100, 0, 114 };
                int h2 = h2Item[mfID];
                int[] bItem = new int[] {1219, 1200, 758,1018 };
                int b = bItem[mfID];
                int[] b1Item = new int[] {750, 800, 510, 402};
                int b1 = b1Item[mfID];
                string[] r1Item = new string[] {"Φ42.0×2.5", "Φ48.0×3.5", "Φ42.0×2.5", "Φ42.0×2.5"};
                string  r1 = r1Item[mfID];
                string[] r2Item = new string[] { "Φ26.8×2.5", "Φ26.8×2.5", "Φ26.8×2.2", "Φ26.8×2.2" };
                string  r2 = r2Item[mfID];
                string[] r3Item = new string[] { "Φ42.0×2.5", "Φ48.0×3.5", "Φ42.0×2.5", "Φ42.0×2.5" };
                string  r3 = r3Item[mfID];
                string[] r4Item = new string[] { "Φ26.8×2.5", "Φ26.8×2.5", "Φ26.8×2.2", "Φ26.8×2.2" };
                string r4 = r4Item[mfID];
                double[]  i1Item = new double[] {1.525, 1.652, 1.514, 1.517};
                double  i1 = i1Item[mfID];
                double[] I2Item = new double[] {7.21, 13.37,  7.11, 7.13 };
                double I2 = I2Item[mfID];
                double[] AItem = new double[] {6.20,  9.78, 6.20, 6.20};
                double A = AItem[mfID];
                double[] A1Item = new double[] {3.10, 4.89 ,3.10, 3.10};
                double A1 = A1Item[mfID];
                #endregion
                //LX4tabItem2
                double  pc13_1, pc13_2, pc13_3, pc13_7, pc13_8;
                string pc13_4, pc13_5, pc13_6;
                pc13_1 = DbInput_Lx4Item2CD.Value; //连墙件计算长度
                pc13_2 = DbInput_Lx4Item2BJ.Value; //连墙件截面回转半径i(mm)
                pc13_3 = DbInput_Lx4Item2SX.Value ; //连墙件竖向间距
                pc13_4 = Cbx_Lx4Item2LJFS.Text; //连墙件连接方式
                pc13_5 = Rdo_Lx4Item2D.Text; //单扣件
                pc13_6 = Rdo_Lx4Item2S.Text; //双扣件
                pc13_7 = DbInput_Lx4Item2DJ.Value; //对接焊缝的抗拉、压强度
                pc13_8 = DbInput_Lx4Item2SP.Value; //连墙件水平间距
                //LX4tabItem3
                double pc14_1, pc14_2, pc14_5, pc14_6, pc14_8, pc14_9;
                string pc14_3, pc14_4, pc14_7;
                pc14_1 = IntInput_Lx4Item3JSB.Value; //脚手板搭设方式
                pc14_2 = IntInput_Lx4Item3SPJ.Value; //水平架搭设方式
                pc14_3 = Cbx_Lx4Item3JSB.Text; //脚手板类别
                pc14_4 = Cbx_Lx4Item3JGJ.Text; //加固件自重,窗体显示
                pc14_5 = DbInput_Lx4Item3AQW.Value; //安全网自重
                pc14_6 = DbInput_Lx4Item3HL.Value; //护栏自重
                pc14_7 = Cbx_Lx4Item3YT.Text; //脚手架用途
                pc14_8 = IntInput_Lx4Item3CS.Value; //同时施工层数
                pc14_9 = DbInput_Lx4Item3SG.Value; //施工活荷载标准值（kN/m2）
                double weightSPJ = 0.165 / pc14_2; //水平架重量
                double[] weightJSB1 = new double[] { 0.148, 0.168, 0.184, 0.195 };
                double weightJSB = (weightJSB1[Cbx_Lx4Item3JSB.SelectedIndex]) / pc14_1; //脚手板重量
                double[] pc14_1weight1 = new double[] { 0.06, 0.04 };
                double pc14_1weight2 = pc14_1weight1[Cbx_Lx4Item3JGJ.SelectedIndex]; //加固件自重，运行计算
                //LX4tabItem4
                string pc15_1, pc15_2, pc15_5;
                double pc15_3, pc15_4, pc15_6, pc15_7, pc15_8, pc15_9;
                pc15_1 = Rdo_Lx4Item4QF.Text ; //全封闭墙
                pc15_2 = Rdo_Lx4Item4CK.Text ; //敞开、框架和开洞墙
                pc15_3 = System.Convert.ToDouble(Tb_Lx4Item4YFMJ.Text); //迎风面积Aw
                pc15_4 = DbIput_Lx4Item4DFMJ.Value; //挡风面积An
                pc15_5 = Cb_Lx4Item4DJTLX.Text; //地基土类型
                pc15_6 = System.Convert.ToDouble ( Tb_Lx4Item4DJCZL.Text); //地基承载力标准值（N/mm2）
                pc15_7 = DbIput_Lx4Item4DBC.Value; //垫板长a
                pc15_8 = DbIput_Lx4Item4DBK.Value; //垫板宽b
                pc15_9 = DbInput_Lx4Item4TZXS.Value ;  //地基承载力调整系数
                if (Rdo_Lx4Item4QF.Checked) //选“全封闭墙”时，“μs”为：1.2An/Aw×1.0
                { 
                    μs = 1.2 * pc15_4 / pc15_3 * 1.0; 
                }
                else if (Rdo_Lx4Item4CK.Checked) //选“敞开、框架和开洞墙”时，“μs”为：1.2An/Aw×1.3
                { 
                    μs = 1.2 * pc15_4 / pc15_3 * 1.0; 
                }
                //计算过程
                //一、脚手架荷载标准值
                double NG1,NG2,NG,SumNQ,SumWk;
                NG1 = weightMF + 0.080 + weightJSB + 0.012 + 0.017 + weightSPJ; //脚手架结构自重总计重量
                NG2 = pc14_1weight2 + pc14_5 + pc14_6; //脚手架附件自重=加固件自重+安全网自重+护栏自重
                NG = NG1 + NG2;
                SumNQ = (pc12_6 / 1000) * (pc12_5 / 1000) * pc14_9; //活荷载标准值
                SumWk = μz * μs * pc6_4;
                //二、立杆的稳定性计算
                double SumN1, SumQk, SumN2, maxN, SumΦ1=0,SumNd;
                SumN1 = 1.2 * NG * pc12_7 + 1.4 * SumNQ; //作用于一榀门架的轴向力设计值计算公式(不组合风荷载)
                SumQk = SumWk * pc12_6;
                SumN2 = 1.2 * NG * pc12_7 + 0.9 * 1.4 * (SumNQ + 2 * SumQk * (pc13_3) * (pc13_3) / 10 / b);
                maxN = System.Math.Max(SumN1, SumN2);
                double λ1 = 0;
                if (mfID == 2) {λ1 = Math.Round((pc15_9 * h0) /(10* i1),0); }
                else {  λ1 = Math.Round((3 * pc15_9 * h0 ) / (10*i1), 0); }
                if (λ1 >250){ SumΦ1 =7320/(λ1*λ1); }
                else
                {
                    int λy1 = Convert.ToInt32(λ1 / 10);//第λy1行
                    int λx1 = Convert.ToInt32(λ1 % 10);// 第λx1列
                    SumΦ1 = λArray[λy1, λx1];
                }
                SumNd = SumΦ1 * A * 205/10;
                string ComparerNdN = ""; //立杆的稳定性
                if (maxN < SumNd)
                { ComparerNdN = "N < Nd，满足要求！";}
                else if (maxN > SumNd)
                {ComparerNdN = "N > Nd，不满足要求！";}
                //三、最大搭设高度的计算
                double SumHd,SumHdw,SumHs;
                SumHd = (SumNd - 1.4 * SumNQ) / (1.2 * NG);
                SumHdw = (SumNd - 0.85 * 1.4 * (SumNQ + 2 * SumQk * pc13_3 * 2 / 10 / b)) / (1.2 * NG);
                SumHs = System.Math.Min (SumHd ,SumHdw);
                string ComparerHsH = ""; //脚手架搭设高度的计算
                if (pc12_7 < SumHs)
                { ComparerHsH = "H≤HS，满足要求！";}
                else if (pc12_7 > SumHs)
                {ComparerHsH = "H>HS，不满足要求！"; }
                //五、立杆的地基承载力计算
                double SumA,SumP,SumFg;
                SumA = pc15_7 * pc15_8;
                SumP = maxN / SumA/1000;
                SumFg = pc15_9 * pc15_6;
                string ComparerFgP = ""; //立杆的地基承载力的计算 
                if (SumP <= SumFg){ ComparerFgP = "P≤fg ，满足要求！"; }
                else if (SumP > SumFg){ ComparerFgP = "P>fg ，满足要求！"; }
                #region 一 二 三 五 的数据转化
                NG1 = Convert.ToDouble(NG1.ToString("f3"));
                NG2 = Convert.ToDouble(NG2.ToString("f3"));
                NG = Convert.ToDouble(NG.ToString("f3"));
                SumNQ = Convert.ToDouble(SumNQ.ToString("f3"));
                SumWk = Convert.ToDouble(SumWk.ToString("f3"));
                SumN1 = Convert.ToDouble(SumN1.ToString("f3"));
                SumQk = Convert.ToDouble(SumQk.ToString("f3"));
                SumN2 = Convert.ToDouble(SumN2.ToString("f3"));
                maxN = Convert.ToDouble(maxN.ToString("f3"));
                SumΦ1 = Convert.ToDouble(SumΦ1.ToString("f3"));
                SumNd = Convert.ToDouble(SumNd.ToString("f3"));
                SumHd = Convert.ToDouble(SumHd.ToString("f3"));
                SumHdw = Convert.ToDouble(SumHdw.ToString("f3"));
                SumHs = Convert.ToDouble(SumHs.ToString("f3"));

                SumA = Convert.ToDouble(SumA.ToString("f3"));
                SumP = Convert.ToDouble(SumP.ToString("f3"));
                SumFg = Convert.ToDouble(SumFg.ToString("f3"));

                #endregion
                //四、连墙件的计算
                string ComparerLQJ = ""; //连墙件的计算
                double SumNw = 1.4 * SumWk * pc13_3 * pc13_8;
                double SumNc = SumNw + 3.0;
                #region 四 的数据转化
                

                SumNw = Convert.ToDouble(SumNw.ToString("f3"));
                SumNc = Convert.ToDouble(SumNc.ToString("f3"));
                #endregion
                if (Cbx_Lx4Item2LJFS.Text == "扣件连接")//如果选中扣件连接，得到一个obj
                {
                    itemtext = "门式钢管脚手架(扣件连接)";
                    double λ2 = pc13_1 / pc13_2;
                    double SumΦ2 = 0;
                    if (λ2 >= 250)
                    { SumΦ2 = 7320 / (λ2 * λ2); }
                    else
                    {
                        int λy2 = Convert.ToInt32(λ2 / 10);
                        int λx2 = Convert.ToInt32(λ2 % 10);
                        SumΦ2 = λArray[λy2, λx2];
                    }
                    double SumNf = 0.85 * SumΦ2 * A1 * 205/10;
                    SumNf = Convert.ToDouble(SumNf.ToString("f3"));

                    double Rc=0;
                    if (Rdo_Lx4Item2D.Checked) { Rc = pc12_8; }
                    else if (Rdo_Lx4Item2S.Checked) { Rc = pc12_9; }
                    if ((SumNc <= SumNf) && (SumNw <= Rc))
                    { ComparerLQJ = "Nc≤Nf  且 Nw≤Rc，满足要求！"; }
                    else if ((SumNc > SumNf) | (SumNw >= Rc))
                    { ComparerLQJ = "Nc>Nf  或 Nw≥Rc，不满足要求！"; }
                    obj = new object[] {k, MF, weightMF, h0, h1, h2, b, b1, r1, r2, r3, r4, i1, I2 , A, A1,
                                                        pc12_5,  pc12_6,  pc12_7,  pc12_5,  pc12_8,  pc12_9,
                                                        pc13_1, pc13_2, pc13_3, pc13_4, pc13_7,pc13_8, 
                                                         pc14_1, pc14_2, weightSPJ, pc14_3, weightJSB, NG1, pc14_4, pc14_5, pc14_6, NG2, NG,  pc14_7, pc14_8, pc14_9,
                                                         pc6_1, pc6_2, pc6_4, pc7_1, μz, 
                                                         μs, pc15_5, pc15_6, pc15_7, pc15_8, pc15_9,
                                                        SumNQ, SumN1 ,SumWk, SumQk, SumN2, maxN, SumΦ1, SumNd, ComparerNdN, 
                                                        SumHd, SumHdw, SumHs, ComparerHsH,
                                                         SumA, SumP, SumFg, ComparerFgP,
                                                         SumNw, SumNc,SumΦ2, SumNf, ComparerLQJ};

                }
                else if (Cbx_Lx4Item2LJFS.Text == "焊缝连接")//如果选中焊缝连接，得到一个obj
                {
                    itemtext = "门式钢管脚手架(焊缝连接)";
                    if ( SumNc <=pc13_7 ){ComparerLQJ = "Nc≤[ft]， 满足要求！";}
                    else if ( SumNc > pc13_7){ComparerLQJ = "Nc>[ft]，不满足要求！";}
                    obj = new object[] {k, MF, weightMF, h0, h1, h2, b, b1, r1, r2, r3, r4, i1, I2 , A, A1,
                                                        pc12_5,  pc12_6,  pc12_7,  pc12_5,  pc12_8,  pc12_9,
                                                        pc13_1, pc13_2, pc13_3, pc13_4, pc13_7,pc13_8, 
                                                         pc14_1, pc14_2, weightSPJ, pc14_3, weightJSB, NG1, pc14_4, pc14_5, pc14_6, NG2, NG,  pc14_7, pc14_8, pc14_9,
                                                         pc6_1, pc6_2, pc6_4, pc7_1, μz, 
                                                         μs, pc15_5, pc15_6, pc15_7, pc15_8, pc15_9,
                                                        SumNQ, SumN1 ,SumWk, SumQk, SumN2, maxN, SumΦ1, SumNd, ComparerNdN, 
                                                        SumHd, SumHdw, SumHs, ComparerHsH,
                                                         SumA, SumP, SumFg, ComparerFgP,
                                                         SumNw, SumNc, ComparerLQJ};
                }
               

            }
            
            #endregion

            #region  5碗扣式脚手架
            else if (CbxScaffoldType.SelectedIndex == 4) //5碗扣式脚手架
            {
                itemtext = "碗扣式脚手架";
                double[] Gkzg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//立杆纵距
                double Gkzg = Gkzg1[Cbx_Lx5Item1ZJ.SelectedIndex];
                double[] Gkhg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//立杆横距
                double Gkhg = Gkhg1[Cbx_Lx5Item1HJ.SelectedIndex];
                double[] Gkjhg1 = new double[] { 0.0437, 0.0552, 0.0685, 0.0816 };//间横杆钢管类型
                double Gkjhg = Gkjhg1[Cbx_Lx5Item1JHG.SelectedIndex];
                double[] Gkl1 = new double[] { 0.0705, 0.1019, 0.1334, 0.1648 };//立杆钢管类型
                double Gkl = Gkl1[Cbx_Lx5Item1LGG.SelectedIndex];
                double[] Gkl2 = new double[] { 1.2, 1.8, 2.4, 3.0 };//根据立杆类型选择,得到荷载计算中数值
                double Gkl3 = Gkl1[Cbx_Lx5Item1LGG.SelectedIndex];
                double[] Gkwg1 = new double[] { 0.0633, 0.0703, 0.0866, 0.0930, 0.1004 };//外斜杆钢管类型
                double Gkwg = Gkwg1[Cbx_Lx5Item1WXG.SelectedIndex];
                double[] Gksg1 = new double[] { 0.0589, 0.0676, 0.0873 };//水平斜杆钢管类型
                double Gksg = Gksg1[Cbx_Lx5Item1SPX.SelectedIndex];
                double[] Gklg1 = new double[] { 0.0633, 0.0703, 0.0866, 0.0930, 0.1004 };//廊道斜杆钢管类型
                double Gklg = Gklg1[Cbx_Lx5Item1LDX.SelectedIndex];
                //一、横向横杆的计算:
                double sum10Hq1, sum10Hq2, sum10HMmax, sum10Hσ, sum10HVmax, sum10HVmin;
                string compareHσ = "", compareHVmaxVmin = "", compareHτdb = "";
                sum10Hq1 = 1.2 * (Gkhg / pc16_4 + 0.35 * pc16_3 / (pc16_10 + 1)) + 1.4 * pc5_3 * pc16_3 / (pc16_10 + 1);
                sum10Hq2 = Gkhg / pc16_4 + 0.350 * pc16_3 / (pc16_10 + 1) + pc5_3 * pc16_3 / (pc16_10 + 1);
                sum10HMmax = sum10Hq1 * Math.Pow(pc16_4, 2) / 8;
                sum10Hσ = sum10HMmax * Math.Pow(10, 6) / 5080;
                if (sum10Hσ <= 205) { compareHσ = "满足要求！"; }
                else { compareHσ = "不满足要求！"; }
                sum10HVmax = (5 * sum10Hq2 * Math.Pow(pc16_4 * 1000, 4) / (384 * 205 * 1219))/100000;
                sum10HVmin = Math.Min(pc16_4*1000/150,10);
                if (sum10HVmax <= sum10HVmin)
                { compareHVmaxVmin = "满足要求！"; }
                else
                { compareHVmaxVmin = "不满足要求！"; }
                double sum10HR1 = sum10Hq1 * pc16_4 / 2;
                double sum10HR2 = sum10Hq2 * pc16_4 / 2;
                double sum10Hτdb = sum10Hq1 * pc16_4 / 2;
                if (sum10Hτdb <= 25)
                { compareHτdb = "满足要求！"; }
                else
                { compareHτdb = "不满足要求！"; }
                #region 一 数据转化
                sum10Hq1 = Convert.ToDouble(sum10Hq1.ToString("f3"));
                sum10Hq2 = Convert.ToDouble(sum10Hq2.ToString("f3"));
                sum10HMmax = Convert.ToDouble(sum10HMmax.ToString("f3"));
                sum10Hσ = Convert.ToDouble(sum10Hσ.ToString("f3"));
                sum10HVmax = Convert.ToDouble(sum10HVmax.ToString("f3"));
                sum10HVmin = Convert.ToDouble(sum10HVmin.ToString("f3"));

                #endregion
                //二、间横杆计算
                double sum10Jq1, sum10Jq2, sum10JMmax, sum10Jσ, sum10JVmax, sum10JVmin, sum10JR1, sum10JR2, sum10Jτdb;
                string compareJσ="",compareJVmaxVmin="",compareJτdb="";
                sum10Jq1=1.2*(Gkjhg/pc16_4+0.350*pc16_3/(pc16_10+1))+1.4*pc5_3*pc16_3/(pc16_10+1);
                sum10Jq2=Gkjhg/pc16_4+0.350*pc16_3/(pc16_10+1)+pc5_3*pc16_3/(pc16_10+1);
                sum10JMmax = sum10Jq1 * Math.Pow(pc16_4, 2) / 8;
                sum10Jσ = sum10JMmax * 1000000 / 5080;
                if (sum10Jσ <= 205)
                { compareJσ = "满足要求！"; }
                else
                { compareJσ = "不满足要求！"; }
                sum10JVmax = (5 * sum10Jq2 * Math.Pow((pc16_4 * 1000), 4) / (384 * 205 * 1219))/100000;
                sum10JVmin = Math.Min(pc16_4*1000/150,10);
                if (sum10JVmax <= sum10JVmin)
                { compareJVmaxVmin = "满足要求！"; }
                else
                { compareJVmaxVmin = "不满足要求！"; }
                sum10JR1 = sum10Jq1 * pc16_4 / 2;
                sum10JR2 = sum10Jq2 * pc16_4 / 2;
                sum10Jτdb = sum10JR1;
                if (sum10Jτdb <= 25)
                { compareJτdb = "满足要求！"; }
                else
                { compareJτdb = "不满足要求！"; }
                #region 二 数据转化
                sum10Jq1 = Convert.ToDouble(sum10Jq1.ToString("f3"));
                sum10Jq2 = Convert.ToDouble(sum10Jq2.ToString("f3"));
                sum10JMmax = Convert.ToDouble(sum10JMmax.ToString("f3"));
                sum10Jσ = Convert.ToDouble(sum10Jσ.ToString("f3"));
                sum10JVmax = Convert.ToDouble(sum10JVmax.ToString("f3"));
                sum10JVmin = Convert.ToDouble(sum10JVmin.ToString("f3"));
                sum10JR1 = Convert.ToDouble(sum10JR1.ToString("f3"));
                sum10JR2 = Convert.ToDouble(sum10JR2.ToString("f3"));
                sum10Jτdb = Convert.ToDouble(sum10Jτdb.ToString("f3"));


                #endregion
                //三、纵向横杆计算
                double sum10Zq1, sum10Zq2, sum10Zτdb1=0, sum10Zτdb2=0;
                string str10Zσ = "", str10Zτdb1 = "", compareZσ = "", compareZτdb1 = "", compareZτdb2 = "";
                sum10Zq1 = 1.2 * Gkzg / pc16_3;
                sum10Zq2 = Gkzg / pc16_3;
                if (Cbx_Lx5Item1DKJ.Text=="2")
                {
                    double temp = (0.858 * pc16_3 / 3 + sum10Zq1 * Math.Pow(pc16_3, 2) / 4 - sum10Zq1 * pc16_3/8)*1000000/5080;//
                    str10Zσ = "Mmax/W= F1×la /3+q×la 2/4- q×la /8= " + "0.858×" + pc16_3.ToString() + "/3+" + sum10Zq1.ToString() + "×" + pc16_3.ToString() + "2/4-" + sum10Zq1.ToString() + "×" + pc16_3.ToString() + "/8×1000000/5080=" + temp.ToString() + "N/mm2≤[f]=205N/mm2";
                    if (temp <= 205)
                    { compareZσ = "满足要求！"; }
                    else
                    { compareZσ = "不满足要求！"; }
                    sum10Zτdb1 = 0.858 + sum10Zq1 * pc16_3 / 2;
                    if (sum10Zτdb1 <= 25)
                    { compareZτdb1 = "满足要求！"; }
                    else
                    { compareZτdb1 = "不满足要求！"; }


                    str10Zτdb1 = "F1+ q×la /2= 0.858+ " + sum10Zq1.ToString()+ "×"+pc16_3.ToString()+"/2="+sum10Zτdb1.ToString()+"kN≤[τ]=25kN";
                    sum10Zτdb2 = 2 * sum10Zτdb1 + sum10Hτdb;
                    if (sum10Zτdb2 <= 60)
                    { compareZτdb2 = "满足要求！"; }
                    else
                    { compareZτdb2 = "不满足要求！"; }
                }
                else if (Cbx_Lx5Item1DKJ.Text == "1")
                {
                    double temp = (0.858 * pc16_3 / 4 + sum10Zq1 * Math.Pow(pc16_3, 2) / 4)*1000000/5080;//
                    if (temp <= 205)
                    { compareZσ = "满足要求！"; }
                    else
                    { compareZσ = "不满足要求！"; }
                    str10Zσ = "Mmax/W= F1×la /4+q×la 2/4= " + "0.858×" + pc16_3.ToString() + "/4+" + sum10Zq1.ToString() + "×" + pc16_3.ToString() + "2/4×1000000/5080=" + temp.ToString() + "N/mm2≤[f]=205N/mm2";
                    sum10Zτdb1 = 0.858/2 + sum10Zq1 * pc16_3 / 2;
                    if (sum10Zτdb1 <= 25)
                    { compareZτdb1 = "满足要求！"; }
                    else
                    { compareZτdb1 = "不满足要求！"; }
                    str10Zτdb1 = "F1/2+ q×la /2= 0.858/2+ " + sum10Zq1.ToString() + "×" + pc16_3.ToString() + "/2=" + sum10Zτdb1.ToString() + "kN≤[τ]=25kN";
                    sum10Zτdb2 = 2 * sum10Zτdb1 + sum10Hτdb;
                    if (sum10Zτdb2 <= 60)
                    { compareZτdb2 = "满足要求！"; }
                    else
                    { compareZτdb2 = "不满足要求！"; }
                }
                #region 三 数据转化
                sum10Zq1 = Convert.ToDouble(sum10Zq1.ToString("f3"));
                sum10Zq2 = Convert.ToDouble(sum10Zq2.ToString("f3"));
                sum10Zτdb1 = Convert.ToDouble(sum10Zτdb1.ToString("f3"));
                sum10Zτdb2 = Convert.ToDouble(sum10Zτdb2.ToString("f3"));
                #endregion
                //四、荷载计算
                double NG1k1, NG1k2, NG1k3, NG1k4, NG1k5, NG1k6, NG1k7, sum10NG1k;
                double NG2k1, NG2k2, NG2k3, sum10NG2k;
                double NQ1k, sum10Nw1, sum10Nw2, sum10N1, sum10N2, sum10Wk;
                NG1k1 = pc16_2 * Gkl / Gkl3;
                NG1k2 = Gkzg * (pc16_2 / pc16_1 + 1);
                NG1k3 = Gkhg * (pc16_2 / pc16_1 + 1) / 2;
                NG1k4 = Gkwg * (pc16_2 / pc16_1 + 1) / pc16_11;
                NG1k5 = (pc16_2 / pc16_1 + 1) * Gksg / pc16_12 / 2;
                NG1k6 = (pc16_2 / pc16_1 + 1) * pc16_10 * Gkjhg / 2;
                NG1k7 = (pc16_2 / pc16_1 + 1) * Gklg / pc16_13 / 2;
                sum10NG1k = NG1k1 + NG1k2 + NG1k3 + NG1k4 + NG1k5 + NG1k6 + NG1k7;
                //
                NG2k1 = pc5_4 * pc16_3 * pc16_4 * 0.35 / 2;
                NG2k2 = pc5_4 * pc16_3 * 0.14;
                NG2k3 = 0.01 * pc16_3 * pc16_2;
                sum10NG2k = NG2k1 + NG2k2 + NG2k3;
                //
                NQ1k = pc16_3 * pc16_4 * pc5_2 * pc5_3 / 2;
                sum10Nw1 = 1.2 * (sum10NG1k + sum10NG2k) + 0.9 * 1.4 * NQ1k;
                sum10Nw2 = 1.2 * (sum10NG1k + NG2k1) + 0.9 * 1.4 * NQ1k;
                sum10N1 = 1.2 * (sum10NG1k + sum10NG2k) + 1.4 * NQ1k;
                sum10N2 = 1.2 * (sum10NG1k + NG2k1) + 1.4 * NQ1k;
                //
                μz = FengYaXiShu(DbInput_Lx5Item2GD.Value, Cb_Item7DMCCD.SelectedIndex);//风压高度变化系数
                sum10Wk = 0.7 * pc6_4 * μz * DbInput_Item6Uz.Value;
                #region 四 数据转化
                /* double NG1k1, NG1k2, NG1k3, NG1k4, NG1k5, NG1k6, NG1k7, sum10NG1k;
                double NG2k1, NG2k2, NG2k3, sum10NG2k;
                double NQ1k, sum10Nw1, sum10Nw2, sum10N1, sum10N2, sum10Wk;
                 */
                NG1k1 = Convert.ToDouble(NG1k1.ToString("f3"));
                NG1k2 = Convert.ToDouble(NG1k2.ToString("f3"));
                NG1k3 = Convert.ToDouble(NG1k3.ToString("f3"));
                NG1k4 = Convert.ToDouble(NG1k4.ToString("f3"));
                NG1k5 = Convert.ToDouble(NG1k5.ToString("f3"));
                NG1k6 = Convert.ToDouble(NG1k6.ToString("f3"));
                NG1k7 = Convert.ToDouble(NG1k7.ToString("f3"));
                sum10NG1k = Convert.ToDouble(sum10NG1k.ToString("f3"));
                NG2k1 = Convert.ToDouble(NG2k1.ToString("f3"));
                NG2k2 = Convert.ToDouble(NG2k2.ToString("f3"));
                NG2k3 = Convert.ToDouble(NG2k3.ToString("f3"));
                sum10NG2k = Convert.ToDouble(sum10NG2k.ToString("f3"));
                NQ1k = Convert.ToDouble(NQ1k.ToString("f3"));
                sum10Nw1 = Convert.ToDouble(sum10Nw1.ToString("f3"));
                sum10Nw2 = Convert.ToDouble(sum10Nw2.ToString("f3"));
                sum10N1 = Convert.ToDouble(sum10N1.ToString("f3"));
                sum10N2 = Convert.ToDouble(sum10N2.ToString("f3"));
                sum10Wk = Convert.ToDouble(sum10Wk.ToString("f3"));
                
                #endregion
                //五不考虑风荷载时,立杆的稳定性计算
                string strWkλ = "", compareWKNoσ = "";
                double pcWk = 0, Wkλ = 0, WkNoφ = 0, sum10Noσ=0;
                if (Cbx_Lx5Item1LGJXG.SelectedIndex == 0)//立杆间有斜杆
                {
                    //l0取步距；长细比λ=l0/i=步距(@pc16_1@)×1000/15.800=113.924 （@Wkλ@）
                    strWkλ="步距h";
                    pcWk = pc16_1;
                    Wkλ = pcWk * 1000 / 15.800;
                }
                else if (Cbx_Lx5Item1LGJXG.SelectedIndex == 1)//立杆间无斜杆
                {
                    strWkλ = "连墙件竖向间距";
                    pcWk = pc16_1;
                    Wkλ = pcWk * 1000 / 15.800;
                }
                if (Wkλ > 250)
                {
                    WkNoφ = 7320 / (Wkλ * Wkλ);
                }
                else
                {
                    int Wkλy1 = Convert.ToInt32(Wkλ / 10);//第λy1行
                    int Wkλx1 = Convert.ToInt32(Wkλ % 10);// 第λx1列
                    WkNoφ = λArray[Wkλy1, Wkλx1]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                sum10Noσ = sum10N1 / (WkNoφ * 4.89);
                if (sum10Noσ <= 205)
                { compareWKNoσ = "满足要求！"; }
                else
                { compareWKNoσ = "不满足要求！"; }
                #region 五 数据转化
                Wkλ = Convert.ToDouble(Wkλ.ToString("f3"));
                WkNoφ = Convert.ToDouble(WkNoφ.ToString("f3"));
                sum10Noσ = Convert.ToDouble(sum10Noσ.ToString("f3"));
                

                #endregion
                //五考虑风荷载时,立杆的稳定性计算
                double sum10Mw , sum10NE,sum10Yesσ;
                string compareWKYesσ = "";
                sum10Mw = 1.4 * sum10Wk * pc16_3 * Math.Pow(pcWk, 2) / 10;
                sum10NE = 3.14162 * 205 * 489 / Math.Pow(Wkλ, 2);
                sum10Yesσ = sum10Nw1 / (WkNoφ * 4.89) + (0.9 * 1.0 * sum10Mw) / (1.15 * 5.08 * (1 - 0.8 * sum10Nw1 / sum10NE));
                if (sum10Yesσ <= 205)
                { compareWKYesσ = "满足要求！"; }
                else
                { compareWKYesσ = "不满足要求！"; }
                #region 五 数据转化
                sum10Mw = Convert.ToDouble(sum10Mw.ToString("f3"));
                sum10NE = Convert.ToDouble(sum10NE.ToString("f3"));
                sum10Yesσ = Convert.ToDouble(sum10Yesσ.ToString("f3"));

                #endregion
                //六、连墙件承载力计算
                double sum10Nc, wkLqjφ, sum10NcN0Ac;
                string strNcN0Ac = "", compareNcN0Ac = "", strNcN0="",compareNcN0 ="";
                sum10Nc = 1.4 * sum10Wk * pc17_1 * pc17_2;
                double wkLqjλ = pc17_3 * pc17_4;
                if (wkLqjλ > 250)
                {
                    wkLqjφ = 7320 / (Wkλ * Wkλ);
                }
                else
                {
                    int wkLqjλy1 = Convert.ToInt32(wkLqjλ / 10);//第λy1行
                    int wkLqjλx1 = Convert.ToInt32(wkLqjλ % 10);// 第λx1列
                    wkLqjφ = λArray[wkLqjλy1, wkLqjλx1]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                sum10NcN0Ac = (sum10Nc + 3) * 1000 / (wkLqjφ * pc17_5);
                if (Cbx_Lx5Item2LQJ.SelectedIndex == 0)
                {
                    strNcN0Ac = "[f]=205";
                    if (sum10NcN0Ac <= 205) { compareNcN0Ac = "满足要求！"; }
                    else { compareNcN0Ac = "不满足要求！"; }
                    double  sum10NcN0,wkXs;
                    int kjChoice =0;
                    if(Rdo_Lx5Item2D.Checked ){kjChoice =8;}
                    else if(Rdo_Lx5Item2D.Checked ) {kjChoice =12;}
                    sum10NcN0 = sum10Nc+3;
                    wkXs = pc17_9 * kjChoice;
                    if (sum10NcN0 <= wkXs) { compareNcN0 = "满足要求！"; }
                    else {compareNcN0 = "满足要求！";}
                    strNcN0 = "扣件抗滑承载力验算:Nc+N0=" + sum10NcN0.ToString() + " kN≤" + pc17_9.ToString() + "×" + kjChoice.ToString()+ "="+wkXs.ToString()+"kN";
                }
                else if (Cbx_Lx5Item2LQJ.SelectedIndex == 1)
                {
                    strNcN0Ac = "[ft]=对接焊缝的抗拉、压强度" + pc17_10.ToString();
                    if (sum10NcN0Ac <= pc17_10) { compareNcN0Ac = "满足要求！"; }
                    else { compareNcN0Ac = "不满足要求！"; }
                }
                else if (Cbx_Lx5Item2LQJ.SelectedIndex == 2)
                {
                    strNcN0Ac = "[fy]=拉接钢筋的抗拉强度" + pc17_11.ToString();
                    if (sum10NcN0Ac <= pc17_11) { compareNcN0Ac = "满足要求！"; }
                    else { compareNcN0Ac = "不满足要求！"; }
                }
                #region 六 数据转化
                sum10Nc = Convert.ToDouble(sum10Nc.ToString("f3"));
                wkLqjφ = Convert.ToDouble(wkLqjφ.ToString("f3"));
                sum10NcN0Ac = Convert.ToDouble(sum10NcN0Ac.ToString("f3"));
                wkLqjλ = Convert.ToDouble(wkLqjλ.ToString("f3"));
                //sum10NcN0 = Convert.ToDouble(sum10NcN0.ToString("f3"));
                //wkXs = Convert.ToDouble(wkXs.ToString("f3"));

                #endregion
                //七、脚手架搭设高度验算:
                double   sum10h ;
                string compareSum10h="";
                sum10h = sum10Nw1-1.2* sum10NG2k -0.9*1.4* NQ1k* pc16_2/1.2/ sum10NG1k;
                sum10h = Convert.ToDouble(sum10h.ToString("f3"));
                if (sum10h > pc16_2)
                { compareSum10h = "满足要求！"; }
                else
                { compareSum10h = "不满足要求！"; }
                //八、可调底座承载力验算:
                string  compareNN0="";
                if (sum10N1 <= pc16_14)
                { compareNN0 = "满足要求！"; }
                else
                { compareNN0 = "不满足要求！"; }
                //九、立杆的地基承载力验算:
                double sum10Ag,sum10fg;
                string compareWkfg="";
                sum10Ag= pc9_3* pc16_3;
                sum10fg= pc9_2* pc9_5;
                sum10Ag = Convert.ToDouble(sum10Ag.ToString("f3"));
                sum10fg = Convert.ToDouble(sum10fg.ToString("f3"));
                if ((sum10N1 / sum10Ag) <= sum10fg)
                { compareWkfg = "满足要求！"; }
                else
                { compareWkfg = "不满足要求！"; }
                obj = new object[] {pc5_1,pc5_2,pc5_3,pc5_4,
                                    pc6_1,pc6_2,pc6_4, DbInput_Item6Uz.Value,pc7_1,μz,
                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,Cb_Item9DJLX.Text,
                                    pc16_1,  pc16_2,  pc16_3,  pc16_4,  pc16_5,  pc16_6,  pc16_7,  pc16_8,  pc16_9,  pc16_10,  pc16_11,  pc16_12,  pc16_13,  pc16_14,  pc16_15,  pc16_1, 
                                    pc17_1, pc17_2, pc17_3, pc17_4, pc17_5, pc17_6,  pc17_9, pc17_10, pc17_11, 
                                    Gkzg, Gkhg, Gkjhg, Gkl,Gkl3, Gkwg, Gksg, Gklg,
                                    sum10Hq1, sum10Hq2, sum10HMmax, sum10Hσ, sum10HVmax, sum10HVmin,compareHσ, compareHVmaxVmin, compareHτdb,sum10HR1,sum10HR2,sum10Hτdb,
                                    sum10Jq1, sum10Jq2, sum10JMmax, sum10Jσ, sum10JVmax, sum10JVmin, sum10JR1, sum10JR2, sum10Jτdb,compareJσ,compareJVmaxVmin,compareJτdb,
                                    sum10Zq1, sum10Zq2, sum10Zτdb1, sum10Zτdb2,str10Zσ, str10Zτdb1, compareZσ, compareZτdb1, compareZτdb2 ,
                                    NG1k1, NG1k2, NG1k3, NG1k4, NG1k5, NG1k6, NG1k7, sum10NG1k,NG2k1, NG2k2, NG2k3, sum10NG2k,NQ1k, sum10Nw1, sum10Nw2, sum10N1, sum10N2, sum10Wk,
                                    pcWk, Wkλ, WkNoφ, sum10Noσ, sum10Mw , sum10NE,sum10Yesσ,strWkλ, compareWKNoσ, compareWKYesσ,
                                    sum10Nc, wkLqjφ, sum10NcN0Ac, wkLqjλ,strNcN0Ac, compareNcN0Ac, strNcN0,compareNcN0,
                                    sum10h ,compareSum10h,
                                    compareNN0,
                                    sum10Ag,sum10fg,compareWkfg};
            }
            #endregion
            #endregion

            foreach (Framework.Entity.Template template in templateList)
            {
                if (itemtext == template.Title)
                {
                    item = template;
                    break;
                }
            }
            CreateModuleIntance(item, null, @class, obj);
            this.Close();
        }

        private void Cbx_Lx4Item2LJFS_SelectedIndexChanged(object sender, EventArgs e)//4连墙件LX4tabItem2—连墙件连接方式
        {
            if (Cbx_Lx4Item2LJFS.SelectedIndex == 0)
            {
                Grp_Lx4Item2KJ.Enabled = true;
                Grp_Lx4Item2HF.Enabled = false;
            }
            else if (Cbx_Lx4Item2LJFS.SelectedIndex == 1)
            {
                Grp_Lx4Item2HF.Enabled = true ;
                Grp_Lx4Item2KJ.Enabled = false ;
            }
        }

        #region  LX4tabItem2门架重量（标准值）
        private void Rdo_Lx4Item1MF1_CheckedChanged(object sender, EventArgs e)//4连墙件LX4tabItem2—MF1219(1)
        {
            if (Rdo_Lx4Item1MF1.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1980 ";
                weightMF = 0.116F;
                mfID = 0;
            }
        }
        private void Rdo_Lx4Item1MF2_CheckedChanged(object sender, EventArgs e)//4连墙件LX4tabItem2—MF1219(2)
        {
            if (Rdo_Lx4Item1MF2.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1950 ";
                weightMF = 0.142F;
                mfID = 1;
            }
        }
        private void Rdo_Lx4Item1MF3_CheckedChanged(object sender, EventArgs e)//4连墙件LX4tabItem2—MF0817
        {
            if (Rdo_Lx4Item1MF3.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1800 ";
                weightMF = 0.087F;
                mfID = 2;
            }
        }
        private void Rdo_Lx4Item1MF4_CheckedChanged(object sender, EventArgs e)//4连墙件LX4tabItem2—MF1017
        {
            if (Rdo_Lx4Item1MF4.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1800 ";
                weightMF = 0.094F;
                mfID = 3;
            }
        }
        #endregion

        private void Cb_Lx4Item4DJTLX_SelectedIndexChanged(object sender, EventArgs e) //4风荷载体型系数+地基承载力—LX4tabItem4
        {
            switch (Cb_Lx4Item4DJTLX.SelectedIndex)
            {
                case 0: Tb_Lx4Item4DJCZL.Text = "200"; break; //岩石
                case 1: Tb_Lx4Item4DJCZL.Text = "200"; break; //碎石土
                case 2: Tb_Lx4Item4DJCZL.Text = "140";  break; // 砂土
                case 3: Tb_Lx4Item4DJCZL.Text = "100"; break; //粉土
                case 4: Tb_Lx4Item4DJCZL.Text = "80"; break; //素填土
                case 5: Tb_Lx4Item4DJCZL.Text = "120"; break; //红粘土
                case 6: Tb_Lx4Item4DJCZL.Text = "120"; break; //粘性土
                case 7: Tb_Lx4Item4DJCZL.Text = "60"; break; //淤泥质土
            }
        }

        private void Btn_Lx4Item4Search1_Click(object sender, EventArgs e) //LX4tabItem4中地基承载力中第一个“查询图表”按钮
        {
            FrmShowChart showchart = new FrmShowChart(Cb_Lx4Item4DJTLX.SelectedIndex);
            showchart.ShowDialog();
        }

        private void Btn_Lx4Item4Search2_Click(object sender, EventArgs e) //LX4tabItem4中地基承载力中第一个“查询图表”按钮
        {
            FrmShowChart showchart = new FrmShowChart(9);
            showchart.ShowDialog();
        }

        private void Btn_Item9SearchChart_Click(object sender, EventArgs e)//LXtabItem9中地基承载力中第一个“查询图表”按钮
        {
            FrmShowChart showchart = new FrmShowChart(Cb_Item9DJTLX.SelectedIndex );
            showchart.ShowDialog();
        }
        
        private void DbIput_Item8DFMJ_ValueChanged(object sender, EventArgs e)
        {
            double dangfengxishu=1.2 * DbIput_Item8DFMJ.Value/100;
            Tb_Item8DFXS1.Text = dangfengxishu.ToString();
        }

        private void LXtabItem4_Click(object sender, EventArgs e)
        {
            #region 每米立杆自重标准值,调用函数ErweiShuzu()
            double[,] gksArray = new double[,] { { 0.1538, 0.1667, 0.1796, 0.1882, 0.1925 }, 
                                                                        { 0.1426, 0.1543, 0.1660, 0.1739, 0.1778}, 
                                                                        {0.1336, 0.1444, 0.1552, 0.1324, 0.1660 }, 
                                                                        { 0.1202, 0.1295, 0.1389, 0.1451, 0.1482}, 
                                                                        {0.1134, 0.1221, 0.1307, 0.1365, 0.1394} };//双排数组
            double[,] gkdArray = new double[,] { { 0.1642,0.1793,0.1945,0.2046,0.2097 }, 
                                                                        { 0.1530, 0.1670,	0.1809 ,0.1903, 0.1949 }, 
                                                                        {0.1440,0.1570,0.1701,0.1788 ,0.1831 }, 
                                                                        { 0.1305,0.1422 ,0.1538,	0.1615 ,0.1654 }, 
                                                                        {0.1238 ,0.1347 ,0.1456,	0.1529 ,0.1565 } };//单排数组
            double[] bjArray = new double[] { 1.20, 1.35, 1.50, 1.80, 2.00 };
            double[] zjArray = new double[] { 1.2, 1.5, 1.8, 2.0, 2.1 };
            double gk = 0;//每米立杆自重标准值
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//双排脚手架
            { gk = ErweiShuzu(gksArray, zjArray, bjArray, DbInput_Item1LGZJ.Value, DbInput_Item1BJ.Value); }
            else if (CbxScaffoldType.SelectedIndex == 2)//单排脚手架
            { gk = ErweiShuzu(gkdArray, zjArray, bjArray, DbInput_Item1LGZJ.Value, DbInput_Item1BJ.Value); }
            Tb_Item4GK.Text = gk.ToString();
            #endregion 
        }

        private void Cb_Item5YT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxScaffoldType.SelectedIndex == 4)
            {
                if (Cb_Item5YT.SelectedIndex == 0)
                {
                    DbInput_Item5HZBZ.Value = 2;
                }
                else
                    DbInput_Item5HZBZ.Value = 3;
            }
        }

        private void Cbx_Lx5Item2LQJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cbx_Lx5Item2LQJ.SelectedIndex)
            {
                case 0: 
                    Grp_Lx5Item2KJ.Enabled = true;
                    Grp_Lx5Item2HF.Enabled = Grp_Lx5Item2RL.Enabled = false;
                    break;
                case 1:
                    Grp_Lx5Item2HF.Enabled = true;
                    Grp_Lx5Item2KJ.Enabled = Grp_Lx5Item2RL.Enabled = false;
                    break;
                case 2:
                    Grp_Lx5Item2RL.Enabled = true;
                    Grp_Lx5Item2KJ.Enabled = Grp_Lx5Item2HF.Enabled = false;
                    break;
            }
        }

        private void Cb_Item4JSBLB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (Cb_Item4JSBLB.SelectedIndex)
            {
                case 0: Tb_Item4JSBZZBZZ.Text = "0.3"; break; //冲压脚手板
                case 1: Tb_Item4JSBZZBZZ.Text = "0.35"; break; //竹串脚手板
                case 2: Tb_Item4JSBZZBZZ.Text = "0.35"; break; // 木脚手板
                case 3: Tb_Item4JSBZZBZZ.Text = "0.10"; break; //竹芭脚手板
                
            }
        }

        private void Cb_Item4JBLB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (Cb_Item4JBLB.SelectedIndex)
            {
                case 0: Tb_Item4JBZZBZZ.Text = "0.16"; break; //冲压脚手板
                case 1: Tb_Item4JBZZBZZ.Text = "0.17"; break; //竹串脚手板
                case 2: Tb_Item4JBZZBZZ.Text = "0.17"; break; // 木脚手板
               
            }

        }


    }
}

