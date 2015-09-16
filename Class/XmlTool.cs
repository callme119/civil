namespace Framework.Class
{
    public static class XmlTool
    {
        private static System.Xml.XmlDocument doc;

        public static System.Xml.XmlDocument GetInstance()
        {
            if (doc == null)
            {
                doc = new System.Xml.XmlDocument();
            }
            return doc;
        }

        public static System.Xml.XmlElement FindChapterByCid(int cid)
        {
            System.Xml.XmlElement element = null;
            string head = "PROJECT/CONTENT";
            string tail = "[@CID=" + cid + "]";
            string chapter = "";
            for (int i = 0; i < 5; i++)
            {
                chapter += "/CHAPTER";
                System.Xml.XmlDocument xmlDoc = GetInstance();
                element = (System.Xml.XmlElement)xmlDoc.SelectSingleNode(head + chapter + tail);
                if (element != null)
                {
                    break;
                }
            }
            return element;
        }
    }
}