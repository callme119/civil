namespace Framework.Model
{
    public class ProfileBase
    {
        private string name;
        private string build;
        private string design;
        private string address;
        private string type;
        private float area;
        private int level;
        private float length;
        private float width;
        private float height;
        private float diff;
        private string fire;
        private string earthquake;

        [System.ComponentModel.Category("基本信息")]
        public string 工程名称
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 建设单位
        {
            get { return this.build; }
            set { this.build = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 设计单位
        {
            get { return this.design; }
            set { this.design = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 工程地址
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(TypeConverter))]
        public string 结构类型
        {
            get { return this.type; }
            set { this.type = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 总建筑面积
        {
            get { return this.area; }
            set { this.area = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public int 建筑层数
        {
            get { return this.level; }
            set { this.level = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 建筑物长度
        {
            get { return this.length; }
            set { this.length = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 建筑物宽度
        {
            get { return this.width; }
            set { this.width = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 建筑物高度
        {
            get { return this.height; }
            set { this.height = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 室内外高差
        {
            get { return this.diff; }
            set { this.diff = value; }
        }

        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(FireConverter))]
        public string 工程耐火等级
        {
            get { return this.fire; }
            set { this.fire = value; }
        }

        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(EarthquakeConverter))]
        public string 抗震设防烈度
        {
            get { return this.earthquake; }
            set { this.earthquake = value; }
        }

        public class TypeConverter : System.ComponentModel.StringConverter
        {
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }

            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add("砖混结构");
                list.Add("钢筋混凝土结构");
                return new StandardValuesCollection(list.ToArray());
            }

            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }

        public class FireConverter : System.ComponentModel.StringConverter
        {
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }

            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add("一级");
                list.Add("二级");
                list.Add("三级");
                list.Add("四级");
                return new StandardValuesCollection(list.ToArray());
            }

            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }

        public class EarthquakeConverter : System.ComponentModel.StringConverter
        {
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }

            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add("6度");
                list.Add("7度");
                list.Add("8度");
                list.Add("9度");
                list.Add("不设防");
                return new StandardValuesCollection(list.ToArray());
            }

            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }
    }
}