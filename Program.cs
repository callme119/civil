namespace Framework
{
    static class Program
    {
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Frmlogin Frmlogin = new Frmlogin();
            Frmlogin.Show();
            System.Windows.Forms.Application.Run( );
        }
    }
}