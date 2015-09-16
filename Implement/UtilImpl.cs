namespace Framework.Implement
{
    public class UtilImpl : Framework.Service.BaseService, Framework.Service.UtilService
    {
        private System.Data.IDbConnection conn;

        public UtilImpl()
        {
            this.conn = Framework.Config.Connection.SQLiteConn();
        }

        protected override System.Data.IDbConnection getConnection
        {
            get { return this.conn; }
        }

        public void Insert(object entity)
        {
            using (this.getConnection)
            {
                this.getConnection.Open();
                System.Data.IDbCommand cmd = this.getConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                object obj;
                switch (Framework.Class.PackageEntity.Dispatcher(entity))
                {
                    case 1:
                        cmd.CommandText = "SELECT MAX(M_Id) + 1 FROM FW_Module";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.Module module = (Framework.Entity.Module)entity;
                        module.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO FW_Module (M_Id,M_Title,M_Class,M_Pid,M_Level,M_Order,M_Image,M_Position) VALUES (@Id,@Title,@Class,@Pid,@Level,@Order,@Image,@Position)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", module.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", module.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Class", module.Class));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Pid", module.Pid));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Level", module.Level));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Order", module.Order));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Image", module.Image));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Position", module.Position));
                        break;
                    case 2:
                        cmd.CommandText = "SELECT MAX(R_Id) + 1 FROM FW_Role";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.Role role = (Framework.Entity.Role)entity;
                        role.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO FW_Role (R_Id,R_Name,R_Mark,R_Modules) VALUES (@Id,@Name,@Mark,@Modules)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", role.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", role.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Mark", role.Mark));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Modules", role.Modules));
                        break;
                    case 3:
                        cmd.CommandText = "SELECT MAX(U_Id) + 1 FROM FW_User";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.User user = (Framework.Entity.User)entity;
                        user.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO FW_User (U_Id,U_Name,U_Password,U_Roles) VALUES (@Id,@Name,@Password,@Roles)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", user.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", user.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Password", user.Password));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Roles", user.Roles));
                        break;
                    case 4:
                        cmd.CommandText = "SELECT MAX(C_Id) + 1 FROM CB_Chapter";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)entity;
                        chapter.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO CB_Chapter (C_Id,C_Pid,C_Title,C_Description,C_State,M_Id,D_Id,C_Type) VALUES (@Id,@Pid,@Title,@Description,@State,@Module,@Model,@Type)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", chapter.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Pid", chapter.Pid));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", chapter.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Description", chapter.Description));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", chapter.State));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Module", chapter.Module));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Model", chapter.Model));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Type", chapter.Type));
                        break;
                    case 5:
                        cmd.CommandText = "SELECT MAX(T_Id) + 1 FROM CB_Template";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.Template template = (Framework.Entity.Template)entity;
                        template.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO CB_Template (T_Id,T_Title,T_Key,C_Id,T_Content,T_State,T_Type) VALUES (@Id,@Title,@Key,@Chapter,@Content,@State,@Type)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", template.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", template.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Key", template.Key));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Chapter", template.Chapter));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Content", template.Content));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", template.State));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Type", template.Type));
                        break;
                    case 6:
                        cmd.CommandText = "SELECT MAX(D_Id) + 1 FROM CB_Model";
                        obj = cmd.ExecuteScalar();
                        Framework.Entity.Model model = (Framework.Entity.Model)entity;
                        model.Id = System.Convert.ToInt32(obj == System.DBNull.Value ? 1 : obj);
                        cmd.CommandText = @"INSERT INTO CB_Model (D_Id,D_Name,D_Class,D_Description,D_State) VALUES (@Id,@Name,@Class,@Description,@State)";
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Id", model.Id));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", model.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Class", model.Class));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Description", model.Description));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", model.State));
                        break;
                }
                cmd.ExecuteNonQuery();
                this.getConnection.Close();
            }
        }

        public void Delete(object entity)
        {
            using (this.getConnection)
            {
                this.getConnection.Open();
                System.Data.IDbCommand cmd = this.getConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                switch (Framework.Class.PackageEntity.Dispatcher(entity))
                {
                    case 1:
                        Framework.Entity.Module module = (Framework.Entity.Module)entity;
                        cmd.CommandText = "DELETE FROM FW_Module WHERE M_Id = " + module.Id;
                        break;
                    case 2:
                        Framework.Entity.Role role = (Framework.Entity.Role)entity;
                        cmd.CommandText = "DELETE FROM FW_Role WHERE R_Id = " + role.Id;
                        break;
                    case 3:
                        Framework.Entity.User user = (Framework.Entity.User)entity;
                        cmd.CommandText = "DELETE FROM FW_User WHERE U_Id = " + user.Id;
                        break;
                    case 4:
                        Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)entity;
                        cmd.CommandText = "DELETE FROM CB_Chapter WHERE C_Id = " + chapter.Id;
                        break;
                    case 5:
                        Framework.Entity.Template template = (Framework.Entity.Template)entity;
                        cmd.CommandText = "DELETE FROM CB_Template WHERE T_Id = " + template.Id;
                        break;
                    case 6:
                        Framework.Entity.Model model = (Framework.Entity.Model)entity;
                        cmd.CommandText = "DELETE FROM CB_Model WHERE D_Id = " + model.Id;
                        break;
                }
                cmd.ExecuteReader();
                this.getConnection.Close();
            }
        }

        public void Update(object entity)
        {
            using (this.getConnection)
            {
                this.getConnection.Open();
                System.Data.IDbCommand cmd = this.getConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                switch (Framework.Class.PackageEntity.Dispatcher(entity))
                {
                    case 1:
                        Framework.Entity.Module module = (Framework.Entity.Module)entity;
                        cmd.CommandText = @"UPDATE FW_Module SET M_Title = @Title, M_Class = @Class, M_Pid = @Pid, M_Level = @Level, M_Order = @Order, M_Image = @Image, M_Position = @Position  WHERE M_Id = " + module.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", module.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Class", module.Class));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Pid", module.Pid));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Level", module.Level));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Order", module.Order));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Image", module.Image));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Position", module.Position));
                        break;
                    case 2:
                        Framework.Entity.Role role = (Framework.Entity.Role)entity;
                        cmd.CommandText = @"UPDATE FW_Role SET R_Name = @Name, R_Mark = @Mark, R_Modules = @Modules WHERE R_Id = " + role.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", role.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Mark", role.Mark));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Modules", role.Modules));
                        break;
                    case 3:
                        Framework.Entity.User user = (Framework.Entity.User)entity;
                        cmd.CommandText = @"UPDATE FW_User SET U_Name = @Name, U_Password = @Password, U_Roles = @Roles WHERE U_Id = " + user.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", user.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Password", user.Password));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Roles", user.Roles));
                        break;
                    case 4:
                        Framework.Entity.Chapter chapter = (Framework.Entity.Chapter)entity;
                        cmd.CommandText = "UPDATE CB_Chapter SET C_Pid = @Pid, C_Title = @Title, C_Description = @Description, C_State = @State, M_Id = @Module, D_Id = @Model ,C_Type= @Type  WHERE C_Id = " + chapter.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Pid", chapter.Pid));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", chapter.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Description", chapter.Description));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", chapter.State));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Module", chapter.Module));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Model", chapter.Model));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Type", chapter.Type));
                        break;
                    case 5:
                        Framework.Entity.Template template = (Framework.Entity.Template)entity;
                        cmd.CommandText = "UPDATE CB_Template SET T_Title = @Title, T_Key = @Key, C_Id = @Chapter, T_Content = @Content, T_State = @State, T_Type = @Type WHERE T_Id = " + template.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Title", template.Title));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Key", template.Key));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Chapter", template.Chapter));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Content", template.Content));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", template.State));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Type", template.Type));
                        break;
                    case 6:
                        Framework.Entity.Model model = (Framework.Entity.Model)entity;
                        cmd.CommandText = "UPDATE CB_Model SET D_Name = @Name, D_Class = @Class, D_Description = @Description, D_State = @State WHERE D_Id = " + model.Id;
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Name", model.Name));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Class", model.Class));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@Description", model.Description));
                        cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("@State", model.State));
                        break;
                }
                cmd.ExecuteReader();
                this.getConnection.Close();
            }
        }

        public object FindById(object entity, int id)
        {
            using (this.getConnection)
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                this.getConnection.Open();
                System.Data.IDbCommand cmd = this.getConnection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                switch (Framework.Class.PackageEntity.Dispatcher(entity))
                {
                    case 1:
                        cmd.CommandText = "SELECT * FROM FW_Module WHERE M_Id = " + id;
                        break;
                    case 2:
                        cmd.CommandText = "SELECT * FROM FW_Role WHERE R_Id = " + id;
                        break;
                    case 3:
                        cmd.CommandText = "SELECT * FROM FW_User WHERE U_Id = " + id;
                        break;
                    case 4:
                        cmd.CommandText = "SELECT * FROM CB_Chapter WHERE C_Id = " + id;
                        break;
                    case 5:
                        cmd.CommandText = "SELECT * FROM CB_Template WHERE T_Id = " + id;
                        break;
                    case 6:
                        cmd.CommandText = "SELECT * FROM CB_Model WHERE D_Id = " + id;
                        break;
                }
                System.Data.IDbDataAdapter adapter = new System.Data.SQLite.SQLiteDataAdapter((System.Data.SQLite.SQLiteCommand)cmd);
                adapter.Fill(ds);
                System.Collections.ArrayList alist = Framework.Class.PackageEntity.Package(entity, ds.Tables[0]);
                this.getConnection.Close();
                return alist[0];
            }
        }
    }
}