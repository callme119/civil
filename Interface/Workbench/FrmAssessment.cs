using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Algorithm;
using System.Threading;
namespace Framework.Interface.Workbench
{
    public partial class FrmAssessment : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;
        public FrmAssessment()
        {
            InitializeComponent();
           
        }

        public FrmAssessment(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);
            ChangeDataGridView(intInputProjectNum.Value, intInputAssessNum.Value);
            //RefreshDataGridView();
        }
        /// <summary>
        /// 判断是否为整数字符串
        /// </summary>
        /// <param name="message">输入的字符串</param>
        /// <param name="result">返回的数字</param>
        /// <returns>是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false</returns>
        protected bool isNumberic(string message, out double result)
        {
            result = -1;   //result 定义为out 用来输出值
            try
            {
                //当数字字符串的为是少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                result = Convert.ToDouble(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 这是一个结构体，用来进行排序
        /// </summary>
        public struct ToBeOrdered
        {
            public int Index;
            public double Value;
            public ToBeOrdered(int p1, double p2)
            {
                Index = p1;
                Value = p2;
            }
        }
        public bool CalculateAssessment()
        {
            dgAssessment.Refresh();
            try
            {
                int Rows, Columns;//记录矩阵元素的行数和列数
                Rows = dgAssessment.Rows.Count - 1;
                Columns = dgAssessment.Columns.Count - 1;

                lbState.Visible = true;
                pgBar.Visible = true;
                

                double[,] X = new double[Rows, Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (isNumberic(dgAssessment.Rows[i + 1].Cells[j + 1].Value.ToString(), out X[i, j]))
                           ;
                        else
                            return false;
                    }
                }
                //第一步
                double[,] S = new double[Rows, Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        //object a=dgChooseSmallIndex.Rows[j].Cells[0].Value;
                        if (dgChooseSmallIndex.Rows[j].Cells[0].Value.ToString().Equals("True"))
                        {
                            S[i, j] = 1 / X[i, j];
                        }
                        else
                            S[i, j] = X[i, j];
                    }
                }
                lbState.Text = "正在对原始数据进行规范化";
                pgBar.Value = 10;
                //第二步
                double[,] R = new double[Rows, Columns];
                double[] M = new double[Columns];
                double[] m = new double[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    M[j] = S[0, j];
                    m[j] = S[0, j];
                    for (int i = 0; i < Rows; i++)
                    {
                        //object a=dgChooseSmallIndex.Rows[j].Cells[0].Value;
                        if (S[i, j] > M[j])
                        {
                            M[j] = S[i, j];
                        }
                        if (S[i, j] < m[j])
                        {
                            m[j] = S[i, j];
                        }
                    }
                }
                
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        //object a=dgChooseSmallIndex.Rows[j].Cells[0].Value;
                        R[i, j] = S[i, j] / m[j];
                    }
                }
                lbState.Text = "正在计算综合评价值得取值范围";
                pgBar.Value = 25;
                //第三步
                double λ1 = dbInputFactorλ1.Value;
                double[,] T = new double[Rows, Columns];
                double[] wu = new double[Columns];
                T = (double [,])R.Clone();
                for (int j = 0; j < Rows; j++)
                {
                    for (int i = 0; i < Columns; i++)
                    {
                        for (int k = i + 1; k < Columns; k++)
                        {
                            if (T[j, i] < T[j, k])
                            {
                                double temp = T[j, k];
                                T[j, k] = T[j, i];
                                T[j, i] = temp;
                            }
                        }
                    }
                }
                if (radioButton1.Checked)
                { //对于“强权数非独裁性条件”：
                    double temp = 0;
                    for (int i = 0; i < Columns - 2; i++)
                    {
                        wu[i] = Math.Pow(0.5, i + 1);
                        temp += wu[i];
                    }
                    wu[Columns - 2] = wu[Columns - 1] = 0.5 - 0.5 * temp;
                }
                else
                {//对于“弱权数非独裁性条件”：
                    wu[0] = 0.5;
                    wu[1] = 0.5 - (Columns - 2) * Math.Pow(0.5, Columns - 1);
                    for (int i = 2; i < Columns; i++)
                    {
                        wu[i] = Math.Pow(0.5, Columns - 1);
                    }
                }
                double[,] y = new double[Rows, 2];
                for (int i = 0; i < Rows; i++)
                {
                    double temp0 = 0, temp1 = 0, temp2 = 0, temp3 = 0, temp4 = 1, temp5= 1;
                    for (int j = 0; j < Columns; j++)
                    {
                        temp2 += wu[j] * T[i, Columns - j - 1];
                        temp3 += wu[j] * T[i, j];
                        //temp4 *= Math.Pow();
                        temp4 *= Math.Pow(T[i, Columns - j - 1], 1 / Columns);
                        temp5 *= Math.Pow(T[i, j], 1 / Columns);

                    }
                    temp0 = (λ1 * temp2 + (1-λ1) * temp4);
                    temp1 = (λ1 * temp3 + (1-λ1) * temp5);

                    y[i, 0] = temp0;
                    y[i, 1] = temp1;
                }
                lbState.Text = "正在计算各工程方案的竞争视野";
                pgBar.Value = 45;
                //第四步
                double[,] C_L = new double[Rows, Rows];
                double[,] C_U = new double[Rows, Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = i; j < Rows; j++)
                    {
                        intersection(y[i, 0], y[i, 1], y[j, 0], y[j, 1], out C_L[i, j], out C_U[i, j]);
                    }
                }

                double[,] d = new double[Rows, Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = i; j < Rows; j++)
                    {
                        if (i == j)
                        {
                            d[i, j] = 0;//这里不知道横线是什么意思，姑且按照0来计算
                        }
                        else
                        {
                            d[i, j] = d[j, i] = (C_U[i, j] - C_L[i, j]) / (Math.Max(y[i, 1], y[j, 1]) - Math.Min(y[i, 0], y[j, 0]));
                        }
                    }
                }
                lbState.Text = "正在计算各工程方案的竞争强度";
                pgBar.Value = 70;
                //第五步
                double[,] u = new double[Rows, Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        if (i == j)
                        {
                            u[i, j] = 0;
                        }
                        else
                        {
                            double temp = 0;
                            for (int k = 0; k < Rows; k++)
                            {
                                temp += d[i, k];
                            }
                            u[i, j] = d[i, j] / temp;
                        }
                    }
                }
                lbState.Text = "正在计算竞争力关注系数向量";
                pgBar.Value = 80;
                //第六步
                double λ = dbInputFactorλ.Value;
                double[,] w = new double[Rows, Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < Rows; k++)
                        {
                            if (k != i)
                            {
                                temp += R[k, j] * u[i, k];
                            }

                        }
                        w[i, j] = λ * R[i, j] - (1 - λ) * temp;
                    }
                }
                //第七步
                lbState.Text = "正在构造规划问题并求解";
                pgBar.Value = 90;
                double[,] wx = new double[Rows, Columns];//wx表示w*:x为星的意思
                //对于“强权数非独裁性条件”和“强权数非独裁性条件”代码是一样的：
                //因为：wx是有wu求得的，而wu已经通过上述条件获得。
                ToBeOrdered[] orderNumber = new ToBeOrdered[Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {//先赋值
                        orderNumber[j].Index = j;
                        orderNumber[j].Value = w[i, j];
                    }
                    for (int j = 0; j < Columns; j++)
                    {//再排序
                        for (int k = j + 1; k < Columns; k++)
                        {
                            if (orderNumber[j].Value < orderNumber[k].Value)
                            {
                                ToBeOrdered temp = orderNumber[k];
                                orderNumber[k] = orderNumber[j];
                                orderNumber[j] = temp;
                            }
                        }

                    }
                    for (int j = 0; j < Columns; j++)
                    {//最后输出
                        wx[i, orderNumber[j].Index] = wu[j];
                    }
                }
                //第八步
                double[,] Y = new double[Rows, Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        double  temp = 0, temp6 = 0, temp7 = 1;
                        for (int k = 0; k < Columns; k++)
                        {
                            //temp += wx[j, k] * R[i, k];

                            temp6 += wx[j, k] * R[i, k];
                            temp7 *= Math.Pow(R[i, k], 1 / Columns);

                        }
                        //Y[i, j] = temp;
                        temp = (λ1 * temp6 + (1-λ1) * temp7);
                        Y[i, j] = temp;

                    }
                }
                //第九步
                //计算矩阵的正特征向量
                double[,] Y1 = new double[Rows, Rows];//左侧
                double[,] Y2 = new double[Rows, Rows];//右侧
                double[,] Y3 = new double[Rows, Rows];//结果
                Y1 =(double [,]) Y.Clone();
                for (int i = 0; i < Rows; i++)
                {//构造转置矩阵
                    for (int j = 0; j < Rows; j++)
                    {
                        Y2[i, j] = Y1[j, i];
                    }
                }
                for (int i = 0; i < Rows; i++)
                {//构造对称矩阵
                    for (int j = 0; j < Rows; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < Rows; k++)
                        {
                            temp += Y1[i, k] * Y2[k, j];
                        }
                        Y3[i, j] = temp;
                    }
                }
                double[] Y4 = new double[Rows*Rows];//用于计算参数
                for (int i = 0; i < Rows; i++)
                {//将对称矩阵转换为一维数组
                    for (int j = 0; j < Rows; j++)
                    {
                        Y4[i*Rows+j] = Y3[i, j];
                    }
                }
                //////////////////////////////////////////
                            // 实对称三对角阵的全部特征值与特征向量的计算
                Matrix mtx16 = new Matrix(Rows, Rows, Y4);
              
                Matrix mtxQ2 = new Matrix();//返回豪斯荷尔德变换的乘积矩阵Q
                Matrix mtxT2 = new Matrix();//返回求得的对称三对角阵
                double[] bArray2 = new double[mtx16.GetNumColumns()];//返回对称三对角阵的主对角线元素
                double[] cArray2 = new double[mtx16.GetNumColumns()];//前n-1个元素返回对称三对角阵的次对角线元素
                double[] resultArray = new double[mtx16.GetNumColumns()];//存放λ的结果值
                // 1: 约化对称矩阵为对称三对角阵: 豪斯荷尔德变换法
                if (mtx16.MakeSymTri(mtxQ2, mtxT2, bArray2, cArray2))
                {
                    // 2: 计算全部特征值与特征向量
                    //bArray2:传入对称三对角阵的主对角线元素,返回时存放全部特征值。
                    //cArray2:前n-1个元素传入对称三对角阵的次对角线元素
                    //mtxQ2:返回矩阵A的特征值向量矩阵。其中第i列为与数组dblB中第i个特征值对应的特征向量。
                    //60:迭代次数
                    //0.0001:计算精度
                    if (mtx16.ComputeEvSymTri(bArray2, cArray2, mtxQ2, 60, 0.0001))
                    {
                        int tempi = 0;
                        double tempNum = bArray2[0];
                        for (int i = 0; i < mtxQ2.GetNumColumns(); ++i)
                        {//查找特征值中最大的那个
                            if (tempNum < bArray2[i])
                            {
                                tempi = i;
                                tempNum = bArray2[i];
                            }
                        }
                        for (int i = 0; i < mtxQ2.GetNumRows(); ++i)
                        {
                            if(mtxQ2.GetElement(i,tempi)<0)
                            {//取正值
                                resultArray[i]=-mtxQ2.GetElement(i,tempi);
                            }
                            else
                            {
                                resultArray[i]=mtxQ2.GetElement(i,tempi);
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                //////////////////////////////////////////

                //第十步
                double[,] x = new double[Rows, Rows];

                ToBeOrdered[] orderNumber2 = new ToBeOrdered[Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {//先赋值
                        orderNumber2[j].Index = j;
                        orderNumber2[j].Value = Y[j, i];//注意是对列进行操作
                    }
                    for (int j = 0; j < Rows; j++)
                    {//再排序
                        for (int k = j + 1; k < Rows; k++)
                        {
                            if (orderNumber2[j].Value < orderNumber2[k].Value)
                            {
                                ToBeOrdered temp = orderNumber2[k];
                                orderNumber2[k] = orderNumber2[j];
                                orderNumber2[j] = temp;
                            }
                        }
                    }
                    for (int j = 0; j < Rows; j++)
                    {//最后输出
                        x[orderNumber2[j].Index, i] = j + 1;//注意值越大，序号越小
                    }
                }
                //
                //第十一步
                int[] orderResult = new int[Rows];//存放λ的排序值
                ToBeOrdered[] orderNumber3 = new ToBeOrdered[Rows];

                for (int j = 0; j < Rows; j++)
                {//先赋值
                    orderNumber3[j].Index = j;
                    orderNumber3[j].Value = resultArray[j];
                }
                for (int j = 0; j < Rows; j++)
                {//再排序
                    for (int k = j + 1; k < Rows; k++)
                    {
                        if (orderNumber3[j].Value < orderNumber3[k].Value)
                        {
                            ToBeOrdered temp = orderNumber3[k];
                            orderNumber3[k] = orderNumber3[j];
                            orderNumber3[j] = temp;
                        }
                    }
                }
                for (int j = 0; j < Rows; j++)
                {//最后输出
                    orderResult[orderNumber3[j].Index] = j + 1;//注意值越大，序号越小
                }
               
                //
                lbState.Text = "计算完成！";
                pgBar.Value = 100;
                lbState.Visible = false;
                pgBar.Visible = false;

                FrmAssessResultshow result = new FrmAssessResultshow(x,orderResult);
                result.ShowDialog();
            }
            catch
            {
                return false;
            }

                return true;
        }
        /// <summary>
        /// 获取区间的交集
        /// </summary>
        /// <param name="a1">区间a的左侧</param>
        /// <param name="a2">区间a的右侧</param>
        /// <param name="b1">区间b的左侧</param>
        /// <param name="b2">区间b的右侧</param>
        /// <param name="a">输出交集区间左侧</param>
        /// <param name="b">输出交集区间右侧</param>
        public void intersection(double a1,double a2,double b1,double b2,out double a,out double b)
        {
            if (a2 < b1)
            {
                a = b = 0;
                return;
            }
            else
                if (a2 == b1)
                {
                    a = b = a2;
                    return;
                }
                else
                {
                    if (a2 <= b2 && a1 <= b1)
                    {
                        a = b1;
                        b = a2;
                        return;
                    }
                    if(a2 <= b2 && a1 > b1)
                    {
                        a = a1;
                        b = a2;
                        return;
                    }
                    if (a2 > b2 && a1 <= b2)
                    {
                        a = b1;
                        b = b2;
                        return;
                    }
                    if (a2 > b2 && a1 > b2)
                    {
                        a = b = 0;
                        return;
                    }
                }
            a = b = 0;
            return;
        }
        public void RefreshDataGridView(bool recreate)
        {
            string text;
            dgAssessment.Refresh();
            if (recreate)
            {
                dgChooseSmallIndex.Rows.Clear();
                for (int i = 0; i < dgAssessment.ColumnCount - 1; i++)
                {
                    text = dgAssessment.Rows[0].Cells[i + 1].Value.ToString();
                    //DevComponents.DotNetBar.Controls. chkBtn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXCell();
                    //chkBtn.Value = text;
                    dgChooseSmallIndex.Rows.Add();
                    dgChooseSmallIndex.Rows[i].Cells[0].Value = false;
                    dgChooseSmallIndex.Rows[i].Cells[1].Value = text;
                }
            }
            else
            {
                for (int i = 0; i < dgAssessment.ColumnCount - 1; i++)
                {
                    text = dgAssessment.Rows[0].Cells[i + 1].Value.ToString();
                    dgChooseSmallIndex.Rows[i].Cells[1].Value = text;
                }
            }
            
        }
        public void ChangeDataGridView(int Rows, int Columns)
        {
            dgAssessment.Columns.Clear();
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colBtn = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            colBtn.HeaderText = "工程方案";
            dgAssessment.Columns.Add(colBtn);
            for (int i = 0; i < Columns; i++)
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colName.HeaderText = "指标" + Convert.ToInt16(i + 1).ToString();
                dgAssessment.Columns.Add(colName);
            }

            string[] rowNames = new string[Columns+1];
            rowNames[0]="工程方案";
            for (int i = 0; i < Columns; i++)
            {
                rowNames[i+1] = "指标" + Convert.ToInt16(i + 1).ToString();
            }
            dgAssessment.Rows.Add(rowNames);
            //dgAssessment.Rows.Add(rowNames);
            //colName.Width = 475;
            for (int i = 0; i < Rows; i++)
            {
                string rowName = "方案" + Convert.ToInt16(i + 1).ToString();
                dgAssessment.Rows.Add(rowName);
            }
        }
        private void intInputProjectNum_ValueChanged(object sender, EventArgs e)
        {
            ChangeDataGridView(intInputProjectNum.Value, intInputAssessNum.Value);
            
        }
        private void intInputAssessNum_ValueChanged(object sender, EventArgs e)
        {
            ChangeDataGridView(intInputProjectNum.Value, intInputAssessNum.Value);
            RefreshDataGridView(true);
        }
        private void dgAssessment_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            RefreshDataGridView(true);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(false);
            if (!CalculateAssessment())
                MessageBox.Show("请注意数据的填写！");

        }
        private void btnQuit_Click(object sender, System.EventArgs e)//关闭窗体
        {
            this.Close();
        }
       

        private void FrmAssessment_Load(object sender, EventArgs e)
        {
            RefreshDataGridView(true);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
    }
}

