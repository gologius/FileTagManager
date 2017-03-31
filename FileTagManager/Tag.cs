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

    /// <summary>
    /// シングルトン．
    /// </summary>
    public class TagList
    {
        private static TagList instance = new TagList(); //シングルトン
        
        public int MAX_TAG_NUM = 3; //登録できる最大数
        public List<Tag> tags = new List<Tag>();

        private TagList()
        {
            //XMLシリアライズでエラーを出さないために必要
        }

        /// <summary>
        /// 指定されたXMLファイルを基にクラス情報を設定して，クラスを戻す．
        /// </summary>
        /// <param name="readFilepath">読み込むXMLファイルのパス</param>
        /// <returns>設定後のクラス</returns>
        public static TagList getTagList(string readFilepath)
        {
            instance.readTagListFile(readFilepath);
            return instance;
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
