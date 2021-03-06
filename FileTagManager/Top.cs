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
        private string currentPath = "";
        private TagList tagList;
        private ImagePreviewForm imgform;
        private int prevSelectRow = -1; //前回選択していたセル行番号

        public Top()
        {
            InitializeComponent();

            //ファイルのD&Dにて起動されたなら（＝コマンドライン引数で、ファイルパスが設定されているなら）
            string path = "";
            string[] cmds = System.Environment.GetCommandLineArgs();
            if (cmds.Count() == 2)
            {
                path = cmds[1];
            }

            init(path);
        }

        /// <summary>
        /// 初期化関数。別ボタンからも使用するので別関数化している。
        /// </summary>
        private void init(string path = "")
        {
            tagList = TagList.getTagList(Config.TAGFILE_PATH); //タグ設定情報を読み込み

            if (path == "")
            {
                return;
            }

            path = System.IO.Path.GetDirectoryName(path); //ファイル名が紛れ込んでいる場合、それを削除する
            this.currentPath = path;
            updateFileNameView(this.currentPath);
        }

        /// <summary>
        /// fileNameViewから値を得るためのラッパー
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="colIndex"></param>
        /// <returns>getValue</returns>
        private string getViewValue(int rowIndex, int colIndex)
        {
            return fileNameView.Rows[rowIndex].Cells[colIndex].Value.ToString();
        }

        /// <summary>
        /// fileNameViewから値を得るためのラッパー
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="colIndex"></param>
        /// <returns></returns>
        private void setValue(int rowIndex, int colIndex, string value)
        {
            fileNameView.Rows[rowIndex].Cells[colIndex].Value = value;
        }

        /// <summary>
        /// 指定されたフォルダのパスから，ファイルの文字列を表示する．
        /// </summary>
        /// <param name="selectPath">ファイルを読み込むフォルダのパス</param>
        private void updateFileNameView(string selectPath)
        {
            if (currentPath.Equals(""))
                return;

            //GUIの更新
            this.Text = "File Tag Manager - " + currentPath;
            previewButton.Enabled = true;
            decideChangeNameButton.Enabled = true;
            allChangeButton.Enabled = true;
            overrideButton.Enabled = true;
            viewerToolStripMenuItem.Enabled = true;

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
                fileNameView.Columns[0].ReadOnly = true;
            }

            updateHeaderText(); //ヘッダーの更新
            fileNameView.Rows.Clear(); //表を初期化

            //指定パスにあるファイルを取得して，行を追加していく(列は0番目)．
            var fullpaths = System.IO.Directory.GetFiles(selectPath, "*");
            foreach (var f in fullpaths)
            {
                fileNameView.Rows.Add(Path.GetFileName(f)); //行をset
            }

            extractString(); //tagの設定に合わせて文字列を抽出，反映

            //左端の列の色を変更
            for (int i = 0; i < fileNameView.Rows.Count; i++)
            {
                fileNameView[0, i].Style.BackColor = Color.LightBlue;
            }
        }

        /// <summary>
        /// Viewの列ヘッダーテキストを更新する(表の最上部の行のテキスト)
        /// </summary>
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

        /// <summary>
        /// 抽出設定を基に，文字列を抽出する．
        /// </summary>
        private void extractString()
        {
            //全ファイル名に対してTag数分の文字列処理をする
            for (int i = 0; i < fileNameView.Rows.Count; i++) //行
            {
                for (int j = 0; j < Config.MAX_TAG_NUM; j++) //タグ(列)
                {
                    string target = fileNameView.Rows[i].Cells[0].Value.ToString(); //ファイル名を取得
                    fileNameView.Rows[i].Cells[j + 1].Value = tagList.tags[j].replace(target); //セルに挿入
                }
            }
        }

        /// <summary>
        /// 画像ビューワーの表示
        /// </summary>
        /// <param name="isShow">trueなら表示，falseなら非表示</param>
        private void showViewer(bool isShow)
        {
            //まだフォルダを開いていない状態であれば、ビューワーは開けない
            if (currentPath.Count() == 0)
            {
                return;
            }

            //表示
            if (isShow)
            {
                //ビューワーを複数起動を許さないため、フォームが閉じられているか確認する
                if (imgform != null)
                {
                    if (imgform.IsDisposed == false)
                    {
                        return;
                    }
                }

                imgform = new ImagePreviewForm();
                imgform.Show();

                //選択されているセル行のZIPファイル名を取得
                if (fileNameView.SelectedCells.Count > 0)
                {
                    int select_row = fileNameView.SelectedCells[0].RowIndex; //選択しているセルの行番号取得
                    imgform.setImages(@currentPath + @"\" + getViewValue(select_row, 0), tagList);
                }
            }
            //非表示
            else
            {
                if (imgform != null)
                {
                    //フォームを閉じる
                    imgform.clear(); //file close
                    imgform.Dispose();
                }
            }
        }

        private void backPage()
        {
            if (imgform == null)
            {
                return;
            }

            imgform.back();
        }

        private void nextPage()
        {
            if (imgform == null)
            {
                return;
            }

            imgform.next();
        }

        //##############################################################################################################

        /// <summary>
        /// 編集対象のフォルダを指定するウインドウを開く．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirOpenToolStripMenuItem_Click(object sender, EventArgs e)
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
                currentPath = dialog.FileName;
                updateFileNameView(dialog.FileName);
            }
        }

        /// <summary>
        /// タグを編集するウインドウを開く．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StringConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //タグ設定フォームを生成
            TagConfig form = new TagConfig();
            form.ShowDialog(this); //編集終了までTOPには戻らない
            form.Dispose();

            updateHeaderText(); //タグ名が変わっている場合があるため，更新する
            updateFileNameView(currentPath); //抽出条件が変わる場合があるので更新する．
        }

        /// <summary>
        /// フォーマット文字列を基に，ファイル名を変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decideChangeNameButton_Click(object sender, EventArgs e)
        {
            //確認ダイアログ
            DialogResult decide = MessageBox.Show(
                "選択されている行のファイル名を一括で変更しますか？",
                "確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
            if (decide == DialogResult.Cancel)
            {
                return;
            }

            //選択されているセルから，行番号を重複がないように抽出する
            List<int> indices = new List<int>();
            foreach (DataGridViewCell c in fileNameView.SelectedCells)
            {
                indices.Add(c.RowIndex);
            }
            indices = indices.Distinct().ToList<int>(); //重複の削除

            //実際に更新する
            updateFileName(indices);

            //確認ダイアログ
            MessageBox.Show(
                "変更が終了しました",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
        }

        private void allChangeButton_Click(object sender, EventArgs e)
        {
            //確認ダイアログ
            DialogResult decide = MessageBox.Show(
                "全てのファイル名を一括で変更しますか？",
                "確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
            if (decide == DialogResult.Cancel)
            {
                return;
            }

            //全ての行番号が入ったリストを作成
            List<int> indices = new List<int>();
            for (int i = 0; i < fileNameView.RowCount; i++)
            {
                indices.Add(i);
            }

            //実際に更新する
            updateFileName(indices);

            //確認ダイアログ
            MessageBox.Show(
                "変更が終了しました",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
        }

        /// <summary>
        /// 指定された行番号のファイル名を書き換える
        /// </summary>
        /// <param name="indices">行番号リスト</param>
        private void updateFileName(List<int> indices)
        {
            //ビューワーを一回落とす(ファイルアクセス中に名前を変更できない)
            showViewer(false);

            //選択された行だけ対象に，文字を置換していく
            foreach (int select_index in indices)
            {
                string result = formatText.Text; //テンプレート文字列を取り出す

                //%で囲んだタグ名を，文字列に置き換える
                foreach (Tag tag in tagList.tags)
                {
                    string cell_string = getViewValue(select_index, tagList.getTagIndex(tag.name) + 1); //+1は元のファイル名の分
                    result = result.Replace("%" + tag.name + "%", cell_string);
                }

                try
                {
                    //実際にファイル名を変更する
                    System.IO.File.Move(
                        @currentPath + @"\" + getViewValue(select_index, 0),
                        @currentPath + @"\" + result);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                    "\"" + getViewValue(select_index, 0) + "\" > \"" + result + "\"\n" + ex.Message,
                    "ファイル名変更時エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
                }
            }

            //ファイルのパスが変わるので，表示を更新する
            updateFileNameView(currentPath);
        }

        /// <summary>
        /// Zipファイルにアクセスして，別のウインドウにZIPファイル内の画像を表示する．
        /// Viewでセル選択が別のセルに移ったときに場合に呼ばれる．
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileNameView_SelectionChanged(object sender, EventArgs e)
        {
            //フォームが生成されていない or 閉じられている場合はこの処理をしない
            if (imgform == null)
                return;
            if (imgform.IsDisposed)
                return;

            //ZIPファイルをViewerに設定
            if (fileNameView.SelectedCells.Count > 0)
            {
                int select_row = fileNameView.SelectedCells[0].RowIndex; //選択しているセルの行番号取得
                //前回選択していた行と違う行なら
                if (select_row != prevSelectRow)
                {
                    imgform.setImages(@currentPath + @"\" + getViewValue(select_row, 0), tagList);
                    prevSelectRow = select_row; //更新
                }
            }
        }

        /// <summary>
        /// 選択されたセル内のタグを上書き設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overrideButton_Click(object sender, EventArgs e)
        {
            //選択されているセルを抽出
            string override_text = overrideTextBox.Text;
            foreach (DataGridViewCell cell in fileNameView.SelectedCells)
            {
                //textboxで設定されている文字列に変更する
                fileNameView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = override_text;
            }

        }

        /// <summary>
        /// プレビューボタンを押した際の挙動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previewButton_Click(object sender, EventArgs e)
        {
            showViewer(true);
        }

        private void backpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backPage();
        }

        private void nextpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextPage();
        }

        private void showViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showViewer(true);
        }

        private void hideViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showViewer(false);
        }

        /// <summary>
        /// ウインドウにファイルをD&Dした際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Top_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("DDされたよ");
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            this.init(fileName[0]); //D6Dされたフォルダ（ファイル）を元に、再表示する
        }

        private void Top_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //確認ダイアログ
            DialogResult decide = MessageBox.Show(
                "現在の編集内容をすべてリセットしますか？",
                "確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
            if (decide == DialogResult.Cancel)
            {
                return;
            }

            this.init();
            updateFileNameView(this.currentPath); //現在保持しているディレクトリで再表示
        }

        private void autoAuthorSetButton_Click(object sender, EventArgs e)
        {
            autoAuthorSet();
        }

        /// <summary>
        /// 自動著者セット
        /// 先頭行の著者を、全ての行に適用する
        /// </summary>
        private void autoAuthorSet()
        {
            string author = getViewValue(0, 1);

            for (int i = 0; i < fileNameView.RowCount; i++)
            {
                setValue(i, 1, author);
            }
        }


    }
}
