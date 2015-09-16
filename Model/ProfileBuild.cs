namespace Framework.Model
{
    class ProfileBuild
    {
        private string name;

        [System.ComponentModel.Category("基本信息")]
        public string 工程名称
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}