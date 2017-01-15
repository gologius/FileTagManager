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
        private const int REPLACE_NAME = 0;
        private const int REPLACED_NAME = 1;

        private TagList tagList;
       
        public TagConfig()
        {
            InitializeComponent();

            tagList = new TagList(tagFilePath); //ファイルからデータを読み込む
            
            updateTagListView();
            updateReplaceView(getSelectDataGridRowIndex(tagListView));
        }

        //表示の更新
        private void updateTagListView()
        {
            tagListView.Rows.Clear(); //全部クリア

            foreach (var tag in tagList.tags)
            {
                tagListView.Rows.Add(tag.name);
            }
        }

        //表示の更新
        private void updateReplaceView(int index)
        {
            if (index < 0 || index <= tagList.tags.Count)
                return;

            replaceTextsView.Rows.Clear(); //全部クリア

            Tag tag = tagList.tags[index];
            for (int i = 0; i < tag.replaceTexts.Count; i++)
            {
                replaceTextsView.Rows.Add(
                    tag.replaceTexts[i],
                    tag.replacedTexts[i]);
            }
        }

        //編集終了時
        private void TagConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
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
            */
            tagList.writeTagListFile(tagFilePath);
        }

        private void debugMsgBox(string str)
        {
            DialogResult result = MessageBox.Show(
                str,
                "確認",
                MessageBoxButtons.OK);
        }

        private int getSelectDataGridRowIndex(DataGridView view)
        {
            int select_index = -1;

            //選択しているtagのindexを取り出す
            //memo プロパティのMultiSelectをFalseにしておくべき
            foreach (var row in view.SelectedRows.Cast<DataGridViewRow>())
            {
                select_index = row.Index;
                break; //一つしか使わないので．特にMultiSelect=Falseにした場合
            }

            return select_index;
        }

        //##############################################################################################################

        private void tagListView_SelectionChanged(object sender, EventArgs e)
        {
            //変更前に選択していたtagのreplaceTextsViewの内容を保存する


            int select_index = getSelectDataGridRowIndex(tagListView);
            if (select_index != -1)
            {
                Tag tag = tagList.tags[select_index];
                tag.replaceTexts.Clear(); //初期化
                tag.replacedTexts.Clear();
                foreach (var row in replaceTextsView.Rows.Cast<DataGridViewRow>())
                {
                    string replace_text = "";
                    string replaced_text = "";
                    if (row.Cells[REPLACE_NAME].Value != null)
                        replace_text = row.Cells[REPLACE_NAME].Value.ToString();
                    if (row.Cells[REPLACED_NAME].Value != null)
                        replaced_text = row.Cells[REPLACED_NAME].Value.ToString();

                    tag.replaceTexts.Add(replace_text);
                    tag.replacedTexts.Add(replaced_text);
                }
            }

            //表示の更新
            updateReplaceView(select_index);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            string tag_name = AddTagForm.showConfirmForm();
            if (tag_name.Equals(""))
                return;
        
            
            tagList.tags.Add(new Tag(tag_name));
            updateTagListView();

        }

        private void deleteTagButton_Click(object sender, EventArgs e)
        {
            //選択している行を抽出
            int select_index = getSelectDataGridRowIndex(tagListView);
            if (select_index == -1)
                return;

            //確認，削除，更新
            DialogResult result = MessageBox.Show(
              "タグを削除します",
              "タグ削除の確認",
              MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                tagList.tags.RemoveAt(select_index);
                updateTagListView();
            }
        }

       
    }
}
