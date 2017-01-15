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
        private const int REPLACE_NAME = 0;
        private const int REPLACED_NAME = 1;

        private TagList tagList;
        private int selectTagIndex = -1;
       
        public TagConfig()
        {
            InitializeComponent();

            tagList = new TagList(tagFilePath); //ファイルからデータを読み込む
            
            updateTagComboBox();
            updateTagInfo(tagComboBox.SelectedIndex);
        }

        //表示の更新
        private void updateTagComboBox()
        {
            tagComboBox.Items.Clear(); //全部クリア

            foreach (var tag in tagList.tags)
            {
                tagComboBox.Items.Add(tag.name);
            }
        }

        //表示の更新
        private void updateTagInfo(int index)
        {
            if (index < 0 || index > tagList.tags.Count)
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

        private void debugMsgBox(string str)
        {
            DialogResult result = MessageBox.Show(
                str,
                "確認",
                MessageBoxButtons.OK);
        }

        private int getSelectDataGridRowIndex(ListView view)
        {
            int select_index = -1;

            //選択しているtagのindexを取り出す
            //memo プロパティのMultiSelectをFalseにしておくべき
            foreach (int i in view.SelectedIndices)
            {
                select_index = i;
                break; //一つしか使わないので．特にMultiSelect=Falseにした場合
            }

            return select_index;
        }

        //##############################################################################################################

        //編集終了時
        private void TagConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            tagList.writeTagListFile(tagFilePath);
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            string tag_name = EditTagForm.showAddTagForm();
            if (tag_name.Equals(""))
                return;
        
            
            tagList.tags.Add(new Tag(tag_name));
            updateTagComboBox();

        }

        private void editTagButton_Click(object sender, EventArgs e)
        {
            //選択している行を抽出
            int select_index = tagComboBox.SelectedIndex;
            if (select_index == -1)
                return;

            //確認，削除，更新
            string edit_text = tagList.tags[select_index].name;
            bool do_delete = false;
            EditTagForm.showEditTagForm(ref edit_text, out do_delete);

            //削除時
            if (do_delete)
            {
                DialogResult result = MessageBox.Show(
                  "タグを削除します",
                  "タグ削除の確認",
                  MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    tagList.tags.RemoveAt(select_index);
                    updateTagComboBox();
                }
            }
            //タグ名変更時
            else
            {
                tagList.tags[select_index].name = edit_text;
                updateTagComboBox();
            }
        }

        private void tagListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //変更前に選択していたtagのreplaceTextsViewの内容を保存する
            if (selectTagIndex != -1)
            {
                Tag tag = tagList.tags[selectTagIndex];

                //抽出正規表現の更新
                tag.regex = regexpText.Text;

                //置換文字列の更新
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
                    debugMsgBox(replace_text);
                }
            }

            selectTagIndex = tagComboBox.SelectedIndex;
            
            //表示の更新
            updateTagInfo(selectTagIndex);
        }

       
    }
}
