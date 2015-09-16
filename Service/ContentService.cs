namespace Framework.Service
{
    public interface ContentService
    {
        System.Collections.ArrayList GetChapterByPid(int pid,int type);
        System.Collections.ArrayList GetTemplateByChapter(int cid);
        System.Collections.ArrayList GetContentTemplateByTitle(string title);
        Framework.Entity.Template GetTemplateByTitle(string title);
        System.Collections.ArrayList GetAllModel();
    }
}