using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmLEC : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;

        public FrmLEC(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);

            #region 构造参数初值
            cB_U1_a1L.SelectedIndex = 0;
            cB_U1_a1E.SelectedIndex = 1;
            cB_U1_a1C.SelectedIndex = 3;
            cB_U1_a2L.SelectedIndex = 0;
            cB_U1_a2E.SelectedIndex = 1;
            cB_U1_a2C.SelectedIndex = 3;
            cB_U1_a3L.SelectedIndex = 0;
            cB_U1_a3E.SelectedIndex = 1;
            cB_U1_a3C.SelectedIndex = 3;
            cB_U1_a4L.SelectedIndex = 0;
            cB_U1_a4E.SelectedIndex = 1;
            cB_U1_a4C.SelectedIndex = 1;
            cB_U1_a5L.SelectedIndex = 1;
            cB_U1_a5E.SelectedIndex = 1;
            cB_U1_a5C.SelectedIndex = 1;
            cB_U1_a6L.SelectedIndex = 2;
            cB_U1_a6E.SelectedIndex = 3;
            cB_U1_a6C.SelectedIndex = 2;
            cB_U1_a7L.SelectedIndex = 0;
            cB_U1_a7E.SelectedIndex = 1;
            cB_U1_a7C.SelectedIndex = 3;
            cB_U1_a8L.SelectedIndex = 1;
            cB_U1_a8E.SelectedIndex = 1;
            cB_U1_a8C.SelectedIndex = 3;
            cB_U1_a9L.SelectedIndex = 0;
            cB_U1_a9E.SelectedIndex = 3;
            cB_U1_a9C.SelectedIndex = 3;
            cB_U1_a10L.SelectedIndex = 1;
            cB_U1_a10E.SelectedIndex = 4;
            cB_U1_a10C.SelectedIndex = 3;

            cB_U2_a1L.SelectedIndex = 0;
            cB_U2_a1E.SelectedIndex = 1;
            cB_U2_a1C.SelectedIndex = 3;
            cB_U2_a2L.SelectedIndex = 1;
            cB_U2_a2E.SelectedIndex = 1;
            cB_U2_a2C.SelectedIndex = 3;
            cB_U2_a3L.SelectedIndex = 0;
            cB_U2_a3E.SelectedIndex = 1;
            cB_U2_a3C.SelectedIndex = 3;
            cB_U2_a4L.SelectedIndex = 0;
            cB_U2_a4E.SelectedIndex = 1;
            cB_U2_a4C.SelectedIndex = 3;
            cB_U2_a5L.SelectedIndex = 0;
            cB_U2_a5E.SelectedIndex = 1;
            cB_U2_a5C.SelectedIndex = 1;
            cB_U2_a6L.SelectedIndex = 1;
            cB_U2_a6E.SelectedIndex = 1;
            cB_U2_a6C.SelectedIndex = 3;
            cB_U2_a7L.SelectedIndex = 1;
            cB_U2_a7E.SelectedIndex = 1;
            cB_U2_a7C.SelectedIndex = 3;
            cB_U2_a8L.SelectedIndex = 0;
            cB_U2_a8E.SelectedIndex = 1;
            cB_U2_a8C.SelectedIndex = 1;

            cB_U3_a1L.SelectedIndex = 1;
            cB_U3_a1E.SelectedIndex = 1;
            cB_U3_a1C.SelectedIndex = 3;
            cB_U3_a2L.SelectedIndex = 2;
            cB_U3_a2E.SelectedIndex = 1;
            cB_U3_a2C.SelectedIndex = 3;
            cB_U3_a3L.SelectedIndex = 0;
            cB_U3_a3E.SelectedIndex = 1;
            cB_U3_a3C.SelectedIndex = 4;
            cB_U3_a4L.SelectedIndex = 0;
            cB_U3_a4E.SelectedIndex = 1;
            cB_U3_a4C.SelectedIndex = 3;

            cB_U4_a1L.SelectedIndex = 0;
            cB_U4_a1E.SelectedIndex = 1;
            cB_U4_a1C.SelectedIndex = 3;
            cB_U4_a2L.SelectedIndex = 1;
            cB_U4_a2E.SelectedIndex = 1;
            cB_U4_a2C.SelectedIndex = 3;

            cB_U5_a1L.SelectedIndex = 1;
            cB_U5_a1E.SelectedIndex = 1;
            cB_U5_a1C.SelectedIndex = 2;
            cB_U5_a2L.SelectedIndex = 1;
            cB_U5_a2E.SelectedIndex = 1;
            cB_U5_a2C.SelectedIndex = 3;
            cB_U5_a3L.SelectedIndex = 2;
            cB_U5_a3E.SelectedIndex = 4;
            cB_U5_a3C.SelectedIndex = 2;
            
            #endregion
        }

        private string level(double d) //判定风险等级
        {
            string str;
            if (d >= 320)
            {
                str = "1级";
            }
            else if(d<320&&d>160)
            {
                str = "2级";
            }
            else if (d < 160 && d > 70)
            {
                str = "3级";
            }
            else if (d < 70 && d > 20)
            {
                str = "4级";
            }
            else
            {
                str = "5级";
            }

            return str;
        }

        private void Btn_CESubmit_Click(object sender, EventArgs e)
        {
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "LEC";
            object[] obj = new object[] { };


            double[] LEC_L = new double[] { 10, 6, 3, 1, 0.5, 0.2, 0.1 };
            double[] LEC_E = new double[] { 10, 6, 3, 2, 1, 0.5 };
            double[] LEC_C = new double[] { 100, 40, 15, 7, 3, 1 };

            //高处坠落 U1
            double D1_1, D1_2, D1_3, D1_4, D1_5, D1_6, D1_7, D1_8, D1_9, D1_10;
            string S1_1, S1_2, S1_3, S1_4, S1_5, S1_6, S1_7, S1_8, S1_9, S1_10;

            double L1_1, L1_2, L1_3, L1_4, L1_5, L1_6, L1_7, L1_8, L1_9, L1_10,
                   E1_1, E1_2, E1_3, E1_4, E1_5, E1_6, E1_7, E1_8, E1_9, E1_10,
                   C1_1, C1_2, C1_3, C1_4, C1_5, C1_6, C1_7, C1_8, C1_9, C1_10;

            L1_1 = LEC_L[cB_U1_a1L.SelectedIndex];
            L1_2 = LEC_L[cB_U1_a2L.SelectedIndex];
            L1_3 = LEC_L[cB_U1_a3L.SelectedIndex];
            L1_4 = LEC_L[cB_U1_a4L.SelectedIndex];
            L1_5 = LEC_L[cB_U1_a5L.SelectedIndex];
            L1_6 = LEC_L[cB_U1_a6L.SelectedIndex];
            L1_7 = LEC_L[cB_U1_a7L.SelectedIndex];
            L1_8 = LEC_L[cB_U1_a8L.SelectedIndex];
            L1_9 = LEC_L[cB_U1_a9L.SelectedIndex];
            L1_10 = LEC_L[cB_U1_a10L.SelectedIndex];

            E1_1 = LEC_E[cB_U1_a1E.SelectedIndex];
            E1_2 = LEC_E[cB_U1_a2E.SelectedIndex];
            E1_3 = LEC_E[cB_U1_a3E.SelectedIndex];
            E1_4 = LEC_E[cB_U1_a4E.SelectedIndex];
            E1_5 = LEC_E[cB_U1_a5E.SelectedIndex];
            E1_6 = LEC_E[cB_U1_a6E.SelectedIndex];
            E1_7 = LEC_E[cB_U1_a7E.SelectedIndex];
            E1_8 = LEC_E[cB_U1_a8E.SelectedIndex];
            E1_9 = LEC_E[cB_U1_a9E.SelectedIndex];
            E1_10 = LEC_E[cB_U1_a10E.SelectedIndex];

            C1_1 = LEC_C[cB_U1_a1C.SelectedIndex];
            C1_2 = LEC_C[cB_U1_a2C.SelectedIndex];
            C1_3 = LEC_C[cB_U1_a3C.SelectedIndex];
            C1_4 = LEC_C[cB_U1_a4C.SelectedIndex];
            C1_5 = LEC_C[cB_U1_a5C.SelectedIndex];
            C1_6 = LEC_C[cB_U1_a6C.SelectedIndex];
            C1_7 = LEC_C[cB_U1_a7C.SelectedIndex];
            C1_8 = LEC_C[cB_U1_a8C.SelectedIndex];
            C1_9 = LEC_C[cB_U1_a9C.SelectedIndex];
            C1_10 = LEC_C[cB_U1_a10C.SelectedIndex];

            D1_1 = LEC_L[cB_U1_a1L.SelectedIndex] * LEC_E[cB_U1_a1E.SelectedIndex] * LEC_C[cB_U1_a1C.SelectedIndex];
            D1_2 = LEC_L[cB_U1_a2L.SelectedIndex] * LEC_E[cB_U1_a2E.SelectedIndex] * LEC_C[cB_U1_a2C.SelectedIndex];
            D1_3 = LEC_L[cB_U1_a3L.SelectedIndex] * LEC_E[cB_U1_a3E.SelectedIndex] * LEC_C[cB_U1_a3C.SelectedIndex];
            D1_4 = LEC_L[cB_U1_a4L.SelectedIndex] * LEC_E[cB_U1_a4E.SelectedIndex] * LEC_C[cB_U1_a4C.SelectedIndex];
            D1_5 = LEC_L[cB_U1_a5L.SelectedIndex] * LEC_E[cB_U1_a5E.SelectedIndex] * LEC_C[cB_U1_a5C.SelectedIndex];
            D1_6 = LEC_L[cB_U1_a6L.SelectedIndex] * LEC_E[cB_U1_a6E.SelectedIndex] * LEC_C[cB_U1_a6C.SelectedIndex];
            D1_7 = LEC_L[cB_U1_a7L.SelectedIndex] * LEC_E[cB_U1_a7E.SelectedIndex] * LEC_C[cB_U1_a7C.SelectedIndex];
            D1_8 = LEC_L[cB_U1_a8L.SelectedIndex] * LEC_E[cB_U1_a8E.SelectedIndex] * LEC_C[cB_U1_a8C.SelectedIndex];
            D1_9 = LEC_L[cB_U1_a9L.SelectedIndex] * LEC_E[cB_U1_a9E.SelectedIndex] * LEC_C[cB_U1_a9C.SelectedIndex];
            D1_10 = LEC_L[cB_U1_a10L.SelectedIndex] * LEC_E[cB_U1_a10E.SelectedIndex] * LEC_C[cB_U1_a10C.SelectedIndex];

            S1_1 = level(D1_1);
            S1_2 = level(D1_2);
            S1_3 = level(D1_3);
            S1_4 = level(D1_4);
            S1_5 = level(D1_5);
            S1_6 = level(D1_6);
            S1_7 = level(D1_7);
            S1_8 = level(D1_8);
            S1_9 = level(D1_9);
            S1_10 = level(D1_10);

            //坍塌U2
            double D2_1, D2_2, D2_3, D2_4, D2_5, D2_6, D2_7, D2_8;
            string S2_1, S2_2, S2_3, S2_4, S2_5, S2_6, S2_7, S2_8;

            double L2_1, L2_2, L2_3, L2_4, L2_5, L2_6, L2_7, L2_8,
                   E2_1, E2_2, E2_3, E2_4, E2_5, E2_6, E2_7, E2_8,
                   C2_1, C2_2, C2_3, C2_4, C2_5, C2_6, C2_7, C2_8;

            L2_1 = LEC_L[cB_U2_a1L.SelectedIndex];
            L2_2 = LEC_L[cB_U2_a2L.SelectedIndex];
            L2_3 = LEC_L[cB_U2_a3L.SelectedIndex];
            L2_4 = LEC_L[cB_U2_a4L.SelectedIndex];
            L2_5 = LEC_L[cB_U2_a5L.SelectedIndex];
            L2_6 = LEC_L[cB_U2_a6L.SelectedIndex];
            L2_7 = LEC_L[cB_U2_a7L.SelectedIndex];
            L2_8 = LEC_L[cB_U2_a8L.SelectedIndex];

            E2_1 = LEC_E[cB_U2_a1E.SelectedIndex];
            E2_2 = LEC_E[cB_U2_a2E.SelectedIndex];
            E2_3 = LEC_E[cB_U2_a3E.SelectedIndex];
            E2_4 = LEC_E[cB_U2_a4E.SelectedIndex];
            E2_5 = LEC_E[cB_U2_a5E.SelectedIndex];
            E2_6 = LEC_E[cB_U2_a6E.SelectedIndex];
            E2_7 = LEC_E[cB_U2_a7E.SelectedIndex];
            E2_8 = LEC_E[cB_U2_a8E.SelectedIndex];

            C2_1 = LEC_C[cB_U2_a1C.SelectedIndex];
            C2_2 = LEC_C[cB_U2_a2C.SelectedIndex];
            C2_3 = LEC_C[cB_U2_a3C.SelectedIndex];
            C2_4 = LEC_C[cB_U2_a4C.SelectedIndex];
            C2_5 = LEC_C[cB_U2_a5C.SelectedIndex];
            C2_6 = LEC_C[cB_U2_a6C.SelectedIndex];
            C2_7 = LEC_C[cB_U2_a7C.SelectedIndex];
            C2_8 = LEC_C[cB_U2_a8C.SelectedIndex];

            D2_1 = LEC_L[cB_U2_a1L.SelectedIndex] * LEC_E[cB_U2_a1E.SelectedIndex] * LEC_C[cB_U2_a1C.SelectedIndex];
            D2_2 = LEC_L[cB_U2_a2L.SelectedIndex] * LEC_E[cB_U2_a2E.SelectedIndex] * LEC_C[cB_U2_a2C.SelectedIndex];
            D2_3 = LEC_L[cB_U2_a3L.SelectedIndex] * LEC_E[cB_U2_a3E.SelectedIndex] * LEC_C[cB_U2_a3C.SelectedIndex];
            D2_4 = LEC_L[cB_U2_a4L.SelectedIndex] * LEC_E[cB_U2_a4E.SelectedIndex] * LEC_C[cB_U2_a4C.SelectedIndex];
            D2_5 = LEC_L[cB_U2_a5L.SelectedIndex] * LEC_E[cB_U2_a5E.SelectedIndex] * LEC_C[cB_U2_a5C.SelectedIndex];
            D2_6 = LEC_L[cB_U2_a6L.SelectedIndex] * LEC_E[cB_U2_a6E.SelectedIndex] * LEC_C[cB_U2_a6C.SelectedIndex];
            D2_7 = LEC_L[cB_U2_a7L.SelectedIndex] * LEC_E[cB_U2_a7E.SelectedIndex] * LEC_C[cB_U2_a7C.SelectedIndex];
            D2_8 = LEC_L[cB_U2_a8L.SelectedIndex] * LEC_E[cB_U2_a8E.SelectedIndex] * LEC_C[cB_U2_a8C.SelectedIndex];


            S2_1 = level(D2_1);
            S2_2 = level(D2_2);
            S2_3 = level(D2_3);
            S2_4 = level(D2_4);
            S2_5 = level(D2_5);
            S2_6 = level(D2_6);
            S2_7 = level(D2_7);
            S2_8 = level(D2_8);

            //物体打击U3
            double D3_1, D3_2, D3_3, D3_4;
            string S3_1, S3_2, S3_3, S3_4;

            double L3_1, L3_2, L3_3, L3_4,
                   E3_1, E3_2, E3_3, E3_4,
                   C3_1, C3_2, C3_3, C3_4;

            L3_1 = LEC_L[cB_U3_a1L.SelectedIndex];
            L3_2 = LEC_L[cB_U3_a2L.SelectedIndex];
            L3_3 = LEC_L[cB_U3_a3L.SelectedIndex];
            L3_4 = LEC_L[cB_U3_a4L.SelectedIndex];

            E3_1 = LEC_E[cB_U3_a1E.SelectedIndex];
            E3_2 = LEC_E[cB_U3_a2E.SelectedIndex];
            E3_3 = LEC_E[cB_U3_a3E.SelectedIndex];
            E3_4 = LEC_E[cB_U3_a4E.SelectedIndex];

            C3_1 = LEC_C[cB_U3_a1C.SelectedIndex];
            C3_2 = LEC_C[cB_U3_a2C.SelectedIndex];
            C3_3 = LEC_C[cB_U3_a3C.SelectedIndex];
            C3_4 = LEC_C[cB_U3_a4C.SelectedIndex];

            D3_1 = LEC_L[cB_U3_a1L.SelectedIndex] * LEC_E[cB_U3_a1E.SelectedIndex] * LEC_C[cB_U3_a1C.SelectedIndex];
            D3_2 = LEC_L[cB_U3_a2L.SelectedIndex] * LEC_E[cB_U3_a2E.SelectedIndex] * LEC_C[cB_U3_a2C.SelectedIndex];
            D3_3 = LEC_L[cB_U3_a3L.SelectedIndex] * LEC_E[cB_U3_a3E.SelectedIndex] * LEC_C[cB_U3_a3C.SelectedIndex];
            D3_4 = LEC_L[cB_U3_a4L.SelectedIndex] * LEC_E[cB_U3_a4E.SelectedIndex] * LEC_C[cB_U3_a4C.SelectedIndex];

            S3_1 = level(D3_1);
            S3_2 = level(D3_2);
            S3_3 = level(D3_3);
            S3_4 = level(D3_4);

            //火灾U4
            double D4_1, D4_2;
            string S4_1, S4_2;

            double L4_1, L4_2,
                   E4_1, E4_2,
                   C4_1, C4_2;

            L4_1 = LEC_L[cB_U4_a1L.SelectedIndex];
            L4_2 = LEC_L[cB_U4_a2L.SelectedIndex];

            E4_1 = LEC_E[cB_U4_a1E.SelectedIndex];
            E4_2 = LEC_E[cB_U4_a2E.SelectedIndex];

            C4_1 = LEC_C[cB_U4_a1C.SelectedIndex];
            C4_2 = LEC_C[cB_U4_a2C.SelectedIndex];


            D4_1 = LEC_L[cB_U4_a1L.SelectedIndex] * LEC_E[cB_U4_a1E.SelectedIndex] * LEC_C[cB_U4_a1C.SelectedIndex];
            D4_2 = LEC_L[cB_U4_a2L.SelectedIndex] * LEC_E[cB_U4_a2E.SelectedIndex] * LEC_C[cB_U4_a2C.SelectedIndex];

            S4_1 = level(D4_1);
            S4_2 = level(D4_2);

            //触电U5
            double D5_1, D5_2, D5_3;
            string S5_1, S5_2, S5_3;

            double L5_1, L5_2, L5_3,
                   E5_1, E5_2, E5_3,
                   C5_1, C5_2, C5_3;

            L5_1 = LEC_L[cB_U5_a1L.SelectedIndex];
            L5_2 = LEC_L[cB_U5_a2L.SelectedIndex];
            L5_3 = LEC_L[cB_U5_a3L.SelectedIndex];

            E5_1 = LEC_E[cB_U5_a1E.SelectedIndex];
            E5_2 = LEC_E[cB_U5_a2E.SelectedIndex];
            E5_3 = LEC_E[cB_U5_a3E.SelectedIndex];

            C5_1 = LEC_C[cB_U5_a1C.SelectedIndex];
            C5_2 = LEC_C[cB_U5_a2C.SelectedIndex];
            C5_3 = LEC_C[cB_U5_a3C.SelectedIndex];

            D5_1 = LEC_L[cB_U5_a1L.SelectedIndex] * LEC_E[cB_U5_a1E.SelectedIndex] * LEC_C[cB_U5_a1C.SelectedIndex];
            D5_2 = LEC_L[cB_U5_a2L.SelectedIndex] * LEC_E[cB_U5_a2E.SelectedIndex] * LEC_C[cB_U5_a2C.SelectedIndex];
            D5_3 = LEC_L[cB_U5_a3L.SelectedIndex] * LEC_E[cB_U5_a3E.SelectedIndex] * LEC_C[cB_U5_a3C.SelectedIndex];

            S5_1 = level(D5_1);
            S5_2 = level(D5_2);
            S5_3 = level(D5_3);



            obj = new object[] { D1_1, D1_2, D1_3, D1_4, D1_5, D1_6, D1_7, D1_8, D1_9, D1_10, D2_1, D2_2, D2_3, D2_4,
                D2_5, D2_6, D2_7, D2_8, D3_1, D3_2, D3_3, D3_4, D4_1, D4_2, D5_1, D5_2, D5_3, S1_1, S1_2, S1_3, S1_4,
                S1_5, S1_6, S1_7, S1_8, S1_9, S1_10, S2_1, S2_2, S2_3, S2_4, S2_5, S2_6, S2_7, S2_8, S3_1, S3_2, S3_3,
                S3_4, S4_1, S4_2, S5_1, S5_2, S5_3, L1_1, L1_2, L1_3, L1_4, L1_5, L1_6, L1_7, L1_8, L1_9, L1_10, E1_1,
                E1_2, E1_3, E1_4, E1_5, E1_6, E1_7, E1_8, E1_9, E1_10, C1_1, C1_2, C1_3, C1_4, C1_5, C1_6, C1_7, C1_8,
                C1_9, C1_10, L2_1, L2_2, L2_3, L2_4, L2_5, L2_6, L2_7, L2_8, E2_1, E2_2, E2_3, E2_4, E2_5, E2_6, E2_7,
                E2_8, C2_1, C2_2, C2_3, C2_4, C2_5, C2_6, C2_7, C2_8, L3_1, L3_2, L3_3, L3_4, E3_1, E3_2, E3_3, E3_4, 
                C3_1, C3_2, C3_3, C3_4, L4_1, L4_2, E4_1, E4_2, C4_1, C4_2, L5_1, L5_2, L5_3, E5_1, E5_2, E5_3, C5_1, 
                C5_2, C5_3};

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