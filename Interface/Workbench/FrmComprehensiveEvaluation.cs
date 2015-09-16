using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmComprehensiveEvaluation : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private System.Collections.ArrayList templateList;


        public FrmComprehensiveEvaluation(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            templateList = contentService.GetContentTemplateByTitle(chapter.Title);

            CBX_CE_method.SelectedIndex = 0;

            #region 构造参数初值
            CB_U11.SelectedIndex = 0;
            CB_U12.SelectedIndex = 3;
            CB_U13.SelectedIndex = 3;
            CB_U14.SelectedIndex = 1;
            CB_U15.SelectedIndex = 2;
            CB_U21.SelectedIndex = 1;
            CB_U22.SelectedIndex = 2;
            CB_U23.SelectedIndex = 1;
            CB_U24.SelectedIndex = 2;
            CB_U25.SelectedIndex = 2;
            CB_U31.SelectedIndex = 2;
            CB_U32.SelectedIndex = 3;
            CB_U33.SelectedIndex = 2;
            CB_U34.SelectedIndex = 3;
            CB_U41.SelectedIndex = 0;
            CB_U42.SelectedIndex = 1;
            CB_U43.SelectedIndex = 2;
            CB_U44.SelectedIndex = 1;
            CB_U51.SelectedIndex = 2;
            CB_U52.SelectedIndex = 1;
            CB_U53.SelectedIndex = 1;
            CB_U54.SelectedIndex = 2;
            CB_U55.SelectedIndex = 2;
            CB_U61.SelectedIndex = 2;
            CB_U62.SelectedIndex = 1;
            CB_U63.SelectedIndex = 2;
            CB_U64.SelectedIndex = 3;
            CB_U65.SelectedIndex = 3;
            CB_U66.SelectedIndex = 2;
            #endregion

            #region AHP初始矩阵
            //1.工程施工风险因素判断矩阵
            dataGridViewX1.Rows.Add(6);
            dataGridViewX1.Rows[0].Cells[0].Value = "作业人员U1";
            dataGridViewX1.Rows[0].Cells[1].Value = 1;
            dataGridViewX1.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX1.Rows[1].Cells[0].Value = "机械设备U2";
            dataGridViewX1.Rows[1].Cells[2].Value = 1;
            dataGridViewX1.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX1.Rows[2].Cells[0].Value = "材料U3";
            dataGridViewX1.Rows[2].Cells[3].Value = 1;
            dataGridViewX1.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX1.Rows[3].Cells[0].Value = "施工方法U4";
            dataGridViewX1.Rows[3].Cells[4].Value = 1;
            dataGridViewX1.Rows[3].Cells[4].ReadOnly = true;

            dataGridViewX1.Rows[4].Cells[0].Value = "作业环境U5";
            dataGridViewX1.Rows[4].Cells[5].Value = 1;
            dataGridViewX1.Rows[4].Cells[5].ReadOnly = true;

            dataGridViewX1.Rows[5].Cells[0].Value = "安全管理U6";
            dataGridViewX1.Rows[5].Cells[6].Value = 1;
            dataGridViewX1.Rows[5].Cells[6].ReadOnly = true;

            //下三角
            dataGridViewX1.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX1.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX1.Rows[3].Cells[1].ReadOnly = true;
            dataGridViewX1.Rows[4].Cells[1].ReadOnly = true;
            dataGridViewX1.Rows[5].Cells[1].ReadOnly = true;

            dataGridViewX1.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX1.Rows[3].Cells[2].ReadOnly = true;
            dataGridViewX1.Rows[4].Cells[2].ReadOnly = true;
            dataGridViewX1.Rows[5].Cells[2].ReadOnly = true;

            dataGridViewX1.Rows[3].Cells[3].ReadOnly = true;
            dataGridViewX1.Rows[4].Cells[3].ReadOnly = true;
            dataGridViewX1.Rows[5].Cells[3].ReadOnly = true;

            dataGridViewX1.Rows[4].Cells[4].ReadOnly = true;
            dataGridViewX1.Rows[5].Cells[4].ReadOnly = true;

            dataGridViewX1.Rows[5].Cells[5].ReadOnly = true;

            //2.作业人员判断矩阵
            dataGridViewX2.Rows.Add(5);
            dataGridViewX2.Rows[0].Cells[0].Value = "劳务企业资质u11";
            dataGridViewX2.Rows[0].Cells[1].Value = 1;
            dataGridViewX2.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX2.Rows[1].Cells[0].Value = "作业人员技能u12";
            dataGridViewX2.Rows[1].Cells[2].Value = 1;
            dataGridViewX2.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX2.Rows[2].Cells[0].Value = "作业人员安全意识u13";
            dataGridViewX2.Rows[2].Cells[3].Value = 1;
            dataGridViewX2.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX2.Rows[3].Cells[0].Value = "特种人员持证上岗u14";
            dataGridViewX2.Rows[3].Cells[4].Value = 1;
            dataGridViewX2.Rows[3].Cells[4].ReadOnly = true;

            dataGridViewX2.Rows[4].Cells[0].Value = "作业人员身体状况u15";
            dataGridViewX2.Rows[4].Cells[5].Value = 1;
            dataGridViewX2.Rows[4].Cells[5].ReadOnly = true;

            //下三角
            dataGridViewX2.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX2.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX2.Rows[3].Cells[1].ReadOnly = true;
            dataGridViewX2.Rows[4].Cells[1].ReadOnly = true;

            dataGridViewX2.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX2.Rows[3].Cells[2].ReadOnly = true;
            dataGridViewX2.Rows[4].Cells[2].ReadOnly = true;

            dataGridViewX2.Rows[3].Cells[3].ReadOnly = true;
            dataGridViewX2.Rows[4].Cells[3].ReadOnly = true;

            dataGridViewX2.Rows[4].Cells[4].ReadOnly = true;

            //3.机械设备判断矩阵
            dataGridViewX3.Rows.Add(5);
            dataGridViewX3.Rows[0].Cells[0].Value = "机械设备性能u21";
            dataGridViewX3.Rows[0].Cells[1].Value = 1;
            dataGridViewX3.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX3.Rows[1].Cells[0].Value = "大型机械设备安装、拆除u22";
            dataGridViewX3.Rows[1].Cells[2].Value = 1;
            dataGridViewX3.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX3.Rows[2].Cells[0].Value = "特种设备检测、验收u23";
            dataGridViewX3.Rows[2].Cells[3].Value = 1;
            dataGridViewX3.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX3.Rows[3].Cells[0].Value = "机械设备临时用电u24";
            dataGridViewX3.Rows[3].Cells[4].Value = 1;
            dataGridViewX3.Rows[3].Cells[4].ReadOnly = true;

            dataGridViewX3.Rows[4].Cells[0].Value = "机械设备维修保养u25";
            dataGridViewX3.Rows[4].Cells[5].Value = 1;
            dataGridViewX3.Rows[4].Cells[5].ReadOnly = true;

            //下三角
            dataGridViewX3.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX3.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX3.Rows[3].Cells[1].ReadOnly = true;
            dataGridViewX3.Rows[4].Cells[1].ReadOnly = true;

            dataGridViewX3.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX3.Rows[3].Cells[2].ReadOnly = true;
            dataGridViewX3.Rows[4].Cells[2].ReadOnly = true;

            dataGridViewX3.Rows[3].Cells[3].ReadOnly = true;
            dataGridViewX3.Rows[4].Cells[3].ReadOnly = true;

            dataGridViewX3.Rows[4].Cells[4].ReadOnly = true;

            //4.材料判断矩阵
            dataGridViewX4.Rows.Add(4);
            dataGridViewX4.Rows[0].Cells[0].Value = "材料合格证u31";
            dataGridViewX4.Rows[0].Cells[1].Value = 1;
            dataGridViewX4.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX4.Rows[1].Cells[0].Value = "材料检测u32";
            dataGridViewX4.Rows[1].Cells[2].Value = 1;
            dataGridViewX4.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX4.Rows[2].Cells[0].Value = "材料运输u33";
            dataGridViewX4.Rows[2].Cells[3].Value = 1;
            dataGridViewX4.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX4.Rows[3].Cells[0].Value = "材料制作、堆放u34";
            dataGridViewX4.Rows[3].Cells[4].Value = 1;
            dataGridViewX4.Rows[3].Cells[4].ReadOnly = true;

            //下三角
            dataGridViewX4.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX4.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX4.Rows[3].Cells[1].ReadOnly = true;

            dataGridViewX4.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX4.Rows[3].Cells[2].ReadOnly = true;

            dataGridViewX4.Rows[3].Cells[3].ReadOnly = true;

            //5.施工方法判断矩阵
            dataGridViewX5.Rows.Add(4);
            dataGridViewX5.Rows[0].Cells[0].Value = "企业资质u41";
            dataGridViewX5.Rows[0].Cells[1].Value = 1;
            dataGridViewX5.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX5.Rows[1].Cells[0].Value = "施工工艺u42";
            dataGridViewX5.Rows[1].Cells[2].Value = 1;
            dataGridViewX5.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX5.Rows[2].Cells[0].Value = "设计、施工方案及实施u43";
            dataGridViewX5.Rows[2].Cells[3].Value = 1;
            dataGridViewX5.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX5.Rows[3].Cells[0].Value = "施工方案专家论证u44";
            dataGridViewX5.Rows[3].Cells[4].Value = 1;
            dataGridViewX5.Rows[3].Cells[4].ReadOnly = true;

            //下三角
            dataGridViewX5.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX5.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX5.Rows[3].Cells[1].ReadOnly = true;

            dataGridViewX5.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX5.Rows[3].Cells[2].ReadOnly = true;

            dataGridViewX5.Rows[3].Cells[3].ReadOnly = true;

            //6.作业条件判断矩阵
            dataGridViewX6.Rows.Add(5);
            dataGridViewX6.Rows[0].Cells[0].Value = "作业条件u51";
            dataGridViewX6.Rows[0].Cells[1].Value = 1;
            dataGridViewX6.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX6.Rows[1].Cells[0].Value = "周围环境（含地质条件）u52";
            dataGridViewX6.Rows[1].Cells[2].Value = 1;
            dataGridViewX6.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX6.Rows[2].Cells[0].Value = "气候情况u53";
            dataGridViewX6.Rows[2].Cells[3].Value = 1;
            dataGridViewX6.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX6.Rows[3].Cells[0].Value = "安全防护、标志u54";
            dataGridViewX6.Rows[3].Cells[4].Value = 1;
            dataGridViewX6.Rows[3].Cells[4].ReadOnly = true;

            dataGridViewX6.Rows[4].Cells[0].Value = "主要施工技术参数u55";
            dataGridViewX6.Rows[4].Cells[5].Value = 1;
            dataGridViewX6.Rows[4].Cells[5].ReadOnly = true;

            //下三角
            dataGridViewX6.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX6.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX6.Rows[3].Cells[1].ReadOnly = true;
            dataGridViewX6.Rows[4].Cells[1].ReadOnly = true;

            dataGridViewX6.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX6.Rows[3].Cells[2].ReadOnly = true;
            dataGridViewX6.Rows[4].Cells[2].ReadOnly = true;

            dataGridViewX6.Rows[3].Cells[3].ReadOnly = true;
            dataGridViewX6.Rows[4].Cells[3].ReadOnly = true;

            dataGridViewX6.Rows[4].Cells[4].ReadOnly = true;

            //7.安全管理判断矩阵
            dataGridViewX7.Rows.Add(6);
            dataGridViewX7.Rows[0].Cells[0].Value = "安全管理体系u61";
            dataGridViewX7.Rows[0].Cells[1].Value = 1;
            dataGridViewX7.Rows[0].Cells[1].ReadOnly = true;

            dataGridViewX7.Rows[1].Cells[0].Value = "项目安全人员配备u62";
            dataGridViewX7.Rows[1].Cells[2].Value = 1;
            dataGridViewX7.Rows[1].Cells[2].ReadOnly = true;

            dataGridViewX7.Rows[2].Cells[0].Value = "安全管理目标、制度u63";
            dataGridViewX7.Rows[2].Cells[3].Value = 1;
            dataGridViewX7.Rows[2].Cells[3].ReadOnly = true;

            dataGridViewX7.Rows[3].Cells[0].Value = "安全教育、交底u64";
            dataGridViewX7.Rows[3].Cells[4].Value = 1;
            dataGridViewX7.Rows[3].Cells[4].ReadOnly = true;

            dataGridViewX7.Rows[4].Cells[0].Value = "班前安全活动u65";
            dataGridViewX7.Rows[4].Cells[5].Value = 1;
            dataGridViewX7.Rows[4].Cells[5].ReadOnly = true;

            dataGridViewX7.Rows[5].Cells[0].Value = "安全监督检查、验收u66";
            dataGridViewX7.Rows[5].Cells[6].Value = 1;
            dataGridViewX7.Rows[5].Cells[6].ReadOnly = true;

            //下三角
            dataGridViewX7.Rows[1].Cells[1].ReadOnly = true;
            dataGridViewX7.Rows[2].Cells[1].ReadOnly = true;
            dataGridViewX7.Rows[3].Cells[1].ReadOnly = true;
            dataGridViewX7.Rows[4].Cells[1].ReadOnly = true;
            dataGridViewX7.Rows[5].Cells[1].ReadOnly = true;

            dataGridViewX7.Rows[2].Cells[2].ReadOnly = true;
            dataGridViewX7.Rows[3].Cells[2].ReadOnly = true;
            dataGridViewX7.Rows[4].Cells[2].ReadOnly = true;
            dataGridViewX7.Rows[5].Cells[2].ReadOnly = true;

            dataGridViewX7.Rows[3].Cells[3].ReadOnly = true;
            dataGridViewX7.Rows[4].Cells[3].ReadOnly = true;
            dataGridViewX7.Rows[5].Cells[3].ReadOnly = true;

            dataGridViewX7.Rows[4].Cells[4].ReadOnly = true;
            dataGridViewX7.Rows[5].Cells[4].ReadOnly = true;

            dataGridViewX7.Rows[5].Cells[5].ReadOnly = true;
            #endregion

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[0].Cells[2].Value), 2);
            dataGridViewX1.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[0].Cells[3].Value), 2);
            dataGridViewX1.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[0].Cells[4].Value), 2);
            dataGridViewX1.Rows[4].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[0].Cells[5].Value), 2);
            dataGridViewX1.Rows[5].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[0].Cells[6].Value), 2);

            dataGridViewX1.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[1].Cells[3].Value), 2);
            dataGridViewX1.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[1].Cells[4].Value), 2);
            dataGridViewX1.Rows[4].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[1].Cells[5].Value), 2);
            dataGridViewX1.Rows[5].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[1].Cells[6].Value), 2);

            dataGridViewX1.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[2].Cells[4].Value), 2);
            dataGridViewX1.Rows[4].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[2].Cells[5].Value), 2);
            dataGridViewX1.Rows[5].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[2].Cells[6].Value), 2);

            dataGridViewX1.Rows[4].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[3].Cells[5].Value), 2);
            dataGridViewX1.Rows[5].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[3].Cells[6].Value), 2);

            dataGridViewX1.Rows[5].Cells[5].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX1.Rows[4].Cells[6].Value), 2);

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dataGridViewX2.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[0].Cells[2].Value), 2);
            dataGridViewX2.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[0].Cells[3].Value), 2);
            dataGridViewX2.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[0].Cells[4].Value), 2);
            dataGridViewX2.Rows[4].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[0].Cells[5].Value), 2);

            dataGridViewX2.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[1].Cells[3].Value), 2);
            dataGridViewX2.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[1].Cells[4].Value), 2);
            dataGridViewX2.Rows[4].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[1].Cells[5].Value), 2);

            dataGridViewX2.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[2].Cells[4].Value), 2);
            dataGridViewX2.Rows[4].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[2].Cells[5].Value), 2);

            dataGridViewX2.Rows[4].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX2.Rows[3].Cells[5].Value), 2);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridViewX3.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[0].Cells[2].Value), 2);
            dataGridViewX3.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[0].Cells[3].Value), 2);
            dataGridViewX3.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[0].Cells[4].Value), 2);
            dataGridViewX3.Rows[4].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[0].Cells[5].Value), 2);

            dataGridViewX3.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[1].Cells[3].Value), 2);
            dataGridViewX3.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[1].Cells[4].Value), 2);
            dataGridViewX3.Rows[4].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[1].Cells[5].Value), 2);

            dataGridViewX3.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[2].Cells[4].Value), 2);
            dataGridViewX3.Rows[4].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[2].Cells[5].Value), 2);

            dataGridViewX3.Rows[4].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX3.Rows[3].Cells[5].Value), 2);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            dataGridViewX4.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[0].Cells[2].Value), 2);
            dataGridViewX4.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[0].Cells[3].Value), 2);
            dataGridViewX4.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[0].Cells[4].Value), 2);

            dataGridViewX4.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[1].Cells[3].Value), 2);
            dataGridViewX4.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[1].Cells[4].Value), 2);

            dataGridViewX4.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX4.Rows[2].Cells[4].Value), 2);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            dataGridViewX5.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[0].Cells[2].Value), 2);
            dataGridViewX5.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[0].Cells[3].Value), 2);
            dataGridViewX5.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[0].Cells[4].Value), 2);

            dataGridViewX5.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[1].Cells[3].Value), 2);
            dataGridViewX5.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[1].Cells[4].Value), 2);

            dataGridViewX5.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX5.Rows[2].Cells[4].Value), 2);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            dataGridViewX6.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[0].Cells[2].Value), 2);
            dataGridViewX6.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[0].Cells[3].Value), 2);
            dataGridViewX6.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[0].Cells[4].Value), 2);
            dataGridViewX6.Rows[4].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[0].Cells[5].Value), 2);

            dataGridViewX6.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[1].Cells[3].Value), 2);
            dataGridViewX6.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[1].Cells[4].Value), 2);
            dataGridViewX6.Rows[4].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[1].Cells[5].Value), 2);

            dataGridViewX6.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[2].Cells[4].Value), 2);
            dataGridViewX6.Rows[4].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[2].Cells[5].Value), 2);

            dataGridViewX6.Rows[4].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX6.Rows[3].Cells[5].Value), 2);
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            dataGridViewX7.Rows[1].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[0].Cells[2].Value), 2);
            dataGridViewX7.Rows[2].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[0].Cells[3].Value), 2);
            dataGridViewX7.Rows[3].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[0].Cells[4].Value), 2);
            dataGridViewX7.Rows[4].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[0].Cells[5].Value), 2);
            dataGridViewX7.Rows[5].Cells[1].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[0].Cells[6].Value), 2);

            dataGridViewX7.Rows[2].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[1].Cells[3].Value), 2);
            dataGridViewX7.Rows[3].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[1].Cells[4].Value), 2);
            dataGridViewX7.Rows[4].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[1].Cells[5].Value), 2);
            dataGridViewX7.Rows[5].Cells[2].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[1].Cells[6].Value), 2);

            dataGridViewX7.Rows[3].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[2].Cells[4].Value), 2);
            dataGridViewX7.Rows[4].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[2].Cells[5].Value), 2);
            dataGridViewX7.Rows[5].Cells[3].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[2].Cells[6].Value), 2);

            dataGridViewX7.Rows[4].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[3].Cells[5].Value), 2);
            dataGridViewX7.Rows[5].Cells[4].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[3].Cells[6].Value), 2);

            dataGridViewX7.Rows[5].Cells[5].Value = Math.Round(1 / Convert.ToDouble(dataGridViewX7.Rows[4].Cells[6].Value), 2);
        }

        private void buttonX1_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX2_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX3_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX4_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX5_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX6_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void buttonX7_help_Click(object sender, EventArgs e)
        {
            FrmShowChart showchart = new FrmShowChart(14);
            showchart.ShowDialog();
        }

        private void Btn_CESubmit_Click(object sender, EventArgs e)
        {
            Framework.Entity.Template item = new Framework.Entity.Template();
            string itemtext = "";
            object[] obj = new object[] { };

            #region 公用参数

            #region 构造参数
            double[] socre = new double[] { 1.0, 0.8, 0.6, 0.4 };
            double u11, u12, u13, u14, u15, u21, u22, u23, u24, u25, u31, u32, u33, u34, u41, u42, u43, u44, u51, u52, u53, u54, u55, u61, u62, u63, u64, u65, u66;

            u11 = socre[CB_U11.SelectedIndex];
            u12 = socre[CB_U12.SelectedIndex];
            u13 = socre[CB_U13.SelectedIndex];
            u14 = socre[CB_U14.SelectedIndex];
            u15 = socre[CB_U15.SelectedIndex];
            u21 = socre[CB_U21.SelectedIndex];
            u22 = socre[CB_U22.SelectedIndex];
            u23 = socre[CB_U23.SelectedIndex];
            u24 = socre[CB_U24.SelectedIndex];
            u25 = socre[CB_U25.SelectedIndex];
            u31 = socre[CB_U31.SelectedIndex];
            u32 = socre[CB_U32.SelectedIndex];
            u33 = socre[CB_U33.SelectedIndex];
            u34 = socre[CB_U34.SelectedIndex];
            u41 = socre[CB_U41.SelectedIndex];
            u42 = socre[CB_U42.SelectedIndex];
            u43 = socre[CB_U43.SelectedIndex];
            u44 = socre[CB_U44.SelectedIndex];
            u51 = socre[CB_U51.SelectedIndex];
            u52 = socre[CB_U52.SelectedIndex];
            u53 = socre[CB_U53.SelectedIndex];
            u54 = socre[CB_U54.SelectedIndex];
            u55 = socre[CB_U55.SelectedIndex];
            u61 = socre[CB_U61.SelectedIndex];
            u62 = socre[CB_U62.SelectedIndex];
            u63 = socre[CB_U63.SelectedIndex];
            u64 = socre[CB_U64.SelectedIndex];
            u65 = socre[CB_U65.SelectedIndex];
            u66 = socre[CB_U66.SelectedIndex];
            #endregion

            #region 工程施工风险因素判断矩阵
            double a12, a13, a14, a15, a16, a23, a24, a25, a26, a34, a35, a36, a45, a46, a56,
                a21, a31, a32, a41, a42, a43, a51, a52, a53, a54, a61, a62, a63, a64, a65;

            a12 = Convert.ToDouble(dataGridViewX1.Rows[0].Cells[2].Value);
            a13 = Convert.ToDouble(dataGridViewX1.Rows[0].Cells[3].Value);
            a14 = Convert.ToDouble(dataGridViewX1.Rows[0].Cells[4].Value);
            a15 = Convert.ToDouble(dataGridViewX1.Rows[0].Cells[5].Value);
            a16 = Convert.ToDouble(dataGridViewX1.Rows[0].Cells[6].Value);
            a21 = Convert.ToDouble(dataGridViewX1.Rows[1].Cells[1].Value);
            a31 = Convert.ToDouble(dataGridViewX1.Rows[2].Cells[1].Value);
            a41 = Convert.ToDouble(dataGridViewX1.Rows[3].Cells[1].Value);
            a51 = Convert.ToDouble(dataGridViewX1.Rows[4].Cells[1].Value);
            a61 = Convert.ToDouble(dataGridViewX1.Rows[5].Cells[1].Value);

            a23 = Convert.ToDouble(dataGridViewX1.Rows[1].Cells[3].Value);
            a24 = Convert.ToDouble(dataGridViewX1.Rows[1].Cells[4].Value);
            a25 = Convert.ToDouble(dataGridViewX1.Rows[1].Cells[5].Value);
            a26 = Convert.ToDouble(dataGridViewX1.Rows[1].Cells[6].Value);
            a32 = Convert.ToDouble(dataGridViewX1.Rows[2].Cells[2].Value);
            a42 = Convert.ToDouble(dataGridViewX1.Rows[3].Cells[2].Value);
            a52 = Convert.ToDouble(dataGridViewX1.Rows[4].Cells[2].Value);
            a62 = Convert.ToDouble(dataGridViewX1.Rows[5].Cells[2].Value);

            a34 = Convert.ToDouble(dataGridViewX1.Rows[2].Cells[4].Value);
            a35 = Convert.ToDouble(dataGridViewX1.Rows[2].Cells[5].Value);
            a36 = Convert.ToDouble(dataGridViewX1.Rows[2].Cells[6].Value);
            a43 = Convert.ToDouble(dataGridViewX1.Rows[3].Cells[3].Value);
            a53 = Convert.ToDouble(dataGridViewX1.Rows[4].Cells[3].Value);
            a63 = Convert.ToDouble(dataGridViewX1.Rows[5].Cells[3].Value);

            a45 = Convert.ToDouble(dataGridViewX1.Rows[3].Cells[5].Value);
            a46 = Convert.ToDouble(dataGridViewX1.Rows[3].Cells[6].Value);
            a54 = Convert.ToDouble(dataGridViewX1.Rows[4].Cells[4].Value);
            a64 = Convert.ToDouble(dataGridViewX1.Rows[5].Cells[4].Value);

            a56 = Convert.ToDouble(dataGridViewX1.Rows[4].Cells[6].Value);
            a65 = Convert.ToDouble(dataGridViewX1.Rows[5].Cells[5].Value);

            double A1, A2, A3, A4, A5, A6, w1, w2, w3, w4, w5, w6, wa11, wa12, wa13, wa14, wa15, wa16, wa21, wa22, wa23, wa24, wa25, wa26, wa31, wa32,
                    wa33, wa34, wa35, wa36, wa41, wa42, wa43, wa44, wa45, wa46, wa51, wa52, wa53, wa54, wa55, wa56, wa61, wa62,
                    wa63, wa64, wa65, wa66;
            #endregion

            #region 作业人员
            double b12, b13, b14, b15, b21, b23, b24, b25, b31, b32, b34, b35, b41, b42, b43, b45,
                   b51, b52, b53, b54;

            b12 = Convert.ToDouble(dataGridViewX2.Rows[0].Cells[2].Value);
            b13 = Convert.ToDouble(dataGridViewX2.Rows[0].Cells[3].Value);
            b14 = Convert.ToDouble(dataGridViewX2.Rows[0].Cells[4].Value);
            b15 = Convert.ToDouble(dataGridViewX2.Rows[0].Cells[5].Value);
            b21 = Convert.ToDouble(dataGridViewX2.Rows[1].Cells[1].Value);
            b31 = Convert.ToDouble(dataGridViewX2.Rows[2].Cells[1].Value);
            b41 = Convert.ToDouble(dataGridViewX2.Rows[3].Cells[1].Value);
            b51 = Convert.ToDouble(dataGridViewX2.Rows[4].Cells[1].Value);

            b23 = Convert.ToDouble(dataGridViewX2.Rows[1].Cells[3].Value);
            b24 = Convert.ToDouble(dataGridViewX2.Rows[1].Cells[4].Value);
            b25 = Convert.ToDouble(dataGridViewX2.Rows[1].Cells[5].Value);
            b32 = Convert.ToDouble(dataGridViewX2.Rows[2].Cells[2].Value);
            b42 = Convert.ToDouble(dataGridViewX2.Rows[3].Cells[2].Value);
            b52 = Convert.ToDouble(dataGridViewX2.Rows[4].Cells[2].Value);

            b34 = Convert.ToDouble(dataGridViewX2.Rows[2].Cells[4].Value);
            b35 = Convert.ToDouble(dataGridViewX2.Rows[2].Cells[5].Value);
            b43 = Convert.ToDouble(dataGridViewX2.Rows[3].Cells[3].Value);
            b53 = Convert.ToDouble(dataGridViewX2.Rows[4].Cells[3].Value);

            b45 = Convert.ToDouble(dataGridViewX2.Rows[3].Cells[5].Value);
            b54 = Convert.ToDouble(dataGridViewX2.Rows[4].Cells[4].Value);

            double B1, B2, B3, B4, B5, Wb1, Wb2, Wb3, Wb4, Wb5, Cb;
            #endregion

            #region 机械设备
            double c12, c13, c14, c15, c21, c23, c24, c25, c31, c32, c34, c35, c41, c42, c43, c45,
                    c51, c52, c53, c54;

            c12 = Convert.ToDouble(dataGridViewX3.Rows[0].Cells[2].Value);
            c13 = Convert.ToDouble(dataGridViewX3.Rows[0].Cells[3].Value);
            c14 = Convert.ToDouble(dataGridViewX3.Rows[0].Cells[4].Value);
            c15 = Convert.ToDouble(dataGridViewX3.Rows[0].Cells[5].Value);
            c21 = Convert.ToDouble(dataGridViewX3.Rows[1].Cells[1].Value);
            c31 = Convert.ToDouble(dataGridViewX3.Rows[2].Cells[1].Value);
            c41 = Convert.ToDouble(dataGridViewX3.Rows[3].Cells[1].Value);
            c51 = Convert.ToDouble(dataGridViewX3.Rows[4].Cells[1].Value);

            c23 = Convert.ToDouble(dataGridViewX3.Rows[1].Cells[3].Value);
            c24 = Convert.ToDouble(dataGridViewX3.Rows[1].Cells[4].Value);
            c25 = Convert.ToDouble(dataGridViewX3.Rows[1].Cells[5].Value);
            c32 = Convert.ToDouble(dataGridViewX3.Rows[2].Cells[2].Value);
            c42 = Convert.ToDouble(dataGridViewX3.Rows[3].Cells[2].Value);
            c52 = Convert.ToDouble(dataGridViewX3.Rows[4].Cells[2].Value);

            c34 = Convert.ToDouble(dataGridViewX3.Rows[2].Cells[4].Value);
            c35 = Convert.ToDouble(dataGridViewX3.Rows[2].Cells[5].Value);
            c43 = Convert.ToDouble(dataGridViewX3.Rows[3].Cells[3].Value);
            c53 = Convert.ToDouble(dataGridViewX3.Rows[4].Cells[3].Value);

            c45 = Convert.ToDouble(dataGridViewX3.Rows[3].Cells[5].Value);
            c54 = Convert.ToDouble(dataGridViewX3.Rows[4].Cells[4].Value);

            double C1, C2, C3, C4, C5, Wc1, Wc2, Wc3, Wc4, Wc5, Cc;
            #endregion

            #region 材料
            double d12, d13, d14, d21, d23, d24, d31, d32, d34, d41, d42, d43;

            d12 = Convert.ToDouble(dataGridViewX4.Rows[0].Cells[2].Value);
            d13 = Convert.ToDouble(dataGridViewX4.Rows[0].Cells[3].Value);
            d14 = Convert.ToDouble(dataGridViewX4.Rows[0].Cells[4].Value);
            d21 = Convert.ToDouble(dataGridViewX4.Rows[1].Cells[1].Value);
            d31 = Convert.ToDouble(dataGridViewX4.Rows[2].Cells[1].Value);
            d41 = Convert.ToDouble(dataGridViewX4.Rows[3].Cells[1].Value);

            d23 = Convert.ToDouble(dataGridViewX4.Rows[1].Cells[3].Value);
            d24 = Convert.ToDouble(dataGridViewX4.Rows[1].Cells[4].Value);
            d32 = Convert.ToDouble(dataGridViewX4.Rows[2].Cells[2].Value);
            d42 = Convert.ToDouble(dataGridViewX4.Rows[3].Cells[2].Value);

            d34 = Convert.ToDouble(dataGridViewX4.Rows[2].Cells[4].Value);
            d43 = Convert.ToDouble(dataGridViewX4.Rows[3].Cells[3].Value);

            double D1, D2, D3, D4, Wd1, Wd2, Wd3, Wd4, Cd;
            #endregion

            #region 施工方法
            double e12, e13, e14, e21, e23, e24, e31, e32, e34, e41, e42, e43;

            e12 = Convert.ToDouble(dataGridViewX5.Rows[0].Cells[2].Value);
            e13 = Convert.ToDouble(dataGridViewX5.Rows[0].Cells[3].Value);
            e14 = Convert.ToDouble(dataGridViewX5.Rows[0].Cells[4].Value);
            e21 = Convert.ToDouble(dataGridViewX5.Rows[1].Cells[1].Value);
            e31 = Convert.ToDouble(dataGridViewX5.Rows[2].Cells[1].Value);
            e41 = Convert.ToDouble(dataGridViewX5.Rows[3].Cells[1].Value);

            e23 = Convert.ToDouble(dataGridViewX5.Rows[1].Cells[3].Value);
            e24 = Convert.ToDouble(dataGridViewX5.Rows[1].Cells[4].Value);
            e32 = Convert.ToDouble(dataGridViewX5.Rows[2].Cells[2].Value);
            e42 = Convert.ToDouble(dataGridViewX5.Rows[3].Cells[2].Value);

            e34 = Convert.ToDouble(dataGridViewX5.Rows[2].Cells[4].Value);
            e43 = Convert.ToDouble(dataGridViewX5.Rows[3].Cells[3].Value);

            double E1, E2, E3, E4, We1, We2, We3, We4, Ce;
            #endregion

            #region 作业条件
            double f12, f13, f14, f15, f21, f23, f24, f25, f31, f32, f34, f35, f41, f42, f43, f45, f51, f52, f53, f54;

            f12 = Convert.ToDouble(dataGridViewX6.Rows[0].Cells[2].Value);
            f13 = Convert.ToDouble(dataGridViewX6.Rows[0].Cells[3].Value);
            f14 = Convert.ToDouble(dataGridViewX6.Rows[0].Cells[4].Value);
            f15 = Convert.ToDouble(dataGridViewX6.Rows[0].Cells[5].Value);
            f21 = Convert.ToDouble(dataGridViewX6.Rows[1].Cells[1].Value);
            f31 = Convert.ToDouble(dataGridViewX6.Rows[2].Cells[1].Value);
            f41 = Convert.ToDouble(dataGridViewX6.Rows[3].Cells[1].Value);
            f51 = Convert.ToDouble(dataGridViewX6.Rows[4].Cells[1].Value);

            f23 = Convert.ToDouble(dataGridViewX6.Rows[1].Cells[3].Value);
            f24 = Convert.ToDouble(dataGridViewX6.Rows[1].Cells[4].Value);
            f25 = Convert.ToDouble(dataGridViewX6.Rows[1].Cells[5].Value);
            f32 = Convert.ToDouble(dataGridViewX6.Rows[2].Cells[2].Value);
            f42 = Convert.ToDouble(dataGridViewX6.Rows[3].Cells[2].Value);
            f52 = Convert.ToDouble(dataGridViewX6.Rows[4].Cells[2].Value);

            f34 = Convert.ToDouble(dataGridViewX6.Rows[2].Cells[4].Value);
            f35 = Convert.ToDouble(dataGridViewX6.Rows[2].Cells[5].Value);
            f43 = Convert.ToDouble(dataGridViewX6.Rows[3].Cells[3].Value);
            f53 = Convert.ToDouble(dataGridViewX6.Rows[4].Cells[3].Value);

            f45 = Convert.ToDouble(dataGridViewX6.Rows[3].Cells[5].Value);
            f54 = Convert.ToDouble(dataGridViewX6.Rows[4].Cells[4].Value);

            double F1, F2, F3, F4, F5, Wf1, Wf2, Wf3, Wf4, Wf5, Cf;
            #endregion

            #region 安全管理
            double g12, g13, g14, g15, g16, g23, g24, g25, g26, g34, g35, g36, g45, g46, g56,
                    g21, g31, g32, g41, g42, g43, g51, g52, g53, g54, g61, g62, g63, g64, g65;

            g12 = Convert.ToDouble(dataGridViewX7.Rows[0].Cells[2].Value);
            g13 = Convert.ToDouble(dataGridViewX7.Rows[0].Cells[3].Value);
            g14 = Convert.ToDouble(dataGridViewX7.Rows[0].Cells[4].Value);
            g15 = Convert.ToDouble(dataGridViewX7.Rows[0].Cells[5].Value);
            g16 = Convert.ToDouble(dataGridViewX7.Rows[0].Cells[6].Value);
            g21 = Convert.ToDouble(dataGridViewX7.Rows[1].Cells[1].Value);
            g31 = Convert.ToDouble(dataGridViewX7.Rows[2].Cells[1].Value);
            g41 = Convert.ToDouble(dataGridViewX7.Rows[3].Cells[1].Value);
            g51 = Convert.ToDouble(dataGridViewX7.Rows[4].Cells[1].Value);
            g61 = Convert.ToDouble(dataGridViewX7.Rows[5].Cells[1].Value);

            g23 = Convert.ToDouble(dataGridViewX7.Rows[1].Cells[3].Value);
            g24 = Convert.ToDouble(dataGridViewX7.Rows[1].Cells[4].Value);
            g25 = Convert.ToDouble(dataGridViewX7.Rows[1].Cells[5].Value);
            g26 = Convert.ToDouble(dataGridViewX7.Rows[1].Cells[6].Value);
            g32 = Convert.ToDouble(dataGridViewX7.Rows[2].Cells[2].Value);
            g42 = Convert.ToDouble(dataGridViewX7.Rows[3].Cells[2].Value);
            g52 = Convert.ToDouble(dataGridViewX7.Rows[4].Cells[2].Value);
            g62 = Convert.ToDouble(dataGridViewX7.Rows[5].Cells[2].Value);

            g34 = Convert.ToDouble(dataGridViewX7.Rows[2].Cells[4].Value);
            g35 = Convert.ToDouble(dataGridViewX7.Rows[2].Cells[5].Value);
            g36 = Convert.ToDouble(dataGridViewX7.Rows[2].Cells[6].Value);
            g43 = Convert.ToDouble(dataGridViewX7.Rows[3].Cells[3].Value);
            g53 = Convert.ToDouble(dataGridViewX7.Rows[4].Cells[3].Value);
            g63 = Convert.ToDouble(dataGridViewX7.Rows[5].Cells[3].Value);

            g45 = Convert.ToDouble(dataGridViewX7.Rows[3].Cells[5].Value);
            g46 = Convert.ToDouble(dataGridViewX7.Rows[3].Cells[6].Value);
            g54 = Convert.ToDouble(dataGridViewX7.Rows[4].Cells[4].Value);
            g64 = Convert.ToDouble(dataGridViewX7.Rows[5].Cells[4].Value);

            g56 = Convert.ToDouble(dataGridViewX7.Rows[4].Cells[6].Value);
            g65 = Convert.ToDouble(dataGridViewX7.Rows[5].Cells[5].Value);

            double G1, G2, G3, G4, G5, G6, Wg1, Wg2, Wg3, Wg4, Wg5, Wg6, Cg;
            #endregion

            #endregion


            if (CBX_CE_method.SelectedIndex == 0)//AHP和法
            {
                itemtext = "AHP和法";

                #region 工程施工风险因素判断矩阵
                A1 = Math.Round(Math.Pow(1 * a12 * a13 * a14 * a15 * a16, 1f / 6), 2);
                A2 = Math.Round(Math.Pow(a21 * 1 * a23 * a24 * a25 * a26, 1f / 6), 2);
                A3 = Math.Round(Math.Pow(a31 * a32 * 1 * a34 * a35 * a36, 1f / 6), 2);
                A4 = Math.Round(Math.Pow(a41 * a42 * a43 * 1 * a45 * a46, 1f / 6), 2);
                A5 = Math.Round(Math.Pow(a51 * a52 * a53 * a54 * 1 * a56, 1f / 6), 2);
                A6 = Math.Round(Math.Pow(a61 * a62 * a63 * a64 * a65 * 1, 1f / 6), 2);

                wa11 = Math.Round(1 / A1, 2);
                wa12 = Math.Round(a12 / A1, 2);
                wa13 = Math.Round(a13 / A1, 2);
                wa14 = Math.Round(a14 / A1, 2);
                wa15 = Math.Round(a15 / A1, 2);
                wa16 = Math.Round(a16 / A1, 2);
                w1 = Math.Round((wa11 + wa12 + wa13 + wa14 + wa15 + wa16) / 6, 2);
                wa21 = Math.Round(a21 / A2, 2);
                wa22 = Math.Round(1 / A2, 2);
                wa23 = Math.Round(a23 / A2, 2);
                wa24 = Math.Round(a24 / A2, 2);
                wa25 = Math.Round(a25 / A2, 2);
                wa26 = Math.Round(a26 / A2, 2);
                w2 = Math.Round((wa21 + wa22 + wa23 + wa24 + wa25 + wa26) / 6, 2);
                wa31 = Math.Round(a31 / A3, 2);
                wa32 = Math.Round(a32 / A3, 2);
                wa33 = Math.Round(1 / A3, 2);
                wa34 = Math.Round(a34 / A3, 2);
                wa35 = Math.Round(a35 / A3, 2);
                wa36 = Math.Round(a36 / A3, 2);
                w3 = Math.Round((wa31 + wa32 + wa33 + wa34 + wa35 + wa36) / 6, 2);
                wa41 = Math.Round(a41 / A4, 2);
                wa42 = Math.Round(a42 / A4, 2);
                wa43 = Math.Round(a43 / A4, 2);
                wa44 = Math.Round(1 / A4, 2);
                wa45 = Math.Round(a45 / A4, 2);
                wa46 = Math.Round(a46 / A4, 2);
                w4 = Math.Round((wa41 + wa42 + wa43 + wa44 + wa45 + wa46) / 6, 2);
                wa51 = Math.Round(a51 / A5, 2);
                wa52 = Math.Round(a52 / A5, 2);
                wa53 = Math.Round(a53 / A5, 2);
                wa54 = Math.Round(a54 / A5, 2);
                wa55 = Math.Round(1 / A5, 2);
                wa56 = Math.Round(a56 / A5, 2);
                w5 = Math.Round((wa51 + wa52 + wa53 + wa54 + wa55 + wa56) / 6, 2);
                wa61 = Math.Round(a61 / A6, 2);
                wa62 = Math.Round(a62 / A6, 2);
                wa63 = Math.Round(a63 / A6, 2);
                wa64 = Math.Round(a64 / A6, 2);
                wa65 = Math.Round(a65 / A6, 2);
                wa66 = Math.Round(1 / A6, 2);
                w6 = Math.Round((wa61 + wa62 + wa63 + wa64 + wa65 + wa66) / 6, 2);
                #endregion

                #region 作业人员

                B1 = Math.Round(Math.Pow(1 * b12 * b13 * b14 * b15, 1f / 5), 2);
                B2 = Math.Round(Math.Pow(b21 * 1 * b23 * b24 * b25, 1f / 5), 2);
                B3 = Math.Round(Math.Pow(b31 * b32 * 1 * b34 * b35, 1f / 5), 2);
                B4 = Math.Round(Math.Pow(b41 * b42 * b43 * 1 * b45, 1f / 5), 2);
                B5 = Math.Round(Math.Pow(b51 * b52 * b53 * b54 * 1, 1f / 5), 2);
                Wb1 = Math.Round((1 + b12 + b13 + b14 + b15) / B1 / 5, 2);
                Wb2 = Math.Round((b21 + 1 + b23 + b24 + b25) / B2 / 5, 2);
                Wb3 = Math.Round((b31 + b32 + 1 + b34 + b35) / B3 / 5, 2);
                Wb4 = Math.Round((b41 + b42 + b43 + 1 + b45) / B4 / 5, 2);
                Wb5 = Math.Round((b51 + b52 + b53 + b54 + 1) / B5 / 5, 2);
                Cb = Math.Round(Wb1 * u11 + Wb2 * u12 + Wb3 * u13 + Wb4 * u14 + Wb5 * u15, 2);
                #endregion

                #region 机械设备

                C1 = Math.Round(Math.Pow(1 * c12 * c13 * c14 * c15, 1f / 5), 2);
                C2 = Math.Round(Math.Pow(c21 * 1 * c23 * c24 * c25, 1f / 5), 2);
                C3 = Math.Round(Math.Pow(c31 * c32 * 1 * c34 * c35, 1f / 5), 2);
                C4 = Math.Round(Math.Pow(c41 * c42 * c43 * 1 * c45, 1f / 5), 2);
                C5 = Math.Round(Math.Pow(c51 * c52 * c53 * c54 * 1, 1f / 5), 2);
                Wc1 = Math.Round((1 + c12 + c13 + c14 + c15) / C1 / 5, 2);
                Wc2 = Math.Round((c21 + 1 + c23 + c24 + c25) / C2 / 5, 2);
                Wc3 = Math.Round((c31 + c32 + 1 + c34 + c35) / C3 / 5, 2);
                Wc4 = Math.Round((c41 + c42 + c43 + 1 + c45) / C4 / 5, 2);
                Wc5 = Math.Round((c51 + c52 + c53 + c54 + 1) / C5 / 5, 2);
                Cc = Math.Round(Wc1 * u21 + Wc2 * u22 + Wc3 * u23 + Wc4 * u24 + Wc5 * u25, 2);
                #endregion

                #region 材料

                D1 = Math.Round(Math.Pow(1 * d12 * d13 * d14, 1f / 4), 2);
                D2 = Math.Round(Math.Pow(d21 * 1 * d23 * d24, 1f / 4), 2);
                D3 = Math.Round(Math.Pow(d31 * d32 * 1 * d34, 1f / 4), 2);
                D4 = Math.Round(Math.Pow(d41 * d42 * d43 * 1, 1f / 4), 2);
                Wd1 = Math.Round((1 + d12 + d13 + d14) / D1 / 4, 2);
                Wd2 = Math.Round((d21 + 1 + d23 + d24) / D2 / 4, 2);
                Wd3 = Math.Round((d31 + d32 + 1 + d34) / D3 / 4, 2);
                Wd4 = Math.Round((d41 + d42 + d43 + 1) / D4 / 4, 2);
                Cd = Math.Round(Wd1 * u31 + Wd2 * u32 + Wd3 * u33 + Wd4 * u34, 2);
                #endregion

                #region 施工方法

                E1 = Math.Round(Math.Pow(1 * e12 * e13 * e14, 1f / 4), 2);
                E2 = Math.Round(Math.Pow(e21 * 1 * e23 * e24, 1f / 4), 2);
                E3 = Math.Round(Math.Pow(e31 * e32 * 1 * e34, 1f / 4), 2);
                E4 = Math.Round(Math.Pow(e41 * e42 * e43 * 1, 1f / 4), 2);
                We1 = Math.Round((1 + e12 + e13 + e14) / E1 / 4, 2);
                We2 = Math.Round((e21 + 1 + e23 + e24) / E2 / 4, 2);
                We3 = Math.Round((e31 + e32 + 1 + e34) / E3 / 4, 2);
                We4 = Math.Round((e41 + e42 + e43 + 1) / E4 / 4, 2);
                Ce = Math.Round(We1 * u41 + We2 * u42 + We3 * u43 + We4 * u44, 2);
                #endregion

                #region 作业条件

                F1 = Math.Round(Math.Pow(1 * f12 * f13 * f14 * f15, 1f / 5), 2);
                F2 = Math.Round(Math.Pow(f21 * 1 * f23 * f24 * f25, 1f / 5), 2);
                F3 = Math.Round(Math.Pow(f31 * f32 * 1 * f34 * f35, 1f / 5), 2);
                F4 = Math.Round(Math.Pow(f41 * f42 * f43 * 1 * f45, 1f / 5), 2);
                F5 = Math.Round(Math.Pow(f51 * f52 * f53 * f54 * 1, 1f / 5), 2);
                Wf1 = Math.Round((1 + f12 + f13 + f14 + f15) / F1 / 5, 2);
                Wf2 = Math.Round((f21 + 1 + f23 + f24 + f25) / F2 / 5, 2);
                Wf3 = Math.Round((f31 + f32 + 1 + f34 + f35) / F3 / 5, 2);
                Wf4 = Math.Round((f41 + f42 + f43 + 1 + f45) / F4 / 5, 2);
                Wf5 = Math.Round((f51 + f52 + f53 + f54 + 1) / F5 / 5, 2);
                Cf = Math.Round(Wf1 * u51 + Wf2 * u52 + Wf3 * u53 + Wf4 * u54 + Wf5 * u55, 2);
                #endregion

                #region 安全管理

                G1 = Math.Round(Math.Pow(1 * g12 * g13 * g14 * g15 * g16, 1f / 6), 2);
                G2 = Math.Round(Math.Pow(g21 * 1 * g23 * g24 * g25 * g26, 1f / 6), 2);
                G3 = Math.Round(Math.Pow(g31 * g32 * 1 * g34 * g35 * g36, 1f / 6), 2);
                G4 = Math.Round(Math.Pow(g41 * g42 * g43 * 1 * g45 * g46, 1f / 6), 2);
                G5 = Math.Round(Math.Pow(g51 * g52 * g53 * g54 * 1 * g56, 1f / 6), 2);
                G6 = Math.Round(Math.Pow(g61 * g62 * g63 * g64 * g65 * 1, 1f / 6), 2);
                Wg1 = Math.Round((1 + g12 + g13 + g14 + g15 + g16) / G1 / 6, 2);
                Wg2 = Math.Round((g21 + 1 + g23 + g24 + g25 + g26) / G2 / 6, 2);
                Wg3 = Math.Round((g31 + g32 + 1 + g34 + g35 + g36) / G3 / 6, 2);
                Wg4 = Math.Round((g41 + g42 + g43 + 1 + g45 + g46) / G4 / 6, 2);
                Wg5 = Math.Round((g51 + g52 + g53 + g54 + 1 + g56) / G5 / 6, 2);
                Wg6 = Math.Round((g61 + g62 + g63 + g64 + g65 + 1) / G6 / 6, 2);
                Cg = Math.Round(Wg1 * u61 + Wg2 * u62 + Wg3 * u63 + Wg4 * u64 + Wg5 * u65 + Wg6 * u66, 2);
                #endregion

                #region 评价
                double C;
                string result;

                C = Math.Round(w1 * Cb + w2 * Cc + w3 * Cd + w4 * Ce + w5 * Cf + w6 * Cg, 2);

                if (C >= 90)
                {
                    result = "风险小、可控";
                }
                else if (C < 80)
                {
                    result = "风险大、难控";
                }
                else
                {
                    result = "有风险、应改进";
                }
                #endregion

                obj = new object[] { u11, u12, u13, u14, u15, u21, u22, u23, u24,u25, u31, u32, u33, u34, 
                    u41, u42, u43, u44, u51, u52, u53, u54, u55, u61, u62, u63, u64, u65, u66,a12, a13, a14,
                    a15, a16, a23, a24, a25, a26, a34, a35, a36, a45, a46, a56,a21, a31, a32, a41, a42, a43,
                    a51, a52, a53, a54, a61, a62, a63, a64, a65 ,A1, A2, A3, A4, A5, A6, w1, w2, w3, w4, w5, w6, 
                    wa11, wa12, wa13, wa14, wa15, wa16, wa21, wa22, wa23, wa24, wa25, wa26, wa31, wa32,
                    wa33, wa34, wa35, wa36, wa41, wa42, wa43, wa44, wa45, wa46, wa51, wa52, wa53, wa54, wa55, 
                    wa56, wa61, wa62, wa63, wa64, wa65, wa66,b12, b13, b14, b15, b21, b23, b24, b25 ,b31, b32,
                    b34, b35, b41, b42, b43, b45, b51, b52, b53, b54,B1, B2, B3, B4, B5, Wb1, Wb2, Wb3, Wb4, Wb5, Cb,
                    c12, c13, c14, c15, c21, c23, c24, c25, c31, c32, c34, c35, c41, c42, c43, c45, c51, c52, c53, c54,
                    C1, C2, C3, C4, C5, Wc1, Wc2, Wc3, Wc4, Wc5, Cc,d12, d13, d14, d21, d23, d24, d31, d32, d34, d41, d42, d43,
                    D1, D2, D3, D4, Wd1, Wd2, Wd3, Wd4, Cd,e12, e13, e14, e21, e23, e24, e31, e32, e34, e41, e42, e43,
                    E1, E2, E3, E4, We1, We2, We3, We4, Ce,f12, f13, f14, f15, f21, f23, f24, f25, f31, f32, f34, f35, 
                    f41, f42, f43, f45, f51, f52, f53, f54,F1, F2, F3, F4, F5, Wf1, Wf2, Wf3, Wf4, Wf5, Cf,g12, g13, g14, g15,
                    g16, g23, g24, g25, g26, g34, g35, g36, g45, g46, g56,g21, g31, g32, g41, g42, g43, g51, g52, g53, g54, 
                    g61, g62, g63, g64, g65,G1, G2, G3, G4, G5, G6, Wg1, Wg2, Wg3, Wg4, Wg5, Wg6, Cg,C,result};

            }
            else if (CBX_CE_method.SelectedIndex == 1)//AHP均值法
            {
                itemtext = "AHP均值法";

                #region 工程施工风险因素判断矩阵
                A1 = Math.Round(1 + a21 + a31 + a41 + a51 + a61, 2);
                A2 = Math.Round(a12 + 1 + a32 + a42 + a52 + a62, 2);
                A3 = Math.Round(a13 + a23 + 1 + a43 + a53 + a63, 2);
                A4 = Math.Round(a14 + a24 + a34 + 1 + a54 + a64, 2);
                A5 = Math.Round(a15 + a25 + a35 + a45 + 1 + a65, 2);
                A6 = Math.Round(a16 + a26 + a36 + a46 + a56 + 1, 2);

                wa11 = Math.Round(1 / A1, 2);
                wa12 = Math.Round(a12 / A2, 2);
                wa13 = Math.Round(a13 / A3, 2);
                wa14 = Math.Round(a14 / A4, 2);
                wa15 = Math.Round(a15 / A5, 2);
                wa16 = Math.Round(a16 / A6, 2);
                w1 = Math.Round((wa11 + wa12 + wa13 + wa14 + wa15 + wa16) / 6, 2);
                wa21 = Math.Round(a21 / A1, 2);
                wa22 = Math.Round(1 / A2, 2);
                wa23 = Math.Round(a23 / A3, 2);
                wa24 = Math.Round(a24 / A4, 2);
                wa25 = Math.Round(a25 / A5, 2);
                wa26 = Math.Round(a26 / A6, 2);
                w2 = Math.Round((wa21 + wa22 + wa23 + wa24 + wa25 + wa26) / 6, 2);
                wa31 = Math.Round(a31 / A1, 2);
                wa32 = Math.Round(a32 / A2, 2);
                wa33 = Math.Round(1 / A3, 2);
                wa34 = Math.Round(a34 / A4, 2);
                wa35 = Math.Round(a35 / A5, 2);
                wa36 = Math.Round(a36 / A6, 2);
                w3 = Math.Round((wa31 + wa32 + wa33 + wa34 + wa35 + wa36) / 6, 2);
                wa41 = Math.Round(a41 / A1, 2);
                wa42 = Math.Round(a42 / A2, 2);
                wa43 = Math.Round(a43 / A3, 2);
                wa44 = Math.Round(1 / A4, 2);
                wa45 = Math.Round(a45 / A5, 2);
                wa46 = Math.Round(a46 / A6, 2);
                w4 = Math.Round((wa41 + wa42 + wa43 + wa44 + wa45 + wa46) / 6, 2);
                wa51 = Math.Round(a51 / A1, 2);
                wa52 = Math.Round(a52 / A2, 2);
                wa53 = Math.Round(a53 / A3, 2);
                wa54 = Math.Round(a54 / A4, 2);
                wa55 = Math.Round(1 / A5, 2);
                wa56 = Math.Round(a56 / A6, 2);
                w5 = Math.Round((wa51 + wa52 + wa53 + wa54 + wa55 + wa56) / 6, 2);
                wa61 = Math.Round(a61 / A1, 2);
                wa62 = Math.Round(a62 / A2, 2);
                wa63 = Math.Round(a63 / A3, 2);
                wa64 = Math.Round(a64 / A4, 2);
                wa65 = Math.Round(a65 / A5, 2);
                wa66 = Math.Round(1 / A6, 2);
                w6 = Math.Round((wa61 + wa62 + wa63 + wa64 + wa65 + wa66) / 6, 2);
                #endregion

                #region 作业人员

                B1 = Math.Round(1 + b21 + b31 + b41 + b51, 2);
                B2 = Math.Round(b12 + 1 + b32 + b42 + b52, 2);
                B3 = Math.Round(b13 + b23 + 1 + b43 + b53, 2);
                B4 = Math.Round(b14 + b24 + b34 + 1 + b54, 2);
                B5 = Math.Round(b15 + b25 + b35 + b45 + 1, 2);
                Wb1 = Math.Round((1 / B1 + b12 / B2 + b13 / B3 + b14 / B4 + b15 / B5) / 5, 2);
                Wb2 = Math.Round((b21 / B1 + 1 / B2 + b23 / B3 + b24 / B4 + b25 / B5) / 5, 2);
                Wb3 = Math.Round((b31 / B1 + b32 / B2 + 1 / B3 + b34 / B4 + b35 / B5) / 5, 2);
                Wb4 = Math.Round((b41 / B1 + b42 / B2 + b43 / B3 + 1 / B4 + b45 / B5) / 5, 2);
                Wb5 = Math.Round((b51 / B1 + b52 / B2 + b53 / B3 + b54 / B4 + 1 / B5) / 5, 2);
                Cb = Math.Round(Wb1 * u11 + Wb2 * u12 + Wb3 * u13 + Wb4 * u14 + Wb5 * u15, 2);
                #endregion

                #region 机械设备

                C1 = Math.Round(1 + c21 + c31 + c41 + c51,  2);
                C2 = Math.Round(c12 + 1 + c32 + c42 + c52,  2);
                C3 = Math.Round(c13 + c23 + 1 + c43 + c53,  2);
                C4 = Math.Round(c14 + c24 + c34 + 1 + c54,  2);
                C5 = Math.Round(c15 + c25 + c35 + c45 + 1,  2);
                Wc1 = Math.Round((1 / C1 + c12 / C2 + c13 / C3 + c14 / C4 + c15 / C5) / 5, 2);
                Wc2 = Math.Round((c21 / C1 + 1 / C2 + c23 / C3 + c24 / C4 + c25 / C5) / 5, 2);
                Wc3 = Math.Round((c31 / C1 + c32 / C2 + 1 / C3 + c34 / C4 + c35 / C5) / 5, 2);
                Wc4 = Math.Round((c41 / C1 + c42 / C2 + c43 / C3 + 1 / C4 + c45 / C5) / 5, 2);
                Wc5 = Math.Round((c51 / C1 + c52 / C2 + c53 / C3 + c54 / C4 + 1 / C5) / 5, 2);
                Cc = Math.Round(Wc1 * u21 + Wc2 * u22 + Wc3 * u23 + Wc4 * u24 + Wc5 * u25, 2);
                #endregion

                #region 材料

                D1 = Math.Round(1 + d21 + d31 + d41, 2);
                D2 = Math.Round(d12 + 1 + d32 + d42, 2);
                D3 = Math.Round(d13 + d23 + 1 + d43, 2);
                D4 = Math.Round(d14 + d24 + d34 + 1, 2);
                Wd1 = Math.Round((1 / D1 + d12 / D2 + d13 / D3 + d14 / D4) / 4, 2);
                Wd2 = Math.Round((d21 / D1 + 1 / D2 + d23 / D3 + d24 / D4) / 4, 2);
                Wd3 = Math.Round((d31 / D1 + d32 / D2 + 1 / D3 + d34 / D4) / 4, 2);
                Wd4 = Math.Round((d41 / D1 + d42 / D2 + d43 / D3 + 1 / D4) / 4, 2);
                Cd = Math.Round(Wd1 * u31 + Wd2 * u32 + Wd3 * u33 + Wd4 * u34, 2);
                #endregion

                #region 施工方法

                E1 = Math.Round(1 + e21 + e31 + e41, 2);
                E2 = Math.Round(e12 + 1 + e32 + e42, 2);
                E3 = Math.Round(e13 + e23 + 1 + e43, 2);
                E4 = Math.Round(e14 + e24 + e34 + 1, 2);
                We1 = Math.Round((1 / E1 + e12 / E2 + e13 / E3 + e14 / E4) / 4, 2);
                We2 = Math.Round((e21 / E1 + 1 / E2 + e23 / E3 + e24 / E4) / 4, 2);
                We3 = Math.Round((e31 / E1 + e32 / E2 + 1 / E3 + e34 / E4) / 4, 2);
                We4 = Math.Round((e41 / E1 + e42 / E2 + e43 / E3 + 1 / E4) / 4, 2);
                Ce = Math.Round(We1 * u41 + We2 * u42 + We3 * u43 + We4 * u44, 2);
                #endregion

                #region 作业条件

                F1 = Math.Round(1 + f21 + f31 + f41 + f51, 2);
                F2 = Math.Round(f12 + 1 + f32 + f42 + f52, 2);
                F3 = Math.Round(f13 + f23 + 1 + f43 + f53, 2);
                F4 = Math.Round(f14 + f24 + f34 + 1 + f54, 2);
                F5 = Math.Round(f15 + f25 + f35 + f45 + 1, 2);
                Wf1 = Math.Round((1 / F1 + f12 / F2 + f13 / F3 + f14 / F4 + f15 / F5) / 5, 2);
                Wf2 = Math.Round((f21 / F1 + 1 / F2 + f23 / F3 + f24 / F4 + f25 / F5) / 5, 2);
                Wf3 = Math.Round((f31 / F1 + f32 / F2 + 1 / F3 + f34 / F4 + f35 / F5) / 5, 2);
                Wf4 = Math.Round((f41 / F1 + f42 / F2 + f43 / F3 + 1 / F4 + f45 / F5) / 5, 2);
                Wf5 = Math.Round((f51 / F1 + f52 / F2 + f53 / F3 + f54 / F4 + 1 / F5) / 5, 2);
                Cf = Math.Round(Wf1 * u51 + Wf2 * u52 + Wf3 * u53 + Wf4 * u54 + Wf5 * u55, 2);
                #endregion

                #region 安全管理

                G1 = Math.Round(1 + g21 + g31 + g41 + g51 + g61, 2);
                G2 = Math.Round(g12 + 1 + g32 + g42 + g52 + g62, 2);
                G3 = Math.Round(g13 + g23 + 1 + g43 + g53 + g63, 2);
                G4 = Math.Round(g14 + g24 + g34 + 1 + g54 + g64, 2);
                G5 = Math.Round(g15 + g25 + g35 + g45 + 1 + g65, 2);
                G6 = Math.Round(g16 + g26 + g36 + g46 + g56 + 1, 2);
                Wg1 = Math.Round((1 / G1 + g12 / G2 + g13 / G3 + g14 / G4 + g15 / G5 + g16 / G6) / 6, 2);
                Wg2 = Math.Round((g21 / G1 + 1 / G2 + g23 / G3 + g24 / G4 + g25 / G5 + g26 / G6) / 6, 2);
                Wg3 = Math.Round((g31 / G1 + g32 / G2 + 1 / G3 + g34 / G4 + g35 / G5 + g36 / G6) / 6, 2);
                Wg4 = Math.Round((g41 / G1 + g42 / G2 + g43 / G3 + 1 / G4 + g45 / G5 + g46 / G6) / 6, 2);
                Wg5 = Math.Round((g51 / G1 + g52 / G2 + g53 / G3 + g54 / G4 + 1 / G5 + g56 / G6) / 6, 2);
                Wg6 = Math.Round((g61 / G1 + g62 / G2 + g63 / G3 + g64 / G4 + g65 / G5 + 1 / G6) / 6, 2);
                Cg = Math.Round(Wg1 * u61 + Wg2 * u62 + Wg3 * u63 + Wg4 * u64 + Wg5 * u65 + Wg6 * u66, 2);
                #endregion
            
                #region 评价
                double C;
                string result;

                C = Math.Round(w1 * Cb + w2 * Cc + w3 * Cd + w4 * Ce + w5 * Cf + w6 * Cg, 2);        
                
                if (C >= 90)
                {
                    result = "风险小、可控";
                }
                else if (C < 80)
                {
                    result = "风险大、难控";
                }
                else
                {
                    result = "有风险、应改进";
                }
                #endregion

                obj = new object[] { u11, u12, u13, u14, u15, u21, u22, u23, u24,u25, u31, u32, u33, u34, 
                    u41, u42, u43, u44, u51, u52, u53, u54, u55, u61, u62, u63, u64, u65, u66,a12, a13, a14,
                    a15, a16, a23, a24, a25, a26, a34, a35, a36, a45, a46, a56,a21, a31, a32, a41, a42, a43,
                    a51, a52, a53, a54, a61, a62, a63, a64, a65 ,A1, A2, A3, A4, A5, A6, w1, w2, w3, w4, w5, w6, 
                    wa11, wa12, wa13, wa14, wa15, wa16, wa21, wa22, wa23, wa24, wa25, wa26, wa31, wa32,
                    wa33, wa34, wa35, wa36, wa41, wa42, wa43, wa44, wa45, wa46, wa51, wa52, wa53, wa54, wa55, 
                    wa56, wa61, wa62, wa63, wa64, wa65, wa66,b12, b13, b14, b15, b21, b23, b24, b25 ,b31, b32,
                    b34, b35, b41, b42, b43, b45, b51, b52, b53, b54,B1, B2, B3, B4, B5, Wb1, Wb2, Wb3, Wb4, Wb5, Cb,
                    c12, c13, c14, c15, c21, c23, c24, c25, c31, c32, c34, c35, c41, c42, c43, c45, c51, c52, c53, c54,
                    C1, C2, C3, C4, C5, Wc1, Wc2, Wc3, Wc4, Wc5, Cc,d12, d13, d14, d21, d23, d24, d31, d32, d34, d41, d42, d43,
                    D1, D2, D3, D4, Wd1, Wd2, Wd3, Wd4, Cd,e12, e13, e14, e21, e23, e24, e31, e32, e34, e41, e42, e43,
                    E1, E2, E3, E4, We1, We2, We3, We4, Ce,f12, f13, f14, f15, f21, f23, f24, f25, f31, f32, f34, f35, 
                    f41, f42, f43, f45, f51, f52, f53, f54,F1, F2, F3, F4, F5, Wf1, Wf2, Wf3, Wf4, Wf5, Cf,g12, g13, g14, g15,
                    g16, g23, g24, g25, g26, g34, g35, g36, g45, g46, g56,g21, g31, g32, g41, g42, g43, g51, g52, g53, g54, 
                    g61, g62, g63, g64, g65,G1, G2, G3, G4, G5, G6, Wg1, Wg2, Wg3, Wg4, Wg5, Wg6, Cg,C,result};
            }


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