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
        List<string> replaceTexts; //置換対象の文字列リスト
        List<string> replacesTexts; //置換後の文字列リスト

        //ファイルからタグデータを読み込む
        public static void readTagFile(string filepath)
        {

        }

        //ファイルにタグ情報を書き出す
        public static void writeTagFile(string filepath)
        {

        }
    }
}
