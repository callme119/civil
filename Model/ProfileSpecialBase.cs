//using System;
//using System.Collections.Generic;
//using System.Text;

namespace Framework.Model  //脚手架专项工程，专项工程概况
{
    public  class ProfileSpecialBase
    {
        private string name;
        private string address;
        private float height;
        private float area;
        private string type;
        private string earthquakeclass;
        private string earthquakestrength;
        private int uplayer;
        private int downlayer;
        private string constructunits;
        private string designunits;
        private string buildunits;

       

        [System.ComponentModel.Category("基本信息")]
        public string 工程名称
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public string 工程地址
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 建筑高度
        {
            get { return this.height; }
            set { this.height = value; }
        }

        [System.ComponentModel.Category("基本信息")]
        public float 建筑面积
        {
            get { return this.area; }
            set { this.area = value; }
        }
        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(TypeConverter))]
        public string 主体结构类型
        {
            get { return this.type; }
            set { this.type = value; }
        }
        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(EarthquakeClassConverter))]
        public string 抗震设防类别
        {
            get { return this.earthquakeclass; }
            set { this.earthquakeclass = value; }
        }
        [System.ComponentModel.Category("基本信息"), System.ComponentModel.TypeConverter(typeof(EarthquakeStrengthConverter))]
        public string 抗震设防烈度
        {
            get { return this.earthquakestrength; }
            set { this.earthquakestrength = value; }
        }
        [System.ComponentModel.Category("基本信息")]
        public int 地上层数
        {
            get { return this.uplayer; }
            set { this.uplayer = value; }
        }
        [System.ComponentModel.Category("基本信息")]
        public int 地下层数
        {
            get { return this.downlayer; }
            set { this.downlayer = value; }
        }
        [System.ComponentModel.Category("基本信息")]
        public string 建设单位
        {
            get { return this.constructunits; }
            set { this.constructunits = value; }
        }
        [System.ComponentModel.Category("基本信息")]
        public string 设计单位
        {
            get { return this.designunits; }
            set { this.designunits = value; }
        }
        [System.ComponentModel.Category("基本信息")]
        public string 施工单位
        {
            get { return this.buildunits; }
            set { this.buildunits = value; }
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
                list.Add("框架");
                list.Add("砌体");
                list.Add("框剪");
                list.Add("框筒");
                list.Add("筒中筒");
                list.Add("其它");
                return new StandardValuesCollection(list.ToArray());
            }
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }
        public class EarthquakeClassConverter : System.ComponentModel.StringConverter
        {
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add("甲类");
                list.Add("乙类");
                list.Add("丙类");
                list.Add("丁类");
                return new StandardValuesCollection(list.ToArray());
            }
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }
        public class EarthquakeStrengthConverter : System.ComponentModel.StringConverter
        {
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context)
            {
                System.Collections.ArrayList list = new System.Collections.ArrayList();
                list.Add("6度");
                list.Add("7度（0.1g）");
                list.Add("7度（0.15g）");
                list.Add("8度（0.2g）");
                list.Add("8度（0.3g）");
                list.Add("9度");
                return new StandardValuesCollection(list.ToArray());
            }
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }
    }
}
