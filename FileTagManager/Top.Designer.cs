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
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameView = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decideChangeNameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extractTagButton = new System.Windows.Forms.Button();
            this.goTagConfigButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirOpenButton
            // 
            this.dirOpenButton.Location = new System.Drawing.Point(12, 52);
            this.dirOpenButton.Name = "dirOpenButton";
            this.dirOpenButton.Size = new System.Drawing.Size(146, 23);
            this.dirOpenButton.TabIndex = 0;
            this.dirOpenButton.Text = "フォルダを開く";
            this.dirOpenButton.UseVisualStyleBackColor = true;
            this.dirOpenButton.Click += new System.EventHandler(this.dirOpenButton_Click);
            // 
            // dirPathText
            // 
            this.dirPathText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirPathText.Location = new System.Drawing.Point(46, 27);
            this.dirPathText.Name = "dirPathText";
            this.dirPathText.ReadOnly = true;
            this.dirPathText.Size = new System.Drawing.Size(1038, 19);
            this.dirPathText.TabIndex = 1;
            // 
            // formatText
            // 
            this.formatText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formatText.Location = new System.Drawing.Point(296, 5);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(797, 19);
            this.formatText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "出力ファイル名のフォーマット";
            // 
            // fileNameView
            // 
            this.fileNameView.AllowUserToAddRows = false;
            this.fileNameView.AllowUserToDeleteRows = false;
            this.fileNameView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileNameView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.title,
            this.otherTag});
            this.fileNameView.Location = new System.Drawing.Point(12, 81);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.RowTemplate.Height = 21;
            this.fileNameView.Size = new System.Drawing.Size(1073, 536);
            this.fileNameView.TabIndex = 8;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // otherTag
            // 
            this.otherTag.HeaderText = "Other Tag";
            this.otherTag.Name = "otherTag";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(95, 24);
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
            // decideChangeNameButton
            // 
            this.decideChangeNameButton.Location = new System.Drawing.Point(3, 3);
            this.decideChangeNameButton.Name = "decideChangeNameButton";
            this.decideChangeNameButton.Size = new System.Drawing.Size(146, 23);
            this.decideChangeNameButton.TabIndex = 10;
            this.decideChangeNameButton.Text = "選択したファイル名を変更";
            this.decideChangeNameButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.decideChangeNameButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.formatText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 32);
            this.panel1.TabIndex = 14;
            // 
            // extractTagButton
            // 
            this.extractTagButton.Location = new System.Drawing.Point(317, 50);
            this.extractTagButton.Name = "extractTagButton";
            this.extractTagButton.Size = new System.Drawing.Size(147, 25);
            this.extractTagButton.TabIndex = 11;
            this.extractTagButton.Text = "文字抽出";
            this.extractTagButton.UseVisualStyleBackColor = true;
            this.extractTagButton.Click += new System.EventHandler(this.extractTagButton_Click);
            // 
            // goTagConfigButton
            // 
            this.goTagConfigButton.Location = new System.Drawing.Point(164, 52);
            this.goTagConfigButton.Name = "goTagConfigButton";
            this.goTagConfigButton.Size = new System.Drawing.Size(147, 23);
            this.goTagConfigButton.TabIndex = 13;
            this.goTagConfigButton.Text = "抽出方法の設定";
            this.goTagConfigButton.UseVisualStyleBackColor = true;
            this.goTagConfigButton.Click += new System.EventHandler(this.goTagConfigButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Path";
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extractTagButton);
            this.Controls.Add(this.goTagConfigButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fileNameView);
            this.Controls.Add(this.dirPathText);
            this.Controls.Add(this.dirOpenButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Top";
            this.Text = "FileTagManager";
            ((System.ComponentModel.ISupportInitialize)(this.fileNameView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirOpenButton;
        private System.Windows.Forms.TextBox dirPathText;
        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView fileNameView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.Button decideChangeNameButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherTag;
        private System.Windows.Forms.Button extractTagButton;
        private System.Windows.Forms.Button goTagConfigButton;
        private System.Windows.Forms.Label label2;
    }
}

