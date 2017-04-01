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


        private List<Image> imgs = new List<Image>();
        private List<string> paths = new List<string>();

        private int lookPage = 0;

        public ImagePreviewForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 与えられたZIPファイルのパスから，
        /// </summary>
        /// <param name="path"></param>
        public void setZip(string path)
        {
            //圧縮ファイル以外の場合は無視
            if (!Path.GetExtension(path).Equals(".zip") &&
                !Path.GetExtension(path).Equals(".rar"))
            {
                return;
            }

            //初期化
            imgs.Clear();
            paths.Clear();

            try
            {

                //Zipファイルから画像ファイルのみを取り出す
                List<ZipArchiveEntry> imgZips = new List<ZipArchiveEntry>();
                ZipArchive archive = ZipFile.OpenRead(path);
                foreach (ZipArchiveEntry e in archive.Entries)
                {
                    if (Path.GetExtension(e.FullName).Equals(".jpg") ||
                        Path.GetExtension(e.FullName).Equals(".jpeg") ||
                        Path.GetExtension(e.FullName).Equals(".png") ||
                        Path.GetExtension(e.FullName).Equals(".bmp"))
                    {
                        imgZips.Add(e);
                    }
                }

                //名前でソートして画像とパスを保存
                imgZips.Sort((a, b) => { return a.Name.CompareTo(b.Name); });
                foreach (var i in imgZips)
                {
                    imgs.Add(Image.FromStream(i.Open()));
                    paths.Add(i.FullName);
                }
            }
            catch (InvalidDataException ex)
            {
                //確認ダイアログ
                MessageBox.Show(
                    "Zipファイル読み込みエラー",
                    "確認",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }

            //一枚目の画像を表示
            lookPage = 0;
            if (imgs.Count != 0)
            {
                updatePictureBox();
            }
        }

        private void updatePictureBox()
        {
            //エラー処理
            if (imgs.Count == 0)
            {
                return;
            }

            pictureBox1.Image = imgs[lookPage];
            this.Text = "Preview - " + @paths[lookPage];
        }

        private void back()
        {
            lookPage--;
            if (lookPage < 0) lookPage = imgs.Count - 1;

            updatePictureBox();
        }

        private void next()
        {
            lookPage++;
            if (lookPage >= imgs.Count) lookPage = 0;

            updatePictureBox();
        }

        //##############################################################################################################


        private void backButton_Click(object sender, EventArgs e)
        {
            back();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            next();
        }

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
