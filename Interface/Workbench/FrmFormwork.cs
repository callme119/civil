using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmFormwork : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;
  
        public FrmFormwork(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            CbxFormworkType.SelectedIndex = 0;
        }

        private void CbxFormworkType_SelectedIndexChanged(object sender, EventArgs e) //板模板窗体首页
        {
            if (CbxFormworkType.SelectedIndex == 0)
            {
                FKtabItem1.Visible = FKtabItem2.Visible = FKtabItem3.Visible = FKtabItem4.Visible = FKtabItem5.Visible = FKtabItem7.Visible = FKtabItem8.Visible = true;
                FKtabItem6.Visible = false;
                Cb_FK_2JDCLX.SelectedIndex = 0;
            }
        }

        private void Cb_FK_3XLCZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FK_3XLCZ.SelectedIndex == 0)//方木
            {
                Cb_FK_3JMLX.Enabled = Db_FK_3MJJ.Enabled = false;
                Db_FK_3FMG.Enabled = Db_FK_3FMK.Enabled = true;
            }
            else if (Cb_FK_3XLCZ.SelectedIndex == 1)//方钢管
            {
                Cb_FK_3JMLX.Enabled = Db_FK_3MJJ.Enabled = true;
                Db_FK_3FMG.Enabled = Db_FK_3FMK.Enabled = false;
                Cb_FK_3JMLX.Items.Clear();
                Cb_FK_3JMLX.Items.Add("□60×40×2.5"); Cb_FK_3JMLX.Items.Add("□80×40×2"); Cb_FK_3JMLX.Items.Add("□100×50×3");
            }
            else if (Cb_FK_3XLCZ.SelectedIndex == 2)//工字钢
            {
                Cb_FK_3JMLX.Enabled = Db_FK_3MJJ.Enabled = true;
                Db_FK_3FMG.Enabled = Db_FK_3FMK.Enabled = false;
                Cb_FK_3JMLX.Items.Clear();
                Cb_FK_3JMLX.Items.Add("10号"); Cb_FK_3JMLX.Items.Add("12.6号"); Cb_FK_3JMLX.Items.Add("14号"); Cb_FK_3JMLX.Items.Add("16号"); Cb_FK_3JMLX.Items.Add("18号");
                Cb_FK_3JMLX.Items.Add("20a号"); Cb_FK_3JMLX.Items.Add("20b号"); Cb_FK_3JMLX.Items.Add("22a号"); Cb_FK_3JMLX.Items.Add("22b号"); Cb_FK_3JMLX.Items.Add("25a号");
                Cb_FK_3JMLX.Items.Add("25b号"); Cb_FK_3JMLX.Items.Add("28a号"); Cb_FK_3JMLX.Items.Add("28b号"); Cb_FK_3JMLX.Items.Add("32a号"); Cb_FK_3JMLX.Items.Add("32b号");
                Cb_FK_3JMLX.Items.Add("32c号"); Cb_FK_3JMLX.Items.Add("36a号"); Cb_FK_3JMLX.Items.Add("36b号"); Cb_FK_3JMLX.Items.Add("36c号"); Cb_FK_3JMLX.Items.Add("40a号");
                Cb_FK_3JMLX.Items.Add("40b号"); Cb_FK_3JMLX.Items.Add("40c号"); Cb_FK_3JMLX.Items.Add("45a号"); Cb_FK_3JMLX.Items.Add("45b号"); Cb_FK_3JMLX.Items.Add("45c号");
                Cb_FK_3JMLX.Items.Add("50a号"); Cb_FK_3JMLX.Items.Add("50b号"); Cb_FK_3JMLX.Items.Add("50c号"); Cb_FK_3JMLX.Items.Add("56a号"); Cb_FK_3JMLX.Items.Add("56b号");
                Cb_FK_3JMLX.Items.Add("56c号"); Cb_FK_3JMLX.Items.Add("63a号"); Cb_FK_3JMLX.Items.Add("63b号"); Cb_FK_3JMLX.Items.Add("63c号");
            }
            else if (Cb_FK_3XLCZ.SelectedIndex == 3)//槽钢
            {
                Cb_FK_3JMLX.Enabled = Db_FK_3MJJ.Enabled = true;
                Db_FK_3FMG.Enabled = Db_FK_3FMK.Enabled = false;
                Cb_FK_3JMLX.Items.Clear();
                Cb_FK_3JMLX.Items.Add("5号"); Cb_FK_3JMLX.Items.Add("6.3号"); Cb_FK_3JMLX.Items.Add("8号"); Cb_FK_3JMLX.Items.Add("10号"); Cb_FK_3JMLX.Items.Add("12.6号");
                Cb_FK_3JMLX.Items.Add("14a号"); Cb_FK_3JMLX.Items.Add("14b号"); Cb_FK_3JMLX.Items.Add("16a号"); Cb_FK_3JMLX.Items.Add("16b号"); Cb_FK_3JMLX.Items.Add("18a号");
                Cb_FK_3JMLX.Items.Add("18b号"); Cb_FK_3JMLX.Items.Add("20a号"); Cb_FK_3JMLX.Items.Add("20b号"); Cb_FK_3JMLX.Items.Add("22a号"); Cb_FK_3JMLX.Items.Add("22b号");
                Cb_FK_3JMLX.Items.Add("25a号"); Cb_FK_3JMLX.Items.Add("25b号"); Cb_FK_3JMLX.Items.Add("25c号"); Cb_FK_3JMLX.Items.Add("28a号"); Cb_FK_3JMLX.Items.Add("28b号");
                Cb_FK_3JMLX.Items.Add("28c号"); Cb_FK_3JMLX.Items.Add("32a号"); Cb_FK_3JMLX.Items.Add("32b号"); Cb_FK_3JMLX.Items.Add("32c号"); Cb_FK_3JMLX.Items.Add("36a号");
                Cb_FK_3JMLX.Items.Add("36b号"); Cb_FK_3JMLX.Items.Add("36c号"); Cb_FK_3JMLX.Items.Add("40a号"); Cb_FK_3JMLX.Items.Add("40b号"); Cb_FK_3JMLX.Items.Add("40c号");
            }
            else if (Cb_FK_3XLCZ.SelectedIndex == 4)//钢管
            {
                Cb_FK_3JMLX.Enabled = Db_FK_3MJJ.Enabled = true;
                Db_FK_3FMG.Enabled = Db_FK_3FMK.Enabled = false;
                Cb_FK_3JMLX.Items.Clear();
                Cb_FK_3JMLX.Items.Add("φ48×3.5"); Cb_FK_3JMLX.Items.Add("φ48×3.25"); Cb_FK_3JMLX.Items.Add("φ48×3.2"); Cb_FK_3JMLX.Items.Add("φ48×3"); Cb_FK_3JMLX.Items.Add("φ51×3");
            }
        }//小梁

        private void Db_FK_3FMK_ValueChanged(object sender, EventArgs e)
        {
            Db_FK_3GXJ.Value = Math.Round((Db_FK_3FMK.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value / 12 / 10000), 2);
            Db_FK_3DKJ.Value = Math.Round((Db_FK_3FMK.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value / 12 / 1000), 2);
        }

        private void Db_FK_3FMG_ValueChanged(object sender, EventArgs e)
        {
            Db_FK_3GXJ.Value = Math.Round((Db_FK_3FMK.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value / 12 / 10000), 2);
            Db_FK_3DKJ.Value = Math.Round((Db_FK_3FMK.Value * Db_FK_3FMG.Value * Db_FK_3FMG.Value / 12 / 1000), 2);
        }

        private void Cb_FK_3JMLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FK_3XLCZ.SelectedIndex == 1)//方钢管
            {
                switch (Cb_FK_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_3GXJ.Value = 21.88;
                        Db_FK_3DKJ.Value = 7.29;
                        Db_FK_3MJJ.Value = 3.58;
                        break;
                    case 1:
                        Db_FK_3GXJ.Value = 37.13;
                        Db_FK_3DKJ.Value = 9.28;
                        Db_FK_3MJJ.Value = 3.69;
                        break;
                    case 2:
                        Db_FK_3GXJ.Value = 112.12;
                        Db_FK_3DKJ.Value = 22.42;
                        Db_FK_3MJJ.Value = 8.50;
                        break;
                }
            }
            else if (Cb_FK_3XLCZ.SelectedIndex == 2)//工字钢
            {
                switch (Cb_FK_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_3GXJ.Value = 245;
                        Db_FK_3DKJ.Value = 49;
                        Db_FK_3MJJ.Value = 28.52;
                        break;
                    case 1:
                        Db_FK_3GXJ.Value = 488.99;
                        Db_FK_3DKJ.Value = 77.53;
                        Db_FK_3MJJ.Value = 29.05;
                        break;
                    case 2:
                        Db_FK_3GXJ.Value = 712;
                        Db_FK_3DKJ.Value = 102;
                        Db_FK_3MJJ.Value = 59.33;
                        break;
                    case 3:
                        Db_FK_3GXJ.Value = 1130;
                        Db_FK_3DKJ.Value = 141;
                        Db_FK_3MJJ.Value = 81.88;
                        break;
                    case 4:
                        Db_FK_3GXJ.Value = 1660;
                        Db_FK_3DKJ.Value = 185;
                        Db_FK_3MJJ.Value = 107.79;
                        break;
                    case 5:
                        Db_FK_3GXJ.Value = 2370;
                        Db_FK_3DKJ.Value = 237;
                        Db_FK_3MJJ.Value = 137.79;
                        break;
                    case 6:
                        Db_FK_3GXJ.Value = 2550;
                        Db_FK_3DKJ.Value = 250;
                        Db_FK_3MJJ.Value = 147.93;
                        break;
                    case 7:
                        Db_FK_3GXJ.Value = 3400;
                        Db_FK_3DKJ.Value = 309;
                        Db_FK_3MJJ.Value = 179.89;
                        break;
                    case 8:
                        Db_FK_3GXJ.Value = 3570;
                        Db_FK_3DKJ.Value = 325;
                        Db_FK_3MJJ.Value = 190.911;//小数点后三位精确不到
                        break;
                    case 10:
                        Db_FK_3GXJ.Value = 5023.54;
                        Db_FK_3DKJ.Value = 401.88;
                        Db_FK_3MJJ.Value = 232.41;
                        break;
                    case 11:
                        Db_FK_3GXJ.Value = 5283.96;
                        Db_FK_3DKJ.Value = 422.72;
                        Db_FK_3MJJ.Value = 247.89;
                        break;
                    case 12:
                        Db_FK_3GXJ.Value = 7114.14;
                        Db_FK_3DKJ.Value = 508.15;
                        Db_FK_3MJJ.Value = 289.02;
                        break;
                    case 13:
                        Db_FK_3GXJ.Value = 7480;
                        Db_FK_3DKJ.Value = 534.29;
                        Db_FK_3MJJ.Value = 309.09;
                        break;
                    case 14:
                        Db_FK_3GXJ.Value = 11075.5;
                        Db_FK_3DKJ.Value = 682.2;
                        Db_FK_3MJJ.Value = 402.91;
                        break;
                    case 15:
                        Db_FK_3GXJ.Value = 11621.4;
                        Db_FK_3DKJ.Value = 726.33;
                        Db_FK_3MJJ.Value = 428.78;
                        break;
                    case 16:
                        Db_FK_3GXJ.Value = 12167.5;
                        Db_FK_3DKJ.Value = 760.47;
                        Db_FK_3MJJ.Value = 454.10;
                        break;
                    case 17:
                        Db_FK_3GXJ.Value = 15760;
                        Db_FK_3DKJ.Value = 875;
                        Db_FK_3MJJ.Value = 513.36;
                        break;
                    case 18:
                        Db_FK_3GXJ.Value = 16530;
                        Db_FK_3DKJ.Value = 919;
                        Db_FK_3MJJ.Value = 545.55;
                        break;
                    case 19:
                        Db_FK_3GXJ.Value = 17310;
                        Db_FK_3DKJ.Value = 962;
                        Db_FK_3MJJ.Value = 578.93;
                        break;
                    case 20:
                        Db_FK_3GXJ.Value = 21720;
                        Db_FK_3DKJ.Value = 1090;
                        Db_FK_3MJJ.Value = 636.95;
                        break;
                    case 21:
                        Db_FK_3GXJ.Value = 22780;
                        Db_FK_3DKJ.Value = 1140;
                        Db_FK_3MJJ.Value = 677.98;
                        break;
                    case 22:
                        Db_FK_3GXJ.Value = 23850;
                        Db_FK_3DKJ.Value = 1190;
                        Db_FK_3MJJ.Value = 718.37;
                        break;
                    case 23:
                        Db_FK_3GXJ.Value = 32240;
                        Db_FK_3DKJ.Value = 1430;
                        Db_FK_3MJJ.Value = 835.23;
                        break;
                    case 24:
                        Db_FK_3GXJ.Value = 33760;
                        Db_FK_3DKJ.Value = 1500;
                        Db_FK_3MJJ.Value = 888.42;
                        break;
                    case 25:
                        Db_FK_3GXJ.Value = 35280;
                        Db_FK_3DKJ.Value = 1570;
                        Db_FK_3MJJ.Value = 938.3;
                        break;
                    case 26:
                        Db_FK_3GXJ.Value = 46470;
                        Db_FK_3DKJ.Value = 1860;
                        Db_FK_3MJJ.Value = 1085.75;
                        break;
                    case 27:
                        Db_FK_3GXJ.Value = 48560;
                        Db_FK_3DKJ.Value = 1940;
                        Db_FK_3MJJ.Value = 1145.28;
                        break;
                    case 28:
                        Db_FK_3GXJ.Value = 50640;
                        Db_FK_3DKJ.Value = 2080;
                        Db_FK_3MJJ.Value = 1211.48;
                        break;
                    case 29:
                        Db_FK_3GXJ.Value = 65585.6;
                        Db_FK_3DKJ.Value = 2342.31;
                        Db_FK_3MJJ.Value = 1375.05;
                        break;
                    case 30:
                        Db_FK_3GXJ.Value = 68512.5;
                        Db_FK_3DKJ.Value = 2446.69;
                        Db_FK_3MJJ.Value = 1451.48;
                        break;
                    case 31:
                        Db_FK_3GXJ.Value = 71439.4;
                        Db_FK_3DKJ.Value = 2551.41;
                        Db_FK_3MJJ.Value = 1529.76;
                        break;
                    case 32:
                        Db_FK_3GXJ.Value = 93916.2;
                        Db_FK_3DKJ.Value = 2981.47;
                        Db_FK_3MJJ.Value = 1732.84;
                        break;
                    case 33:
                        Db_FK_3GXJ.Value = 98083.6;
                        Db_FK_3DKJ.Value = 3163.38;
                        Db_FK_3MJJ.Value = 1833.27;
                        break;
                    case 34:
                        Db_FK_3GXJ.Value = 102251.1;
                        Db_FK_3DKJ.Value = 3298.42;
                        Db_FK_3MJJ.Value = 1932.89;
                        break;
                }
            }
            else if(Cb_FK_3XLCZ.SelectedIndex == 3)//槽钢
            {
                switch (Cb_FK_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_3GXJ.Value = 26;
                        Db_FK_3DKJ.Value = 10.4;
                        Db_FK_3MJJ.Value = 5.84;
                        break;
                    case 1:
                        Db_FK_3GXJ.Value = 50.79;
                        Db_FK_3DKJ.Value = 16.12;
                        Db_FK_3MJJ.Value = 8.77;
                        break;
                    case 2:
                        Db_FK_3GXJ.Value = 101.3;
                        Db_FK_3DKJ.Value = 25.3;
                        Db_FK_3MJJ.Value = 13.11;
                        break;
                    case 3:
                        Db_FK_3GXJ.Value = 198;
                        Db_FK_3DKJ.Value = 39.7;
                        Db_FK_3MJJ.Value = 19.85;
                        break;
                    case 4:
                        Db_FK_3GXJ.Value = 391;
                        Db_FK_3DKJ.Value = 62.1;
                        Db_FK_3MJJ.Value = 30.06;
                        break;
                    case 5:
                        Db_FK_3GXJ.Value = 564;
                        Db_FK_3DKJ.Value = 80.5;
                        Db_FK_3MJJ.Value = 38.50;
                        break;
                    case 6:
                        Db_FK_3GXJ.Value = 609;
                        Db_FK_3DKJ.Value = 87.1;
                        Db_FK_3MJJ.Value = 39.74;
                        break;
                    case 7:
                        Db_FK_3GXJ.Value = 866;
                        Db_FK_3DKJ.Value = 108;
                        Db_FK_3MJJ.Value = 50.45;
                        break;
                    case 8:
                        Db_FK_3GXJ.Value = 934;
                        Db_FK_3DKJ.Value = 117;
                        Db_FK_3MJJ.Value = 51.95;
                        break;
                    case 9:
                        Db_FK_3GXJ.Value = 1273;
                        Db_FK_3DKJ.Value = 141;
                        Db_FK_3MJJ.Value = 64.90;
                        break;
                    case 10:
                        Db_FK_3GXJ.Value = 1370;
                        Db_FK_3DKJ.Value = 152;
                        Db_FK_3MJJ.Value = 66.68;
                        break;
                    case 11:
                        Db_FK_3GXJ.Value = 1780;
                        Db_FK_3DKJ.Value = 178;
                        Db_FK_3MJJ.Value = 81.17;
                        break;
                    case 12:
                        Db_FK_3GXJ.Value = 1914;
                        Db_FK_3DKJ.Value = 191;
                        Db_FK_3MJJ.Value = 83.25;
                        break;
                    case 13:
                        Db_FK_3GXJ.Value = 2394;
                        Db_FK_3DKJ.Value = 218;
                        Db_FK_3MJJ.Value = 98.73;
                        break;
                    case 14:
                        Db_FK_3GXJ.Value = 2571;
                        Db_FK_3DKJ.Value = 234;
                        Db_FK_3MJJ.Value = 101.13;
                        break;
                    case 15:
                        Db_FK_3GXJ.Value = 3370;
                        Db_FK_3DKJ.Value = 270;
                        Db_FK_3MJJ.Value = 119.91;
                        break;
                    case 16:
                        Db_FK_3GXJ.Value = 3530;
                        Db_FK_3DKJ.Value = 282;
                        Db_FK_3MJJ.Value = 122.77;
                        break;
                    case 17:
                        Db_FK_3GXJ.Value = 3696;
                        Db_FK_3DKJ.Value = 295;
                        Db_FK_3MJJ.Value = 125.62;
                        break;
                    case 18:
                        Db_FK_3GXJ.Value = 4765;
                        Db_FK_3DKJ.Value = 340;
                        Db_FK_3MJJ.Value = 147.73;
                        break;
                    case 19:
                        Db_FK_3GXJ.Value = 5130;
                        Db_FK_3DKJ.Value = 366;
                        Db_FK_3MJJ.Value = 151.07;
                        break;
                    case 20:
                        Db_FK_3GXJ.Value = 5495;
                        Db_FK_3DKJ.Value = 393;
                        Db_FK_3MJJ.Value = 154.42;
                        break;
                    case 21:
                        Db_FK_3GXJ.Value = 7598;
                        Db_FK_3DKJ.Value = 475;
                        Db_FK_3MJJ.Value = 204.51;
                        break;
                    case 22:
                        Db_FK_3GXJ.Value = 8144;
                        Db_FK_3DKJ.Value = 509;
                        Db_FK_3MJJ.Value = 208.79;
                        break;
                    case 23:
                        Db_FK_3GXJ.Value = 8690;
                        Db_FK_3DKJ.Value = 543;
                        Db_FK_3MJJ.Value = 213.08;
                        break;
                    case 24:
                        Db_FK_3GXJ.Value = 11870;
                        Db_FK_3DKJ.Value = 660;
                        Db_FK_3MJJ.Value = 283.32;
                        break;
                    case 25:
                        Db_FK_3GXJ.Value = 12650;
                        Db_FK_3DKJ.Value = 703;
                        Db_FK_3MJJ.Value = 288.82;
                        break;
                    case 26:
                        Db_FK_3GXJ.Value = 13430;
                        Db_FK_3DKJ.Value = 746;
                        Db_FK_3MJJ.Value = 294.32;
                        break;
                    case 27:
                        Db_FK_3GXJ.Value = 17580;
                        Db_FK_3DKJ.Value = 879;
                        Db_FK_3MJJ.Value = 367.81;
                        break;
                    case 28:
                        Db_FK_3GXJ.Value = 18640;
                        Db_FK_3DKJ.Value = 932;
                        Db_FK_3MJJ.Value = 374.69;
                        break;
                    case 29:
                        Db_FK_3GXJ.Value = 19710;
                        Db_FK_3DKJ.Value = 986;
                        Db_FK_3MJJ.Value = 381.56;
                        break;            
                }
            }
            else if(Cb_FK_3XLCZ.SelectedIndex == 4)//钢管
            {
                switch (Cb_FK_3JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_3GXJ.Value = 12.19;
                        Db_FK_3DKJ.Value = 5.08;
                        Db_FK_3MJJ.Value = 7.78;
                        break;
                    case 1:
                        Db_FK_3GXJ.Value = 11.5;
                        Db_FK_3DKJ.Value = 4.79;
                        Db_FK_3MJJ.Value = 7.73;
                        break;
                    case 2:
                        Db_FK_3GXJ.Value = 11.36;
                        Db_FK_3DKJ.Value = 4.73;
                        Db_FK_3MJJ.Value = 7.72;
                        break;
                    case 3:
                        Db_FK_3GXJ.Value = 10.78;
                        Db_FK_3DKJ.Value = 4.49;
                        Db_FK_3MJJ.Value = 7.67;
                        break;
                    case 4:
                        Db_FK_3GXJ.Value = 13.08;
                        Db_FK_3DKJ.Value = 5.13;
                        Db_FK_3MJJ.Value = 9.16;
                        break;
                }
            }

        }

        private void Cb_FK_4ZLCZ_SelectedIndexChanged(object sender, EventArgs e)//主梁
        {
            if (Cb_FK_4ZLCZ.SelectedIndex == 0)//方木
            {
                Cb_FK_4JMLX.Enabled = Db_FK_4MJJ.Enabled = false;
                Db_FK_4FMG.Enabled = Db_FK_4FMK.Enabled = true;
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 1)//方钢管
            {
                Cb_FK_4JMLX.Enabled = Db_FK_4MJJ.Enabled = true;
                Db_FK_4FMG.Enabled = Db_FK_4FMK.Enabled = false;
                Cb_FK_4JMLX.Items.Clear();
                Cb_FK_4JMLX.Items.Add("□60×40×2.5"); Cb_FK_4JMLX.Items.Add("□80×40×2"); Cb_FK_4JMLX.Items.Add("□100×50×3");
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 2)//工字钢
            {
                Cb_FK_4JMLX.Enabled = Db_FK_4MJJ.Enabled = true;
                Db_FK_4FMG.Enabled = Db_FK_4FMK.Enabled = false;
                Cb_FK_4JMLX.Items.Clear();
                Cb_FK_4JMLX.Items.Add("10号"); Cb_FK_4JMLX.Items.Add("12.6号"); Cb_FK_4JMLX.Items.Add("14号"); Cb_FK_4JMLX.Items.Add("16号"); Cb_FK_4JMLX.Items.Add("18号");
                Cb_FK_4JMLX.Items.Add("20a号"); Cb_FK_4JMLX.Items.Add("20b号"); Cb_FK_4JMLX.Items.Add("22a号"); Cb_FK_4JMLX.Items.Add("22b号"); Cb_FK_4JMLX.Items.Add("25a号");
                Cb_FK_4JMLX.Items.Add("25b号"); Cb_FK_4JMLX.Items.Add("28a号"); Cb_FK_4JMLX.Items.Add("28b号"); Cb_FK_4JMLX.Items.Add("32a号"); Cb_FK_4JMLX.Items.Add("32b号");
                Cb_FK_4JMLX.Items.Add("32c号"); Cb_FK_4JMLX.Items.Add("36a号"); Cb_FK_4JMLX.Items.Add("36b号"); Cb_FK_4JMLX.Items.Add("36c号"); Cb_FK_4JMLX.Items.Add("40a号");
                Cb_FK_4JMLX.Items.Add("40b号"); Cb_FK_4JMLX.Items.Add("40c号"); Cb_FK_4JMLX.Items.Add("45a号"); Cb_FK_4JMLX.Items.Add("45b号"); Cb_FK_4JMLX.Items.Add("45c号");
                Cb_FK_4JMLX.Items.Add("50a号"); Cb_FK_4JMLX.Items.Add("50b号"); Cb_FK_4JMLX.Items.Add("50c号"); Cb_FK_4JMLX.Items.Add("56a号"); Cb_FK_4JMLX.Items.Add("56b号");
                Cb_FK_4JMLX.Items.Add("56c号"); Cb_FK_4JMLX.Items.Add("63a号"); Cb_FK_4JMLX.Items.Add("63b号"); Cb_FK_4JMLX.Items.Add("63c号");
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 3)//槽钢
            {
                Cb_FK_4JMLX.Enabled = Db_FK_4MJJ.Enabled = true;
                Db_FK_4FMG.Enabled = Db_FK_4FMK.Enabled = false;
                Cb_FK_4JMLX.Items.Clear();
                Cb_FK_4JMLX.Items.Add("5号"); Cb_FK_4JMLX.Items.Add("6.3号"); Cb_FK_4JMLX.Items.Add("8号"); Cb_FK_4JMLX.Items.Add("10号"); Cb_FK_4JMLX.Items.Add("12.6号");
                Cb_FK_4JMLX.Items.Add("14a号"); Cb_FK_4JMLX.Items.Add("14b号"); Cb_FK_4JMLX.Items.Add("16a号"); Cb_FK_4JMLX.Items.Add("16b号"); Cb_FK_4JMLX.Items.Add("18a号");
                Cb_FK_4JMLX.Items.Add("18b号"); Cb_FK_4JMLX.Items.Add("20a号"); Cb_FK_4JMLX.Items.Add("20b号"); Cb_FK_4JMLX.Items.Add("22a号"); Cb_FK_4JMLX.Items.Add("22b号");
                Cb_FK_4JMLX.Items.Add("25a号"); Cb_FK_4JMLX.Items.Add("25b号"); Cb_FK_4JMLX.Items.Add("25c号"); Cb_FK_4JMLX.Items.Add("28a号"); Cb_FK_4JMLX.Items.Add("28b号");
                Cb_FK_4JMLX.Items.Add("28c号"); Cb_FK_4JMLX.Items.Add("32a号"); Cb_FK_4JMLX.Items.Add("32b号"); Cb_FK_4JMLX.Items.Add("32c号"); Cb_FK_4JMLX.Items.Add("36a号");
                Cb_FK_4JMLX.Items.Add("36b号"); Cb_FK_4JMLX.Items.Add("36c号"); Cb_FK_4JMLX.Items.Add("40a号"); Cb_FK_4JMLX.Items.Add("40b号"); Cb_FK_4JMLX.Items.Add("40c号");
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 4)//钢管
            {
                Cb_FK_4JMLX.Enabled = Db_FK_4MJJ.Enabled = true;
                Db_FK_4FMG.Enabled = Db_FK_4FMK.Enabled = false;
                Cb_FK_4JMLX.Items.Clear();
                Cb_FK_4JMLX.Items.Add("φ48×3.5"); Cb_FK_4JMLX.Items.Add("φ48×3.25"); Cb_FK_4JMLX.Items.Add("φ48×3.2"); Cb_FK_4JMLX.Items.Add("φ48×3"); Cb_FK_4JMLX.Items.Add("φ51×3");
            }

        }

        private void Db_FK_4FMK_ValueChanged(object sender, EventArgs e)
        {
            Db_FK_4GXJ.Value = Math.Round((Db_FK_4FMK.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value / 12 / 10000), 2);
            Db_FK_4DKJ.Value = Math.Round((Db_FK_4FMK.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value / 12 / 1000), 2);
        }

        private void Db_FK_4FMG_ValueChanged(object sender, EventArgs e)
        {
            Db_FK_4GXJ.Value = Math.Round((Db_FK_4FMK.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value / 12 / 10000), 2);
            Db_FK_4DKJ.Value = Math.Round((Db_FK_4FMK.Value * Db_FK_4FMG.Value * Db_FK_4FMG.Value / 12 / 1000), 2);
        }

        private void Cb_FK_4JMLX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FK_4ZLCZ.SelectedIndex == 1)//方钢管
            {
                switch (Cb_FK_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_4GXJ.Value = 21.88;
                        Db_FK_4DKJ.Value = 7.29;
                        Db_FK_4MJJ.Value = 3.58;
                        break;
                    case 1:
                        Db_FK_4GXJ.Value = 37.13;
                        Db_FK_4DKJ.Value = 9.28;
                        Db_FK_4MJJ.Value = 3.69;
                        break;
                    case 2:
                        Db_FK_4GXJ.Value = 112.12;
                        Db_FK_4DKJ.Value = 22.42;
                        Db_FK_4MJJ.Value = 8.50;
                        break;
                }
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 2)//工字钢
            {
                switch (Cb_FK_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_4GXJ.Value = 245;
                        Db_FK_4DKJ.Value = 49;
                        Db_FK_4MJJ.Value = 28.52;
                        break;
                    case 1:
                        Db_FK_4GXJ.Value = 488.99;
                        Db_FK_4DKJ.Value = 77.53;
                        Db_FK_4MJJ.Value = 29.05;
                        break;
                    case 2:
                        Db_FK_4GXJ.Value = 712;
                        Db_FK_4DKJ.Value = 102;
                        Db_FK_4MJJ.Value = 59.33;
                        break;
                    case 3:
                        Db_FK_4GXJ.Value = 1130;
                        Db_FK_4DKJ.Value = 141;
                        Db_FK_4MJJ.Value = 81.88;
                        break;
                    case 4:
                        Db_FK_4GXJ.Value = 1660;
                        Db_FK_4DKJ.Value = 185;
                        Db_FK_4MJJ.Value = 107.79;
                        break;
                    case 5:
                        Db_FK_4GXJ.Value = 2370;
                        Db_FK_4DKJ.Value = 237;
                        Db_FK_4MJJ.Value = 137.79;
                        break;
                    case 6:
                        Db_FK_4GXJ.Value = 2550;
                        Db_FK_4DKJ.Value = 250;
                        Db_FK_4MJJ.Value = 147.93;
                        break;
                    case 7:
                        Db_FK_4GXJ.Value = 3400;
                        Db_FK_4DKJ.Value = 309;
                        Db_FK_4MJJ.Value = 179.89;
                        break;
                    case 8:
                        Db_FK_4GXJ.Value = 3570;
                        Db_FK_4DKJ.Value = 325;
                        Db_FK_4MJJ.Value = 190.911;//小数点后三位精确不到
                        break;
                    case 10:
                        Db_FK_4GXJ.Value = 5023.54;
                        Db_FK_4DKJ.Value = 401.88;
                        Db_FK_4MJJ.Value = 232.41;
                        break;
                    case 11:
                        Db_FK_4GXJ.Value = 5283.96;
                        Db_FK_4DKJ.Value = 422.72;
                        Db_FK_4MJJ.Value = 247.89;
                        break;
                    case 12:
                        Db_FK_4GXJ.Value = 7114.14;
                        Db_FK_4DKJ.Value = 508.15;
                        Db_FK_4MJJ.Value = 289.02;
                        break;
                    case 13:
                        Db_FK_4GXJ.Value = 7480;
                        Db_FK_4DKJ.Value = 534.29;
                        Db_FK_4MJJ.Value = 309.09;
                        break;
                    case 14:
                        Db_FK_4GXJ.Value = 11075.5;
                        Db_FK_4DKJ.Value = 682.2;
                        Db_FK_4MJJ.Value = 402.91;
                        break;
                    case 15:
                        Db_FK_4GXJ.Value = 11621.4;
                        Db_FK_4DKJ.Value = 726.33;
                        Db_FK_4MJJ.Value = 428.78;
                        break;
                    case 16:
                        Db_FK_4GXJ.Value = 12167.5;
                        Db_FK_4DKJ.Value = 760.47;
                        Db_FK_4MJJ.Value = 454.10;
                        break;
                    case 17:
                        Db_FK_4GXJ.Value = 15760;
                        Db_FK_4DKJ.Value = 875;
                        Db_FK_4MJJ.Value = 513.36;
                        break;
                    case 18:
                        Db_FK_4GXJ.Value = 16530;
                        Db_FK_4DKJ.Value = 919;
                        Db_FK_4MJJ.Value = 545.55;
                        break;
                    case 19:
                        Db_FK_4GXJ.Value = 17310;
                        Db_FK_4DKJ.Value = 962;
                        Db_FK_4MJJ.Value = 578.93;
                        break;
                    case 20:
                        Db_FK_4GXJ.Value = 21720;
                        Db_FK_4DKJ.Value = 1090;
                        Db_FK_4MJJ.Value = 636.95;
                        break;
                    case 21:
                        Db_FK_4GXJ.Value = 22780;
                        Db_FK_4DKJ.Value = 1140;
                        Db_FK_4MJJ.Value = 677.98;
                        break;
                    case 22:
                        Db_FK_4GXJ.Value = 23850;
                        Db_FK_4DKJ.Value = 1190;
                        Db_FK_4MJJ.Value = 718.37;
                        break;
                    case 23:
                        Db_FK_4GXJ.Value = 32240;
                        Db_FK_4DKJ.Value = 1430;
                        Db_FK_4MJJ.Value = 835.23;
                        break;
                    case 24:
                        Db_FK_4GXJ.Value = 33760;
                        Db_FK_4DKJ.Value = 1500;
                        Db_FK_4MJJ.Value = 888.42;
                        break;
                    case 25:
                        Db_FK_4GXJ.Value = 35280;
                        Db_FK_4DKJ.Value = 1570;
                        Db_FK_4MJJ.Value = 938.3;
                        break;
                    case 26:
                        Db_FK_4GXJ.Value = 46470;
                        Db_FK_4DKJ.Value = 1860;
                        Db_FK_4MJJ.Value = 1085.75;
                        break;
                    case 27:
                        Db_FK_4GXJ.Value = 48560;
                        Db_FK_4DKJ.Value = 1940;
                        Db_FK_4MJJ.Value = 1145.28;
                        break;
                    case 28:
                        Db_FK_4GXJ.Value = 50640;
                        Db_FK_4DKJ.Value = 2080;
                        Db_FK_4MJJ.Value = 1211.48;
                        break;
                    case 29:
                        Db_FK_4GXJ.Value = 65585.6;
                        Db_FK_4DKJ.Value = 2342.31;
                        Db_FK_4MJJ.Value = 1375.05;
                        break;
                    case 30:
                        Db_FK_4GXJ.Value = 68512.5;
                        Db_FK_4DKJ.Value = 2446.69;
                        Db_FK_4MJJ.Value = 1451.48;
                        break;
                    case 31:
                        Db_FK_4GXJ.Value = 71439.4;
                        Db_FK_4DKJ.Value = 2551.41;
                        Db_FK_4MJJ.Value = 1529.76;
                        break;
                    case 32:
                        Db_FK_4GXJ.Value = 93916.2;
                        Db_FK_4DKJ.Value = 2981.47;
                        Db_FK_4MJJ.Value = 1732.84;
                        break;
                    case 33:
                        Db_FK_4GXJ.Value = 98083.6;
                        Db_FK_4DKJ.Value = 3163.38;
                        Db_FK_4MJJ.Value = 1833.27;
                        break;
                    case 34:
                        Db_FK_4GXJ.Value = 102251.1;
                        Db_FK_4DKJ.Value = 3298.42;
                        Db_FK_4MJJ.Value = 1932.89;
                        break;
                }
            }
            else if(Cb_FK_4ZLCZ.SelectedIndex == 3)//槽钢
            {
                switch (Cb_FK_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_4GXJ.Value = 26;
                        Db_FK_4DKJ.Value = 10.4;
                        Db_FK_4MJJ.Value = 5.84;
                        break;
                    case 1:
                        Db_FK_4GXJ.Value = 50.79;
                        Db_FK_4DKJ.Value = 16.12;
                        Db_FK_4MJJ.Value = 8.77;
                        break;
                    case 2:
                        Db_FK_4GXJ.Value = 101.3;
                        Db_FK_4DKJ.Value = 25.3;
                        Db_FK_4MJJ.Value = 13.11;
                        break;
                    case 3:
                        Db_FK_4GXJ.Value = 198;
                        Db_FK_4DKJ.Value = 39.7;
                        Db_FK_4MJJ.Value = 19.85;
                        break;
                    case 4:
                        Db_FK_4GXJ.Value = 391;
                        Db_FK_4DKJ.Value = 62.1;
                        Db_FK_4MJJ.Value = 30.06;
                        break;
                    case 5:
                        Db_FK_4GXJ.Value = 564;
                        Db_FK_4DKJ.Value = 80.5;
                        Db_FK_4MJJ.Value = 38.50;
                        break;
                    case 6:
                        Db_FK_4GXJ.Value = 609;
                        Db_FK_4DKJ.Value = 87.1;
                        Db_FK_4MJJ.Value = 39.74;
                        break;
                    case 7:
                        Db_FK_4GXJ.Value = 866;
                        Db_FK_4DKJ.Value = 108;
                        Db_FK_4MJJ.Value = 50.45;
                        break;
                    case 8:
                        Db_FK_4GXJ.Value = 934;
                        Db_FK_4DKJ.Value = 117;
                        Db_FK_4MJJ.Value = 51.95;
                        break;
                    case 9:
                        Db_FK_4GXJ.Value = 1273;
                        Db_FK_4DKJ.Value = 141;
                        Db_FK_4MJJ.Value = 64.90;
                        break;
                    case 10:
                        Db_FK_4GXJ.Value = 1370;
                        Db_FK_4DKJ.Value = 152;
                        Db_FK_4MJJ.Value = 66.68;
                        break;
                    case 11:
                        Db_FK_4GXJ.Value = 1780;
                        Db_FK_4DKJ.Value = 178;
                        Db_FK_4MJJ.Value = 81.17;
                        break;
                    case 12:
                        Db_FK_4GXJ.Value = 1914;
                        Db_FK_4DKJ.Value = 191;
                        Db_FK_4MJJ.Value = 83.25;
                        break;
                    case 13:
                        Db_FK_4GXJ.Value = 2394;
                        Db_FK_4DKJ.Value = 218;
                        Db_FK_4MJJ.Value = 98.73;
                        break;
                    case 14:
                        Db_FK_4GXJ.Value = 2571;
                        Db_FK_4DKJ.Value = 234;
                        Db_FK_4MJJ.Value = 101.13;
                        break;
                    case 15:
                        Db_FK_4GXJ.Value = 3370;
                        Db_FK_4DKJ.Value = 270;
                        Db_FK_4MJJ.Value = 119.91;
                        break;
                    case 16:
                        Db_FK_4GXJ.Value = 3530;
                        Db_FK_4DKJ.Value = 282;
                        Db_FK_4MJJ.Value = 122.77;
                        break;
                    case 17:
                        Db_FK_4GXJ.Value = 3696;
                        Db_FK_4DKJ.Value = 295;
                        Db_FK_4MJJ.Value = 125.62;
                        break;
                    case 18:
                        Db_FK_4GXJ.Value = 4765;
                        Db_FK_4DKJ.Value = 340;
                        Db_FK_4MJJ.Value = 147.73;
                        break;
                    case 19:
                        Db_FK_4GXJ.Value = 5130;
                        Db_FK_4DKJ.Value = 366;
                        Db_FK_4MJJ.Value = 151.07;
                        break;
                    case 20:
                        Db_FK_4GXJ.Value = 5495;
                        Db_FK_4DKJ.Value = 393;
                        Db_FK_4MJJ.Value = 154.42;
                        break;
                    case 21:
                        Db_FK_4GXJ.Value = 7598;
                        Db_FK_4DKJ.Value = 475;
                        Db_FK_4MJJ.Value = 204.51;
                        break;
                    case 22:
                        Db_FK_4GXJ.Value = 8144;
                        Db_FK_4DKJ.Value = 509;
                        Db_FK_4MJJ.Value = 208.79;
                        break;
                    case 23:
                        Db_FK_4GXJ.Value = 8690;
                        Db_FK_4DKJ.Value = 543;
                        Db_FK_4MJJ.Value = 213.08;
                        break;
                    case 24:
                        Db_FK_4GXJ.Value = 11870;
                        Db_FK_4DKJ.Value = 660;
                        Db_FK_4MJJ.Value = 283.32;
                        break;
                    case 25:
                        Db_FK_4GXJ.Value = 12650;
                        Db_FK_4DKJ.Value = 703;
                        Db_FK_4MJJ.Value = 288.82;
                        break;
                    case 26:
                        Db_FK_4GXJ.Value = 13430;
                        Db_FK_4DKJ.Value = 746;
                        Db_FK_4MJJ.Value = 294.32;
                        break;
                    case 27:
                        Db_FK_4GXJ.Value = 17580;
                        Db_FK_4DKJ.Value = 879;
                        Db_FK_4MJJ.Value = 367.81;
                        break;
                    case 28:
                        Db_FK_4GXJ.Value = 18640;
                        Db_FK_4DKJ.Value = 932;
                        Db_FK_4MJJ.Value = 374.69;
                        break;
                    case 29:
                        Db_FK_4GXJ.Value = 19710;
                        Db_FK_4DKJ.Value = 986;
                        Db_FK_4MJJ.Value = 381.56;
                        break;            
                }
            }
            else if (Cb_FK_4ZLCZ.SelectedIndex == 4)//钢管
            {
                switch (Cb_FK_4JMLX.SelectedIndex)
                {
                    case 0:
                        Db_FK_4GXJ.Value = 12.19;
                        Db_FK_4DKJ.Value = 5.08;
                        Db_FK_4MJJ.Value = 7.78;
                        break;
                    case 1:
                        Db_FK_4GXJ.Value = 11.5;
                        Db_FK_4DKJ.Value = 4.79;
                        Db_FK_4MJJ.Value = 7.73;
                        break;
                    case 2:
                        Db_FK_4GXJ.Value = 11.36;
                        Db_FK_4DKJ.Value = 4.73;
                        Db_FK_4MJJ.Value = 7.72;
                        break;
                    case 3:
                        Db_FK_4GXJ.Value = 10.78;
                        Db_FK_4DKJ.Value = 4.49;
                        Db_FK_4MJJ.Value = 7.67;
                        break;
                    case 4:
                        Db_FK_4GXJ.Value = 13.08;
                        Db_FK_4DKJ.Value = 5.13;
                        Db_FK_4MJJ.Value = 9.16;
                        break;
                }
            }

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "板模板(工具式)";

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
            //FKtabItem1构造参数
            double fk1_1, fk1_2, fk1_3, fk1_4, fk1_5, fk1_6, fk1_7, fk1_9, fk1_10, fk1_12, fk1_13, fk1_13_2, fk1_14;
            string fk1_8, fk1_11;

            fk1_1 = Db_FK_GD.Value;
            fk1_2 = Db_FK_HD.Value;
            fk1_3 = Db_FK_LBCB.Value;
            fk1_4 = Db_FK_LBDB.Value;
            fk1_5 = Db_FK_SPLGBJ.Value;
            fk1_6 = Db_FK_ZXJJ.Value;
            fk1_7 = Db_FK_HXJJ.Value;
            fk1_8 = Tb_FK_WZ.Text;
            fk1_9 = Convert.ToDouble(Tb_FK_DBJL.Text);
            fk1_10 = Convert.ToDouble(Tb_FK_CBJL.Text);
            fk1_11 = Tb_FK_ZLBZFX.Text;
            fk1_12 = Db_FK_XLJJ.Value;
            fk1_13 = Db_FK_XTCD.Value;
            fk1_13_2 = Db_FK_XTCD2.Value;
            fk1_14 = Db_FK_XLDBJL.Value;

            //FKtabItem2支撑参数+面板
            string fk2_1, fk2_2;
            double fk2_3, fk2_4, fk2_5;

            //支撑参数
            fk2_1 = Cb_FK_2JDCLX.Text;

            //面板
            fk2_2 = Cb_FK_2MBLX.Text;
            fk2_3 = Db_FK_2MBHD.Value;
            fk2_4 = Db_FK_2QD.Value;
            fk2_5 = Db_FK_2TXML.Value;

            //FKtabItem3小梁
            string fk3_1, fk3_2;
            double fk3_3, fk3_4, fk3_5, fk3_6, fk3_7, fk3_8, fk3_9,fk3_10;

            fk3_1 = Cb_FK_3XLCZ.Text;
            fk3_2 = Cb_FK_3JMLX.Text;
            fk3_3 = Db_FK_3FMK.Value;
            fk3_4 = Db_FK_3FMG.Value;
            fk3_5 = Db_FK_3KWQD.Value;
            fk3_6 = Db_FK_3KJQD.Value;
            fk3_7 = Db_FK_3TXML.Value;
            fk3_8 = Db_FK_3GXJ.Value;
            fk3_9 = Db_FK_3DKJ.Value;
            fk3_10 = Db_FK_3MJJ.Value;

            //FKtabItem4主梁
            string fk4_1, fk4_2;
            double fk4_3, fk4_4, fk4_5, fk4_6, fk4_7, fk4_8, fk4_9, fk4_10;

            fk4_1 = Cb_FK_4ZLCZ.Text;
            fk4_2 = Cb_FK_4JMLX.Text;
            fk4_3 = Db_FK_4FMK.Value;
            fk4_4 = Db_FK_4FMG.Value;
            fk4_5 = Db_FK_4KWQD.Value;
            fk4_6 = Db_FK_4KJQD.Value;
            fk4_7 = Db_FK_4TXML.Value;
            fk4_8 = Db_FK_4GXJ.Value;
            fk4_9 = Db_FK_4DKJ.Value;
            fk4_10 = Db_FK_4MJJ.Value;

            //FKtabItem5立柱+插销
            string fk5_1;
            double fk5_2, fk5_3, fk5_4, fk5_5, fk5_6, fk5_7, fk5_8, fk5_9, fk5_10, fk5_11, fk5_12, fk5_13, fk5_14, fk5_15, fk5_16, fk5_17;
            //立柱
            fk5_1 = Cb_FK_5LZXH.Text;
            fk5_2 = Convert.ToDouble(Tb_FK_5RXHZ.Text);
            fk5_3 = Db_FK_5KYQD.Value;
            fk5_4 = Convert.ToDouble(Tb_FK_5CGHZBJ.Text);
            fk5_5 = Convert.ToDouble(Tb_FK_5TGHZBJ.Text);
            fk5_6 = Convert.ToDouble(Tb_FK_5CGJMMJ.Text);
            fk5_7 = Convert.ToDouble(Tb_FK_5TGJMMJ.Text);
            fk5_8 = Convert.ToDouble(Tb_FK_5CGGXJ.Text);
            fk5_9 = Convert.ToDouble(Tb_FK_5TGGXJ.Text);
            fk5_10 = Convert.ToDouble(Tb_FK_5CGDKJ.Text);
            fk5_11 = Convert.ToDouble(Tb_FK_5TGDKJ.Text);
            fk5_12 = Convert.ToDouble(Tb_FK_5CGBH.Text);
            fk5_13 = Convert.ToDouble(Tb_FK_5TGBH.Text);
            //插销
            fk5_14 = Convert.ToDouble(Cb_FK_5CXZJ.Text);
            fk5_15 = Convert.ToDouble(Tb_FK_5CXJMMJ.Text);
            fk5_16 = Convert.ToDouble(Tb_FK_5KJQD.Text);
            fk5_17 = Convert.ToDouble(Tb_FK_5CYQD.Text);

            //FKtabItem6风荷载参数+风压高度变化系数

            //FKtabItem7可调托座+地基基础
            string fk7_3, fk7_4;
            double fk7_1, fk7_2, fk7_5, fk7_6, fk7_7;
            double[] zjxs = new double[] { 1.0,0.9,0.5,0.8,0.4};

            //可调托座
            fk7_1 = Convert.ToDouble(Cb_FK_7ZLGS.Text);
            fk7_2 = Db_FK_7CZL.Value;

            //地基基础
            fk7_3 = Cb_FK_7ZYWZ.Text;
            fk7_4 = Cb_FK_7DJTLX.Text;
            fk7_5 = Db_FK_7CZL.Value;
            fk7_6 = zjxs[Cb_FK_7ZJXS.SelectedIndex];
            fk7_7 = Db_FK_7DMMJ.Value;

            //FKtabItem8荷载参数
            double fk8_1, fk8_2, fk8_3, fk8_4, fk8_5, fk8_6, fk8_8, fk8_9, fk8_10, fk8_11;
            string fk8_7;

            //永久荷载
            fk8_1 = Db_FK_8MBZZ.Value;
            fk8_2 = Db_FK_8MBJXLZZ.Value;
            fk8_3 = Db_FK_8LBMBZZ.Value;
            fk8_4 = Db_FK_8MBJZJZZ.Value;
            fk8_5 = Db_FK_8XJHNTZZ.Value;
            fk8_6 = Db_FK_8GJZZ.Value;
            //可变荷载
            fk8_7 = Cbx_FK_8JSJYT.Text;
            fk8_8 = Db_FK_8MBXLJB.Value;
            fk8_9 = Db_FK_8MBXLJZ.Value;
            fk8_10 = Db_FK_8ZLJB.Value;
            fk8_11 = Db_FK_8LGJB.Value;

            #region 一、面板验算
            double sum1I, sum1W, sum1G1k, sum1G2k, sum1G3k, sum1Gk, sum1Q1k, sum1P, sum1q, sum1q11, sum1q22, sum1q1, sum1P1, sum1q2, sum1P2, sum1M, sum1MA, sum1MB1, sum1MB2, sum1σ, sum1ν, sum1ν2;
            string compare1_1, compare1_2;

            sum1I = 1000 / 12 * fk2_3 * fk2_3 * fk2_3;//面板截面惯性矩I
            sum1W = 1000 / 6 * fk2_3 * fk2_3;//面板截面抵抗矩W
            sum1G1k = fk8_1 * 1.000;//模板自重标准值G1k
            sum1G2k = fk8_5 * 1.00 * fk1_2;//新浇筑砼自重标准值G2k
            sum1G3k = fk8_6 * 1.00 * fk1_2;//钢筋自重标准值G3k
            sum1Gk = sum1G1k + sum1G2k + sum1G3k;//永久荷载标准值Gk
            sum1Q1k = fk8_8 * 1.00;//施工人员及设备荷载标准值Q1k
            sum1P = fk8_9 * 1.00;//计算模板面板时用集中活荷载进行验算P
            sum1q11 = 0.9 * ((1.2 * sum1Gk) + (1.4 * sum1Q1k));//可变荷载效应控制的组合
            sum1q22 = 0.9 * ((1.35 * sum1Gk) + (1.4 * 0.7 * sum1Q1k));//永久荷载效应控制的组合
            /*
            if (sum1q11 > sum1q22)
                sum1q = sum1q11;
            else
                sum1q = sum1q22;
            */
            sum1q = sum1q11 > sum1q22 ? sum1q11 : sum1q22;
            sum1q1 = 0.9 * 1.2 * sum1Gk;
            sum1P1 = 0.9 * 1.4 * sum1P;
            sum1q2 = 0.9 * 1.35 * sum1Gk;
            sum1P2 = 0.9 * 1.4 * 0.7 * sum1P;
            sum1MA = 0.125 * sum1q * fk1_12 * fk1_12 / 1000 / 1000;
            sum1MB1 = (0.125 * sum1q1 * fk1_12 * fk1_12 / 1000 / 1000) + (0.25 * sum1P1 * fk1_12 / 1000);
            sum1MB2 = (0.125 * sum1q2 * fk1_12 * fk1_12 / 1000 / 1000) + (0.25 * sum1P2 * fk1_12 / 1000);
            if (sum1MA > sum1MB1)
            {
                if (sum1MA > sum1MB2)
                    sum1M = sum1MA;
                else
                    sum1M = sum1MB2;
            }
            else
            {
                if (sum1MB1 > sum1MB2)
                    sum1M = sum1MB1;
                else
                    sum1M = sum1MB2;
            }
            sum1σ = sum1M / sum1W;
            sum1σ = Math.Round(sum1σ, 4);
            if (sum1σ <= fk2_4)
                compare1_1 = "面板的计算强度" + sum1σ + "小于等于面板抗弯强度设计值" + fk2_4 + "N/mm2,满足要求!";
            else
                compare1_1 = "面板的计算强度" + sum1σ + "大于面板抗弯强度设计值" + fk2_4 + "N/mm2,不满足要求!";
            sum1ν = 5 * sum1Gk * fk1_12 * fk1_12 * fk1_12 * fk1_12 / (384 * fk2_5 * sum1I);
            sum1ν2 = Math.Floor(fk1_12 / 250) < 10 ? Math.Floor(fk1_12 / 250) : 10;
            sum1ν = Math.Round(sum1ν, 2);
            if (sum1ν <= sum1ν2)
                compare1_2 = "面板的挠度" + sum1ν + "小于等于面板最大允许挠度值" + sum1ν2 + "mm,满足要求!";
            else
                compare1_2 = "面板的挠度" + sum1ν + "大于面板最大允许挠度值" + sum1ν2 + "mm,不满足要求!";

            sum1M = Math.Round(sum1M, 2);
            sum1MA = Math.Round(sum1MA, 2);
            sum1MB1 = Math.Round(sum1MB1, 2);
            sum1MB2 = Math.Round(sum1MB2, 2);           
            sum1q22 = Math.Round(sum1q22, 2);
            sum1q11 = Math.Round(sum1q11, 2);
            sum1q = Math.Round(sum1q, 2);
            sum1q1 = Math.Round(sum1q1, 2);
            sum1q2 = Math.Round(sum1q2, 2);
            sum1P2 = Math.Round(sum1P2, 2);
            
            #endregion

            #region 二、小梁验算
            double sum2n, sum2min, sum2max, sum2G1k, sum2G2k, sum2G3k, sum2Gk, sum2Q1k, sum2P, sum2qa11, sum2qa12, sum2qa21, sum2qa22, sum2q1, sum2P1, sum2q2, sum2P2, sum2MA1, sum2MA2, sum2MB1, sum2MB2, sum2M, sum2σ,
                sum2VA1, sum2VA2, sum2VB1, sum2VB2, sum2V, sum2τ, sum2q, sum2kzν, sum2kzν2, sum2xbdν, sum2xbdν2;
            string compare2_1, compare2_2, compare2_3, compare2_4, str2_τ;

            sum2n = Math.Floor(fk1_4 / fk1_6);
            sum2min = sum2n < 5 ? sum2n : 5;
            sum2max = fk1_13 > fk1_13_2 ? fk1_13 : fk1_13_2;//小梁较大悬挑长度
            sum2G1k = fk8_2 * fk1_12 / 1000;//面板及小梁自重标准值G1k
            sum2G2k = fk8_5 * fk1_12 / 1000 * fk1_2 / 1000;//新浇筑砼自重标准值G2k
            sum2G3k = fk8_6 * fk1_12 / 1000 * fk1_2 / 1000;//钢筋自重标准值G3k
            sum2Gk = sum2G1k + sum2G2k + sum2G3k;//永久荷载标准值Gk
            sum2Q1k = fk8_8 * fk1_12 / 1000;//施工人员及设备荷载标准值Q1k
            sum2P = fk8_9;//计算模板面板时用集中活荷载进行验算P
            sum2qa11 = 0.9 * 1.2 * sum2Gk;
            sum2qa12 = 0.9 * 1.4 * sum2Q1k;
            sum2qa21 = 0.9 * 1.35 * sum2Gk;
            sum2qa22 = 0.9 * 1.4 * 0.7 * sum2Q1k;
            sum2q1 = 0.9 * 1.2 * sum2Gk;
            sum2P1 = 0.9 * 1.4 * sum2P;
            sum2q2 = 0.9 * 1.35 * sum2Gk;
            sum2P2 = 0.9 * 1.4 * 0.7 * sum2P;
            sum2MA1 = 0.078 * sum2qa11 * fk1_7 * fk1_7 + 0.1 * sum2qa12 * fk1_7 * fk1_7;
            sum2MA2 = 0.078 * sum2qa21 * fk1_7 * fk1_7 + 0.1 * sum2qa22 * fk1_7 * fk1_7;
            sum2MB1 = 0.078 * sum2q1 * fk1_7 * fk1_7 + 0.2 * sum2P1 * fk1_7;
            sum2MB2 = 0.078 * sum2q2 * fk1_7 * fk1_7 + 0.2 * sum2P2 * fk1_7;
            double[] sum2M_array = new double[] { sum2MA1, sum2MA2, sum2MB1, sum2MB2 };
            Array.Sort(sum2M_array);
            sum2M = sum2M_array[3];//小梁的最大弯矩M
            sum2σ = sum2M * 1000000 / fk3_9 / 1000;
            sum2σ = Math.Round(sum2σ, 2);
            if (sum2σ <= fk3_5)
                compare2_1 = "小梁的计算强度" + sum2σ + "小于等于小梁抗弯强度设计值" + fk3_5 + "N/mm2,满足要求!";
            else
                compare2_1 = "小梁的计算强度" + sum2σ + "大于小梁抗弯强度设计值" + fk3_5 + "N/mm2,不满足要求!";
            sum2VA1 = 0.606 * sum2qa11 * fk1_7 + 0.620 * sum2qa12 * fk1_7;
            sum2VA2 = 0.606 * sum2qa21 * fk1_7 + 0.620 * sum2qa22 * fk1_7;
            sum2VB1 = 0.606 * sum2q1 * fk1_7 + 0.679 * sum2P1;
            sum2VB2 = 0.606 * sum2q2 * fk1_7 + 0.679 * sum2P2;
            double[] sum2V_array = new double[] { sum2VA1, sum2VA2, sum2VB1, sum2VB2 };
            Array.Sort(sum2V_array);
            sum2V = sum2V_array[3];
            if (Cb_FK_3XLCZ.SelectedIndex == 0)//小梁选择 方木时
            {
                sum2τ = sum2V * 1000 / fk3_3 / fk3_4;
                sum2τ = Math.Round(sum2τ, 2);
                str2_τ = "τ =V/bh0=小梁的最大剪力/方木宽/方木高=" + sum2τ + "N/mm2";
            }
            else//小梁选择 工字钢、槽钢、方钢管、钢管时
            {
                sum2τ = sum2V * 1000 * fk3_10 * 1000 / fk3_8 / 10000 / 7.6;
                sum2τ = Math.Round(sum2τ, 2);
                str2_τ = "τ =VS0/Itw=小梁的最大剪力×小梁截面面积矩/37.13/小梁厚度=" + sum2τ + "N/mm2";
            }          
            if (sum2τ <= fk3_6)
            {
                compare2_2 = "小梁的计算强度" + sum2τ + "小于等于小梁抗剪强度设计值" + fk3_6 + "N/mm2,满足要求!";
            }
            else
            {
                compare2_2 = "小梁的计算强度" + sum2τ + "大于小梁抗剪强度设计值" + fk3_6 + "N/mm2,不满足要求!";
            }
            sum2q = sum2Gk;
            sum2kzν = 0.632 * sum2q * Math.Pow(fk1_7 * 1000, 4) / (100 * fk3_7 * fk3_8);
            sum2kzν2 = fk1_7 * 1000 / 400;
            sum2kzν = Math.Round(sum2kzν, 2);
            sum2kzν2 = Math.Round(sum2kzν2, 2);
            if (sum2kzν <= sum2kzν2)
            {
                compare2_3 = "小梁跨中的挠度" + sum2kzν + "小于等于小梁跨中的最大允许挠度值" + sum2kzν2 + "mm,满足要求!";
            }
            else
            {
                compare2_3 = "小梁跨中的挠度" + sum2kzν + "大于小梁跨中的最大允许挠度值" + sum2kzν2 + "mm,不满足要求!";
            }
            sum2xbdν = sum2q * Math.Pow(sum2max, 4) / (8 * fk3_7 * fk3_8);
            sum2xbdν2 = sum2max / 400;
            sum2xbdν = Math.Round(sum2xbdν, 2);
            sum2xbdν2 = Math.Round(sum2xbdν2, 2);
            if (sum2xbdν <= sum2xbdν2)
            {
                compare2_4 = "小梁悬臂端的挠度" + sum2xbdν + "小于等于小梁悬臂端的最大允许挠度值" + sum2xbdν2 + "mm,满足要求!";
            }
            else
            {
                compare2_4 = "小梁悬臂端的挠度" + sum2xbdν + "大于小梁悬臂端的最大允许挠度值" + sum2xbdν2 + "mm,不满足要求!";
            }

            sum2G1k = Math.Round(sum2G1k, 2);
            sum2G2k = Math.Round(sum2G2k, 2);
            sum2G3k = Math.Round(sum2G3k, 2);
            sum2Gk = Math.Round(sum2Gk, 2);
            sum2qa11 = Math.Round(sum2qa11, 2);
            sum2qa12 = Math.Round(sum2qa12, 2);
            sum2qa21 = Math.Round(sum2qa21, 2);
            sum2qa22 = Math.Round(sum2qa22, 2);
            sum2q1 = Math.Round(sum2q1, 2);
            sum2q2 = Math.Round(sum2q2, 2);
            sum2q = Math.Round(sum2q, 2);
            sum2M = Math.Round(sum2M, 2);
            sum2MA1 = Math.Round(sum2MA1, 2);
            sum2MA2 = Math.Round(sum2MA2, 2);
            sum2MB1 = Math.Round(sum2MB1, 2);
            sum2MB2 = Math.Round(sum2MB2, 2);            
            sum2VA1 = Math.Round(sum2VA1, 2);
            sum2VA2 = Math.Round(sum2VA2, 2);
            sum2VB1 = Math.Round(sum2VB1, 2);
            sum2VB2 = Math.Round(sum2VB2, 2);
            sum2V = Math.Round(sum2V, 2);              

            #endregion

            #region 三、主梁验算
            double sum3G1k, sum3G2k, sum3G3k, sum3Gk, sum3Q1k, sum3q11, sum3q12, sum3q21, sum3q22, sum3F1, sum3F2, sum3FA, sum3FB, sum3q1, sum3q2, sum3n, sum3min, sum3M,
                sum3V, sum3ν, sum3σ, sum3τ, sum3ν2;
            string compare3_1, compare3_2, compare3_3, str3_τ;

            sum3G1k = fk8_2 * fk1_12 / 1000; //面板及小梁自重标准值G1k
            sum3G2k = fk8_5 * fk1_12 / 1000 * fk1_2 / 1000; //新浇筑砼自重标准值G2k
            sum3G3k = fk8_6 * fk1_12 / 1000 * fk1_2 / 1000;//钢筋自重标准值G3k
            sum3Gk = sum3G1k + sum3G2k + sum3G3k;//永久荷载标准值Gk
            sum3Q1k = fk8_10 * fk1_7;//施工人员及设备荷载标准值Q1k
            sum3q11 = 0.9 * 1.2 * sum3Gk;
            sum3q12 = 0.9 * 1.4 * sum3Q1k;
            sum3q21 = 0.9 * 1.35 * sum3Gk;
            sum3q22 = 0.9 * 1.4 * 0.7 * sum3Q1k;
            sum3F1 = 1.132 * sum3q11 * fk1_6 + 1.218 * sum3q12 * fk1_6;
            sum3F2 = 1.132 * sum3q21 * fk1_6 + 1.218 * sum3q22 * fk1_6;
            sum3FA = sum3F1 > sum3F2 ? sum3F1 : sum3F2;
            sum3FB = 1.100 * sum3Gk * fk1_6;
            sum3q1 = 1.4 * fk8_3 * 0.1;
            sum3q2 = fk8_3 * 0.1;
            sum3n = Math.Floor(fk1_3 / fk1_6);
            sum3min = sum3n < 5 ? sum3n : 5;
            sum3M = 0.078 * sum3q1 * fk1_6 * fk1_6 + 0.24 * sum3FA * fk1_6;//最大弯矩M
            sum3V = 0.606 * sum3q1 * fk1_6 + 1.281 * sum3FA;//最大剪力V
            sum3ν = 0.632 * sum3q2 * Math.Pow(fk1_6 * 1000, 4) / (100 * fk4_7 * fk4_8) + 6.81 * sum3FB * Math.Pow(fk1_6 * 1000, 3) / (384 * fk4_7 * fk4_8);//最大变形ν
            sum3σ = sum3M * 1000000 / fk4_9 / 1000;//抗弯强度σ
            sum3σ = Math.Round(sum3σ, 2);
            if (sum3σ <= fk4_5)
            {
                compare3_1 = "主梁的计算强度" + sum3σ + "小于等于主梁抗弯强度设计值" + fk4_5 + "N/mm2,满足要求!";
            }
            else
            {
                compare3_1 = "主梁的计算强度" + sum3σ + "大于主梁抗弯强度设计值" + fk4_5 + "N/mm2,不满足要求!";
            }
            if (Cb_FK_4ZLCZ.SelectedIndex == 0)//主梁选择 方木时
            {
                sum3τ = sum3V * 1000 / fk4_3 / fk4_4;
                sum3τ = Math.Round(sum3τ, 2);
                str3_τ = "τ =V/bh0=主梁的最大剪力/方木宽/方木高=" + sum3τ + "N/mm2";
            }
            else//主梁选择 工字钢、槽钢、方钢管、钢管时
            {
                sum3τ = sum3V * 1000 * fk4_10 * 1000 / fk4_8 / 10000 / 7.6;//主梁厚度未知
                sum3τ = Math.Round(sum3τ, 2);
                str3_τ = "τ =VS0/Itw=主梁的最大剪力×主梁截面面积矩/37.13/主梁厚度=" + sum3τ + "N/mm2";
            }
            if(sum3τ<=fk4_6)
            {
                compare3_2 = "主梁的计算强度" + sum3τ + "小于等于主梁抗剪强度设计值" + fk4_6 + "N/mm2,满足要求!";
            }
            else
            {
                compare3_2 = "主梁的计算强度" + sum3τ + "大于主梁抗剪强度设计值" + fk4_6 + "N/mm2,不满足要求!";
            }
            sum3ν2 = fk1_6 / 400;
            sum3ν = Math.Round(sum3ν, 2);
            if(sum3ν<=sum3ν2)
            {
                compare3_3 = "主梁跨中的挠度" + sum3ν + "小于等于主梁跨中的最大允许挠度值" + sum3ν2 + "mm,满足要求!";
            }
            else
            {
                compare3_3 = "主梁跨中的挠度" + sum3ν + "大于主梁跨中的最大允许挠度值" + sum3ν2 + "mm,不满足要求!";
            }

            sum3G1k = Math.Round(sum3G1k, 2);
            sum3G2k = Math.Round(sum3G2k, 2);
            sum3G3k = Math.Round(sum3G3k, 2);
            sum3F1 = Math.Round(sum3F1, 2);
            sum3F2 = Math.Round(sum3F2, 2);
            sum3M = Math.Round(sum3M, 2);
            sum3V = Math.Round(sum3V, 2);
            sum3ν = Math.Round(sum3ν, 2);
            sum3Gk = Math.Round(sum3Gk, 2);
            sum3q11 = Math.Round(sum3q11, 2);
            sum3q12 = Math.Round(sum3q12, 2);
            sum3q21 = Math.Round(sum3q21, 2);
            sum3q22 = Math.Round(sum3q22, 2);
            sum3FA = Math.Round(sum3FA, 2);
            sum3FB = Math.Round(sum3FB, 2);
            
            #endregion

            #region 四、立杆稳定性验算
            double sum4_1λ,sum4_1λ2,sum4_1φ,sum4_1G1k,sum4_1G2k,sum4_1G3k,sum4_1Gk,sum4_1Qk,sum4_1N,sum4_1NEX,sum4_1Mx,sum4_1f,sum4_1f2,
                sum4_2λ,sum4_2λ2,sum4_2φ,sum4_2G1k,sum4_2G2k,sum4_2G3k,sum4_2Gk,sum4_2Qk,sum4_2N,sum4_2f,sum4_2f2;
            string compare4_1, compare4_2, compare4_3, compare4_4;

            sum4_1λ = Math.Pow((1 + fk5_9 / fk5_8), 0.5) * fk1_5 * 1000 / fk5_5;//立柱长细比λ
            sum4_1λ2 = 150;//Math.Floor(sum4_1λ);//立杆最大允许长细比[λ]
            sum4_1λ = Math.Round(sum4_1λ, 2);
            sum4_1λ2 = Math.Round(sum4_1λ2, 2);
            if(sum4_1λ<sum4_1λ2)
                compare4_1 = "立柱长细比" + sum4_1λ + "小于等于立柱最大允许长细比" + sum4_1λ2 + "mm,满足要求!";
            else
                compare4_1 = "立柱长细比" + sum4_1λ + "大于立柱最大允许长细比" + sum4_1λ2 + "mm,不满足要求!";
            //sum4_1φ = 0;//稳定系数φ查表A.0.6得到
            /*
            if (sum4_1λ > 250)
            {
                sum4_1φ = 7320 / (sum4_1λ * sum4_1λ);
            }
            else
            {
                int sum4_1λy1 = Convert.ToInt32(sum4_1λ / 10);//第λy1行
                int sum4_1λx1 = Convert.ToInt32(sum4_1λ % 10);// 第λx1列
                sum4_1φ = λArray[sum4_1λy1, sum4_1λx1]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
            }
            */
            if (sum4_1λ > 250)
            {
                sum4_1φ = 7320 / sum4_1λ / sum4_1λ;
            }
            else if (Math.Floor(sum4_1λ) == sum4_1λ)
            {
                int sum4_1λy = Convert.ToInt32(sum4_1λ / 10);//第λy1行
                int sum4_1λx = Convert.ToInt32(sum4_1λ % 10);// 第λx1列
                sum4_1φ = λArray[sum4_1λy, sum4_1λx]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
            }
            else
            {
                double sum4_1λ_1, sum4_1λ_2, sum4_1φ1, sum4_1φ2;
                sum4_1λ_1 = Math.Ceiling(sum4_1λ);//x1
                sum4_1λ_2 = Math.Floor(sum4_1λ);//x0

                int sum4_1λy1 = Convert.ToInt32(sum4_1λ_1 / 10);
                int sum4_1λx1 = Convert.ToInt32(sum4_1λ_1 % 10);
                sum4_1φ1 = λArray[sum4_1λy1, sum4_1λx1]; //y1

                int sum4_1λy2 = Convert.ToInt32(sum4_1λ_2 / 10);
                int sum4_1λx2 = Convert.ToInt32(sum4_1λ_2 % 10);
                sum4_1φ2 = λArray[sum4_1λy2, sum4_1λx2]; //y0

                sum4_1φ = (sum4_1λ - sum4_1λ_1) / (sum4_1λ_2 - sum4_1λ_1) * sum4_1φ2 + (sum4_1λ - sum4_1λ_2) / (sum4_1λ_1 - sum4_1λ_2) * sum4_1φ1;//拉格朗日插值
            }

            sum4_1G1k = fk8_4 * fk1_6 * fk1_7;//模板及其支架自重标准值G1k
            sum4_1G2k = fk8_5 * fk1_6 * fk1_7 * fk1_2 / 1000;//新浇筑砼自重标准值G2k
            sum4_1G3k = fk8_6 * fk1_6 * fk1_7 * fk1_2 / 1000;//钢筋自重标准值G3k
            sum4_1Gk = sum4_1G1k + sum4_1G2k + sum4_1G3k;//永久荷载标准值Gk
            sum4_1Qk = fk8_11 * fk1_6 * fk1_7;//施工人员及设备荷载标准值Qk
            sum4_1N = 1.2 * sum4_1Gk + 0.9 * 1.4 * sum4_1Qk;
            sum4_1NEX = Math.PI * Math.PI * 206000 * fk5_6 / sum4_1λ / sum4_1λ;//截面模量206000!!!!!!!!
            sum4_1Mx = sum4_1N * 1000 * 48 / 2;//插管外径48!!!!!!!!!
            sum4_1f = sum4_1N * 1000 / (sum4_1φ * fk5_6) + 1 * sum4_1Mx / (fk5_10 * (1 - 0.8 * sum4_1N * 1000 / sum4_1NEX));
            sum4_1f2 = fk5_3;
            sum4_1f = Math.Round(sum4_1f, 2);
            if(sum4_1f<=sum4_1f2)
                compare4_2 = "立柱抗压强度" + sum4_1f + "小于等于立柱抗压强度设计值" + sum4_1f2 + "N/mm2,满足要求!";
            else
                compare4_2 = "立柱抗压强度" + sum4_1f + "大于立柱抗压强度设计值" + sum4_1f2 + "N/mm2,不满足要求!";
            sum4_2λ = fk1_5 / fk5_4 * 1000;
            sum4_2λ2 = 250;
            sum4_2λ = Math.Round(sum4_2λ, 2);
           // sum4_2f = Math.Round(sum4_2f, 2);
            if (sum4_2λ < sum4_2λ2)
                compare4_3 = "立柱长细比" + sum4_2λ + "小于等于立柱最大允许长细比" + sum4_2λ2 + "mm,满足要求!";
            else
                compare4_3 = "立柱长细比" + sum4_2λ + "大于立柱最大允许长细比" + sum4_2λ2 + "mm,不满足要求!";

            /*
            sum4_2λ = Math.Floor(sum4_2λ);
            if (sum4_2λ > 250)
            {
                sum4_2φ = 7320 / (sum4_2λ * sum4_2λ);
            }
            else
            {
                int sum4_2λy1 = Convert.ToInt32(sum4_2λ / 10);//第λy1行
                int sum4_2λx1 = Convert.ToInt32(sum4_2λ % 10);// 第λx1列
                sum4_2φ = λArray[sum4_2λy1, sum4_2λx1]; //λArray数组为全局变量,参见“表A.0.6轴心受压构件的稳定系数Φ(Q235钢)”
            }
             */
            if (sum4_2λ > 250)
            {
                sum4_2φ = 7320 / sum4_2λ / sum4_2λ;
            }
            else if (Math.Floor(sum4_2λ) == sum4_2λ)
            {
                int sum4_2λy = Convert.ToInt32(sum4_2λ / 10);//第λy1行
                int sum4_2λx = Convert.ToInt32(sum4_2λ % 10);// 第λx1列
                sum4_2φ = λArray[sum4_2λy, sum4_2λx]; //λArray数组为全局变量,参见“表B.0.6轴心受压构件的稳定系数Φ(Q235钢)”
            }
            else
            {
                double sum4_2λ_1, sum4_2λ_2, sum4_2φ1, sum4_2φ2;
                sum4_2λ_1 = Math.Ceiling(sum4_2λ);//x1
                sum4_2λ_2 = Math.Floor(sum4_2λ);//x0

                int sum4_2λy1 = Convert.ToInt32(sum4_2λ_1 / 10);
                int sum4_2λx1 = Convert.ToInt32(sum4_2λ_1 % 10);
                sum4_2φ1 = λArray[sum4_2λy1, sum4_2λx1]; //y1

                int sum4_2λy2 = Convert.ToInt32(sum4_2λ_2 / 10);
                int sum4_2λx2 = Convert.ToInt32(sum4_2λ_2 % 10);
                sum4_2φ2 = λArray[sum4_2λy2, sum4_2λx2]; //y0

                sum4_2φ = (sum4_2λ - sum4_2λ_1) / (sum4_2λ_2 - sum4_2λ_1) * sum4_2φ2 + (sum4_2λ - sum4_2λ_2) / (sum4_2λ_1 - sum4_2λ_2) * sum4_2φ1;//拉格朗日插值
            }

            sum4_2G1k = fk8_4 * fk1_6 * fk1_7;//模板及其支架自重标准值G1k
            sum4_2G2k = fk8_5 * fk1_6 * fk1_7 * fk1_2 / 1000;//新浇筑砼自重标准值G2k
            sum4_2G3k = fk8_6 * fk1_6 * fk1_7 * fk1_2 / 1000;//钢筋自重标准值G3k
            sum4_2Gk = sum4_2G1k + sum4_2G2k + sum4_2G3k;//永久荷载标准值Gk
            sum4_2Qk = fk8_11 * fk1_6 * fk1_7;//施工人员及设备荷载标准值Qk
            sum4_2N = 1.2 * sum4_1Gk + 0.9 * 1.4 * sum4_1Qk;
            sum4_2f = sum4_2N * 1000 / (sum4_2φ * fk5_6);
            sum4_2f2 = fk5_3;
            sum4_2f = Math.Round(sum4_2f, 2);
            if (sum4_2f <= sum4_2f2)
            {
                compare4_4 = "立柱抗压强度" + sum4_2f + "小于等于立柱抗压强度设计值" + sum4_2f2 + "N/mm2,满足要求!";
            }
            else
            {
                compare4_4 = "立柱抗压强度" + sum4_2f + "大于立柱抗压强度设计值" + sum4_2f2 + "N/mm2,不满足要求!";
            }
            sum4_1G1k = Math.Round(sum4_1G1k, 2);
            sum4_1G2k = Math.Round(sum4_1G2k, 2);
            sum4_1G3k = Math.Round(sum4_1G3k, 2);
            sum4_1Gk = Math.Round(sum4_1Gk, 2);
            sum4_1N = Math.Round(sum4_1N, 2);
            sum4_1Mx = Math.Round(sum4_1Mx, 2);
            sum4_1NEX = Math.Round(sum4_1NEX, 2);
            sum4_1φ = Math.Round(sum4_1φ, 2);
            sum4_2φ = Math.Round(sum4_2φ, 2);
            sum4_2G1k = Math.Round(sum4_2G1k, 2);
            sum4_2G2k = Math.Round(sum4_2G2k, 2);
            sum4_2G3k = Math.Round(sum4_2G3k, 2);
            sum4_2Gk = Math.Round(sum4_2Gk, 2);
            sum4_2Qk = Math.Round(sum4_2Qk, 2);
            sum4_2N = Math.Round(sum4_2N, 2);

            #endregion

            #region 五、插销验算
            double sum5G1k, sum5G2k, sum5G3k, sum5Gk, sum5Qk, sum5N, sum5f, sum5fvb, sum5f2, sum5fcb;
            string compare5_1, compare5_2;

            sum5G1k = fk8_4 * fk1_6 * fk1_7;//模板及其支架自重标准值G1k
            sum5G2k = fk8_5 * fk1_6 * fk1_7 * fk1_2 / 1000;//新浇筑砼自重标准值G2k
            sum5G3k = fk8_6 * fk1_6 * fk1_7 * fk1_2 / 1000;//钢筋自重标准值G3k
            sum5Gk = sum5G1k + sum5G2k + sum5G3k;//永久荷载标准值Gk
            sum5Qk = fk8_11 * fk1_6 * fk1_7;//施工人员及设备荷载标准值Qk
            sum5N = 1.2 * sum5Gk + 0.9 * 1.4 * sum5Qk;
            sum5f = 1000 * sum5N / (2 * fk5_15);
            sum5fvb = 140;
            sum5f = Math.Round(sum5f, 2);
            if (sum5f <= sum5fvb)
                compare5_1 = "钢插销抗剪强度" + sum5f + "小于等于钢插销抗剪强度设计值" + sum5fvb + "N/mm2,满足要求!";
            else
                compare5_1 = "钢插销抗剪强度" + sum5f + "大于钢插销抗剪强度设计值" + sum5fvb + "N/mm2,不满足要求!";
            sum5f2 = 1000 * sum5N / (2 * fk5_14 * fk5_13);
            sum5fcb = 290;
            sum5f2 = Math.Round(sum5f2, 2);
            if (sum5f2 <= sum5fcb)
                compare5_2 = "插销孔处管壁端承压强度" + sum5f2 + "小于等于插销孔处管壁端承压强度设计值" + sum5fcb + "N/mm2,满足要求!";
            else
                compare5_2 = "插销孔处管壁端承压强度" + sum5f2 + "大于插销孔处管壁端承压强度设计值" + sum5fcb + "N/mm2,不满足要求!";

            sum5G1k = Math.Round(sum5G1k, 2);
            sum5G2k = Math.Round(sum5G2k, 2);
            sum5G3k = Math.Round(sum5G3k, 2);
            sum5Gk = Math.Round(sum5Gk, 2);
            sum5N = Math.Round(sum5N, 2);
            
            #endregion

            #region 六、可调托座验算
            double sum6N;
            string compare6_1;
            sum6N = sum5N / fk7_1;
            sum6N = Math.Round(sum6N, 2);
            if (sum6N <= fk7_2)
                compare6_1 = "可调托座受力" + sum6N + "小于等于可调托座承载力容许值" + fk7_2 + "kN,满足要求!";
            else
                compare6_1 = "可调托座受力" + sum6N + "大于可调托座承载力容许值" + fk7_2 + "kN,不满足要求!";
            #endregion

            #region 七、立柱地基基础验算
            double sum7N, sum7p;
            string compare7;
            sum7N = sum5N;//上部立柱传至垫木顶面的轴向力设计值N
            sum7p = sum7N / (fk7_6 * fk7_7 * fk7_1);//立柱底垫板的底面平均压力p
            sum7p = Math.Round(sum7p, 2);
            if (sum7p <= fk7_5)
                compare7 = "立柱底垫板的底面平均压力" + sum7p + "小于等于地基土承载力设计值" + fk7_5 + "N/mm2,满足要求!";
            else
                compare7 = "立柱底垫板的底面平均压力" + sum7p + "大于地基土承载力设计值" + fk7_5 + "N/mm2,不满足要求!";

            

            #endregion

            obj = new object[] { fk1_1, fk1_2, fk1_3, fk1_4, fk1_5, fk1_6, fk1_7, fk1_8,fk1_9, fk1_10, fk1_11,fk1_12, fk1_13, fk1_13_2, fk1_14, fk2_1, fk2_2,
                fk2_3, fk2_4, fk2_5,fk3_1, fk3_2,fk3_3, fk3_4, fk3_5, fk3_6, fk3_7, fk3_8, fk3_9,fk3_10,fk4_1, fk4_2, fk4_3, fk4_4, fk4_5, fk4_6, fk4_7, fk4_8,
                fk4_9, fk4_10,fk5_1,fk5_2, fk5_3, fk5_4, fk5_5, fk5_6, fk5_7, fk5_8, fk5_9, fk5_10, fk5_11, fk5_12, fk5_13, fk5_14, fk5_15, fk5_16, fk5_17,
                fk7_1, fk7_2,fk7_3, fk7_4,fk7_5, fk7_6, fk7_7,fk8_1, fk8_2, fk8_3, fk8_4, fk8_5, fk8_6,fk8_7,fk8_8, fk8_9, fk8_10, fk8_11,sum1I, sum1W, sum1G1k,
                sum1G2k, sum1G3k, sum1Gk, sum1Q1k, sum1P, sum1q, sum1q11, sum1q22, sum1q1, sum1P1, sum1q2, sum1P2, sum1M, sum1MA, sum1MB1, sum1MB2, sum1σ, sum1ν,
                sum1ν2,compare1_1, compare1_2,sum2n, sum2min, sum2max, sum2G1k, sum2G2k, sum2G3k, sum2Gk, sum2Q1k, sum2P, sum2qa11, sum2qa12, sum2qa21, sum2qa22, sum2q1, sum2P1, sum2q2, sum2P2, sum2MA1, sum2MA2, sum2MB1, sum2MB2, sum2M, sum2σ,
                sum2VA1, sum2VA2, sum2VB1, sum2VB2, sum2V, sum2τ, sum2q, sum2kzν, sum2kzν2, sum2xbdν, sum2xbdν2,compare2_1, compare2_2, compare2_3, compare2_4,sum3G1k, sum3G2k, sum3G3k, sum3Gk, sum3Q1k, sum3q11, sum3q12, sum3q21, sum3q22, sum3F1, sum3F2, sum3FA, sum3FB, sum3q1, sum3q2, sum3n, sum3min, sum3M,
                sum3V, sum3ν, sum3σ, sum3τ, sum3ν2,compare3_1, compare3_2, compare3_3,sum4_1λ,sum4_1λ2,sum4_1φ,sum4_1G1k,sum4_1G2k,sum4_1G3k,sum4_1Gk,sum4_1Qk,sum4_1N,sum4_1NEX,sum4_1Mx,sum4_1f,sum4_1f2,
                sum4_2λ,sum4_2λ2,sum4_2φ,sum4_2G1k,sum4_2G2k,sum4_2G3k,sum4_2Gk,sum4_2Qk,sum4_2N,sum4_2f,sum4_2f2,compare4_1, compare4_2, compare4_3, compare4_4,
                sum5G1k, sum5G2k, sum5G3k, sum5Gk, sum5Qk, sum5N, sum5f, sum5fvb, sum5f2, sum5fcb,compare5_1, compare5_2,sum6N,compare6_1,sum7N, sum7p,compare7,str2_τ,str3_τ};


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

        private void Cb_FK_5LZXH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FK_5LZXH.SelectedIndex == 0 | Cb_FK_5LZXH.SelectedIndex == 1 | Cb_FK_5LZXH.SelectedIndex == 2)
            {
                if (Cb_FK_5LZXH.SelectedIndex == 0 | Cb_FK_5LZXH.SelectedIndex == 1)
                {
                    Tb_FK_5RXHZ.Text = "15"; 
                }
                else
                    Tb_FK_5RXHZ.Text = "12";
                
                Tb_FK_5CGHZBJ.Text = "16.4";
                Tb_FK_5TGHZBJ.Text = "20.6";
                Tb_FK_5CGJMMJ.Text = "348";
                Tb_FK_5TGJMMJ.Text = "438";
                Tb_FK_5CGGXJ.Text = "93200";
                Tb_FK_5TGGXJ.Text = "185100";
                Tb_FK_5CGDKJ.Text = "3831.29";
                Tb_FK_5TGDKJ.Text = "6130.18";
                Tb_FK_5CGBH.Text = "2.4";
                Tb_FK_5TGBH.Text = "2.4";
            }
            else if (Cb_FK_5LZXH.SelectedIndex == 3 | Cb_FK_5LZXH.SelectedIndex == 4 | Cb_FK_5LZXH.SelectedIndex == 5)
            {
                if (Cb_FK_5LZXH.SelectedIndex == 3 | Cb_FK_5LZXH.SelectedIndex == 4)
                {
                    Tb_FK_5RXHZ.Text = "15";
                }
                else
                    Tb_FK_5RXHZ.Text = "12";

                Tb_FK_5CGHZBJ.Text = "16.1";
                Tb_FK_5TGHZBJ.Text = "20.4";
                Tb_FK_5CGJMMJ.Text = "357";
                Tb_FK_5TGJMMJ.Text = "417";
                Tb_FK_5CGGXJ.Text = "92800";
                Tb_FK_5TGGXJ.Text = "173800";
                Tb_FK_5CGDKJ.Text = "3864.84";
                Tb_FK_5TGDKJ.Text = "5792.73";
                Tb_FK_5CGBH.Text = "2.5";
                Tb_FK_5TGBH.Text = "2.3";
            }
        }

        private void Cb_FK_7ZYWZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_FK_7ZYWZ.SelectedIndex == 1)
            {
                Cb_FK_7DJTLX.Enabled = Db_FK_7SJZ.Enabled = Cb_FK_7ZJXS.Enabled = Db_FK_7DMMJ.Enabled = false;
            }
            else
            {
                Cb_FK_7DJTLX.Enabled = Db_FK_7SJZ.Enabled = Cb_FK_7ZJXS.Enabled = Db_FK_7DMMJ.Enabled = true;
            }
        }

        private void Btn_FK_7SearchChart_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(Cb_FK_7DJTLX.SelectedIndex);
            showchart.ShowDialog();
        }

        private void Db_FK_LBCB_ValueChanged(object sender, EventArgs e)
        {
            double dbjl = (Db_FK_LBCB.Value - Db_FK_ZXJJ.Value * (Math.Floor(Db_FK_LBCB.Value / Db_FK_ZXJJ.Value))) / 2;
            Tb_FK_DBJL.Text = Convert.ToString(Math.Round(dbjl,2));
        }

        private void Db_FK_ZXJJ_ValueChanged(object sender, EventArgs e)
        {
            double dbjl = (Db_FK_LBCB.Value - Db_FK_ZXJJ.Value * (Math.Floor(Db_FK_LBCB.Value / Db_FK_ZXJJ.Value))) / 2;
            Tb_FK_DBJL.Text = Convert.ToString(Math.Round(dbjl, 2));
        }

        private void Db_FK_LBDB_ValueChanged(object sender, EventArgs e)
        {
            double cbjl = (Db_FK_LBDB.Value - Db_FK_HXJJ.Value * (Math.Floor(Db_FK_LBDB.Value / Db_FK_HXJJ.Value))) / 2;
            Tb_FK_CBJL.Text = Convert.ToString(Math.Round(cbjl,2));
        }

        private void Db_FK_HXJJ_ValueChanged(object sender, EventArgs e)
        {
            double cbjl = (Db_FK_LBDB.Value - Db_FK_HXJJ.Value * (Math.Floor(Db_FK_LBDB.Value / Db_FK_HXJJ.Value))) / 2;    
            Tb_FK_CBJL.Text = Convert.ToString(Math.Round(cbjl, 2));
        }

        private void Tb_FK_CBJL_TextChanged(object sender, EventArgs e)
        {
            Db_FK_XTCD.Value = System.Convert.ToDouble(Tb_FK_CBJL.Text);
        }

        private void Btn_FK_2SearchChart_Click(object sender, EventArgs e)
        {
            if (Cb_FK_2MBLX.SelectedIndex == 0)
            {
                FrmShowChart showchart = new FrmShowChart(11);
                showchart.ShowDialog();
            }
            else if (Cb_FK_2MBLX.SelectedIndex == 1)
            {
                FrmShowChart showchart = new FrmShowChart(10);
                showchart.ShowDialog();
            }
            else if (Cb_FK_2MBLX.SelectedIndex == 2)
            {
                FrmShowChart showchart = new FrmShowChart(12);
                showchart.ShowDialog();
            }
        }

        private void Cb_FK_5CXZJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cb_FK_5CXZJ.SelectedIndex)
            {
                case 0:
                    Tb_FK_5CXJMMJ.Text = "28.27";
                    break;
                case 1:
                    Tb_FK_5CXJMMJ.Text = "50.27";
                    break;
                case 2:
                    Tb_FK_5CXJMMJ.Text = "78.54";
                    break;
                case 3:
                    Tb_FK_5CXJMMJ.Text = "113.1";
                    break;
                case 4:
                    Tb_FK_5CXJMMJ.Text = "153.94";
                    break;
            }
        }

        private void Btn_FK_5SearchChart_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(13);
            showchart.ShowDialog();
        }

    }
}