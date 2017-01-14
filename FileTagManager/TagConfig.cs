using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTagManager
{
    public partial class TagConfig : Form
    {
        private string tagFilePath = @"taglist.xml"; //todo configへ
        private const int TAG_NAME = 0;

        public TagConfig()
        {
            InitializeComponent();

            updateTagListView();
            updateReplaceView();
        }

        //表示の更新
        private void updateTagListView()
        {
            tagListView.Rows.Clear(); //全部クリア

            TagList tagList = new TagList(tagFilePath); //ファイルからデータを読み込む
            foreach (var tag in tagList.tags)
            {
                tagListView.Rows.Add(tag.name);
            }
        }

        //表示の更新
        private void updateReplaceView()
        {

        }

        //編集終了時
        private void TagConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            TagList tagList = new TagList(); //ここにデータを挿入する

            //タグ名の読み取りと挿入
            foreach (var row in tagListView.Rows.Cast<DataGridViewRow>())
            {
                foreach (var cell in row.Cells.Cast<DataGridViewCell>())
                {
                    if (cell.Value != null)
                        tagList.tags.Add(new Tag(cell.Value.ToString()));
                }
            }

            tagList.writeTagListFile(tagFilePath);
        }

        private void debugMsgBox(string str)
        {
            DialogResult result = MessageBox.Show(
                str, 
                "確認",
                MessageBoxButtons.OK);
        }
    }
}
