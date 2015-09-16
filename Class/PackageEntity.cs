namespace Framework.Class
{
    public static class PackageEntity
    {
        public static System.Collections.ArrayList Package(object entity, System.Data.DataTable dt)
        {
            System.Collections.ArrayList result = new System.Collections.ArrayList();
            switch (Dispatcher(entity))
            {
                case 1:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.Module module = new Framework.Entity.Module();
                        module.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        module.Title = System.Convert.ToString(dt.Rows[i][1]);
                        module.Class = System.Convert.ToString(dt.Rows[i][2]);
                        module.Pid = System.Convert.ToInt32(dt.Rows[i][3]);
                        module.Level = System.Convert.ToInt32(dt.Rows[i][4]);
                        module.Order = System.Convert.ToInt32(dt.Rows[i][5]);
                        module.Image = System.Convert.ToInt32(dt.Rows[i][6]);
                        module.Position = System.Convert.ToInt32(dt.Rows[i][7]);
                        result.Add(module);
                    }
                    break;
                case 2:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.Role role = new Framework.Entity.Role();
                        role.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        role.Name = System.Convert.ToString(dt.Rows[i][1]);
                        role.Mark = System.Convert.ToString(dt.Rows[i][2]);
                        role.Modules = System.Convert.ToString(dt.Rows[i][3]);
                        result.Add(role);
                    }
                    break;
                case 3:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.User user = new Framework.Entity.User();
                        user.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        user.Name = System.Convert.ToString(dt.Rows[i][1]);
                        user.Password = System.Convert.ToString(dt.Rows[i][2]);
                        user.Roles = System.Convert.ToString(dt.Rows[i][3]);
                        result.Add(user);
                    }
                    break;
                case 4:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.Chapter chapter = new Framework.Entity.Chapter();
                        chapter.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        chapter.Pid = System.Convert.ToInt32(dt.Rows[i][1]);
                        chapter.Title = System.Convert.ToString(dt.Rows[i][2]);
                        chapter.Description = System.Convert.ToString(dt.Rows[i][3]);
                        chapter.State = System.Convert.ToInt32(dt.Rows[i][4]);
                        chapter.Module = System.Convert.ToInt32(dt.Rows[i][5]);
                        chapter.Model = System.Convert.ToInt32(dt.Rows[i][6]);
                        chapter.Type = System.Convert.ToInt32(dt.Rows[i][7]);
                        result.Add(chapter);
                    }
                    break;
                case 5:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.Template template = new Framework.Entity.Template();
                        template.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        template.Title = System.Convert.ToString(dt.Rows[i][1]);
                        template.Key = System.Convert.ToString(dt.Rows[i][2]);
                        template.Chapter = System.Convert.ToInt32(dt.Rows[i][3]);
                        template.Content = (byte[])dt.Rows[i][4];
                        template.State = System.Convert.ToInt32(dt.Rows[i][5]);
                        template.Type = System.Convert.ToInt32(dt.Rows[i][6]);
                        result.Add(template);
                    }
                    break;
                case 6:
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Framework.Entity.Model model = new Framework.Entity.Model();
                        model.Id = System.Convert.ToInt32(dt.Rows[i][0]);
                        model.Name = System.Convert.ToString(dt.Rows[i][1]);
                        model.Class = System.Convert.ToString(dt.Rows[i][2]);
                        model.Description = System.Convert.ToString(dt.Rows[i][3]);
                        model.State = System.Convert.ToInt32(dt.Rows[i][4]);
                        result.Add(model);
                    }
                    break;
            }
            return result;
        }

        public static int Dispatcher(object entity)
        {
            int n = 0;
            if (entity.GetType().Equals(typeof(Framework.Entity.Module)))
            {
                n = 1;
            }
            else if (entity.GetType().Equals(typeof(Framework.Entity.Role)))
            {
                n = 2;
            }
            else if (entity.GetType().Equals(typeof(Framework.Entity.User)))
            {
                n = 3;
            }
            else if (entity.GetType().Equals(typeof(Framework.Entity.Chapter)))
            {
                n = 4;
            }
            else if (entity.GetType().Equals(typeof(Framework.Entity.Template)))
            {
                n = 5;
            }
            else if (entity.GetType().Equals(typeof(Framework.Entity.Model)))
            {
                n = 6;
            }
            return n;
        }
    }
}