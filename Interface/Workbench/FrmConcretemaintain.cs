using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmConcretemaintain : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;

        public FrmConcretemaintain(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            object[] obj = new object[] { };
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "混凝土试块的制作与养护";
            string str1 = " ", str2 = " ", str3 = " ", str4 = " ", str6 = " ", str7 = " ", str8 =" ", str5 = " ";

            if (checkBox1.Checked == true)
            {
                str1="用振动台振实制作试件\r\n"+"1.取样或拌制好的混凝土拌合物应至少用铁锨再来回拌合三次。\r\n"+"2.将混凝土拌合物一次装入试模，装料时应用抹刀沿各试模壁插捣，并使混凝土拌合物高出试模口。\r\n"
                + "3.试模应附着或固定在符合要求的振动台上，振动时试模不得有任何跳动，振动应持续到表面出浆为止，不得过振。\r\n"
                + "4.刮除试模口上多余的混凝土，待混凝土临近初凝时用抹刀抹平。\r\n";;
            }
            if (checkBox2.Checked == true)
            {
                str2 = "用人工插捣制作试件\r\n" + "1.取样或拌制好的混凝土拌合物应至少用铁锨再来回拌合三次。\r\n"
                    + "2.混凝土拌合物应分两层装入模内每层的装料" + "厚度大致相等插捣应按螺旋方向从边缘向中心均匀进行。" + "在插捣底层混凝土时，捣棒应达到试模底部。" + "插捣上层时，捣棒应贯穿上层后插入下层20-30mm；插捣时，捣棒应保持垂直，不得倾斜。然后应用抹刀沿试模内壁插拔数次。\r\n";
                str6 = "3.每层插捣次数按在10000mm²截面积内不得少于12次。\r\n" + "4.插捣后应用橡皮锤轻轻敲击试模四周直至插捣棒留下的空洞消失为止。\r\n"+"5.刮除试模口上多余的混凝土，待混凝土临近初凝时用抹刀抹平。\r\n";
            
            }
            if (checkBox3.Checked == true)
            {
                str3 = "用插入式振捣棒振实制作试件\r\n" + "1.取样或拌制好的混凝土拌合物应至少用铁锨再来回拌合三次。\r\n" + "2.将混凝土拌合物一次装入试模，装料时应用抹刀沿各试模壁插捣，并使混凝土拌合物高出试模口。\r\n";
                str7= "3.宜用直径为Φ25mm的插入式振捣棒，插入试模振捣时，振捣棒距试模底板10-20mm且不得触及试模底板，"+"振动应持续到表面出浆为止，且应避免过振，以防止混凝土离析；"+"一般振捣时间为20s。振捣棒拔出时要缓慢拔出后，不得留有孔洞。\r\n"
                    + "4.刮除试模口上多余的混凝土，待混凝土临近初凝时用抹刀抹平。\r\n";
            
            }
            if (checkBox4.Checked == true)
            {
                str4 = "标准养护\r\n" + "1.试件成型后应立即用不透水的薄膜覆盖表。\r\n" + "2.采用标准养护的试件，应在温度为20±5℃的环境中静置一昼夜至二昼夜，然后编号、拆模。" + "拆模后应立即放入温度为20±2℃，相对湿度为95%以上的标准养护室中养护，" + "或在温度为20±2℃的不流动的Ca(OH)2饱和溶液中养护。" + "标准养护室内的试件应放在支架上，彼此间隔10-20mm，试件表面应保持潮湿，并不得被水直接冲淋。\r\n";
                str8= "3.标准养护龄期为28d（从搅拌加水开始计时）。\r\n" + "4.由专人负责检查每日的温度、湿度，每日记录两次，保证箱内符合规定的温度和湿度。"+"控制仪器也由专人负责操作使用，其他人员不得擅自开启温、湿度控制装置或改变已有的设置。"+"每个试件都必须有样本编号标签，如发现温、湿度异常，应立即采取措施，并上报负责人，并作好记录。\r\n";
            
            }
            if (checkBox5.Checked == true)
            {
                str5 = "同条件养护\r\n" + "1.试件成型后应立即用不透水的薄膜覆盖表。\r\n" + "2.同条件养护试件的拆模时间可与实际构件的拆模时间相同，拆模后试件应放置在靠近相应结构构件或结构部位的适当位置，并采用相同的养护方法。\r\n"
                    + "3.按规定养护天数不少于14d，不多于60d，以控制试件累计600℃养护为界的条件（0℃以下不计）。\r\n" + "4.由混凝土工长负责试块养护工作。为防止试块在楼面施工过程中受到破坏（如拆模），"+"影响到结构的评定，可以采取焊一个钢筋笼保护试块的办法。\r\n";
            }
            obj = new object[] { str1,str2,str3,str4,str5,str6,str7,str8 };
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