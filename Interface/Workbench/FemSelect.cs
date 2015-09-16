using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Framework.Interface.Workbench
{
    public partial class FemSelect : Framework.Interface.Common.FrmBase
    {
        private int a1;

        public int A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        private int a2;

        public int A2
        {
            get { return a2; }
            set { a2 = value; }
        }
        private int a3;

        public int A3
        {
            get { return a3; }
            set { a3 = value; }
        }
        private int b1;

        public int B1
        {
            get { return b1; }
            set { b1 = value; }
        }
        private int b2;

        public int B2
        {
            get { return b2; }
            set { b2 = value; }
        }
        private int b3;

        public int B3
        {
            get { return b3; }
            set { b3 = value; }
        }
        private int c1;

        public int C1
        {
            get { return c1; }
            set { c1 = value; }
        }
        private int c2;

        public int C2
        {
            get { return c2; }
            set { c2 = value; }
        }
        private int c3;

        public int C3
        {
            get { return c3; }
            set { c3 = value; }
        }
        private int d1;

        public int D1
        {
            get { return d1; }
            set { d1 = value; }
        }
        private int d2;

        public int D2
        {
            get { return d2; }
            set { d2 = value; }
        }
        private int d3;

        public int D3
        {
            get { return d3; }
            set { d3 = value; }
        }
        /// <summary>
        /// 判断是第一种情况或者第二种情况 0代表情况一 1代表情况二
        /// </summary>
        private int isOneOrTwo;

        public int IsOneOrTwo
        {
            get { return isOneOrTwo; }
            set { isOneOrTwo = value; }
        }
        private int pailieMode;

        public int PailieMode
        {
            get { return pailieMode; }
            set { pailieMode = value; }
        }
        public FemSelect()
        {
            InitializeComponent();

        }
        int X11 = 0, X12 = 0, X13 = 0, X21 = 0, X22 = 0, X23 = 0, X31 = 0, X32 = 0, X33 = 0, X41 = 0, X42 = 0, X43 = 0;
        double A11 = 0, A12 = 0, A13 = 0, A21 = 0, A22 = 0, A23 = 0, A31 = 0, A32 = 0, A33 = 0, A41 = 0, A42 = 0, A43 = 0;
        double sum = 0, sum1 = 0;
        double[] TextArray = new double[12];
        double[] LogArray = new double[12];
        double[] HArray = new double[3];
        double[] CArray = new double[12];
        double[] ResultArray = new double[4];
        double[] SortedArray = new double[4];
        ArrayList newList1 = new ArrayList();
        ArrayList newList2 = new ArrayList();
        ArrayList newList3 = new ArrayList();
        ArrayList newList4 = new ArrayList();
        ArrayList newList5 = new ArrayList();
        ArrayList newList6 = new ArrayList();
        ArrayList newList7 = new ArrayList();
        ArrayList newList8 = new ArrayList();
        ArrayList newList9 = new ArrayList();
        ArrayList newList10 = new ArrayList();
        ArrayList newList11 = new ArrayList();
        ArrayList newList12 = new ArrayList();

        private void FemSelect_Load(object sender, EventArgs e)
        {

            if (this.PailieMode == 3)
            {
                this.buttonX1.Visible = true; this.textBoxX29.Visible = true; this.textBoxX30.Visible = true; this.textBoxX31.Visible = true; this.textBoxX32.Visible = true; this.textBoxX33.Visible = true;
            }
            else
            {
                this.buttonX1.Visible = false; this.textBoxX29.Visible = false; this.textBoxX30.Visible = false; this.textBoxX31.Visible = false; this.textBoxX32.Visible = false; this.textBoxX33.Visible = false;
            }
            if (this.isOneOrTwo == 0)
            {
                this.textBoxX1.Text = "情况一组合方式";
                this.textBoxX8.Text = A1.ToString();
                this.textBoxX9.Text = A2.ToString();
                this.textBoxX10.Text = A3.ToString();
                this.textBoxX20.Text = B1.ToString();
                this.textBoxX21.Text = B2.ToString();
                this.textBoxX22.Text = B3.ToString();
                this.textBoxX23.Text = C1.ToString();
                this.textBoxX24.Text = C2.ToString();
                this.textBoxX25.Text = C3.ToString();
                this.textBoxX26.Text = D1.ToString();
                this.textBoxX27.Text = D2.ToString();
                this.textBoxX28.Text = D3.ToString();


            }
            else if (this.isOneOrTwo == 1)
            {
                this.textBoxX1.Text = "情况二组合方式";
                this.textBoxX8.Text = A1.ToString();
                this.textBoxX9.Text = A2.ToString();
                this.textBoxX10.Text = A3.ToString();
                this.textBoxX20.Text = B1.ToString();
                this.textBoxX21.Text = B2.ToString();
                this.textBoxX22.Text = B3.ToString();
                this.textBoxX23.Text = C1.ToString();
                this.textBoxX24.Text = C2.ToString();
                this.textBoxX25.Text = C3.ToString();
                this.textBoxX26.Text = D1.ToString();
                this.textBoxX27.Text = D2.ToString();
                this.textBoxX28.Text = D3.ToString();

            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < TextArray.Length; i++)
            {
                TextArray[i] = 0;
            }
            for (int j = 0; j < HArray.Length; j++)
            {
                HArray[j] = 0;
            }
            X11 = A1; X12 = A2; X13 = A3;
            X21 = B1; X22 = B2; X23 = B3;
            X31 = C1; X32 = C2; X33 = C3;
            X41 = D1; X42 = D2; X43 = D3;
            A11 = Math.Round((Double)X11 / (Double)(Max(X11, X21, X31, X41)), 2);
            A12 = Math.Round((Double)X12 / (Double)(Max(X12, X22, X32, X42)), 2);
            A13 = Math.Round((Double)X13 / (Double)(Max(X13, X23, X33, X43)), 2);
            A21 = Math.Round((Double)X21 / (Double)(Max(X11, X21, X31, X41)), 2);
            A22 = Math.Round((Double)X22 / (Double)(Max(X12, X22, X32, X42)), 2);
            A23 = Math.Round((Double)X23 / (Double)(Max(X13, X23, X33, X43)), 2);
            A31 = Math.Round((Double)X31 / (Double)(Max(X11, X21, X31, X41)), 2);
            A32 = Math.Round((Double)X32 / (Double)(Max(X12, X22, X32, X42)), 2);
            A33 = Math.Round((Double)X33 / (Double)(Max(X13, X23, X33, X43)), 2);
            A41 = Math.Round((Double)X41 / (Double)(Max(X11, X21, X31, X41)), 2);
            A42 = Math.Round((Double)X42 / (Double)(Max(X12, X22, X32, X42)), 2);
            A43 = Math.Round((Double)X43 / (Double)(Max(X13, X23, X33, X43)), 2);
            TextArray[0] = A11;
            TextArray[1] = A12;
            TextArray[2] = A13;
            TextArray[3] = A21;
            TextArray[4] = A22;
            TextArray[5] = A23;
            TextArray[6] = A31;
            TextArray[7] = A32;
            TextArray[8] = A33;
            TextArray[9] = A41;
            TextArray[10] = A42;
            TextArray[11] = A43;
            for (int i = 0; i < TextArray.Length; i++)
            {
                sum += Math.Round((Double)TextArray[i], 2);
            }
            TextArray[0] = Math.Round(A11 / sum, 2);
            TextArray[1] = Math.Round(A12 / sum, 2);
            TextArray[2] = Math.Round(A13 / sum, 2);
            TextArray[3] = Math.Round(A21 / sum, 2);
            TextArray[4] = Math.Round(A22 / sum, 2);
            TextArray[5] = Math.Round(A23 / sum, 2);
            TextArray[6] = Math.Round(A31 / sum, 2);
            TextArray[7] = Math.Round(A32 / sum, 2);
            TextArray[8] = Math.Round(A33 / sum, 2);
            TextArray[9] = Math.Round(A41 / sum, 2);
            TextArray[10] = Math.Round(A42 / sum, 2);
            TextArray[11] = Math.Round(A43 / sum, 2);
            for (int i = 0; i < TextArray.Length; i++)
            {
                if (TextArray[i] == 0)
                {
                    LogArray[i] = 0;
                }
                else
                {
                    LogArray[i] = Math.Log(TextArray[i]);
                }
            }
            HArray[0] = -(TextArray[0] * LogArray[0] + TextArray[3] * LogArray[3] + TextArray[6] * LogArray[6] + TextArray[9] * LogArray[9]);
            HArray[1] = -(TextArray[1] * LogArray[1] + TextArray[4] * LogArray[4] + TextArray[7] * LogArray[7] + TextArray[10] * LogArray[10]);
            HArray[2] = -(TextArray[2] * LogArray[2] + TextArray[5] * LogArray[5] + TextArray[8] * LogArray[8] + TextArray[11] * LogArray[11]);
            for (int j = 0; j < HArray.Length; j++)
            {
                HArray[j] = 1 - HArray[j] / Math.Log(4);
            }
            for (int i = 0; i < HArray.Length; i++)
            {
                sum1 += HArray[i];
            }
            for (int j = 0; j < HArray.Length; j++)
            {
                HArray[j] = HArray[j] / sum1;
            }
            #region C12
            if (A11 >= A21)
            {
                newList1.Add(1);
            }
            if (A12 >= A22)
            {
                newList1.Add(2);
            }
            if (A13 >= A23)
            {
                newList1.Add(3);
            }
            #endregion
            #region C13
            if (A11 >= A31)
            {
                newList2.Add(1);
            }
            if (A12 >= A32)
            {
                newList2.Add(2);
            }
            if (A13 >= A33)
            {
                newList2.Add(3);
            }
            #endregion
            #region C14
            if (A11 >= A41)
            {
                newList3.Add(1);
            }
            if (A12 >= A42)
            {
                newList3.Add(2);
            }
            if (A13 >= A43)
            {
                newList3.Add(3);
            }
            #endregion
            #region C21
            if (A21 >= A11)
            {
                newList4.Add(1);
            }
            if (A22 >= A12)
            {
                newList4.Add(2);
            }
            if (A23 >= A13)
            {
                newList4.Add(3);
            }
            #endregion
            #region C23
            if (A21 >= A31)
            {
                newList5.Add(1);
            }
            if (A22 >= A32)
            {
                newList5.Add(2);
            }
            if (A23 >= A33)
            {
                newList5.Add(3);
            }
            #endregion
            #region C24
            if (A21 >= A41)
            {
                newList6.Add(1);
            }
            if (A22 >= A42)
            {
                newList6.Add(2);
            }
            if (A23 >= A43)
            {
                newList6.Add(3);
            }
            #endregion
            #region C31
            if (A31 >= A11)
            {
                newList7.Add(1);
            }
            if (A32 >= A12)
            {
                newList7.Add(2);
            }
            if (A33 >= A13)
            {
                newList7.Add(3);
            }
            #endregion
            #region C32
            if (A31 >= A21)
            {
                newList8.Add(1);
            }
            if (A32 >= A22)
            {
                newList8.Add(2);
            }
            if (A33 >= A23)
            {
                newList8.Add(3);
            }
            #endregion
            #region C34
            if (A31 >= A41)
            {
                newList9.Add(1);
            }
            if (A32 >= A42)
            {
                newList9.Add(2);
            }
            if (A33 >= A43)
            {
                newList9.Add(3);
            }
            #endregion
            #region C41
            if (A41 >= A11)
            {
                newList10.Add(1);
            }
            if (A42 >= A12)
            {
                newList10.Add(2);
            }
            if (A43 >= A13)
            {
                newList10.Add(3);
            }
            #endregion
            #region C42
            if (A41 >= A21)
            {
                newList11.Add(1);
            }
            if (A42 >= A22)
            {
                newList11.Add(2);
            }
            if (A43 >= A23)
            {
                newList11.Add(3);
            }
            #endregion
            #region C43
            if (A41 >= A31)
            {
                newList12.Add(1);
            }
            if (A42 >= A32)
            {
                newList12.Add(2);
            }
            if (A43 >= A33)
            {
                newList12.Add(3);
            }
            #endregion

            #region c12
            if (newList1.Count == 1)
            {
                if ((int)newList1[0] == 1)
                {
                    CArray[0] = HArray[0];
                }
                else if ((int)newList1[0] == 2)
                {
                    CArray[0] = HArray[1];
                }
                else if ((int)newList1[0] == 3)
                {
                    CArray[0] = HArray[2];
                }
            }
            else if (newList1.Count == 2)
            {
                if ((int)newList1[0] == 1 && (int)newList1[1] == 2)
                {
                    CArray[0] = HArray[0] + HArray[1];
                }
                else if ((int)newList1[0] == 1 && (int)newList1[1] == 3)
                {
                    CArray[0] = HArray[0] + HArray[2];
                }
                else if ((int)newList1[0] == 2 && (int)newList1[1] == 3)
                {
                    CArray[0] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList1.Count == 3)
            {
                CArray[0] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[0] = 0;
            }
            #endregion
            #region c13
            if (newList2.Count == 1)
            {
                if ((int)newList2[0] == 1)
                {
                    CArray[1] = HArray[0];
                }
                else if ((int)newList2[0] == 2)
                {
                    CArray[1] = HArray[1];
                }
                else if ((int)newList2[0] == 3)
                {
                    CArray[1] = HArray[2];
                }
            }
            else if (newList2.Count == 2)
            {
                if ((int)newList2[0] == 1 && (int)newList2[1] == 2)
                {
                    CArray[1] = HArray[0] + HArray[1];
                }
                else if ((int)newList2[0] == 1 && (int)newList2[1] == 3)
                {
                    CArray[1] = HArray[0] + HArray[2];
                }
                else if ((int)newList2[0] == 2 && (int)newList2[1] == 3)
                {
                    CArray[1] = HArray[1] + HArray[2];
                }
            }
            else if (newList2.Count == 3)
            {
                CArray[1] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[1] = 0;
            }
            #endregion
            #region c14
            if (newList3.Count == 1)
            {
                if ((int)newList3[0] == 1)
                {
                    CArray[2] = HArray[0];
                }
                else if ((int)newList3[0] == 2)
                {
                    CArray[2] = HArray[1];
                }
                else if ((int)newList3[0] == 3)
                {
                    CArray[2] = HArray[2];
                }
            }
            else if (newList3.Count == 2)
            {
                if ((int)newList3[0] == 1 && (int)newList3[1] == 2)
                {
                    CArray[2] = HArray[0] + HArray[1];
                }
                else if ((int)newList3[0] == 1 && (int)newList3[1] == 3)
                {
                    CArray[2] = HArray[0] + HArray[2];
                }
                else if ((int)newList3[0] == 2 && (int)newList3[1] == 3)
                {
                    CArray[2] = HArray[1] + HArray[2];
                }
            }
            else if (newList3.Count == 3)
            {
                CArray[2] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[2] = 0;
            }
            #endregion
            #region c21
            if (newList4.Count == 1)
            {
                if ((int)newList4[0] == 1)
                {
                    CArray[3] = HArray[0];
                }
                else if ((int)newList4[0] == 2)
                {
                    CArray[3] = HArray[1];
                }
                else if ((int)newList4[0] == 3)
                {
                    CArray[3] = HArray[2];
                }
            }
            else if (newList4.Count == 2)
            {
                if ((int)newList4[0] == 1 && (int)newList4[1] == 2)
                {
                    CArray[3] = HArray[0] + HArray[1];
                }
                else if ((int)newList4[0] == 1 && (int)newList4[1] == 3)
                {
                    CArray[3] = HArray[0] + HArray[2];
                }
                else if ((int)newList4[0] == 2 && (int)newList4[1] == 3)
                {
                    CArray[3] = HArray[1] + HArray[2];
                }
            }
            else if (newList4.Count == 3)
            {
                CArray[3] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[3] = 0;
            }
            #endregion
            #region c23
            if ((int)newList5.Count == 1)
            {
                if ((int)newList5[0] == 1)
                {
                    CArray[4] = HArray[0];
                }
                else if ((int)newList5[0] == 2)
                {
                    CArray[4] = HArray[1];
                }
                else if ((int)newList5[0] == 3)
                {
                    CArray[4] = HArray[2];
                }
            }
            else if ((int)newList5.Count == 2)
            {
                if ((int)newList5[0] == 1 && (int)newList5[1] == 2)
                {
                    CArray[4] = HArray[0] + HArray[1];
                }
                else if ((int)newList5[0] == 1 && (int)newList5[1] == 3)
                {
                    CArray[4] = HArray[0] + HArray[2];
                }
                else if ((int)newList5[0] == 2 && (int)newList5[1] == 3)
                {
                    CArray[4] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList5.Count == 3)
            {
                CArray[4] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[4] = 0;
            }
            #endregion
            #region c24
            if ((int)newList6.Count == 1)
            {
                if ((int)newList6[0] == 1)
                {
                    CArray[5] = HArray[0];
                }
                else if ((int)newList6[0] == 2)
                {
                    CArray[5] = HArray[1];
                }
                else if ((int)newList6[0] == 3)
                {
                    CArray[5] = HArray[2];
                }
            }
            else if ((int)newList6.Count == 2)
            {
                if ((int)newList6[0] == 1 && (int)newList6[1] == 2)
                {
                    CArray[5] = HArray[0] + HArray[1];
                }
                else if ((int)newList6[0] == 1 && (int)newList6[1] == 3)
                {
                    CArray[5] = HArray[0] + HArray[2];
                }
                else if ((int)newList6[0] == 2 && (int)newList6[1] == 3)
                {
                    CArray[5] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList6.Count == 3)
            {
                CArray[5] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[5] = 0;
            }
            #endregion
            #region c31
            if ((int)newList7.Count == 1)
            {
                if ((int)newList7[0] == 1)
                {
                    CArray[6] = HArray[0];
                }
                else if ((int)newList7[0] == 2)
                {
                    CArray[6] = HArray[1];
                }
                else if ((int)newList7[0] == 3)
                {
                    CArray[6] = HArray[2];
                }
            }
            else if ((int)newList7.Count == 2)
            {
                if ((int)newList7[0] == 1 && (int)newList7[1] == 2)
                {
                    CArray[6] = HArray[0] + HArray[1];
                }
                else if ((int)newList7[0] == 1 && (int)newList7[1] == 3)
                {
                    CArray[6] = HArray[0] + HArray[2];
                }
                else if ((int)newList7[0] == 2 && (int)newList7[1] == 3)
                {
                    CArray[6] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList7.Count == 3)
            {
                CArray[6] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[6] = 0;
            }
            #endregion
            #region c32
            if ((int)newList8.Count == 1)
            {
                if ((int)newList8[0] == 1)
                {
                    CArray[7] = HArray[0];
                }
                else if ((int)newList8[0] == 2)
                {
                    CArray[7] = HArray[1];
                }
                else if ((int)newList8[0] == 3)
                {
                    CArray[7] = HArray[2];
                }
            }
            else if ((int)newList8.Count == 2)
            {
                if ((int)newList8[0] == 1 && (int)newList8[1] == 2)
                {
                    CArray[7] = HArray[0] + HArray[1];
                }
                else if ((int)newList8[0] == 1 && (int)newList8[1] == 3)
                {
                    CArray[7] = HArray[0] + HArray[2];
                }
                else if ((int)newList8[0] == 2 && (int)newList8[1] == 3)
                {
                    CArray[7] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList8.Count == 3)
            {
                CArray[7] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[7] = 0;
            }
            #endregion
            #region c34
            if ((int)newList9.Count == 1)
            {
                if ((int)newList9[0] == 1)
                {
                    CArray[8] = HArray[0];
                }
                else if ((int)newList9[0] == 2)
                {
                    CArray[8] = HArray[1];
                }
                else if ((int)newList9[0] == 3)
                {
                    CArray[8] = HArray[2];
                }
            }
            else if ((int)newList9.Count == 2)
            {
                if ((int)newList9[0] == 1 && (int)newList9[1] == 2)
                {
                    CArray[8] = HArray[0] + HArray[1];
                }
                else if ((int)newList9[0] == 1 && (int)newList9[1] == 3)
                {
                    CArray[8] = HArray[0] + HArray[2];
                }
                else if ((int)newList9[0] == 2 && (int)newList9[1] == 3)
                {
                    CArray[8] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList9.Count == 3)
            {
                CArray[8] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[8] = 0;
            }
            #endregion
            #region c41
            if ((int)newList10.Count == 1)
            {
                if ((int)(int)newList10[0] == 1)
                {
                    CArray[9] = HArray[0];
                }
                else if ((int)(int)newList10[0] == 2)
                {
                    CArray[9] = HArray[1];
                }
                else if ((int)(int)newList10[0] == 3)
                {
                    CArray[9] = HArray[2];
                }
            }
            else if ((int)newList10.Count == 2)
            {
                if ((int)(int)newList10[0] == 1 && (int)(int)newList10[1] == 2)
                {
                    CArray[9] = HArray[0] + HArray[1];
                }
                else if ((int)(int)newList10[0] == 1 && (int)(int)newList10[1] == 3)
                {
                    CArray[9] = HArray[0] + HArray[2];
                }
                else if ((int)(int)newList10[0] == 2 && (int)(int)newList10[1] == 3)
                {
                    CArray[9] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList10.Count == 3)
            {
                CArray[9] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[9] = 0;
            }
            #endregion
            #region c42
            if ((int)newList11.Count == 1)
            {
                if ((int)newList11[0] == 1)
                {
                    CArray[10] = HArray[0];
                }
                else if ((int)newList11[0] == 2)
                {
                    CArray[10] = HArray[1];
                }
                else if ((int)newList11[0] == 3)
                {
                    CArray[10] = HArray[2];
                }
            }
            else if ((int)newList11.Count == 2)
            {
                if ((int)newList11[0] == 1 && (int)newList11[1] == 2)
                {
                    CArray[10] = HArray[0] + HArray[1];
                }
                else if ((int)newList11[0] == 1 && (int)newList11[1] == 3)
                {
                    CArray[10] = HArray[0] + HArray[2];
                }
                else if ((int)newList11[0] == 2 && (int)newList11[1] == 3)
                {
                    CArray[10] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList11.Count == 3)
            {
                CArray[10] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[10] = 0;
            }
            #endregion
            #region c43
            if ((int)newList12.Count == 1)
            {
                if ((int)newList12[0] == 1)
                {
                    CArray[11] = HArray[0];
                }
                else if ((int)newList12[0] == 2)
                {
                    CArray[11] = HArray[1];
                }
                else if ((int)newList12[0] == 3)
                {
                    CArray[11] = HArray[2];
                }
            }
            else if ((int)newList12.Count == 2)
            {
                if ((int)newList12[0] == 1 && (int)newList12[1] == 2)
                {
                    CArray[11] = HArray[0] + HArray[1];
                }
                else if ((int)newList12[0] == 1 && (int)newList12[1] == 3)
                {
                    CArray[11] = HArray[0] + HArray[2];
                }
                else if ((int)newList12[0] == 2 && (int)newList12[1] == 3)
                {
                    CArray[11] = HArray[1] + HArray[2];
                }
            }
            else if ((int)newList12.Count == 3)
            {
                CArray[11] = HArray[0] + HArray[1] + HArray[2];
            }
            else
            {
                CArray[11] = 0;
            }
            #endregion
            ResultArray[0] = CArray[0] + CArray[1] + CArray[2] - CArray[3] - CArray[6] - CArray[9];
            ResultArray[1] = CArray[3] + CArray[4] + CArray[5] - CArray[0] - CArray[7] - CArray[10];
            ResultArray[2] = CArray[6] + CArray[7] + CArray[8] - CArray[1] - CArray[4] - CArray[11];
            ResultArray[3] = CArray[9] + CArray[10] + CArray[11] - CArray[2] - CArray[5] - CArray[8];
            for (int i = 0; i < SortedArray.Length; i++)
            {
                SortedArray[i] = ResultArray[i];
            }
            Sort(ResultArray);
            for (int i = 0; i < ResultArray.Length; i++)
            {
                if (ResultArray[i]==SortedArray[0])
                {
                    this.textBoxX30.Text = (i + 1).ToString();
                }
                else if (ResultArray[i]==SortedArray[1])
                {
                    this.textBoxX31.Text = (i + 1).ToString();
                }
                else if ( ResultArray[i]==SortedArray[2])
                {
                    this.textBoxX32.Text = (i + 1).ToString();
                }
                else if ( ResultArray[i]==SortedArray[3])
                {
                    this.textBoxX33.Text = (i + 1).ToString();
                }
            }

        }
        private int Max(int a, int b, int c, int d)
        {
            int Max1 = a > b ? a : b;
            int Max2 = c > d ? c : d;
            int Max = Max1 > Max2 ? Max1 : Max2;
            return Max;
        }
        public static void Sort(double[] array)
        {
            int i, j;  // 循环变量
            double temp;  // 临时变量
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // 交换元素
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


    }
}