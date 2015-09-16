namespace Framework.Class
{
    public class ComboItem
    {
        private string cb_text;
        private object cb_value;

        public string Text
        {
            get { return cb_text; }
            set { cb_text = value; }
        }

        public object Value
        {
            get { return cb_value; }
            set { cb_value = value; }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}