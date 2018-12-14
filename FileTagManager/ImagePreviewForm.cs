using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpCompress.Archives;

namespace FileTagManager
{
    /// <summary>
    /// 圧縮ファイル内の画像を表示する
    /// 使用にはNuGetでSharpCompressのインストールが必要
    /// </summary>
    public partial class ImagePreviewForm : Form
    {

        IArchive archive = null; //圧縮ファイルの実体
        List<IArchiveEntry> imgs = null; //画像ファイル群
        private int lookPage = 0; //現在閲覧しているページ番号

        const int SUCCESS = 0;
        const int FILE_NOT_FOUND = 1;
        const int NOT_FILE = 2;
        const int NOT_IMGFILE = 3;

        public ImagePreviewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 圧縮ファイルを指定して、ビューワー表示するための初期化をする
        /// </summary>
        /// <param name="path">圧縮ファイルパス</param>
        public void setImages(string path)
        {
            string extension = Path.GetExtension(path);

            //初期化
            if (archive != null)
            {
                archive.Dispose();
                archive = null;
            }

            //圧縮ファイルから画像ファイルのみ取り出す
            try
            {
                archive = ArchiveFactory.Open(path);
                var entries = archive.Entries.Where(e =>
                    e.IsDirectory == false && (
                    Path.GetExtension(e.Key).Equals(".jpg") ||
                    Path.GetExtension(e.Key).Equals(".jpeg") ||
                    Path.GetExtension(e.Key).Equals(".png") ||
                    Path.GetExtension(e.Key).Equals(".bmp")));

                imgs = entries.ToList();
            }
            catch (Exception e)
            {
                messageLabel.Text = "ファイル展開に失敗しました";
                messageLabel.ForeColor = Color.Red;
                pictureBox1.Image = null;
                archive.Dispose();
                archive = null;
                return;
            }

            //ソート
            imgs.Sort((a, b) => { return a.Key.CompareTo(b.Key); });

            //一枚目の画像を表示
            lookPage = 0;
            if (imgs.Count() != 0)
            {
                messageLabel.Text = path;
                messageLabel.ForeColor = Color.Black;
                updatePictureBox();
            }
            else
            {
                messageLabel.Text = "ファイルが一つもありません";
                messageLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// 現在指定されているページの画像を読み込み、ビューワーを更新する
        /// </summary>
        /// <returns></returns>
        private int updatePictureBox()
        {
            if (imgs.Count() == 0)
            {
                return FILE_NOT_FOUND;
            }

            //圧縮ファイル内のファイル指定
            var entry = imgs[lookPage];
            this.Text = "Preview - " + entry.Key;
            Console.WriteLine(entry.Key);

            if (entry.IsDirectory)
            {
                Console.WriteLine("ディレクトリです");
                return NOT_FILE; //ディレクトリは無視
            }

            try
            {
                //ファイルを読み込みビューワーにセット
                pictureBox1.Image = Image.FromStream(entry.OpenEntryStream());
            }
            catch (Exception e)
            {
                Console.WriteLine("正常な画像ファイルではありません");
                return NOT_IMGFILE;
            }


            return 0;
        }

        /// <summary>
        /// ページ戻す
        /// </summary>
        private void back()
        {
            if (archive == null)
            {
                return;
            }

            lookPage--;
            if (lookPage < 0) lookPage = imgs.Count() - 1;

            int result = updatePictureBox();
            if (result == NOT_FILE || result == NOT_IMGFILE)
            {
                back();
            }
        }

        /// <summary>
        /// ページ進める
        /// </summary>
        private void next()
        {
            if (archive == null)
            {
                return;
            }

            lookPage++;
            if (lookPage >= imgs.Count()) lookPage = 0;

            int result = updatePictureBox();
            if (result == NOT_FILE || result == NOT_IMGFILE)
            {
                next();
            }
        }

        //##############################################################################################################

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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
        
        private void ImagePreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                back();
            }
            else if (e.KeyCode == Keys.Right)
            {
                next();
            }
        }

        public void clear()
        {
            //ファイル読み込みの終了
            if (archive != null)
            {
                archive.Dispose();
            }
        }
    }
}
