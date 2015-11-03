using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmScaffoldMaterialCalculate : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;

        public FrmScaffoldMaterialCalculate(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            //CbxType.SelectedIndex = 0;
            CbxScaffoldType.SelectedIndex = 0;
            Cb_MaterialJDCSZ.SelectedIndex = 0;
            //Cbx_Item3JDCSZ.SelectedIndex = 0;
        }

        private void CbxScaffoldType_SelectedIndexChanged(object sender, EventArgs e)//ѡ����ּ����ͺ���ʾ�Ĵ���
        {
            if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 1)
            {
                YLtabItem1.Visible = true;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = false;
                Cb_MaterialWCDHGJJ.SelectedIndex = 0;
                if (CbxScaffoldType.SelectedIndex == 0)
                {
                    YLtabItem1.Text = "˫�Ž��ּ����ϼ���";
                }
                else
                    YLtabItem1.Text = "���Ž��ּ����ϼ���";
            }
            else if (CbxScaffoldType.SelectedIndex == 2)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = true;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = false;
                Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//������ּܴ��貽��
                Cbx_Item2ZJ.SelectedIndex = 3;
                Cbx_Item2HJ.SelectedIndex = 3;
                Cbx_Item2LGG.SelectedIndex = Cbx_Item2WXG.SelectedIndex = Cbx_Item2SPX.SelectedIndex = Cbx_Item2LDX.SelectedIndex = Cbx_Item2LGD.SelectedIndex = Cbx_Item2JHG.SelectedIndex = 0;
            }
            else if (CbxScaffoldType.SelectedIndex == 3)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = true;
                YLtabItem4.Visible = false;
            }
            else if (CbxScaffoldType.SelectedIndex == 4)
            {
                YLtabItem1.Visible = false;
                YLtabItem2.Visible = false;
                YLtabItem3.Visible = false;
                YLtabItem4.Visible = true;
            }
        }

        private void Cb_MaterialJDCSZ_SelectedIndexChanged(object sender, EventArgs e)//YLtabItem1�����������á��������������ż�������ݾ�������������
        {
            if (Cb_MaterialJDCSZ.SelectedIndex == 1)
            {
                Lb_MaterialJDCJGLGZJ.Enabled = true;
                IntInput_MaterialJDCJGLGZJ.Enabled = true;
            }
            else 
            {
                Lb_MaterialJDCJGLGZJ.Enabled = false ;
                IntInput_MaterialJDCJGLGZJ.Enabled = false ;
            }
        }

        private void Cb_MaterialWCDHGJJ_SelectedIndexChanged_1(object sender, EventArgs e)//YLtabItem1�����˼��
        {
            switch (Cb_MaterialWCDHGJJ.SelectedIndex)
            {
                case 0: Tb_MaterialWCDHGQZ.Text = Convert.ToString(1); break;
                case 1: Tb_MaterialWCDHGQZ.Text = Convert.ToString(2); break;
            }
        }

        private void DbInput_Item2GD_ValueChanged(object sender, EventArgs e)
        {
            Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//������ּܴ��貽��
        }

        private void DbInput_Item2BJ_ValueChanged(object sender, EventArgs e)
        {
            Tb_Item2BS.Text = System.Convert.ToString(System.Convert.ToInt32((DbInput_Item2GD.Value / DbInput_Item2BJ.Value) + 1));//������ּܴ��貽��
        }

        private void Cbx_Item3JDCSZ_SelectedIndexChanged(object sender, EventArgs e)//YLtabItem3�����������á��������������ż���żܿ��������������
        {
            if (Cbx_Item3JDCSZ.SelectedIndex == 1)
            {
                Lb_Item3_ZDCJGMJKDS.Enabled = true;
                IntInput_Item3JDCJGMJKDS.Enabled = true;
            }
            else
            {
                Lb_Item3_ZDCJGMJKDS.Enabled = false;
                IntInput_Item3JDCJGMJKDS.Enabled = false;
            }
        }

        private void TB_Item4ZZBZZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            //�жϰ����ǲ���Ҫ��������͡�
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //С����Ĵ���
            if ((int)e.KeyChar == 46)                           //С����
            {
                if (TB_Item4ZZBZZ.Text.Length <= 0)
                    e.Handled = true;   //С���㲻���ڵ�һλ
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(TB_Item4ZZBZZ.Text, out oldf);
                    b2 = float.TryParse(TB_Item4ZZBZZ.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void Btn_YLSubmit_Click(object sender, EventArgs e)
        {
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            object[] obj = new object[] { };
            #region ��˫�Ž��ּ����ϼ���
            if (CbxScaffoldType.SelectedIndex == 0 | CbxScaffoldType.SelectedIndex == 1)
            {
                #region ��˫�Ž��ּ����ϼ����漰�Ĳ�������
                double Ly1_1, Ly1_2, Ly1_3, Ly1_4, Ly1_5, Ly1_6, Ly1_7, Ly1_9, Ly1_10, Ly1_11, Ly1_12;
                double LySum1 = 0, LySum2 = 0, LySum3 = 0, LySum4 = 0, LySum5 = 0, LySum6 = 0, LySum7 = 0, LySum8 = 0, LySum9 = 0;
                string Ly1_8;
                Ly1_1 = DbInput_MaterialDSGD.Value; //���ּܴ���߶�
                Ly1_2 = DbInput_MaterialDSCD.Value;  //���ּܴ��賤��
                Ly1_3 = DbInput_MaterialLGZJ.Value; //�����ݾ�la
                Ly1_4 = DbInput_MaterialLGHJ.Value; //���˺��lb
                Ly1_5 = DbInput_MaterialBJ.Value; //����h
                Ly1_6 = DbInput_MaterialLQJL.Value; //���ּ����ŵ���ǽ����
                Ly1_7 = System.Convert.ToInt16(Tb_MaterialWCDHGQZ.Text); //�����˼��ȡֵ
                Ly1_8 = Cb_MaterialJDCSZ.Text; //����������
                Ly1_9 = System.Convert.ToDouble(IntInput_MaterialJDCKYBJ.Value); //�����ſ�Խ������
                Ly1_10 = System.Convert.ToDouble(IntInput_MaterialJDCKYLGZJ.Value); //�����ſ�Խ�����ݾ���
                Ly1_11 = System.Convert.ToDouble(IntInput_MaterialJDCJGLGZJ.Value); //�����ż�������ݾ���
                Ly1_12 = DBIput_MaterialCLYLXS.Value; //��������ϵ��
                #endregion
                if (CbxScaffoldType.SelectedIndex == 0) //ѡ��˫�Ž��ּ����ϼ���
                {
                    itemtext = "˫�Ž��ּ����ϼ���";
                    #region // ˫�Ž��ּ����ϼ�����̣�
                    LySum1 = Ly1_12 * Ly1_2 / Ly1_3 * 2 * Ly1_1;//��ͬ�ڵ��Ž��ּ�
                    LySum2 = Ly1_12 * Ly1_1 / Ly1_5 * 2 * Ly1_7 * Ly1_2;//��ͬ�ڵ��Ž��ּ�
                    LySum3 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * (Ly1_4 + Ly1_6);
                    LySum4 = Ly1_12 * (Math.Pow((Ly1_10 * Ly1_10 + Ly1_9 * Ly1_9), 0.5) + 1) * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10;
                    LySum5 = Ly1_12 * (Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * 2 + LySum2 / Ly1_3);//��ͬ�ڵ��Ž��ּ�
                    LySum6 = Ly1_12 * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10 * 14;
                    LySum7 = Ly1_12 * (LySum1 + LySum2) / 5;
                    LySum8 = LySum1 + LySum2 + LySum3 + LySum4;
                    LySum9 = LySum8 * 3.97 / 1000;
                    #endregion
                }
                else if (CbxScaffoldType.SelectedIndex == 1) //ѡ���Ž��ּ����ϼ���
                {
                    itemtext = "���Ž��ּ����ϼ���";
                    #region // ���Ž��ּ����ϼ�����̣�
                    LySum1 = Ly1_12 * Ly1_2 / Ly1_3 * Ly1_1;//��ͬ��˫�Ž��ּ�
                    LySum2 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_7 * Ly1_2;//��ͬ��˫�Ž��ּ�
                    LySum3 = Ly1_12 * Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 * (Ly1_4 + Ly1_6);
                    LySum4 = Ly1_12 * (Math.Pow((Ly1_10 * Ly1_10 + Ly1_9 * Ly1_9), 0.5) + 1) * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10;
                    LySum5 = Ly1_12 * (Ly1_1 / Ly1_5 * Ly1_2 / Ly1_3 + LySum2 / Ly1_3);//��ͬ��˫�Ž��ּ�
                    LySum6 = Ly1_12 * Ly1_1 / Ly1_9 * Ly1_2 / Ly1_10 * 14;
                    LySum7 = Ly1_12 * (LySum1 + LySum2) / 5;
                    LySum8 = LySum1 + LySum2 + LySum3 + LySum4;
                    LySum9 = LySum8 * 3.97 / 1000;
                    #endregion
                }
                LySum1 = Math.Round(LySum1, 0);
                LySum2 = Math.Round(LySum2, 0);
                LySum3 = Math.Round(LySum3, 0);
                LySum4 = Math.Round(LySum4, 0);
                LySum5 = Math.Round(LySum5, 0);
                LySum6 = Math.Round(LySum6, 0);
                LySum7 = Math.Round(LySum7, 0);
                LySum8 = Math.Round(LySum8, 0);
                LySum9 = Math.Round(LySum9, 0);
                obj = new object[] { Ly1_1 , Ly1_2 , Ly1_3 , Ly1_4 , Ly1_5 , Ly1_6 , Ly1_7 , Ly1_8 , IntInput_MaterialJDCKYBJ.Value , IntInput_MaterialJDCKYLGZJ.Value ,IntInput_MaterialJDCJGLGZJ.Value, Ly1_12 ,
                                                        LySum1 , LySum2 ,  LySum3 ,  LySum4 ,  LySum5 ,  LySum6 ,  LySum7 ,  LySum8 ,  LySum9};
            }
            #endregion
            else if (CbxScaffoldType.SelectedIndex == 2) //ѡ�����ʽ���ּ����ϼ���
            {
                itemtext = "���ʽ���ּ����ϼ���";
                #region ���ʽ���ּ����ϼ�����ƵĲ�������
                double Ly2_1, Ly2_2, Ly2_3, Ly2_4, Ly2_5, Ly2_6;
                string Ly2_7, Ly2_8, Ly2_9, Ly2_10, Ly2_11;
                double Ly2Sum1 = 0, Ly2Sum2 = 0, Ly2Sum3 = 0, Ly2Sum4 = 0, Ly2Sum5 = 0, Ly2Sum6 = 0, Ly2Sum7 = 0, Ly2Sum8 = 0, Ly2Sum9 = 0, Ly2Sum10 = 0, Ly2Sum11 = 0, Ly2Sum12 = 0;
                Ly2_1 = DbInput_Item2GD.Value;//���ּܴ���߶�
                Ly2_2 = DbInput_Item2CD.Value;//���ּܴ��賤��
                Ly2_3 = DbInput_Item2BJ.Value;//����
                Ly2_4 = System.Convert.ToDouble(Tb_Item2BS.Text);//���ּܴ��貽��
                Ly2_5 = System.Convert.ToDouble(Cbx_Item2ZJ.Text);//�����ݾ�
                double[] Gkzg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };
                double Gkzg = Gkzg1[Cbx_Item2ZJ.SelectedIndex];
                Ly2_6 = System.Convert.ToDouble(Cbx_Item2HJ.Text);//���˺��
                double[] Gkhg1 = new double[] { 0.0132, 0.0247, 0.0363, 0.0478, 0.0593, 0.0708 };//���˺��
                double Gkhg = Gkhg1[Cbx_Item2HJ.SelectedIndex];

                double[] Gkjhg1 = new double[] { 0.0437, 0.0552, 0.0685, 0.0816 };//���˸ֹ�����
                double Gkjhg = Gkjhg1[Cbx_Item2JHG.SelectedIndex];

                Ly2_7 = Cbx_Item2LGG.Text;//���˸ֹ�����
                double[] Gkl1 = new double[] { 0.0705, 0.1019, 0.1334, 0.1648 };
                double Gkl = Gkl1[Cbx_Item2LGG.SelectedIndex ];
                double[] Gkl2 = new double[] { 1.2, 1.8, 2.4, 3.0 };
                double Gkl3 = Gkl1[Cbx_Item2LGG.SelectedIndex];
                Ly2_8 = Cbx_Item2WXG.Text;//��б�˸ֹ�����
                double[] Gkwg1 = new double[] {0.0633, 0.0703, 0.0866, 0.0930, 0.1004};
                double Gkwg = Gkwg1[Cbx_Item2WXG.SelectedIndex];
                Ly2_9 = Cbx_Item2SPX.Text;//ˮƽб�˸ֹ�����
                double[] Gksg1 = new double[] {0.0589, 0.0676, 0.0873};
                double Gksg = Gksg1[Cbx_Item2SPX.SelectedIndex];
                Ly2_10 = Cbx_Item2LDX.Text;//�ȵ�б�˸ֹ�����
                double[] Gklg1 = new double[] {0.0633, 0.0703, 0.0866, 0.0930, 0.1004};
                double Gklg = Gklg1[Cbx_Item2LDX.SelectedIndex];
                Ly2_11 = Cbx_Item2LGD.Text;//���˵�������
                double[] Gkdz1 = new double[] { 0.0582, 0.0712, 0.085};
                double Gkdz = Gkdz1[Cbx_Item2LDX.SelectedIndex];
                double Ly2_12, Ly2_13, Ly2_14, Ly2_15, Ly2_16, Ly2_17, Ly2_18, Ly2_19, Ly2_20;
                Ly2_12 = System.Convert.ToDouble(Cbx_Item2DKJ.Text);
                Ly2_13 = System.Convert.ToDouble(Cbx_Item2WXGBZ.Text);
                Ly2_14 = IntInput_Item2SPX.Value;
                Ly2_15 = IntInput_Item2LDX.Value;
                Ly2_16 = DbInput_Item2H1.Value;
                Ly2_17 = DbInput_Item2L1.Value;
                Ly2_18 = DbInput_Item2L0.Value;
                Ly2_19 = IntInput_Item2CS.Value;
                Ly2_20 = DbInput_Item2XS.Value;
                #endregion
                Ly2Sum1 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * 2 * Ly2_1 / Gkl3 * Gkl / 10;
                Ly2Sum2 = Ly2_20 * 2 * (Ly2_4 + Ly2_20) * Ly2_2 / Ly2_5 * Gkzg / 10;
                Ly2Sum3 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * Ly2_4 * Gkhg / 10;
                Ly2Sum4 = Ly2_20 * Ly2_2 / Ly2_5 * Ly2_12 * Ly2_4 * Gkjhg / 10;
                Ly2Sum5 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_13 * Ly2_4 * Gkwg / 10;
                Ly2Sum6 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_14 * Ly2_4 * Gksg / 10;
                Ly2Sum7 = Ly2_20 * Ly2_2 / Ly2_5 / Ly2_15 * Ly2_4 * Gklg / 10;
                Ly2Sum8 = Ly2_20 * (Ly2_2 / Ly2_5 + 1) * 2 * Gkdz / 10;
                Ly2Sum9 = Ly2_20 * Ly2_2 * Ly2_1 / Ly2_16 / Ly2_17 * Ly2_18 * 3.97 / 1000;
                Ly2Sum10 = Ly2_20 * Ly2_2 * Ly2_5 * Ly2_19;
                Ly2Sum11 = Ly2_20 * 2 * 0.18 * Ly2_2 * Ly2_19;
                Ly2Sum12 = Ly2_20 * Ly2_2 * Ly2_1;
      
                obj = new object[] { Ly2_1, Ly2_2, Ly2_3, Ly2_4, Ly2_5, Gkzg, Ly2_6, Gkhg, Gkjhg, Ly2_7, Gkl, Gkl3, Ly2_8, Gkwg, Ly2_9, Gksg, Ly2_10, Gklg, Ly2_11, Gkdz ,
                                                Ly2_12, Ly2_13, Ly2_14, Ly2_15, Ly2_16, Ly2_17, Ly2_18, Ly2_19, Ly2_20,
                                                 Ly2Sum1, Ly2Sum2, Ly2Sum3,Ly2Sum4, Ly2Sum5, Ly2Sum6, Ly2Sum7, Ly2Sum8, Ly2Sum9, Ly2Sum10, Ly2Sum11, Ly2Sum12, Cbx_Item2JHG.Text };
            }
            /*
             * ���ܣ���ʽ���ּ���������
             * ���ߣ��ֿ�
             * ���ڣ�2013-9-16
             */
            else if (CbxScaffoldType.SelectedIndex == 3)//ѡ����ʽ���ּ���������
            {
                itemtext = "��ʽ���ּ����ϼ���";
                #region ��ʽ���ּ����������漰�Ĳ�������
                double Ly3_1, Ly3_2, Ly3_3, Ly3_4, Ly3_5, Ly3_7, Ly3_8, Ly3_9, Ly3_10;
                string Ly3_6;
                double Ly3Sum1 = 0, Ly3Sum2 = 0, Ly3Sum3 = 0, Ly3Sum4 = 0, Ly3Sum5 = 0, Ly3Sum6 = 0, Ly3Sum7 = 0;
                Ly3_1 = DbInput_Item3GD.Value;//���ּܴ���߶�               
                Ly3_2 = DbInput_Item3CD.Value;//���ּܴ��賤��
                Ly3_3 = DbInput_Item3MJBJ.Value;//�żܲ���
                Ly3_4 = DbInput_Item3MJKD.Value;//�żܿ��
                Ly3_5 = System.Convert.ToDouble(DbInput_Item3CS.Value);//���ְ�������
                Ly3_6 = Cbx_Item3JDCSZ.Text;//����������
                Ly3_7 = System.Convert.ToDouble(IntInput_Item3JDCKMJBJ.Value);//�����ſ��żܲ���
                Ly3_8 = System.Convert.ToDouble(IntInput_Item3JDCKYMJKDS.Value);//�����ſ�Խ�����ݾ���
                Ly3_9 = System.Convert.ToDouble(IntInput_Item3JDCJGMJKDS.Value);//�����ż�������ݾ���
                Ly3_10 = DbInput_Item3XS.Value;//��������ϵ��
                #endregion
                #region ��ʽ���ּ������������
                Ly3Sum1 = Ly3_10 * (Ly3_2 / Ly3_4 + 1) * Ly3_1 / Ly3_3;
                Ly3Sum2 = Ly3_10 * Ly3_2 / Ly3_4 * Ly3_1 / Ly3_3 * 2;
                Ly3Sum3 = Ly3_10 * Ly3_2 / Ly3_4 * Ly3_5;
                Ly3Sum4 = Ly3_10 * (Ly3_2 / Ly3_4 + 1) * Ly3_1 / Ly3_3 * 2;
                Ly3Sum5 = Ly3_10 * (Math.Pow((Ly3_8 * Ly3_8 + Ly3_7 * Ly3_7), 0.5) + 1) * Ly3_1 / Ly3_7 * Ly3_2 / Ly3_8;
                Ly3Sum6 = Ly3Sum5 * 3.97 / 1000;
                Ly3Sum7 = Ly3_10 * Ly3_1 / Ly3_7 * Ly3_2 / Ly3_8 * 14;
                #endregion
                Ly3Sum1 = Math.Round(Ly3Sum1, 0);
                Ly3Sum2 = Math.Round(Ly3Sum2, 0);
                Ly3Sum3 = Math.Round(Ly3Sum3, 0);
                Ly3Sum4 = Math.Round(Ly3Sum4, 0);
                Ly3Sum5 = Math.Round(Ly3Sum5, 0);
                Ly3Sum6 = Math.Round(Ly3Sum6, 0);
                Ly3Sum7 = Math.Round(Ly3Sum7, 0);
                obj = new object[] {Ly3_1, Ly3_2, Ly3_3, Ly3_4, Ly3_5, Ly3_7, Ly3_8, Ly3_9, Ly3_10,Ly3_6, Ly3Sum1, Ly3Sum2, Ly3Sum3, Ly3Sum4, Ly3Sum5, Ly3Sum6, Ly3Sum7,
                                            DbInput_Item3CS.Value,IntInput_MaterialJDCKYBJ.Value,IntInput_Item3JDCKYMJKDS.Value,IntInput_Item3JDCJGMJKDS.Value};

            }
            else if (CbxScaffoldType.SelectedIndex == 4)//ѡ��������ּ���������
            {
                itemtext = "�������ּ����ϼ���";
                #region �������ּ����������漰�Ĳ�������
                double Ly4_1, Ly4_2, Ly4_3=1, Ly4_4, Ly4_5, Ly4_6, Ly4_7, Ly4_8, Ly4_9, Ly4_10, Ly4_11, Ly4_12, Ly4_13, Ly4_14, Ly4_15,
                    Ly4_16, Ly4_17, Ly4_18, Ly4_19, Ly4_20, Ly4_21, Ly4_22, Ly4_23, Ly4_24, Ly4_25;
                double Ly4Sum1 = 0, Ly4Sum2 = 0, Ly4Sum3 = 0, Ly4Sum4 = 0, Ly4Sum5 = 0, Ly4Sum6 = 0, Ly4Sum7 = 0, Ly4Sum8 = 0, Ly4Sum9 = 0, Ly4Sum10 = 0, Ly4Sum11 = 0, Ly4Sum12 = 0, Ly4Sum13 = 0, Ly4Sum14 = 0, Ly4Sum15 = 0, Ly4Sum16 = 0;
                string compare1 = "", compare2 = "", compare3 = "", compare4 = "", compare5 = "";
                Ly4_1 = Db_Item4CD.Value;//��������
                Ly4_2 = Db_Item4KD.Value;//�������
                Ly4_3 = Db_Item4GD.Value;//�����߶�
                Ly4_4 = Db_Item4PZZL.Value;//��������
                Ly4_5 = Db_Item4XTLFBHD.Value;//������������
                Ly4_6 = Db_Item4XTLMJJ.Value;//�����������
                Ly4_7 = Db_Item4JMGXJ.Value;//������������Ծ�
                Ly4_8 = Db_Item4JMDKJ.Value;//����������ֿ���
                Ly4_9 = Db_Item4DLDDJL.Value;//������ǰ��֧���������������
                Ly4_10 = Db_Item4HBZDJL.Value;// ������ǰ��֧������֧�����
                Ly4_11 = Db_Item4WDXS.Value;//�����������ȶ�ϵ��
                Ly4_12 = Db_Item4KWQD.Value;//����������ǿ�����ֵ
                Ly4_13 = Db_Item4KJQD.Value;//����������ǿ�����ֵ
                Ly4_14 = Db_Item4GSSZJ.Value;//��˿��ֱ��
                Ly4_15 = Db_Item4LJZH.Value;//��˿�ƶ������ܺ�
                Ly4_16 = Db_Item4SLGSSS.Value;//ÿ鯼���������˿����
                Ly4_17 = Db_Item4AQXS.Value;//��ȫϵ��
                Ly4_18 = Db_Item4BJYXS.Value;//������ϵ��
                Ly4_19 = Db_Item4GSSDLZZ.Value;// ��˿�����������ر�׼ֵ
                Ly4_20 = System.Convert.ToDouble(TB_Item4ZZBZZ.Text);//���������ر�׼ֵ
                Ly4_21 = Db_Item4HZBZZ.Value;//ʩ������ر�׼ֵ
                Ly4_22 = Db_Item4JBFY.Value;//������ѹ
                Ly4_23 = Db_Item4FHZTXXS.Value;//���������ϵ��
                Ly4_24 = Db_Item4FYGDBHXS.Value;//��ѹ�߶ȱ仯ϵ��
                Ly4_25 = Db_Item4FZXS.Value;//����ϵ��
                #endregion
                #region �������ּ������������
                Ly4Sum1 = Ly4_1 * Ly4_3;//�����ܷ����F
                Ly4Sum2 = Ly4_22 * Ly4_23 * Ly4_24 * Ly4_25 * Ly4Sum1;//�����ķ���ر�׼ֵQwk
                Ly4Sum3 = Ly4_1 * Ly4_2;//�����ײ�������A
                Ly4Sum4 = Ly4_21 * Ly4Sum3;//ʩ������ر�׼ֵQk
                Ly4Sum5 = (Ly4_19 + Ly4Sum4) / 2;//����������˿��������ر�׼ֵQ1
                Ly4Sum6 = Ly4Sum2 / 2;//����������˿��ˮƽ���ر�׼ֵQ2
                Ly4Sum7 = Ly4_17 * (Math.Pow((Ly4Sum5 * Ly4Sum5 + Ly4Sum6 * Ly4Sum6), 0.5));//������˿������������ʩ������ֵQD
                Ly4Sum8 = Ly4Sum7 * (1 + Ly4_9 / Ly4_10) + Ly4_20 * (Ly4_9 + Ly4_10);//֧�����һ���ǰ֧�ܵĽṹ�����ܵļ��к���ND
                Ly4Sum9 = Ly4_18 * Ly4_16 * Ly4_15 / Ly4_17;//��˿������[Fg]
                Ly4Sum10 = 2 * (Ly4Sum7 * Ly4_9 / Ly4_10);//֧�����һ�����֧�ܵĽṹ�����ܵļ��к���T
                Ly4Sum11 = Ly4Sum10 * 100;//������С��������m0
                Ly4Sum12 = Ly4Sum7 * Ly4_9;//����������ǿ������Mmax
                Ly4Sum13 = Ly4Sum12 * 1000 / Ly4_8;//����������ǿ�������
                Ly4Sum14 = Ly4Sum7 + Ly4_20 * Ly4_9;//��������������Vmax
                Ly4Sum15 = Ly4Sum14 * Ly4_6 / Ly4_5 / Ly4_7 * 10;//���������������max
                Ly4Sum16 = Ly4Sum12 * 1000 / (Ly4_11 * Ly4_8);//�����������ȶ��������

                Ly4Sum1 = Math.Round(Ly4Sum1, 0);
                Ly4Sum2 = Math.Round(Ly4Sum2, 0);
                Ly4Sum3 = Math.Round(Ly4Sum3, 0);
                Ly4Sum4 = Math.Round(Ly4Sum4, 0);
                Ly4Sum5 = Math.Round(Ly4Sum5, 0);
                Ly4Sum6 = Math.Round(Ly4Sum6, 0);
                Ly4Sum7 = Math.Round(Ly4Sum7, 0);
                Ly4Sum8 = Math.Round(Ly4Sum8, 0);
                Ly4Sum9 = Math.Round(Ly4Sum9, 0);
                Ly4Sum10 = Math.Round(Ly4Sum10, 0);
                Ly4Sum11 = Math.Round(Ly4Sum11, 0);
                Ly4Sum12 = Math.Round(Ly4Sum12, 0);
                Ly4Sum13 = Math.Round(Ly4Sum13, 0);
                Ly4Sum14 = Math.Round(Ly4Sum14, 0);
                Ly4Sum15 = Math.Round(Ly4Sum15, 0);
                Ly4Sum16 = Math.Round(Ly4Sum16, 0);

                if (Ly4Sum9 >= Ly4Sum7)
                {
                    compare1 = "[Fg]= " + Ly4Sum9 + " kN ��QD= " + Ly4Sum7 + " kN������Ҫ��!";
                }
                else
                    compare1 = "[Fg]= " + Ly4Sum9 + " kN<QD= " + Ly4Sum7 + " kN��������Ҫ��!";
               
                if (Ly4_4 >= Ly4Sum11)
                {
                    compare2 = "ʵ�����أ�m=" + Ly4_4 + " kg��m0= " + Ly4Sum11 + " kg������Ҫ��!";
                }
                else
                    compare2 = "ʵ�����أ�m=" + Ly4_4 + " kg<m0= " + Ly4Sum11 + " kg��������Ҫ��!";
               
                if (Ly4Sum13 <= Ly4_12)
                {
                    compare3 = "��=" + Ly4Sum13 + "N/mm2��f= "+Ly4_12+" N/mm2������Ҫ��!";
                }
                else
                    compare3 = "��=" + Ly4Sum13 + "N/mm2>f= " + Ly4_12 + " N/mm2��������Ҫ��!";
               
                if (Ly4Sum15 <= Ly4_13)
                {
                    compare4 = "��max=" + Ly4Sum15 + " N/mm2�ܦ�="+Ly4_13+" N/mm2������Ҫ��!";
                }
                else
                    compare4 = "��max=" + Ly4Sum15 + " N/mm2>��=" + Ly4_13 + " N/mm2��������Ҫ��!";
               
                if (Ly4Sum16 <= Ly4_12)
                {
                    compare5 = "��=" + Ly4Sum16 + "N/mm2��[f]= " + Ly4_12 + "N/mm2������Ҫ��!";
                }
                else
                    compare5 = "��=" + Ly4Sum16 + "N/mm2>[f]= " + Ly4_12 + "N/mm2��������Ҫ��!";
                #endregion


                obj = new object[] {Ly4_1, Ly4_2, Ly4_3, Ly4_4, Ly4_5, Ly4_6, Ly4_7, Ly4_8, Ly4_9, Ly4_10, Ly4_11, Ly4_12, Ly4_13, Ly4_14, Ly4_15,
                    Ly4_16, Ly4_17, Ly4_18, Ly4_19, Ly4_20, Ly4_21, Ly4_22, Ly4_23, Ly4_24, Ly4_25, Ly4Sum1, Ly4Sum2, Ly4Sum3, Ly4Sum4, Ly4Sum5, 
                    Ly4Sum6, Ly4Sum7, Ly4Sum8, Ly4Sum9, Ly4Sum10, Ly4Sum11, Ly4Sum12, Ly4Sum13, Ly4Sum14, Ly4Sum15, Ly4Sum16,compare1,compare2,compare3,compare4,compare5};
            }

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


    }
}

