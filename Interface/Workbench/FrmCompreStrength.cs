using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmCompreStrength : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;
  
        public FrmCompreStrength(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
             int sum = 0;
            #region view1
            int a1, b1, c1;
            double N, X, E, d1;

            foreach (DataGridViewRow row in dataGridViewX1.Rows)
            {
                a1 = Convert.ToInt32(row.Cells[0].Value);
                b1 = Convert.ToInt32(row.Cells[1].Value);
                c1 = Convert.ToInt32(row.Cells[2].Value);
                d1 = 0;

                X = Math.Max(a1, Math.Max(b1, c1));
                N = Math.Min(a1, Math.Min(b1, c1));
                E = (a1 + b1 + c1) / 3;
                if (Math.Abs((N - E) / E) <= (15 / 100) && ((X - E) / E) <= (15 / 100))
                {
                    d1 = ((X + N + E) / 3);
                }
                if (Math.Abs((N - E) / E) > (15 / 100) && ((X - E) / E) > (15 / 100))
                {
                    d1 = E;

                }
                row.Cells[3].Value = d1;
                if (Math.Abs((N - E) / E) > (15 / 100) && ((X - E) / E) > (15 / 100))
                {
                    row.Visible = false;
                    sum++;
                }
            }
            for (int i = 0; i < dataGridViewX1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewX1.Rows[i];
                if (row.Visible == false)
                {
                    dataGridViewX1.Rows.Remove(row);
                    i--;
                }
            }


            #endregion

            label2.Text = "有效组数：" + (dataGridViewX1.Rows.Count - 1);
        }
        

        
    }
}