using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTagManager
{
    class Config
    {
        public static int MAX_TAG_NUM = 3;
        public static string outputFormat = @"[%Author%] %Title%";

        public static string TAGFILE_PATH = @"taglist.xml";
        public static string CONFIG_FILE_PATH = @"config.xml";

        public void loadFile()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Config));
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(CONFIG_FILE_PATH, new System.Text.UTF8Encoding(false));
                Config config = (Config)serializer.Deserialize(sr);
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                //新しくファイルを作成する
                saveFile();
            }
        }

        public void saveFile()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Config));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(CONFIG_FILE_PATH, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, this);
            sw.Close();
        }
    }
}
