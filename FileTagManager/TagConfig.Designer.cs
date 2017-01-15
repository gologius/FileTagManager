namespace FileTagManager
{
    partial class TagConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.testResultText = new System.Windows.Forms.TextBox();
            this.textText = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceTextsView = new System.Windows.Forms.DataGridView();
            this.replaceText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagListView = new System.Windows.Forms.DataGridView();
            this.tagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.deleteTagButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagListView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.testResultText);
            this.groupBox2.Controls.Add(this.textText);
            this.groupBox2.Controls.Add(this.extractButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 71);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "テスト";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "結果";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "入力";
            // 
            // testResultText
            // 
            this.testResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testResultText.Location = new System.Drawing.Point(122, 47);
            this.testResultText.Name = "testResultText";
            this.testResultText.ReadOnly = true;
            this.testResultText.Size = new System.Drawing.Size(569, 19);
            this.testResultText.TabIndex = 2;
            // 
            // textText
            // 
            this.textText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textText.Location = new System.Drawing.Point(122, 20);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(568, 19);
            this.textText.TabIndex = 1;
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(6, 18);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(75, 23);
            this.extractButton.TabIndex = 0;
            this.extractButton.Text = "抽出";
            this.extractButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.replaceTextsView);
            this.groupBox3.Location = new System.Drawing.Point(182, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 257);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文字置換";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "%sss% : 置換対象の文字列";
            // 
            // replaceTextsView
            // 
            this.replaceTextsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.replaceTextsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replaceTextsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.replaceText,
            this.replaced});
            this.replaceTextsView.Location = new System.Drawing.Point(8, 40);
            this.replaceTextsView.Name = "replaceTextsView";
            this.replaceTextsView.RowTemplate.Height = 21;
            this.replaceTextsView.Size = new System.Drawing.Size(512, 211);
            this.replaceTextsView.TabIndex = 22;
            // 
            // replaceText
            // 
            this.replaceText.HeaderText = "置換前の文字列";
            this.replaceText.Name = "replaceText";
            this.replaceText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // replaced
            // 
            this.replaced.HeaderText = "置換後の文字列";
            this.replaced.Name = "replaced";
            this.replaced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteTagButton);
            this.groupBox1.Controls.Add(this.addTagButton);
            this.groupBox1.Controls.Add(this.tagListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 311);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タグを選択";
            // 
            // tagListView
            // 
            this.tagListView.AllowUserToAddRows = false;
            this.tagListView.AllowUserToDeleteRows = false;
            this.tagListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tagListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagName});
            this.tagListView.Location = new System.Drawing.Point(6, 19);
            this.tagListView.MultiSelect = false;
            this.tagListView.Name = "tagListView";
            this.tagListView.RowTemplate.Height = 21;
            this.tagListView.Size = new System.Drawing.Size(152, 256);
            this.tagListView.TabIndex = 16;
            this.tagListView.SelectionChanged += new System.EventHandler(this.tagListView_SelectionChanged);
            // 
            // tagName
            // 
            this.tagName.HeaderText = "タグ名";
            this.tagName.Name = "tagName";
            this.tagName.ReadOnly = true;
            this.tagName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(182, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 48);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文字抽出 (正規表現)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 19);
            this.textBox1.TabIndex = 0;
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(6, 281);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 17;
            this.addTagButton.Text = "タグ追加";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // deleteTagButton
            // 
            this.deleteTagButton.Location = new System.Drawing.Point(82, 281);
            this.deleteTagButton.Name = "deleteTagButton";
            this.deleteTagButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTagButton.TabIndex = 18;
            this.deleteTagButton.Text = "タグ削除";
            this.deleteTagButton.UseVisualStyleBackColor = true;
            this.deleteTagButton.Click += new System.EventHandler(this.deleteTagButton_Click);
            // 
            // TagConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TagConfig";
            this.Text = "タグ抽出条件の編集";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TagConfig_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagListView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox testResultText;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tagListView;
        private System.Windows.Forms.DataGridView replaceTextsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceText;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteTagButton;
        private System.Windows.Forms.Button addTagButton;
    }
}