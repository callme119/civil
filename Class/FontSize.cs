namespace Framework.Class
{
    public class FontSize
    {
        private int fs_value;
        private static System.Collections.Generic.List<FontSize> fontSizeList = null;

        public int Value
        {
            get { return fs_value; }
        }

        public static System.Collections.Generic.List<FontSize> FontSizeList
        {
            get
            {
                if (fontSizeList == null)
                {
                    fontSizeList = new System.Collections.Generic.List<FontSize>();
                    fontSizeList.Add(new FontSize(8));
                    fontSizeList.Add(new FontSize(10));
                    fontSizeList.Add(new FontSize(12));
                    fontSizeList.Add(new FontSize(14));
                    fontSizeList.Add(new FontSize(18));
                    fontSizeList.Add(new FontSize(24));
                    fontSizeList.Add(new FontSize(36));
                }
                return fontSizeList;
            }
        }

        public FontSize(int value)
        {
            this.fs_value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}