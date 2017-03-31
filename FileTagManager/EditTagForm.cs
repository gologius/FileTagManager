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
    public partial class EditTagForm : Form
    {
        private string tagName = "";
        private bool doDelete = false;

        public EditTagForm()
        {
            InitializeComponent();
        }

        //タグ追加用
        static public string showAddTagForm()
        {
            EditTagForm form = new EditTagForm();
            form.deleteButton.Enabled = false; //追加時は削除ボタンを無効に
            form.ShowDialog();
            form.Dispose();

            return form.tagName;
        }

        //タグ編集(名前の変更とタグ自体の削除)
        static public void showEditTagForm(ref string refText, out bool doDelete_)
        {
            //タグ編集フォームを生成
            EditTagForm form = new EditTagForm();
            form.tagNameText.Text = refText;
            form.ShowDialog();
            form.Dispose();

            refText = form.tagName;
            doDelete_ = form.doDelete;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            doDelete = true;
            this.Close();
        }
    }
}
