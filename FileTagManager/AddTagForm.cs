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
    public partial class AddTagForm : Form
    {
        private string tagName = "";

        public AddTagForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            tagName = tagNameText.Text; //値を保存しておく(下の戻り値で使用)
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //何もせずに終了
            this.Close();
        }

        static public string showConfirmForm()
        {
            //タグ追加フォームを生成
            AddTagForm form = new AddTagForm();
            form.ShowDialog();
            form.Dispose();

            return form.tagName;
        }
    }
}
