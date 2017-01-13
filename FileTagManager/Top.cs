using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dirOpenButton_Click(object sender, EventArgs e)
        {
            var Dialog = new CommonOpenFileDialog();
            // フォルダーを開く設定に
            Dialog.IsFolderPicker = true;
            // 読み取り専用フォルダ/コントロールパネルは開かない
            Dialog.EnsureReadOnly = false;
            Dialog.AllowNonFileSystemItems = false;
            // パス指定
            Dialog.DefaultDirectory = Application.StartupPath;
            // 開く
            var Result = Dialog.ShowDialog();
            // もし開かれているなら
            if (Result == CommonFileDialogResult.Ok)
            {
                // ここでいろいろする（開いたフォルダはDialog.FileNameで取得）
            }
        }
    }
}
