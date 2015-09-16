namespace Framework.Implement
{
    public class ContentImpl : Framework.Service.BaseService, Framework.Service.ContentService
    {
        private System.Data.IDbConnection conn;

        public ContentImpl()
        {
            this.conn = Framework.Config.Connection.SQLiteConn();
        }

        protected override System.Data.IDbConnection getConnection
        {
            get { return this.conn; }
        }

        public System.Collections.ArrayList GetChapterByPid(int pid,int type)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM CB_Chapter WHERE C_Pid = " + pid + " AND (C_Type=" + type + " OR C_Type='9')";
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Chapter(), ds.Tables[0]);
            }
        }

        public System.Collections.ArrayList GetTemplateByChapter(int cid)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM CB_Template WHERE C_Id = " + cid;
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Template(), ds.Tables[0]);
            }
        }

        public System.Collections.ArrayList GetContentTemplateByTitle(string title)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM CB_Template WHERE C_Id IN ( SELECT C_Id FROM CB_Chapter WHERE C_Title = '" + title + "')";
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Template(), ds.Tables[0]);
            }
        }

        public Framework.Entity.Template GetTemplateByTitle(string title)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM CB_Template WHERE T_Title = '" + title + "'";
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                System.Collections.ArrayList alist = Framework.Class.PackageEntity.Package(new Framework.Entity.Template(), ds.Tables[0]);
                return (Framework.Entity.Template)alist[0];
            }
        }

        public System.Collections.ArrayList GetAllModel()
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM CB_Model";
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Model(), ds.Tables[0]);
            }
        }
    }
}