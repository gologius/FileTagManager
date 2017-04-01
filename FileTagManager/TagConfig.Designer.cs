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
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.testResultText = new System.Windows.Forms.TextBox();
            this.textText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceTextsView = new System.Windows.Forms.DataGridView();
            this.replaceText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.regexpText = new System.Windows.Forms.TextBox();
            this.tagNameText = new System.Windows.Forms.TextBox();
            this.selectColumnGroupBox = new System.Windows.Forms.GroupBox();
            this.tagComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.selectColumnGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.testResultText);
            this.groupBox2.Controls.Add(this.textText);
            this.groupBox2.Location = new System.Drawing.Point(12, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 73);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "テスト(未実装)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "抽出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "結果";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 23);
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
            this.testResultText.Location = new System.Drawing.Point(43, 47);
            this.testResultText.Name = "testResultText";
            this.testResultText.ReadOnly = true;
            this.testResultText.Size = new System.Drawing.Size(399, 19);
            this.testResultText.TabIndex = 2;
            // 
            // textText
            // 
            this.textText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textText.Location = new System.Drawing.Point(44, 20);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(398, 19);
            this.textText.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.replaceTextsView);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 257);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(2) 抽出した文字列をさらに置換";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "前の行の置換結果が，次の行の置換対象になります";
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
            this.replaceTextsView.Size = new System.Drawing.Size(513, 211);
            this.replaceTextsView.TabIndex = 22;
            // 
            // replaceText
            // 
            this.replaceText.HeaderText = "置換前の文字列 (正規表現)";
            this.replaceText.Name = "replaceText";
            this.replaceText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // replaced
            // 
            this.replaced.HeaderText = "置換後の文字列";
            this.replaced.Name = "replaced";
            this.replaced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.regexpText);
            this.groupBox4.Location = new System.Drawing.Point(12, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 48);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(1) ファイル名からの文字列抽出 (正規表現)";
            // 
            // regexpText
            // 
            this.regexpText.Location = new System.Drawing.Point(6, 19);
            this.regexpText.Name = "regexpText";
            this.regexpText.Size = new System.Drawing.Size(279, 19);
            this.regexpText.TabIndex = 0;
            // 
            // tagNameText
            // 
            this.tagNameText.Location = new System.Drawing.Point(6, 18);
            this.tagNameText.Name = "tagNameText";
            this.tagNameText.Size = new System.Drawing.Size(279, 19);
            this.tagNameText.TabIndex = 22;
            // 
            // selectColumnGroupBox
            // 
            this.selectColumnGroupBox.Controls.Add(this.tagComboBox);
            this.selectColumnGroupBox.Location = new System.Drawing.Point(12, 12);
            this.selectColumnGroupBox.Name = "selectColumnGroupBox";
            this.selectColumnGroupBox.Size = new System.Drawing.Size(147, 53);
            this.selectColumnGroupBox.TabIndex = 27;
            this.selectColumnGroupBox.TabStop = false;
            this.selectColumnGroupBox.Text = "編集する行の選択";
            // 
            // tagComboBox
            // 
            this.tagComboBox.FormattingEnabled = true;
            this.tagComboBox.Location = new System.Drawing.Point(6, 18);
            this.tagComboBox.Name = "tagComboBox";
            this.tagComboBox.Size = new System.Drawing.Size(135, 20);
            this.tagComboBox.TabIndex = 0;
            this.tagComboBox.TextChanged += new System.EventHandler(this.tagComboBox_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tagNameText);
            this.groupBox5.Location = new System.Drawing.Point(12, 71);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 43);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "表における列名";
            // 
            // TagConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 522);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.selectColumnGroupBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "TagConfig";
            this.Text = "タグ抽出条件の編集";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TagConfig_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.selectColumnGroupBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox testResultText;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView replaceTextsView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox regexpText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagNameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox selectColumnGroupBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox tagComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceText;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaced;
    }
}