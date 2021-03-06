using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmAllPlan : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);//1.定义一个delegate函数数据结构
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chaptertemp;
        private object @class;
        public FrmAllPlan(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            chaptertemp = chapter;
            @class = type;
        }

        private void FrmAllPlan_Load(object sender, EventArgs e)
        {
            {

                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn plan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                plan.HeaderText = "方案";
                plan.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn dragpump = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                dragpump.HeaderText = "拖泵";
                dragpump.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Pumpvehiclequantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Pumpvehiclequantity.HeaderText = "泵车数量";
                Pumpvehiclequantity.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Concretemixingtruck = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Concretemixingtruck.HeaderText = "混凝土搅拌运输车";
                Concretemixingtruck.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Concretemixingtruckquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Concretemixingtruckquantity.HeaderText = "混凝土搅拌运输车数量";
                Concretemixingtruckquantity.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Clothrod = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Clothrod.HeaderText = "布料杆";
                Clothrod.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Clothrodquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Clothrodquantity.HeaderText = "布料杆数量";
                Clothrodquantity.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipment = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipment.HeaderText = "振捣设备";
                Vibratingequipment.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipmentquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipmentquantity.HeaderText = "振捣设备数量";
                Vibratingequipmentquantity.Width = 80;
                Dgv_Recommend2Material.Columns.Add(plan);
                Dgv_Recommend2Material.Columns.Add(dragpump);
                Dgv_Recommend2Material.Columns.Add(Pumpvehiclequantity);
                Dgv_Recommend2Material.Columns.Add(Concretemixingtruck);
                Dgv_Recommend2Material.Columns.Add(Concretemixingtruckquantity);
                Dgv_Recommend2Material.Columns.Add(Clothrod);
                Dgv_Recommend2Material.Columns.Add(Clothrodquantity);
                Dgv_Recommend2Material.Columns.Add(Vibratingequipment);
                Dgv_Recommend2Material.Columns.Add(Vibratingequipmentquantity);
                Dgv_Recommend2Material.Rows.Add("1","HBT9050CH-5D",	"1","CLY5257GJB6","","HGR30","1","50型振捣棒","2");
                Dgv_Recommend2Material.Rows.Add("2", "HBT9050CH-5D", "2", "CLY5257GJB6", "", "HGR30", "2", "50型振捣棒", "4");
                Dgv_Recommend2Material.Rows.Add("3", "HBT60.13.90SU", "1", "CLY5169GJB", "", "HGR30", "1", "50型振捣棒", "2");
                Dgv_Recommend2Material.Rows.Add("4", "HBT60.13.90SU", "2", "CLY5169GJB", "", "HGR30", "2", "50型振捣棒", "4");
                Dgv_Recommend2Material.Rows.Add("5", "HBT9050CH-5D", "1", "CLY5257GJB6", "", "HGR40", "1", "50型振捣棒", "2");
                Dgv_Recommend2Material.Rows.Add("6", "HBT9050CH-5D", "2", "CLY5257GJB6", "", "HGR40", "2", "50型振捣棒", "4");
                Dgv_Recommend2Material.Rows.Add("7", "HBT60.13.90SU", "1", "CLY5169GJB", "", "HGR40", "1", "50型振捣棒", "2");
                Dgv_Recommend2Material.Rows.Add("8", "HBT60.13.90SU", "2", "CLY5169GJB", "", "HGR40", "2", "50型振捣棒", "4");
            }
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn plan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                plan.HeaderText = "方案";
                plan.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn pumper = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                pumper.HeaderText = "泵车";
                pumper.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn pumpernumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                pumpernumber.HeaderText = "泵车数量";
                pumpernumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixer = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixer.HeaderText = "混凝土搅拌运输车";
                truckmixer.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixernumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixernumber.HeaderText = "混凝土搅拌运输车数量";
                truckmixernumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipment = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipment.HeaderText = "振捣设备";
                Vibratingequipment.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipmentquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipmentquantity.HeaderText = "振捣设备数量";
                Vibratingequipmentquantity.Width = 80;
                Dgv_Recommend2Labor.Columns.Add(plan);
                Dgv_Recommend2Labor.Columns.Add(pumper);
                Dgv_Recommend2Labor.Columns.Add(pumpernumber);
                Dgv_Recommend2Labor.Columns.Add(truckmixer);
                Dgv_Recommend2Labor.Columns.Add(truckmixernumber);
                Dgv_Recommend2Labor.Columns.Add(Vibratingequipment);
                Dgv_Recommend2Labor.Columns.Add(Vibratingequipmentquantity);
                Dgv_Recommend2Labor.Rows.Add("1", "SY5190THB25E", "1", "CLY5257GJB6", "", "50型振捣棒", "2");
                Dgv_Recommend2Labor.Rows.Add("2", "SY5190THB25E", "2", "CLY5257GJB6", "", "50型振捣棒", "4");
                Dgv_Recommend2Labor.Rows.Add("3", "SY5271THB370C-8", "1", "CLY5257GJB6", "", "50型振捣棒", "2");
                Dgv_Recommend2Labor.Rows.Add("4", "SY5190THB25E", "2", "CLY5257GJB6", "", "50型振捣棒", "4");
                Dgv_Recommend2Labor.Rows.Add("5", "AH5384THB-47", "1", "CLY5257GJB6", "", "50型振捣棒", "2");
                Dgv_Recommend2Labor.Rows.Add("6", "AH5384THB-47", "2", "CLY5257GJB6", "", "50型振捣棒", "4");
                Dgv_Recommend2Labor.Rows.Add("7", "ZLJ5530THBK64X-6RZ", "1", "CLY5257GJB6", "", "50型振捣棒", "2");
                Dgv_Recommend2Labor.Rows.Add("8", "ZLJ5530THBK64X-6RZ", "2", "CLY5257GJB6", "", "50型振捣棒", "4");
            }
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn plan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                plan.HeaderText = "方案";
                plan.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn pumper = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                pumper.HeaderText = "泵车";
                pumper.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn pumpernumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                pumpernumber.HeaderText = "泵车数量";
                pumpernumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn drugpump = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                drugpump.HeaderText = "拖泵";
                drugpump.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn drugpumpnumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                drugpumpnumber.HeaderText = "拖泵数量";
                drugpumpnumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixer = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixer.HeaderText = "混凝土搅拌运输车";
                truckmixer.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixernumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixernumber.HeaderText = "混凝土搅拌运输车数量";
                truckmixernumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Clothrod = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Clothrod.HeaderText = "布料杆";
                Clothrod.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Clothrodnumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Clothrodnumber.HeaderText = "布料杆数量";
                Clothrodnumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipment = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipment.HeaderText = "振捣杆";
                Vibratingequipment.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipmentnumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipmentnumber.HeaderText = "振捣杆数量";
                Vibratingequipmentnumber.Width = 80;
                Dgv_Recommend2Tool.Columns.Add(plan);
                Dgv_Recommend2Tool.Columns.Add(pumper);
                Dgv_Recommend2Tool.Columns.Add(pumpernumber);
                Dgv_Recommend2Tool.Columns.Add(drugpump);
                Dgv_Recommend2Tool.Columns.Add(drugpumpnumber);
                Dgv_Recommend2Tool.Columns.Add(truckmixer);
                Dgv_Recommend2Tool.Columns.Add(truckmixernumber);
                Dgv_Recommend2Tool.Columns.Add(Clothrod);
                Dgv_Recommend2Tool.Columns.Add(Clothrodnumber);
                Dgv_Recommend2Tool.Columns.Add(Vibratingequipment);
                Dgv_Recommend2Tool.Columns.Add(Vibratingequipmentnumber);
                Dgv_Recommend2Tool.Rows.Add("1", "SY5190THB25E", "1", "HBT9050CH-5D", "CLY5257GJB6", "", "HGR30", "1", "50型振捣棒", "4");
                Dgv_Recommend2Tool.Rows.Add("2", "SY5190THB25E", "1", "HBT60.13.90SU", "CLY5257GJB6", "", "HGR30", "1", "50型振捣棒", "4");
                Dgv_Recommend2Tool.Rows.Add("3", "AH5384THB-47", "1", "HBT9050CH-5D", "CLY5257GJB6", "", "HGR40", "1", "50型振捣棒", "4");
                Dgv_Recommend2Tool.Rows.Add("4", "AH5384THB-47", "1", "HBT60.13.90SU", "CLY5257GJB6", "", "HGR40", "1", "50型振捣棒", "4");
            }
            {
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn plan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                plan.HeaderText = "方案";
                plan.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn skip = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                skip.HeaderText = "吊斗";
                skip.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn skipnumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                skipnumber.HeaderText = "吊斗数量";
                skipnumber.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn towercrane = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                towercrane.HeaderText = "塔式起重机";
                towercrane.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn towercranenumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                towercranenumber.HeaderText = "塔式起重机数量";
                towercranenumber.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixer = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixer.HeaderText = "混凝土搅拌运输车";
                truckmixer.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn truckmixernumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                truckmixernumber.HeaderText = "混凝土搅拌运输车数量";
                truckmixernumber.Width = 120;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipment = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipment.HeaderText = "振捣设备";
                Vibratingequipment.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipmentnumber = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipmentnumber.HeaderText = "振捣设备数量";
                Vibratingequipmentnumber.Width = 100;
                dataGridViewX1.Columns.Add(plan);
                dataGridViewX1.Columns.Add(skip);
                dataGridViewX1.Columns.Add(skipnumber);
                dataGridViewX1.Columns.Add(towercrane);
                dataGridViewX1.Columns.Add(towercranenumber);
                dataGridViewX1.Columns.Add(truckmixer);
                dataGridViewX1.Columns.Add(truckmixernumber);
                dataGridViewX1.Columns.Add(Vibratingequipment);
                dataGridViewX1.Columns.Add(Vibratingequipmentnumber);
                dataGridViewX1.Rows.Add("1", "0.5m³", "1", "QTZ63", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX1.Rows.Add("2", "0.5m³", "2", "QTZ63", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX1.Rows.Add("3", "1.5m³", "1", "QTZ63", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX1.Rows.Add("4", "1.5m³", "2", "QTZ63", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX1.Rows.Add("5", "3m³", "1", "QTZ125", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX1.Rows.Add("6", "3m³", "2", "QTZ125", "2", "CLY5169GJB", "", "50型振捣棒", "4");
            }
            {

                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn plan = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                plan.HeaderText = "方案";
                plan.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Skip = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Skip.HeaderText = "吊斗";
                Skip.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Skipquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Skipquantity.HeaderText = "吊斗数量";
                Skipquantity.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Truckmountedcrane = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Truckmountedcrane.HeaderText = "汽车式起重机";
                Truckmountedcrane.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Truckmountedcranequantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Truckmountedcranequantity.HeaderText = "汽车式起重机数量";
                Truckmountedcranequantity.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Concretemixertruck = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Concretemixertruck.HeaderText = "混凝土搅拌运输车";
                Concretemixertruck.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Concretemixertruckquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Concretemixertruckquantity.HeaderText = "混凝土搅拌运输车数量";
                Concretemixertruckquantity.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipment = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipment.HeaderText = "振捣设备";
                Vibratingequipment.Width = 80;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Vibratingequipmentquantity = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                Vibratingequipmentquantity.HeaderText = "振捣设备数量";
                Vibratingequipmentquantity.Width = 100;
                dataGridViewX2.Columns.Add(plan);
                dataGridViewX2.Columns.Add(Skip);
                dataGridViewX2.Columns.Add(Skipquantity);
                dataGridViewX2.Columns.Add(Truckmountedcrane);
                dataGridViewX2.Columns.Add(Truckmountedcranequantity);
                dataGridViewX2.Columns.Add(Concretemixertruck);
                dataGridViewX2.Columns.Add(Concretemixertruckquantity);
                dataGridViewX2.Columns.Add(Vibratingequipment);
                dataGridViewX2.Columns.Add(Vibratingequipmentquantity);
                dataGridViewX2.Rows.Add("1", "0.5m³", "1", "QY12DF331", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("2", "0.5m³", "2", "QY12DF331", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("3", "1.5m³", "1", "QY12DF331", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("4", "1.5m³", "2", "QY12DF331", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("5", "3m³", "1", "QY12DF331", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("6", "3m³", "2", "QY12DF331", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("7", "0.5m³", "1", "QY16HF431", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("8", "0.5m³", "2", "QY16HF431", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("9", "1.5m³", "1", "QY16HF431", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("10", "1.5m³", "2", "QY16HF431", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("11", "3m³", "1", "QY16HF431", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("12", "3m³", "2", "QY16HF431", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("13", "0.5m³", "1", "QY25K5-I", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("14", "0.5m³", "2", "QY25K5-I", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("15", "1.5m³", "1", "QY25K5-I", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("16", "1.5m³", "2", "QY25K5-I", "2", "CLY5169GJB", "", "50型振捣棒", "4");
                dataGridViewX2.Rows.Add("17", "3m³", "1", "QY25K5-I", "1", "CLY5169GJB", "", "50型振捣棒", "2");
                dataGridViewX2.Rows.Add("18", "3m³", "2", "QY25K5-I", "2", "CLY5169GJB", "", "50型振捣棒", "4");
            }
        }
    }
}