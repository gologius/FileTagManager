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
        public Top()
        {
            InitializeComponent();
        }


        private void setFileNameView(string selectPath)
        {
            //表を初期化
            fileNameView.Rows.Clear();

            //指定パスにあるファイルを取得する
            var fullpaths = System.IO.Directory.GetFiles(selectPath, "*");
            foreach (var f in fullpaths)
            {
                //行をset
                fileNameView.Rows.Add(Path.GetFileName(f));

            }
        }

        private void updateUseTagList(){

        }

        //##############################################################################################################

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


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

        private void goTagConfigButton_Click(object sender, EventArgs e)
        {
            //タグ設定フォームを生成
            TagConfig form = new TagConfig();
            form.ShowDialog(this); //編集終了までTOPには戻らない
            form.Dispose();

            updateUseTagList();//タグ編集内容を反映
        }
    }
}
