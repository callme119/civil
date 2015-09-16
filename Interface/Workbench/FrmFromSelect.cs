using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Framework.Interface.Workbench
{
    public partial class FrmFromSelect : Framework.Interface.Common.FrmBase
    {
        public delegate void CreateModuleHandle(Framework.Entity.Template template, System.Collections.ArrayList array, object @class, object[] data);
        public CreateModuleHandle CreateModuleIntance;

        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private object @class;
        private Framework.Entity.Chapter chaptertemp;
        private System.Collections.ArrayList templateList1;

        public FrmFromSelect(Framework.Entity.Chapter chapter, object type)
        {
            InitializeComponent();
            @class = type;
            chaptertemp = chapter;

            templateList1 = contentService.GetContentTemplateByTitle(chapter.Title);
            if (chapter.Title == "≤ƒ¡œ—°‘Ò")
            {
                st_FS_1.SelectedTabIndex = 0;
                btnAddRow.Visible = btnDeleteRow.Visible = false;
            }
            else if (chapter.Title == "»À‘±∞≤≈≈")
            {
                st_FS_1.SelectedTabIndex = 1;
            }
            else {
                st_FS_1.SelectedTabIndex = 2;
            }
        }

        private void cB_FS_1DBZC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_FS_1DBZC.SelectedIndex == 0)//∑Ωƒæ
            {
                cB_FS_1JMLX.Enabled = false;
                dI_FS_1FMG.Enabled = dI_FS_1FMK.Enabled = true;
            }
            else if (cB_FS_1DBZC.SelectedIndex == 1)//∑Ω∏÷π‹
            {
                cB_FS_1JMLX.Enabled = true;
                dI_FS_1FMG.Enabled = dI_FS_1FMK.Enabled = false;
                cB_FS_1JMLX.Items.Clear();
                cB_FS_1JMLX.Items.Add("°ı60°¡40°¡2.5"); cB_FS_1JMLX.Items.Add("°ı80°¡40°¡2"); cB_FS_1JMLX.Items.Add("°ı100°¡50°¡3");
            }
            else if (cB_FS_1DBZC.SelectedIndex == 2)//π§◊÷∏÷
            {
                cB_FS_1JMLX.Enabled = true;
                dI_FS_1FMG.Enabled = dI_FS_1FMK.Enabled = false;
                cB_FS_1JMLX.Items.Clear();
                cB_FS_1JMLX.Items.Add("10∫≈"); cB_FS_1JMLX.Items.Add("12.6∫≈"); cB_FS_1JMLX.Items.Add("14∫≈"); cB_FS_1JMLX.Items.Add("16∫≈"); cB_FS_1JMLX.Items.Add("18∫≈");
                cB_FS_1JMLX.Items.Add("20a∫≈"); cB_FS_1JMLX.Items.Add("20b∫≈"); cB_FS_1JMLX.Items.Add("22a∫≈"); cB_FS_1JMLX.Items.Add("22b∫≈"); cB_FS_1JMLX.Items.Add("25a∫≈");
                cB_FS_1JMLX.Items.Add("25b∫≈"); cB_FS_1JMLX.Items.Add("28a∫≈"); cB_FS_1JMLX.Items.Add("28b∫≈"); cB_FS_1JMLX.Items.Add("32a∫≈"); cB_FS_1JMLX.Items.Add("32b∫≈");
                cB_FS_1JMLX.Items.Add("32c∫≈"); cB_FS_1JMLX.Items.Add("36a∫≈"); cB_FS_1JMLX.Items.Add("36b∫≈"); cB_FS_1JMLX.Items.Add("36c∫≈"); cB_FS_1JMLX.Items.Add("40a∫≈");
                cB_FS_1JMLX.Items.Add("40b∫≈"); cB_FS_1JMLX.Items.Add("40c∫≈"); cB_FS_1JMLX.Items.Add("45a∫≈"); cB_FS_1JMLX.Items.Add("45b∫≈"); cB_FS_1JMLX.Items.Add("45c∫≈");
                cB_FS_1JMLX.Items.Add("50a∫≈"); cB_FS_1JMLX.Items.Add("50b∫≈"); cB_FS_1JMLX.Items.Add("50c∫≈"); cB_FS_1JMLX.Items.Add("56a∫≈"); cB_FS_1JMLX.Items.Add("56b∫≈");
                cB_FS_1JMLX.Items.Add("56c∫≈"); cB_FS_1JMLX.Items.Add("63a∫≈"); cB_FS_1JMLX.Items.Add("63b∫≈"); cB_FS_1JMLX.Items.Add("63c∫≈");
            }
            else if (cB_FS_1DBZC.SelectedIndex == 3)//≤€∏÷
            {
                cB_FS_1JMLX.Enabled = true;
                dI_FS_1FMG.Enabled = dI_FS_1FMK.Enabled = false;
                cB_FS_1JMLX.Items.Clear();
                cB_FS_1JMLX.Items.Add("5∫≈"); cB_FS_1JMLX.Items.Add("6.3∫≈"); cB_FS_1JMLX.Items.Add("8∫≈"); cB_FS_1JMLX.Items.Add("10∫≈"); cB_FS_1JMLX.Items.Add("12.6∫≈");
                cB_FS_1JMLX.Items.Add("14a∫≈"); cB_FS_1JMLX.Items.Add("14b∫≈"); cB_FS_1JMLX.Items.Add("16a∫≈"); cB_FS_1JMLX.Items.Add("16b∫≈"); cB_FS_1JMLX.Items.Add("18a∫≈");
                cB_FS_1JMLX.Items.Add("18b∫≈"); cB_FS_1JMLX.Items.Add("20a∫≈"); cB_FS_1JMLX.Items.Add("20b∫≈"); cB_FS_1JMLX.Items.Add("22a∫≈"); cB_FS_1JMLX.Items.Add("22b∫≈");
                cB_FS_1JMLX.Items.Add("25a∫≈"); cB_FS_1JMLX.Items.Add("25b∫≈"); cB_FS_1JMLX.Items.Add("25c∫≈"); cB_FS_1JMLX.Items.Add("28a∫≈"); cB_FS_1JMLX.Items.Add("28b∫≈");
                cB_FS_1JMLX.Items.Add("28c∫≈"); cB_FS_1JMLX.Items.Add("32a∫≈"); cB_FS_1JMLX.Items.Add("32b∫≈"); cB_FS_1JMLX.Items.Add("32c∫≈"); cB_FS_1JMLX.Items.Add("36a∫≈");
                cB_FS_1JMLX.Items.Add("36b∫≈"); cB_FS_1JMLX.Items.Add("36c∫≈"); cB_FS_1JMLX.Items.Add("40a∫≈"); cB_FS_1JMLX.Items.Add("40b∫≈"); cB_FS_1JMLX.Items.Add("40c∫≈");
            }
            else if (cB_FS_1DBZC.SelectedIndex == 4)//∏÷π‹
            {
                cB_FS_1JMLX.Enabled = true;
                dI_FS_1FMG.Enabled = dI_FS_1FMK.Enabled = false;
                cB_FS_1JMLX.Items.Clear();
                cB_FS_1JMLX.Items.Add("¶’48°¡3.5"); cB_FS_1JMLX.Items.Add("¶’48°¡3.25"); cB_FS_1JMLX.Items.Add("¶’48°¡3.2"); cB_FS_1JMLX.Items.Add("¶’48°¡3"); cB_FS_1JMLX.Items.Add("¶’51°¡3");
            }
        }

        private void cB_FS_2DBZC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_FS_2DBZC.SelectedIndex == 0)//∑Ωƒæ
            {
                cB_FS_2JMLX.Enabled = false;
                dI_FS_2FMG.Enabled = dI_FS_2FMK.Enabled = true;
            }
            else if (cB_FS_2DBZC.SelectedIndex == 1)//∑Ω∏÷π‹
            {
                cB_FS_2JMLX.Enabled = true;
                dI_FS_2FMG.Enabled = dI_FS_2FMK.Enabled = false;
                cB_FS_2JMLX.Items.Clear();
                cB_FS_2JMLX.Items.Add("°ı60°¡40°¡2.5"); cB_FS_2JMLX.Items.Add("°ı80°¡40°¡2"); cB_FS_2JMLX.Items.Add("°ı100°¡50°¡3");
            }
            else if (cB_FS_2DBZC.SelectedIndex == 2)//π§◊÷∏÷
            {
                cB_FS_2JMLX.Enabled = true;
                dI_FS_2FMG.Enabled = dI_FS_2FMK.Enabled = false;
                cB_FS_2JMLX.Items.Clear();
                cB_FS_2JMLX.Items.Add("10∫≈"); cB_FS_2JMLX.Items.Add("12.6∫≈"); cB_FS_2JMLX.Items.Add("14∫≈"); cB_FS_2JMLX.Items.Add("16∫≈"); cB_FS_2JMLX.Items.Add("18∫≈");
                cB_FS_2JMLX.Items.Add("20a∫≈"); cB_FS_2JMLX.Items.Add("20b∫≈"); cB_FS_2JMLX.Items.Add("22a∫≈"); cB_FS_2JMLX.Items.Add("22b∫≈"); cB_FS_2JMLX.Items.Add("25a∫≈");
                cB_FS_2JMLX.Items.Add("25b∫≈"); cB_FS_2JMLX.Items.Add("28a∫≈"); cB_FS_2JMLX.Items.Add("28b∫≈"); cB_FS_2JMLX.Items.Add("32a∫≈"); cB_FS_2JMLX.Items.Add("32b∫≈");
                cB_FS_2JMLX.Items.Add("32c∫≈"); cB_FS_2JMLX.Items.Add("36a∫≈"); cB_FS_2JMLX.Items.Add("36b∫≈"); cB_FS_2JMLX.Items.Add("36c∫≈"); cB_FS_2JMLX.Items.Add("40a∫≈");
                cB_FS_2JMLX.Items.Add("40b∫≈"); cB_FS_2JMLX.Items.Add("40c∫≈"); cB_FS_2JMLX.Items.Add("45a∫≈"); cB_FS_2JMLX.Items.Add("45b∫≈"); cB_FS_2JMLX.Items.Add("45c∫≈");
                cB_FS_2JMLX.Items.Add("50a∫≈"); cB_FS_2JMLX.Items.Add("50b∫≈"); cB_FS_2JMLX.Items.Add("50c∫≈"); cB_FS_2JMLX.Items.Add("56a∫≈"); cB_FS_2JMLX.Items.Add("56b∫≈");
                cB_FS_2JMLX.Items.Add("56c∫≈"); cB_FS_2JMLX.Items.Add("63a∫≈"); cB_FS_2JMLX.Items.Add("63b∫≈"); cB_FS_2JMLX.Items.Add("63c∫≈");
            }
            else if (cB_FS_2DBZC.SelectedIndex == 3)//≤€∏÷
            {
                cB_FS_2JMLX.Enabled = true;
                dI_FS_2FMG.Enabled = dI_FS_2FMK.Enabled = false;
                cB_FS_2JMLX.Items.Clear();
                cB_FS_2JMLX.Items.Add("5∫≈"); cB_FS_2JMLX.Items.Add("6.3∫≈"); cB_FS_2JMLX.Items.Add("8∫≈"); cB_FS_2JMLX.Items.Add("10∫≈"); cB_FS_2JMLX.Items.Add("12.6∫≈");
                cB_FS_2JMLX.Items.Add("14a∫≈"); cB_FS_2JMLX.Items.Add("14b∫≈"); cB_FS_2JMLX.Items.Add("16a∫≈"); cB_FS_2JMLX.Items.Add("16b∫≈"); cB_FS_2JMLX.Items.Add("18a∫≈");
                cB_FS_2JMLX.Items.Add("18b∫≈"); cB_FS_2JMLX.Items.Add("20a∫≈"); cB_FS_2JMLX.Items.Add("20b∫≈"); cB_FS_2JMLX.Items.Add("22a∫≈"); cB_FS_2JMLX.Items.Add("22b∫≈");
                cB_FS_2JMLX.Items.Add("25a∫≈"); cB_FS_2JMLX.Items.Add("25b∫≈"); cB_FS_2JMLX.Items.Add("25c∫≈"); cB_FS_2JMLX.Items.Add("28a∫≈"); cB_FS_2JMLX.Items.Add("28b∫≈");
                cB_FS_2JMLX.Items.Add("28c∫≈"); cB_FS_2JMLX.Items.Add("32a∫≈"); cB_FS_2JMLX.Items.Add("32b∫≈"); cB_FS_2JMLX.Items.Add("32c∫≈"); cB_FS_2JMLX.Items.Add("36a∫≈");
                cB_FS_2JMLX.Items.Add("36b∫≈"); cB_FS_2JMLX.Items.Add("36c∫≈"); cB_FS_2JMLX.Items.Add("40a∫≈"); cB_FS_2JMLX.Items.Add("40b∫≈"); cB_FS_2JMLX.Items.Add("40c∫≈");
            }
            else if (cB_FS_2DBZC.SelectedIndex == 4)//∏÷π‹
            {
                cB_FS_2JMLX.Enabled = true;
                dI_FS_2FMG.Enabled = dI_FS_2FMK.Enabled = false;
                cB_FS_2JMLX.Items.Clear();
                cB_FS_2JMLX.Items.Add("¶’48°¡3.5"); cB_FS_2JMLX.Items.Add("¶’48°¡3.25"); cB_FS_2JMLX.Items.Add("¶’48°¡3.2"); cB_FS_2JMLX.Items.Add("¶’48°¡3"); cB_FS_2JMLX.Items.Add("¶’51°¡3");
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            switch (st_FS_1.SelectedTabIndex)
            {
                case 1: Dgv_FS_Staff.Rows.Add(); break;
                case 2: Dgv_FS_Machine.Rows.Add(); break;
            }
        }

        private void FrmFromSelect_Load(object sender, EventArgs e)
        {
            #region //»À‘±∞≤≈≈
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colWorktypeChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colWorktypeChoice.HeaderText = "—°‘Òπ§÷÷";
                colWorktypeChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colWorktype = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colWorktype.HeaderText = "π§÷÷√˚≥∆";
                colWorktype.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colWorkNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colWorkNumber.HeaderText = "»À ˝";
                colWorkNumber.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colWorkDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colWorkDelete.HeaderText = "…æ≥˝––";
                colWorkDelete.Width = 60;
                Dgv_FS_Staff.Columns.Add(colWorktypeChoice);
                Dgv_FS_Staff.Columns.Add(colWorktype);
                Dgv_FS_Staff.Columns.Add(colWorkNumber);
                Dgv_FS_Staff.Columns.Add(colWorkDelete);
                Dgv_FS_Staff.Rows.Add();

                object[] strWork = new object[] { "ºº ıπ‹¿Ì", "∞≤»´º‡∂Ω", "÷ ¡øºÏ≤‚", "≤‚¡ø∑≈œﬂ", "º‹◊”π§", "µÁ∫∏π§", "ƒæπ§", "–ﬁ¿Ìπ§", "ªÏƒ˝Õ¡π§", "∏÷ΩÓπ§" };
                for (int i = 0; i < strWork.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strWork[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {
                        int RowNum = Dgv_FS_Staff.CurrentRow.Index;
                        Dgv_FS_Staff.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        Dgv_FS_Staff.Refresh();
                    });
                    colWorktypeChoice.SubItems.Add(btnItem);
                }
            }
            #endregion

            #region //ª˙–µ∞≤≈≈±Ì
            {
                DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn colMaterialChoice = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
                colMaterialChoice.HeaderText = "—°‘Òª˙–µ";
                colMaterialChoice.Width = 100;
                DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterial = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
                colMaterial.HeaderText = "ª˙–µ√˚≥∆";
                colMaterial.Width = 180;
                DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colMaterialNumber = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
                colMaterialNumber.HeaderText = " ˝¡ø";
                colMaterialNumber.Width = 180;
             // DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn colMaterialRemark = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
               // colMaterialRemark.HeaderText = "πÊ∏Ò";
                //colMaterialRemark.Width = 150;
                DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colMaterialDelete = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
                colMaterialDelete.HeaderText = "…æ≥˝––";
                colMaterialDelete.Width = 60;
                Dgv_FS_Machine.Columns.Add(colMaterialChoice);
                Dgv_FS_Machine.Columns.Add(colMaterial);
                Dgv_FS_Machine.Columns.Add(colMaterialNumber);
               // Dgv_FS_Machine.Columns.Add(colMaterialRemark);
                Dgv_FS_Machine.Columns.Add(colMaterialDelete);
                Dgv_FS_Machine.Rows.Add();

                object[] strMaterial = new object[] { "¥∏◊”", "µ•Õ∑∞‚ ÷", "‘≤≈Ãæ‚", "∆Ω≈Ÿ", " ÷µÁ◊Í", "Ã®◊Í", " ÷Ã·µÁæ‚", " ÷Ã·µÁ≈Ÿ", "—π≈Ÿ", "ªÓ∂Ø∞‚ ÷", " ÷µÁ◊Í", "ø’—πª˙", "∏÷Àø«Ø", "ƒ´∂∑°¢∑€œﬂ¥¯", "…∞¬÷«–∏Óª˙", "¡„≈‰º˛∫Õπ§æﬂœ‰", "ÀÆ◊º“«", "º§π‚¥π◊º“«", "ÀÆ∆Ω≥ﬂ", "∏÷æÌ≥ﬂ", "÷±≥ﬂ", "øø≥ﬂ", "»˚πÊ" };
               // string[] strNumber = new string[] { "         ∏ˆ", "         m", "          ∏ˆ", "           m2", "      ∏ˆ", "         m" };
                for (int i = 0; i < strMaterial.Length; i++)
                {
                    DevComponents.DotNetBar.ButtonItem btnItem = new DevComponents.DotNetBar.ButtonItem();
                    btnItem.Text = (string)strMaterial[i];
                    btnItem.Click += new System.EventHandler(delegate(object sender1, System.EventArgs args)
                    {

                        int RowNum = Dgv_FS_Machine.CurrentRow.Index;
                        Dgv_FS_Machine.Rows[RowNum].Cells[1].Value = btnItem.Text;
                        /*  for (int j = 0; j < strMaterial.Length; j++)
                           {
                            if (btnItem.Text == strMaterial[j].ToString())
                               {
                                   Dgv_FS_Machine.Rows[RowNum].Cells[2].Value = strNumber[j];
                                   break;
                               }
                           }
                       */
                        Dgv_FS_Machine.Refresh();
                    });
                    colMaterialChoice.SubItems.Add(btnItem);
                }
            }
            #endregion
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (st_FS_1.SelectedTabIndex == 2)
            {
                foreach (DataGridViewRow row in this.Dgv_FS_Machine.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_FS_Machine.Rows.Remove(row);
                    }
                }
            }
            if (st_FS_1.SelectedTabIndex == 1)
            {
                foreach (DataGridViewRow row in this.Dgv_FS_Staff.Rows)
                {
                    if (row.Cells[3].Value != null && Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        this.Dgv_FS_Staff.Rows.Remove(row);
                    }
                }
            }
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region  //ªÒ»°ƒ£∞Âµƒƒ⁄»›
            object[] obj = new object[] { };
            string templatename = "ƒ£∞Â—°‘Ò";
            Framework.Entity.Template templatetemp = new Framework.Entity.Template();
            System.Collections.ArrayList templateList = contentService.GetContentTemplateByTitle(chaptertemp.Title);
            
            #endregion
            System.Collections.ArrayList array = new System.Collections.ArrayList();
            System.Collections.ArrayList array1 = new System.Collections.ArrayList();
            System.Collections.ArrayList array2 = new System.Collections.ArrayList();

            for (int i = 0; i < Dgv_FS_Machine.Rows.Count; i++)
            {
                if (Dgv_FS_Machine.Rows[i].Cells[1].Value != null)
                {
                    array2.Add(new object[] { i + 1, Dgv_FS_Machine.Rows[i].Cells[1].Value, Dgv_FS_Machine.Rows[i].Cells[2].Value });
                }
            }
            for (int i = 0; i < Dgv_FS_Staff.Rows.Count; i++)
            {
                if (Dgv_FS_Staff.Rows[i].Cells[1].Value != null)
                {
                    array1.Add(new object[] { i + 1, Dgv_FS_Staff.Rows[i].Cells[1].Value, Dgv_FS_Staff.Rows[i].Cells[2].Value });
                }
            }

            array.Add(array1);
            array.Add(array2);

            string data1_1, data1_2, data1_3, data1_5, data1_6;
            double data1_4, data1_7, data1_8;
            string str1_1;

            //¡∫
            data1_1 = cB_FS_1CZJ.Text;
            data1_2 = cB_FS_1GGLX.Text;
            data1_3 = cB_FS_1MBLX.Text;
            data1_4 = dI_FS_1MBHD.Value;
            data1_5 = cB_FS_1DBZC.Text;
            data1_6 = cB_FS_1JMLX.Text;
            data1_7 = dI_FS_1FMK.Value;
            data1_8 = dI_FS_1FMG.Value;

            if (cB_FS_1DBZC.SelectedIndex != 0)
            {
                str1_1 = data1_6 + data1_5;
            }
            else {
                str1_1 = data1_7 + "mm" + "°¡" + data1_8 + "mm" + data1_5;
            }

            //∞Â
            string data2_1, data2_2, data2_3, data2_5, data2_6;
            double data2_4, data2_7, data2_8;
            string str2_1;

            data2_1 = cB_FS_2CZJ.Text;
            data2_2 = cB_FS_2GGLX.Text;
            data2_3 = cB_FS_2MBLX.Text;
            data2_4 = dI_FS_2MBHD.Value;
            data2_5 = cB_FS_2DBZC.Text;
            data2_6 = cB_FS_2JMLX.Text;
            data2_7 = dI_FS_2FMK.Value;
            data2_8 = dI_FS_2FMG.Value;

            if (cB_FS_2DBZC.SelectedIndex != 0)
            {
                str2_1 = data2_6 + data2_5;
            }
            else
            {
                str2_1 = data2_7 + "mm" + "°¡" + data2_8 + "mm" + data2_5;
            }

            obj = new object[] { data1_1, data1_2, data1_3, data1_4, str1_1, data2_1, data2_2, data2_3, data2_4, str2_1 };

            foreach (Framework.Entity.Template template in templateList)
            {
                if (template.Title == templatename)
                {
                    templatetemp = template;
                    break;
                }
            }

            CreateModuleIntance(templatetemp, array, @class, obj);
            this.Close();
        }
        
        private void st_FS_1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (st_FS_1.SelectedTabIndex == 0)
            {
                btnAddRow.Visible = btnDeleteRow.Visible = false;
            }
            else
            {
                btnAddRow.Visible = btnDeleteRow.Visible = true;
            }
        }

        
        


    }
}