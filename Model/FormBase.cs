//using System;
//using System.Collections.Generic;
//using System.Text;
namespace Framework.Model  //ģ�幤�̣�ר��̸ſ�
{
    public class FormBase
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



        [System.ComponentModel.Category("������Ϣ")]
        public string ��������
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [System.ComponentModel.Category("������Ϣ")]
        public string ���̵�ַ
        {
            get { return this.address; }
            set { this.address = value; }
        }

        [System.ComponentModel.Category("������Ϣ")]
        public float �����߶�
        {
            get { return this.height; }
            set { this.height = value; }
        }

        [System.ComponentModel.Category("������Ϣ")]
        public float �������
        {
            get { return this.area; }
            set { this.area = value; }
        }
        [System.ComponentModel.Category("������Ϣ"), System.ComponentModel.TypeConverter(typeof(TypeConverter))]
        public string ����ṹ����
        {
            get { return this.type; }
            set { this.type = value; }
        }
        [System.ComponentModel.Category("������Ϣ"), System.ComponentModel.TypeConverter(typeof(EarthquakeClassConverter))]
        public string ����������
        {
            get { return this.earthquakeclass; }
            set { this.earthquakeclass = value; }
        }
        [System.ComponentModel.Category("������Ϣ"), System.ComponentModel.TypeConverter(typeof(EarthquakeStrengthConverter))]
        public string ��������Ҷ�
        {
            get { return this.earthquakestrength; }
            set { this.earthquakestrength = value; }
        }
        [System.ComponentModel.Category("������Ϣ")]
        public int ���ϲ���
        {
            get { return this.uplayer; }
            set { this.uplayer = value; }
        }
        [System.ComponentModel.Category("������Ϣ")]
        public int ���²���
        {
            get { return this.downlayer; }
            set { this.downlayer = value; }
        }
        [System.ComponentModel.Category("������Ϣ")]
        public string ���赥λ
        {
            get { return this.constructunits; }
            set { this.constructunits = value; }
        }
        [System.ComponentModel.Category("������Ϣ")]
        public string ��Ƶ�λ
        {
            get { return this.designunits; }
            set { this.designunits = value; }
        }
        [System.ComponentModel.Category("������Ϣ")]
        public string ʩ����λ
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
                list.Add("���");
                list.Add("����");
                list.Add("���");
                list.Add("��Ͳ");
                list.Add("Ͳ��Ͳ");
                list.Add("����");
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
                list.Add("����");
                list.Add("����");
                list.Add("����");
                list.Add("����");
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
                list.Add("6��");
                list.Add("7�ȣ�0.1g��");
                list.Add("7�ȣ�0.15g��");
                list.Add("8�ȣ�0.2g��");
                list.Add("8�ȣ�0.3g��");
                list.Add("9��");
                return new StandardValuesCollection(list.ToArray());
            }
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context)
            {
                return true;
            }
        }
    }
}