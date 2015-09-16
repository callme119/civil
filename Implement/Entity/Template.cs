namespace Framework.Entity
{
    public class Template
    {
        public static int UNLOCK = 0, LOCK = 1;
        public static int RTF = 0, DOC = 1, XLS = 2;
        public int Id;
        public string Title;
        public string Key;
        public int Chapter;
        public byte[] Content;
        public int State;
        public int Type;
    }
}