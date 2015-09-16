namespace Framework.Model
{
    public class ManageTarget
    {
        private System.DateTime start;
        private System.DateTime end;
        private string level;
        private string target;

        [System.ComponentModel.Category("基本信息")]
        public System.DateTime 开工日期
        {
            get { return this.start; }
            set { this.start = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public System.DateTime 竣工日期
        {
            get { return this.end; }
            set { this.end = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 达到标准
        {
            get { return this.level; }
            set { this.level = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 文明施工及环保目标
        {
            get { return this.target; }
            set { this.target = value; }
        }
    }
}