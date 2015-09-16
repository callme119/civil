namespace Framework.Config
{
    internal class Connection
    {
        internal static System.Data.IDbConnection SQLiteConn()
        {
            string strConn = System.Windows.Forms.Application.StartupPath + "//Database.db";
            System.Data.SQLite.SQLiteConnectionStringBuilder strBuild = new System.Data.SQLite.SQLiteConnectionStringBuilder();
            strBuild.DataSource = strConn;
            System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(strBuild.ToString());
            return conn;
        }
    }
}