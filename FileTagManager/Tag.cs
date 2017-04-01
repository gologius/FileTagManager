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

        /// <summary>
        /// 文字列の抽出，置換をする
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public string replace(string target)
        {
            string result = target;

            try
            {
                //正規表現を用いた文字列の抽出
                var regexp = new System.Text.RegularExpressions.Regex(regex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                var m = regexp.Match(result);
                result = m.Value.ToString();


                //文字列置換
                for (int i = 0; i < replaceTexts.Count; i++)
                {
                    string before = replaceTexts[i];
                    string after = replacedTexts[i];

                    //正規表現による対象文文字列の抽出
                    System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(before);
                    System.Text.RegularExpressions.Match m2 = regex2.Match(result);
                    before = m2.Value.ToString();

                    //置換
                    if (before.Length != 0)
                        result = result.Replace(before, after);
                }

            }
            catch (System.NullReferenceException ex)
            {

            }
            

            return result;
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
                    tags.Add(new Tag("tag" + (i + 1).ToString()));
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

        //tag名からindexを割り出す
        public int getTagIndex(string tagname)
        {
            int i = 0;
            for (i = 0; i < tags.Count; i++)
            {
                if (tags[i].name.Equals(tagname))
                    return i;
            }
            
            return -1; //見つからなかった場合
        }
    }
}
