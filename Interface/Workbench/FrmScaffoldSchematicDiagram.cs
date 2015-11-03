using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Class;
namespace Framework.Interface.Workbench
{
    public partial class FrmScaffoldSchematicDiagram : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        public bool savePic=false ;
        Image imtemp;
        private object @class;
        private System.Collections.ArrayList templateList;

        public FrmScaffoldSchematicDiagram(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            tcDiagram.SelectedTabIndex = 6;
        }

        private void Cbx_choose_SelectedIndexChanged(object sender, EventArgs e)//�жϻ����ֽ��ּܵ�ʾ��ͼ
        {
            if (Cbx_choose.SelectedIndex == 0)
            {
                tabItem1Diagram.Visible = true;
                tabItem2Diagram.Visible = tabItem3Diagram.Visible = tabItem4Diagram.Visible = tabItem5Diagram.Visible = tabItem8.Visible = tabItem6Diagram.Visible = false;
            }
            else if (Cbx_choose.SelectedIndex == 1)
            {
                tabItem2Diagram.Visible = true;
                tabItem1Diagram.Visible = tabItem3Diagram.Visible = tabItem4Diagram.Visible = tabItem5Diagram.Visible = tabItem8.Visible = tabItem6Diagram.Visible = false;
            }
            else if (Cbx_choose.SelectedIndex == 2)
            {
                tabItem3Diagram.Visible = true;
                tabItem1Diagram.Visible = tabItem2Diagram.Visible = tabItem4Diagram.Visible = tabItem5Diagram.Visible = tabItem8.Visible = tabItem6Diagram.Visible = false;
            }
            else if (Cbx_choose.SelectedIndex == 3)
            {
                tabItem4Diagram.Visible = true;
                tabItem1Diagram.Visible = tabItem2Diagram.Visible = tabItem3Diagram.Visible = tabItem5Diagram.Visible = tabItem8.Visible = tabItem6Diagram.Visible = false;
            }
            else if (Cbx_choose.SelectedIndex == 4)
            {
                tabItem5Diagram.Visible = true;
                tabItem1Diagram.Visible = tabItem2Diagram.Visible = tabItem3Diagram.Visible = tabItem4Diagram.Visible = tabItem8.Visible = tabItem6Diagram.Visible = false;
            }
            else if (Cbx_choose.SelectedIndex == 5)
            {
                tabItem6Diagram.Visible = true;
                tabItem1Diagram.Visible = tabItem2Diagram.Visible = tabItem3Diagram.Visible = tabItem4Diagram.Visible = tabItem5Diagram.Visible = tabItem8.Visible = false;
            }
           
        }

