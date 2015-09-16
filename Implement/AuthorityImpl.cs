namespace Framework.Implement
{
    public class AuthorityImpl : Framework.Service.BaseService, Framework.Service.AuthorityService
    {
        private System.Data.IDbConnection conn;

        public AuthorityImpl()
        {
            this.conn = Framework.Config.Connection.SQLiteConn();
        }

        protected override System.Data.IDbConnection getConnection
        {
            get { return this.conn; }
        }

        public System.Collections.ArrayList GetRootModule(int position)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (position == Framework.Entity.Module.ALL)
                {
                    cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Level = " + Framework.Entity.Module.ROOT + "";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Level = " + Framework.Entity.Module.ROOT + " AND M_Position = " + position;
                }
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Module(), ds.Tables[0]);
            }
        }

        public System.Collections.ArrayList GetModuleByPid(int pid, int position)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (position == Framework.Entity.Module.ALL)
                {
                    cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Level = " + Framework.Entity.Module.CHILD + " AND M_Pid = " + pid;
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Level = " + Framework.Entity.Module.CHILD + " AND M_Pid = " + pid + " AND M_Position = " + position;
                }
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Module(), ds.Tables[0]);
            }
        }

        public System.Collections.ArrayList GetContentModule()
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                System.Data.IDbCommand cmd = this.conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Level = " + Framework.Entity.Module.CHILD + " AND M_Position = " + Framework.Entity.Module.CONTENT;
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                return Framework.Class.PackageEntity.Package(new Framework.Entity.Module(), ds.Tables[0]);
            }
        }
    }
}