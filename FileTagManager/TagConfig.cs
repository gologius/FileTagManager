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
        private const int REPLACE_NAME = 0;
        private const int REPLACED_NAME = 1;

        private TagList tagList;
        private int selectTagIndex = -1;

        public TagConfig()
        {
            InitializeComponent();

            tagList = TagList.getTagList(Config.TAGFILE_PATH);
           
            updateTagComboBox();
            updateFormInfo(tagComboBox.SelectedIndex);
        }

        /// <summary>
        /// 選択用ComboBoxの表示更新．
        /// </summary>
        private void updateTagComboBox()
        {
            tagComboBox.Items.Clear();
            foreach (var tag in tagList.tags)
            {
                tagComboBox.Items.Add(tag.name);
            }
        }

        /// <summary>
        /// 選択されたタグに合わせて，Form全体の表示を更新する．
        /// </summary>
        /// <param name="index"></param>
        private void updateFormInfo(int index)
        {
            if (index < 0 || index > tagList.tags.Count)
                return;

            Tag tag = tagList.tags[index];

            tagNameText.Text = tag.name;
            regexpText.Text = tag.regex; //抽出用正規表現の更新

            //置換表の更新
            replaceTextsView.Rows.Clear(); //全部クリア
            for (int i = 0; i < tag.replaceTexts.Count; i++)
            {
                replaceTextsView.Rows.Add(
                    tag.replaceTexts[i],
                    tag.replacedTexts[i]);
            }
        }

        /// <summary>
        /// TagListにフォームのデータを反映する．
        /// <param name="index">更新するタグのindex</param>
        /// </summary>
        private void updateTagList(int index)
        {
            //変更前に選択していたtagのreplaceTextsViewの内容を保存する
            if (index != -1)
            {
                Tag tag = tagList.tags[index];

                tag.name = tagNameText.Text;
                tag.regex = regexpText.Text;

                //置換文字列の更新
                tag.replaceTexts.Clear(); //初期化
                tag.replacedTexts.Clear();
                foreach (var row in replaceTextsView.Rows.Cast<DataGridViewRow>())
                {
                    //置換前が空なら，挿入しない
                    if (row.Cells[REPLACE_NAME].Value == null)
                        continue;
                    //置換後が空なら，空文字列を挿入する
                    else if (row.Cells[REPLACED_NAME].Value == null) 
                        row.Cells[REPLACED_NAME].Value = "";

                    string replace_text = row.Cells[REPLACE_NAME].Value.ToString();
                    string replaced_text = row.Cells[REPLACED_NAME].Value.ToString();
                    tag.replaceTexts.Add(replace_text);
                    tag.replacedTexts.Add(replaced_text);
                }
            }
        }

        private void debugMsgBox(string str)
        {
            DialogResult result = MessageBox.Show(
                str,
                "確認",
                MessageBoxButtons.OK);
        }

        //##############################################################################################################

        /// <summary>
        /// ウィンドウを閉じたときに呼び出される関数．
        /// ファイルに情報を保存する．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TagConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateTagList(selectTagIndex); //フォームの情報を保存
            tagList.writeTagListFile(Config.TAGFILE_PATH); //ファイルへの設定の保存
        }

        /// <summary>
        /// タグを追加する．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTagButton_Click(object sender, EventArgs e)
        {
            string tag_name = EditTagForm.showAddTagForm();
            if (tag_name.Equals(""))
                return;


            tagList.tags.Add(new Tag(tag_name));
            updateTagComboBox();

        }

        /// <summary>
        /// 編集したい行の選択完了時に処理される関数．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagComboBox_TextChanged(object sender, EventArgs e)
        {
            //クラスにフォームの値を保存
            updateTagList(selectTagIndex); 

            //更新
            selectTagIndex = tagComboBox.SelectedIndex;
            updateFormInfo(selectTagIndex);           
        }


    }
}
