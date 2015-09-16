namespace Framework.Interface.Content
{
    public partial class FrmChapter : Framework.Interface.Common.FrmBase
    {
        public delegate void RefreshHandle();
        public RefreshHandle RefreshIntance;

        private Framework.Implement.UtilImpl utilService = new Framework.Implement.UtilImpl();
        private Framework.Implement.AuthorityImpl authorityService = new Framework.Implement.AuthorityImpl();
        private Framework.Implement.ContentImpl contentService = new Framework.Implement.ContentImpl();
        private Framework.Entity.Chapter chapter;
        private bool flag;

        public FrmChapter(bool _flag, Framework.Entity.Chapter _chapter)
        {
            InitializeComponent();
            flag = _flag;
            chapter = _chapter;
        }

        private void FrmChapter_Load(object sender, System.EventArgs e)
        {
           
            CbxState.Items.Add("启用");
            CbxState.Items.Add("禁用");
            CbxState.SelectedIndex = 0;
            System.Collections.ArrayList moduleList = authorityService.GetContentModule();
            foreach (Framework.Entity.Module module in moduleList)
            {
                Framework.Class.ComboItem item = new Framework.Class.ComboItem();
                item.Text = module.Title;
                item.Value = module.Id;
                CbxModule.Items.Add(item);
            }
            CbxModule.SelectedIndex = 0;
            Framework.Class.ComboItem defualtItem = new Framework.Class.ComboItem();
            defualtItem.Text = "不使用模型";
            defualtItem.Value = 0;
            CbxModel.Items.Add(defualtItem);
            System.Collections.ArrayList modelList = contentService.GetAllModel();
            foreach (Framework.Entity.Model model in modelList)
            {
                Framework.Class.ComboItem item = new Framework.Class.ComboItem();
                item.Text = model.Name;
                item.Value = model.Id;
                CbxModel.Items.Add(item);
            }
            CbxModel.SelectedIndex = 0;
            if (flag)
            {
                if (chapter.Pid != Framework.Entity.Chapter.ROOT)
                {
                    Framework.Entity.Chapter pChapter = (Framework.Entity.Chapter)utilService.FindById(chapter, chapter.Pid);
                    LbParent.Text = pChapter.Title;
                }
                else
                {
                    LbParent.Text = "顶级";
                }
                TbxName.Text = chapter.Title;
                TbxDescription.Text = chapter.Description;
                int index = 0;
                foreach (Framework.Entity.Module module in moduleList)
                {
                    if (module.Id == chapter.Module)
                    {
                        CbxModule.SelectedIndex = index;
                    }
                    index++;
                }
                index = 0;
                foreach (Framework.Entity.Model model in modelList)
                {
                    if (model.Id == chapter.Model)
                    {
                        CbxModel.SelectedIndex = index + 1;
                    }
                    index++;
                }
                switch (chapter.Type)
                {
                    case 0: //基本类型
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = false;
                        break;
                    case 1: //专项类型
                        CbxBasicType.Checked = false;
                        CbxSpecialType.Checked = true;
                            break;
                    case 9: //所有类型
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = true;
                        break;
                    default:
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = false;
                        break;
                }
                CbxState.SelectedIndex = chapter.State;
            }
            else
            {
                if (chapter.Title != null)
                {
                    LbParent.Text = chapter.Title;
                }
                switch (chapter.Type)
                {
                    case 0: //基本类型
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = false;
                        break;
                    case 1: //专项类型
                        CbxBasicType.Checked = false;
                        CbxSpecialType.Checked = true;
                        break;
                    case 9: //所有类型
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = true;
                        break;
                    default:
                        CbxBasicType.Checked = true;
                        CbxSpecialType.Checked = false;
                        break;
                }
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            Framework.Entity.Chapter newChapter = new Framework.Entity.Chapter();
            if (flag)
            {
                newChapter = chapter;
            }
            else
            {
                if (chapter.Title != null)
                {
                    newChapter.Pid = chapter.Id;
                }
                else
                {
                    newChapter.Pid = Framework.Entity.Chapter.ROOT;
                }
            }
            newChapter.Title = TbxName.Text;
            newChapter.Description = TbxDescription.Text;
            Framework.Class.ComboItem item = (Framework.Class.ComboItem)CbxModule.SelectedItem;
            newChapter.Module = System.Convert.ToInt32(item.Value);
            newChapter.State = CbxState.SelectedIndex;
            item = (Framework.Class.ComboItem)CbxModel.SelectedItem;
            newChapter.Model = System.Convert.ToInt32(item.Value);
           // int type;//章节属于哪个工程
            if (CbxBasicType.Checked & CbxSpecialType.Checked)
            {
                newChapter.Type = 9;//所有工程
            }
            else if (CbxSpecialType.Checked)
            {
                newChapter.Type = 1;//专项工程
            }
            else
            {
                newChapter.Type = 0;//基本工程
            }
            if (flag)
            {
                utilService.Update(newChapter);
            }
            else
            {
                utilService.Insert(newChapter);
            }
            RefreshIntance();
            this.Close();
        }
    }
}