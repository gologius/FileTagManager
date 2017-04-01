using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTagManager
{

    /// <summary>
    /// Zipファイル内の画像を表示する
    /// 
    /// ZipClassを使用するには参照マネージャーで，
    /// * System.IO.Compression
    /// * System.IO.Compression.FileSystem
    /// の追加が必要
    /// </summary>
    public partial class ImagePreviewForm : Form
    {

        List<ZipArchiveEntry> imgFiles = new List<ZipArchiveEntry>();
        private int lookPage = 0; //現在閲覧しているページ番号

        public ImagePreviewForm()
        {
            InitializeComponent();
        }

        // 閉じるボタンを無効にする
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;

                return createParams;
            }
        }

        /// <summary>
        /// 与えられたZIPファイルのパスから，
        /// </summary>
        /// <param name="path"></param>
        public void setZip(string path)
        {
            //圧縮ファイル以外の場合は無視
            if (!Path.GetExtension(path).Equals(".zip"))
            {
                //確認ダイアログ
                MessageBox.Show(
                    "ZIPファイルではありません",
                    "確認",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
                return;
            }

            //初期化
            imgFiles.Clear();
         
            try
            {
                //Zipファイルから画像ファイルのみを取り出す
                ZipArchive archive = ZipFile.OpenRead(path);
                foreach (ZipArchiveEntry e in archive.Entries)
                {
                    if (Path.GetExtension(e.FullName).Equals(".jpg") ||
                        Path.GetExtension(e.FullName).Equals(".jpeg") ||
                        Path.GetExtension(e.FullName).Equals(".png") ||
                        Path.GetExtension(e.FullName).Equals(".bmp"))
                    {
                        imgFiles.Add(e);
                    }
                }

                //名前でソート
                imgFiles.Sort((a, b) => { return a.Name.CompareTo(b.Name); });
            }
            catch (InvalidDataException ex)
            {
                //確認ダイアログ
                MessageBox.Show(
                    "圧縮ファイル読み込みエラー",
                    "確認",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }

            //一枚目の画像を表示
            lookPage = 0;
            if (imgFiles.Count != 0)
            {
                updatePictureBox();
            }
        }

        private void updatePictureBox()
        {
            //エラー処理
            if (imgFiles.Count == 0)
                return;
            
            pictureBox1.Image = Image.FromStream(imgFiles[lookPage].Open());
            this.Text = "Preview - " + imgFiles[lookPage].FullName;
        }

        private void back()
        {
            lookPage--;
            if (lookPage < 0) lookPage = imgFiles.Count - 1;

            updatePictureBox();
        }

        private void next()
        {
            lookPage++;
            if (lookPage >= imgFiles.Count) lookPage = 0;

            updatePictureBox();
        }

        //##############################################################################################################

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            System.Drawing.Point cp = this.PointToClient(sp);
            int x = cp.X;
            int y = cp.Y;

            //左半分をクリック→戻る
            if (cp.X < this.Width / 2.0f)
            {
                back();
            }
            //右半分をクリック→進む
            else
            {
                next();
            }
        }
    }
}
