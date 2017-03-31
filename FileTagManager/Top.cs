using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs; //add 

namespace FileTagManager
{
    public partial class Top : Form
    {
        TagList tagList;

        public Top()
        {
            InitializeComponent();
            tagList = TagList.getTagList(Config.TAGFILE_PATH);
        }

        /// <summary>
        /// 指定されたフォルダのパスから，ファイルの文字列を抽出して，表示する．
        /// </summary>
        /// <param name="selectPath">ファイルを読み込むフォルダのパス</param>
        private void setFileNameView(string selectPath)
        {
            //列がない(=初回)場合は列を追加する
            //元のファイル名表示(1列)+タグ数 
            if (fileNameView.Columns.Count < Config.MAX_TAG_NUM + 1)
            {
                for (int i = 0; i < Config.MAX_TAG_NUM + 1; i++)
                {
                    fileNameView.Columns.Add(new DataGridViewTextBoxColumn());
                }

                //元のファイル名を表示する列
                fileNameView.Columns[0].DataPropertyName = "FileName";
                fileNameView.Columns[0].Name = "FileName";
                fileNameView.Columns[0].HeaderText = "FileName";
            }
            updateHeaderText(); //ヘッダーの更新
            
            fileNameView.Rows.Clear(); //表を初期化

            //指定パスにあるファイルを取得して，行を追加していく(列は0番目)．
            var fullpaths = System.IO.Directory.GetFiles(selectPath, "*");
            foreach (var f in fullpaths)
            {
                //行をset
                fileNameView.Rows.Add(Path.GetFileName(f));
            }
        }

        public void updateHeaderText()
        {
            if (fileNameView.Columns.Count < Config.MAX_TAG_NUM + 1)
                return; //列が足りない(まだ追加されていない)

            //タグ表示列
            for (int i = 0; i < Config.MAX_TAG_NUM; i++)
            {
                //+1は元のファイル名表示列の分
                string tagname = tagList.tags[i].name;
                fileNameView.Columns[i + 1].DataPropertyName = tagname;
                fileNameView.Columns[i + 1].Name = tagname;
                fileNameView.Columns[i + 1].HeaderText = tagname;
            }
        }

        //##############################################################################################################

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 編集対象のフォルダを指定するウインドウを開く．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dirOpenButton_Click(object sender, EventArgs e)
        {
            //フォルダを開くダイアログの準備
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;  // フォルダーを開く設定に
            dialog.EnsureReadOnly = false;
            dialog.AllowNonFileSystemItems = false;
            dialog.DefaultDirectory = Application.StartupPath;

            //フォルダを開く
            var Result = dialog.ShowDialog();
            if (Result == CommonFileDialogResult.Ok)
            {
                //
                this.Text = "File Tag Manager - " + dialog.FileName;
                dirPathText.Text = dialog.FileName;

                setFileNameView(dialog.FileName);
            }
        }

        /// <summary>
        /// タグを編集するウインドウを開く．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goTagConfigButton_Click(object sender, EventArgs e)
        {
            //タグ設定フォームを生成
            TagConfig form = new TagConfig();
            form.ShowDialog(this); //編集終了までTOPには戻らない
            form.Dispose();

            updateHeaderText(); //タグ名が変わっている場合があるため，更新する
        }

        /// <summary>
        /// 抽出設定を基に，文字列を抽出する．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extractTagButton_Click(object sender, EventArgs e)
        {

        }
    }
}
