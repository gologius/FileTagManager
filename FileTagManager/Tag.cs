using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTagManager
{
    public class Tag
    {
        public string name = "";
        public string regex = "";
        public List<string> replaceTexts = new List<string>(); //置換対象の文字列リスト
        public List<string> replacedTexts = new List<string>(); //置換後の文字列リスト

        public Tag()
        {
            //XMLシリアライズでエラーを出さないために必要
        }

        public Tag(string name_)
        {
            this.name = name_;
        }
    }

    public class TagList
    {
        public int MAX_TAG_NUM = 3; //登録できる最大数
        public List<Tag> tags = new List<Tag>();

        public TagList()
        {
            //XMLシリアライズでエラーを出さないために必要
        }

        public TagList(string readFilepath)
        {
            readTagListFile(readFilepath);
        }

        //ファイルからタグデータを読み込む
        public void readTagListFile(string filepath)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(TagList));

            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(filepath, new System.Text.UTF8Encoding(false));
                TagList readObj = (TagList)serializer.Deserialize(sr);
                sr.Close();
                this.tags = readObj.tags; //読み込んだオブジェクトの中身をコピー (todo 直接代入)
            }
            catch (FileNotFoundException e)
            {
                //最大数までタグを生成しておく
                for (int i = 0; i < MAX_TAG_NUM; i++)
                {
                    tags.Add(new Tag("tag"+(i+1).ToString()));
                }

                writeTagListFile(filepath); //ファイルを新規に作成する
            }
        }

        //ファイルにタグ情報を書き出す
        public void writeTagListFile(string filepath)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(TagList));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, this);
            sw.Close();
        }

    }
}
