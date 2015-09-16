namespace Framework.Class
{
    public static class GlobalData
    {
        private static System.Collections.Hashtable store = new System.Collections.Hashtable();

        public static object GetValue(object key)
        {
            return store[key];
        }

        public static void SetValue(object key, object value)
        {
            store.Add(key, value);
        }
    }
}