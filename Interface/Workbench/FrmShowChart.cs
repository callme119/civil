using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmShowChart : Framework.Interface.Common.FrmBase
    {
        public FrmShowChart(int chart)
        {
            InitializeComponent();
            switch (chart)
            {
                case 0:
                    this.BackgroundImage = global::Framework.Properties.Resources.��ʯ;
                    break;
                case 1:
                    this.BackgroundImage = global::Framework.Properties.Resources.��ʯ��;
                    break;
                case 2:
                    this.BackgroundImage = global::Framework.Properties.Resources.ɰ��;
                    break;
                case 3:
                    this.BackgroundImage = global::Framework.Properties.Resources.����;
                    break;
                case 4:
                    this.BackgroundImage = global::Framework.Properties.Resources.������;
                    break;
                case 5:
                    this.BackgroundImage = global::Framework.Properties.Resources.��ճ��;
                    break;
                case 6:
                    this.BackgroundImage = global::Framework.Properties.Resources.ճ����;
                    break;
                case 7:
                    this.BackgroundImage = global::Framework.Properties.Resources.��������;
                    break;
                case 8:
                    this.BackgroundImage = global::Framework.Properties.Resources.��ʯԲ��;
                    break;
                case 9:
                    this.BackgroundImage = global::Framework.Properties.Resources.�ػ�����������ϵ��;
                    break;
                case 10:
                    this.BackgroundImage = global::Framework.Properties.Resources.�����񽺺ϰ�;
                    break;
                case 11:
                    this.BackgroundImage = global::Framework.Properties.Resources.����ľ���ϰ�;
                    break;
                case 12:
                    this.BackgroundImage = global::Framework.Properties.Resources.����ľ��ά��;
                    break;
                case 13:
                    this.BackgroundImage = global::Framework.Properties.Resources.������ѹǿ��;
                    break;
                case 14:
                    this.BackgroundImage = global::Framework.Properties.Resources.�ۺ����۰���;
                    break;
                case 15:
                    this.BackgroundImage = global::Framework.Properties.Resources.���2;
                    break;
                case 16:
                    this.BackgroundImage = global::Framework.Properties.Resources.���3;
                    break;
                case 17:
                    this.BackgroundImage = global::Framework.Properties.Resources.���4;
                    break;
                case 18:
                    this.BackgroundImage = global::Framework.Properties.Resources.���5;
                    break;
                case 19:
                    this.BackgroundImage = global::Framework.Properties.Resources.���6;
                    break;
                case 20:
                    this.BackgroundImage = global::Framework.Properties.Resources.���7;
                    break;
                case 21:
                    this.BackgroundImage = global::Framework.Properties.Resources.���8;
                    break;
                case 22:
                    this.BackgroundImage = global::Framework.Properties.Resources.���9;
                    break;
                case 23:
                    this.BackgroundImage = global::Framework.Properties.Resources.���10;
                    break;
            }
        }
    }
}

