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
        /// �ж��Ƿ�Ϊ�����ַ���
        /// </summary>
        /// <param name="message">������ַ���</param>
        /// <param name="result">���ص�����</param>
        /// <returns>�ǵĻ�����ת��Ϊ���ֲ�������Ϊout���͵����ֵ������true, ����Ϊfalse</returns>
        protected bool isNumberic(string message, out double result)
        {
            result = -1;   //result ����Ϊout �������ֵ
            try
            {
                //�������ַ�����Ϊ������4ʱ���������ֶ�����ת������ѡһ��
                //���λ������4�Ļ�����ѡ��Convert.ToInt32() ��int.Parse()

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
        /// ����һ���ṹ�壬������������
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
                int Rows, Columns;//��¼����Ԫ�ص�����������
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
                //��һ��
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
                lbState.Text = "���ڶ�ԭʼ���ݽ��й淶��";
                pgBar.Value = 10;
                //�ڶ���
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
                lbState.Text = "���ڼ����ۺ�����ֵ��ȡֵ��Χ";
                pgBar.Value = 25;
                //������
                double ��1 = dbInputFactor��1.Value;
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
                { //���ڡ�ǿȨ���Ƕ�������������
                    double temp = 0;
                    for (int i = 0; i < Columns - 2; i++)
                    {
                        wu[i] = Math.Pow(0.5, i + 1);
                        temp += wu[i];
                    }
                    wu[Columns - 2] = wu[Columns - 1] = 0.5 - 0.5 * temp;
                }
                else
                {//���ڡ���Ȩ���Ƕ�������������
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
                    temp0 = (��1 * temp2 + (1-��1) * temp4);
                    temp1 = (��1 * temp3 + (1-��1) * temp5);

                    y[i, 0] = temp0;
                    y[i, 1] = temp1;
                }
                lbState.Text = "���ڼ�������̷����ľ�����Ұ";
                pgBar.Value = 45;
                //���Ĳ�
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
                            d[i, j] = 0;//���ﲻ֪��������ʲô��˼�����Ұ���0������
                        }
                        else
                        {
                            d[i, j] = d[j, i] = (C_U[i, j] - C_L[i, j]) / (Math.Max(y[i, 1], y[j, 1]) - Math.Min(y[i, 0], y[j, 0]));
                        }
                    }
                }
                lbState.Text = "���ڼ�������̷����ľ���ǿ��";
                pgBar.Value = 70;
                //���岽
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
                lbState.Text = "���ڼ��㾺������עϵ������";
                pgBar.Value = 80;
                //������
                double �� = dbInputFactor��.Value;
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
                        w[i, j] = �� * R[i, j] - (1 - ��) * temp;
                    }
                }
                //���߲�
                lbState.Text = "���ڹ���滮���Ⲣ���";
                pgBar.Value = 90;
                double[,] wx = new double[Rows, Columns];//wx��ʾw*:xΪ�ǵ���˼
                //���ڡ�ǿȨ���Ƕ������������͡�ǿȨ���Ƕ�����������������һ���ģ�
                //��Ϊ��wx����wu��õģ���wu�Ѿ�ͨ������������á�
                ToBeOrdered[] orderNumber = new ToBeOrdered[Columns];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {//�ȸ�ֵ
                        orderNumber[j].Index = j;
                        orderNumber[j].Value = w[i, j];
                    }
                    for (int j = 0; j < Columns; j++)
                    {//������
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
                    {//������
                        wx[i, orderNumber[j].Index] = wu[j];
                    }
                }
                //�ڰ˲�
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
                        temp = (��1 * temp6 + (1-��1) * temp7);
                        Y[i, j] = temp;

                    }
                }
                //�ھŲ�
                //������������������
                double[,] Y1 = new double[Rows, Rows];//���
                double[,] Y2 = new double[Rows, Rows];//�Ҳ�
                double[,] Y3 = new double[Rows, Rows];//���
                Y1 =(double [,]) Y.Clone();
                for (int i = 0; i < Rows; i++)
                {//����ת�þ���
                    for (int j = 0; j < Rows; j++)
                    {
                        Y2[i, j] = Y1[j, i];
                    }
                }
                for (int i = 0; i < Rows; i++)
                {//����Գƾ���
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
                double[] Y4 = new double[Rows*Rows];//���ڼ������
                for (int i = 0; i < Rows; i++)
                {//���Գƾ���ת��Ϊһά����
                    for (int j = 0; j < Rows; j++)
                    {
                        Y4[i*Rows+j] = Y3[i, j];
                    }
                }
                //////////////////////////////////////////
                            // ʵ�Գ����Խ����ȫ������ֵ�����������ļ���
                Matrix mtx16 = new Matrix(Rows, Rows, Y4);
              
                Matrix mtxQ2 = new Matrix();//���غ�˹�ɶ��±任�ĳ˻�����Q
                Matrix mtxT2 = new Matrix();//������õĶԳ����Խ���
                double[] bArray2 = new double[mtx16.GetNumColumns()];//���ضԳ����Խ�������Խ���Ԫ��
                double[] cArray2 = new double[mtx16.GetNumColumns()];//ǰn-1��Ԫ�ط��ضԳ����Խ���ĴζԽ���Ԫ��
                double[] resultArray = new double[mtx16.GetNumColumns()];//��Ŧ˵Ľ��ֵ
                // 1: Լ���Գƾ���Ϊ�Գ����Խ���: ��˹�ɶ��±任��
                if (mtx16.MakeSymTri(mtxQ2, mtxT2, bArray2, cArray2))
                {
                    // 2: ����ȫ������ֵ����������
                    //bArray2:����Գ����Խ�������Խ���Ԫ��,����ʱ���ȫ������ֵ��
                    //cArray2:ǰn-1��Ԫ�ش���Գ����Խ���ĴζԽ���Ԫ��
                    //mtxQ2:���ؾ���A������ֵ�����������е�i��Ϊ������dblB�е�i������ֵ��Ӧ������������
                    //60:��������
                    //0.0001:���㾫��
                    if (mtx16.ComputeEvSymTri(bArray2, cArray2, mtxQ2, 60, 0.0001))
                    {
                        int tempi = 0;
                        double tempNum = bArray2[0];
                        for (int i = 0; i < mtxQ2.GetNumColumns(); ++i)
                        {//��������ֵ�������Ǹ�
                            if (tempNum < bArray2[i])
                            {
                                tempi = i;
                                tempNum = bArray2[i];
                            }
                        }
                        for (int i = 0; i < mtxQ2.GetNumRows(); ++i)
                        {
                            if(mtxQ2.GetElement(i,tempi)<0)
                            {//ȡ��ֵ
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

                //��ʮ��
                double[,] x = new double[Rows, Rows];

                ToBeOrdered[] orderNumber2 = new ToBeOrdered[Rows];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {//�ȸ�ֵ
                        orderNumber2[j].Index = j;
                        orderNumber2[j].Value = Y[j, i];//ע���Ƕ��н��в���
                    }
                    for (int j = 0; j < Rows; j++)
                    {//������
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
                    {//������
                        x[orderNumber2[j].Index, i] = j + 1;//ע��ֵԽ�����ԽС
                    }
                }
                //
                //��ʮһ��
                int[] orderResult = new int[Rows];//��Ŧ˵�����ֵ
                ToBeOrdered[] orderNumber3 = new ToBeOrdered[Rows];

                for (int j = 0; j < Rows; j++)
                {//�ȸ�ֵ
                    orderNumber3[j].Index = j;
                    orderNumber3[j].Value = resultArray[j];
                }
                for (int j = 0; j < Rows; j++)
                {//������
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
                {//������
                    orderResult[orderNumber3[j].Index] = j + 1;//ע��ֵԽ�����ԽС
                }
               
                //
                lbState.Text = "������ɣ�";
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
        /// ��ȡ����Ľ���
        /// </summary>
        /// <param name="a1">����a�����</param>
        /// <param name="a2">����a���Ҳ�</param>
        /// <param name="b1">����b�����</param>
        /// <param name="b2">����b���Ҳ�</param>
        /// <param name="a">��������������</param>
        /// <param name="b">������������Ҳ�</param>
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
            colBtn.HeaderText = "���̷���";
            dgAssessment.Columns.Add(colBtn);
            for (int i = 0; i < Columns; i++)
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colName.HeaderText = "ָ��" + Convert.ToInt16(i + 1).ToString();
                dgAssessment.Columns.Add(colName);
            }

            string[] rowNames = new string[Columns+1];
            rowNames[0]="���̷���";
            for (int i = 0; i < Columns; i++)
            {
                rowNames[i+1] = "ָ��" + Convert.ToInt16(i + 1).ToString();
            }
            dgAssessment.Rows.Add(rowNames);
            //dgAssessment.Rows.Add(rowNames);
            //colName.Width = 475;
            for (int i = 0; i < Rows; i++)
            {
                string rowName = "����" + Convert.ToInt16(i + 1).ToString();
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
                MessageBox.Show("��ע�����ݵ���д��");

        }
        private void btnQuit_Click(object sender, System.EventArgs e)//�رմ���
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

