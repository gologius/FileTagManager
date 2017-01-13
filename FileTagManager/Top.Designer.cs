namespace FileTagManager
{
    partial class Top
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dirOpenButton = new System.Windows.Forms.Button();
            this.dirPathText = new System.Windows.Forms.TextBox();
            this.formatText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setProgramButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タグ抽出設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decideChangeNameButton = new System.Windows.Forms.Button();
            this.extractTagButton = new System.Windows.Forms.Button();
            this.configComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirOpenButton
            // 
            this.dirOpenButton.Location = new System.Drawing.Point(13, 25);
            this.dirOpenButton.Name = "dirOpenButton";
            this.dirOpenButton.Size = new System.Drawing.Size(146, 23);
            this.dirOpenButton.TabIndex = 0;
            this.dirOpenButton.Text = "フォルダを開く";
            this.dirOpenButton.UseVisualStyleBackColor = true;
            this.dirOpenButton.Click += new System.EventHandler(this.dirOpenButton_Click);
            // 
            // dirPathText
            // 
            this.dirPathText.Location = new System.Drawing.Point(165, 27);
            this.dirPathText.Name = "dirPathText";
            this.dirPathText.ReadOnly = true;
            this.dirPathText.Size = new System.Drawing.Size(633, 19);
            this.dirPathText.TabIndex = 1;
            // 
            // formatText
            // 
            this.formatText.Location = new System.Drawing.Point(165, 123);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(633, 19);
            this.formatText.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 19);
            this.textBox1.TabIndex = 5;
            // 
            // setProgramButton
            // 
            this.setProgramButton.Location = new System.Drawing.Point(12, 83);
            this.setProgramButton.Name = "setProgramButton";
            this.setProgramButton.Size = new System.Drawing.Size(146, 23);
            this.setProgramButton.TabIndex = 6;
            this.setProgramButton.Text = "ボタンで開くプログラム";
            this.setProgramButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "出力ファイル名のフォーマット";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(785, 359);
            this.dataGridView1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.タグ抽出設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.設定ToolStripMenuItem.Text = "設定(未実装)";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // タグ抽出設定ToolStripMenuItem
            // 
            this.タグ抽出設定ToolStripMenuItem.Name = "タグ抽出設定ToolStripMenuItem";
            this.タグ抽出設定ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.タグ抽出設定ToolStripMenuItem.Text = "タグ抽出設定";
            // 
            // decideChangeNameButton
            // 
            this.decideChangeNameButton.Location = new System.Drawing.Point(12, 141);
            this.decideChangeNameButton.Name = "decideChangeNameButton";
            this.decideChangeNameButton.Size = new System.Drawing.Size(146, 23);
            this.decideChangeNameButton.TabIndex = 10;
            this.decideChangeNameButton.Text = "選択したファイル名を変更";
            this.decideChangeNameButton.UseVisualStyleBackColor = true;
            // 
            // extractTagButton
            // 
            this.extractTagButton.Location = new System.Drawing.Point(12, 54);
            this.extractTagButton.Name = "extractTagButton";
            this.extractTagButton.Size = new System.Drawing.Size(146, 23);
            this.extractTagButton.TabIndex = 11;
            this.extractTagButton.Text = "ファイル名からタグを抽出";
            this.extractTagButton.UseVisualStyleBackColor = true;
            // 
            // configComboBox
            // 
            this.configComboBox.FormattingEnabled = true;
            this.configComboBox.Location = new System.Drawing.Point(165, 56);
            this.configComboBox.Name = "configComboBox";
            this.configComboBox.Size = new System.Drawing.Size(121, 20);
            this.configComboBox.TabIndex = 12;
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(810, 541);
            this.Controls.Add(this.configComboBox);
            this.Controls.Add(this.extractTagButton);
            this.Controls.Add(this.decideChangeNameButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setProgramButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.formatText);
            this.Controls.Add(this.dirPathText);
            this.Controls.Add(this.dirOpenButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Top";
            this.Text = "FileTagManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirOpenButton;
        private System.Windows.Forms.TextBox dirPathText;
        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setProgramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.Button decideChangeNameButton;
        private System.Windows.Forms.Button extractTagButton;
        private System.Windows.Forms.ComboBox configComboBox;
        private System.Windows.Forms.ToolStripMenuItem タグ抽出設定ToolStripMenuItem;
    }
}

