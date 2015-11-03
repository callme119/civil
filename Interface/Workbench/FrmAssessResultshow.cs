using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmAssessResultshow : Framework.Interface.Common.FrmBase
    {
        public FrmAssessResultshow(double[,] result, int[] result��)
        {
            InitializeComponent();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
            //    }
            //}
            //for()
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Project = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            Project.HeaderText = "���̷���";
            dgAssessResultshow.Columns.Add(Project);
            for (int i = 0; i < result.GetLength(1); i++)
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colName = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colName.HeaderText = "����" + Convert.ToInt16(i + 1).ToString() + "��Ұ��";
                dgAssessResultshow.Columns.Add(colName);
 
            }
            DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn MulityOrder = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            MulityOrder.HeaderText = "�ۺ�����";
            dgAssessResultshow.Columns.Add(MulityOrder);


            string[] strResult = new string[result.GetLength(1)+2];
            


            for (int i = 0; i < result.GetLength(0); i++)
            {
                strResult[0] = "����"+Convert.ToInt16(i+1).ToString();
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    strResult[j + 1] = result[i, j].ToString();
                }
                strResult[result.GetLength(1) + 1] = result��[i].ToString();
                dgAssessResultshow.Rows.Add(strResult);
            }
        }
    }
}

