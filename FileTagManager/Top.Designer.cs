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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formatText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameView = new System.Windows.Forms.DataGridView();
            this.decideChangeNameButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.戻るToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StringConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overrideButton = new System.Windows.Forms.Button();
            this.overrideTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.autoAuthorSetButton = new System.Windows.Forms.Button();
            this.allChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatText
            // 
            this.formatText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formatText.Location = new System.Drawing.Point(12, 492);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(195, 19);
            this.formatText.TabIndex = 3;
            this.formatText.Text = "[%Author%] %Title%%Extension%";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "出力ファイル名のフォーマット";
            // 
            // fileNameView
            // 
            this.fileNameView.AllowUserToAddRows = false;
            this.fileNameView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.fileNameView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fileNameView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileNameView.Location = new System.Drawing.Point(213, 31);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.RowTemplate.Height = 21;
            this.fileNameView.Size = new System.Drawing.Size(872, 574);
            this.fileNameView.TabIndex = 8;
            this.fileNameView.SelectionChanged += new System.EventHandler(this.fileNameView_SelectionChanged);
            // 
            // decideChangeNameButton
            // 
            this.decideChangeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decideChangeNameButton.Enabled = false;
            this.decideChangeNameButton.Location = new System.Drawing.Point(12, 517);
            this.decideChangeNameButton.Name = "decideChangeNameButton";
            this.decideChangeNameButton.Size = new System.Drawing.Size(195, 23);
            this.decideChangeNameButton.TabIndex = 10;
            this.decideChangeNameButton.Text = "選択した行のファイル名を変更";
            this.decideChangeNameButton.UseVisualStyleBackColor = true;
            this.decideChangeNameButton.Click += new System.EventHandler(this.decideChangeNameButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.viewerToolStripMenuItem,
            this.ConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DirOpenToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // DirOpenToolStripMenuItem
            // 
            this.DirOpenToolStripMenuItem.Name = "DirOpenToolStripMenuItem";
            this.DirOpenToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.DirOpenToolStripMenuItem.Text = "フォルダを開く";
            this.DirOpenToolStripMenuItem.Click += new System.EventHandler(this.DirOpenToolStripMenuItem_Click);
            // 
            // viewerToolStripMenuItem
            // 
            this.viewerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showViewerToolStripMenuItem,
            this.hideViewerToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.戻るToolStripMenuItem});
            this.viewerToolStripMenuItem.Enabled = false;
            this.viewerToolStripMenuItem.Name = "viewerToolStripMenuItem";
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viewerToolStripMenuItem.Text = "ビューワー";
            // 
            // showViewerToolStripMenuItem
            // 
            this.showViewerToolStripMenuItem.Name = "showViewerToolStripMenuItem";
            this.showViewerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.showViewerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showViewerToolStripMenuItem.Text = "表示";
            this.showViewerToolStripMenuItem.Click += new System.EventHandler(this.showViewerToolStripMenuItem_Click);
            // 
            // hideViewerToolStripMenuItem
            // 
            this.hideViewerToolStripMenuItem.Name = "hideViewerToolStripMenuItem";
            this.hideViewerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.hideViewerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.hideViewerToolStripMenuItem.Text = "非表示";
            this.hideViewerToolStripMenuItem.Click += new System.EventHandler(this.hideViewerToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nextToolStripMenuItem.Text = "1ページ進む";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextpageToolStripMenuItem_Click);
            // 
            // 戻るToolStripMenuItem
            // 
            this.戻るToolStripMenuItem.Name = "戻るToolStripMenuItem";
            this.戻るToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.戻るToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.戻るToolStripMenuItem.Text = "1ページ戻る";
            this.戻るToolStripMenuItem.Click += new System.EventHandler(this.backpageToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllConfigToolStripMenuItem,
            this.StringConfigToolStripMenuItem});
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ConfigToolStripMenuItem.Text = "設定";
            // 
            // AllConfigToolStripMenuItem
            // 
            this.AllConfigToolStripMenuItem.Name = "AllConfigToolStripMenuItem";
            this.AllConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.AllConfigToolStripMenuItem.Text = "全体設定(未実装)";
            // 
            // StringConfigToolStripMenuItem
            // 
            this.StringConfigToolStripMenuItem.Name = "StringConfigToolStripMenuItem";
            this.StringConfigToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.StringConfigToolStripMenuItem.Text = "文字列抽出設定";
            this.StringConfigToolStripMenuItem.Click += new System.EventHandler(this.StringConfigToolStripMenuItem_Click);
            // 
            // overrideButton
            // 
            this.overrideButton.Enabled = false;
            this.overrideButton.Location = new System.Drawing.Point(12, 122);
            this.overrideButton.Name = "overrideButton";
            this.overrideButton.Size = new System.Drawing.Size(195, 51);
            this.overrideButton.TabIndex = 17;
            this.overrideButton.Text = "選択したセルのタグを一括設定";
            this.overrideButton.UseVisualStyleBackColor = true;
            this.overrideButton.Click += new System.EventHandler(this.overrideButton_Click);
            // 
            // overrideTextBox
            // 
            this.overrideTextBox.Location = new System.Drawing.Point(14, 97);
            this.overrideTextBox.Name = "overrideTextBox";
            this.overrideTextBox.Size = new System.Drawing.Size(193, 19);
            this.overrideTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "タグの一括設定";
            // 
            // previewButton
            // 
            this.previewButton.Enabled = false;
            this.previewButton.Location = new System.Drawing.Point(12, 31);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(195, 44);
            this.previewButton.TabIndex = 21;
            this.previewButton.Text = "プレビュー表示";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(109, 179);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 51);
            this.resetButton.TabIndex = 22;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // autoAuthorSetButton
            // 
            this.autoAuthorSetButton.Location = new System.Drawing.Point(12, 179);
            this.autoAuthorSetButton.Name = "autoAuthorSetButton";
            this.autoAuthorSetButton.Size = new System.Drawing.Size(91, 51);
            this.autoAuthorSetButton.TabIndex = 23;
            this.autoAuthorSetButton.Text = "自動著者セット";
            this.autoAuthorSetButton.UseVisualStyleBackColor = true;
            this.autoAuthorSetButton.Click += new System.EventHandler(this.autoAuthorSetButton_Click);
            // 
            // allChangeButton
            // 
            this.allChangeButton.Enabled = false;
            this.allChangeButton.Location = new System.Drawing.Point(14, 546);
            this.allChangeButton.Name = "allChangeButton";
            this.allChangeButton.Size = new System.Drawing.Size(193, 60);
            this.allChangeButton.TabIndex = 24;
            this.allChangeButton.Text = "全ての行のファイル名を変更";
            this.allChangeButton.UseVisualStyleBackColor = true;
            this.allChangeButton.Click += new System.EventHandler(this.allChangeButton_Click);
            // 
            // Top
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 617);
            this.Controls.Add(this.allChangeButton);
            this.Controls.Add(this.autoAuthorSetButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overrideTextBox);
            this.Controls.Add(this.overrideButton);
            this.Controls.Add(this.decideChangeNameButton);
            this.Controls.Add(this.fileNameView);
            this.Controls.Add(this.formatText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Top";
            this.Text = "FileTagManager";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Top_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Top_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.fileNameView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox formatText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView fileNameView;
        private System.Windows.Forms.Button decideChangeNameButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StringConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DirOpenToolStripMenuItem;
        private System.Windows.Forms.Button overrideButton;
        private System.Windows.Forms.TextBox overrideTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ToolStripMenuItem viewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 戻るToolStripMenuItem;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button autoAuthorSetButton;
        private System.Windows.Forms.Button allChangeButton;
    }
}

