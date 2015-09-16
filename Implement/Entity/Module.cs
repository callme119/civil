namespace Framework.Entity
{
    public class Module
    {
        public static int ROOT = 0, CHILD = 1;
        public static int ALL = -1, MENU = 0, CONTENT = 1;
        public int Id;
        public string Title;
        public string Class;
        public int Pid;
        public int Level;
        public int Order;
        public int Image;
        public int Position;
    }
}