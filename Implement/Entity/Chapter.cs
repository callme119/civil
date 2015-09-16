namespace Framework.Entity
{
    public class Chapter
    {
        public static int UNLOCK = 0, LOCK = 1;
        public static int ROOT = 0;
        public int Id;
        public int Pid;
        public string Title;
        public string Description;
        public int State;
        public int Module;
        public int Model;
        public int Type;
    }
}