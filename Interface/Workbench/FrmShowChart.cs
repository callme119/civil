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
                    this.BackgroundImage = global::Framework.Properties.Resources.岩石;
                    break;
                case 1:
                    this.BackgroundImage = global::Framework.Properties.Resources.碎石土;
                    break;
                case 2:
                    this.BackgroundImage = global::Framework.Properties.Resources.砂土;
                    break;
                case 3:
                    this.BackgroundImage = global::Framework.Properties.Resources.粉土;
                    break;
                case 4:
                    this.BackgroundImage = global::Framework.Properties.Resources.素填土;
                    break;
                case 5:
                    this.BackgroundImage = global::Framework.Properties.Resources.红粘土;
                    break;
                case 6:
                    this.BackgroundImage = global::Framework.Properties.Resources.粘性土;
                    break;
                case 7:
                    this.BackgroundImage = global::Framework.Properties.Resources.淤泥质土;
                    break;
                case 8:
                    this.BackgroundImage = global::Framework.Properties.Resources.卵石圆砾;
                    break;
                case 9:
                    this.BackgroundImage = global::Framework.Properties.Resources.地基承载力调整系数;
                    break;
                case 10:
                    this.BackgroundImage = global::Framework.Properties.Resources.覆面竹胶合板;
                    break;
                case 11:
                    this.BackgroundImage = global::Framework.Properties.Resources.覆面木胶合板;
                    break;
                case 12:
                    this.BackgroundImage = global::Framework.Properties.Resources.复合木纤维板;
                    break;
                case 13:
                    this.BackgroundImage = global::Framework.Properties.Resources.立柱抗压强度;
                    break;
                case 14:
                    this.BackgroundImage = global::Framework.Properties.Resources.综合评价帮助;
                    break;
                case 15:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣2;
                    break;
                case 16:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣3;
                    break;
                case 17:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣4;
                    break;
                case 18:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣5;
                    break;
                case 19:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣6;
                    break;
                case 20:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣7;
                    break;
                case 21:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣8;
                    break;
                case 22:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣9;
                    break;
                case 23:
                    this.BackgroundImage = global::Framework.Properties.Resources.碗扣10;
                    break;
            }
        }
    }
}

