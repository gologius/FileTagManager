using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTagManager
{
    class Tag
    {
        string name;
        List<string> replaceTexts = new List<string>(); //置換対象の文字列リスト
        List<string> replacesTexts = new List<string>(); //置換後の文字列リスト

    }

    class TagList
    {
        List<Tag> tags = new List<Tag>();

        //ファイルからタグデータを読み込む
        public void readTagListFile(string filepath)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(TagList));

            System.IO.StreamReader sr = new System.IO.StreamReader(filepath, new System.Text.UTF8Encoding(false));
            TagList readObj = (TagList)serializer.Deserialize(sr);
            sr.Close();

            this.tags = readObj.tags; //コピー
        }

        //ファイルにタグ情報を書き出す
        public void writeTagListFile(string filepath)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(TagList));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                filepath, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, this);
            sw.Close();
        }

    }
}
