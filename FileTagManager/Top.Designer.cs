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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formatText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameView = new System.Windows.Forms.DataGridView();
            this.decideChangeNameButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StringConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPreviewCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatText
            // 
            this.formatText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formatText.Location = new System.Drawing.Point(251, 29);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(643, 19);
            this.formatText.TabIndex = 3;
            this.formatText.Text = "[%Author%] %Title%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "出力ファイル名のフォーマット";
            // 
            // fileNameView
            // 
            this.fileNameView.AllowUserToAddRows = false;
            this.fileNameView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.fileNameView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.fileNameView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileNameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileNameView.Location = new System.Drawing.Point(12, 56);
            this.fileNameView.Name = "fileNameView";
            this.fileNameView.RowTemplate.Height = 21;
            this.fileNameView.Size = new System.Drawing.Size(1073, 549);
            this.fileNameView.TabIndex = 8;
            this.fileNameView.SelectionChanged += new System.EventHandler(this.fileNameView_SelectionChanged);
            // 
            // decideChangeNameButton
            // 
            this.decideChangeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decideChangeNameButton.Enabled = false;
            this.decideChangeNameButton.Location = new System.Drawing.Point(900, 27);
            this.decideChangeNameButton.Name = "decideChangeNameButton";
            this.decideChangeNameButton.Size = new System.Drawing.Size(184, 23);
            this.decideChangeNameButton.TabIndex = 10;
            this.decideChangeNameButton.Text = "選択した行のファイル名を変更";
            this.decideChangeNameButton.UseVisualStyleBackColor = true;
            this.decideChangeNameButton.Click += new System.EventHandler(this.decideChangeNameButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
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
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.FileToolStripMenuItem.Text = "ファイル";
            // 
            // DirOpenToolStripMenuItem
            // 
            this.DirOpenToolStripMenuItem.Name = "DirOpenToolStripMenuItem";
            this.DirOpenToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.DirOpenToolStripMenuItem.Text = "フォルダを開く";
            this.DirOpenToolStripMenuItem.Click += new System.EventHandler(this.DirOpenToolStripMenuItem_Click);
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
            // showPreviewCheckBox
            // 
            this.showPreviewCheckBox.AutoSize = true;
            this.showPreviewCheckBox.Checked = true;
            this.showPreviewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPreviewCheckBox.Location = new System.Drawing.Point(12, 31);
            this.showPreviewCheckBox.Name = "showPreviewCheckBox";
            this.showPreviewCheckBox.Size = new System.Drawing.Size(92, 16);
            this.showPreviewCheckBox.TabIndex = 16;
            this.showPreviewCheckBox.Text = "プレビュー表示";
            this.showPreviewCheckBox.UseVisualStyleBackColor = true;
            this.showPreviewCheckBox.CheckedChanged += new System.EventHandler(this.showPreviewCheckBox_CheckedChanged);
            // 
            // Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 617);
            this.Controls.Add(this.showPreviewCheckBox);
            this.Controls.Add(this.decideChangeNameButton);
            this.Controls.Add(this.fileNameView);
            this.Controls.Add(this.formatText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Top";
            this.Text = "FileTagManager";
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
        private System.Windows.Forms.CheckBox showPreviewCheckBox;
    }
}