        private void rdo_DiagramLX_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Item1LX.Checked)
            {
                IntInput_Item1JDCJGLGZJ.Visible = false;
                Lb_Item1JDCJGLGZJ.Visible = false;
            }
            if(rdoItem1FLX.Checked )
            {
                IntInput_Item1JDCJGLGZJ.Visible = true ;
                Lb_Item1JDCJGLGZJ.Visible = true ;
            }
        }
        
        private void drawCross(ref Graphics g,Point start,Point end,Pen p)//֪���Խǵ����꣬����
        {
            g.DrawLine(p, start.X, start.Y, end.X, end.Y);
            g.DrawLine(p, end.X, start.Y, start.X, end.Y);
        }

        private void btnCadPic_Click(object sender, EventArgs e)
        {
            Framework.Class.CADAutomation.CreateAutoCADObject();
            //���±�������������ͼ���õ�
            int height, width;//height:img����߶ȣ�width:img�����ȣ�basic����׼����                                                          
            //double basic;
            int basicwidth, basicheight;
            int xnum = 0;//�����ж��ٸ���
            int ynum = 0;//�����ж��ٸ���

            //���±���������ƽ��ͼ���õ�
            int mla, nla;//��ʾ��¼la�ĺ��������ĸ���
            int la, lb, lc;//��ʾÿ��la��lb�������������

            //���±�������������ͼ���õ�
            string lqjl, lghj, bj;
            
            
            switch (Cbx_choose.SelectedIndex)
            {
                #region 0
                case 0:
                    
                    basicwidth =Convert.ToInt32(DbInput_Item1LGZJ.Value*100);
                    basicheight = Convert.ToInt32(DbInput_Item1BJ.Value * 100);

                    xnum = IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value;
                    ynum = IntInputItem1JDCKYBJ.Value * 2;

                    
                    Framework.Class.CADAutomation.DrawLine(-30, 0, xnum * basicwidth + 30, 0);
                    for (int i = 0; i <= xnum; i++)
                    {
                        Framework.Class.CADAutomation.DrawLine(i * basicwidth, 0, i * basicwidth, basicheight * ynum + 20);
 
                    }
                    for (int i = 0; i <= ynum; i++)
                    {
                        Framework.Class.CADAutomation.DrawLine(0, i*basicheight+20, xnum * basicwidth, basicheight * i + 20);

                    }
                    Framework.Class.CADAutomation.DrawLine(0, 20, IntInput_Item1JDCKYLGZJ.Value * basicwidth, 20+IntInputItem1JDCKYBJ.Value*basicheight);
                    Framework.Class.CADAutomation.DrawLine(IntInput_Item1JDCKYLGZJ.Value * basicwidth, 20, 0, 20+IntInputItem1JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine(0, 20 + IntInputItem1JDCKYBJ.Value * basicheight, IntInput_Item1JDCKYLGZJ.Value * basicwidth, IntInputItem1JDCKYBJ.Value * basicheight*2+20);
                    Framework.Class.CADAutomation.DrawLine(0, 20 + IntInputItem1JDCKYBJ.Value * basicheight * 2, IntInput_Item1JDCKYLGZJ.Value * basicwidth, 20+IntInputItem1JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine((IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20, (IntInput_Item1JDCKYLGZJ.Value*2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20+IntInputItem1JDCKYBJ.Value * basicheight);
                    Framework.Class.CADAutomation.DrawLine((IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20, (IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20+IntInputItem1JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine((IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem1JDCKYBJ.Value * basicheight, (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20+IntInputItem1JDCKYBJ.Value * basicheight*2);
                    Framework.Class.CADAutomation.DrawLine((IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem1JDCKYBJ.Value * basicheight * 2, (IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth, 20+2*IntInputItem1JDCKYBJ.Value * basicheight);
                    break;
                #endregion
                #region 1
                case 1:
                
                mla = Convert.ToInt32(Math.Round(((DbInput_Item2CD.Value + 2 * DbInput_Item2LQJL.Value) / DbInput_Item2LGZJ.Value), 0, MidpointRounding.AwayFromZero) + 1);
                nla = Convert.ToInt32(Math.Round((DbInput_Item2KD.Value + 2 * DbInput_Item2LQJL.Value) / DbInput_Item2LGZJ.Value, 0, MidpointRounding.AwayFromZero) + 1);
                la =Convert.ToInt32( DbInput_Item2LGZJ.Value * 10);
                lb =Convert.ToInt32( DbInput_Item2LGHJ.Value * 10);
                lc = Convert.ToInt32(DbInput_Item2LQJL.Value * 10);
                //���ĸ�����
                CADAutomation.DrawLine(0,2,lb*2+la*mla+4,2);
                CADAutomation.DrawLine(0, lb+2, lb * 2 + la * mla + 4,lb+2);
                CADAutomation.DrawLine(0, lb + la * nla+2, lb * 2 + la * mla + 4, lb + la * nla+2);
                CADAutomation.DrawLine(0, lb*2 + la * nla+2, lb * 2 + la * mla + 4, lb*2 + la * nla+2);
                //���ĸ�����
                CADAutomation.DrawLine(2,0,2,lb*2+la*nla+4);
                CADAutomation.DrawLine(2+lb, 0, 2+lb, lb * 2 + la * nla + 4);
                CADAutomation.DrawLine(2 + lb + la * mla, 0, 2 + lb + la * mla, lb * 2 + la * nla + 4);
                CADAutomation.DrawLine(2 + lb*2 + la * mla, 0, 2 + lb*2 + la * mla, lb * 2 + la * nla + 4);
                //������
                CADAutomation.DrawLine(2 + lb + lc, 2 + lb + lc, 2 + lb + la * mla-lc , 2 + lb + lc);
                CADAutomation.DrawLine(2 + lb + la * mla - lc, 2 + lb + lc, 2 + lb + la * mla - lc, 2 + lb + la * nla - lc);
                CADAutomation.DrawLine(2 + lb + la * mla - lc, 2 + lb + la * nla - lc, 2 + lb + lc, 2 + lb + la * nla - lc);
                CADAutomation.DrawLine(2 + lb + lc, 2 + lb + lc, 2 + lb + lc, 2 + lb + la * nla - lc);
                //���ϱߺ��±ߺ͵�
                for (int i = 0; i < mla; i++)
                {
                    CADAutomation.DrawLine(2 + lb + i * la, 0, 2 + lb + i * la,lb+4);
                    CADAutomation.DrawLine(2 + lb + i * la, 4 + lb * 2 + la * nla, 2 + lb + i * la,  lb  + la * nla);
                    //g.DrawLine(p1, 40 + lb + la * i, 38, 40 + lb + la * i, 40 + lb + 2);//�ϱ�
                    //g.DrawLine(p1, 40 + lb + la * i, 38 + lb + la * nla, 40 + lb + la * i, 42 + lb * 2 + la * nla);//�±�



                    //CADAutomation.DrawPoint(23, 43, 33);
                    if ((i % 3) == 0 & i != 0)
                    {
                        
                    //    g.FillEllipse(b2, 37 + lb + la * i, 37 + lc + lb, 6, 6);
                    //    g.FillEllipse(b2, 37 + lb + la * i, 37 + lb + la * nla - lc, 6, 6);
                    }
                }
                //����ߺ��ұ�
                for (int i = 0; i < nla; i++)
                {
                    CADAutomation.DrawLine(0, 2 + lb + i * la, 4 + lb, 2 + lb + i * la);
                    CADAutomation.DrawLine(lb+la*mla, 2 + lb + i * la, 4 + lb*2+la*mla, 2 + lb + i * la);
                    //g.DrawLine(p1, 38, 40 + lb + la * i, 40 + lb + 2, 40 + lb + la * i);//���
                    //g.DrawLine(p1, 38 + lb + la * mla, 40 + lb + la * i, 42 + lb * 2 + la * mla, 40 + lb + la * i);//�±�
                    //if ((i % 3) == 0 & i != 0)
                    //{
                    //    g.FillEllipse(b2, 37 + lc + lb, 37 + lb + la * i, 6, 6);
                    //    g.FillEllipse(b2, 37 + lb + la * mla - lc, 37 + lb + la * i, 6, 6);
                    //}
                }
                // CADAutomation.DrawLine();
                break;
                #endregion
                #region 2
                case 2:
                    Point[] p1 = new Point[3];//������Ҫд��ע��������
                    string[] str1 = new string[3];//������Ҫд��������ע
                    lqjl = Convert.ToString(DbInput_Item3LQJL.Value * 1000);
                    lghj = Convert.ToString(DbInput_Item3LGHJ.Value * 1000);
                    bj = Convert.ToString(DbInput_Item3BJ.Value * 1000);
                    str1[0] = lqjl;
                    str1[1] = lghj;
                    str1[2] = bj;
                    p1[0].X = 435; p1[0].Y = 12;
                    p1[1].X = 445; p1[1].Y = 12;
                    p1[2].X = 465; p1[2].Y = 35;
                    switch (Cb_Item3JJ.SelectedIndex)
                    {
                        case 0: CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\23.dwg",str1,p1);
                            break;
                        case 1: CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\33.dwg", str1, p1);
                            break;
                        default: CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\23.dwg", str1, p1);
                            break;
                    }
                    
                    break;
                #endregion
                #region 3
                case 3:
                    
                    basicwidth = Convert.ToInt32(DbInput_Item4LGZJ.Value * 100);
                    basicheight = Convert.ToInt32(DbInput_Item4BJ.Value * 100);

                    xnum = IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value;
                    ynum = IntInputItem4JDCKYBJ.Value * 2;


                    //Framework.Class.CADAutomation.DrawLine(-30, 0, xnum * basicwidth + 30, 0);//���������
                    for (int i = 0; i <= xnum; i++)//������
                    {
                        Framework.Class.CADAutomation.DrawLine(i * basicwidth, 0, i * basicwidth, basicheight * ynum + 20);
                        Framework.Class.CADAutomation.DrawLine(i * basicwidth, 0, i * basicwidth, -60);//������
                        Framework.Class.CADAutomation.DrawLine(i * basicwidth - 10, 0, i * basicwidth + 10, 0);//�Ϻ���
                        Framework.Class.CADAutomation.DrawLine(i * basicwidth - 10, -60, i * basicwidth + 10, -60);//�º���
                    }
                    for (int i = 0; i <= ynum; i++)//������
                    {
                        Framework.Class.CADAutomation.DrawLine(0, i * basicheight + 20, xnum * basicwidth, basicheight * i + 20);

                    }
                    Framework.Class.CADAutomation.DrawLine(0, 20, IntInput_Item4JDCKYLGZJ.Value * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight);
                    Framework.Class.CADAutomation.DrawLine(IntInput_Item4JDCKYLGZJ.Value * basicwidth, 20, 0, 20 + IntInputItem4JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine(0, 20 + IntInputItem4JDCKYBJ.Value * basicheight, IntInput_Item4JDCKYLGZJ.Value * basicwidth, IntInputItem4JDCKYBJ.Value * basicheight * 2 + 20);
                    Framework.Class.CADAutomation.DrawLine(0, 20 + IntInputItem4JDCKYBJ.Value * basicheight * 2, IntInput_Item4JDCKYLGZJ.Value * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine((IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20, (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight);
                    Framework.Class.CADAutomation.DrawLine((IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20, (IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight);

                    Framework.Class.CADAutomation.DrawLine((IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight, (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight * 2);
                    Framework.Class.CADAutomation.DrawLine((IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + IntInputItem4JDCKYBJ.Value * basicheight * 2, (IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth, 20 + 2 * IntInputItem4JDCKYBJ.Value * basicheight);
                    break;
                #endregion
                #region 4
                case 4:
                    
                    mla = Convert.ToInt32(Math.Round(((DbInput_Item5CD.Value + 2 * DbInput_Item5LQJL.Value) / DbInput_Item5LGZJ.Value), 0, MidpointRounding.AwayFromZero) + 1);
                    nla = Convert.ToInt32(Math.Round((DbInput_Item5KD.Value + 2 * DbInput_Item5LQJL.Value) / DbInput_Item5LGZJ.Value, 0, MidpointRounding.AwayFromZero) + 1);
                    la = Convert.ToInt32(DbInput_Item5LGZJ.Value * 10);
                    lb = Convert.ToInt32(DbInput_Item5LGHJ.Value * 10);
                    lc = Convert.ToInt32(DbInput_Item5LQJL.Value * 10);
                    int ld = Convert.ToInt32(DbInput_Item5MGDCD.Value * 10);
                    //���ĸ�����
                    CADAutomation.DrawLine(0, 2, lb * 2 + la * mla + 4, 2);
                    CADAutomation.DrawLine(0, lb + 2, lb * 2 + la * mla + 4, lb + 2);
                    CADAutomation.DrawLine(0, lb + la * nla + 2, lb * 2 + la * mla + 4, lb + la * nla + 2);
                    CADAutomation.DrawLine(0, lb * 2 + la * nla + 2, lb * 2 + la * mla + 4, lb * 2 + la * nla + 2);
                    //���ĸ�����
                    CADAutomation.DrawLine(2, 0, 2, lb * 2 + la * nla + 4);
                    CADAutomation.DrawLine(2 + lb, 0, 2 + lb, lb * 2 + la * nla + 4);
                    CADAutomation.DrawLine(2 + lb + la * mla, 0, 2 + lb + la * mla, lb * 2 + la * nla + 4);
                    CADAutomation.DrawLine(2 + lb * 2 + la * mla, 0, 2 + lb * 2 + la * mla, lb * 2 + la * nla + 4);
                    //������
                    CADAutomation.DrawLine(2 + lb + lc, 2 + lb + lc, 2 + lb + la * mla - lc, 2 + lb + lc);
                    CADAutomation.DrawLine(2 + lb + la * mla - lc, 2 + lb + lc, 2 + lb + la * mla - lc, 2 + lb + la * nla - lc);
                    CADAutomation.DrawLine(2 + lb + la * mla - lc, 2 + lb + la * nla - lc, 2 + lb + lc, 2 + lb + la * nla - lc);
                    CADAutomation.DrawLine(2 + lb + lc, 2 + lb + lc, 2 + lb + lc, 2 + lb + la * nla - lc);
                    //���ϱߺ��±ߺ͵�
                    for (int i = 0; i < mla; i++)
                    {
                        CADAutomation.DrawLine(2 + lb + i * la, 0, 2 + lb + i * la, lb + 4+ld);
                        CADAutomation.DrawLine(2 + lb + i * la, 4 + lb * 2 + la * nla, 2 + lb + i * la, lb + la * nla-ld);
                        //g.DrawLine(p1, 40 + lb + la * i, 38, 40 + lb + la * i, 40 + lb + 2);//�ϱ�
                        //g.DrawLine(p1, 40 + lb + la * i, 38 + lb + la * nla, 40 + lb + la * i, 42 + lb * 2 + la * nla);//�±�
                        //if ((i % 3) == 0 & i != 0)
                        //{
                        //    g.FillEllipse(b2, 37 + lb + la * i, 37 + lc + lb, 6, 6);
                        //    g.FillEllipse(b2, 37 + lb + la * i, 37 + lb + la * nla - lc, 6, 6);
                        //}
                    }
                    //����ߺ��ұ�
                    for (int i = 0; i < nla; i++)
                    {
                        CADAutomation.DrawLine(0, 2 + lb + i * la, 4 + lb+ld, 2 + lb + i * la);
                        CADAutomation.DrawLine(lb + la * mla-ld, 2 + lb + i * la, 4 + lb * 2 + la * mla, 2 + lb + i * la);
                        //g.DrawLine(p1, 38, 40 + lb + la * i, 40 + lb + 2, 40 + lb + la * i);//���
                        //g.DrawLine(p1, 38 + lb + la * mla, 40 + lb + la * i, 42 + lb * 2 + la * mla, 40 + lb + la * i);//�±�
                        //if ((i % 3) == 0 & i != 0)
                        //{
                        //    g.FillEllipse(b2, 37 + lc + lb, 37 + lb + la * i, 6, 6);
                        //    g.FillEllipse(b2, 37 + lb + la * mla - lc, 37 + lb + la * i, 6, 6);
                        //}
                    }
                    // CADAutomation.DrawLine();
                    break;
                #endregion
                #region 5
                case 5:
                    Point[] p2 = new Point[5];//������Ҫд��ע��������
                    string[] str2 = new string[5];//������Ҫд��������ע
                    lqjl = Convert.ToString(DbInput_Item6LQJL.Value * 1000);
                    lghj = Convert.ToString(DbInput_Item6LGHJ.Value * 1000);
                    bj = Convert.ToString(DbInput_Item6BJ.Value * 1000);
                    str2[0] = lqjl;
                    str2[1] = lghj;
                    str2[2] = bj;
                    str2[3] = Convert.ToString(DbInput_Item6MGDCD.Value * 1000);
                    str2[4] = Convert.ToString(DbInput_Item6XTDCD.Value * 1000);
                    
                    switch (Cb_Item6JJ.Text)
                    {
                        case "��������":
                            p2[0].X = 435; p2[0].Y = 12;
                            p2[1].X = 445; p2[1].Y = 12;
                            p2[2].X = 465; p2[2].Y = 35;
                            p2[3].X = 418; p2[3].Y = 8;
                            p2[4].X = 442; p2[4].Y = 8;
                            CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\23.dwg", str2, p2);
                            break;
                        case "��������":
                            p2[0].X = 435; p2[0].Y = 15;
                            p2[1].X = 445; p2[1].Y = 15;
                            p2[2].X = 465; p2[2].Y = 38;
                            p2[3].X = 418; p2[3].Y = 11;
                            p2[4].X = 442; p2[4].Y = 11;
                            CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\33.dwg", str2, p2);
                            break;
                        default: //CADAutomation.ImportFromDwg(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\23.dwg", str2, p2);
                            break;
                    }

                    break;
                                    
                #endregion
            }
        }

        private void btnSimpPic_Click(object sender, EventArgs e)
        {
            savePic = true;//������ɼ�ͼ��ſ��Ա���
            pbImg.Width = 542;
            pbImg.Height = 449;
            int height, width;//height:img����߶ȣ�width:img�����ȣ�basic����׼����
            //double basic;
            height = pbImg.Height;
            width = pbImg.Width;

            imtemp = new Bitmap(width, height);//����Image����
            Graphics g = Graphics.FromImage(imtemp);

            Pen p1 = new Pen(Color.Black, 1);//������һ����ɫ,���Ϊ�Ļ���
            Pen p2 = new Pen(Color.Black, 2);//������һ����ɫ,���Ϊ�Ļ���
            Pen p3 = new Pen(Color.Black, 1);//������һ����ɫ,���Ϊ�Ļ���
            //��ɫ���
                    
            SolidBrush b1 = new SolidBrush(Color.Black);//���嵥ɫ��ˢ��
            SolidBrush b2 = new SolidBrush(Color.Black);//���嵥ɫ��ˢ��
            #region ����ͼ

            //���¶������������������ͼ���õ�
            int basicwidth, basicheight;
            int xnum = 0;//�����ж��ٸ���
            int ynum = 0;//�����ж��ٸ���
            int startx = 40;
            int starty = 40;
            Point start = new Point();
            Point end = new Point();
            //���¶��������������ƽ��ͼ���õ�
            int mla, nla;//��ʾ��¼la�ĺ��������ĸ���
            int la, lb, lc;//��ʾÿ��la��lb�������������
            //���¶������������������ͼ���õ�
            Bitmap bmpformfile;
            
            switch (Cbx_choose.SelectedIndex)
            {
                #region 0
                case 0:
                   
                    if (rdo_Item1LX.Checked)
                    {
                        IntInput_Item1JDCJGLGZJ.Value = 0;
                    }

                    xnum = IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value;
                    ynum = IntInputItem1JDCKYBJ.Value * 2;
                    // if ((width / (DbInput_Item1LGZJ.Value * (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value))) < (height / (DbInput_Item1BJ.Value * IntInputItem1JDCKYBJ.Value * 2)))
                    if (((DbInput_Item1LGZJ.Value * xnum) / (DbInput_Item1BJ.Value * ynum)) > (width / height))
                    {
                        //basic = width / (DbInput_Item1LGZJ.Value * (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value)>(width/height));
                        basicwidth = width / ((IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) + 2);//Ϊ�˷�ֹ̫��
                        basicheight = Convert.ToInt32(basicwidth * (DbInput_Item1BJ.Value / DbInput_Item1LGZJ.Value));
                    }
                    else
                    {
                        basicheight = Convert.ToInt32(height / (DbInput_Item1BJ.Value * IntInputItem1JDCKYBJ.Value * 2 + 2));
                        basicwidth = Convert.ToInt32(basicheight * (DbInput_Item1LGZJ.Value / DbInput_Item1BJ.Value));
                    }

                    //MessageBox.Show(basicheight.ToString());
                    //MessageBox.Show(basicwidth.ToString());

                    //ʵ�ֱ���
                    
                    //p3.StartCap=
                    
                    for (int i = 0; i <= ynum; i++)//������
                    {
                        g.DrawLine(p1, startx, starty + i * basicheight, startx + xnum * basicwidth, (starty + i * basicheight));
                    }
                    for (int i = 0; i <= xnum; i++)//������
                    {
                        g.DrawLine(p1, startx + i * basicwidth, starty, startx + i * basicwidth, (starty + ynum * basicheight + 10));
                        //�໭10�����أ��Ա����滭����
                    }
                    //������
                    g.DrawLine(p2, startx - 20, starty + ynum * basicheight + 10, startx + xnum * basicwidth + 20, starty + ynum * basicheight + 10);
                    //��б��
                   

                    start.X = startx;
                    start.Y = starty;
                    end.X = startx + IntInput_Item1JDCKYLGZJ.Value * basicwidth;
                    end.Y = starty + IntInputItem1JDCKYBJ.Value * basicheight;
                    drawCross(ref g, start, end, p1);//�����ϽǵĲ�

                    start = end;
                    end.X = startx;
                    end.Y = starty + IntInputItem1JDCKYBJ.Value * basicheight * 2;
                    drawCross(ref g, start, end, p1);//�����½ǵĲ�

                    start.X = startx + (IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth;
                    start.Y = starty;
                    end.X = startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth;
                    end.Y = starty + IntInputItem1JDCKYBJ.Value * basicheight;
                    drawCross(ref g, start, end, p1);//�����ϽǵĲ�

                    start = end;
                    end.X = startx + (IntInput_Item1JDCKYLGZJ.Value + IntInput_Item1JDCJGLGZJ.Value) * basicwidth;
                    end.Y = starty + IntInputItem1JDCKYBJ.Value * basicheight * 2;
                    drawCross(ref g, start, end, p1);//�����½ǵĲ�


                    //�������ݾ��ֵ
                    g.DrawLine(p1, startx, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 18, startx, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 35);
                    g.DrawLine(p1, startx + basicwidth, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 18, startx + basicwidth, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 35);
                    g.DrawLine(p3, startx, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 32, startx + basicwidth, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 32);

                    ��������
                    //g.FillRectangle(b1, rect);//����������
                    //�ַ���
                    g.DrawString((Convert.ToInt32(DbInput_Item1LGZJ.Value * 1000)).ToString(), new Font("����", 10), b1, new Point(startx + 2, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2 + 20));


                    //�������ֵ
                    g.DrawLine(p1, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 18, starty + (IntInputItem1JDCKYBJ.Value * 2 - 1) * basicheight, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 35, starty + (IntInputItem1JDCKYBJ.Value * 2 - 1) * basicheight);
                    g.DrawLine(p1, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 18, starty + IntInputItem1JDCKYBJ.Value * 2 * basicheight, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 35, starty + IntInputItem1JDCKYBJ.Value * basicheight * 2);
                    g.DrawLine(p3, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 32, starty + (IntInputItem1JDCKYBJ.Value * 2 - 1) * basicheight, startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 32, starty + IntInputItem1JDCKYBJ.Value * 2 * basicheight);

                    //��ɫ���
                    //SolidBrush b1 = new SolidBrush(Color.Blue);//���嵥ɫ��ˢ����������
                    //g.FillRectangle(b1, rect);//����������
                    //�ַ���
                    g.DrawString((Convert.ToInt32(DbInput_Item1BJ.Value * 1000)).ToString(), new Font("����", 10), b1, new Point(startx + (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) * basicwidth + 2, starty + IntInputItem1JDCKYBJ.Value * 2 * basicheight - 15));                 
                    break;
                #endregion
                #region 1
                case 1:
                    mla = Convert.ToInt32(Math.Round(((DbInput_Item2CD.Value + 2 * DbInput_Item2LQJL.Value) / DbInput_Item2LGZJ.Value), 0, MidpointRounding.AwayFromZero) + 1);
                    nla = Convert.ToInt32(Math.Round((DbInput_Item2KD.Value + 2 * DbInput_Item2LQJL.Value) / DbInput_Item2LGZJ.Value, 0, MidpointRounding.AwayFromZero) + 1);
                    //if (((DbInput_Item2CD.Value) / (DbInput_Item2KD.Value)) > (Convert.ToDouble( width) /Convert.ToDouble( height)))
                    if (((DbInput_Item2CD.Value) / (Convert.ToDouble(width)) > (DbInput_Item2KD.Value) / Convert.ToDouble(height)))
                    {//��������ǻ��Ƶļ�ͼ�Ͽ�Ӧ�ñ�֤������ȫ���Ž�������
                        la = (width - 80) / mla;
                        lb = Convert.ToInt32(Math.Round((DbInput_Item2LGHJ.Value / DbInput_Item2LGZJ.Value) * la, 0));
                        lc=Convert.ToInt32(Math.Round((DbInput_Item2LQJL.Value / DbInput_Item2LGZJ.Value) * la, 0));
                        //basic = width / (DbInput_Item1LGZJ.Value * (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value)>(width/height));
                        //basicwidth = width / ((IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) + 2);//Ϊ�˷�ֹ̫��
                        //basicheight = Convert.ToInt32(basicwidth * (DbInput_Item1BJ.Value / DbInput_Item1LGZJ.Value));
                    }
                    else
                    {
                        la = (height - 80) / nla; 
                        lb = Convert.ToInt32(Math.Round((DbInput_Item2LGHJ.Value / DbInput_Item2LGZJ.Value) * la, 0));
                        lc=Convert.ToInt32(Math.Round((DbInput_Item2LQJL.Value / DbInput_Item2LGZJ.Value) * la, 0));
                        //basicheight = Convert.ToInt32(height / (DbInput_Item1BJ.Value * IntInputItem1JDCKYBJ.Value * 2 + 2));
                        //basicwidth = Convert.ToInt32(basicheight * (DbInput_Item1LGZJ.Value / DbInput_Item1BJ.Value));
                    }
                    //40,40��Ϊ��ʼ�㣬ǰ��̽��5�ľ���
                    //��������
                    g.DrawLine(p1, 38, 40, (la * mla + 2 * lb + 42), 40);
                    g.DrawLine(p1, 38, 40 + lb, (la * mla + 2 * lb + 42), 40 + lb);
                    g.DrawLine(p1, 38, 40 + lb + nla * la, (la * mla + 2 * lb + 42), 40 + lb + nla * la);
                    g.DrawLine(p1, 38, 40 + lb * 2 + nla * la, (la * mla + 2 * lb + 42), 40 + lb*2 + nla * la);


                    //��������
                    g.DrawLine(p1, 40, 38, 40, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40+lb, 38, 40+lb, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40 + lb + la * mla, 38, 40 + lb + la * mla, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40 + lb*2 + la * mla, 38, 40 + lb*2 + la * mla, (la * nla + lb * 2 + 42));


                    //����
                    g.DrawLine(p2, 40 + lb + lc, 40 + lb + lc, 40 + lb + la * mla - lc, 40 + lb + lc);
                    g.DrawLine(p2, 40 + lb + la * mla - lc, 40 + lb + lc,40 + lb + la * mla - lc, 40+lb+la*nla-lc);
                    g.DrawLine(p2, 40 + lb + la * mla - lc, 40 + lb + la * nla - lc,40+lb+lc,40+lb+la*nla-lc );
                    g.DrawLine(p2, 40 + lb + lc, 40 + lb + la * nla - lc, 40 + lb + lc, 40 + lb + lc);

                    //���ϱߺ��±ߺ͵�
                    for (int i = 0; i < mla; i++)
                    {
                        g.DrawLine(p1, 40 + lb + la * i, 38, 40 + lb + la * i, 40 + lb + 2);//�ϱ�
                        g.DrawLine(p1, 40 + lb + la * i, 38 + lb + la * nla, 40 + lb + la * i, 42 + lb*2 + la * nla);//�±�
                        if ((i % 3) == 0&i!=0)
                        {
                            g.FillEllipse(b2, 37 + lb + la * i, 37+lc+lb, 6, 6);
                            g.FillEllipse(b2, 37 + lb + la * i, 37 +lb+ la * nla-lc, 6, 6);
                           
                        }
                    }
                    //����ߺ��ұ�
                    for (int i = 0; i < nla; i++)
                    {
                        g.DrawLine(p1, 38, 40 + lb + la * i, 40 + lb + 2, 40 + lb + la * i);//���
                        g.DrawLine(p1, 38 + lb + la * mla, 40 + lb + la * i, 42 + lb * 2 + la * mla, 40 + lb + la * i);//�±�
                        if ((i % 3) == 0 & i != 0)
                        {
                            g.FillEllipse(b2, 37 + lc + lb, 37 + lb + la * i, 6, 6);
                            g.FillEllipse(b2, 37 + lb + la * mla - lc, 37 + lb + la * i, 6, 6);
                        }
                    }

                    //��ǽ����ע
                    g.DrawLine(p1, 40 + lb+la*3, 50 + lc + lb, 40 + lb+la*3, 70 + lc + lb);
                    g.DrawString("��ǽ��", new Font("����", 10), b1, new Point(37 + lb + la * 3, 75 + lc + lb));


                    //�������ע

                    g.DrawString("������", new Font("����", 10), b1, new Point((la * mla) / 2+30, (la * nla) / 2+40));                 


                
                    //��ȱ�ע
                    g.DrawLine(p1, 35, 40 + lb + lc, 15, 40 + lb + lc);
                    g.DrawLine(p1, 35, 40 + lb + la * nla - lc, 15, 40 + lb + la * nla - lc);
                    g.DrawLine(p1, 30, 40 + lb + lc, 30, 40 + lb + la * nla - lc);
                    g.DrawString(Convert.ToInt16(DbInput_Item2KD.Value).ToString() + "m", new Font("����", 10), b1, new Point(4, (la * nla) / 2 + 40));

                    //���ȱ�ע
                    g.DrawLine(p1, 40 + lb + lc, 35, 40 + lb + lc, 15);
                    g.DrawLine(p1, 40 + lb + la * mla - lc, 35, 40 + lb + la * mla - lc, 15);
                    g.DrawLine(p1, 40 + lb + lc, 30, 40 + lb + la * mla - lc, 30);
                    g.DrawString(Convert.ToInt16(DbInput_Item2CD.Value).ToString() + "m", new Font("����", 10), b1, new Point((la * mla) / 2 + 40,8));
                    
                    break;
                #endregion
                #region 2
                case 2:
                    
                    switch (Cb_Item3JJ.SelectedIndex)
                    {
                        case 0: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\23.jpg");//��ȡ�򿪵��ļ�
                            break;
                        case 1: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\33.jpg");//��ȡ�򿪵��ļ�
                            break;
                        default: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\ldjpm\23.jpg");//��ȡ�򿪵��ļ�
                            break;
                    }
                    panelEx2.AutoScrollPosition = new Point(0, 0);//����������λ
                    pbImg.Size = bmpformfile.Size;//������ͼ����СΪͼƬ��С
                    //panelEx2.Size = bmpformfile.Size;
                    //reSize.Location = new Point(bmpformfile.Width, bmpformfile.Height);//reSizeΪ����ʵ���ֶ����ڻ�����С�õ�
                    //��Ϊ���ǳ�ʼʱ�Ŀհ׻�����С���ޣ�"��"�����������𻭰��С�ı䣬����Ҫ���������´��빤����
                    //dt.DrawTools_Graphics = pbImg.CreateGraphics();
                    imtemp = new Bitmap(pbImg.Width, pbImg.Height);
                    g = Graphics.FromImage(imtemp);
                    g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));//��ʹ����仰����ô���bmp�ı�������͸����
                    g.DrawImage(bmpformfile, 0, 0, bmpformfile.Width, bmpformfile.Height);//��ͼƬ����������
                    g.Dispose();//�ͷŻ�����ռ��Դ
                    //��ֱ��ʹ��pbImg.Image = Image.FormFile(ofd.FileName)����Ϊ��������ͼƬһֱ���ڴ�״̬��Ҳ���޷������޸ĺ��ͼƬ��
                    bmpformfile.Dispose();//�ͷ�ͼƬ��ռ��Դ
                    g = pbImg.CreateGraphics();
                    g.DrawImage(imtemp, 0, 0);
                    break;






                #endregion
                #region 3
                case 3:
                   
                    xnum = 0;//�����ж��ٸ���
                    ynum = 0;//�����ж��ٸ���
                    if (rdo_Item4LX.Checked)
                    {
                        IntInput_Item4JDCJGLGZJ.Value = 0;
                    }
                    xnum = IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value;
                    ynum = IntInputItem4JDCKYBJ.Value * 2;
                    // if ((width / (DbInput_Item4LGZJ.Value * (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value))) < (height / (DbInput_Item4BJ.Value * IntInputItem4JDCKYBJ.Value * 2)))
                    if (((DbInput_Item4LGZJ.Value * xnum) / (DbInput_Item4BJ.Value * ynum)) > (width / height))
                    {
                        //basic = width / (DbInput_Item4LGZJ.Value * (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value)>(width/height));
                        basicwidth = width / ((IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) + 2);//Ϊ�˷�ֹ̫��
                        basicheight = Convert.ToInt32(basicwidth * (DbInput_Item4BJ.Value / DbInput_Item4LGZJ.Value));
                    }
                    else
                    {
                        basicheight = Convert.ToInt32(height / (DbInput_Item4BJ.Value * IntInputItem4JDCKYBJ.Value * 2 + 2));
                        basicwidth = Convert.ToInt32(basicheight * (DbInput_Item4LGZJ.Value / DbInput_Item4BJ.Value));
                    }
                    //MessageBox.Show(basicheight.ToString());
                    //MessageBox.Show(basicwidth.ToString());

                    //ʵ�ֱ���

                    //p3.StartCap=

                    for (int i = 0; i <= ynum; i++)//������
                    {
                        g.DrawLine(p1, startx, starty + i * basicheight, startx + xnum * basicwidth, (starty + i * basicheight));
                    }
                    for (int i = 0; i <= xnum; i++)//������
                    {
                        g.DrawLine(p1, startx + i * basicwidth, starty, startx + i * basicwidth, (starty + ynum * basicheight + 10));
                        //�໭10�����أ��Ա����滭���ָ�

                        //�����ָ�
                        g.DrawLine(p2, startx + i * basicwidth-5, starty + ynum * basicheight + 10, startx + i * basicwidth+5, starty + ynum * basicheight + 10);//�Ϻ���
                        g.DrawLine(p2, startx + i * basicwidth, starty + ynum * basicheight + 10, startx + i * basicwidth, starty + ynum * basicheight + 25);//������
                        g.DrawLine(p2, startx + i * basicwidth-5, starty + ynum * basicheight + 25, startx + i * basicwidth+5, starty + ynum * basicheight + 25);//�º���

                    }
                    //��б��
                    

                    start.X = startx;
                    start.Y = starty;
                    end.X = startx + IntInput_Item4JDCKYLGZJ.Value * basicwidth;
                    end.Y = starty + IntInputItem4JDCKYBJ.Value * basicheight;
                    drawCross(ref g, start, end, p1);//�����ϽǵĲ�

                    start = end;
                    end.X = startx;
                    end.Y = starty + IntInputItem4JDCKYBJ.Value * basicheight * 2;
                    drawCross(ref g, start, end, p1);//�����½ǵĲ�

                    start.X = startx + (IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth;
                    start.Y = starty;
                    end.X = startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth;
                    end.Y = starty + IntInputItem4JDCKYBJ.Value * basicheight;
                    drawCross(ref g, start, end, p1);//�����ϽǵĲ�

                    start = end;
                    end.X = startx + (IntInput_Item4JDCKYLGZJ.Value + IntInput_Item4JDCJGLGZJ.Value) * basicwidth;
                    end.Y = starty + IntInputItem4JDCKYBJ.Value * basicheight * 2;
                    drawCross(ref g, start, end, p1);//�����½ǵĲ�


                    //�������ݾ��ֵ
                    g.DrawLine(p1, startx, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 28, startx, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 45);
                    g.DrawLine(p1, startx + basicwidth, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 28, startx + basicwidth, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 45);
                    g.DrawLine(p3, startx, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 42, startx + basicwidth, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 42);


                    //g.FillRectangle(b1, rect);//����������
                    //�ַ���
                    g.DrawString((Convert.ToInt32(DbInput_Item4LGZJ.Value * 1000)).ToString(), new Font("����", 10), b1, new Point(startx + 2, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2 + 30));


                    //�������ֵ
                    g.DrawLine(p1, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 18, starty + (IntInputItem4JDCKYBJ.Value * 2 - 1) * basicheight, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 35, starty + (IntInputItem4JDCKYBJ.Value * 2 - 1) * basicheight);
                    g.DrawLine(p1, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 18, starty + IntInputItem4JDCKYBJ.Value * 2 * basicheight, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 35, starty + IntInputItem4JDCKYBJ.Value * basicheight * 2);
                    g.DrawLine(p3, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 32, starty + (IntInputItem4JDCKYBJ.Value * 2 - 1) * basicheight, startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 32, starty + IntInputItem4JDCKYBJ.Value * 2 * basicheight);

                    //��ɫ���
                    //SolidBrush b1 = new SolidBrush(Color.Blue);//���嵥ɫ��ˢ����������
                    //g.FillRectangle(b1, rect);//����������
                    //�ַ���
                    g.DrawString((Convert.ToInt32(DbInput_Item4BJ.Value * 1000)).ToString(), new Font("����", 10), b1, new Point(startx + (IntInput_Item4JDCKYLGZJ.Value * 2 + IntInput_Item4JDCJGLGZJ.Value) * basicwidth + 2, starty + IntInputItem4JDCKYBJ.Value * 2 * basicheight - 15));
                    break;
                #endregion
                #region 4
                case 4:
                    mla = Convert.ToInt32(Math.Round(((DbInput_Item5CD.Value + 2 * DbInput_Item5LQJL.Value) / DbInput_Item5LGZJ.Value), 0, MidpointRounding.AwayFromZero) + 1);
                    nla = Convert.ToInt32(Math.Round((DbInput_Item5KD.Value + 2 * DbInput_Item5LQJL.Value) / DbInput_Item5LGZJ.Value, 0, MidpointRounding.AwayFromZero) + 1);
                    //if (((DbInput_Item5CD.Value) / (DbInput_Item5KD.Value)) > (Convert.ToDouble( width) /Convert.ToDouble( height)))
                    if (((DbInput_Item5CD.Value) / (Convert.ToDouble(width)) > (DbInput_Item5KD.Value) / Convert.ToDouble(height)))
                    {//��������ǻ��Ƶļ�ͼ�Ͽ�Ӧ�ñ�֤������ȫ���Ž�������
                        la = (width - 80) / mla;
                        lb = Convert.ToInt32(Math.Round((DbInput_Item5LGHJ.Value / DbInput_Item5LGZJ.Value) * la, 0));
                        lc = Convert.ToInt32(Math.Round((DbInput_Item5LQJL.Value / DbInput_Item5LGZJ.Value) * la, 0));
                        //basic = width / (DbInput_Item1LGZJ.Value * (IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value)>(width/height));
                        //basicwidth = width / ((IntInput_Item1JDCKYLGZJ.Value * 2 + IntInput_Item1JDCJGLGZJ.Value) + 2);//Ϊ�˷�ֹ̫��
                        //basicheight = Convert.ToInt32(basicwidth * (DbInput_Item1BJ.Value / DbInput_Item1LGZJ.Value));
                    }
                    else
                    {
                        la = (height - 80) / nla;
                        lb = Convert.ToInt32(Math.Round((DbInput_Item5LGHJ.Value / DbInput_Item5LGZJ.Value) * la, 0));
                        lc = Convert.ToInt32(Math.Round((DbInput_Item5LQJL.Value / DbInput_Item5LGZJ.Value) * la, 0));
                        //basicheight = Convert.ToInt32(height / (DbInput_Item1BJ.Value * IntInputItem1JDCKYBJ.Value * 2 + 2));
                        //basicwidth = Convert.ToInt32(basicheight * (DbInput_Item1LGZJ.Value / DbInput_Item1BJ.Value));
                    }
                    int ld = Convert.ToInt32(Math.Round((DbInput_Item5MGDCD.Value / DbInput_Item5LGZJ.Value) * la, 0));
                    //40,40��Ϊ��ʼ�㣬ǰ��̽��5�ľ���
                    //��������
                    g.DrawLine(p1, 38, 40, (la * mla + 2 * lb + 42), 40);
                    g.DrawLine(p1, 38, 40 + lb, (la * mla + 2 * lb + 42), 40 + lb);
                    g.DrawLine(p1, 38, 40 + lb + nla * la, (la * mla + 2 * lb + 42), 40 + lb + nla * la);
                    g.DrawLine(p1, 38, 40 + lb * 2 + nla * la, (la * mla + 2 * lb + 42), 40 + lb * 2 + nla * la);


                    //��������
                    g.DrawLine(p1, 40, 38, 40, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40 + lb, 38, 40 + lb, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40 + lb + la * mla, 38, 40 + lb + la * mla, (la * nla + lb * 2 + 42));
                    g.DrawLine(p1, 40 + lb * 2 + la * mla, 38, 40 + lb * 2 + la * mla, (la * nla + lb * 2 + 42));


                    //����
                    g.DrawLine(p2, 40 + lb + lc, 40 + lb + lc, 40 + lb + la * mla - lc, 40 + lb + lc);
                    g.DrawLine(p2, 40 + lb + la * mla - lc, 40 + lb + lc, 40 + lb + la * mla - lc, 40 + lb + la * nla - lc);
                    g.DrawLine(p2, 40 + lb + la * mla - lc, 40 + lb + la * nla - lc, 40 + lb + lc, 40 + lb + la * nla - lc);
                    g.DrawLine(p2, 40 + lb + lc, 40 + lb + la * nla - lc, 40 + lb + lc, 40 + lb + lc);

                    //���ϱߺ��±ߺ͵�
                    for (int i = 0; i < mla; i++)
                    {
                        g.DrawLine(p2, 40 + lb + la * i, 38, 40 + lb + la * i, 38 + ld+lb);//�ϱ�
                        g.DrawLine(p2, 40 + lb + la * i, 42 + lb + la * nla-ld, 40 + lb + la * i, 42 + lb * 2 + la * nla);//�±�

                        if ((i % 3) == 0 & i != 0)
                        {
                            g.FillEllipse(b2, 37 + lb + la * i, 37 + lc + lb, 6, 6);
                            g.FillEllipse(b2, 37 + lb + la * i, 37 + lb + la * nla - lc, 6, 6);
                        }
                    }
                    //����ߺ��ұ�
                    for (int i = 0; i < nla; i++)
                    {
                        g.DrawLine(p2, 38, 40 + lb + la * i, 38+ld+lb, 40 + lb + la * i);//���
                        g.DrawLine(p2, 38 + lb + la * mla-ld, 40 + lb + la * i, 42 + lb * 2 + la * mla, 40 + lb + la * i);//�±�
                        if ((i % 3) == 0 & i != 0)
                        {
                            g.FillEllipse(b2, 37 + lc + lb, 37 + lb + la * i, 6, 6);
                            g.FillEllipse(b2, 37 + lb + la * mla - lc, 37 + lb + la * i, 6, 6);
                        }
                    }
                    //��ǽ����ע
                    g.DrawLine(p1, 40 + lb + la * 3, 50 + lc + lb, 40 + lb + la * 3, 70 + lc + lb);
                    g.DrawString("��ǽ��", new Font("����", 10), b1, new Point(37 + lb + la * 3, 75 + lc + lb));


                    //�������ע

                    g.DrawString("������", new Font("����", 10), b1, new Point((la * mla) / 2 + 30, (la * nla) / 2 + 40));



                    //��ȱ�ע
                    g.DrawLine(p1, 35, 40 + lb + lc, 15, 40 + lb + lc);
                    g.DrawLine(p1, 35, 40 + lb + la * nla - lc, 15, 40 + lb + la * nla - lc);
                    g.DrawLine(p1, 30, 40 + lb + lc, 30, 40 + lb + la * nla - lc);
                    g.DrawString(Convert.ToInt16(DbInput_Item5KD.Value).ToString() + "m", new Font("����", 10), b1, new Point(4, (la * nla) / 2 + 40));

                    //���ȱ�ע
                    g.DrawLine(p1, 40 + lb + lc, 35, 40 + lb + lc, 15);
                    g.DrawLine(p1, 40 + lb + la * mla - lc, 35, 40 + lb + la * mla - lc, 15);
                    g.DrawLine(p1, 40 + lb + lc, 30, 40 + lb + la * mla - lc, 30);
                    g.DrawString(Convert.ToInt16(DbInput_Item5CD.Value).ToString() + "m", new Font("����", 10), b1, new Point((la * mla) / 2 + 40, 8));
                    
                    break;
                    #endregion
                #region 5
                case 5:

                    switch (Cb_Item6JJ.SelectedIndex)
                    {
                        case 0: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\23.jpg");//��ȡ�򿪵��ļ�
                            break;
                        case 1: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\33.jpg");//��ȡ�򿪵��ļ�
                            break;
                        default: bmpformfile = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\soft\CAD\xtjpm\23.jpg");//��ȡ�򿪵��ļ�
                            break;
                    }
                    panelEx2.AutoScrollPosition = new Point(0, 0);//����������λ
                    pbImg.Size = bmpformfile.Size;//������ͼ����СΪͼƬ��С
                    //panelEx2.Size = bmpformfile.Size;
                    //reSize.Location = new Point(bmpformfile.Width, bmpformfile.Height);//reSizeΪ����ʵ���ֶ����ڻ�����С�õ�
                    //��Ϊ���ǳ�ʼʱ�Ŀհ׻�����С���ޣ�"��"�����������𻭰��С�ı䣬����Ҫ���������´��빤����
                    //dt.DrawTools_Graphics = pbImg.CreateGraphics();
                    imtemp = new Bitmap(pbImg.Width, pbImg.Height);
                    g = Graphics.FromImage(imtemp);
                    g.FillRectangle(new SolidBrush(pbImg.BackColor), new Rectangle(0, 0, pbImg.Width, pbImg.Height));//��ʹ����仰����ô���bmp�ı�������͸����
                    g.DrawImage(bmpformfile, 0, 0, bmpformfile.Width, bmpformfile.Height);//��ͼƬ����������
                    g.Dispose();//�ͷŻ�����ռ��Դ
                    //��ֱ��ʹ��pbImg.Image = Image.FormFile(ofd.FileName)����Ϊ��������ͼƬһֱ���ڴ�״̬��Ҳ���޷������޸ĺ��ͼƬ��
                    bmpformfile.Dispose();//�ͷ�ͼƬ��ռ��Դ
                    g = pbImg.CreateGraphics();
                    g.DrawImage(imtemp, 0, 0);
                    break;
                    #endregion

            }
            pbImg.Image = imtemp;
            
            //imtemp.Save("D:\\abc\\b.jpg");//����ͼƬ
            g.Dispose();
            //Framework.Class.CADAutomation.CloseAllInstance();�ر�            
            
            //g.DrawLine(p, 10, 10, 100, 100);//�ڻ����ϻ�ֱ��,��ʼ����Ϊ(10,10),�յ�����Ϊ(100,100)       
            //g.DrawRectangle(p, 10, 10, 100, 100);//�ڻ����ϻ�����,��ʼ����Ϊ(10,10),��Ϊ,��Ϊ       
            //g.DrawEllipse(p, 10, 10, 100, 100);//�ڻ����ϻ���Բ,��ʼ����Ϊ(10,10),��Ӿ��εĿ�Ϊ,��Ϊ
            #endregion
           
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            if (savePic)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //dt.OrginalImg.Save(sfd.FileName);
                    imtemp.Save(sfd.FileName);
                }

            }
            else
                MessageBox.Show("�������ɼ�ͼ���ٱ���");
            return;
        }

        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            switch(Cbx_choose.SelectedIndex)
            {
                case 0:itemtext = "��ؼ�����ͼ";break;
                case 1:itemtext = "��ؼ�ƽ��ͼ";break;
                case 2:itemtext = "��ؼ�����ͼ";break;
                case 3:itemtext = "����������ͼ";break;
                case 4:itemtext = "������ƽ��ͼ";break;
                case 5:itemtext = "����������ͼ";break;
            }
            if (savePic)
            {
                imtemp.Save(System.Windows.Forms.Application.StartupPath + @"\temp.jpg");
                object[] obj = new object[] { itemtext, "" };

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
            else
                MessageBox.Show("�������ɼ�ͼ���ٱ���");
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            CADAutomation.DrawPoint(23, 43, 33);
        }

    }
}

