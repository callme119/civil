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

        #region  ���ּ���ѧ���㴰������ӵ�һЩ�ؼ��¼�
            private void CbxScaffoldType_SelectedIndexChanged(object sender, EventArgs e) //���ּ���ѧ���㴰����ҳ
            {
                if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 2)//��˫�Ž��ּ�
                {
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem8.Visible = LXtabItem9.Visible = true;
                    LXtabItem10.Visible = LXtabItem11.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cb_Item5YT.Items.Clear();
                    Cb_Item5YT.Items.Add("װ��ʩ�����ּ�"); Cb_Item5YT.Items.Add("�ṹʩ�����ּ�"); Cb_Item5YT.Items.Add("������;���ּ�");
                    Cb_Item9DJLX.Items.Clear();
                    Cb_Item9DJLX.Items.Add("��Ȼ�ػ�"); Cb_Item9DJLX.Items.Add("�������ػ�");
                    Cb_Item9DJTLX.SelectedIndex = Cb_Item9DJLX.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cb_Item3JJ.SelectedIndex =Cb_Item3FS.SelectedIndex = 0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = false;
                    DbInput_Item5HZBZ.Enabled = true;
                }
                else if (CbxScaffoldType.SelectedIndex == 1)//�͸��������ּ�
                {
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem8.Visible = LXtabItem10.Visible = LXtabItem11.Visible = true;
                    LXtabItem9.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cb_Item3JJ.SelectedIndex = Cb_Item3FS.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cb_Item10GLXH.SelectedIndex = Cb_Item10RXND.SelectedIndex = Cb_Item11ULSZJ.SelectedIndex = Cb_Item11LBHNTQD.SelectedIndex = 0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = false;
                }
                else if (CbxScaffoldType.SelectedIndex == 3)//��ʽ���ּ�
                {
                    LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = LXtabItem6.Visible = true;
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem5.Visible =  LXtabItem8.Visible = LXtabItem9.Visible = LXtabItem10.Visible = LXtabItem11.Visible = LX5tabItem1.Visible = LX5tabItem2.Visible = false;
                    Cbx_Lx4Item3JSB.SelectedIndex = Cb_Lx4Item4DJTLX.SelectedIndex = Cbx_Lx4Item3JGJ.SelectedIndex = Cb_Item7DMCCD.SelectedIndex = Cbx_Lx4Item2LJFS.SelectedIndex = Cbx_Lx4Item3YT.SelectedIndex  =0;//����һЩcomboBox��Ĭ��index=0
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = false ;
                }
                else if (CbxScaffoldType.SelectedIndex == 4)//���ʽ���ּ�
                {
                    LX5tabItem1.Visible = LX5tabItem2.Visible = LXtabItem5.Visible = LXtabItem6.Visible = LXtabItem9.Visible = true;
                    LXtabItem1.Visible = LXtabItem2.Visible = LXtabItem3.Visible = LXtabItem4.Visible = LXtabItem8.Visible = LXtabItem10.Visible = LXtabItem11.Visible = LX4tabItem1.Visible = LX4tabItem2.Visible = LX4tabItem3.Visible = LX4tabItem4.Visible = false;
                    Cb_Item9DJLX.Items.Clear();
                    Cb_Item9DJLX.Items.Add("��Ȼ�ػ�"); Cb_Item9DJLX.Items.Add("�������ػ�"); Cb_Item9DJLX.Items.Add("��ʯ���ػ�"); Cb_Item9DJLX.Items.Add("ɰ���ػ�"); Cb_Item9DJLX.Items.Add("ճ���ػ�");
                    Cb_Item7DMCCD.SelectedIndex = Cb_Item9DJLX.SelectedIndex =0;
                    Cb_Item5YT.Items.Clear();
                    Cb_Item5YT.Items.Add("װ��ʩ�����ּ�"); Cb_Item5YT.Items.Add("�ṹʩ�����ּ�");
                    Cbx_Lx5Item1ZJ.SelectedIndex = Cbx_Lx5Item1HJ.SelectedIndex = Cbx_Lx5Item1JHG.SelectedIndex = Cbx_Lx5Item1LGG.SelectedIndex = Cbx_Lx5Item1WXG.SelectedIndex = Cbx_Lx5Item1SPX.SelectedIndex = Cbx_Lx5Item1LDX.SelectedIndex = Cbx_Lx5Item1DKJ.SelectedIndex = Cbx_Lx5Item1WXGBZ.SelectedIndex = Cbx_Lx5Item1LGJXG.SelectedIndex = Cbx_Lx5Item2LQJ.SelectedIndex  =0;
                    Lb_Item6Uz.Visible = DbInput_Item6Uz.Visible = true;
                    Lb_Item5PSCS.Visible = IntInput_Item5PSCS.Visible = true;
                    DbInput_Item5HZBZ.Enabled = false;
                    
                }
            }

            private void Cb_Item10RXND_SelectedIndexChanged(object sender, EventArgs e) //Item10 �͸��������ּ�
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

            private void Rdo_Item2XHG_CheckedChanged(object sender, EventArgs e) //Item2��С��˲���
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

            private void Cb_Item2LGZJ_SelectedIndexChanged(object sender, EventArgs e)//Item2С�������С��˼��仯
            {
                if (Cb_Item2LGZJ.SelectedIndex == 0)
                {
                    Tb_Item2XHGJJ.Text = "2";
                }
                else
                    Tb_Item2XHGJJ.Text = "1";
            }
        
            private void Cb_Item3FS_SelectedIndexChanged(object sender, EventArgs e) //Item3��ǽ������
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

            private void Cb_Item4JSBLB_SelectedIndexChanged(object sender, EventArgs e)//Item4���ú��ز���,���ְ����
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

            private void Cb_Item4JBLB_SelectedIndexChanged(object sender, EventArgs e) //Item4���ú��ز���,���˵��Ű����
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
                if (Chk_Item6Self.Checked) //���ѡ�и�ѡ���������û��Լ���д��ѹ�����򲻿������ѹ
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
     
             #region   // Item8���������ϵ��
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
       
        private void Cb_Item9DJTLX_SelectedIndexChanged(object sender, EventArgs e)//Item9���˵ػ�������
            {
                switch (Cb_Item9DJTLX.SelectedIndex)
                {
                    case 0: Tb_Item9DJCZL.Text = "200"; break; //��ʯ
                    case 1: Tb_Item9DJCZL.Text = "200"; break; //��ʯ��
                    case 2: Tb_Item9DJCZL.Text = "140"; break; // ɰ��
                    case 3: Tb_Item9DJCZL.Text = "100"; break; //����
                    case 4: Tb_Item9DJCZL.Text = "80"; break; //������
                    case 5: Tb_Item9DJCZL.Text = "120"; break; //��ճ��
                    case 6: Tb_Item9DJCZL.Text = "120"; break; //ճ����
                    case 7: Tb_Item9DJCZL.Text = "60"; break; //��������
                }
            }

            private void tabItem9_Click(object sender, EventArgs e)
            {
                Tb_Item9ZYCD.Text = DbInput_Item1LGZJ.Text;//tabItem9�¡����ó��ȡ����ݡ������ݾࡱ��ȷ��
            }

            #region  //Item6����ز�������ʡ�ݵ���ȷ��������ѹ
            private string[] neimenggu1 = new string[] { "����&0.30" };
            private string[] neimenggu2 = new string[] { "�����&0.30", "����&0.40" };
            private string[] neimenggu3 = new string[] { "�Ϻ�&0.40" };
            private string[] neimenggu4 = new string[] { "����&0.25" };
            private string[] neimenggu5 = new string[] { "ʯ��ׯ��&0.25", "ε��&0.20", "��̨��&0.20 ", "����&0.30", "Χ��&0.35", "�żҿ���&0.35", "����& 0.25", " �е���& 0.30", " ��& 0.30", " ����&0.25 ", " �ػʵ���&0.35", "����&0.25", "��ɽ��&0.30", "��ͤ&0.30", "������&0.30", "����&0.30", "������&0.30", "����&0.30", "�Ϲ���&0.25" };
            private string[] neimenggu6 = new string[] { "̫ԭ��&0.30", "��ͬ��&0.35", "����&0.30", "��կ&0.30", "����&0.25", "ԭƽ&0.30", "��ʯ&0.30", "��Ȫ��&0.30", "����&0.20", "����&0.25", "����&0.25", "�ٷ���&0.25", "������&0.30", "�˳���&0.30", "����&0.30" };
            private string[] neimenggu7 = new string[] { "���ͺ�����&0.35", "��������������&0.35", "����ʯ��ͼ���&0.30", "��������&0.50", "��������&0.45", "���״�С����&0.30", "�°Ͷ�������&0.45", "�°Ͷ������찢ľ����&0.40", "����ʯ�в���ͼ&0.40", "��������&0.30", "������ǰ�찢��ɽ&0.35", "������ǰ������&0.45", "����������&0.40", "������������&0.35", "�������&0.40", "���������Ӻ�&0.45", "���������ë��&0.40", "����������&0.45", "����������&0.55", "���ʱ�����&0.40", "��ï��������&0.50", "���͸���&0.35", "����������&0.40", "���������캣����&0.45", "�������������պ�&0.50", "���������캣��ͼ&0.45", "������&0.50", "��������&0.40", "����&0.45", "���޺����°�&0.30", "��ͷ��&0.35", "������&0.40", "���������켪��̩&0.35", "�ٺ���&0.30", "���п���&0.35", "��ʤ��&0.30", "����ϯ��&0.40", "�������&0.40", "������������&0.45", "��³��³��&0.40", "���������ֶ�&0.40", "���ֺ�����&0.40", "����&0.45", "��³&0.40", "ͨ����&0.40", "����&0.40", "�����&0.30", "�����챦��ͼ&0.40" };
            private string[] neimenggu8 = new string[] { "������&0.40", "����&0.35", "������&0.40", "��ԭ&0.30", "��ԭ&0.25", "������&0.40", "��ƽ��Ҷ����&0.30", "��ɽ&0.45", "������&0.40", "��ɽ��&0.30", "��Ϫ��&0.35", "��˳���µ�&0.30", "����&0.25", "����&0.25", "�˳���&0.35", "Ӫ����&0.40", "��������&0.30", "��Ϫ�زݺӿ�&0.25", "���&0.30", "���&0.30", "������&0.35", "�߷�����&0.35", "�½���Ƥ��&0.35", "ׯ��&0.35", "������&0.40" };
            private string[] neimenggu9 = new string[] { "������&0.45", "�׳���&0.45", "Ǭ��&0.35", "ǰ������˹&0.30", "ͨ��&0.35", "����&0.30", "�����������&0.35", "˫��&0.35", "��ƽ��&0.40", "��ʯ����Ͳɽ&0.30", "������&0.40", "�Ժ�&0.30", "�ػ���&0.30", "÷�ӿ���&0.30", "���&0.30", "����&0.25", "�����ض���&0.30", "�Ӽ���&0.35", "ͨ����&0.30", "�뽭���ٽ�&0.20", "������&0.20", "����&0.35" };
            private string[] neimenggu10 = new string[] { "��������&0.35", "Į��&0.25", "����&0.25", "����&0.25", "����&0.30", "�Ӹ����&0.25", "�ں���&0.35", "�۽�&0.40", "����&0.40", "������&0.30", "��ɽ&0.30", "��ԣ&0.30", "���������&0.35", "����&0.35", "��ˮ&0.35", "������&0.25", "�׸���&0.30", "����&0.30", "̩��&0.30", "�绯��&0.35", "������&0.35", "����&0.25", "��ľ˹��&0.40", "����&0.45", "����&0.30", "ͨ��&0.35", "��־&0.35", "������&0.40", "����&0.35", "ĵ������&0.35", "��Һ���&0.40" };
            private string[] neimenggu11 = new string[] { "������&0.30", "������&0.30", "����&0.40", "�ٹ�����ǹ�&0.30", "������&0.45", "��̨��&0.40", "������&0.45", "�ٳ��г�ɽͷ&0.60", "ݷ�س���&0.35", "̩����̩ɽ&0.65", "̩����&0.30", "�Ͳ����ŵ�&0.30", "��Դ&0.30", "Ϋ����&0.30", "������&0.30", "�ൺ��&0.45", "����&0.40", "�ٳ���ʯ��&0.40", "������&0.25", "����&0.25", "����&0.25", "����&0.30", "������&0.30" };
            private string[] neimenggu12 = new string[] { "�Ͼ���&0.25", "������&0.25", "����&0.30", "����&0.25", "������&0.25", "����&0.30", "��&0.30", "����&0.30", "̩��&0.25", "�����&0.35", "�γ�&0.25", "����&0.25", "��̨��&0.30", "��ͨ��&0.25", "����&0.25", "���ض�ɽ&0.30" };
            private string[] neimenggu13 = new string[] { "������&0.30", "�ٰ�����Ŀɽ&0.55", "ƽ����է��&0.35", "��Ϫ��&0.30", "����&0.85", "��������ɽ&0.95", "��ɽ��&0.50", "����&0.25", "����&0.25", "������&0.30", "��ɽ��ʯ��&0.75", "����&0.25", "��ˮ��&0.20", "��Ȫ&0.20", "�ٺ�������ɽ&0.60", "������&0.35", "�����к��&0.35", "�������´��&0.90", "���ؿ���&0.70", "���б���&0.95" };
            private string[] neimenggu14 = new string[] { "�Ϸ�&0.25", "�ɽ&0.25", "������&0.25", "����&0.25", "����&0.25", "������&0.25", "����&0.25", "������&0.20", "��ɽ&0.20", "����&0.25", "������&0.25", "����&0.25", "������&0.25", "��ɽ&0.50", "��ɽ��&0.25" };
            private string[] neimenggu15 = new string[] { "�ϲ���&0.30", "��ˮ&0.20", "�˴���&0.20", "����&0.25", "����&0.20", "�촨&0.20", "������&0.20", "�Ž�&0.25", "®ɽ&0.40", "����&0.25", "��������&0.25", "������&0.20", "��Ϫ&0.20", "��ɽ&0.20", "�ϳ�&0.25", "���&0.20", "Ѱ��&0.25" };
            private string[] neimenggu16 = new string[] { "������&0.40", "������&0.20", "Ǧɽ������ɽ&0.55", "�ֳ�&0.20", "����&0.25", "���&0.25", "����&0.35", "̩��&0.20", "��ƽ��&0.20", "������̨ɽ&0.75", "��͡&0.20", "�Ϻ�&0.25", "������&0.25", "������&0.20", "�»��ؾ���ɽ&0.60", "����&0.20", "ƽ̶&0.75", "����&0.55", "������&0.55", "��ɽ&0.80" };
            private string[] neimenggu17 = new string[] { "������&0.25", "������&0.25", "����&0.25", "��ɽ&0.30", "���&0.3", "�Ӱ���&0.25", "����&0.20", "�崨&0.25", "ͭ����&0.20", "������&0.20", "�书&0.20", "�����ػ�ɽ&0.40", "����&0.25", "������&0.20", "��ƺ&0.25", "������&0.25", "��&0.20", "ʯȪ&0.20", "������&0.30" };
            private string[] neimenggu18 = new string[] { "������&0.20", "���µ�&0.45", "����&0.40", "��Ȫ��&0.40", "��Ҵ��&0.30", "������&0.35", "����&0.40", "������&0.35", "��̩&0.25", "��Զ&0.20", "������&0.20", "���&0.20", "������&0.30", "����&0.20", "ƽ����&0.25", "������&0.20", "����&0.25", "�ĺ��غ���&0.25", "�䶼&0.25", "��ˮ��&0.20" };
            private string[] neimenggu19 = new string[] { "������&0.40", "��ũ&0.45", "����&0.30", "����&0.30", "�γ�&0.30", "��Դ&0.25", "ͬ��&0.20", "��ԭ&0.25", "����&0.20" };
            private string[] neimenggu20 = new string[] { "������&0.25", "ã��&0.30", "���&0.40", "����������&0.30", "������Ұţ��&0.30", "����&0.30", "���ľ��С���&0.30", "���&0.30", "�������&0.25", "�ղ�&0.25", "��Դ&0.25", "���ľ��&0.30", "�����ز迨&0.25", "������ǡ��ǡ&0.25", "���&0.25", "���&0.20", "�ƹ���ɽ�����&0.35", "�˺�&0.25", "ͬ��&0.25", "���&0.25", "���ľ�����к�&0.40", "�ζ�&0.25", "�Ӷ�&0.25", "�����&0.25", "����&0.20", "���&0.30", "�ƶ�����ˮ��&0.25", "��������Ͽķ&0.30", "�����ؼ���&0.25", "����&0.25", "����&0.20", "����&0.20" };
            private string[] neimenggu21 = new string[] { "��³ľ����&0.40", "��̩����&0.40", "�����а���ɽ��&0.95", "����������&0.65", "������&0.40", "����&0.25", "��³ľ���ش���&0.55", "�;��ذ�����³��&0.25", "��³����&0.50", "��������&0.30", "�⳵&0.35", "�������&0.30", "��ǡ&0.25", "��ʲ��&0.35", "������&0.25", "Ƥɽ&0.20", "����&0.25", "���&0.20", "����ذ��ĺ�&0.20", "����&0.20", "����&0.40" };
            private string[] neimenggu22 = new string[] { "֣����&0.30", "������&0.25", "������&0.30", "����Ͽ��&0.25", "¬��&0.20", "�Ͻ�&0.30", "������&0.25", "�ﴨ&0.20", "�����&0.30", "������&0.30", "��Ͽ&0.25", "������&0.25", "����&0.25", "����&0.25", "פ�����&0.25", "������&0.25", "������&0.20", "��ʼ&0.20" };
            private string[] neimenggu23 = new string[] { "�人��&0.25", "����&0.20", "����&0.20", "�Ϻӿ���&0.20", "������&0.25", "�Ͷ�&0.15", "����&0.20", "�����&0.20", "��ʩ��&0.20", "�Ͷ����̴���&0.30", "�����&0.20", "�˲���&0.20", "�����ؾ���&0.20", "������&0.20", "����&0.20", "����&0.20", "Ӣɽ&0.20", "��ʯ��&0.25" };
            private string[] neimenggu24 = new string[] { "��ɳ��&0.25", "ɣֲ&0.20", "ʯ��&0.25", "����&0.25", "������&0.25", "������&0.20", "����&0.20", "������&0.25", "����&0.20", "�佭��&0.25", "ƽ��&0.20", "�ƽ�&0.20", "������&0.20", "˫��&0.20", "����&0.60", "ͨ��&0.25", "���&0.20", "������&0.25", "������&0.25", "����&0.25", "������&0.20" };
            private string[] neimenggu25 = new string[] { "������&0.30", "����&0.20", "����&0.20", "�ع�&0.20", "���&0.20", "��ƽ&0.20", "÷��&0.20", "����&0.20", "��Ҫ&0.30", "��Դ&0.20", "����&0.35", "�廪&0.20", "��ͷ��&0.50", "����&0.45", "�ϰ�&0.50", "����&0.35", "�޶�&0.20", "̨ɽ&0.35", "������&0.45", "��β&0.50", "տ����&0.50", "����&0.45", "���&0.45", "̨ɽ���ϴ���&0.75", "����&0.45" };
            private string[] neimenggu26 = new string[] { "������&0.25", "������&0.20", "������&0.20", "��ɽ&0.20", "��ɽ&0.20", "��ɫ��&0.25", "����&0.20", "��ƽ&0.20", "������&0.20", "����&0.20", "��ɽ&0.20", "����&0.20", "����&0.45", "������&0.45", "��ݵ�&0.70" };
            private string[] neimenggu27 = new string[] { "������&0.45", "����&0.55", "����&0.40", "����&0.30", "��&0.50", "������&0.50", "��ˮ&0.50", "��ɳ��&1.05", "ɺ����&0.70" };
            private string[] neimenggu28 = new string[] { "�ɶ���&0.20", "ʯ��&0.25", "������&0.25", "����&0.35", "��������&0.20", "������&0.20", "�Ű���&0.20", "����&0.20", "����&0.30", "��Դ&0.20", "����&0.20", "Խ��&0.25", "�Ѿ�&0.25", "�ײ�&0.20", "�˱���&0.20", "��Դ&0.20", "������&0.20", "����&0.20", "��Դ&0.20", "����&0.20", "����&0.20", "������&0.20", "���&0.25", "������&0.20", "�ϳ���&0.20", "��ƽ&0.20", "������&0.15", "�ڽ���&0.25", "������&0.20", "������&0.20", "����&0.20" };
            private string[] neimenggu29 = new string[] { "������&0.20", "����&0.25", "����&0.25", "ͩ��&0.20", "ϰˮ&0.20", "�Ͻ�&0.20", "������&0.20", "��̶&", "˼��&0.20", "ͭ��&0.20", "��˳��&0.20", "������&0.20", "����&0.20", "�޵�&0.20" };
            private string[] neimenggu30 = new string[] { "������&0.20", "����&0.25", "��ɽ&0.20", "�е�&0.20", "ά��&0.20", "��ͨ��&0.25", "����&0.25", "��ƺ&0.25", "����&0.25", "�ڳ�&0.20", "��ˮ&0.20", "��ɽ��&0.20", "������&0.45", "Ԫı&0.25", "������&0.20", "������մ��&0.25", "����&0.20", "����&0.20", "��Ϫ&0.20", "����&0.25", "����&0.25", "�϶�&0.25", "�ٲ�&0.20", "����&0.20", "����&0.20", "˼é&0.25", "Ԫ��&0.25", "����&0.20", "����&0.20", "����&0.25", "����&0.20", "��ɽ&0.20", "����&0.25" };
            private string[] neimenggu31 = new string[] { "������&0.20", "���&0.35", "����&0.45", "����&0.30", "�տ�����&0.20", "�˶�����&0.20", "¡��&0.30", "����&0.25", "����&0.20", "��֥&0.25" };
            private string[] neimenggu32 = new string[] { "̨��&0.40", "����&0.50", "����&1.10", "̨��&0.50", "����&0.40", "����&0.50", "��&0.85", "̨��&0.65", "��ɽ&0.55", "�㴺&0.70", "����ɽ&0.25", "̨��&0.60" };
            private string[] neimenggu33 = new string[] { "���&0.80", "������&0.95" };
            private string[] neimenggu34 = new string[] { "����&0.75" };

            private void Cb_Item6SF_SelectedIndexChanged(object sender, EventArgs e)
            {//Item6��ʡ��ȷ�������¼�
                Cb_Item6DQ.Items.Clear();
                Cb_Item6DQ.Text = "";
                Tb_Item6SFDQFY.Text = "";
                string[] province = new string[] { };
                switch (Cb_Item6SF.SelectedItem.ToString())
                {
                    case "����": province = neimenggu1; break;
                    case "���": province = neimenggu2; break;
                    case "�Ϻ�": province = neimenggu3; break;
                    case "����": province = neimenggu4; break;
                    case "�ӱ�": province = neimenggu5; break;
                    case "ɽ��": province = neimenggu6; break;
                    case "���ɹ�": province = neimenggu7; break;
                    case "����": province = neimenggu8; break;
                    case "����": province = neimenggu9; break;
                    case "������": province = neimenggu10; break;
                    case "ɽ��": province = neimenggu11; break;
                    case "����": province = neimenggu12; break;
                    case "�㽭": province = neimenggu13; break;
                    case "����": province = neimenggu14; break;
                    case "����": province = neimenggu15; break;
                    case "����": province = neimenggu16; break;
                    case "����": province = neimenggu17; break;
                    case "����": province = neimenggu18; break;
                    case "����": province = neimenggu19; break;
                    case "�ຣ": province = neimenggu20; break;
                    case "�½�": province = neimenggu21; break;
                    case "����": province = neimenggu22; break;
                    case "����": province = neimenggu23; break;
                    case "����": province = neimenggu24; break;
                    case "�㶫": province = neimenggu25; break;
                    case "����": province = neimenggu26; break;
                    case "����": province = neimenggu27; break;
                    case "�Ĵ�": province = neimenggu28; break;
                    case "����": province = neimenggu29; break;
                    case "����": province = neimenggu30; break;
                    case "����": province = neimenggu31; break;
                    case "̨��": province = neimenggu32; break;
                    case "���": province = neimenggu33; break;
                    case "����": province = neimenggu34; break;

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
            {//Item6�е���ȷ�������¼�
                string[] province = new string[] { };
                switch (Cb_Item6SF.SelectedItem.ToString())
                {
                    case "����": province = neimenggu1; break;
                    case "���": province = neimenggu2; break;
                    case "�Ϻ�": province = neimenggu3; break;
                    case "����": province = neimenggu4; break;
                    case "�ӱ�": province = neimenggu5; break;
                    case "ɽ��": province = neimenggu6; break;
                    case "���ɹ�": province = neimenggu7; break;
                    case "����": province = neimenggu8; break;
                    case "����": province = neimenggu9; break;
                    case "������": province = neimenggu10; break;
                    case "ɽ��": province = neimenggu11; break;
                    case "����": province = neimenggu12; break;
                    case "�㽭": province = neimenggu13; break;
                    case "����": province = neimenggu14; break;
                    case "����": province = neimenggu15; break;
                    case "����": province = neimenggu16; break;
                    case "����": province = neimenggu17; break;
                    case "����": province = neimenggu18; break;
                    case "����": province = neimenggu19; break;
                    case "�ຣ": province = neimenggu20; break;
                    case "�½�": province = neimenggu21; break;
                    case "����": province = neimenggu22; break;
                    case "����": province = neimenggu23; break;
                    case "����": province = neimenggu24; break;
                    case "�㶫": province = neimenggu25; break;
                    case "����": province = neimenggu26; break;
                    case "����": province = neimenggu27; break;
                    case "�Ĵ�": province = neimenggu28; break;
                    case "����": province = neimenggu29; break;
                    case "����": province = neimenggu30; break;
                    case "����": province = neimenggu31; break;
                    case "̨��": province = neimenggu32; break;
                    case "���": province = neimenggu33; break;
                    case "����": province = neimenggu34; break;
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
        /// ��ѹ�߶ȱ仯ϵ����z,һά�����ڲ�
        /// </summary>
        /// <param name="height">���ּܴ���߶�</param>
        /// <param name="roughness">����ֲڶ�</param>
         /// <returns>��ѹ�߶ȱ仯ϵ����z</returns>
        private double FengYaXiShu(double height, int roughness)
        {
            #region ��ѹ�߶ȱ仯ϵ����z ,������
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
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0, ��z = 0;
            if (height >= 450)
            { ��z = 3.12;  }
            else if (height >= 5 && height < 450)
            {
                for (i = 0; i < 19; i++)
                {//�жϱ����Ƿ��ж�Ӧ��ֵ
                    if (height == heightArray[i])//����У���ֱ�Ӷ�ȡ
                    {
                        ��z = uzArray[i, j];
                        break;
                    }
                    else if (height < heightArray[i]) //���û�У������������ڲ幫ʽ����
                    {
                        x1 = heightArray[i - 1];
                        x2 = heightArray[i];
                        y1 = uzArray[i - 1, j];
                        y2 = uzArray[i, j];
                        ��z = (y2 - y1) * (height - x1) / (x2 - x1) + y1; // ��ѹ�߶ȱ仯ϵ����z,�ɡ����ּܴ���߶ȡ��͡�����ֲڶȡ��ó�.��Ϊ�ݶ�ֵ���Ժ����޸�
                        break;
                    }
                }
            }
            return ��z;
              #endregion
        }

        /// <summary>
        /// �ڲ壬���ά����ֵ
        /// </summary>
        /// <param name="valueArray">��ȥ��һ�к͵�һ�к���ж�Ӧ��ֵ����ά���飩</param>
        /// <param name="xArray">���е�һ��������ֵ��һά���飩</param>
        /// <param name="yArray">���е�һ��������ֵ��һά���飩</param>
        /// <param name="x">�û�����ģ���һ�����ڲ����ֵ����ֵ��</param>
        /// <param name="y">�û�����ģ���һ�����ڲ����ֵ����ֵ��</param>
        /// <returns>�ڲ���</returns>
        private double ErweiShuzu(double[,] valueArray, double[] xArray,double[] yArray,double x,double y )
        {
            double value1_1, value1_2, value2_1, value2_2;
            double x1, x2;
            double y1, y2;
            double valueReturn=0;
            for (int i = 0; i < yArray.Length; i++)
            {
                if (y== yArray[i])//����в���
                {
                    for (int j = 0; j < xArray.Length; j++)
                    {//���жϱ�����Ƿ��ж�Ӧ���ݾ�ֵ
                        if (x == xArray[j])//������ݾ�
                        {
                            valueReturn=valueArray[i, j];
                        }
                        else if (x < xArray[j])//���û���ݾ�
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
                else if (y < yArray[i])//���û�в���
                {
                    y1 = yArray[i - 1];//С����
                    y2 = yArray[i];//�󲽾�
                    for (int j = 0; j < xArray.Length; j++)
                    {
                        if (x == xArray[j])//����в���
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
      /// ���㳤��ϵ��u,һά�����ڲ�
        /// </summary>
        /// <param name="hengJv">���˺��</param>
        /// <param name="LqjSet">��ǽ������</param>
        /// <returns>���㳤��ϵ��u</returns>
        private double YiweiShuzu(double hengJv,int LqjSet) 
        {
            #region ���˼��㳤��ϵ��u ,������
            double[,] uArray = new double[,] { {1.50, 1.70}, {1.55, 1.75} ,{1.60, 1.80},{1.80, 2.0} };
            double[] hengJvArray = new double[] { 1.05, 1.30, 1.55};
            int ui = 0;
            int uj = LqjSet;
            double ux1 = 0, ux2 = 0, uy1 = 0, uy2 = 0, LgU = 0;
            if(CbxScaffoldType.SelectedIndex ==2)//���Ž��ּ�
            {
                LgU = uArray[3,uj ];
            }
            else if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)// ˫���������ּ�
            {  
                for (ui = 0; ui < 3; ui++)
                {//�жϱ����Ƿ��ж�Ӧ�����˺��ֵ
                    if (hengJv == hengJvArray[ui])//����У���ֱ�Ӷ�ȡ
                    {
                        LgU = uArray[ui, uj];
                        break;
                    }
                    else if (hengJv < hengJvArray[ui]) //���û�У������������ڲ幫ʽ����
                    {
                        ux1 = hengJvArray[ui - 1];
                        ux2 = hengJvArray[ui];
                        uy1 = uArray[ui - 1, uj];
                        uy2 = uArray[ui, uj];
                        LgU = (uy2 - uy1) * (hengJv - ux1) / (ux2 - ux1) + uy1; // ��ѹ�߶ȱ仯ϵ����z,�ɡ����ּܴ���߶ȡ��͡�����ֲڶȡ��ó�.��Ϊ�ݶ�ֵ���Ժ����޸�
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
            #region ȫ�ֱ���
            #region LXtabItem6,������ּܶ��õ�
            double pc6_3=0, pc6_4=0;
            string pc6_1 = "", pc6_2 = "", pc7_1 = "";
            pc6_1 = Cb_Item6SF.Text;  //ʡ��
            pc6_2 = Cb_Item6DQ.Text; //����
            pc6_3 = System.Convert.ToDouble(Tb_Item6SFDQFY.Text); //�õ�����ѹ�ǣ�kN/m2��
            if (Chk_Item6Self.Checked) //���û���ѡ�˴��������ʱ�����û�����Ļ�����ѹֵ����;
            {
                pc6_4 = DbInput_Item6SelfJBFY.Value; //������ѹWo��kN/m2��
                Lb_Item6SelfJBFY.Enabled = true;
                DbInput_Item6SelfJBFY.Enabled = true;
            }
            else //����ѡ�򰴡�ʡ�ݡ���������ѡ���ó��ķ�ѹֵ���㡣
            {
                pc6_4 = pc6_3;
                Lb_Item6SelfJBFY.Enabled = false;
                DbInput_Item6SelfJBFY.Enabled = false;
            }
            pc7_1 = Cb_Item7DMCCD.Text; //����ֲڶ�
            double ��z = 0;//��ѹ�߶ȱ仯ϵ��
            #endregion
             #region ��B.0.6������ѹ�������ȶ�ϵ����(Q235��)
                double[,] ��Array = new double[,] {  {	1	,	0.997	,	0.995	,	0.992	,	0.989	,	0.987	,	0.984	,	0.981	,	0.979	,	0.976	},
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
            #region ���ֹ��ô����������
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
            double gk = 0;//ÿ���������ر�׼ֵ
            //LXtabItem8
            string pc8_1 = "", pc8_2 = "", pc8_3 = "";
            double  pc8_5 = 0, pc8_12 = 0, pc8_13 = 0 ;
            double ��s = 0; //���������ϵ����s
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
            #region ǰ���������ʽ���õ�
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1 || CbxScaffoldType.SelectedIndex == 2 || CbxScaffoldType.SelectedIndex == 4)
            {
                //LXtabItem5
                pc5_1 = Cb_Item5YT.Text;//���ּ���;
                pc5_2 = IntInput_Item5SGCS.Value;//ͬʱʩ������
                pc5_3 = DbInput_Item5HZBZ.Value;//ʩ������ر�׼ֵ
                pc5_4 = IntInput_Item5PSCS.Value;//���ְ塢���ˡ����Ű��������,���ʽר��
            }
            #endregion
            #region ǰ����������
            if (CbxScaffoldType.SelectedIndex == 0||CbxScaffoldType.SelectedIndex == 1||CbxScaffoldType.SelectedIndex == 2)
            {
                //LXtabItem1
                pc1_1 = DbInput_Item1LGZJ.Value; //�����ݾ�
                pc1_2 = DbInput_Item1LGHJ.Value;//���˺��
                pc1_3 = DbInput_Item1BJ.Value;//���˲���
                pc1_4 = DbInput_Item1DSGD.Value;//���ּܴ���߶�
                pc1_5 = DbInput_Item1LQJL.Value;//���ּ����ŵ���ǽ����
                pc1_6 = DbInput_Item1XHGWSCD.Value;//С��˼������쳤��
                pc1_7 = DbInput_Item1DKJ.Value;//���ۼ�����������
                pc1_8 = DbInput_Item1SKJ.Value;//˫�ۼ�����������
                pc1_9 = Convert.ToDouble(Tb_Item1BH.Text);//�ں�
                pc1_10 = Convert.ToDouble(Tb_Item1GGWJ.Text);//�ֹ��⾶
                //LXtabItem2
                pc2_2 = Rdo_Item2DHG.Text;
                pc2_7 = Convert.ToDouble(Cb_Item2DHGGS.Text);
                pc2_1 = Rdo_Item2XHG.Text;
                pc2_4 = Cb_Item2LGZJ.Text;
                pc2_5 = Convert.ToDouble(Tb_Item2XHGJJ.Text);
                //LXtabItem3
                pc3_1 = Cb_Item3JJ.Text; //��ǽ�����
                pc3_2 = Cb_Item3FS.Text; //��ǽ����ʽ
                pc3_3 = DbInput_Item3ZXL.Value;//��ǽ��Լ�����ּ�ƽ��������
                //LXtabItem4
                pc4_1 = Cb_Item4JSBLB.Text;//���ְ����
                pc4_2 =Convert.ToDouble( Tb_Item4JSBZZBZZ.Text);//���ְ����ر�׼ֵ
                pc4_3 = Cb_Item4JBLB.Text;//���ˡ����Ű����
                pc4_4 =Convert.ToDouble( Tb_Item4JBZZBZZ.Text);//���ˡ����Ű����ر�׼ֵ
                pc4_5 = IntInput_Item4PSCS.Value;//���ְ��������
                pc4_6 = Convert.ToDouble(Tb_Item4AQW.Text);//��ȫ�����ر�׼ֵ
                #region ÿ���������ر�׼ֵ,���ú���ErweiShuzu()
                double[,] gksArray = new double[,] { { 0.1538, 0.1667, 0.1796, 0.1882, 0.1925 }, 
                                                                        { 0.1426, 0.1543, 0.1660, 0.1739, 0.1778}, 
                                                                        {0.1336, 0.1444, 0.1552, 0.1324, 0.1660 }, 
                                                                        { 0.1202, 0.1295, 0.1389, 0.1451, 0.1482}, 
                                                                        {0.1134, 0.1221, 0.1307, 0.1365, 0.1394} };//˫������
                double[,] gkdArray = new double[,] { { 0.1642,0.1793,0.1945,0.2046,0.2097 }, 
                                                                        { 0.1530, 0.1670,	0.1809 ,0.1903, 0.1949 }, 
                                                                        {0.1440,0.1570,0.1701,0.1788 ,0.1831 }, 
                                                                        { 0.1305,0.1422 ,0.1538,	0.1615 ,0.1654 }, 
                                                                        {0.1238 ,0.1347 ,0.1456,	0.1529 ,0.1565 } };//��������
                double[] bjArray = new double[] { 1.20, 1.35, 1.50, 1.80, 2.00 };
                double[] zjArray = new double[] { 1.2, 1.5, 1.8, 2.0, 2.1 };
                if (CbxScaffoldType.SelectedIndex  == 0 || CbxScaffoldType.SelectedIndex  == 1)//˫�Ž��ּ�
                { gk = ErweiShuzu(gksArray, zjArray, bjArray, pc1_1, pc1_3); }
                else if (CbxScaffoldType.SelectedIndex == 2)//���Ž��ּ�
                { gk = ErweiShuzu(gkdArray, zjArray, bjArray, pc1_1, pc1_3); }
                Tb_Item4GK.Text = gk.ToString();
                #endregion 
                //LXtabItem6+7
                ��z=FengYaXiShu(DbInput_Item1DSGD.Value, Cb_Item7DMCCD.SelectedIndex);//��ѹ�߶ȱ仯ϵ��
               //LXtabItem8
                pc8_1 = Rdo_Item8WMMW.Text;//������ʽ���ּܣ�����Ŀ������  
                pc8_2 = Rdo_Item8FBSK.Text;//�����ʽ���ּܱ�����������ܺͿ���ǽ��  
                pc8_3 = Rdo_Item8FBSQ.Text;//�����ʽ���ּܱ���ȫ���ǽ��            
                pc8_5 =Convert.ToDouble( Tb_Item8DFXS1.Text);//����ϵ��                              
                pc8_12 =Convert.ToDouble( Tb_Item8YFMJ.Text);//ӭ�����                              
                pc8_13 = DbIput_Item8DFMJ.Value; //�������
                #region ���õ���ϵ���������������ϵ����s�Ĺ���
                if (Rdo_Item8WMMW.Checked)
                {
                    ��s = Convert.ToDouble(Tb_Item8DFXS1.Text) * 0.6;
                }
                else if (Rdo_Item8FBSK.Checked)
                {
                    if (Convert.ToDouble(Tb_Item8DFXS1.Text) >= 0.8)
                        ��s = Convert.ToDouble(Tb_Item8DFXS1.Text) * 1.3;
                    else
                        ��s = 0.8 * 1.3;
                }
                else if (Rdo_Item8FBSQ.Checked)
                {
                    if (Convert.ToDouble(Tb_Item8DFXS1.Text) >= 0.8)
                        ��s = Convert.ToDouble(Tb_Item8DFXS1.Text);
                    else
                        ��s = 0.8;
                }
                #endregion              
            }
            #endregion
            #region ˫�š����ź����ʽ���õ�
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 2 || CbxScaffoldType.SelectedIndex == 4)
            {
                //LXtabItem9
                pc9_1 = Cb_Item9DJTLX.Text;//�ػ�������                            
                pc9_2 =Convert.ToDouble( Tb_Item9DJCZL.Text);//�ػ���������׼ֵ��kN/m2��
                pc9_3 = DbIput_Item9DBK.Value;//���ּܵ����ף� 
                pc9_4 =Convert.ToDouble( Tb_Item9ZYCD.Text);//���ó��ȣ�m��
                //�ػ�����
                double[] djArray = new double[] {1,0.4, 0.4 ,0.4, 0.5};
                pc9_5 = djArray[Cb_Item9DJLX.SelectedIndex];
            }
            #endregion
            #region �͸�����ר��
            if (CbxScaffoldType.SelectedIndex == 1) //2ѡ���͸��������ּ�
            {
                //LXtabItem10
                pc10_1 = Cb_Item10GLXH.Text;//�����ͺ� 
                pc10_2 = DbInput_Item10MGD.Value;//������ê�̶γ��ȣ�m��             	  
                pc10_3 = DbInput_Item10XTD.Value;//�����������γ��ȣ�m��             	  
                pc10_4 = Cb_Item10RXND.Text;//�����������Ӷ�ѡ��                    
                pc10_5 = Convert.ToDouble(Tb_Item10RXND.Text); //�����������Ӷȣ�m�� 
                //LXtabItem11
                pc11_1 = Convert.ToDouble(Cb_Item11ULSZJ.Text);// U �͸ֽ���������˨ֱ����mm��      	  
                pc11_2 = Convert.ToDouble(Tb_Item11MGXGJL.Text);//ê��λ�����͸�β�����루m��        	  
                pc11_3 = Cb_Item11LBHNTQD.Text;//¥�������ǿ�ȵȼ�
            }
            #endregion
            #region ���ʽר��
            if (CbxScaffoldType.SelectedIndex == 4) //5���ʽ���ּ�
            {
                //LXtabItem16
                pc16_1 = DbInput_Lx5Item1BJ.Value;//	����h(m)
                pc16_2 = DbInput_Lx5Item2GD.Value;//���ּܴ���߶�
                pc16_3 = Convert.ToDouble(Cbx_Lx5Item1ZJ.Text);//�����ݾ�la(m)
                pc16_4 = Convert.ToDouble(Cbx_Lx5Item1HJ.Text);//���˺��lb(m)
                pc16_5 = Cbx_Lx5Item1JHG.Text;//���˸ֹ�����
                pc16_6 = Cbx_Lx5Item1LGG.Text;	//���˸ֹ�����
                pc16_7 = Cbx_Lx5Item1WXG.Text;	//��б�˸ֹ�����
                pc16_8 = Cbx_Lx5Item1SPX.Text;	//ˮƽб�˸ֹ�����
                pc16_9 = Cbx_Lx5Item1LDX.Text;//�ȵ�б�˸ֹ�����
                pc16_10 = Convert.ToInt32(Cbx_Lx5Item1DKJ.Text);	//������˸���njg
                pc16_11 = Convert.ToInt32(Cbx_Lx5Item1WXGBZ.Text);	//��б�˲���(����һ��)
                pc16_12 = IntInput_Lx5Item1SPX.Value;	//ˮƽб�˲���(����һ��)
                pc16_13 = IntInput_Lx5Item1LDX.Value;	//�ȵ�б�˲���(����һ��)
                pc16_14 = IntInput_Lx5Item1NO.Value;	//�ɵ���������������ֵN0(kN)
                pc16_15 = Cbx_Lx5Item1LGJXG.Text;	//���˼�б������
                //LXtabItem17
                pc17_1 = DbInput_Lx5Item2SX.Value;//	��ǽ��������H1��m��
                pc17_2 = DbInput_Lx5Item2SP.Value;//	��ǽ��ˮƽ���L1��m��
                pc17_3 = DbInput_Lx5Item2L0.Value;//	��ǽ�����㳤��l0 (mm)
                pc17_4 = DbInput_Lx5Item2BJ.Value;//	��ǽ�������ת�뾶i(mm)
                pc17_5 = DbInput_Lx5Item2MJ.Value;//	��ǽ���������Ac(mm2)
                pc17_6 = Cbx_Lx5Item2LQJ.Text;//	��ǽ����ʽ
                pc17_9 = DbInput_Lx5Item2KJ.Value;//	�ۼ��������ۼ�ϵ��:
                pc17_10 = DbInput_Lx5Item2DJ.Value;//	�ԽӺ���Ŀ�����ѹǿ�ȣ�N/mm2��
                pc17_11 = DbInput_Lx5Item2LJ.Value;//	���Ӹֽ�Ŀ���ǿ�ȣ�N/mm2��
            }
            #endregion

            #region �ж�ѡ�����ֽ��ּ�ģ��, �ܹ�������ּ�, 11��ģ��(3+3+3+1+1)
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1 || CbxScaffoldType.SelectedIndex == 2)
            {
                #region (˫��+����+����)�����������,һ����
                #region  ������ʼ��
                //�������ϣ�һ������������ʼ��
                double Sum1D1P2 = 0, Sum1D1Q = 0, Sum1D1q1 = 0, Sum1D1q2 = 0;//һ��1.��������ֵ����
                double Sum1D2M1 = 0, Sum1D2M2 = 0, Sum1D2�� = 0; //һ��2.����ǿ�ȼ���
                string CompareD2�� = "";
                double Sum1D3q1 = 0, Sum1D3V = 0;//һ��3.�Ӷȼ���
                string CompareD3V = "";
                double Sum1X1P1 = 0, Sum1X1P2 = 0, Sum1X1Q = 0, Sum1X1P = 0; //1.����ֵ����
                double Sum1X1M = 0, Sum1X2�� = 0; //��2.����ǿ�ȼ���
                string CompareX2�� = "";
                double Sum1X3V1 = 0, Sum1X3P = 0, Sum1X3V2 = 0, Sum1X3V = 0;  //��3.�Ӷȼ���
                string CompareX3V1 = "";
                double Sum1K1P1 = 0, Sum1K1P2 = 0, Sum1K1Q = 0, Sum1K1R = 0;  //�����ۼ��������ļ���:
                string CompareK1R = "";
                //С������ϣ�һ������������ʼ��
                double Sum2X1q2 = 0, Sum2X1dQ = 0, Sum2X1xq = 0, Sum2X2M = 0, Sum2X2�� = 0, Sum2X3V1 = 0;//һ��С�������,la2+la,������������
                string Compare2X2�� = "" , Compare2X3V1 = ""; //С��˵ļ���ǿ�ȣ�С��˵�����Ӷ�
                double Sum2D1Fk = 0, Sum2D1F = 0, Sum2D2Mmax = 0, Sum2D2�� = 0, Sum2D3V = 0, Sum2KR = 0;//������С�������,la2+la,������������
                string Compare2D2�� = "",Compare2D3V = "",Compare2K1R = "";//���˵ļ���ǿ�ȱȽϣ����˵�����ӶȱȽϣ����ۼ�����������
                #endregion
                #region �������
                if (Rdo_Item2DHG.Checked) //��������
                {
                    #region �������� ���������һ����
                    //һ�����˵ļ���:
                    //һ��1.��������ֵ����
                    Sum1D1P2 = pc4_2 * pc1_2 / (pc2_7 + 1);//���ְ�ĺ��ر�׼ֵ
                    Sum1D1Q = pc5_3 * pc1_2 / (pc2_7 + 1);// ����ر�׼ֵ
                    Sum1D1q1 = 1.2 * 0.04 + 1.2 * Sum1D1P2;//�����ص����ֵ
                    Sum1D1q2 = 1.4 * Sum1D1Q;// ����ص����ֵ
                    //һ��2.����ǿ�ȼ���
                    Sum1D2M1 = (0.08 * Sum1D1q1 + 0.10 * Sum1D1q2) * pc1_1 * pc1_1;// ����������
                    Sum1D2M2 = -(0.10 * Sum1D1q1 + 0.117 * Sum1D1q2) * pc1_1 * pc1_1;//֧��������
                    Sum1D2�� = Math.Max(Math.Abs(Sum1D2M1), Math.Abs(Sum1D2M2)) * Math.Pow(10, 6) / 5260; //ѡ��֧�����M2�Ϳ������M1�����ֵ����ǿ������
                    if (Sum1D2�� <= 205) { CompareD2�� = "���˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum1D2�� == 205) { CompareD2�� = "���˵ļ���ǿ�ȵ���205.0N/mm2,����Ҫ��!"; }
                    else if (Sum1D2�� >= 205) { CompareD2�� = "���˵ļ���ǿ��С��205.0N/mm2,������Ҫ��!"; }
                    //һ��3.�Ӷȼ���
                    Sum1D3q1 = 0.040 + Sum1D1P2;
                    Sum1D3V = (0.677 * Sum1D3q1 + 0.990 * Sum1D1Q) * (pc1_1) * 4 / (100 * 2.06 * 105 * 127100.0);
                    if ((Sum1D3V <= (pc1_1 / 150)) && (Sum1D3V <= 10)) { CompareD3V = "���˵�����Ӷ�С�������ݾ�/150��10mm,����Ҫ��!"; }
                    else if ((Sum1D3V == (pc1_1 / 150)) && (Sum1D3V == 10)) { CompareD3V = "���˵�����Ӷȵ��������ݾ�/150��10mm,����Ҫ��!"; }
                    else if ((Sum1D3V >= (pc1_1 / 150)) && (Sum1D3V >= 10)) { CompareD3V = "���˵�����Ӷȴ��������ݾ�/150��10mm,������Ҫ��!"; }
                    //����С��˵ļ���:
                    //��1.����ֵ����
                    Sum1X1P1 = 0.040 * pc1_1;//���˵����ر�׼ֵ
                    Sum1X1P2 = pc4_2 * pc1_2 * pc1_1 / (pc2_7 + 1);//���ְ�ĺ��ر�׼ֵ 
                    Sum1X1Q = pc5_3 * pc1_2 * pc1_1 / (pc2_7 + 1);  //����ر�׼ֵ 
                    Sum1X1P = 1.2 * Sum1X1P1 + 1.2 * Sum1X1P2 + 1.4 * Sum1X1Q;//���ص����ֵ 
                    //��2.����ǿ�ȼ���
                    Sum1X1M = (1.2 * 0.040) * Math.Pow(pc1_2, 2) / 8 + (Sum1X1P * pc1_2) / (pc2_7 + 1);
                    Sum1X2�� = Sum1X1M * Math.Pow(10, 6) / 5260.0;
                    if (Sum1X2�� <= 205) { CompareX2�� = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum1X2�� == 205) { CompareX2�� = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum1X2�� >= 205) { CompareX2�� = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    //��3.�Ӷȼ���
                    Sum1X3V1 = 5.0 * 0.040 * Math.Pow(pc1_2, 4) / (384 * 2.060 * Math.Pow(10, 5) * 127100.000); //С������ؾ����������������Ӷ�
                    Sum1X3P = Sum1X1P1 + Sum1X1P2 + Sum1X1Q;//���к��ر�׼ֵ
                    Sum1X3V2 = Sum1X3P * 1000 * pc1_2 * (3 * Math.Pow(pc1_2, 2) - 4 * Math.Pow(pc1_2, 2) / 9) / (72 * 2.06 * Math.Pow(10, 5) * 127100.0);//���к��ر�׼ֵ����������������Ӷ�
                    Sum1X3V = Sum1X3V1 + Sum1X3V2;//����ӶȺ�
                    if ((Sum1X3V1 <= (pc1_2 / 150)) && (Sum1X3V1 <= 10)) { CompareX3V1 = " С��˵�����Ӷ�С�� ���˺��/150��10mm,����Ҫ��!"; }
                    else if ((Sum1X3V1 == (pc1_2 / 150)) && (Sum1X3V1 == 10)) { CompareX3V1 = "С��˵�����Ӷȵ��� ���˺��/150��10mm,����Ҫ��!"; }
                    else if ((Sum1X3V1 >= (pc1_2 / 150)) && (Sum1X3V1 >= 10)) { CompareX3V1 = "С��˵�����Ӷȴ��� ���˺��/150��10mm,������Ҫ��!"; }
                    //�����ۼ��������ļ���:
                    Sum1K1P1 = 0.040 * pc1_2; //��˵����ر�׼ֵ  
                    Sum1K1P2 = pc1_2 * pc1_2 * pc1_1 / 2;//���ְ�ĺ��ر�׼ֵ
                    Sum1K1Q = @pc5_3 * pc1_2 * pc1_1 / 2; //����ر�׼ֵ
                    Sum1K1R = 1.2 * Sum1K1P1 + 1.2 * Sum1K1P2 + 1.4 * Sum1K1Q;//���ص����ֵ
                    if (Sum1K1R <= pc1_7) { CompareK1R = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum1K1R == pc1_7) { CompareK1R = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    #region ������������ת��
                    Sum1D1P2 = Convert.ToDouble(Sum1D1P2.ToString("f3"));
                    Sum1D1Q = Convert.ToDouble(Sum1D1Q.ToString("f3"));
                    Sum1D1q1 = Convert.ToDouble(Sum1D1q1.ToString("f3"));
                    Sum1D1q2 = Convert.ToDouble(Sum1D1q2.ToString("f3"));
                    Sum1D2M1 = Convert.ToDouble(Sum1D2M1.ToString("f3"));
                    Sum1D2M2 = Convert.ToDouble(Sum1D2M2.ToString("f3"));
                    Sum1D2�� = Convert.ToDouble(Sum1D2��.ToString("f3"));
                    Sum1D3q1 = Convert.ToDouble(Sum1D3q1.ToString("f3"));
                    Sum1D3V = Convert.ToDouble(Sum1D3V.ToString("f3"));
                    Sum1X1P1 = Convert.ToDouble(Sum1X1P1.ToString("f3"));
                    Sum1X1P2 = Convert.ToDouble(Sum1X1P2.ToString("f3"));
                    Sum1X1Q = Convert.ToDouble(Sum1X1Q.ToString("f3"));
                    Sum1X1P = Convert.ToDouble(Sum1X1P.ToString("f3"));
                    Sum1X1M = Convert.ToDouble(Sum1X1M.ToString("f3"));
                    Sum1X2�� = Convert.ToDouble(Sum1X2��.ToString("f3"));
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
                else if(Rdo_Item2XHG.Checked==true ) //С�������
                {
                    #region һ��С�������,la2+la,�����ļ������,һ:
                    Sum2X1q2 = pc4_2 * pc1_2 / pc2_5;
                    Sum2X1dQ = pc5_3 * pc1_1 / pc2_5;
                    Sum2X1xq = 1.2 * 0.040 + 1.2 * Sum2X1q2 + 1.4 * Sum2X1dQ;
                    Sum2X2M = Sum2X1xq * pc1_2 * pc1_2 / 8;
                    Sum2X2�� = Sum2X2M * Math.Pow(10, 6) / 5260.0;
                    Sum2X3V1 = 5.0 * (0.040 + Sum2X1q2) * Math.Pow(pc1_2, 4) / (384 * 2.060 * Math.Pow(10, 5) * 127100.000);
                    if (Sum2X2�� <= 205) { Compare2X2�� = "С��˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum2X2�� == 205) { Compare2X2�� = "С��˵ļ���ǿ�ȵ���205.0N/mm2,����Ҫ��!"; }
                    else if (Sum2X2�� >= 205) { Compare2X2�� = "С��˵ļ���ǿ�ȴ���205.0N/mm2,������Ҫ��!"; }
                    if ((Sum2X3V1 <= (pc1_2 / 150)) && (Sum2X3V1 <= 10)) { Compare2X3V1 = "С��˵�����Ӷ�С�����˺��/150��10mm,����Ҫ��!"; }
                    else if ((Sum2X3V1 == (pc1_2 / 150)) && (Sum2X3V1 == 10)) { Compare2X3V1 = "С��˵�����Ӷȵ������˺��/150��10mm,����Ҫ��!"; }
                    else if ((Sum2X3V1 >= (pc1_2 / 150)) && (Sum2X3V1 >= 10)) { Compare2X3V1 = "С��˵�����Ӷȴ������˺��/150��10mm,������Ҫ��!"; }
                    #endregion
                    if (Cb_Item2LGZJ.SelectedIndex == 0)//С������������ݾ�la2
                    {
                        #region С�������la2,������̶���
                        //�������˵ļ���:
                        Sum2D1Fk = 0.5 * (0.040 + Sum2X1q2 + Sum2X1dQ) * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D1F = 0.5 * Sum2X1xq * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D2Mmax = 0.175 * Sum2D1F * pc1_1 + 0.1 * 0.040 * pc1_1 * pc1_1;
                        Sum2D2�� = Sum2D2Mmax * Math.Pow(10, 6) / 5260.0;
                        Sum2D3V = (0.677 * 0.04 * pc1_1 + 1.146 * Sum2D1Fk) * Math.Pow(pc1_1, 3) / (100 * 2.06 * Math.Pow(10, 5) * 127100.0);
                        //�����ۼ��������ļ���:
                        Sum2KR = 2.15 * 3.412 + 0.040 * pc1_1 / 3;
                        #endregion
                    }
                    else if (Cb_Item2LGZJ.SelectedIndex == 1)//С������������ݾ�la
                    {
                        #region С�������la,������̶���
                        //�������˵ļ���:
                        Sum2D1Fk = 0.5 * (0.040 + Sum2X1q2 + Sum2X1dQ) * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D1F = 0.5 * Sum2X1xq * pc1_2 * (1 + pc1_6 / pc1_2);
                        Sum2D2Mmax = 0.1 * 0.040 * pc1_1 * pc1_1;//��ͬ��la2֮��
                        Sum2D2�� = Sum2D2Mmax * Math.Pow(10, 6) / 5260.0;
                        Sum2D3V = (0.677 * 0.04 * Math.Pow(pc1_1, 4)) / (100 * 2.06 * Math.Pow(10, 5) * 127100.0);
                        //�����ۼ��������ļ���:
                        Sum2KR = 3.412 + 0.040 * pc1_1 / 3;
                        #endregion
                    }
                    if (Sum2D2�� <= 205) { Compare2D2�� = "���˵ļ���ǿ��С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum2D2�� == 205) { Compare2D2�� = "���˵ļ���ǿ�ȵ���205.0N/mm2,����Ҫ��!"; }
                    else if (Sum2D2�� >= 205) { Compare2D2�� = "���˵ļ���ǿ�ȴ���205.0N/mm2,������Ҫ��!"; }
                    if ((Sum2D3V <= (pc1_1 / 150)) && (Sum2D3V <= 10)) { Compare2D3V = "���˵�����Ӷ�С�������ݾ�/150��10mm,����Ҫ��!"; }
                    else if ((Sum2D3V == (pc1_1 / 150)) && (Sum2D3V == 10)) { Compare2D3V = "���˵�����Ӷȵ��������ݾ�/150��10mm,����Ҫ��!"; }
                    else if ((Sum2D3V >= (pc1_1 / 150)) && (Sum2D3V >= 10)) { Compare2D3V = "���˵�����Ӷȴ��������ݾ�/150��10mm,������Ҫ��!"; }
                    if (Sum2KR <= pc1_7) { Compare2K1R = "���ۼ���������������Ƽ�������Ҫ��!"; }
                    else if (Sum2KR == pc1_7) { Compare2K1R = "���ۼ���������������Ƽ��㲻����Ҫ��!"; }
                }
                #endregion
                #region С�����������ת��
                Sum2X1q2 = Convert.ToDouble(Sum2X1q2.ToString("f3"));
                Sum2X1dQ = Convert.ToDouble(Sum2X1dQ.ToString("f3"));
                Sum2X1xq = Convert.ToDouble(Sum2X1xq.ToString("f3"));
                Sum2X2M = Convert.ToDouble(Sum2X2M.ToString("f3"));
                Sum2X2�� = Convert.ToDouble(Sum2X2��.ToString("f3"));
                Sum2X3V1 = Convert.ToDouble(Sum2X3V1.ToString("f3"));
                Sum2D1Fk = Convert.ToDouble(Sum2D1Fk.ToString("f3"));
                Sum2D1F = Convert.ToDouble(Sum2D1F.ToString("f3"));
                Sum2D2Mmax = Convert.ToDouble(Sum2D2Mmax.ToString("f3"));
                Sum2D2�� = Convert.ToDouble(Sum2D2��.ToString("f3"));
                Sum2D3V = Convert.ToDouble(Sum2D3V.ToString("f3"));
                Sum2KR = Convert.ToDouble(Sum2KR.ToString("f3"));
                #endregion

                #endregion

                #region (˫��+����+����)�����������,��������
                //�ġ����ּܺ��ر�׼ֵ:
                double Sum1NG1 = 0, Sum1NG2 = 0, Sum1NG3 = 0, Sum1NG4 = 0, Sum1NG = 0, Sum1NQ = 0, Sum1Wk = 0, Sum1YesN = 0, Sum1NoN = 0, Sum1MW = 0;
                Sum1NG1 = gk * pc1_4;
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//(˫��+����)���ּ�
                {Sum1NG2 = pc4_2 * pc4_5 * pc1_1 * (pc1_2 + pc1_6) / 2;}
                else if (CbxScaffoldType.SelectedIndex == 2)//���Ž��ּ�
                { Sum1NG2 = pc4_2 * pc4_5 * pc1_1 * pc1_2  / 2; }
                Sum1NG3 = pc4_4 * pc1_1 * pc4_5 / 2;
                Sum1NG4 = pc4_6 * pc1_1 * pc1_4;
                Sum1NG = Sum1NG1 + Sum1NG2 + Sum1NG3 + Sum1NG4; //�����ر�׼ֵ
                Sum1NQ = pc5_3 * pc5_2 * pc1_1 * pc1_2 / 2;
                Sum1Wk = 0.7 * pc6_4 * ��z * ��s;
                Sum1YesN = 1.2 * Sum1NG + 0.9 * 1.4 * Sum1NQ;//���Ƿ����ʱ,���˵�����ѹ�����ֵ
                Sum1NoN = 1.2 * Sum1NG + 1.4 * Sum1NQ;//�����Ƿ����ʱ,���˵�����ѹ�����ֵ
                Sum1MW = 0.9 * 1.4 * Sum1Wk * pc1_1 * Math.Pow(pc1_3, 2) / 10;
                //�塢���˵��ȶ��Լ���:
                double LgU = 0, LgL0 = 0, Lg�� = 0, Lg�� = 0, Sum1No�� = 0, Sum1Yes�� = 0;
                LgU = YiweiShuzu(DbInput_Item1LGHJ.Value, Cb_Item3JJ.SelectedIndex);//���ú���,���㳤��ϵ��u
                LgL0 = 1.155 * LgU * pc1_3;
                Lg�� = LgL0 / 159;
                if (Lg�� > 250)
                {
                    Lg�� = 7320 / (Lg�� * Lg��);
                }
                else
                {
                    int Lg��y1 = Convert.ToInt32(Lg�� / 10);//�ڦ�y1��
                    int Lg��x1 = Convert.ToInt32(Lg�� % 10);// �ڦ�x1��
                    Lg�� = ��Array[Lg��y1, Lg��x1]; //��Array����Ϊȫ�ֱ���,�μ�����B.0.6������ѹ�������ȶ�ϵ����(Q235��)��
                }
                string CompareNo�� = ""; 
                Sum1No�� = Sum1NoN / (Lg�� * 5.06);
                if (Sum1No�� <= 205) { CompareNo�� = "�����Ƿ����ʱ�����˵��ȶ��Լ����< [f],����Ҫ��!"; }
                else if (Sum1No�� == 205) { CompareNo�� = "�����Ƿ����ʱ�����˵��ȶ��Լ����= [f],����Ҫ��!"; }
                else if (Sum1No�� >= 205) { CompareNo�� = "�����Ƿ����ʱ�����˵��ȶ��Լ����> [f],����Ҫ��!"; }
                string CompareYes�� = "";
                Sum1Yes�� = Sum1YesN / (Lg�� * 5.06) + Sum1MW / 5.26;
                if (Sum1Yes�� <= 205) { CompareYes�� = "���Ƿ����ʱ�����˵��ȶ��Լ����< [f],����Ҫ��!"; }
                else if (Sum1Yes�� == 205) { CompareYes�� = "���Ƿ����ʱ�����˵��ȶ��Լ����= [f],����Ҫ��!"; }
                else if (Sum1Yes�� >= 205) { CompareYes�� = "���Ƿ����ʱ�����˵��ȶ��Լ����> [f],����Ҫ��!"; }
                //����������߶ȵļ���:
                double Sum1NG2K = 0, Sum1Mwk = 0, Sum1NoHs = 0, Sum1YesHs = 0, Sum1compareH = 0;
                Sum1NG2K = Sum1NG2 + Sum1NG3 + Sum1NG4;
                Sum1Mwk = Sum1Wk * pc1_1 * (pc1_3 * pc1_3) / 10;
                Sum1NoHs = (Lg�� * 5.06 * 205 - (1.2 * Sum1NG2K + 1.4 * Sum1NQ)) / (1.2 * gk);
                Sum1YesHs = (Lg�� * 5.06 * 205 - (1.2 * Sum1NG2K + 0.9 * 1.4 * (Sum1NQ + (Sum1Mwk / 5.26) * (Lg�� * 5.06)))) / (1.2 * gk);
                Sum1compareH = Math.Min(Sum1NoHs, Sum1YesHs);
                string CompareHs = "";
                if (pc1_4 <= Sum1compareH) { CompareHs = "С��[H]������Ҫ��"; }
                else if (pc1_4 == Sum1compareH) { CompareHs = "����[H]������Ҫ��"; }
                else if (pc1_4 >= Sum1compareH) { CompareHs = "����[H]��������Ҫ��"; }
                //�ߡ���ǽ���ļ���:
                int m = 0, n = 0;
                switch (Cb_Item3JJ.SelectedIndex)
                {
                    case 0: m = 2; n = 3; break;
                    case 1: m = n = 3; break;
                }
                double Sum1Aw = 0, Sum1Nlw = 0, Sum1Nl = 0, Sum1Lqj��=0;
                Sum1Aw = m * pc1_3 * n * pc1_1;
                Sum1Nlw = 1.4 * Sum1Wk * Sum1Aw; //����ز�������ǽ�����������ֵ
                Sum1Nl = Sum1Nlw + pc3_3;//��ǽ�����������ֵ
                Sum1Lqj�� = Sum1Nl / 506;// ��ǽ����ǿ��
                string CompareF1 = "";
                if (Sum1Lqj�� <= (0.85 * 205)) { CompareF1 = " ������æ�С��0.85f,����Ҫ��"; }
                else if (Sum1Lqj�� == (0.85 * 205)) { CompareF1 = " ������æĵ���0.85f,����Ҫ��"; }
                else if (Sum1Lqj�� >= (0.85 * 205)) { CompareF1 = " ������æĴ���0.85f,����Ҫ��"; }
                double Sum1Nl��A, Lqj��;
                double Lqj�� = 0;
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//(˫��+����)���ּ�
                { Lqj�� = pc1_5 / 159; }
                else if (CbxScaffoldType.SelectedIndex == 2)
                { Lqj�� = pc1_2 / 159; }
                if (Lqj�� > 250)
                {
                    Lqj�� = 7320 / (Lg�� * Lg��);
                }
                else
                {
                    int Lqj��y1 = Convert.ToInt32(Lqj�� / 10);//�ڦ�y1��
                    int Lqj��x1 = Convert.ToInt32(Lqj�� % 10);// �ڦ�x1��
                    Lqj�� = ��Array[Lqj��y1, Lqj��x1]; //��Array����Ϊȫ�ֱ���,�μ�����B.0.6������ѹ�������ȶ�ϵ����(Q235��)��
                }
                Sum1Nl��A = Sum1Nl / (Lqj�� * 1832);
                string CompareF2 = "";
                if (Sum1Nl��A <= (0.85 * 205)) { CompareF2 = " С��0.85f,����Ҫ��"; }
                else if (Sum1Nl��A == (0.85 * 205)) { CompareF2 = " ����0.85f,����Ҫ��"; }
                else if (Sum1Nl��A >= (0.85 * 205)) { CompareF2 = " ����0.85f,����Ҫ��"; }
                #region (˫��+����+����)�����������,�������� ����ת��
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
                Lg�� = Convert.ToDouble(Lg��.ToString("f3"));
                Lg�� = Convert.ToDouble(Lg��.ToString("f3"));
                Sum1No�� = Convert.ToDouble(Sum1No��.ToString("f3"));
                Sum1Yes�� = Convert.ToDouble(Sum1Yes��.ToString("f3"));
                Sum1NG2K = Convert.ToDouble(Sum1NG2K.ToString("f3"));
                Sum1Mwk = Convert.ToDouble(Sum1Mwk.ToString("f3"));
                Sum1NoHs = Convert.ToDouble(Sum1NoHs.ToString("f3"));
                Sum1YesHs = Convert.ToDouble(Sum1YesHs.ToString("f3"));
                Sum1Aw = Convert.ToDouble(Sum1Aw.ToString("f3"));
                Sum1Nlw = Convert.ToDouble(Sum1Nlw.ToString("f3"));
                Sum1Nl = Convert.ToDouble(Sum1Nl.ToString("f3"));
                Sum1Lqj�� = Convert.ToDouble(Sum1Lqj��.ToString("f3"));
                Sum1Nl��A = Convert.ToDouble(Sum1Nl��A.ToString("f3"));
                Lqj�� = Convert.ToDouble(Lqj��.ToString("f3"));
                Lqj�� = Convert.ToDouble(Lqj��.ToString("f3"));
                
                #endregion
                #endregion

                #region  (˫��+����)����������̰ˣ�������������̰˾�ʮ
                double Sum1NK = 0, Sum1A = 0, Sum1Pk = 0, Sum1fg = 0;   //��˫�Űˡ����˵ĵػ�����������,��������
                string Comparefg = "";
                #region ���ֲָ�����
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
                double Sum4N1 = 0, Sum4q1 = 0, Sum4k = 0, Sum4k1 = 0, Sum4k2 = 0, Sum4RA = 0, Sum4RB = 0, Sum4MA = 0, Sum4f = 0, Sum4N2 = 0, Sum4q2 = 0, Sum4Vmax = 0;//����,��(�͸�����������)
                string CompareXgf="",CompareVmax = "";
                double Sum4��b1 = 0, Sum4��b = 0, Sum4��1 = 0, ��Param = 0, ��bParam = 0, ��yParam = 0, fy = 235, ��b = 0;//��(�����������ȶ���)
                string strSum4��b="", Compare��b�� = "";
                double Sum4��2 = 0, Sum4Mgd = 0, Sum4d = 0, fc = 0, Sum4fc = 0, Sum4Lsll = 0;//ʮ(ê�̶���¥�����Ӽ���)
                string CompareLhsl = "" ,CompareLsll="";
                if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 2)//����ǵ�˫�Ž��ּ�,����,��(���˵ĵػ�����������)
                {
                    #region  ��˫��,����������̣��ˡ����˵ĵػ�����������:
                    Sum1NK = 1.2 * Sum1NG + 1.4 * Sum1NQ;
                    Sum1A = pc9_3 * pc1_1;
                    Sum1Pk = Sum1NK / Sum1A;
                    Sum1fg = pc9_2 * pc9_5;
                    if (Sum1Pk <= Sum1fg) { Comparefg = " ������õ��ػ��������ļ���,����Ҫ��!"; }
                    else if (Sum1Pk > Sum1fg) { Comparefg = " ������õ��ػ��������ļ���,������Ҫ��!"; }
                    #region ��˫��,����������̣��ˡ����˵ĵػ���������������ת��
                    Sum1NK = Convert.ToDouble(Sum1NK.ToString("f3"));
                    Sum1A = Convert.ToDouble(Sum1A.ToString("f3"));
                    Sum1Pk = Convert.ToDouble(Sum1Pk.ToString("f3"));
                    Sum1fg = Convert.ToDouble(Sum1fg.ToString("f3"));
                   
                    #endregion
                    #endregion
                }
                else if (CbxScaffoldType.SelectedIndex == 1)//������������ּ�,����,��(�͸�����������)����(�����������ȶ���)��ʮ(ê�̶���¥�����Ӽ���)
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
                    //��(�͸�����������)
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
                    if (Sum4f < 205) { CompareXgf = " �͸�������Ӧ��ֵС��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum4f == 205) { CompareXgf = "�͸�������Ӧ��ֵ����205.0N/mm2,����Ҫ��!"; }
                    else if (Sum4f > 205) { CompareXgf = " �͸�������Ӧ��ֵ����205.0N/mm2,������Ҫ��!"; }
                    Sum4N2 = Sum1NG + Sum1NQ;
                    Sum4q2 = weightParam * (pc10_3 + pc10_2 - 200) * 0.001 * 9.8 * 0.001;
                    Sum4Vmax = (Sum4N2 * Math.Pow(m2Param, 2) * lParam * (1 + Sum4k2) / (3 * 2.06 * ix1Param) + Sum4N2 * Math.Pow(m1Param, 2) * lParam * (1 + Sum4k1) / (3 * 2.06 * ix1Param) + mParam * Sum4q2 * Math.Pow(lParam, 3) * (-1 + 4 * Math.Pow(Sum4k, 2) + 3 * Math.Pow(Sum4k, 3)) / (3 * 2.06 * ix1Param * 8))*1000;       //��δ���
                    if (Sum4Vmax < pc10_5) { CompareVmax = " ˮƽ֧����������Ӷ�С�������������Ӷȣ�����Ҫ��!"; }
                    else if (Sum4Vmax == pc10_5) { CompareVmax = "ˮƽ֧����������Ӷȵ��������������Ӷȣ�����Ҫ��!"; }
                    else if (Sum4Vmax > pc10_5) { CompareVmax = " ˮƽ֧����������Ӷȴ��������������Ӷȣ�������Ҫ��!"; }
                    //��(�����������ȶ���)
                    ��Param = pc10_3*1000 * tParam / (bParam * hParam);
                    if (��Param >= 0.60 && ��Param <= 1.24){��bParam = 0.21 + 0.67 * ��Param;}
                    else if(��Param >1.24 && ��Param <= 1.96){ ��bParam = 0.72 + 0.26 * ��Param; }
                    else if (��Param >1.96 && ��Param <= 3.10){ ��bParam = 1.17 + 0.03 * ��Param; }
                    ��yParam = pc10_3 / iy2Param;
                    Sum4��b1 = (��bParam * 4320 / Math.Pow(��yParam, 2)) * (aParam * hParam / wxParam) * (Math.Sqrt(1 + Math.Pow(��yParam * tParam / (4.4 * hParam), 2)) + ��b) * 235 / fy;
                    if (Sum4��b > 0.6)
                    {
                        double Sum4��b2 = 1.07 - 0.282 / Sum4��b1;
                        strSum4��b = "���� b����0.6�����ա��ֽṹ��ƹ淶��(GB50017)������������ʽΪ��b=1.07-0.282/��b�ҡ�1.0������æ�b '=" + Sum4��b.ToString();
                        Sum4��b = Sum4��b2;
                    }
                    else 
                    {
                        Sum4��b = Sum4��b1;
                    }
                    Sum4��1 = Sum4MA * Math.Pow(10, 6) / (Sum4��b * wxParam * 1000);
                    if (Sum4��1 < 205) { Compare��b�� = " ˮƽ�������ȶ��Լ����С��205.0N/mm2,����Ҫ��!"; }
                    else if (Sum4��1 == 205) { Compare��b�� = "ˮƽ�������ȶ��Լ���ҵ���205.0N/mm2,����Ҫ��!"; }
                    else if (Sum4��1 > 205) { Compare��b�� = " ˮƽ�������ȶ��Լ���Ҵ���205.0N/mm2,������Ҫ��!"; }
                    //ʮ(ê�̶���¥�����Ӽ���)
                    Sum4��2 = Sum4RB / (3.1416 * pc11_1 / 2 * pc11_1 / 2 * 2);
                    if (Sum4��2 < 50) { CompareLhsl = " ��������Ӧ����С��50N/mm2,����Ҫ��!"; }
                    else if (Sum4��2 == 50) { CompareLhsl = "��������Ӧ���ҵ���50N/mm2,����Ҫ��!"; }
                    else if (Sum4��2 > 50) { CompareLhsl = " ��������Ӧ���Ҵ���50N/mm2,������Ҫ��!"; }
                    Sum4Mgd = Sum4RB * 1000 / (3.1416 * pc11_1 * 1.5);
                    Sum4d = 5*dParam;
                    double[] fcArray=new double[]{9.6, 11.9, 14.3, 16.7, 19.1, 21.1, 23.1};
                    fc = fcArray[Cb_Item11LBHNTQD.SelectedIndex]; 
                    Sum4fc = 0.95 * fc;
                    Sum4Lsll = (bParam * bParam - Math.PI * dParam * dParam / 4) * Sum4fc;
                    if (Sum4RB <= Sum4Lsll) { CompareLsll = " ¥��������ֲ���ѹ��������Ҫ��!"; }
                    else { CompareLsll = "¥��������ֲ���ѹ���㲻����Ҫ��!"; }
                    #region ������������ּ�,����,��(�͸�����������)����(�����������ȶ���)��ʮ(ê�̶���¥�����Ӽ���)����ת��
                    /*double Sum4N1 = 0, Sum4q1 = 0, Sum4k = 0, Sum4k1 = 0, Sum4k2 = 0, Sum4RA = 0, Sum4RB = 0, Sum4MA = 0, Sum4f = 0, Sum4N2 = 0, Sum4q2 = 0, Sum4Vmax = 0;//����,��(�͸�����������)
                     string CompareXgf="",CompareVmax = "";
                     double Sum4��b1 = 0, Sum4��b = 0, Sum4��1 = 0, ��Param = 0, ��bParam = 0, ��yParam = 0, fy = 235, ��b = 0;//��(�����������ȶ���)
                     string strSum4��b="", Compare��b�� = "";
                     double Sum4��2 = 0, Sum4Mgd = 0, Sum4d = 0, fc = 0, Sum4fc = 0, Sum4Lsll = 0;//ʮ(ê�̶���¥�����Ӽ���)
                     
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
                    ��Param = Convert.ToDouble(��Param.ToString("f3"));
                    ��yParam = Convert.ToDouble(��yParam.ToString("f3"));
                    Sum4��b1 = Convert.ToDouble(Sum4��b1.ToString("f3"));
                    Sum4��1 = Convert.ToDouble(Sum4��1.ToString("f3"));
                    Sum4��2 = Convert.ToDouble(Sum4��2.ToString("f3"));
                    Sum4Mgd = Convert.ToDouble(Sum4Mgd.ToString("f3"));
                    Sum4d = Convert.ToDouble(Sum4d.ToString("f3"));
                    Sum4fc = Convert.ToDouble(Sum4fc.ToString("f3"));
                    Sum4Lsll = Convert.ToDouble(Sum4Lsll.ToString("f3"));
                   
                    #endregion
                }
                #endregion

                #region      1ѡ�����˫�Ž��ּ�
                if (CbxScaffoldType.SelectedIndex == 0) //1ѡ�����˫�Ž��ּ�
                {
                    if (Rdo_Item2DHG.Checked) //��������
                    {
                        itemtext = "˫�Ŵ�������";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,��z,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2��,CompareD2��, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2��, CompareX2��,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                    Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                    else if (Rdo_Item2XHG.Checked) //С�������
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)//С������������ݾ�la2
                        {
                            itemtext = "˫��С������������ݾ�la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)//С������������ݾ�la
                        {
                            itemtext = "˫��С������������ݾ�la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,��z,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                        pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2��, Sum2X3V1,Compare2X2��,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2��, Sum2D3V,Compare2D2��,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                        Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                }
                #endregion

                #region       2ѡ���͸��������ּ�
                else if (CbxScaffoldType.SelectedIndex == 1) //2ѡ���͸��������ּ�
                {
                    if (Rdo_Item2DHG.Checked)
                    {
                        itemtext = "������������";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,��z,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                    pc10_1,pc10_2,pc10_3,pc10_4,pc10_5 ,
                                                    pc11_1,pc11_2,pc11_3,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2��,CompareD2��, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2��, CompareX2��,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                   weightParam, wxParam,Sum4N1, Sum4q1, Sum4k, Sum4k1, Sum4k2, Sum4RA, Sum4RB, Sum4MA, Sum4f, Sum4N2, Sum4q2, Sum4Vmax, CompareXgf, CompareVmax,
                                                   Sum4��b1, Sum4��b,Sum4��1,strSum4��b,Compare��b��,
                                                   Sum4��2,Sum4Mgd,Sum4d, fc ,Sum4fc,Sum4Lsll ,CompareLhsl ,CompareLsll
                                                    };
                    }
                    if (Rdo_Item2XHG.Checked)
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)
                        {
                            itemtext = "����С������������ݾ�la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)
                        {
                            itemtext = "����С������������ݾ�la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,��z,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                        pc10_1,pc10_2,pc10_3,pc10_4,pc10_5 ,
                                                        pc11_1,pc11_2,pc11_3,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2��, Sum2X3V1,Compare2X2��,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2��, Sum2D3V,Compare2D2��,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                       weightParam, wxParam,Sum4N1, Sum4q1, Sum4k, Sum4k1, Sum4k2, Sum4RA, Sum4RB, Sum4MA, Sum4f, Sum4N2, Sum4q2, Sum4Vmax,CompareXgf, CompareVmax,
                                                        Sum4��b1, Sum4��b,Sum4��1,strSum4��b,Compare��b��,
                                                       Sum4��2,Sum4Mgd,Sum4d, fc ,Sum4fc,Sum4Lsll ,CompareLhsl,CompareLsll
                                                        };
                    }
                }
                #endregion

                #region       3ѡ����ص��Ž��ּ�
                else if (CbxScaffoldType.SelectedIndex == 2) //3ѡ����ص��Ž��ּ�
                {
                    if (Rdo_Item2DHG.Checked)
                    {
                        itemtext = "���Ŵ�������";
                        obj = new object[] { pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                    pc2_2,pc2_7,
                                                    pc3_1,pc3_2,pc3_3,
                                                    pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                    pc5_1,pc5_2,pc5_3,
                                                    pc6_1,pc6_2,pc6_4,
                                                    pc7_1,��z,
                                                    pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                    Sum1D1P2, Sum1D1Q, Sum1D1q1, Sum1D1q2, Sum1D2M1, Sum1D2M2, Sum1D2��,CompareD2��, Sum1D3q1, Sum1D3V,CompareD3V,
                                                    Sum1X1P1, Sum1X1P2, Sum1X1Q, Sum1X1P, Sum1X1M, Sum1X2��, CompareX2��,Sum1X3V1, Sum1X3P, Sum1X3V2, Sum1X3V,CompareX3V1,
                                                    Sum1K1P1,Sum1K1P2 ,Sum1K1Q , Sum1K1R,CompareK1R,
                                                    Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                    LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                    Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                    Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                    Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                    if (Rdo_Item2XHG.Checked)
                    {
                        if (Cb_Item2LGZJ.SelectedIndex == 0)
                        {
                            itemtext = "����С������������ݾ�la2";
                        }
                        else if (Cb_Item2LGZJ.SelectedIndex == 1)
                        {
                            itemtext = "����С������������ݾ�la";
                        }
                        obj = new object[] {   pc1_1 , pc1_2 , pc1_3 , pc1_4, pc1_5, pc1_6, pc1_7, pc1_8, pc1_9, pc1_10,
                                                        pc2_1,pc2_4,pc2_5,
                                                        pc3_1,pc3_2,pc3_3,
                                                        pc4_1,pc4_2,pc4_3,pc4_4,pc4_5,pc4_6,gk,
                                                        pc5_1,pc5_2,pc5_3,
                                                        pc6_1,pc6_2,pc6_4,
                                                        pc7_1,��z,
                                                        pc8_1,pc8_2,pc8_3,pc8_12,pc8_13,��s,
                                                        pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,
                                                        Sum2X1q2, Sum2X1dQ, Sum2X1xq, Sum2X2M, Sum2X2��, Sum2X3V1,Compare2X2��,Compare2X3V1,
                                                        Sum2D1Fk, Sum2D1F, Sum2D2Mmax, Sum2D2��, Sum2D3V,Compare2D2��,Compare2D3V,
                                                        Sum2KR,Compare2K1R,
                                                        Sum1NG1, Sum1NG2, Sum1NG3, Sum1NG4, Sum1NG, Sum1NQ, Sum1Wk, Sum1YesN, Sum1NoN, Sum1MW,
                                                        LgU, LgL0, Lg��, Sum1No��,CompareNo��,Sum1Yes��,CompareYes��,
                                                        Sum1NG2K, Sum1Mwk ,Sum1NoHs, Sum1YesHs,CompareHs,
                                                        Sum1Aw, Sum1Nlw, Sum1Nl ,Sum1Lqj��,CompareF1, Sum1Nl��A, Lqj��,CompareF2,
                                                        Sum1NK, Sum1A, Sum1Pk,Sum1fg,Comparefg };
                    }
                }
                #endregion
            }

            #region      4��ʽ�ֹܽ��ּ�
            else if (CbxScaffoldType.SelectedIndex == 3) //4��ʽ�ֹܽ��ּ�
            {
                //LX4tabItem1
                double  pc12_5, pc12_6, pc12_7, pc12_8, pc12_9;
                pc12_5 = System.Convert.ToDouble ( Tb_Lx4Item1BJ.Text) ; //�żܲ���
                pc12_6 = DbInput_Lx4Item1KJ.Value ; //�żܿ��
                pc12_7 = DbInput_Lx4Item1GD.Value ; //���ּܴ���߶�
                pc12_8 = DbInput_Lx4Item1D.Value ; //���ۼ�����������
                pc12_9 = DbInput_Lx4Item1S.Value; //˫�ۼ�����������
                ��z = FengYaXiShu(pc12_7, Cb_Item7DMCCD.SelectedIndex);//��z����ѹ�߶ȱ仯ϵ��
                double k = 0;
                if (pc12_7 <= 30) { k = 1.13; }
                else if (30 < pc12_7 && pc12_7 <= 45) { k = 1.17; }
                else if (45 < pc12_7 && pc12_7 <= 55) { k = 1.22; }
                #region ���Ҫ���ĵ��е�һ����
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
                string[] r1Item = new string[] {"��42.0��2.5", "��48.0��3.5", "��42.0��2.5", "��42.0��2.5"};
                string  r1 = r1Item[mfID];
                string[] r2Item = new string[] { "��26.8��2.5", "��26.8��2.5", "��26.8��2.2", "��26.8��2.2" };
                string  r2 = r2Item[mfID];
                string[] r3Item = new string[] { "��42.0��2.5", "��48.0��3.5", "��42.0��2.5", "��42.0��2.5" };
                string  r3 = r3Item[mfID];
                string[] r4Item = new string[] { "��26.8��2.5", "��26.8��2.5", "��26.8��2.2", "��26.8��2.2" };
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
                pc13_1 = DbInput_Lx4Item2CD.Value; //��ǽ�����㳤��
                pc13_2 = DbInput_Lx4Item2BJ.Value; //��ǽ�������ת�뾶i(mm)
                pc13_3 = DbInput_Lx4Item2SX.Value ; //��ǽ��������
                pc13_4 = Cbx_Lx4Item2LJFS.Text; //��ǽ�����ӷ�ʽ
                pc13_5 = Rdo_Lx4Item2D.Text; //���ۼ�
                pc13_6 = Rdo_Lx4Item2S.Text; //˫�ۼ�
                pc13_7 = DbInput_Lx4Item2DJ.Value; //�ԽӺ���Ŀ�����ѹǿ��
                pc13_8 = DbInput_Lx4Item2SP.Value; //��ǽ��ˮƽ���
                //LX4tabItem3
                double pc14_1, pc14_2, pc14_5, pc14_6, pc14_8, pc14_9;
                string pc14_3, pc14_4, pc14_7;
                pc14_1 = IntInput_Lx4Item3JSB.Value; //���ְ���跽ʽ
                pc14_2 = IntInput_Lx4Item3SPJ.Value; //ˮƽ�ܴ��跽ʽ
                pc14_3 = Cbx_Lx4Item3JSB.Text; //���ְ����
                pc14_4 = Cbx_Lx4Item3JGJ.Text; //�ӹ̼�����,������ʾ
                pc14_5 = DbInput_Lx4Item3AQW.Value; //��ȫ������
                pc14_6 = DbInput_Lx4Item3HL.Value; //��������
                pc14_7 = Cbx_Lx4Item3YT.Text; //���ּ���;
                pc14_8 = IntInput_Lx4Item3CS.Value; //ͬʱʩ������
                pc14_9 = DbInput_Lx4Item3SG.Value; //ʩ������ر�׼ֵ��kN/m2��
                double weightSPJ = 0.165 / pc14_2; //ˮƽ������
                double[] weightJSB1 = new double[] { 0.148, 0.168, 0.184, 0.195 };
                double weightJSB = (weightJSB1[Cbx_Lx4Item3JSB.SelectedIndex]) / pc14_1; //���ְ�����
                double[] pc14_1weight1 = new double[] { 0.06, 0.04 };
                double pc14_1weight2 = pc14_1weight1[Cbx_Lx4Item3JGJ.SelectedIndex]; //�ӹ̼����أ����м���
                //LX4tabItem4
                string pc15_1, pc15_2, pc15_5;
                double pc15_3, pc15_4, pc15_6, pc15_7, pc15_8, pc15_9;
                pc15_1 = Rdo_Lx4Item4QF.Text ; //ȫ���ǽ
                pc15_2 = Rdo_Lx4Item4CK.Text ; //��������ܺͿ���ǽ
                pc15_3 = System.Convert.ToDouble(Tb_Lx4Item4YFMJ.Text); //ӭ�����Aw
                pc15_4 = DbIput_Lx4Item4DFMJ.Value; //�������An
                pc15_5 = Cb_Lx4Item4DJTLX.Text; //�ػ�������
                pc15_6 = System.Convert.ToDouble ( Tb_Lx4Item4DJCZL.Text); //�ػ���������׼ֵ��N/mm2��
                pc15_7 = DbIput_Lx4Item4DBC.Value; //��峤a
                pc15_8 = DbIput_Lx4Item4DBK.Value; //����b
                pc15_9 = DbInput_Lx4Item4TZXS.Value ;  //�ػ�����������ϵ��
                if (Rdo_Lx4Item4QF.Checked) //ѡ��ȫ���ǽ��ʱ������s��Ϊ��1.2An/Aw��1.0
                { 
                    ��s = 1.2 * pc15_4 / pc15_3 * 1.0; 
                }
                else if (Rdo_Lx4Item4CK.Checked) //ѡ����������ܺͿ���ǽ��ʱ������s��Ϊ��1.2An/Aw��1.3
                { 
                    ��s = 1.2 * pc15_4 / pc15_3 * 1.0; 
                }
                //�������
                //һ�����ּܺ��ر�׼ֵ
                double NG1,NG2,NG,SumNQ,SumWk;
                NG1 = weightMF + 0.080 + weightJSB + 0.012 + 0.017 + weightSPJ; //���ּܽṹ�����ܼ�����
                NG2 = pc14_1weight2 + pc14_5 + pc14_6; //���ּܸ�������=�ӹ̼�����+��ȫ������+��������
                NG = NG1 + NG2;
                SumNQ = (pc12_6 / 1000) * (pc12_5 / 1000) * pc14_9; //����ر�׼ֵ
                SumWk = ��z * ��s * pc6_4;
                //�������˵��ȶ��Լ���
                double SumN1, SumQk, SumN2, maxN, Sum��1=0,SumNd;
                SumN1 = 1.2 * NG * pc12_7 + 1.4 * SumNQ; //������һ��żܵ����������ֵ���㹫ʽ(����Ϸ����)
                SumQk = SumWk * pc12_6;
                SumN2 = 1.2 * NG * pc12_7 + 0.9 * 1.4 * (SumNQ + 2 * SumQk * (pc13_3) * (pc13_3) / 10 / b);
                maxN = System.Math.Max(SumN1, SumN2);
                double ��1 = 0;
                if (mfID == 2) {��1 = Math.Round((pc15_9 * h0) /(10* i1),0); }
                else {  ��1 = Math.Round((3 * pc15_9 * h0 ) / (10*i1), 0); }
                if (��1 >250){ Sum��1 =7320/(��1*��1); }
                else
                {
                    int ��y1 = Convert.ToInt32(��1 / 10);//�ڦ�y1��
                    int ��x1 = Convert.ToInt32(��1 % 10);// �ڦ�x1��
                    Sum��1 = ��Array[��y1, ��x1];
                }
                SumNd = Sum��1 * A * 205/10;
                string ComparerNdN = ""; //���˵��ȶ���
                if (maxN < SumNd)
                { ComparerNdN = "N < Nd������Ҫ��";}
                else if (maxN > SumNd)
                {ComparerNdN = "N > Nd��������Ҫ��";}
                //����������߶ȵļ���
                double SumHd,SumHdw,SumHs;
                SumHd = (SumNd - 1.4 * SumNQ) / (1.2 * NG);
                SumHdw = (SumNd - 0.85 * 1.4 * (SumNQ + 2 * SumQk * pc13_3 * 2 / 10 / b)) / (1.2 * NG);
                SumHs = System.Math.Min (SumHd ,SumHdw);
                string ComparerHsH = ""; //���ּܴ���߶ȵļ���
                if (pc12_7 < SumHs)
                { ComparerHsH = "H��HS������Ҫ��";}
                else if (pc12_7 > SumHs)
                {ComparerHsH = "H>HS��������Ҫ��"; }
                //�塢���˵ĵػ�����������
                double SumA,SumP,SumFg;
                SumA = pc15_7 * pc15_8;
                SumP = maxN / SumA/1000;
                SumFg = pc15_9 * pc15_6;
                string ComparerFgP = ""; //���˵ĵػ��������ļ��� 
                if (SumP <= SumFg){ ComparerFgP = "P��fg ������Ҫ��"; }
                else if (SumP > SumFg){ ComparerFgP = "P>fg ������Ҫ��"; }
                #region һ �� �� �� ������ת��
                NG1 = Convert.ToDouble(NG1.ToString("f3"));
                NG2 = Convert.ToDouble(NG2.ToString("f3"));
                NG = Convert.ToDouble(NG.ToString("f3"));
                SumNQ = Convert.ToDouble(SumNQ.ToString("f3"));
                SumWk = Convert.ToDouble(SumWk.ToString("f3"));
                SumN1 = Convert.ToDouble(SumN1.ToString("f3"));
                SumQk = Convert.ToDouble(SumQk.ToString("f3"));
                SumN2 = Convert.ToDouble(SumN2.ToString("f3"));
                maxN = Convert.ToDouble(maxN.ToString("f3"));
                Sum��1 = Convert.ToDouble(Sum��1.ToString("f3"));
                SumNd = Convert.ToDouble(SumNd.ToString("f3"));
                SumHd = Convert.ToDouble(SumHd.ToString("f3"));
                SumHdw = Convert.ToDouble(SumHdw.ToString("f3"));
                SumHs = Convert.ToDouble(SumHs.ToString("f3"));

                SumA = Convert.ToDouble(SumA.ToString("f3"));
                SumP = Convert.ToDouble(SumP.ToString("f3"));
                SumFg = Convert.ToDouble(SumFg.ToString("f3"));

                #endregion
                //�ġ���ǽ���ļ���
                string ComparerLQJ = ""; //��ǽ���ļ���
                double SumNw = 1.4 * SumWk * pc13_3 * pc13_8;
                double SumNc = SumNw + 3.0;
                #region �� ������ת��
                

                SumNw = Convert.ToDouble(SumNw.ToString("f3"));
                SumNc = Convert.ToDouble(SumNc.ToString("f3"));
                #endregion
                if (Cbx_Lx4Item2LJFS.Text == "�ۼ�����")//���ѡ�пۼ����ӣ��õ�һ��obj
                {
                    itemtext = "��ʽ�ֹܽ��ּ�(�ۼ�����)";
                    double ��2 = pc13_1 / pc13_2;
                    double Sum��2 = 0;
                    if (��2 >= 250)
                    { Sum��2 = 7320 / (��2 * ��2); }
                    else
                    {
                        int ��y2 = Convert.ToInt32(��2 / 10);
                        int ��x2 = Convert.ToInt32(��2 % 10);
                        Sum��2 = ��Array[��y2, ��x2];
                    }
                    double SumNf = 0.85 * Sum��2 * A1 * 205/10;
                    SumNf = Convert.ToDouble(SumNf.ToString("f3"));

                    double Rc=0;
                    if (Rdo_Lx4Item2D.Checked) { Rc = pc12_8; }
                    else if (Rdo_Lx4Item2S.Checked) { Rc = pc12_9; }
                    if ((SumNc <= SumNf) && (SumNw <= Rc))
                    { ComparerLQJ = "Nc��Nf  �� Nw��Rc������Ҫ��"; }
                    else if ((SumNc > SumNf) | (SumNw >= Rc))
                    { ComparerLQJ = "Nc>Nf  �� Nw��Rc��������Ҫ��"; }
                    obj = new object[] {k, MF, weightMF, h0, h1, h2, b, b1, r1, r2, r3, r4, i1, I2 , A, A1,
                                                        pc12_5,  pc12_6,  pc12_7,  pc12_5,  pc12_8,  pc12_9,
                                                        pc13_1, pc13_2, pc13_3, pc13_4, pc13_7,pc13_8, 
                                                         pc14_1, pc14_2, weightSPJ, pc14_3, weightJSB, NG1, pc14_4, pc14_5, pc14_6, NG2, NG,  pc14_7, pc14_8, pc14_9,
                                                         pc6_1, pc6_2, pc6_4, pc7_1, ��z, 
                                                         ��s, pc15_5, pc15_6, pc15_7, pc15_8, pc15_9,
                                                        SumNQ, SumN1 ,SumWk, SumQk, SumN2, maxN, Sum��1, SumNd, ComparerNdN, 
                                                        SumHd, SumHdw, SumHs, ComparerHsH,
                                                         SumA, SumP, SumFg, ComparerFgP,
                                                         SumNw, SumNc,Sum��2, SumNf, ComparerLQJ};

                }
                else if (Cbx_Lx4Item2LJFS.Text == "��������")//���ѡ�к������ӣ��õ�һ��obj
                {
                    itemtext = "��ʽ�ֹܽ��ּ�(��������)";
                    if ( SumNc <=pc13_7 ){ComparerLQJ = "Nc��[ft]�� ����Ҫ��";}
                    else if ( SumNc > pc13_7){ComparerLQJ = "Nc>[ft]��������Ҫ��";}
                    obj = new object[] {k, MF, weightMF, h0, h1, h2, b, b1, r1, r2, r3, r4, i1, I2 , A, A1,
                                                        pc12_5,  pc12_6,  pc12_7,  pc12_5,  pc12_8,  pc12_9,
                                                        pc13_1, pc13_2, pc13_3, pc13_4, pc13_7,pc13_8, 
                                                         pc14_1, pc14_2, weightSPJ, pc14_3, weightJSB, NG1, pc14_4, pc14_5, pc14_6, NG2, NG,  pc14_7, pc14_8, pc14_9,
                                                         pc6_1, pc6_2, pc6_4, pc7_1, ��z, 
                                                         ��s, pc15_5, pc15_6, pc15_7, pc15_8, pc15_9,
                                                        SumNQ, SumN1 ,SumWk, SumQk, SumN2, maxN, Sum��1, SumNd, ComparerNdN, 
                                                        SumHd, SumHdw, SumHs, ComparerHsH,
                                                         SumA, SumP, SumFg, ComparerFgP,
                                                         SumNw, SumNc, ComparerLQJ};
                }
               

            }
            
            #endregion

            #region  5���ʽ���ּ�
            else if (CbxScaffoldType.SelectedIndex == 4) //5���ʽ���ּ�
            {
                itemtext = "���ʽ���ּ�";
                double[] Gkzg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//�����ݾ�
                double Gkzg = Gkzg1[Cbx_Lx5Item1ZJ.SelectedIndex];
                double[] Gkhg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//���˺��
                double Gkhg = Gkhg1[Cbx_Lx5Item1HJ.SelectedIndex];
                double[] Gkjhg1 = new double[] { 0.0437, 0.0552, 0.0685, 0.0816 };//���˸ֹ�����
                double Gkjhg = Gkjhg1[Cbx_Lx5Item1JHG.SelectedIndex];
                double[] Gkl1 = new double[] { 0.0705, 0.1019, 0.1334, 0.1648 };//���˸ֹ�����
                double Gkl = Gkl1[Cbx_Lx5Item1LGG.SelectedIndex];
                double[] Gkl2 = new double[] { 1.2, 1.8, 2.4, 3.0 };//������������ѡ��,�õ����ؼ�������ֵ
                double Gkl3 = Gkl1[Cbx_Lx5Item1LGG.SelectedIndex];
                double[] Gkwg1 = new double[] { 0.0633, 0.0703, 0.0866, 0.0930, 0.1004 };//��б�˸ֹ�����
                double Gkwg = Gkwg1[Cbx_Lx5Item1WXG.SelectedIndex];
                double[] Gksg1 = new double[] { 0.0589, 0.0676, 0.0873 };//ˮƽб�˸ֹ�����
                double Gksg = Gksg1[Cbx_Lx5Item1SPX.SelectedIndex];
                double[] Gklg1 = new double[] { 0.0633, 0.0703, 0.0866, 0.0930, 0.1004 };//�ȵ�б�˸ֹ�����
                double Gklg = Gklg1[Cbx_Lx5Item1LDX.SelectedIndex];
                //һ�������˵ļ���:
                double sum10Hq1, sum10Hq2, sum10HMmax, sum10H��, sum10HVmax, sum10HVmin;
                string compareH�� = "", compareHVmaxVmin = "", compareH��db = "";
                sum10Hq1 = 1.2 * (Gkhg / pc16_4 + 0.35 * pc16_3 / (pc16_10 + 1)) + 1.4 * pc5_3 * pc16_3 / (pc16_10 + 1);
                sum10Hq2 = Gkhg / pc16_4 + 0.350 * pc16_3 / (pc16_10 + 1) + pc5_3 * pc16_3 / (pc16_10 + 1);
                sum10HMmax = sum10Hq1 * Math.Pow(pc16_4, 2) / 8;
                sum10H�� = sum10HMmax * Math.Pow(10, 6) / 5080;
                if (sum10H�� <= 205) { compareH�� = "����Ҫ��"; }
                else { compareH�� = "������Ҫ��"; }
                sum10HVmax = (5 * sum10Hq2 * Math.Pow(pc16_4 * 1000, 4) / (384 * 205 * 1219))/100000;
                sum10HVmin = Math.Min(pc16_4*1000/150,10);
                if (sum10HVmax <= sum10HVmin)
                { compareHVmaxVmin = "����Ҫ��"; }
                else
                { compareHVmaxVmin = "������Ҫ��"; }
                double sum10HR1 = sum10Hq1 * pc16_4 / 2;
                double sum10HR2 = sum10Hq2 * pc16_4 / 2;
                double sum10H��db = sum10Hq1 * pc16_4 / 2;
                if (sum10H��db <= 25)
                { compareH��db = "����Ҫ��"; }
                else
                { compareH��db = "������Ҫ��"; }
                #region һ ����ת��
                sum10Hq1 = Convert.ToDouble(sum10Hq1.ToString("f3"));
                sum10Hq2 = Convert.ToDouble(sum10Hq2.ToString("f3"));
                sum10HMmax = Convert.ToDouble(sum10HMmax.ToString("f3"));
                sum10H�� = Convert.ToDouble(sum10H��.ToString("f3"));
                sum10HVmax = Convert.ToDouble(sum10HVmax.ToString("f3"));
                sum10HVmin = Convert.ToDouble(sum10HVmin.ToString("f3"));

                #endregion
                //�������˼���
                double sum10Jq1, sum10Jq2, sum10JMmax, sum10J��, sum10JVmax, sum10JVmin, sum10JR1, sum10JR2, sum10J��db;
                string compareJ��="",compareJVmaxVmin="",compareJ��db="";
                sum10Jq1=1.2*(Gkjhg/pc16_4+0.350*pc16_3/(pc16_10+1))+1.4*pc5_3*pc16_3/(pc16_10+1);
                sum10Jq2=Gkjhg/pc16_4+0.350*pc16_3/(pc16_10+1)+pc5_3*pc16_3/(pc16_10+1);
                sum10JMmax = sum10Jq1 * Math.Pow(pc16_4, 2) / 8;
                sum10J�� = sum10JMmax * 1000000 / 5080;
                if (sum10J�� <= 205)
                { compareJ�� = "����Ҫ��"; }
                else
                { compareJ�� = "������Ҫ��"; }
                sum10JVmax = (5 * sum10Jq2 * Math.Pow((pc16_4 * 1000), 4) / (384 * 205 * 1219))/100000;
                sum10JVmin = Math.Min(pc16_4*1000/150,10);
                if (sum10JVmax <= sum10JVmin)
                { compareJVmaxVmin = "����Ҫ��"; }
                else
                { compareJVmaxVmin = "������Ҫ��"; }
                sum10JR1 = sum10Jq1 * pc16_4 / 2;
                sum10JR2 = sum10Jq2 * pc16_4 / 2;
                sum10J��db = sum10JR1;
                if (sum10J��db <= 25)
                { compareJ��db = "����Ҫ��"; }
                else
                { compareJ��db = "������Ҫ��"; }
                #region �� ����ת��
                sum10Jq1 = Convert.ToDouble(sum10Jq1.ToString("f3"));
                sum10Jq2 = Convert.ToDouble(sum10Jq2.ToString("f3"));
                sum10JMmax = Convert.ToDouble(sum10JMmax.ToString("f3"));
                sum10J�� = Convert.ToDouble(sum10J��.ToString("f3"));
                sum10JVmax = Convert.ToDouble(sum10JVmax.ToString("f3"));
                sum10JVmin = Convert.ToDouble(sum10JVmin.ToString("f3"));
                sum10JR1 = Convert.ToDouble(sum10JR1.ToString("f3"));
                sum10JR2 = Convert.ToDouble(sum10JR2.ToString("f3"));
                sum10J��db = Convert.ToDouble(sum10J��db.ToString("f3"));


                #endregion
                //���������˼���
                double sum10Zq1, sum10Zq2, sum10Z��db1=0, sum10Z��db2=0;
                string str10Z�� = "", str10Z��db1 = "", compareZ�� = "", compareZ��db1 = "", compareZ��db2 = "";
                sum10Zq1 = 1.2 * Gkzg / pc16_3;
                sum10Zq2 = Gkzg / pc16_3;
                if (Cbx_Lx5Item1DKJ.Text=="2")
                {
                    double temp = (0.858 * pc16_3 / 3 + sum10Zq1 * Math.Pow(pc16_3, 2) / 4 - sum10Zq1 * pc16_3/8)*1000000/5080;//
                    str10Z�� = "Mmax/W= F1��la /3+q��la 2/4- q��la /8= " + "0.858��" + pc16_3.ToString() + "/3+" + sum10Zq1.ToString() + "��" + pc16_3.ToString() + "2/4-" + sum10Zq1.ToString() + "��" + pc16_3.ToString() + "/8��1000000/5080=" + temp.ToString() + "N/mm2��[f]=205N/mm2";
                    if (temp <= 205)
                    { compareZ�� = "����Ҫ��"; }
                    else
                    { compareZ�� = "������Ҫ��"; }
                    sum10Z��db1 = 0.858 + sum10Zq1 * pc16_3 / 2;
                    if (sum10Z��db1 <= 25)
                    { compareZ��db1 = "����Ҫ��"; }
                    else
                    { compareZ��db1 = "������Ҫ��"; }


                    str10Z��db1 = "F1+ q��la /2= 0.858+ " + sum10Zq1.ToString()+ "��"+pc16_3.ToString()+"/2="+sum10Z��db1.ToString()+"kN��[��]=25kN";
                    sum10Z��db2 = 2 * sum10Z��db1 + sum10H��db;
                    if (sum10Z��db2 <= 60)
                    { compareZ��db2 = "����Ҫ��"; }
                    else
                    { compareZ��db2 = "������Ҫ��"; }
                }
                else if (Cbx_Lx5Item1DKJ.Text == "1")
                {
                    double temp = (0.858 * pc16_3 / 4 + sum10Zq1 * Math.Pow(pc16_3, 2) / 4)*1000000/5080;//
                    if (temp <= 205)
                    { compareZ�� = "����Ҫ��"; }
                    else
                    { compareZ�� = "������Ҫ��"; }
                    str10Z�� = "Mmax/W= F1��la /4+q��la 2/4= " + "0.858��" + pc16_3.ToString() + "/4+" + sum10Zq1.ToString() + "��" + pc16_3.ToString() + "2/4��1000000/5080=" + temp.ToString() + "N/mm2��[f]=205N/mm2";
                    sum10Z��db1 = 0.858/2 + sum10Zq1 * pc16_3 / 2;
                    if (sum10Z��db1 <= 25)
                    { compareZ��db1 = "����Ҫ��"; }
                    else
                    { compareZ��db1 = "������Ҫ��"; }
                    str10Z��db1 = "F1/2+ q��la /2= 0.858/2+ " + sum10Zq1.ToString() + "��" + pc16_3.ToString() + "/2=" + sum10Z��db1.ToString() + "kN��[��]=25kN";
                    sum10Z��db2 = 2 * sum10Z��db1 + sum10H��db;
                    if (sum10Z��db2 <= 60)
                    { compareZ��db2 = "����Ҫ��"; }
                    else
                    { compareZ��db2 = "������Ҫ��"; }
                }
                #region �� ����ת��
                sum10Zq1 = Convert.ToDouble(sum10Zq1.ToString("f3"));
                sum10Zq2 = Convert.ToDouble(sum10Zq2.ToString("f3"));
                sum10Z��db1 = Convert.ToDouble(sum10Z��db1.ToString("f3"));
                sum10Z��db2 = Convert.ToDouble(sum10Z��db2.ToString("f3"));
                #endregion
                //�ġ����ؼ���
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
                ��z = FengYaXiShu(DbInput_Lx5Item2GD.Value, Cb_Item7DMCCD.SelectedIndex);//��ѹ�߶ȱ仯ϵ��
                sum10Wk = 0.7 * pc6_4 * ��z * DbInput_Item6Uz.Value;
                #region �� ����ת��
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
                //�岻���Ƿ����ʱ,���˵��ȶ��Լ���
                string strWk�� = "", compareWKNo�� = "";
                double pcWk = 0, Wk�� = 0, WkNo�� = 0, sum10No��=0;
                if (Cbx_Lx5Item1LGJXG.SelectedIndex == 0)//���˼���б��
                {
                    //l0ȡ���ࣻ��ϸ�Ȧ�=l0/i=����(@pc16_1@)��1000/15.800=113.924 ��@Wk��@��
                    strWk��="����h";
                    pcWk = pc16_1;
                    Wk�� = pcWk * 1000 / 15.800;
                }
                else if (Cbx_Lx5Item1LGJXG.SelectedIndex == 1)//���˼���б��
                {
                    strWk�� = "��ǽ��������";
                    pcWk = pc16_1;
                    Wk�� = pcWk * 1000 / 15.800;
                }
                if (Wk�� > 250)
                {
                    WkNo�� = 7320 / (Wk�� * Wk��);
                }
                else
                {
                    int Wk��y1 = Convert.ToInt32(Wk�� / 10);//�ڦ�y1��
                    int Wk��x1 = Convert.ToInt32(Wk�� % 10);// �ڦ�x1��
                    WkNo�� = ��Array[Wk��y1, Wk��x1]; //��Array����Ϊȫ�ֱ���,�μ�����B.0.6������ѹ�������ȶ�ϵ����(Q235��)��
                }
                sum10No�� = sum10N1 / (WkNo�� * 4.89);
                if (sum10No�� <= 205)
                { compareWKNo�� = "����Ҫ��"; }
                else
                { compareWKNo�� = "������Ҫ��"; }
                #region �� ����ת��
                Wk�� = Convert.ToDouble(Wk��.ToString("f3"));
                WkNo�� = Convert.ToDouble(WkNo��.ToString("f3"));
                sum10No�� = Convert.ToDouble(sum10No��.ToString("f3"));
                

                #endregion
                //�忼�Ƿ����ʱ,���˵��ȶ��Լ���
                double sum10Mw , sum10NE,sum10Yes��;
                string compareWKYes�� = "";
                sum10Mw = 1.4 * sum10Wk * pc16_3 * Math.Pow(pcWk, 2) / 10;
                sum10NE = 3.14162 * 205 * 489 / Math.Pow(Wk��, 2);
                sum10Yes�� = sum10Nw1 / (WkNo�� * 4.89) + (0.9 * 1.0 * sum10Mw) / (1.15 * 5.08 * (1 - 0.8 * sum10Nw1 / sum10NE));
                if (sum10Yes�� <= 205)
                { compareWKYes�� = "����Ҫ��"; }
                else
                { compareWKYes�� = "������Ҫ��"; }
                #region �� ����ת��
                sum10Mw = Convert.ToDouble(sum10Mw.ToString("f3"));
                sum10NE = Convert.ToDouble(sum10NE.ToString("f3"));
                sum10Yes�� = Convert.ToDouble(sum10Yes��.ToString("f3"));

                #endregion
                //������ǽ������������
                double sum10Nc, wkLqj��, sum10NcN0Ac;
                string strNcN0Ac = "", compareNcN0Ac = "", strNcN0="",compareNcN0 ="";
                sum10Nc = 1.4 * sum10Wk * pc17_1 * pc17_2;
                double wkLqj�� = pc17_3 * pc17_4;
                if (wkLqj�� > 250)
                {
                    wkLqj�� = 7320 / (Wk�� * Wk��);
                }
                else
                {
                    int wkLqj��y1 = Convert.ToInt32(wkLqj�� / 10);//�ڦ�y1��
                    int wkLqj��x1 = Convert.ToInt32(wkLqj�� % 10);// �ڦ�x1��
                    wkLqj�� = ��Array[wkLqj��y1, wkLqj��x1]; //��Array����Ϊȫ�ֱ���,�μ�����B.0.6������ѹ�������ȶ�ϵ����(Q235��)��
                }
                sum10NcN0Ac = (sum10Nc + 3) * 1000 / (wkLqj�� * pc17_5);
                if (Cbx_Lx5Item2LQJ.SelectedIndex == 0)
                {
                    strNcN0Ac = "[f]=205";
                    if (sum10NcN0Ac <= 205) { compareNcN0Ac = "����Ҫ��"; }
                    else { compareNcN0Ac = "������Ҫ��"; }
                    double  sum10NcN0,wkXs;
                    int kjChoice =0;
                    if(Rdo_Lx5Item2D.Checked ){kjChoice =8;}
                    else if(Rdo_Lx5Item2D.Checked ) {kjChoice =12;}
                    sum10NcN0 = sum10Nc+3;
                    wkXs = pc17_9 * kjChoice;
                    if (sum10NcN0 <= wkXs) { compareNcN0 = "����Ҫ��"; }
                    else {compareNcN0 = "����Ҫ��";}
                    strNcN0 = "�ۼ���������������:Nc+N0=" + sum10NcN0.ToString() + " kN��" + pc17_9.ToString() + "��" + kjChoice.ToString()+ "="+wkXs.ToString()+"kN";
                }
                else if (Cbx_Lx5Item2LQJ.SelectedIndex == 1)
                {
                    strNcN0Ac = "[ft]=�ԽӺ���Ŀ�����ѹǿ��" + pc17_10.ToString();
                    if (sum10NcN0Ac <= pc17_10) { compareNcN0Ac = "����Ҫ��"; }
                    else { compareNcN0Ac = "������Ҫ��"; }
                }
                else if (Cbx_Lx5Item2LQJ.SelectedIndex == 2)
                {
                    strNcN0Ac = "[fy]=���Ӹֽ�Ŀ���ǿ��" + pc17_11.ToString();
                    if (sum10NcN0Ac <= pc17_11) { compareNcN0Ac = "����Ҫ��"; }
                    else { compareNcN0Ac = "������Ҫ��"; }
                }
                #region �� ����ת��
                sum10Nc = Convert.ToDouble(sum10Nc.ToString("f3"));
                wkLqj�� = Convert.ToDouble(wkLqj��.ToString("f3"));
                sum10NcN0Ac = Convert.ToDouble(sum10NcN0Ac.ToString("f3"));
                wkLqj�� = Convert.ToDouble(wkLqj��.ToString("f3"));
                //sum10NcN0 = Convert.ToDouble(sum10NcN0.ToString("f3"));
                //wkXs = Convert.ToDouble(wkXs.ToString("f3"));

                #endregion
                //�ߡ����ּܴ���߶�����:
                double   sum10h ;
                string compareSum10h="";
                sum10h = sum10Nw1-1.2* sum10NG2k -0.9*1.4* NQ1k* pc16_2/1.2/ sum10NG1k;
                sum10h = Convert.ToDouble(sum10h.ToString("f3"));
                if (sum10h > pc16_2)
                { compareSum10h = "����Ҫ��"; }
                else
                { compareSum10h = "������Ҫ��"; }
                //�ˡ��ɵ���������������:
                string  compareNN0="";
                if (sum10N1 <= pc16_14)
                { compareNN0 = "����Ҫ��"; }
                else
                { compareNN0 = "������Ҫ��"; }
                //�š����˵ĵػ�����������:
                double sum10Ag,sum10fg;
                string compareWkfg="";
                sum10Ag= pc9_3* pc16_3;
                sum10fg= pc9_2* pc9_5;
                sum10Ag = Convert.ToDouble(sum10Ag.ToString("f3"));
                sum10fg = Convert.ToDouble(sum10fg.ToString("f3"));
                if ((sum10N1 / sum10Ag) <= sum10fg)
                { compareWkfg = "����Ҫ��"; }
                else
                { compareWkfg = "������Ҫ��"; }
                obj = new object[] {pc5_1,pc5_2,pc5_3,pc5_4,
                                    pc6_1,pc6_2,pc6_4, DbInput_Item6Uz.Value,pc7_1,��z,
                                    pc9_1,pc9_2,pc9_3,pc9_4,pc9_5,Cb_Item9DJLX.Text,
                                    pc16_1,  pc16_2,  pc16_3,  pc16_4,  pc16_5,  pc16_6,  pc16_7,  pc16_8,  pc16_9,  pc16_10,  pc16_11,  pc16_12,  pc16_13,  pc16_14,  pc16_15,  pc16_1, 
                                    pc17_1, pc17_2, pc17_3, pc17_4, pc17_5, pc17_6,  pc17_9, pc17_10, pc17_11, 
                                    Gkzg, Gkhg, Gkjhg, Gkl,Gkl3, Gkwg, Gksg, Gklg,
                                    sum10Hq1, sum10Hq2, sum10HMmax, sum10H��, sum10HVmax, sum10HVmin,compareH��, compareHVmaxVmin, compareH��db,sum10HR1,sum10HR2,sum10H��db,
                                    sum10Jq1, sum10Jq2, sum10JMmax, sum10J��, sum10JVmax, sum10JVmin, sum10JR1, sum10JR2, sum10J��db,compareJ��,compareJVmaxVmin,compareJ��db,
                                    sum10Zq1, sum10Zq2, sum10Z��db1, sum10Z��db2,str10Z��, str10Z��db1, compareZ��, compareZ��db1, compareZ��db2 ,
                                    NG1k1, NG1k2, NG1k3, NG1k4, NG1k5, NG1k6, NG1k7, sum10NG1k,NG2k1, NG2k2, NG2k3, sum10NG2k,NQ1k, sum10Nw1, sum10Nw2, sum10N1, sum10N2, sum10Wk,
                                    pcWk, Wk��, WkNo��, sum10No��, sum10Mw , sum10NE,sum10Yes��,strWk��, compareWKNo��, compareWKYes��,
                                    sum10Nc, wkLqj��, sum10NcN0Ac, wkLqj��,strNcN0Ac, compareNcN0Ac, strNcN0,compareNcN0,
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

        private void Cbx_Lx4Item2LJFS_SelectedIndexChanged(object sender, EventArgs e)//4��ǽ��LX4tabItem2����ǽ�����ӷ�ʽ
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

        #region  LX4tabItem2�ż���������׼ֵ��
        private void Rdo_Lx4Item1MF1_CheckedChanged(object sender, EventArgs e)//4��ǽ��LX4tabItem2��MF1219(1)
        {
            if (Rdo_Lx4Item1MF1.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1980 ";
                weightMF = 0.116F;
                mfID = 0;
            }
        }
        private void Rdo_Lx4Item1MF2_CheckedChanged(object sender, EventArgs e)//4��ǽ��LX4tabItem2��MF1219(2)
        {
            if (Rdo_Lx4Item1MF2.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1950 ";
                weightMF = 0.142F;
                mfID = 1;
            }
        }
        private void Rdo_Lx4Item1MF3_CheckedChanged(object sender, EventArgs e)//4��ǽ��LX4tabItem2��MF0817
        {
            if (Rdo_Lx4Item1MF3.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1800 ";
                weightMF = 0.087F;
                mfID = 2;
            }
        }
        private void Rdo_Lx4Item1MF4_CheckedChanged(object sender, EventArgs e)//4��ǽ��LX4tabItem2��MF1017
        {
            if (Rdo_Lx4Item1MF4.Checked)
            {
                Tb_Lx4Item1BJ.Text = " 1800 ";
                weightMF = 0.094F;
                mfID = 3;
            }
        }
        #endregion

        private void Cb_Lx4Item4DJTLX_SelectedIndexChanged(object sender, EventArgs e) //4���������ϵ��+�ػ���������LX4tabItem4
        {
            switch (Cb_Lx4Item4DJTLX.SelectedIndex)
            {
                case 0: Tb_Lx4Item4DJCZL.Text = "200"; break; //��ʯ
                case 1: Tb_Lx4Item4DJCZL.Text = "200"; break; //��ʯ��
                case 2: Tb_Lx4Item4DJCZL.Text = "140";  break; // ɰ��
                case 3: Tb_Lx4Item4DJCZL.Text = "100"; break; //����
                case 4: Tb_Lx4Item4DJCZL.Text = "80"; break; //������
                case 5: Tb_Lx4Item4DJCZL.Text = "120"; break; //��ճ��
                case 6: Tb_Lx4Item4DJCZL.Text = "120"; break; //ճ����
                case 7: Tb_Lx4Item4DJCZL.Text = "60"; break; //��������
            }
        }

        private void Btn_Lx4Item4Search1_Click(object sender, EventArgs e) //LX4tabItem4�еػ��������е�һ������ѯͼ����ť
        {
            FrmShowChart showchart = new FrmShowChart(Cb_Lx4Item4DJTLX.SelectedIndex);
            showchart.ShowDialog();
        }

        private void Btn_Lx4Item4Search2_Click(object sender, EventArgs e) //LX4tabItem4�еػ��������е�һ������ѯͼ����ť
        {
            FrmShowChart showchart = new FrmShowChart(9);
            showchart.ShowDialog();
        }

        private void Btn_Item9SearchChart_Click(object sender, EventArgs e)//LXtabItem9�еػ��������е�һ������ѯͼ����ť
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
            #region ÿ���������ر�׼ֵ,���ú���ErweiShuzu()
            double[,] gksArray = new double[,] { { 0.1538, 0.1667, 0.1796, 0.1882, 0.1925 }, 
                                                                        { 0.1426, 0.1543, 0.1660, 0.1739, 0.1778}, 
                                                                        {0.1336, 0.1444, 0.1552, 0.1324, 0.1660 }, 
                                                                        { 0.1202, 0.1295, 0.1389, 0.1451, 0.1482}, 
                                                                        {0.1134, 0.1221, 0.1307, 0.1365, 0.1394} };//˫������
            double[,] gkdArray = new double[,] { { 0.1642,0.1793,0.1945,0.2046,0.2097 }, 
                                                                        { 0.1530, 0.1670,	0.1809 ,0.1903, 0.1949 }, 
                                                                        {0.1440,0.1570,0.1701,0.1788 ,0.1831 }, 
                                                                        { 0.1305,0.1422 ,0.1538,	0.1615 ,0.1654 }, 
                                                                        {0.1238 ,0.1347 ,0.1456,	0.1529 ,0.1565 } };//��������
            double[] bjArray = new double[] { 1.20, 1.35, 1.50, 1.80, 2.00 };
            double[] zjArray = new double[] { 1.2, 1.5, 1.8, 2.0, 2.1 };
            double gk = 0;//ÿ���������ر�׼ֵ
            if (CbxScaffoldType.SelectedIndex == 0 || CbxScaffoldType.SelectedIndex == 1)//˫�Ž��ּ�
            { gk = ErweiShuzu(gksArray, zjArray, bjArray, DbInput_Item1LGZJ.Value, DbInput_Item1BJ.Value); }
            else if (CbxScaffoldType.SelectedIndex == 2)//���Ž��ּ�
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
                case 0: Tb_Item4JSBZZBZZ.Text = "0.3"; break; //��ѹ���ְ�
                case 1: Tb_Item4JSBZZBZZ.Text = "0.35"; break; //�񴮽��ְ�
                case 2: Tb_Item4JSBZZBZZ.Text = "0.35"; break; // ľ���ְ�
                case 3: Tb_Item4JSBZZBZZ.Text = "0.10"; break; //��Ž��ְ�
                
            }
        }

        private void Cb_Item4JBLB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (Cb_Item4JBLB.SelectedIndex)
            {
                case 0: Tb_Item4JBZZBZZ.Text = "0.16"; break; //��ѹ���ְ�
                case 1: Tb_Item4JBZZBZZ.Text = "0.17"; break; //�񴮽��ְ�
                case 2: Tb_Item4JBZZBZZ.Text = "0.17"; break; // ľ���ְ�
               
            }

        }


    }
}

