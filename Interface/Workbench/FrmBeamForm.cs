using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmBeamForm : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;
  
        public FrmBeamForm(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            CbxBeamFormType.SelectedIndex = 0;
        }

        private void CbxBeamFormType_SelectedIndexChanged(object sender, EventArgs e) //梁模板窗体首页
        {
            if (CbxBeamFormType.SelectedIndex == 0)
            {
                Cb_BF_2JDCLX.SelectedIndex = 0;
                BFtabItem1.Visible = BFtabItem2.Visible = BFtabItem3.Visible = BFtabItem4.Visible = BFtabItem5.Visible = BFtabItem6.Visible = BFtabItem7.Visible = BFtabItem8.Visible = true;
               
                lc_gzhzc.Visible = lc_xiaoliang.Visible = lc_zhuliang.Visible = lc_mbhdlhhz.Visible = tabItem1.Visible =labelX123.Visible=Db_BF_8RJS.Visible= false;
                Db_BF_3KWQD.Value = 205;
                Db_BF_3KJQD.Value = 125;
                Db_BF_3TXML.Value = 206000;
            }
            else if (CbxBeamFormType.SelectedIndex == 1)
            {
               tabItem1.Visible= BFtabItem2.Visible = BFtabItem3.Visible = BFtabItem4.Visible = BFtabItem5.Visible = BFtabItem6.Visible = BFtabItem7.Visible = BFtabItem8.Visible =labelX123.Visible=Db_BF_8RJS.Visible= true;
              BFtabItem1.Visible= lc_gzhzc.Visible = lc_xiaoliang.Visible = lc_zhuliang.Visible = lc_mbhdlhhz.Visible =  false;
               Db_BF_3KWQD.Value = 15.44;
               Db_BF_3KJQD.Value = 1.78;
               Db_BF_3TXML.Value = 9350;
            }
            else if (CbxBeamFormType.SelectedIndex == 4)
            {
                cl_hzp2.SelectedIndex = 2;
                lc_gzhzc.Visible = lc_xiaoliang.Visible = lc_zhuliang.Visible = lc_mbhdlhhz.Visible = true;
                BFtabItem1.Visible = BFtabItem2.Visible = BFtabItem3.Visible = BFtabItem4.Visible = BFtabItem5.Visible = BFtabItem6.Visible = BFtabItem7.Visible = BFtabItem8.Visible = tabItem1.Visible= false;

            }

        }

        private void Db_BF_LZGS_ValueChanged(object sender, EventArgs e)
        {
            if (Db_BF_LZGS.Value == 0)
            {
                Db_BF_ZCJJ1.Enabled = Db_BF_ZCJJ2.Enabled = Db_BF_ZCJJ3.Enabled = Db_BF_ZCJJ4.Enabled = false;
                Db_BF_ZCJJ1.Value = Db_BF_ZCJJ2.Value = Db_BF_ZCJJ3.Value = Db_BF_ZCJJ4.Value = -1;
                Db_BF_ZCJJ1.ValueObject = Db_BF_ZCJJ2.ValueObject = Db_BF_ZCJJ3.ValueObject = Db_BF_ZCJJ4.ValueObject = null;
            }
            else if (Db_BF_LZGS.Value == 1)
            {
                Db_BF_ZCJJ1.Enabled = true;
                Db_BF_ZCJJ1.Value = 0;
                Db_BF_ZCJJ2.Enabled = Db_BF_ZCJJ3.Enabled = Db_BF_ZCJJ4.Enabled = false;
                Db_BF_ZCJJ2.Value = Db_BF_ZCJJ3.Value = Db_BF_ZCJJ4.Value = -1;
                Db_BF_ZCJJ2.ValueObject = Db_BF_ZCJJ3.ValueObject = Db_BF_ZCJJ4.ValueObject = null;
            }
            else if (Db_BF_LZGS.Value == 2)                
            {
                Db_BF_ZCJJ1.Enabled = Db_BF_ZCJJ2.Enabled = true;
                Db_BF_ZCJJ1.Value = Db_BF_ZCJJ2.Value = 0;
                Db_BF_ZCJJ3.Enabled = Db_BF_ZCJJ4.Enabled = false;
                Db_BF_ZCJJ3.Value = Db_BF_ZCJJ4.Value = -1;
                Db_BF_ZCJJ3.ValueObject = Db_BF_ZCJJ4.ValueObject = null;

            }
            else if (Db_BF_LZGS.Value == 3)
            {
                Db_BF_ZCJJ1.Enabled = Db_BF_ZCJJ2.Enabled = Db_BF_ZCJJ3.Enabled = true;
                Db_BF_ZCJJ1.Value = Db_BF_ZCJJ2.Value = Db_BF_ZCJJ3.Value = 0;
                Db_BF_ZCJJ4.Enabled = false;
                Db_BF_ZCJJ4.Value = -1;
                Db_BF_ZCJJ4.ValueObject = null;
            }
            else
            {
                Db_BF_ZCJJ1.Enabled = Db_BF_ZCJJ2.Enabled = Db_BF_ZCJJ3.Enabled = Db_BF_ZCJJ4.Enabled = true;
                Db_BF_ZCJJ1.Value = Db_BF_ZCJJ2.Value = Db_BF_ZCJJ3.Value = Db_BF_ZCJJ4.Value = 0;
            }
        }

        private void Btn_BF_2SearchChart_Click(object sender, EventArgs e)
        {
            if (Cb_BF_2MBLX.SelectedIndex == 0)
            {
                FrmShowChart showchart = new FrmShowChart(11);
                showchart.ShowDialog();
            }
            else if (Cb_BF_2MBLX.SelectedIndex == 1)
            {
                FrmShowChart showchart = new FrmShowChart(10);
                showchart.ShowDialog();
            }
            else if (Cb_BF_2MBLX.SelectedIndex == 2)
            {
                FrmShowChart showchart = new FrmShowChart(12);
                showchart.ShowDialog();
            }
        }

        private void Cb_BF_3XLCZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_BF_3XLCZ.SelectedIndex == 0)//方木
            {
                Cb_BF_3JMLX.Enabled = Db_BF_3MJJ.Enabled = false;
                Db_BF_3FMG.Enabled = Db_BF_3FMK.Enabled = true;
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 1)//方钢管
            {
                Cb_BF_3JMLX.Enabled = Db_BF_3MJJ.Enabled = true;
                Db_BF_3FMG.Enabled = Db_BF_3FMK.Enabled = false;
                Cb_BF_3JMLX.Items.Clear();
                Cb_BF_3JMLX.Items.Add("□60×40×2.5"); Cb_BF_3JMLX.Items.Add("□80×40×2"); Cb_BF_3JMLX.Items.Add("□100×50×3");
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 2)//工字钢
            {
                Cb_BF_3JMLX.Enabled = Db_BF_3MJJ.Enabled = true;
                Db_BF_3FMG.Enabled = Db_BF_3FMK.Enabled = false;
                Cb_BF_3JMLX.Items.Clear();
                Cb_BF_3JMLX.Items.Add("10号"); Cb_BF_3JMLX.Items.Add("12.6号"); Cb_BF_3JMLX.Items.Add("14号"); Cb_BF_3JMLX.Items.Add("16号"); Cb_BF_3JMLX.Items.Add("18号");
                Cb_BF_3JMLX.Items.Add("20a号"); Cb_BF_3JMLX.Items.Add("20b号"); Cb_BF_3JMLX.Items.Add("22a号"); Cb_BF_3JMLX.Items.Add("22b号"); Cb_BF_3JMLX.Items.Add("25a号");
                Cb_BF_3JMLX.Items.Add("25b号"); Cb_BF_3JMLX.Items.Add("28a号"); Cb_BF_3JMLX.Items.Add("28b号"); Cb_BF_3JMLX.Items.Add("32a号"); Cb_BF_3JMLX.Items.Add("32b号");
                Cb_BF_3JMLX.Items.Add("32c号"); Cb_BF_3JMLX.Items.Add("36a号"); Cb_BF_3JMLX.Items.Add("36b号"); Cb_BF_3JMLX.Items.Add("36c号"); Cb_BF_3JMLX.Items.Add("40a号");
                Cb_BF_3JMLX.Items.Add("40b号"); Cb_BF_3JMLX.Items.Add("40c号"); Cb_BF_3JMLX.Items.Add("45a号"); Cb_BF_3JMLX.Items.Add("45b号"); Cb_BF_3JMLX.Items.Add("45c号");
                Cb_BF_3JMLX.Items.Add("50a号"); Cb_BF_3JMLX.Items.Add("50b号"); Cb_BF_3JMLX.Items.Add("50c号"); Cb_BF_3JMLX.Items.Add("56a号"); Cb_BF_3JMLX.Items.Add("56b号");
                Cb_BF_3JMLX.Items.Add("56c号"); Cb_BF_3JMLX.Items.Add("63a号"); Cb_BF_3JMLX.Items.Add("63b号"); Cb_BF_3JMLX.Items.Add("63c号");
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 3)//槽钢
            {
                Cb_BF_3JMLX.Enabled = Db_BF_3MJJ.Enabled = true;
                Db_BF_3FMG.Enabled = Db_BF_3FMK.Enabled = false;
                Cb_BF_3JMLX.Items.Clear();
                Cb_BF_3JMLX.Items.Add("5号"); Cb_BF_3JMLX.Items.Add("6.3号"); Cb_BF_3JMLX.Items.Add("8号"); Cb_BF_3JMLX.Items.Add("10号"); Cb_BF_3JMLX.Items.Add("12.6号");
                Cb_BF_3JMLX.Items.Add("14a号"); Cb_BF_3JMLX.Items.Add("14b号"); Cb_BF_3JMLX.Items.Add("16a号"); Cb_BF_3JMLX.Items.Add("16b号"); Cb_BF_3JMLX.Items.Add("18a号");
                Cb_BF_3JMLX.Items.Add("18b号"); Cb_BF_3JMLX.Items.Add("20a号"); Cb_BF_3JMLX.Items.Add("20b号"); Cb_BF_3JMLX.Items.Add("22a号"); Cb_BF_3JMLX.Items.Add("22b号");
                Cb_BF_3JMLX.Items.Add("25a号"); Cb_BF_3JMLX.Items.Add("25b号"); Cb_BF_3JMLX.Items.Add("25c号"); Cb_BF_3JMLX.Items.Add("28a号"); Cb_BF_3JMLX.Items.Add("28b号");
                Cb_BF_3JMLX.Items.Add("28c号"); Cb_BF_3JMLX.Items.Add("32a号"); Cb_BF_3JMLX.Items.Add("32b号"); Cb_BF_3JMLX.Items.Add("32c号"); Cb_BF_3JMLX.Items.Add("36a号");
                Cb_BF_3JMLX.Items.Add("36b号"); Cb_BF_3JMLX.Items.Add("36c号"); Cb_BF_3JMLX.Items.Add("40a号"); Cb_BF_3JMLX.Items.Add("40b号"); Cb_BF_3JMLX.Items.Add("40c号");
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 4)//钢管
            {
                Cb_BF_3JMLX.Enabled = Db_BF_3MJJ.Enabled = true;
                Db_BF_3FMG.Enabled = Db_BF_3FMK.Enabled = false;
                Cb_BF_3JMLX.Items.Clear();
                Cb_BF_3JMLX.Items.Add("φ48×3.5"); Cb_BF_3JMLX.Items.Add("φ48×3.25"); Cb_BF_3JMLX.Items.Add("φ48×3.2"); Cb_BF_3JMLX.Items.Add("φ48×3"); Cb_BF_3JMLX.Items.Add("φ51×3");
            }
        }

        private void Db_BF_3FMK_ValueChanged(object sender, EventArgs e)
        {
            Db_BF_3GXJ.Value = Math.Round((Db_BF_3FMK.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value / 12 / 10000), 2);
            Db_BF_3DKJ.Value = Math.Round((Db_BF_3FMK.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value / 12 / 1000), 2);
        }

        private void Db_BF_3FMG_ValueChanged(object sender, EventArgs e)
        {
            Db_BF_3GXJ.Value = Math.Round((Db_BF_3FMK.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value / 12 / 10000), 2);
            Db_BF_3DKJ.Value = Math.Round((Db_BF_3FMK.Value * Db_BF_3FMG.Value * Db_BF_3FMG.Value / 12 / 1000), 2);
        }

        private void Cb_BF_3JMLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_BF_3XLCZ.SelectedIndex == 1)//方钢管
            {
                switch (Cb_BF_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_3GXJ.Value = 21.88;
                        Db_BF_3DKJ.Value = 7.29;
                        Db_BF_3MJJ.Value = 3.58;
                        break;
                    case 1:
                        Db_BF_3GXJ.Value = 37.13;
                        Db_BF_3DKJ.Value = 9.28;
                        Db_BF_3MJJ.Value = 3.69;
                        break;
                    case 2:
                        Db_BF_3GXJ.Value = 112.12;
                        Db_BF_3DKJ.Value = 22.42;
                        Db_BF_3MJJ.Value = 8.50;
                        break;
                }
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 2)//工字钢
            {
                switch (Cb_BF_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_3GXJ.Value = 245;
                        Db_BF_3DKJ.Value = 49;
                        Db_BF_3MJJ.Value = 28.52;
                        break;
                    case 1:
                        Db_BF_3GXJ.Value = 488.99;
                        Db_BF_3DKJ.Value = 77.53;
                        Db_BF_3MJJ.Value = 29.05;
                        break;
                    case 2:
                        Db_BF_3GXJ.Value = 712;
                        Db_BF_3DKJ.Value = 102;
                        Db_BF_3MJJ.Value = 59.33;
                        break;
                    case 3:
                        Db_BF_3GXJ.Value = 1130;
                        Db_BF_3DKJ.Value = 141;
                        Db_BF_3MJJ.Value = 81.88;
                        break;
                    case 4:
                        Db_BF_3GXJ.Value = 1660;
                        Db_BF_3DKJ.Value = 185;
                        Db_BF_3MJJ.Value = 107.79;
                        break;
                    case 5:
                        Db_BF_3GXJ.Value = 2370;
                        Db_BF_3DKJ.Value = 237;
                        Db_BF_3MJJ.Value = 137.79;
                        break;
                    case 6:
                        Db_BF_3GXJ.Value = 2550;
                        Db_BF_3DKJ.Value = 250;
                        Db_BF_3MJJ.Value = 147.93;
                        break;
                    case 7:
                        Db_BF_3GXJ.Value = 3400;
                        Db_BF_3DKJ.Value = 309;
                        Db_BF_3MJJ.Value = 179.89;
                        break;
                    case 8:
                        Db_BF_3GXJ.Value = 3570;
                        Db_BF_3DKJ.Value = 325;
                        Db_BF_3MJJ.Value = 190.911;//小数点后三位精确不到
                        break;
                    case 10:
                        Db_BF_3GXJ.Value = 5023.54;
                        Db_BF_3DKJ.Value = 401.88;
                        Db_BF_3MJJ.Value = 232.41;
                        break;
                    case 11:
                        Db_BF_3GXJ.Value = 5283.96;
                        Db_BF_3DKJ.Value = 422.72;
                        Db_BF_3MJJ.Value = 247.89;
                        break;
                    case 12:
                        Db_BF_3GXJ.Value = 7114.14;
                        Db_BF_3DKJ.Value = 508.15;
                        Db_BF_3MJJ.Value = 289.02;
                        break;
                    case 13:
                        Db_BF_3GXJ.Value = 7480;
                        Db_BF_3DKJ.Value = 534.29;
                        Db_BF_3MJJ.Value = 309.09;
                        break;
                    case 14:
                        Db_BF_3GXJ.Value = 11075.5;
                        Db_BF_3DKJ.Value = 682.2;
                        Db_BF_3MJJ.Value = 402.91;
                        break;
                    case 15:
                        Db_BF_3GXJ.Value = 11621.4;
                        Db_BF_3DKJ.Value = 726.33;
                        Db_BF_3MJJ.Value = 428.78;
                        break;
                    case 16:
                        Db_BF_3GXJ.Value = 12167.5;
                        Db_BF_3DKJ.Value = 760.47;
                        Db_BF_3MJJ.Value = 454.10;
                        break;
                    case 17:
                        Db_BF_3GXJ.Value = 15760;
                        Db_BF_3DKJ.Value = 875;
                        Db_BF_3MJJ.Value = 513.36;
                        break;
                    case 18:
                        Db_BF_3GXJ.Value = 16530;
                        Db_BF_3DKJ.Value = 919;
                        Db_BF_3MJJ.Value = 545.55;
                        break;
                    case 19:
                        Db_BF_3GXJ.Value = 17310;
                        Db_BF_3DKJ.Value = 962;
                        Db_BF_3MJJ.Value = 578.93;
                        break;
                    case 20:
                        Db_BF_3GXJ.Value = 21720;
                        Db_BF_3DKJ.Value = 1090;
                        Db_BF_3MJJ.Value = 636.95;
                        break;
                    case 21:
                        Db_BF_3GXJ.Value = 22780;
                        Db_BF_3DKJ.Value = 1140;
                        Db_BF_3MJJ.Value = 677.98;
                        break;
                    case 22:
                        Db_BF_3GXJ.Value = 23850;
                        Db_BF_3DKJ.Value = 1190;
                        Db_BF_3MJJ.Value = 718.37;
                        break;
                    case 23:
                        Db_BF_3GXJ.Value = 32240;
                        Db_BF_3DKJ.Value = 1430;
                        Db_BF_3MJJ.Value = 835.23;
                        break;
                    case 24:
                        Db_BF_3GXJ.Value = 33760;
                        Db_BF_3DKJ.Value = 1500;
                        Db_BF_3MJJ.Value = 888.42;
                        break;
                    case 25:
                        Db_BF_3GXJ.Value = 35280;
                        Db_BF_3DKJ.Value = 1570;
                        Db_BF_3MJJ.Value = 938.3;
                        break;
                    case 26:
                        Db_BF_3GXJ.Value = 46470;
                        Db_BF_3DKJ.Value = 1860;
                        Db_BF_3MJJ.Value = 1085.75;
                        break;
                    case 27:
                        Db_BF_3GXJ.Value = 48560;
                        Db_BF_3DKJ.Value = 1940;
                        Db_BF_3MJJ.Value = 1145.28;
                        break;
                    case 28:
                        Db_BF_3GXJ.Value = 50640;
                        Db_BF_3DKJ.Value = 2080;
                        Db_BF_3MJJ.Value = 1211.48;
                        break;
                    case 29:
                        Db_BF_3GXJ.Value = 65585.6;
                        Db_BF_3DKJ.Value = 2342.31;
                        Db_BF_3MJJ.Value = 1375.05;
                        break;
                    case 30:
                        Db_BF_3GXJ.Value = 68512.5;
                        Db_BF_3DKJ.Value = 2446.69;
                        Db_BF_3MJJ.Value = 1451.48;
                        break;
                    case 31:
                        Db_BF_3GXJ.Value = 71439.4;
                        Db_BF_3DKJ.Value = 2551.41;
                        Db_BF_3MJJ.Value = 1529.76;
                        break;
                    case 32:
                        Db_BF_3GXJ.Value = 93916.2;
                        Db_BF_3DKJ.Value = 2981.47;
                        Db_BF_3MJJ.Value = 1732.84;
                        break;
                    case 33:
                        Db_BF_3GXJ.Value = 98083.6;
                        Db_BF_3DKJ.Value = 3163.38;
                        Db_BF_3MJJ.Value = 1833.27;
                        break;
                    case 34:
                        Db_BF_3GXJ.Value = 102251.1;
                        Db_BF_3DKJ.Value = 3298.42;
                        Db_BF_3MJJ.Value = 1932.89;
                        break;
                }
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 3)//槽钢
            {
                switch (Cb_BF_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_3GXJ.Value = 26;
                        Db_BF_3DKJ.Value = 10.4;
                        Db_BF_3MJJ.Value = 5.84;
                        break;
                    case 1:
                        Db_BF_3GXJ.Value = 50.79;
                        Db_BF_3DKJ.Value = 16.12;
                        Db_BF_3MJJ.Value = 8.77;
                        break;
                    case 2:
                        Db_BF_3GXJ.Value = 101.3;
                        Db_BF_3DKJ.Value = 25.3;
                        Db_BF_3MJJ.Value = 13.11;
                        break;
                    case 3:
                        Db_BF_3GXJ.Value = 198;
                        Db_BF_3DKJ.Value = 39.7;
                        Db_BF_3MJJ.Value = 19.85;
                        break;
                    case 4:
                        Db_BF_3GXJ.Value = 391;
                        Db_BF_3DKJ.Value = 62.1;
                        Db_BF_3MJJ.Value = 30.06;
                        break;
                    case 5:
                        Db_BF_3GXJ.Value = 564;
                        Db_BF_3DKJ.Value = 80.5;
                        Db_BF_3MJJ.Value = 38.50;
                        break;
                    case 6:
                        Db_BF_3GXJ.Value = 609;
                        Db_BF_3DKJ.Value = 87.1;
                        Db_BF_3MJJ.Value = 39.74;
                        break;
                    case 7:
                        Db_BF_3GXJ.Value = 866;
                        Db_BF_3DKJ.Value = 108;
                        Db_BF_3MJJ.Value = 50.45;
                        break;
                    case 8:
                        Db_BF_3GXJ.Value = 934;
                        Db_BF_3DKJ.Value = 117;
                        Db_BF_3MJJ.Value = 51.95;
                        break;
                    case 9:
                        Db_BF_3GXJ.Value = 1273;
                        Db_BF_3DKJ.Value = 141;
                        Db_BF_3MJJ.Value = 64.90;
                        break;
                    case 10:
                        Db_BF_3GXJ.Value = 1370;
                        Db_BF_3DKJ.Value = 152;
                        Db_BF_3MJJ.Value = 66.68;
                        break;
                    case 11:
                        Db_BF_3GXJ.Value = 1780;
                        Db_BF_3DKJ.Value = 178;
                        Db_BF_3MJJ.Value = 81.17;
                        break;
                    case 12:
                        Db_BF_3GXJ.Value = 1914;
                        Db_BF_3DKJ.Value = 191;
                        Db_BF_3MJJ.Value = 83.25;
                        break;
                    case 13:
                        Db_BF_3GXJ.Value = 2394;
                        Db_BF_3DKJ.Value = 218;
                        Db_BF_3MJJ.Value = 98.73;
                        break;
                    case 14:
                        Db_BF_3GXJ.Value = 2571;
                        Db_BF_3DKJ.Value = 234;
                        Db_BF_3MJJ.Value = 101.13;
                        break;
                    case 15:
                        Db_BF_3GXJ.Value = 3370;
                        Db_BF_3DKJ.Value = 270;
                        Db_BF_3MJJ.Value = 119.91;
                        break;
                    case 16:
                        Db_BF_3GXJ.Value = 3530;
                        Db_BF_3DKJ.Value = 282;
                        Db_BF_3MJJ.Value = 122.77;
                        break;
                    case 17:
                        Db_BF_3GXJ.Value = 3696;
                        Db_BF_3DKJ.Value = 295;
                        Db_BF_3MJJ.Value = 125.62;
                        break;
                    case 18:
                        Db_BF_3GXJ.Value = 4765;
                        Db_BF_3DKJ.Value = 340;
                        Db_BF_3MJJ.Value = 147.73;
                        break;
                    case 19:
                        Db_BF_3GXJ.Value = 5130;
                        Db_BF_3DKJ.Value = 366;
                        Db_BF_3MJJ.Value = 151.07;
                        break;
                    case 20:
                        Db_BF_3GXJ.Value = 5495;
                        Db_BF_3DKJ.Value = 393;
                        Db_BF_3MJJ.Value = 154.42;
                        break;
                    case 21:
                        Db_BF_3GXJ.Value = 7598;
                        Db_BF_3DKJ.Value = 475;
                        Db_BF_3MJJ.Value = 204.51;
                        break;
                    case 22:
                        Db_BF_3GXJ.Value = 8144;
                        Db_BF_3DKJ.Value = 509;
                        Db_BF_3MJJ.Value = 208.79;
                        break;
                    case 23:
                        Db_BF_3GXJ.Value = 8690;
                        Db_BF_3DKJ.Value = 543;
                        Db_BF_3MJJ.Value = 213.08;
                        break;
                    case 24:
                        Db_BF_3GXJ.Value = 11870;
                        Db_BF_3DKJ.Value = 660;
                        Db_BF_3MJJ.Value = 283.32;
                        break;
                    case 25:
                        Db_BF_3GXJ.Value = 12650;
                        Db_BF_3DKJ.Value = 703;
                        Db_BF_3MJJ.Value = 288.82;
                        break;
                    case 26:
                        Db_BF_3GXJ.Value = 13430;
                        Db_BF_3DKJ.Value = 746;
                        Db_BF_3MJJ.Value = 294.32;
                        break;
                    case 27:
                        Db_BF_3GXJ.Value = 17580;
                        Db_BF_3DKJ.Value = 879;
                        Db_BF_3MJJ.Value = 367.81;
                        break;
                    case 28:
                        Db_BF_3GXJ.Value = 18640;
                        Db_BF_3DKJ.Value = 932;
                        Db_BF_3MJJ.Value = 374.69;
                        break;
                    case 29:
                        Db_BF_3GXJ.Value = 19710;
                        Db_BF_3DKJ.Value = 986;
                        Db_BF_3MJJ.Value = 381.56;
                        break;
                }
            }
            else if (Cb_BF_3XLCZ.SelectedIndex == 4)//钢管
            {
                switch (Cb_BF_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_3GXJ.Value = 12.19;
                        Db_BF_3DKJ.Value = 5.08;
                        Db_BF_3MJJ.Value = 7.78;
                        break;
                    case 1:
                        Db_BF_3GXJ.Value = 11.5;
                        Db_BF_3DKJ.Value = 4.79;
                        Db_BF_3MJJ.Value = 7.73;
                        break;
                    case 2:
                        Db_BF_3GXJ.Value = 11.36;
                        Db_BF_3DKJ.Value = 4.73;
                        Db_BF_3MJJ.Value = 7.72;
                        break;
                    case 3:
                        Db_BF_3GXJ.Value = 10.78;
                        Db_BF_3DKJ.Value = 4.49;
                        Db_BF_3MJJ.Value = 7.67;
                        break;
                    case 4:
                        Db_BF_3GXJ.Value = 13.08;
                        Db_BF_3DKJ.Value = 5.13;
                        Db_BF_3MJJ.Value = 9.16;
                        break;
                }
            }
        }

        private void Cb_BF_4ZLCZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_BF_4ZLCZ.SelectedIndex == 0)//方木
            {
                Cb_BF_4JMLX.Enabled = Db_BF_4MJJ.Enabled = false;
                Db_BF_4FMG.Enabled = Db_BF_4FMK.Enabled = true;
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 1)//方钢管
            {
                Cb_BF_4JMLX.Enabled = Db_BF_4MJJ.Enabled = true;
                Db_BF_4FMG.Enabled = Db_BF_4FMK.Enabled = false;
                Cb_BF_4JMLX.Items.Clear();
                Cb_BF_4JMLX.Items.Add("□60×40×2.5"); Cb_BF_4JMLX.Items.Add("□80×40×2"); Cb_BF_4JMLX.Items.Add("□100×50×3");
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 2)//工字钢
            {
                Cb_BF_4JMLX.Enabled = Db_BF_4MJJ.Enabled = true;
                Db_BF_4FMG.Enabled = Db_BF_4FMK.Enabled = false;
                Cb_BF_4JMLX.Items.Clear();
                Cb_BF_4JMLX.Items.Add("10号"); Cb_BF_4JMLX.Items.Add("12.6号"); Cb_BF_4JMLX.Items.Add("14号"); Cb_BF_4JMLX.Items.Add("16号"); Cb_BF_4JMLX.Items.Add("18号");
                Cb_BF_4JMLX.Items.Add("20a号"); Cb_BF_4JMLX.Items.Add("20b号"); Cb_BF_4JMLX.Items.Add("22a号"); Cb_BF_4JMLX.Items.Add("22b号"); Cb_BF_4JMLX.Items.Add("25a号");
                Cb_BF_4JMLX.Items.Add("25b号"); Cb_BF_4JMLX.Items.Add("28a号"); Cb_BF_4JMLX.Items.Add("28b号"); Cb_BF_4JMLX.Items.Add("32a号"); Cb_BF_4JMLX.Items.Add("32b号");
                Cb_BF_4JMLX.Items.Add("32c号"); Cb_BF_4JMLX.Items.Add("36a号"); Cb_BF_4JMLX.Items.Add("36b号"); Cb_BF_4JMLX.Items.Add("36c号"); Cb_BF_4JMLX.Items.Add("40a号");
                Cb_BF_4JMLX.Items.Add("40b号"); Cb_BF_4JMLX.Items.Add("40c号"); Cb_BF_4JMLX.Items.Add("45a号"); Cb_BF_4JMLX.Items.Add("45b号"); Cb_BF_4JMLX.Items.Add("45c号");
                Cb_BF_4JMLX.Items.Add("50a号"); Cb_BF_4JMLX.Items.Add("50b号"); Cb_BF_4JMLX.Items.Add("50c号"); Cb_BF_4JMLX.Items.Add("56a号"); Cb_BF_4JMLX.Items.Add("56b号");
                Cb_BF_4JMLX.Items.Add("56c号"); Cb_BF_4JMLX.Items.Add("63a号"); Cb_BF_4JMLX.Items.Add("63b号"); Cb_BF_4JMLX.Items.Add("63c号");
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 3)//槽钢
            {
                Cb_BF_4JMLX.Enabled = Db_BF_4MJJ.Enabled = true;
                Db_BF_4FMG.Enabled = Db_BF_4FMK.Enabled = false;
                Cb_BF_4JMLX.Items.Clear();
                Cb_BF_4JMLX.Items.Add("5号"); Cb_BF_4JMLX.Items.Add("6.3号"); Cb_BF_4JMLX.Items.Add("8号"); Cb_BF_4JMLX.Items.Add("10号"); Cb_BF_4JMLX.Items.Add("12.6号");
                Cb_BF_4JMLX.Items.Add("14a号"); Cb_BF_4JMLX.Items.Add("14b号"); Cb_BF_4JMLX.Items.Add("16a号"); Cb_BF_4JMLX.Items.Add("16b号"); Cb_BF_4JMLX.Items.Add("18a号");
                Cb_BF_4JMLX.Items.Add("18b号"); Cb_BF_4JMLX.Items.Add("20a号"); Cb_BF_4JMLX.Items.Add("20b号"); Cb_BF_4JMLX.Items.Add("22a号"); Cb_BF_4JMLX.Items.Add("22b号");
                Cb_BF_4JMLX.Items.Add("25a号"); Cb_BF_4JMLX.Items.Add("25b号"); Cb_BF_4JMLX.Items.Add("25c号"); Cb_BF_4JMLX.Items.Add("28a号"); Cb_BF_4JMLX.Items.Add("28b号");
                Cb_BF_4JMLX.Items.Add("28c号"); Cb_BF_4JMLX.Items.Add("32a号"); Cb_BF_4JMLX.Items.Add("32b号"); Cb_BF_4JMLX.Items.Add("32c号"); Cb_BF_4JMLX.Items.Add("36a号");
                Cb_BF_4JMLX.Items.Add("36b号"); Cb_BF_4JMLX.Items.Add("36c号"); Cb_BF_4JMLX.Items.Add("40a号"); Cb_BF_4JMLX.Items.Add("40b号"); Cb_BF_4JMLX.Items.Add("40c号");
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 4)//钢管
            {
                Cb_BF_4JMLX.Enabled = Db_BF_4MJJ.Enabled = true;
                Db_BF_4FMG.Enabled = Db_BF_4FMK.Enabled = false;
                Cb_BF_4JMLX.Items.Clear();
                Cb_BF_4JMLX.Items.Add("φ48×3.5"); Cb_BF_4JMLX.Items.Add("φ48×3.25"); Cb_BF_4JMLX.Items.Add("φ48×3.2"); Cb_BF_4JMLX.Items.Add("φ48×3"); Cb_BF_4JMLX.Items.Add("φ51×3");
            }

        }

        private void Db_BF_4FMK_ValueChanged(object sender, EventArgs e)
        {
            Db_BF_4GXJ.Value = Math.Round((Db_BF_4FMK.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value / 12 / 10000), 2);
            Db_BF_4DKJ.Value = Math.Round((Db_BF_4FMK.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value / 12 / 1000), 2);
        }

        private void Db_BF_4FMG_ValueChanged(object sender, EventArgs e)
        {
            Db_BF_4GXJ.Value = Math.Round((Db_BF_4FMK.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value / 12 / 10000), 2);
            Db_BF_4DKJ.Value = Math.Round((Db_BF_4FMK.Value * Db_BF_4FMG.Value * Db_BF_4FMG.Value / 12 / 1000), 2);
        }

        private void Cb_BF_4JMLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_BF_4ZLCZ.SelectedIndex == 1)//方钢管
            {
                switch (Cb_BF_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_4GXJ.Value = 21.88;
                        Db_BF_4DKJ.Value = 7.29;
                        Db_BF_4MJJ.Value = 3.58;
                        break;
                    case 1:
                        Db_BF_4GXJ.Value = 37.13;
                        Db_BF_4DKJ.Value = 9.28;
                        Db_BF_4MJJ.Value = 3.69;
                        break;
                    case 2:
                        Db_BF_4GXJ.Value = 112.12;
                        Db_BF_4DKJ.Value = 22.42;
                        Db_BF_4MJJ.Value = 8.50;
                        break;
                }
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 2)//工字钢
            {
                switch (Cb_BF_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_4GXJ.Value = 245;
                        Db_BF_4DKJ.Value = 49;
                        Db_BF_4MJJ.Value = 28.52;
                        break;
                    case 1:
                        Db_BF_4GXJ.Value = 488.99;
                        Db_BF_4DKJ.Value = 77.53;
                        Db_BF_4MJJ.Value = 29.05;
                        break;
                    case 2:
                        Db_BF_4GXJ.Value = 712;
                        Db_BF_4DKJ.Value = 102;
                        Db_BF_4MJJ.Value = 59.33;
                        break;
                    case 3:
                        Db_BF_4GXJ.Value = 1130;
                        Db_BF_4DKJ.Value = 141;
                        Db_BF_4MJJ.Value = 81.88;
                        break;
                    case 4:
                        Db_BF_4GXJ.Value = 1660;
                        Db_BF_4DKJ.Value = 185;
                        Db_BF_4MJJ.Value = 107.79;
                        break;
                    case 5:
                        Db_BF_4GXJ.Value = 2370;
                        Db_BF_4DKJ.Value = 237;
                        Db_BF_4MJJ.Value = 137.79;
                        break;
                    case 6:
                        Db_BF_4GXJ.Value = 2550;
                        Db_BF_4DKJ.Value = 250;
                        Db_BF_4MJJ.Value = 147.93;
                        break;
                    case 7:
                        Db_BF_4GXJ.Value = 3400;
                        Db_BF_4DKJ.Value = 309;
                        Db_BF_4MJJ.Value = 179.89;
                        break;
                    case 8:
                        Db_BF_4GXJ.Value = 3570;
                        Db_BF_4DKJ.Value = 325;
                        Db_BF_4MJJ.Value = 190.911;//小数点后三位精确不到
                        break;
                    case 10:
                        Db_BF_4GXJ.Value = 5023.54;
                        Db_BF_4DKJ.Value = 401.88;
                        Db_BF_4MJJ.Value = 232.41;
                        break;
                    case 11:
                        Db_BF_4GXJ.Value = 5283.96;
                        Db_BF_4DKJ.Value = 422.72;
                        Db_BF_4MJJ.Value = 247.89;
                        break;
                    case 12:
                        Db_BF_4GXJ.Value = 7114.14;
                        Db_BF_4DKJ.Value = 508.15;
                        Db_BF_4MJJ.Value = 289.02;
                        break;
                    case 13:
                        Db_BF_4GXJ.Value = 7480;
                        Db_BF_4DKJ.Value = 534.29;
                        Db_BF_4MJJ.Value = 309.09;
                        break;
                    case 14:
                        Db_BF_4GXJ.Value = 11075.5;
                        Db_BF_4DKJ.Value = 682.2;
                        Db_BF_4MJJ.Value = 402.91;
                        break;
                    case 15:
                        Db_BF_4GXJ.Value = 11621.4;
                        Db_BF_4DKJ.Value = 726.33;
                        Db_BF_4MJJ.Value = 428.78;
                        break;
                    case 16:
                        Db_BF_4GXJ.Value = 12167.5;
                        Db_BF_4DKJ.Value = 760.47;
                        Db_BF_4MJJ.Value = 454.10;
                        break;
                    case 17:
                        Db_BF_4GXJ.Value = 15760;
                        Db_BF_4DKJ.Value = 875;
                        Db_BF_4MJJ.Value = 513.36;
                        break;
                    case 18:
                        Db_BF_4GXJ.Value = 16530;
                        Db_BF_4DKJ.Value = 919;
                        Db_BF_4MJJ.Value = 545.55;
                        break;
                    case 19:
                        Db_BF_4GXJ.Value = 17310;
                        Db_BF_4DKJ.Value = 962;
                        Db_BF_4MJJ.Value = 578.93;
                        break;
                    case 20:
                        Db_BF_4GXJ.Value = 21720;
                        Db_BF_4DKJ.Value = 1090;
                        Db_BF_4MJJ.Value = 636.95;
                        break;
                    case 21:
                        Db_BF_4GXJ.Value = 22780;
                        Db_BF_4DKJ.Value = 1140;
                        Db_BF_4MJJ.Value = 677.98;
                        break;
                    case 22:
                        Db_BF_4GXJ.Value = 23850;
                        Db_BF_4DKJ.Value = 1190;
                        Db_BF_4MJJ.Value = 718.37;
                        break;
                    case 23:
                        Db_BF_4GXJ.Value = 32240;
                        Db_BF_4DKJ.Value = 1430;
                        Db_BF_4MJJ.Value = 835.23;
                        break;
                    case 24:
                        Db_BF_4GXJ.Value = 33760;
                        Db_BF_4DKJ.Value = 1500;
                        Db_BF_4MJJ.Value = 888.42;
                        break;
                    case 25:
                        Db_BF_4GXJ.Value = 35280;
                        Db_BF_4DKJ.Value = 1570;
                        Db_BF_4MJJ.Value = 938.3;
                        break;
                    case 26:
                        Db_BF_4GXJ.Value = 46470;
                        Db_BF_4DKJ.Value = 1860;
                        Db_BF_4MJJ.Value = 1085.75;
                        break;
                    case 27:
                        Db_BF_4GXJ.Value = 48560;
                        Db_BF_4DKJ.Value = 1940;
                        Db_BF_4MJJ.Value = 1145.28;
                        break;
                    case 28:
                        Db_BF_4GXJ.Value = 50640;
                        Db_BF_4DKJ.Value = 2080;
                        Db_BF_4MJJ.Value = 1211.48;
                        break;
                    case 29:
                        Db_BF_4GXJ.Value = 65585.6;
                        Db_BF_4DKJ.Value = 2342.31;
                        Db_BF_4MJJ.Value = 1375.05;
                        break;
                    case 30:
                        Db_BF_4GXJ.Value = 68512.5;
                        Db_BF_4DKJ.Value = 2446.69;
                        Db_BF_4MJJ.Value = 1451.48;
                        break;
                    case 31:
                        Db_BF_4GXJ.Value = 71439.4;
                        Db_BF_4DKJ.Value = 2551.41;
                        Db_BF_4MJJ.Value = 1529.76;
                        break;
                    case 32:
                        Db_BF_4GXJ.Value = 93916.2;
                        Db_BF_4DKJ.Value = 2981.47;
                        Db_BF_4MJJ.Value = 1732.84;
                        break;
                    case 33:
                        Db_BF_4GXJ.Value = 98083.6;
                        Db_BF_4DKJ.Value = 3163.38;
                        Db_BF_4MJJ.Value = 1833.27;
                        break;
                    case 34:
                        Db_BF_4GXJ.Value = 102251.1;
                        Db_BF_4DKJ.Value = 3298.42;
                        Db_BF_4MJJ.Value = 1932.89;
                        break;
                }
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 3)//槽钢
            {
                switch (Cb_BF_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_4GXJ.Value = 26;
                        Db_BF_4DKJ.Value = 10.4;
                        Db_BF_4MJJ.Value = 5.84;
                        break;
                    case 1:
                        Db_BF_4GXJ.Value = 50.79;
                        Db_BF_4DKJ.Value = 16.12;
                        Db_BF_4MJJ.Value = 8.77;
                        break;
                    case 2:
                        Db_BF_4GXJ.Value = 101.3;
                        Db_BF_4DKJ.Value = 25.3;
                        Db_BF_4MJJ.Value = 13.11;
                        break;
                    case 3:
                        Db_BF_4GXJ.Value = 198;
                        Db_BF_4DKJ.Value = 39.7;
                        Db_BF_4MJJ.Value = 19.85;
                        break;
                    case 4:
                        Db_BF_4GXJ.Value = 391;
                        Db_BF_4DKJ.Value = 62.1;
                        Db_BF_4MJJ.Value = 30.06;
                        break;
                    case 5:
                        Db_BF_4GXJ.Value = 564;
                        Db_BF_4DKJ.Value = 80.5;
                        Db_BF_4MJJ.Value = 38.50;
                        break;
                    case 6:
                        Db_BF_4GXJ.Value = 609;
                        Db_BF_4DKJ.Value = 87.1;
                        Db_BF_4MJJ.Value = 39.74;
                        break;
                    case 7:
                        Db_BF_4GXJ.Value = 866;
                        Db_BF_4DKJ.Value = 108;
                        Db_BF_4MJJ.Value = 50.45;
                        break;
                    case 8:
                        Db_BF_4GXJ.Value = 934;
                        Db_BF_4DKJ.Value = 117;
                        Db_BF_4MJJ.Value = 51.95;
                        break;
                    case 9:
                        Db_BF_4GXJ.Value = 1273;
                        Db_BF_4DKJ.Value = 141;
                        Db_BF_4MJJ.Value = 64.90;
                        break;
                    case 10:
                        Db_BF_4GXJ.Value = 1370;
                        Db_BF_4DKJ.Value = 152;
                        Db_BF_4MJJ.Value = 66.68;
                        break;
                    case 11:
                        Db_BF_4GXJ.Value = 1780;
                        Db_BF_4DKJ.Value = 178;
                        Db_BF_4MJJ.Value = 81.17;
                        break;
                    case 12:
                        Db_BF_4GXJ.Value = 1914;
                        Db_BF_4DKJ.Value = 191;
                        Db_BF_4MJJ.Value = 83.25;
                        break;
                    case 13:
                        Db_BF_4GXJ.Value = 2394;
                        Db_BF_4DKJ.Value = 218;
                        Db_BF_4MJJ.Value = 98.73;
                        break;
                    case 14:
                        Db_BF_4GXJ.Value = 2571;
                        Db_BF_4DKJ.Value = 234;
                        Db_BF_4MJJ.Value = 101.13;
                        break;
                    case 15:
                        Db_BF_4GXJ.Value = 3370;
                        Db_BF_4DKJ.Value = 270;
                        Db_BF_4MJJ.Value = 119.91;
                        break;
                    case 16:
                        Db_BF_4GXJ.Value = 3530;
                        Db_BF_4DKJ.Value = 282;
                        Db_BF_4MJJ.Value = 122.77;
                        break;
                    case 17:
                        Db_BF_4GXJ.Value = 3696;
                        Db_BF_4DKJ.Value = 295;
                        Db_BF_4MJJ.Value = 125.62;
                        break;
                    case 18:
                        Db_BF_4GXJ.Value = 4765;
                        Db_BF_4DKJ.Value = 340;
                        Db_BF_4MJJ.Value = 147.73;
                        break;
                    case 19:
                        Db_BF_4GXJ.Value = 5130;
                        Db_BF_4DKJ.Value = 366;
                        Db_BF_4MJJ.Value = 151.07;
                        break;
                    case 20:
                        Db_BF_4GXJ.Value = 5495;
                        Db_BF_4DKJ.Value = 393;
                        Db_BF_4MJJ.Value = 154.42;
                        break;
                    case 21:
                        Db_BF_4GXJ.Value = 7598;
                        Db_BF_4DKJ.Value = 475;
                        Db_BF_4MJJ.Value = 204.51;
                        break;
                    case 22:
                        Db_BF_4GXJ.Value = 8144;
                        Db_BF_4DKJ.Value = 509;
                        Db_BF_4MJJ.Value = 208.79;
                        break;
                    case 23:
                        Db_BF_4GXJ.Value = 8690;
                        Db_BF_4DKJ.Value = 543;
                        Db_BF_4MJJ.Value = 213.08;
                        break;
                    case 24:
                        Db_BF_4GXJ.Value = 11870;
                        Db_BF_4DKJ.Value = 660;
                        Db_BF_4MJJ.Value = 283.32;
                        break;
                    case 25:
                        Db_BF_4GXJ.Value = 12650;
                        Db_BF_4DKJ.Value = 703;
                        Db_BF_4MJJ.Value = 288.82;
                        break;
                    case 26:
                        Db_BF_4GXJ.Value = 13430;
                        Db_BF_4DKJ.Value = 746;
                        Db_BF_4MJJ.Value = 294.32;
                        break;
                    case 27:
                        Db_BF_4GXJ.Value = 17580;
                        Db_BF_4DKJ.Value = 879;
                        Db_BF_4MJJ.Value = 367.81;
                        break;
                    case 28:
                        Db_BF_4GXJ.Value = 18640;
                        Db_BF_4DKJ.Value = 932;
                        Db_BF_4MJJ.Value = 374.69;
                        break;
                    case 29:
                        Db_BF_4GXJ.Value = 19710;
                        Db_BF_4DKJ.Value = 986;
                        Db_BF_4MJJ.Value = 381.56;
                        break;
                }
            }
            else if (Cb_BF_4ZLCZ.SelectedIndex == 4)//钢管
            {
                switch (Cb_BF_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_BF_4GXJ.Value = 12.19;
                        Db_BF_4DKJ.Value = 5.08;
                        Db_BF_4MJJ.Value = 7.78;
                        break;
                    case 1:
                        Db_BF_4GXJ.Value = 11.5;
                        Db_BF_4DKJ.Value = 4.79;
                        Db_BF_4MJJ.Value = 7.73;
                        break;
                    case 2:
                        Db_BF_4GXJ.Value = 11.36;
                        Db_BF_4DKJ.Value = 4.73;
                        Db_BF_4MJJ.Value = 7.72;
                        break;
                    case 3:
                        Db_BF_4GXJ.Value = 10.78;
                        Db_BF_4DKJ.Value = 4.49;
                        Db_BF_4MJJ.Value = 7.67;
                        break;
                    case 4:
                        Db_BF_4GXJ.Value = 13.08;
                        Db_BF_4DKJ.Value = 5.13;
                        Db_BF_4MJJ.Value = 9.16;
                        break;
                }
            }
        }

        private void Btn_BF_5SearchChart_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(13);
            showchart.ShowDialog();
        }

        private void Cb_BF_5GGLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cb_BF_5GGLX.SelectedIndex)
            { 
                case 0:
                    Tb_BF_5HZBJ.Text = "15.8";
                    Tb_BF_5LZJMMJ.Text = "489";
                    Tb_BF_5JMDKJ.Text = "5.08";
                    break;
                case 1:
                    Tb_BF_5HZBJ.Text = "15.9";
                    Tb_BF_5LZJMMJ.Text = "457";
                    Tb_BF_5JMDKJ.Text = "4.79";
                    break;
                case 2:
                    Tb_BF_5HZBJ.Text = "15.9";
                    Tb_BF_5LZJMMJ.Text = "450";
                    Tb_BF_5JMDKJ.Text = "4.73";
                    break;
                case 3:
                    Tb_BF_5HZBJ.Text = "15.9";
                    Tb_BF_5LZJMMJ.Text = "424";
                    Tb_BF_5JMDKJ.Text = "4.49";
                    break;
                case 4:
                    Tb_BF_5HZBJ.Text = "17";
                    Tb_BF_5LZJMMJ.Text = "452";
                    Tb_BF_5JMDKJ.Text = "5.13";
                    break;
            }
        }

        private void Cb_BF_7ZYWZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_BF_7ZYWZ.SelectedIndex == 1)
            {
                Cb_BF_7DJTLX.Enabled = Db_BF_7SJZ.Enabled = Cb_BF_7ZJXS.Enabled = Db_BF_7DMMJ.Enabled = false;
            }
            else
            {
                Cb_BF_7DJTLX.Enabled = Db_BF_7SJZ.Enabled = Cb_BF_7ZJXS.Enabled = Db_BF_7DMMJ.Enabled = true;
            }
        }

        private void Btn_BF_7SearchChart_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(Cb_BF_7DJTLX.SelectedIndex);
            showchart.ShowDialog();
        }

        #region  //BFtabItem6风荷载参数，由省份地区确定地区风压
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

        private void Cb_BF_6SF_SelectedIndexChanged(object sender, EventArgs e)
        {//BFtabItem6中省份确定触发事件
            Cb_BF_6DQ.Items.Clear();
            Cb_BF_6DQ.Text = "";
            Tb_BF_6SFDQFY.Text = "";
            string[] province = new string[] { };
            switch (Cb_BF_6SF.SelectedItem.ToString())
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
                Cb_BF_6DQ.Items.Add(item);
            }
            Cb_BF_6DQ.Refresh();

        }

        private void Cb_BF_6DQ_SelectedIndexChanged(object sender, EventArgs e)
        {//BFtabItem6中地区确定触发事件
            string[] province = new string[] { };
            switch (Cb_BF_6SF.SelectedItem.ToString())
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
                if (Cb_BF_6DQ.SelectedItem.ToString() == city_tempreture[0])
                {
                    Tb_BF_6SFDQFY.Text = city_tempreture[1];
                    break;
                }
            }
        }

        #endregion

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
                object[] obj = new object[] { };
                Framework.Entity.Template item = new Framework.Entity.Template();
                string itemtext = "";

                #region 表A.0.6轴心受压构件的稳定系数Φ(Q235钢)
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
                if (CbxBeamFormType.SelectedIndex == 0)
                {
                 itemtext = "梁模板(碗扣)";

                #region 参数赋值
                //BFtabItem1构造参数
                double bf1_1, bf1_2, bf1_3, bf1_4, bf1_5, bf1_7, bf1_8, bf1_9, bf1_10, bf1_11, bf1_12, bf1_13, bf1_14, bf1_16, bf1_17, bf1_18, bf1_19;
                string bf1_6, bf1_15, ZCJJ;

                bf1_1 = Db_BF_KD.Value;
                bf1_2 = Db_BF_CG.Value;
                bf1_3 = Db_BF_CCG.Value;
                bf1_4 = Db_BF_CCK.Value;
                bf1_5 = Db_BF_HD.Value;
                bf1_6 = Tb_BF_ZCFS.Text;
                bf1_7 = Db_BF_XLSL.Value;
                bf1_8 = Db_BF_ZLCD.Value;
                bf1_9 = Convert.ToDouble(Cb_BF_BJ.Text);
                bf1_10 = Convert.ToDouble(Cb_BF_JJ.Text);
                bf1_11 = Db_BF_JJ.Value;
                bf1_12 = Db_BF_XTCD.Value;
                bf1_13 = Db_BF_XLJJ.Value;
                bf1_14 = Db_BF_LZGS.Value;
                bf1_15 = Tb_BF_ZCFS.Text;
                bf1_16 = Db_BF_ZCJJ1.Value;
                bf1_17 = Db_BF_ZCJJ2.Value;
                bf1_18 = Db_BF_ZCJJ3.Value;
                bf1_19 = Db_BF_ZCJJ4.Value;

                if (bf1_14 == 0)
                {
                    ZCJJ = "";
                }
                else if (bf1_14 == 1)
                {
                    ZCJJ = Convert.ToString(bf1_16);
                }
                else if (bf1_14 == 2)
                {
                    ZCJJ = bf1_16 + "," + bf1_17;
                }
                else if (bf1_14 == 3)
                {
                    ZCJJ = bf1_16 + "," + bf1_17 + "," + bf1_18;
                }
                else
                {
                    ZCJJ = bf1_16 + "," + bf1_17 + "," + bf1_18 + "," + bf1_19;
                }

                //BFtabItem2支撑参数+面板
                double bf2_3, bf2_4, bf2_5;
                string bf2_1, bf2_2;

                bf2_1 = Cb_BF_2JDCLX.Text;
                bf2_2 = Cb_BF_2MBLX.Text;
                bf2_3 = Db_BF_2MBHD.Value;
                bf2_4 = Db_BF_2QD.Value;
                bf2_5 = Db_BF_2TXML.Value;

                //BFtabItem3小梁
                string bf3_1, bf3_2;
                double bf3_3, bf3_4, bf3_5, bf3_6, bf3_7, bf3_8, bf3_9, bf3_10;

                bf3_1 = Cb_BF_3XLCZ.Text;
                bf3_2 = Cb_BF_3JMLX.Text;
                bf3_3 = Db_BF_3FMK.Value;
                bf3_4 = Db_BF_3FMG.Value;
                bf3_5 = Db_BF_3KWQD.Value;
                bf3_6 = Db_BF_3KJQD.Value;
                bf3_7 = Db_BF_3TXML.Value;
                bf3_8 = Db_BF_3GXJ.Value;
                bf3_9 = Db_BF_3DKJ.Value;
                bf3_10 = Db_BF_3MJJ.Value;

                //BFtabItem4主梁
                string bf4_1, bf4_2;
                double bf4_3, bf4_4, bf4_5, bf4_6, bf4_7, bf4_8, bf4_9, bf4_10;

                bf4_1 = Cb_BF_4ZLCZ.Text;
                bf4_2 = Cb_BF_4JMLX.Text;
                bf4_3 = Db_BF_4FMK.Value;
                bf4_4 = Db_BF_4FMG.Value;
                bf4_5 = Db_BF_4KWQD.Value;
                bf4_6 = Db_BF_4KJQD.Value;
                bf4_7 = Db_BF_4TXML.Value;
                bf4_8 = Db_BF_4GXJ.Value;
                bf4_9 = Db_BF_4DKJ.Value;
                bf4_10 = Db_BF_4MJJ.Value;

                //BFtabItem5立柱
                string bf5_1;
                double bf5_2, bf5_3, bf5_4, bf5_5;

                bf5_1 = Cb_BF_5GGLX.Text;
                bf5_2 = Convert.ToDouble(Tb_BF_5HZBJ.Text);
                bf5_3 = Db_BF_5KYQD.Value;
                bf5_4 = Convert.ToDouble(Tb_BF_5LZJMMJ.Text);
                bf5_5 = Convert.ToDouble(Tb_BF_5JMDKJ.Text);

                //BFtabItem6风荷载
                string bf6_1, bf6_2;
                double bf6_3, bf6_4, bf6_5, bf6_6, bf6_7;

                bf6_1 = Cb_BF_6SF.Text;
                bf6_2 = Cb_BF_6DQ.Text;
                bf6_3 = Convert.ToDouble(Tb_BF_6SFDQFY.Text);
                bf6_4 = Db_BF_6GD.Value;
                bf6_5 = Db_BF_6GDBHXS.Value;
                bf6_6 = Db_BF_6TXXS.Value;
                bf6_7 = Db_BF_6BZZ.Value;

                //BFtabItem7可调托座+地基基础
                string bf7_3, bf7_4;
                double bf7_1, bf7_2, bf7_5, bf7_6, bf7_7;
                double[] zjxs = new double[] { 1.0, 0.9, 0.5, 0.8, 0.4 };

                bf7_1 = Convert.ToDouble(Cb_BF_7ZLGS.Text);
                bf7_2 = Db_BF_7CZL.Value;
                bf7_3 = Cb_BF_7ZYWZ.Text;
                bf7_4 = Cb_BF_7DJTLX.Text;
                bf7_5 = Db_BF_7SJZ.Value;
                bf7_6 = zjxs[Cb_BF_7ZJXS.SelectedIndex];
                bf7_7 = Db_BF_7DMMJ.Value;

                //BFtabItem8荷载参数
                double bf8_1, bf8_2, bf8_3, bf8_4, bf8_5, bf8_6, bf8_7, bf8_8;

                bf8_1 = Db_BF_8MBZZ.Value;
                bf8_2 = Db_BF_8MBJXLZZ.Value;
                bf8_3 = Db_BF_8LBMBZZ.Value;
                bf8_4 = Db_BF_8MBJZJZZ.Value;
                bf8_5 = Db_BF_8XJHNTZZ.Value;
                bf8_6 = Db_BF_8HNTLGJ.Value;
                bf8_7 = Db_BF_8HNTBGJ.Value;
                bf8_8 = Db_BF_8QZ.Value;
                #endregion

                #region 一、面板验算
                double sum1I, sum1W, sum1h, sum1L, sum1q1, sum1q1J, sum1q1H, sum1q2, sum1Mmax,
                    sum1σ, sum1vmax, sum1ν, sum1R1, sum1R2, sum1R3, sum1r1, sum1r2, sum1r3;
                double a1, b1;
                string compare1_1, compare1_2, result1_1, result1_2;

                sum1I = 1000 * bf2_3 * bf2_3 * bf2_3 / 12; //面板截面惯性矩I
                sum1W = 1000 * bf2_3 * bf2_3 / 6; //面板截面抵抗矩W
                sum1h = bf1_3 / 1000;
                sum1L = bf1_13 / 1000;
                a1 = 0.9 * (1.2 * (bf8_1 + (bf8_5 + bf8_6) * sum1h) + 1.4 * bf8_8);
                b1 = 0.9 * (1.35 * (bf8_1 + (bf8_5 + bf8_6) * sum1h) + 1.4 * 0.7 * bf8_8);
                sum1q1 = a1 > b1 ? a1 : b1;
                sum1q1J = 0.9 * 1.35 * (bf8_1 + (bf8_5 + bf8_6) * sum1h);
                sum1q1H = 0.9 * 1.4 * 0.7 * bf8_8;
                sum1q2 = (bf8_1 + (bf8_5 + bf8_6) * sum1h) * 1;
                sum1Mmax = -0.107 * sum1q1J * sum1L * sum1L + 0.121 * sum1q1H * sum1L * sum1L;
                sum1σ = sum1Mmax / sum1W;
                sum1Mmax = Math.Round(sum1Mmax, 2);
                sum1σ = Math.Round(sum1σ, 2);
                if (sum1σ <= bf2_4)
                {
                    compare1_1 = "面板的计算强度" + sum1σ + "小于等于面板抗弯强度设计值" + bf2_4 + "N/mm2,满足要求!";
                    result1_1 = "满足要求";
                }
                else
                {
                    compare1_1 = "面板的计算强度" + sum1σ + "大于面板抗弯强度设计值" + bf2_4 + "N/mm2,不满足要求!";
                    result1_1 = "满足要求";
                }
                sum1vmax = 0.632 * sum1q2 * sum1L * sum1L * sum1L * sum1L / 100 / bf2_5 / sum1I;
                sum1ν = sum1L / 400;
                sum1vmax = Math.Round(sum1vmax, 2);
                sum1ν = Math.Round(sum1ν, 2);
                if (sum1vmax < sum1ν)
                {
                    compare1_2 = "面板的挠度" + sum1vmax + "小于等于面板最大允许挠度值" + sum1ν + "mm,满足要求!";
                    result1_2 = "满足要求";
                }
                else
                {
                    compare1_2 = "面板的挠度" + sum1vmax + "大于面板最大允许挠度值" + sum1ν + "mm,不满足要求!";
                    result1_2 = "不满足要求";
                }

                sum1R1 = 0.393 * sum1q1J * sum1L + 0.446 * sum1q1H * sum1L;
                sum1R2 = 1.143 * sum1q1J * sum1L + 1.223 * sum1q1H * sum1L;
                sum1R3 = 0.928 * sum1q1J * sum1L + 1.142 * sum1q1H * sum1L;
                sum1r1 = 0.393 * sum1q2 * sum1L;
                sum1r2 = 1.143 * sum1q2 * sum1L;
                sum1r3 = 0.928 * sum1q2 * sum1L;

                sum1I = Math.Round(sum1I, 2);
                sum1W = Math.Round(sum1W, 2);
                sum1q1 = Math.Round(sum1q1, 2);
                sum1q1J = Math.Round(sum1q1J, 2);
                sum1q1H = Math.Round(sum1q1H, 2);
                sum1q2 = Math.Round(sum1q2, 2);
                sum1R1 = Math.Round(sum1R1, 2);
                sum1R2 = Math.Round(sum1R2, 2);
                sum1R3 = Math.Round(sum1R3, 2);
                sum1r1 = Math.Round(sum1r1, 2);
                sum1r2 = Math.Round(sum1r2, 2);
                sum1r3 = Math.Round(sum1r3, 2);

                #endregion

                #region 二、小梁验算
                double sum2q1, sum2q2, sum2Mmax, sum2σ, sum2Vmax, sum2τ, sum2ν1, sum2ν, sum2ν2, sum2ν_2;
                double a2, b2, c2, d2, e2, f2, g2, h2;
                string compare2_1, str_xlcz, compare2_2, compare2_3, compare2_4, result2_1, result2_2;

                c2 = sum1R1 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_7 - 1);
                d2 = sum1R2 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_7 - 1);
                sum2q1 = c2 > d2 ? c2 : d2;
                e2 = sum1r1 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_7 - 1);
                f2 = sum1r2 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_7 - 1);
                sum2q2 = e2 > f2 ? e2 : f2;
                g2 = 0.107 * sum2q1 * bf1_10 * bf1_10 / 1000 / 1000;
                h2 = 0.5 * sum2q1 * bf1_12 * bf1_12 / 1000 / 1000;
                sum2Mmax = g2 > h2 ? g2 : h2;
                sum2σ = sum2Mmax * 1000000 / bf3_9 / 1000;
                sum2σ = Math.Round(sum2σ, 2);
                if (sum2σ < bf3_5)
                {
                    compare2_1 = "小梁的计算强度" + sum2σ + "小于等于小梁抗弯强度设计值" + bf3_5 + "N/mm2,满足要求!";
                    result2_1 = "满足要求";
                }
                else
                {
                    compare2_1 = "小梁的计算强度" + sum2σ + "大于小梁抗弯强度设计值" + bf3_5 + "N/mm2,满足要求!";
                    result2_1 = "不满足要求";
                }

                a2 = 0.607 * sum2q1 * bf1_10 / 1000;
                b2 = sum2q1 * bf1_12 / 1000;
                sum2Vmax = a2 > b2 ? a2 : b2;
                if (Cb_BF_3XLCZ.SelectedIndex == 0)
                {
                    sum2τ = 3 * sum2Vmax * 1000 / (2 * bf3_3 * bf3_4);
                    sum2τ = Math.Round(sum2τ, 2);
                    str_xlcz = "τmax＝3Vmax/(2bh0)=" + sum2τ + "N/mm2";
                }
                else
                {
                    sum2τ = sum2Vmax * 1000 * bf3_10 * 1000 / (bf3_8 * 10000 * 7.6);//小梁厚度=7.6
                    sum2τ = Math.Round(sum2τ, 2);
                    str_xlcz = "τ =VSo/Itw=" + sum2τ + "N/mm2";
                }
                if (sum2τ <= bf3_6)
                {
                    compare2_2 = "小梁的计算强度" + sum2τ + "小于等于小梁抗剪强度设计值" + bf3_6 + "N/mm2,满足要求!";
                    result2_2 = "满足要求";
                }
                else
                {
                    compare2_2 = "小梁的计算强度" + sum2τ + "大于小梁抗剪强度设计值" + bf3_6 + "N/mm2,不满足要求!";
                    result2_2 = "不满足要求";
                }

                sum2ν1 = 0.632 * sum2q2 * bf1_10 * bf1_10 * bf1_10 * bf1_10 / (100 * bf3_7 * bf3_8);
                sum2ν = bf1_10 / 400;
                sum2ν1 = Math.Round(sum2ν1, 2);
                sum2ν = Math.Round(sum2ν, 2);
                if (sum2ν1 <= sum2ν)
                    compare2_3 = "小梁跨中的挠度" + sum2ν1 + "小于等于小梁跨中的最大允许挠度值" + sum2ν + "mm,满足要求!";
                else
                    compare2_3 = "小梁跨中的挠度" + sum2ν1 + "大于小梁跨中的最大允许挠度值" + sum2ν + "mm,不满足要求!";

                sum2ν2 = sum2q2 * bf1_12 * bf1_12 * bf1_12 * bf1_12 / (8 * bf3_7 * bf3_8);
                sum2ν_2 = bf1_12 / 400;
                sum2ν2 = Math.Round(sum2ν2, 2);
                sum2ν_2 = Math.Round(sum2ν_2, 2);
                if (sum2ν2 <= sum2ν_2)
                    compare2_4 = "小梁悬臂端的挠度" + sum2ν2 + "小于等于小梁悬臂端的最大允许挠度值" + sum2ν_2 + "mm,满足要求!";
                else
                    compare2_4 = "小梁悬臂端的挠度" + sum2ν2 + "大于小梁悬臂端的最大允许挠度值" + sum2ν_2 + "mm,不满足要求!";

                sum2q1 = Math.Round(sum2q1, 2);
                sum2q2 = Math.Round(sum2q2, 2);
                sum2Mmax = Math.Round(sum2Mmax, 2);
                sum2Vmax = Math.Round(sum2Vmax, 2);
                #endregion

                #region 三、主梁验算
                double sum3G2k, sum3G3k, sum3Gk, sum3q1, sum3q2, sum3q, sum3l, sum3M, sum3W, sum3σ, sum3qN, sum3v, sum3ν;
                string compare3_1, compare3_2, result3_1, result3_2;

                double[] zcjj = new double[] { Db_BF_ZCJJ1.Value, Db_BF_ZCJJ2.Value, Db_BF_ZCJJ3.Value, Db_BF_ZCJJ4.Value };
                double min = 0;

                int i = Convert.ToInt32(Db_BF_LZGS.Value);
                if (i == 0)
                {
                    sum3l = 0;
                }
                else
                {
                    min = zcjj[0];
                    for (int j = 1; j < i; j++)
                    {
                        if (min > zcjj[j])
                        {
                            min = zcjj[j];
                        }
                    }
                    sum3l = min / 1000;
                }

                sum3G2k = bf8_5 * bf1_3 / 1000;
                sum3G3k = bf8_7 * bf1_3 / 1000;
                sum3Gk = bf8_2 + sum3G2k + sum3G3k;
                sum3q1 = 0.9 * (1.2 * sum3Gk + 1.4 * bf8_8) * 0.8;
                sum3q2 = 0.9 * (1.35 * sum3Gk + 1.4 * 0.7 * bf8_8) * 0.8;
                sum3q = sum3q1 > sum3q2 ? sum3q1 : sum3q2;
                sum3M = sum3q * sum3l * sum3l / 8;
                sum3W = bf4_9 * 1000;
                sum3σ = sum3M * 1000 / sum3W;
                sum3σ = Math.Round(sum3σ, 2);
                if (sum3σ > bf4_5)
                {
                    compare3_1 = "主梁的计算强度" + sum3σ + "大于主梁抗弯强度设计值" + bf4_5 + "N/mm2,不满足要求!";
                    result3_1 = "满足要求";
                }
                else
                {
                    compare3_1 = "主梁的计算强度" + sum3σ + "小于等于主梁抗弯强度设计值" + bf4_5 + "N/mm2,满足要求!";
                    result3_1 = "不满足要求";
                }

                sum3qN = 0.8 * sum3Gk;
                sum3v = 5 * sum3qN * min * min * min * min / (384 * bf4_7 * bf4_8 * 10000);
                sum3ν = min / 400;
                sum3v = Math.Round(sum3v, 2);
                sum3ν = Math.Round(sum3ν, 2);
                if (sum3v > sum3ν)
                {
                    compare3_2 = "主梁跨中的挠度" + sum3v + "大于主梁跨中的最大允许挠度值" + sum3ν + "mm,不满足要求!";
                    result3_2 = "满足要求";
                }
                else
                {
                    compare3_2 = "主梁跨中的挠度" + sum3v + "小于等于主梁跨中的最大允许挠度值" + sum3ν + "mm,满足要求!";
                    result3_2 = "不满足要求";
                }

                sum3G2k = Math.Round(sum3G2k, 2);
                sum3G3k = Math.Round(sum3G3k, 2);
                sum3Gk = Math.Round(sum3Gk, 2);
                sum3q1 = Math.Round(sum3q1, 2);
                sum3q2 = Math.Round(sum3q2, 2);
                sum3q = Math.Round(sum3q, 2);
                sum3M = Math.Round(sum3M, 2);
                sum3qN = Math.Round(sum3qN, 2);


                #endregion

                #region 四、立柱稳定性验算
                double sum4λ, sum4φ, sum4G1k, sum4G2k, sum4G3k, sum4Gk, sum4Qk, sum4ωk, sum4Mw, sum4Nw, sum4f;
                string compare4_1, compare4_2, result4_1, result4_2;

                sum4λ = bf1_9 / bf5_2;
                sum4λ = Math.Round(sum4λ, 2);
                if (sum4λ > 250)
                {
                    compare4_1 = "立柱长细比" + sum4λ + "大于立柱最大允许长细比250mm,不满足要求!";
                    result4_1 = "满足要求";
                }
                else
                {
                    compare4_1 = "立柱长细比" + sum4λ + "小于等于立柱最大允许长细比250mm,满足要求!";
                    result4_1 = "不满足要求";
                }

                if (sum4λ > 250)
                {
                    sum4φ = 7320 / sum4λ / sum4λ;
                }
                else if (Math.Floor(sum4λ) == sum4λ)
                {
                    int sum4λy = Convert.ToInt32(sum4λ / 10);//第λy1行
                    int sum4λx = Convert.ToInt32(sum4λ % 10);// 第λx1列
                    sum4φ = λArray[sum4λy, sum4λx]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                else
                {
                    double sum4λ_1, sum4λ_2, sum4φ1, sum4φ2;
                    sum4λ_1 = Math.Ceiling(sum4λ);//x1
                    sum4λ_2 = Math.Floor(sum4λ);//x0

                    int sum4λy1 = Convert.ToInt32(sum4λ_1 / 10);
                    int sum4λx1 = Convert.ToInt32(sum4λ_1 % 10);
                    sum4φ1 = λArray[sum4λy1, sum4λx1]; //y1

                    int sum4λy2 = Convert.ToInt32(sum4λ_2 / 10);
                    int sum4λx2 = Convert.ToInt32(sum4λ_2 % 10);
                    sum4φ2 = λArray[sum4λy2, sum4λx2]; //y0

                    sum4φ = (sum4λ - sum4λ_1) / (sum4λ_2 - sum4λ_1) * sum4φ2 + (sum4λ - sum4λ_2) / (sum4λ_1 - sum4λ_2) * sum4φ1;//拉格朗日插值
                }

                sum4G1k = bf8_4 * bf1_10 / 1000 * bf1_11 / 1000;
                sum4G2k = bf8_5 * bf1_4 / 1000 * bf1_3 / 1000 * bf1_10 / 1000;
                sum4G3k = bf8_6 * bf1_4 / 1000 * bf1_3 / 1000 * bf1_10 / 1000;
                sum4Gk = sum4G1k + sum4G2k + sum4G3k;
                sum4Qk = bf8_8 * bf1_10 / 1000 * bf1_11 / 1000;
                sum4ωk = 0.7 * bf6_5 * bf6_6 * bf6_3;
                sum4Mw = 0.9 * 1.4 * sum4ωk * bf1_10 / 1000 * bf1_9 / 1000 * bf1_9 / 1000 / 10;
                sum4Nw = 1.2 * sum4Gk + 0.9 * 1.4 * sum4Qk + 0.9 * 1.4 * sum4Mw / (bf1_10 / 1000);
                sum4f = sum4Nw * 1000 / (sum4φ * bf5_4) + sum4Mw * 1000 / bf5_5;
                sum4f = Math.Round(sum4f, 2);
                if (sum4f > 205)
                {
                    compare4_2 = "立柱抗压强度" + sum4f + "大于立柱抗压强度设计值205N/mm2,不满足要求!";
                    result4_2 = "满足要求";
                }
                else
                {
                    compare4_2 = "立柱抗压强度" + sum4f + "小于等于立柱抗压强度设计值205N/mm2,不满足要求!";
                    result4_2 = "不满足要求";
                }

                sum4G1k = Math.Round(sum4G1k, 2);
                sum4G2k = Math.Round(sum4G2k, 2);
                sum4G3k = Math.Round(sum4G3k, 2);
                sum4Gk = Math.Round(sum4Gk, 2);
                sum4Qk = Math.Round(sum4Qk, 2);
                sum4ωk = Math.Round(sum4ωk, 2);
                sum4Mw = Math.Round(sum4Mw, 2);
                sum4Nw = Math.Round(sum4Nw, 2);
                sum4φ = Math.Round(sum4φ, 2);

                #endregion

                #region 五、可调托座验算
                double sum5N;
                string compare5_1, result5_1;

                sum5N = sum4Nw / bf7_1;
                sum5N = Math.Round(sum5N, 2);
                if (sum5N > bf7_2)
                {
                    compare5_1 = "可调托座受力" + sum5N + "大于可调托座承载力容许值" + bf7_2 + "（kN）,不满足要求!";
                    result5_1 = "满足要求";
                }
                else
                {
                    compare5_1 = "可调托座受力" + sum5N + "小于等于可调托座承载力容许值" + bf7_2 + "（kN）,满足要求!";
                    result5_1 = "不满足要求";
                }
                #endregion

                #region 六、立柱地基基础验算
                double sum6p;
                string compare6_1, result6_1;

                sum6p = sum4Nw / (bf7_6 * bf7_7 * bf7_1);
                sum6p = Math.Round(sum6p, 2);
                if (sum6p > bf7_5)
                {
                    compare6_1 = "立柱底垫板的底面平均压力" + sum6p + "大于地基土承载力设计值" + bf7_5 + "N/mm2,不满足要求!";
                    result6_1 = "满足要求";
                }
                else
                {
                    compare6_1 = "立柱底垫板的底面平均压力" + sum6p + "小于等于地基土承载力设计值" + bf7_5 + "N/mm2,满足要求!";
                    result6_1 = "不满足要求";
                }
                #endregion

                obj = new object[] { ZCJJ,bf1_1,bf1_2,bf1_3,bf1_4,bf1_5,bf1_6,bf1_7,bf1_8,bf1_9,bf1_10,bf1_11,bf1_12,bf1_13,bf1_14,bf1_15,bf2_1,
            bf2_2,bf2_3,bf2_4,bf2_5,bf3_1,bf3_2,bf3_5,bf3_6,bf3_7,bf3_8,bf3_9,bf4_1,bf4_2,bf4_5,bf4_6,bf4_7,bf4_8,bf4_9,bf5_1,bf5_2,bf5_3,
            bf5_4,bf5_5,bf6_1,bf6_2,bf6_3,bf6_4,bf6_5,bf6_6,bf6_7,bf7_1,bf7_2,bf7_3,bf7_4,bf7_5,bf7_6,bf7_7,bf8_1,bf8_2,bf8_3,bf8_4,bf8_5,
            bf8_6,bf8_7,bf8_8,sum1I,sum1W,sum1h,sum1L,sum1q1,sum1q1J,sum1q1H,sum1q2,sum1Mmax,sum1σ,compare1_1,sum1vmax,sum1ν,compare1_2,
            sum1R1,sum1R2,sum1R3,sum1r1,sum1r2,sum1r3,sum2q1,sum2q2,sum2Mmax,sum2σ,compare2_1,sum2Vmax,str_xlcz,compare2_2,sum2ν1,sum2ν,
            compare2_3,sum2ν2,sum2ν_2,compare2_4,sum3G2k,sum3G3k,sum3Gk,sum3q1,sum3q2,sum3q,sum3l,sum3M,sum3W,sum3σ,compare3_1,sum3qN,
            sum3v,min,sum3ν,compare3_2,sum4λ,compare4_1,sum4φ,sum4G1k,sum4G2k,sum4G3k,sum4Gk,sum4Qk,sum4ωk,sum4Mw,sum4Nw,sum4f,compare4_2,
            sum5N,compare5_1,sum6p,compare6_1,result1_1,result1_2,result2_1,result2_2,result3_1,result3_2,result4_1,result4_2,result5_1,result6_1};

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
      else if(CbxBeamFormType.SelectedIndex == 1)
    {

        itemtext = "梁模板(扣件)计算书";
                    
         #region 参数赋值
                //BFtabItem1构造参数
                double bf1_3, bf1_4,bf1_6, bf1_7,  bf1_11, bf1_12, bf1_13, bf1_1, bf1_2, bf1_5, bf1_8, bf1_14, bf1_16, bf1_17, bf1_18, bf1_19;

                string bf1_9="", bf1_10="", bf1_15="", ZCJJ="";

                bf1_1 = BF_KJ_KD.Value;
                bf1_2 = BF_KJ_CG.Value;
                bf1_3 = BF_KJ_CCG.Value;
                bf1_4 = BF_KJ_CCK.Value;
                bf1_5 = BF_KJ_HD.Value;
                bf1_6 = BF_KJ_BJ.Value;
                bf1_7 = BF_KJ_LZJJ.Value;
                bf1_8 = BF_KJ_JLZXJL.Value;
                bf1_9 = BF_KJ_ZCFS.Text;
                bf1_10 = BF_KJ_LZWZ.Text;
                bf1_11 = BF_KJ_LZJJa.Value;
                bf1_12 = BF_KJ_LZJJb.Value;
                bf1_13 = BF_KJ_XLGS.Value;
                bf1_14 = KJ_LZGS.Value;
                bf1_15 = BF_KJ_BZFS.Text;
                bf1_16 = KJ_JL1.Value;
                bf1_17 = KJ_JL2.Value;
                bf1_18=BF_KJ_XLJJ.Value;
                bf1_19=BF_KJ_XTCD.Value;




                if (bf1_14 == 0)
                {
                    ZCJJ = "";
                }
                else if (bf1_14 == 1)
                {
                    ZCJJ = Convert.ToString(bf1_16);
                }
                else 
                {
                    ZCJJ = bf1_16 + "," + bf1_17;
                }
                
                



                //BFtabItem2支撑参数+面板
                double bf2_3, bf2_4, bf2_5;
                string bf2_1="", bf2_2="";

                bf2_1 = Cb_BF_2JDCLX.Text;
                bf2_2 = Cb_BF_2MBLX.Text;
                bf2_3 = Db_BF_2MBHD.Value;
                bf2_4 = Db_BF_2QD.Value;
                bf2_5 = Db_BF_2TXML.Value;

                //BFtabItem3小梁
                string bf3_1="", bf3_2="";
                double bf3_3, bf3_4, bf3_5, bf3_6, bf3_7, bf3_8, bf3_9, bf3_10;

                bf3_1 = Cb_BF_3XLCZ.Text;
                bf3_2 = Cb_BF_3JMLX.Text;
                bf3_3 = Db_BF_3FMK.Value;
                bf3_4 = Db_BF_3FMG.Value;
                bf3_5 = Db_BF_3KWQD.Value;
                bf3_6 = Db_BF_3KJQD.Value;
                bf3_7 = Db_BF_3TXML.Value;
                bf3_8 = Db_BF_3GXJ.Value;
                bf3_9 = Db_BF_3DKJ.Value;
                bf3_10 = Db_BF_3MJJ.Value;

                //BFtabItem4主梁
                string bf4_1="", bf4_2="";
                double bf4_3, bf4_4, bf4_5, bf4_6, bf4_7, bf4_8, bf4_9, bf4_10;

                bf4_1 = Cb_BF_4ZLCZ.Text;
                bf4_2 = Cb_BF_4JMLX.Text;
                bf4_3 = Db_BF_4FMK.Value;
                bf4_4 = Db_BF_4FMG.Value;
                bf4_5 = Db_BF_4KWQD.Value;
                bf4_6 = Db_BF_4KJQD.Value;
                bf4_7 = Db_BF_4TXML.Value;
                bf4_8 = Db_BF_4GXJ.Value;
                bf4_9 = Db_BF_4DKJ.Value;
                bf4_10 = Db_BF_4MJJ.Value;

                //BFtabItem5立柱
                string bf5_1="";
                double bf5_2, bf5_3, bf5_4, bf5_5;

                bf5_1 = Cb_BF_5GGLX.Text;
                bf5_2 = Convert.ToDouble(Tb_BF_5HZBJ.Text);
                bf5_3 = Db_BF_5KYQD.Value;
                bf5_4 = Convert.ToDouble(Tb_BF_5LZJMMJ.Text);
                bf5_5 = Convert.ToDouble(Tb_BF_5JMDKJ.Text);

                //BFtabItem6风荷载
                string bf6_1="", bf6_2="";
                double bf6_3, bf6_4, bf6_5, bf6_6, bf6_7;

                bf6_1 = Cb_BF_6SF.Text;
                bf6_2 = Cb_BF_6DQ.Text;
                bf6_3 = Convert.ToDouble(Tb_BF_6SFDQFY.Text);
                bf6_4 = Db_BF_6GD.Value;
                bf6_5 = Db_BF_6GDBHXS.Value;
                bf6_6 = Db_BF_6TXXS.Value;
                bf6_7 = Db_BF_6BZZ.Value;

                //BFtabItem7可调托座+地基基础
                string bf7_3="", bf7_4="";
                double bf7_1, bf7_2, bf7_5, bf7_6, bf7_7;
                double[] zjxs = new double[] { 1.0, 0.9, 0.5, 0.8, 0.4 };

                bf7_1 = Convert.ToDouble(Cb_BF_7ZLGS.Text);
                bf7_2 = Db_BF_7CZL.Value;
                bf7_3 = Cb_BF_7ZYWZ.Text;
                bf7_4 = Cb_BF_7DJTLX.Text;
                bf7_5 = Db_BF_7SJZ.Value;
                bf7_6 = zjxs[Cb_BF_7ZJXS.SelectedIndex];
                bf7_7 = Db_BF_7DMMJ.Value;

                //BFtabItem8荷载参数
                double bf8_1, bf8_2, bf8_3, bf8_4, bf8_5, bf8_6, bf8_7, bf8_8,bf8_9;

                bf8_1 = Db_BF_8MBZZ.Value;
                bf8_2 = Db_BF_8MBJXLZZ.Value;
                bf8_3 = Db_BF_8LBMBZZ.Value;
                bf8_4 = Db_BF_8MBJZJZZ.Value;
                bf8_5 = Db_BF_8XJHNTZZ.Value;
                bf8_6 = Db_BF_8HNTLGJ.Value;
                bf8_7 = Db_BF_8HNTBGJ.Value;
                bf8_8 = Db_BF_8QZ.Value;
                bf8_9=Db_BF_8RJS.Value;
                #endregion
               
                  

                #region 一、面板验算
                double sum1I, sum1W, sum1h, sum1L, sum1q1, sum1q1J, sum1q1H, sum1q2, sum1Mmax,
                    sum1σ, sum1vmax, sum1ν, sum1R1, sum1R2, sum1R3, sum1r1, sum1r2, sum1r3;
                double a1, b1;
                string compare1_1, compare1_2;

                sum1I = 1000 * bf2_3 * bf2_3 * bf2_3 / 12; //面板截面惯性矩I
                sum1W = 1000 * bf2_3 * bf2_3 / 6; //面板截面抵抗矩W
                sum1h = bf1_3 / 1000;
                sum1L = bf1_18 / 1000;
                a1 = 0.9 * (1.2 * (bf8_1 + (bf8_5 + bf8_6) * sum1h) + 1.4 * bf8_8);
                b1 = 0.9 * (1.35 * (bf8_1 + (bf8_5 + bf8_6) * sum1h) + 1.4 * 0.7 * bf8_8);
                sum1q1 = a1 > b1 ? a1 : b1;
                sum1q1J = 0.9 * 1.35 * (bf8_1 + (bf8_5 + bf8_6) * sum1h);
                sum1q1H = 0.9 * 1.4 * 0.7 * bf8_8;
                sum1q2 = (bf8_1 + (bf8_5 + bf8_6) * sum1h) * 1;
                sum1Mmax = (-0.107) * sum1q1J * sum1L * sum1L + 0.121 * sum1q1H * sum1L * sum1L;
                sum1σ = sum1Mmax / sum1W * 1000000;
                sum1Mmax = Math.Abs(sum1Mmax);//数据计算成负数，考虑公式问题或单位换算问题
                sum1σ = Math.Abs(sum1σ);//数据计算成负数，考虑公式问题或单位换算问题
                sum1Mmax = Math.Round(sum1Mmax, 2);
                sum1σ = Math.Round(sum1σ, 2);
                if (sum1σ <= bf2_4)
                    compare1_1 = "面板的计算强度" + sum1σ + "小于等于面板抗弯强度设计值" + bf2_4 + "N/mm2,满足要求!";
                else
                    compare1_1 = "面板的计算强度" + sum1σ + "大于面板抗弯强度设计值" + bf2_4 + "N/mm2,不满足要求!";

                sum1vmax = 0.632 * sum1q2 * sum1L * sum1L * sum1L * sum1L / 100 / bf2_5 / sum1I * 1000 * 1000 * 1000 * 1000;
                sum1ν = sum1L * 1000 / 400;               
                sum1vmax = Math.Round(sum1vmax, 2);
                sum1ν = Math.Round(sum1ν, 2);
                if (sum1vmax < sum1ν)
                    compare1_2 = "面板的挠度" + sum1vmax + "小于等于面板最大允许挠度值" + sum1ν + "mm,满足要求!";
                else
                    compare1_2 = "面板的挠度" + sum1vmax + "大于面板最大允许挠度值" + sum1ν + "mm,不满足要求!";

                sum1R1 = 0.393 * sum1q1J * sum1L + 0.446 * sum1q1H * sum1L;
                sum1R2 = 1.143 * sum1q1J * sum1L + 1.223 * sum1q1H * sum1L;
                sum1R3 = 0.928 * sum1q1J * sum1L + 1.142 * sum1q1H * sum1L;
                sum1r1 = 0.393 * sum1q2 * sum1L;
                sum1r2 = 1.143 * sum1q2 * sum1L;
                sum1r3 = 0.928 * sum1q2 * sum1L;

                sum1I = Math.Round(sum1I, 2);
                sum1W = Math.Round(sum1W, 2);
                sum1q1 = Math.Round(sum1q1, 2);
                sum1q1J = Math.Round(sum1q1J, 2);
                sum1q1H = Math.Round(sum1q1H, 2);
                sum1q2 = Math.Round(sum1q2, 2);
                sum1R1 = Math.Round(sum1R1, 2);
                sum1R2 = Math.Round(sum1R2, 2);
                sum1R3 = Math.Round(sum1R3, 2);
                sum1r1 = Math.Round(sum1r1, 2);
                sum1r2 = Math.Round(sum1r2, 2);
                sum1r3 = Math.Round(sum1r3, 2);

                #endregion

                #region 二、小梁验算
                double sum2q1, sum2q2, sum2Mmax, sum2σ, sum2Vmax, sum2τ, sum2ν1, sum2ν, sum2ν2, sum2ν_2;
                double a2, b2, c2, d2, e2, f2, g2, h2;
                string compare2_1, str_xlcz, compare2_2, compare2_3, compare2_4;

                c2 = sum1R1 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_13 - 1);
                d2 = sum1R2 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_13 - 1);
                sum2q1 = c2 > d2 ? c2 : d2;
                e2 = sum1r1 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_13 - 1);
                f2 = sum1r2 + (bf8_2 - bf8_1) * (bf1_4 / 1000) / (bf1_13 - 1);
                sum2q2 = e2 > f2 ? e2 : f2;
                g2 = 0.107 * sum2q1 * bf1_11 * bf1_11 / 1000 / 1000;
                h2 = 0.5 * sum2q1 * bf1_19 * bf1_19 / 1000 / 1000;
                sum2Mmax = g2 > h2 ? g2 : h2;
                sum2σ = sum2Mmax * 1000000 / bf3_9 / 1000;
                sum2σ = Math.Round(sum2σ, 2);
                if (sum2σ < bf3_5)
                    compare2_1 = "小梁的计算强度" + sum2σ + "小于等于小梁抗弯强度设计值" + bf3_5 + "N/mm2,满足要求!";
                else
                    compare2_1 = "小梁的计算强度" + sum2σ + "大于小梁抗弯强度设计值" + bf3_5 + "N/mm2,满足要求!";

                a2 = 0.607 * sum2q1 * bf1_11 / 1000;
                b2 = sum2q1 * bf1_19 / 1000;
                sum2Vmax = a2 > b2 ? a2 : b2;
                if (Cb_BF_3XLCZ.SelectedIndex == 0)
                {
                    sum2τ = 3 * sum2Vmax * 1000 / (2 * bf3_3 * bf3_4);
                    sum2τ = Math.Round(sum2τ, 2);
                    str_xlcz = "τmax＝3Vmax/(2bh0)=" + sum2τ + "N/mm2";
                }
                else
                {
                    sum2τ = sum2Vmax * 1000 * bf3_10 * 1000 / (bf3_8 * 10000 * 7.6);//小梁厚度=7.6
                    sum2τ = Math.Round(sum2τ, 2);
                    str_xlcz = "τ =VSo/Itw=" + sum2τ + "N/mm2";
                }
                if (sum2τ <= bf3_6)
                    compare2_2 = "小梁的计算强度" + sum2τ + "小于等于小梁抗剪强度设计值" + bf3_6 + "N/mm2,满足要求!";
                else
                    compare2_2 = "小梁的计算强度" + sum2τ + "大于小梁抗剪强度设计值" + bf3_6 + "N/mm2,不满足要求!";

                sum2ν1 = 0.632 * sum2q2 * bf1_11 * bf1_11 * bf1_11 * bf1_11 / (100 * bf3_7 * bf3_8);
                sum2ν = bf1_11 / 400;
                sum2ν1 = Math.Round(sum2ν1, 2);
                sum2ν = Math.Round(sum2ν, 2);
                if (sum2ν1 <= sum2ν)
                    compare2_3 = "小梁跨中的挠度" + sum2ν1 + "小于等于小梁跨中的最大允许挠度值" + sum2ν + "mm,满足要求!";
                else
                    compare2_3 = "小梁跨中的挠度" + sum2ν1 + "大于小梁跨中的最大允许挠度值" + sum2ν + "mm,不满足要求!";

                sum2ν2 = sum2q2 * bf1_19 * bf1_19 * bf1_19 * bf1_19 / (8 * bf3_7 * bf3_8);
                sum2ν_2 = bf1_19 / 400;
                sum2ν2 = Math.Round(sum2ν2, 2);
                sum2ν_2 = Math.Round(sum2ν_2, 2);
                if (sum2ν2 <= sum2ν_2)
                    compare2_4 = "小梁悬臂端的挠度" + sum2ν2 + "小于等于小梁悬臂端的最大允许挠度值" + sum2ν_2 + "mm,满足要求!";
                else
                    compare2_4 = "小梁悬臂端的挠度" + sum2ν2 + "大于小梁悬臂端的最大允许挠度值" + sum2ν_2 + "mm,不满足要求!";

                sum2q1 = Math.Round(sum2q1, 2);
                sum2q2 = Math.Round(sum2q2, 2);
                sum2Mmax = Math.Round(sum2Mmax, 2);
                sum2Vmax = Math.Round(sum2Vmax, 2);
                #endregion

                #region 三、主梁验算
                double sum3G2k, sum3G3k, sum3Gk, sum3q1, sum3q2, sum3q, sum3l, sum3M, sum3W, sum3σ, sum3qN, sum3v, sum3ν;
                string compare3_1="", compare3_2="";

                double[] zcjj = new double[] {  KJ_JL1.Value, KJ_JL2.Value};
                double min = 0;

                int i = Convert.ToInt32(KJ_LZGS.Value);
                if (i == 0)
                {
                    sum3l = 0;
                }
                else
                {
                    min = zcjj[0];
                    for (int j = 1; j < i; j++)
                    {
                        if (min > zcjj[j])
                        {
                            min = zcjj[j];
                        }
                    }
                    sum3l = min / 1000;
                }

                sum3G2k = bf8_5 * bf1_3 / 1000;
                sum3G3k = bf8_7 * bf1_3 / 1000;
                sum3Gk = bf8_2 + sum3G2k + sum3G3k;
                sum3q1 = 0.9 * (1.2 * sum3Gk + 1.4 * bf8_8) * 0.8;
                sum3q2 = 0.9 * (1.35 * sum3Gk + 1.4 * 0.7 * bf8_8) * 0.8;
                sum3q = sum3q1 > sum3q2 ? sum3q1 : sum3q2;
                sum3M = sum3q * sum3l * sum3l / 8;
                sum3W = bf4_9 * 1000;
                sum3σ = sum3M * 1000 / sum3W;
                sum3σ = Math.Round(sum3σ, 2);
                if (sum3σ > bf4_5)
                    compare3_1 = "主梁的计算强度" + sum3σ + "大于主梁抗弯强度设计值" + bf4_5 + "N/mm2,不满足要求!";
                else
                    compare3_1 = "主梁的计算强度" + sum3σ + "小于等于主梁抗弯强度设计值" + bf4_5 + "N/mm2,满足要求!";

                sum3qN = 0.8 * sum3Gk;
                sum3v = 5 * sum3qN * min * min * min * min / (384 * bf4_7 * bf4_8 * 10000);
                sum3ν = min / 400;
                sum3v = Math.Round(sum3v, 2);
                sum3ν = Math.Round(sum3ν, 2);
                if (sum3v > sum3ν)
                    compare3_2 = "主梁跨中的挠度" + sum3v + "大于主梁跨中的最大允许挠度值" + sum3ν + "mm,不满足要求!";
                else
                    compare3_2 = "主梁跨中的挠度" + sum3v + "小于等于主梁跨中的最大允许挠度值" + sum3ν + "mm,满足要求!";

                sum3G2k = Math.Round(sum3G2k, 2);
                sum3G3k = Math.Round(sum3G3k, 2);
                sum3Gk = Math.Round(sum3Gk, 2);
                sum3q1 = Math.Round(sum3q1, 2);
                sum3q2 = Math.Round(sum3q2, 2);
                sum3q = Math.Round(sum3q, 2);
                sum3M = Math.Round(sum3M, 2);
                sum3qN = Math.Round(sum3qN, 2);


                #endregion

                #region 四、立柱稳定性验算
                double sum4λ, sum4φ, sum4G1k, sum4G2k, sum4G3k, sum4Gk, sum4Qk, sum4ωk, sum4Mw, sum4Nw, sum4f;
                string compare4_1, compare4_2;

                sum4λ = bf1_6 / bf5_2;
                sum4λ = Math.Round(sum4λ, 2);
                if (sum4λ > 250)
                    compare4_1 = "立柱长细比" + sum4λ + "大于立柱最大允许长细比250mm,不满足要求!";
                else
                    compare4_1 = "立柱长细比" + sum4λ + "小于等于立柱最大允许长细比250mm,满足要求!";

                if (sum4λ > 250)
                {
                    sum4φ = 7320 / sum4λ / sum4λ;
                }
                else if (Math.Floor(sum4λ) == sum4λ)
                {
                    int sum4λy = Convert.ToInt32(sum4λ / 10);//第λy1行
                    int sum4λx = Convert.ToInt32(sum4λ % 10);// 第λx1列
                    sum4φ = λArray[sum4λy, sum4λx]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
                }
                else
                {
                    double sum4λ_1, sum4λ_2, sum4φ1, sum4φ2;
                    sum4λ_1 = Math.Ceiling(sum4λ);//x1
                    sum4λ_2 = Math.Floor(sum4λ);//x0

                    int sum4λy1 = Convert.ToInt32(sum4λ_1 / 10);
                    int sum4λx1 = Convert.ToInt32(sum4λ_1 % 10);
                    sum4φ1 = λArray[sum4λy1, sum4λx1]; //y1

                    int sum4λy2 = Convert.ToInt32(sum4λ_2 / 10);
                    int sum4λx2 = Convert.ToInt32(sum4λ_2 % 10);
                    sum4φ2 = λArray[sum4λy2, sum4λx2]; //y0

                    sum4φ = (sum4λ - sum4λ_1) / (sum4λ_2 - sum4λ_1) * sum4φ2 + (sum4λ - sum4λ_2) / (sum4λ_1 - sum4λ_2) * sum4φ1;//拉格朗日插值
                }

                sum4G1k = bf8_4 * bf1_11 / 1000 * bf1_12 / 1000;
                sum4G2k = bf8_5 * bf1_4 / 1000 * bf1_3 / 1000 * bf1_11 / 1000;
                sum4G3k = bf8_6 * bf1_4 / 1000 * bf1_3 / 1000 * bf1_11 / 1000;
                sum4Gk = sum4G1k + sum4G2k + sum4G3k;
                sum4Qk = (bf8_8+bf8_9) * bf1_11 / 1000 * bf1_12 / 1000;
                sum4ωk = 0.7 * bf6_5 * bf6_6 * bf6_3;
                sum4Mw = 0.9 * 1.4 * sum4ωk * bf1_12 / 1000 * bf1_6 / 1000 * bf1_6 / 1000 / 10;
                sum4Nw = 1.2 * sum4Gk + 0.9 * 1.4 * sum4Qk + 0.9 * 1.4 * sum4Mw / (bf1_11 / 1000);
                sum4f = sum4Nw * 1000 / (sum4φ * bf5_4) + sum4Mw * 1000 / bf5_5;
                sum4f = Math.Round(sum4f, 2);
                if (sum4f > 205)
                    compare4_2 = "立柱抗压强度" + sum4f + "大于立柱抗压强度设计值205N/mm2,不满足要求!";
                else
                    compare4_2 = "立柱抗压强度" + sum4f + "小于等于立柱抗压强度设计值205N/mm2,不满足要求!";

                sum4G1k = Math.Round(sum4G1k, 2);
                sum4G2k = Math.Round(sum4G2k, 2);
                sum4G3k = Math.Round(sum4G3k, 2);
                sum4Gk = Math.Round(sum4Gk, 2);
                sum4Qk = Math.Round(sum4Qk, 2);
                sum4ωk = Math.Round(sum4ωk, 2);
                sum4Mw = Math.Round(sum4Mw, 2);
                sum4Nw = Math.Round(sum4Nw, 2);
                sum4φ = Math.Round(sum4φ, 2);

                #endregion

                #region 五、可调托座验算
                double sum5N;
                string compare5_1;

                sum5N = sum4Nw / bf7_1;
                sum5N = Math.Round(sum5N, 2);
                if (sum5N > bf7_2)
                    compare5_1 = "可调托座受力" + sum5N + "大于可调托座承载力容许值" + bf7_2 + "（kN）,不满足要求!";
                else
                    compare5_1 = "可调托座受力" + sum5N + "小于等于可调托座承载力容许值" + bf7_2 + "（kN）,满足要求!";
                #endregion

                #region 六、立柱地基基础验算
                double sum6p;
                string compare6_1;

                sum6p = sum4Nw / (bf7_6 * bf7_7 * bf7_1);
                sum6p = Math.Round(sum6p, 2);
                if (sum6p > bf7_5)
                    compare6_1 = "立柱底垫板的底面平均压力" + sum6p + "大于地基土承载力设计值" + bf7_5 + "N/mm2,不满足要求!";
                else
                    compare6_1 = "立柱底垫板的底面平均压力" + sum6p + "小于等于地基土承载力设计值" + bf7_5 + "N/mm2,满足要求!";
                #endregion



                obj = new object[] { ZCJJ, bf1_1, bf1_2, bf1_3, bf1_4, bf1_5, bf1_6, bf1_7, bf1_8, bf1_9, bf1_10, bf1_11, bf1_12, bf1_13, bf1_14, bf1_15,bf1_18,bf1_19,bf2_1,
            bf2_2,bf2_3,bf2_4,bf2_5,bf3_1,bf3_2,bf3_5,bf3_6,bf3_7,bf3_8,bf3_9,bf4_1,bf4_2,bf4_5,bf4_6,bf4_7,bf4_8,bf4_9,bf5_1,bf5_2,bf5_3,
            bf5_4,bf5_5,bf6_1,bf6_2,bf6_3,bf6_4,bf6_5,bf6_6,bf6_7,bf7_1,bf7_2,bf7_3,bf7_4,bf7_5,bf7_6,bf7_7,bf8_1,bf8_2,bf8_3,bf8_4,bf8_5,
            bf8_6,bf8_7,bf8_8,bf8_9,sum1I,sum1W,sum1h,sum1L,sum1q1,sum1q1J,sum1q1H,sum1q2,sum1Mmax,sum1σ,compare1_1,sum1vmax,sum1ν,compare1_2,
            sum1R1,sum1R2,sum1R3,sum1r1,sum1r2,sum1r3,sum2q1,sum2q2,sum2Mmax,sum2σ,compare2_1,sum2Vmax,str_xlcz,compare2_2,sum2ν1,sum2ν,
            compare2_3,sum2ν2,sum2ν_2,compare2_4,sum3G2k,sum3G3k,sum3Gk,sum3q1,sum3q2,sum3q,sum3l,sum3M,sum3W,sum3σ,compare3_1,sum3qN,
            sum3v,min,sum3ν,compare3_2,sum4λ,compare4_1,sum4φ,sum4G1k,sum4G2k,sum4G3k,sum4Gk,sum4Qk,sum4ωk,sum4Mw,sum4Nw,sum4f,compare4_2,
            sum5N,compare5_1,sum6p,compare6_1};

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
        
            else if (CbxBeamFormType.SelectedIndex == 4)
            {
                
                 itemtext = "梁测模板";
                #region 参数赋值
                //构造+支撑参数
                double lca_2, lca_3, lca_4, lca_5, lca_7, lca_8, lca_9, lca_10, lca_12, lca_13, lca_14, lca_15;
                string lca_6="", lca_16="", lca_1="", lca_17="", lca_18="", lca_11="";
                lca_1 = lc_gzjgqk.Text;
                lca_2 = cl_gzjmg.Value;
                lca_3 = cl_gzjmk.Value;
                lca_4 = cl_gzkd.Value;
                lca_5 = cl_gzlbhd.Value;
                lca_6 = lc_zcxlbz.Text;
                lca_7 = lc_zcju1.Value;
                lca_8 = lc_zcju2.Value;
                lca_9 = lc_zcjl3.Value;
                lca_10 = doubleInput11.Value;
                lca_11 = comboBoxEx2.Text;
                lca_12 = doubleInput6.Value;
                lca_13 = doubleInput10.Value;
                lca_14 = doubleInput16.Value;
                lca_15 = doubleInput5.Value;
                lca_16 = lc_zcxs1.Text;
                lca_17 = lc_zcxs2.Text;
                lca_18 = lc_zcxs3.Text;
                //小梁参数
                double lcb_3, lcb_4, lcb_5, lcb_6, lcb_7, lcb_8, lcb_9;
                string lcb_1="", lcb_2="";
                lcb_1 = lc_xlca.Text;
                lcb_2 = lc_xljmlx.Text;
                lcb_3 = lc_xlfmk.Value;
                lcb_4 = lc_xlfmg.Value;
                lcb_5 = lc_xlf.Value;
                lcb_6 = lc_xlt.Value;
                lcb_7 = lc_xle.Value;
                lcb_8 = lc_xli.Value;
                lcb_9 = lc_xlw.Value;
                //主梁参数
                double lcc_3, lcc_4, lcc_5, lcc_6, lcc_7, lcc_8, lcc_9;
                string lcc_1="", lcc_2="";
                lcc_1 = lc_zlcz.Text;
                lcc_2 = lc_zljm.Text;
                lcc_3 = lc_zlfmk.Value;
                lcc_4 = lc_zlfmg.Value;
                lcc_5 = lc_zlf.Value;
                lcc_6 = lc_zlt.Value;
                lcc_7 = lc_zle.Value;
                lcc_8 = lc_zlci.Value;
                lcc_9 = lc_zlw.Value;
                //面板+对拉螺栓+荷载
                double lcd_2, lcd_3, lcd_4, lcd_6, lcd_7, lcd_9, lcd_10, lcd_11, lcd_12, lcd_13, lcd_5;
                string lcd_1="", lcd_8="";
                double[] p2 = new double[] { 0.85, 1, 1.15 };
                double[] p1 = new double[] { 1, 1.2 };
                lcd_1 = lc_mblx.Text;
                lcd_2 = lc_mbhd.Value;
                lcd_3 = lc_mbf.Value;
                lcd_4 = lc_mbe.Value;
                int temp = cl_hzp2.SelectedIndex;
                lcd_5 = p2[cl_hzp2.SelectedIndex];
                lcd_6 = cl_hzh.Value;
                lcd_7 = cl_hzq2k.Value;
                lcd_8 = cl_dllslx.Text;
                lcd_9 = cl_dllsn.Value;
                lcd_10 = cl_hzr.Value;
                lcd_11 = cl_hzv.Value;
                lcd_12 = cl_hzt0.Value;
                lcd_13 = p1[cl_hzp1.SelectedIndex];
                #endregion
                #region 一、荷载计算
                double sum1g4k, sum1ss, sum1sz;
                //新浇混凝土对模板的侧压力标准值G4k＝min[0.22γct0β1β2v1/2，γcH]＝min[0.22×γc×t0×β1×β2×v1/2，γc×H]＝min[0.22×24×4×1×1.15×2.51/2，24×1.6]＝min[38.4，38.4]＝38.4kN/m2
                sum1g4k = Math.Min(0.22 * lcd_10 * lcd_12 * lcd_13 * lcd_5 * Math.Sqrt(lcd_11), lcd_10 * lcc_6);
                //承载能力极限状态设计值S承＝0.9max[1.2×G4k+1.4×Q2k，1.35×G4k+1.4×0.7×Q2k]
                sum1ss = 0.9 * Math.Max(1.2 * sum1g4k + 1.4 * lcd_7, 1.35 * sum1g4k + 1.4 * 0.7 * lcd_7);
                sum1sz = sum1g4k;
                sum1g4k = Math.Round(sum1g4k, 2);
                sum1ss = Math.Round(sum1ss, 2);
                sum1sz = Math.Round(sum1sz, 2);
                #endregion
                #region 二、面板计算
                double b = 1000, h = 15, sum2w, sum2i, sum2q1, sum2q1j, sum2q1h, sum2m, sum26, sum2q, sum2vmax, sum2v, sum2rmax, sum2r1max;
                string compare_mb1, compare_mb2;
                //W＝bh2/6
                sum2w = b * h * h / 6;
                //I＝bh3/12
                sum2i = b * h * h * h / 12;
                // q1＝bS承
                sum2q1 = b * sum1ss;
                // q1静＝0.9×1.35×G4k×b＝@sum2q1j@kN/m
                sum2q1j = 0.9 * 1.35 * sum1g4k * b;
                // q1活＝0.9×1.4×0.7×Q2k×b＝@sum2q1h@kN/m
                sum2q1h = 0.9 * 1.4 * 0.7 * lcd_7 * b;
                //Mmax=＝max[0.077×q1静×小梁间距2+0.1×q1活×小梁间距2,-0.107×q1静×小梁间距2+0.121×q1活×小梁间距2,-0.071×q1静×小梁间距2-0.107×q1活×小梁间距2]＝@sum2m@kN•m
                sum2m = Math.Max(0.077 * sum2q1j * lca_13 * lca_13 + 0.1 * sum2q1h * lca_13 * lca_13, Math.Max((-0.107) * sum2q1j * lca_13 * lca_13 + 0.121 * sum2q1h * lca_13 * lca_13, -0.071 * sum2q1j * lca_13 * lca_13 *(- 0.107) * sum2q1h * lca_13 * lca_13));
                //σ＝Mmax/W＝@sum26@N/mm2
                sum26 = sum2m / sum2w;
                sum2m = Math.Round(sum2m, 2);
                sum26 = Math.Round(sum26, 2);
                if (sum26 <= lcd_3)
                    compare_mb1 = "面板的计算强度" + sum26 + "小于等于面板抗弯强度设计值" + lcd_3 + "N/mm2,满足要求!";
                else
                    compare_mb1 = "面板的计算强度" + sum26 + "大于面板抗弯强度设计值" + lcd_3 + "N/mm2,不满足要求!";
                //q＝bS正
                sum2q = b * sum1sz;
                //νmax＝0.632qL4/(100EI)= 0.632×q×(小梁间距×1000) 4/(100×E×I)=0.632×38.4×(0.18×1000) 4/(100×10000×281250)＝0.09mm
                sum2vmax = 0.632 * sum2q * (lca_13 * 1000) * (lca_13 * 1000) * (lca_13 * 1000) * (lca_13 * 1000) / (100 * 10000 * sum2i);
                //[ν]=L/0.4=L/0.4=0.18/0.4=0.45mm
                sum2v = (lca_13 * 1000) / 0.4;
                sum2v = Math.Round(sum2v, 2);
                sum2vmax = Math.Round(sum2vmax, 2);
                //面板的挠度ν小于面板最大允许挠度值[ν]mm,满足要求!
                if (sum2v <= sum2vmax)
                    compare_mb2 = "面板的挠度" + sum2v + "小于等于面板最大允许挠度值" + sum2vmax + "mm,满足要求!";
                else
                    compare_mb2 = "面板的挠度" + sum2v + "小于等于面板最大允许挠度值" + sum2vmax + "mm,不满足要求!";
                //Rmax＝1.143×q1静×l左+1.223×q1活×l左＝1.143×q1静×小梁间距+1.223×q1活×小梁间距＝1.143×46.66×0.18+1.223×3.53×0.18＝10.45kN
                sum2rmax = 1.143 * sum2q1j * lca_13 + 1.223 * sum2q1h * lca_13;
                //R'max＝1.143×l左×G4k＝1.143×小梁间距×G4k＝1.143×0.18×38.4＝7.96kN
                sum2r1max = 1.143 * lca_13 * sum1g4k;
                sum2w = Math.Round(sum2w, 2);
                sum2i = Math.Round(sum2i, 2);
                sum2q1 = Math.Round(sum2q1, 2);
                sum2q1j = Math.Round(sum2q1j, 2);
                sum2q1h = Math.Round(sum2q1h,2);
                sum2q = Math.Round(sum2q, 2);                
                sum2rmax = Math.Round(sum2rmax, 2);
                sum2r1max = Math.Round(sum2r1max, 2);
                #endregion
                #region 三、小梁验算
                double sum3q, sum3mmax, sum36, sum3vmax, sum3t, sum3v1max, sum31v1, sum3v2max, sum31v12, sum3rmax, sum3r1max;
                string compare_xl1, compare_xl2, compare_xl3, compare_xl4, str_3t;
                //q＝Rmax = Rmax =10.45kN/m
                sum3q = sum2rmax;
                // Mmax＝max[0.1×q×l2,0.5×q×l12]= max[0.1×q×主梁间距2,0.5×q×小梁最大悬挑长度2]
                sum3mmax = Math.Max(0.1 * sum3q * lca_14 * lca_14, 0.5 * sum3q * lca_10 * lca_10);
                sum3mmax = Math.Round(sum3mmax, 2);
                //σ＝Mmax/W＝Mmax×106/W＝0.47×103/64＝7.35N/mm2  
                sum36 = sum3mmax / lca_9;                
                sum36 = Math.Round(sum36, 2);                
                //小梁的计算强度σ小于小梁抗弯强度设计值小梁抗弯强度设计值N/mm2,满足要求!
                if (sum36 <= lcb_5)
                    compare_xl1 = "小梁的计算强度" + sum36 + "小于等于小梁抗弯强度设计值" + lcb_5 + "N/mm2,满足要求!";
                else
                    compare_xl1 = "小梁的计算强度" + sum36 + "小于等于小梁抗弯强度设计值" + lcb_5 + "N/mm2,不满足要求!";
                //Vmax＝max[0.6×q×l,q×l1] ＝max[0.6×q×主梁间距,q×小梁最大悬挑长度]
                sum3vmax = Math.Max(0.6 * sum3q * lca_14, sum3q * lca_10);
                sum3vmax = Math.Round(sum3vmax, 2);
                if (lc_xlca.SelectedIndex == 0)//小梁选择 方木时
                {   //τmax＝3Vmax/(2bh0)= 3小梁的最大剪力/（2方木宽×方木高）
                    sum3t = 3 * sum3vmax / (2 * lcb_3 * lcb_4);
                    sum3t = Math.Round(sum3t, 2);
                    str_3t = "τmax＝3Vmax/(2bh0)=" + sum3t;
                }
                else //小梁选择 工字钢、槽钢、方钢管、钢管时
                {  //τ =VS0/Itw=小梁的最大剪力×小梁截面面积矩/（小梁截面惯性矩×小梁厚度）
                    sum3t = 2.858 * 1000 * 28.52 * 1000 / 245 / 10000 / 7.6;
                    sum3t = Math.Round(sum3t, 2);
                    str_3t = "τ=VS0/Itw=" + sum3t;
                }
                //小梁的计算强度@sum3t@小于小梁抗剪强度设计值@lcb_6@N/mm2,满足要求!
                if (sum3t <= lcb_6)
                    compare_xl2 = "小梁的计算强度" + sum3t + "小于等于小梁抗剪强度设计值" + lcb_6 + "N/mm2,满足要求!";
                else
                    compare_xl2 = "小梁的计算强度" + sum3t + "小于等于小梁抗剪强度设计值" + lcb_6 + "N/mm2,不满足要求!";
                //q＝R'max＝R'max
                sum3q = sum2r1max;
                //ν1max＝0.677qL4/(100EI)= 0.677×q×(主梁间距×1000)4/(100×E×I)
                sum3v1max = 0.677 * sum3q * (lca_14 * 1000) * (lca_14 * 1000) * (lca_14 * 1000) * (lca_14 * 1000) / (100 * lcb_7 * lcb_8);
                sum3v1max = Math.Round(sum3v1max, 2);
                //[ν]=l/0.4=@lca_14@/0.4=0.6/0.4=@sum[v]@mm；
                sum31v1 = lca_14 / 0.4;
                sum31v1 = Math.Round(sum31v1, 2);
                //小梁跨中的挠度ν小于小梁跨中的最大允许挠度值[ν]mm,满足要求!
                if (sum31v1 <= sum3v1max)
                    compare_xl3 = "小梁跨中的挠度" + sum31v1 + "小于等于小梁跨中的最大允许挠度值" + sum3v1max + "mm,满足要求!";
                else
                    compare_xl3 = "小梁跨中的挠度" + sum31v1 + "小于等于小梁跨中的最大允许挠度值" + sum3v1max + "mm,不满足要求!";
                //ν2max＝qL4/(8EI)= @sum3q@×(@lca_10@×10004)/(8×@lcb_7@×@lcb_8@)=@sum3v2max@mm
                sum3v2max = sum3q * (lca_10 * 1000 * 1000 * 1000 * 1000) / (8 * lcb_8 * lcb_7);
                sum3v2max = Math.Round(sum3v2max, 2);
                //[ν]=l/0.4=@lca_10@/0.4=0.3/0.4=@sum31v12@mm；
                sum31v12 = lca_10 / 0.4;
                sum31v12 = Math.Round(sum31v12, 2);
                //小梁跨中的挠度ν小于小梁跨中的最大允许挠度值[ν]mm,满足要求!
                if (sum31v12 <= sum3v2max)
                    compare_xl4 = "小梁跨中的挠度" + sum31v12 + "小于等于小梁跨中的最大允许挠度值" + sum3v2max + "mm,满足要求!";
                else
                    compare_xl4 = "小梁跨中的挠度" + sum31v12 + "小于等于小梁跨中的最大允许挠度值" + sum3v2max + "mm,不满足要求!";
                //Rmax＝max[1.1×10.45×0.6，0.4×10.45×0.6+10.45×0.3]＝6.9kN
                sum3rmax = 6.9;
                //R'max＝max[1.1×7.96×0.6，0.4×7.96×0.6+7.96×0.3]＝5.25kN
                sum3r1max = 5.25;

                #endregion
                #region 四、主梁验算
                double sum4i, sum4q, sum4m, sum4w, sum46, sum4f, sum4qn, sum4v, sum41v1;
                string compare_zl1, compare_zl2;
                //l= min((@lca_8@-@lca_7@), (@lca_9@-@lca_8@))/1000 =@sum3i@
                sum4i = Math.Min((lca_8 - lca_7), (lca_9 - lca_8)) / 1000;
                sum4i = Math.Round(sum4i, 2);
                //q= @sum1ss@ /@lca_15@=@sum4q@ kN/m2
                sum4q = sum1ss / lca_15;
                sum4q = Math.Round(sum4q, 2);
                //M=ql2/8= @sum4q@×@sum4i@2/8=@sum4m@ kN/m。
                sum4m = sum4q * sum4i * sum4i / 8;
                sum4m = Math.Round(sum4m, 2);
                //W=@lcc_9@×103
                sum4w = lcc_9 * 1000;
                sum4w = Math.Round(sum4w, 2);
                //σ＝Mmax/W=@sum46@ N/mm2
                sum46 = sum3mmax / sum4w;
                sum46 = Math.Round(sum46, 2); 
                //[f]= @lcc_5@=@sum4f@N/mm2；
                sum4f = lcc_5;
                sum4f = Math.Round(sum4f, 2);
                // 主梁的计算强度@sum46@小于主梁抗弯强度设计值@sum4f@N/mm2,满足要求!
                if (sum46 <= sum4f)
                    compare_zl1 = "主梁的计算强度" + sum46 + "小于等于主梁抗弯强度设计值" + sum4f + "N/mm2,满足要求!";
                else
                    compare_zl1 = "主梁的计算强度" + sum46 + "小于等于主梁抗弯强度设计值" + sum4f + "N/mm2,不满足要求!";
                //q挠=0.8×@sum4q@=@sum4qn@ N/mm
                sum4qn = 0.8 * sum4q;
                sum4qn = Math.Round(sum4qn, 2);
                //v=5 q挠l4/(384EI)= 5 @sum4qn@ (@sum4i@×1000) 4/(384@lcc_7@@sum4i@)= @sum4v@mm
                sum4v = 5 * sum4qn * (sum4i * 1000) * (sum4i * 1000) * (sum4i * 1000) * (sum4i * 1000) / (384 * lcc_7 * sum4i);
                sum4v = Math.Round(sum4v, 2);
                // [ν]=l/0.4=@sum4i@/0.4= @sum41v1@mm
                sum41v1 = sum4i / 0.4;
                sum41v1 = Math.Round(sum41v1, 2);
                //主梁跨中的挠度@sum4v@小于主梁跨中的最大允许挠度值@sum41v1@mm,满足要求!
                if (sum4v <= sum41v1)
                    compare_zl2 = "主梁跨中的挠度" + sum4v + "小于等于主梁跨中的最大允许挠度值" + sum41v1 + "mm,满足要求!";
                else
                    compare_zl2 = "主梁跨中的挠度" + sum4v + "小于等于主梁跨中的最大允许挠度值" + sum41v1 + "mm,不满足要求!";
                #endregion

                #region 五、对拉螺栓验算
                double sum5n, sum5ntb;
                string compare_dlls1;
                //N＝0.95×Rmax×2＝0.95×@sum3rmax@×2＝@sum5n@kN
                sum5n = 0.95 * sum3rmax * 2;
                sum5n = Math.Round(sum5n, 2);
                //Ntb＝@lcd_9@Ntb kN
                sum5ntb = lcd_9;
                sum5ntb=Math .Round (sum5ntb ,2);
                //对拉螺栓受力@sum5n@ kN小于轴向拉力设计值@lcd_9@ kN,满足要求!
                if (sum5ntb <= lcd_9)
                    compare_dlls1 = "对拉螺栓受力" + sum5n + "小于等于轴向拉力设计值" + lcd_9 + "kN,满足要求!";
                else
                    compare_dlls1 = "对拉螺栓受力" + sum5n + "小于等于轴向拉力设计值" + lcd_9 + "kN,不满足要求!";

                #endregion
                obj = new object[] { lca_1, lca_2, lca_3, lca_4, lca_5, lca_6, lca_7, lca_8, lca_9, lca_10, lca_11, lca_12, lca_13, lca_14, lca_15, lca_16, lca_17, lca_18, lcb_1, lcb_2, lcb_3, lcb_4,
                    lcb_5, lcb_6, lcb_7, lcb_8, lcb_9, lcc_1, lcc_2, lcc_3, lcc_4, lcc_5, lcc_6, lcc_7, lcc_8, lcc_9, lcd_1, lcd_2, lcd_3, lcd_4, lcd_5, lcd_6, lcd_7,
                    lcd_8, lcd_9, lcd_10, lcd_11, lcd_12, lcd_13, sum1g4k, sum1ss, sum1sz, sum2w, sum2i, sum2q1, sum2q1j, sum2q1h, sum2m, sum26, sum2q, sum2vmax, sum2v, sum2rmax, sum2r1max 
                ,compare_mb1, compare_mb2,sum3q,sum3mmax,sum36,sum3vmax,sum3t,sum3v1max,sum31v1,sum3v2max,sum31v12,sum3rmax,sum3r1max,compare_xl1, compare_xl2, compare_xl3, compare_xl4,
                sum4i,sum4q,sum4m,sum4w,sum46,sum4f,sum4qn,sum4v,sum41v1,compare_zl1, compare_zl2,sum5n,sum5ntb,compare_dlls1,str_3t};

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

        private void Rdo_BF_6NO_CheckedChanged(object sender, EventArgs e)
        {
            Cb_BF_6SF.Enabled = Cb_BF_6DQ.Enabled = Db_BF_6GD.Enabled = Db_BF_6GDBHXS.Enabled = Db_BF_6TXXS.Enabled = Db_BF_6BZZ.Enabled = false;
            Tb_BF_6SFDQFY.Clear();
            Tb_BF_6SFDQFY.Text = "0";
            Cb_BF_6SF.Text = "";
            Cb_BF_6DQ.Text = "";
            Db_BF_6GD.Value = Db_BF_6GDBHXS.Value = Db_BF_6TXXS.Value = Db_BF_6BZZ.Value = 0;
        }

        private void Rdo_BF_6YES_CheckedChanged(object sender, EventArgs e)
        {
            Cb_BF_6SF.Enabled = Cb_BF_6DQ.Enabled = Db_BF_6GD.Enabled = Db_BF_6GDBHXS.Enabled = Db_BF_6TXXS.Enabled = Db_BF_6BZZ.Enabled = true;
        }

        private void Db_BF_ZCJJ1_ValueChanged(object sender, EventArgs e)
        {
            double[] zcjj = new double[] { Db_BF_ZCJJ1.Value, Db_BF_ZCJJ2.Value, Db_BF_ZCJJ3.Value, Db_BF_ZCJJ4.Value };

            int i = Convert.ToInt32(Db_BF_LZGS.Value);
            double sum = 0;

            for (int j = 0; j < i; j++)
            {
                if(zcjj[j]>=0)
                {
                    sum += zcjj[j];
                }else
                {
                    MessageBox.Show("左侧间距值不能小于0，请重新输入");
                    break;
                }
            }
            if (sum > Db_BF_ZLCD.Value)
            {
                MessageBox.Show("左侧间距总和超出主梁长度，请重新输入");
                Db_BF_ZCJJ1.Value = 0;
            }
        }

        private void Db_BF_ZCJJ2_ValueChanged(object sender, EventArgs e)
        {
            double[] zcjj = new double[] { Db_BF_ZCJJ1.Value, Db_BF_ZCJJ2.Value, Db_BF_ZCJJ3.Value, Db_BF_ZCJJ4.Value };

            int i = Convert.ToInt32(Db_BF_LZGS.Value);
            double sum = 0;

            for (int j = 0; j < i; j++)
            {
                if (zcjj[j] >=0)
                {
                    sum += zcjj[j];
                }
                else
                {
                    MessageBox.Show("左侧间距值不能小于0，请重新输入");
                    break;
                }
            }
            if (sum > Db_BF_ZLCD.Value)
            {
                MessageBox.Show("左侧间距总和超出主梁长度，请重新输入");
                Db_BF_ZCJJ2.Value = 0;
            }
        }

        private void Db_BF_ZCJJ3_ValueChanged(object sender, EventArgs e)
        {
            double[] zcjj = new double[] { Db_BF_ZCJJ1.Value, Db_BF_ZCJJ2.Value, Db_BF_ZCJJ3.Value, Db_BF_ZCJJ4.Value };

            int i = Convert.ToInt32(Db_BF_LZGS.Value);
            double sum = 0;

            for (int j = 0; j < i; j++)
            {
                if (zcjj[j] >= 0)
                {
                    sum += zcjj[j];
                }
                else
                {
                    MessageBox.Show("左侧间距值不能小于0，请重新输入");
                    break;
                }
            }
            if (sum > Db_BF_ZLCD.Value)
            {
                MessageBox.Show("左侧间距总和超出主梁长度，请重新输入");
                Db_BF_ZCJJ3.Value = 0;
            }
        }

        private void Db_BF_ZCJJ4_ValueChanged(object sender, EventArgs e)
        {
            double[] zcjj = new double[] { Db_BF_ZCJJ1.Value, Db_BF_ZCJJ2.Value, Db_BF_ZCJJ3.Value, Db_BF_ZCJJ4.Value };

            int i = Convert.ToInt32(Db_BF_LZGS.Value);
            double sum = 0;

            for (int j = 0; j < i; j++)
            {
                if (zcjj[j] >= 0)
                {
                    sum += zcjj[j];
                }
                else
                {
                    MessageBox.Show("左侧间距值不能小于0，请重新输入");
                    break;
                }
            }
            if (sum > Db_BF_ZLCD.Value)
            {
                MessageBox.Show("左侧间距总和超出主梁长度，请重新输入");
                Db_BF_ZCJJ4.Value = 0;
            }
        }

        private void lc_mbtubiao_Click(object sender, EventArgs e)
        {
            if (lc_mblx.SelectedIndex == 0)
            {
                FrmShowChart showchart = new FrmShowChart(11);
                showchart.ShowDialog();
            }
            else if (lc_mblx.SelectedIndex == 1)
            {
                FrmShowChart showchart = new FrmShowChart(10);
                showchart.ShowDialog();
            }
            else if (lc_mblx.SelectedIndex == 2)
            {
                FrmShowChart showchart = new FrmShowChart(12);
                showchart.ShowDialog();
            }
        }

        private void lc_zlcz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lc_zlcz.SelectedIndex == 0)//方木
            {
                lc_zljm.Enabled = lc_zls.Enabled = false;
                lc_zlfmg.Enabled = lc_zlfmk.Enabled = true;
            }
            else if (lc_zlcz.SelectedIndex == 1)//方钢管
            {
                lc_zljm.Enabled = lc_zls.Enabled = true;
                lc_zlfmg.Enabled = lc_zlfmk.Enabled = false;
                lc_zljm.Items.Clear();
                lc_zljm.Items.Add("□60×40×2.5"); lc_zljm.Items.Add("□80×40×2"); lc_zljm.Items.Add("□100×50×3");
            }
            else if (lc_zlcz.SelectedIndex == 2)//工字钢
            {
                lc_zljm.Enabled = lc_zls.Enabled = true;
                lc_zlfmg.Enabled = lc_zlfmk.Enabled = false;
                lc_zljm.Items.Clear();
                lc_zljm.Items.Add("10号"); lc_zljm.Items.Add("12.6号"); lc_zljm.Items.Add("14号"); lc_zljm.Items.Add("16号"); lc_zljm.Items.Add("18号");
                lc_zljm.Items.Add("20a号"); lc_zljm.Items.Add("20b号"); lc_zljm.Items.Add("22a号"); lc_zljm.Items.Add("22b号"); lc_zljm.Items.Add("25a号");
                lc_zljm.Items.Add("25b号"); lc_zljm.Items.Add("28a号"); lc_zljm.Items.Add("28b号"); lc_zljm.Items.Add("32a号"); lc_zljm.Items.Add("32b号");
                lc_zljm.Items.Add("32c号"); lc_zljm.Items.Add("36a号"); lc_zljm.Items.Add("36b号"); lc_zljm.Items.Add("36c号"); lc_zljm.Items.Add("40a号");
                lc_zljm.Items.Add("40b号"); lc_zljm.Items.Add("40c号"); lc_zljm.Items.Add("45a号"); lc_zljm.Items.Add("45b号"); lc_zljm.Items.Add("45c号");
                lc_zljm.Items.Add("50a号"); lc_zljm.Items.Add("50b号"); lc_zljm.Items.Add("50c号"); lc_zljm.Items.Add("56a号"); lc_zljm.Items.Add("56b号");
                lc_zljm.Items.Add("56c号"); lc_zljm.Items.Add("63a号"); lc_zljm.Items.Add("63b号"); lc_zljm.Items.Add("63c号");
            }
            else if (lc_zlcz.SelectedIndex == 3)//槽钢
            {
                lc_zljm.Enabled = lc_zls.Enabled = true;
                lc_zlfmg.Enabled = lc_zlfmk.Enabled = false;
                lc_zljm.Items.Clear();
                lc_zljm.Items.Add("5号"); lc_zljm.Items.Add("6.3号"); lc_zljm.Items.Add("8号"); lc_zljm.Items.Add("10号"); lc_zljm.Items.Add("12.6号");
                lc_zljm.Items.Add("14a号"); lc_zljm.Items.Add("14b号"); lc_zljm.Items.Add("16a号"); lc_zljm.Items.Add("16b号"); lc_zljm.Items.Add("18a号");
                lc_zljm.Items.Add("18b号"); lc_zljm.Items.Add("20a号"); lc_zljm.Items.Add("20b号"); lc_zljm.Items.Add("22a号"); lc_zljm.Items.Add("22b号");
                lc_zljm.Items.Add("25a号"); lc_zljm.Items.Add("25b号"); lc_zljm.Items.Add("25c号"); lc_zljm.Items.Add("28a号"); lc_zljm.Items.Add("28b号");
                lc_zljm.Items.Add("28c号"); lc_zljm.Items.Add("32a号"); lc_zljm.Items.Add("32b号"); lc_zljm.Items.Add("32c号"); lc_zljm.Items.Add("36a号");
                lc_zljm.Items.Add("36b号"); lc_zljm.Items.Add("36c号"); lc_zljm.Items.Add("40a号"); lc_zljm.Items.Add("40b号"); lc_zljm.Items.Add("40c号");
            }
            else if (lc_zlcz.SelectedIndex == 4)//钢管
            {
                lc_zljm.Enabled = lc_zls.Enabled = true;
                lc_zlfmg.Enabled = lc_zlfmk.Enabled = false;
                lc_zljm.Items.Clear();
                lc_zljm.Items.Add("φ48×3.5"); lc_zljm.Items.Add("φ48×3.25"); lc_zljm.Items.Add("φ48×3.2"); lc_zljm.Items.Add("φ48×3"); lc_zljm.Items.Add("φ51×3");
            }
        }

        private void lc_xlca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lc_xlca.SelectedIndex == 0)//方木
            {
                lc_xljmlx.Enabled = lc_xls.Enabled = false;
                lc_xlfmk.Enabled = lc_xlfmg.Enabled = true;
            }
            else if (lc_xlca.SelectedIndex == 1)//方钢管
            {

                lc_xls.Enabled = lc_xljmlx.Enabled = true;
                lc_xlfmk.Enabled = lc_xlfmg.Enabled = false;
                lc_xljmlx.Items.Clear();
                lc_xljmlx.Items.Add("□60×40×2.5"); lc_xljmlx.Items.Add("□80×40×2"); lc_xljmlx.Items.Add("□100×50×3");


            }
            else if (lc_xlca.SelectedIndex == 2)//工字钢
            {
                lc_xljmlx.Enabled = lc_xls.Enabled = true;
                lc_xlfmg.Enabled = lc_xlfmk.Enabled = false;
                lc_xljmlx.Items.Clear();
                lc_xljmlx.Items.Add("10号"); lc_xljmlx.Items.Add("12.6号"); lc_xljmlx.Items.Add("14号"); lc_xljmlx.Items.Add("16号"); lc_xljmlx.Items.Add("18号");
                lc_xljmlx.Items.Add("20a号"); lc_xljmlx.Items.Add("20b号"); lc_xljmlx.Items.Add("22a号"); lc_xljmlx.Items.Add("22b号"); lc_xljmlx.Items.Add("25a号");
                lc_xljmlx.Items.Add("25b号"); lc_xljmlx.Items.Add("28a号"); lc_xljmlx.Items.Add("28b号"); lc_xljmlx.Items.Add("32a号"); lc_xljmlx.Items.Add("32b号");
                lc_xljmlx.Items.Add("32c号"); lc_xljmlx.Items.Add("36a号"); lc_xljmlx.Items.Add("36b号"); lc_xljmlx.Items.Add("36c号"); lc_xljmlx.Items.Add("40a号");
                lc_xljmlx.Items.Add("40b号"); lc_xljmlx.Items.Add("40c号"); lc_xljmlx.Items.Add("45a号"); lc_xljmlx.Items.Add("45b号"); lc_xljmlx.Items.Add("45c号");
                lc_xljmlx.Items.Add("50a号"); lc_xljmlx.Items.Add("50b号"); lc_xljmlx.Items.Add("50c号"); lc_xljmlx.Items.Add("56a号"); lc_xljmlx.Items.Add("56b号");
                lc_xljmlx.Items.Add("56c号"); lc_xljmlx.Items.Add("63a号"); lc_xljmlx.Items.Add("63b号"); lc_xljmlx.Items.Add("63c号");

            }
            else if (lc_xlca.SelectedIndex == 3)//槽钢
            {
                lc_xljmlx.Enabled = lc_xls.Enabled = true;
                lc_xlfmg.Enabled = lc_xlfmk.Enabled = false;
                lc_xljmlx.Items.Clear();
                lc_xljmlx.Items.Add("5号"); lc_xljmlx.Items.Add("6.3号"); lc_xljmlx.Items.Add("8号"); lc_xljmlx.Items.Add("10号"); lc_xljmlx.Items.Add("12.6号");
                lc_xljmlx.Items.Add("14a号"); lc_xljmlx.Items.Add("14b号"); lc_xljmlx.Items.Add("16a号"); lc_xljmlx.Items.Add("16b号"); lc_xljmlx.Items.Add("18a号");
                lc_xljmlx.Items.Add("18b号"); lc_xljmlx.Items.Add("20a号"); lc_xljmlx.Items.Add("20b号"); lc_xljmlx.Items.Add("22a号"); lc_xljmlx.Items.Add("22b号");
                lc_xljmlx.Items.Add("25a号"); lc_xljmlx.Items.Add("25b号"); lc_xljmlx.Items.Add("25c号"); lc_xljmlx.Items.Add("28a号"); lc_xljmlx.Items.Add("28b号");
                lc_xljmlx.Items.Add("28c号"); lc_xljmlx.Items.Add("32a号"); lc_xljmlx.Items.Add("32b号"); lc_xljmlx.Items.Add("32c号"); lc_xljmlx.Items.Add("36a号");
                lc_xljmlx.Items.Add("36b号"); lc_xljmlx.Items.Add("36c号"); lc_xljmlx.Items.Add("40a号"); lc_xljmlx.Items.Add("40b号"); lc_xljmlx.Items.Add("40c号");

            }
            else if (lc_xlca.SelectedIndex == 4)//钢管
            {
                lc_xljmlx.Enabled = lc_xls.Enabled = true;
                lc_xlfmg.Enabled = lc_xlfmk.Enabled = false;
                lc_xljmlx.Items.Clear();
                lc_xljmlx.Items.Add("φ48×3.5"); lc_xljmlx.Items.Add("φ48×3.25"); lc_xljmlx.Items.Add("φ48×3.2"); lc_xljmlx.Items.Add("φ48×3"); lc_xljmlx.Items.Add("φ51×3");

            }
        }

        private void Btn_BF_1preview_Click(object sender, EventArgs e)
        {
            if (Db_BF_LZGS.Value == 2)
            {
                FrmShowChart showchart = new FrmShowChart(15);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 3)
            {
                FrmShowChart showchart = new FrmShowChart(16);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 4)
            {
                FrmShowChart showchart = new FrmShowChart(17);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 5)
            {
                FrmShowChart showchart = new FrmShowChart(18);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 6)
            {
                FrmShowChart showchart = new FrmShowChart(19);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 7)
            {
                FrmShowChart showchart = new FrmShowChart(20);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 8)
            {
                FrmShowChart showchart = new FrmShowChart(21);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 9)
            {
                FrmShowChart showchart = new FrmShowChart(22);
                showchart.ShowDialog();
            }
            else if (Db_BF_LZGS.Value == 10)
            {
                FrmShowChart showchart = new FrmShowChart(23);
                showchart.ShowDialog();
            }
            else
            {
                MessageBox.Show("暂无预览");
            }
        }

        private void KJ_LZGS_ValueChanged(object sender, EventArgs e)
        {
            
        
            if (KJ_LZGS.Value == 0)
            {
                KJ_JL1.Enabled = KJ_JL2.Enabled = false;
            }
            else if (KJ_LZGS.Value == 1)
            {
                KJ_JL2.Enabled = false;
                KJ_JL1.Enabled = true;
                KJ_JL1.Value = 0;
            }
            else
            {
                KJ_JL1.Enabled = KJ_JL2.Enabled = true;
                KJ_JL1.Value = KJ_JL2.Value = 0;
            }
        }
        }


    }
