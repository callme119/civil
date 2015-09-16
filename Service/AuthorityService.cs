namespace Framework.Service
{
    public interface AuthorityService
    {
        System.Collections.ArrayList GetRootModule(int position);
        System.Collections.ArrayList GetModuleByPid(int pid, int position);
        System.Collections.ArrayList GetContentModule();
    }
}