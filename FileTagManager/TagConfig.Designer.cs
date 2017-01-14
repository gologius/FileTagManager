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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceTextsView = new System.Windows.Forms.DataGridView();
            this.replaceText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).BeginInit();
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
            this.groupBox3.Controls.Add(this.replaceTextsView);
            this.groupBox3.Location = new System.Drawing.Point(182, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 311);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文字置換";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 311);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タグを選択";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(152, 286);
            this.dataGridView1.TabIndex = 16;
            // 
            // tagName
            // 
            this.tagName.HeaderText = "タグ名";
            this.tagName.Name = "tagName";
            // 
            // replaceTextsView
            // 
            this.replaceTextsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.replaceTextsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replaceTextsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.replaceText,
            this.replaced});
            this.replaceTextsView.Location = new System.Drawing.Point(8, 19);
            this.replaceTextsView.Name = "replaceTextsView";
            this.replaceTextsView.RowTemplate.Height = 21;
            this.replaceTextsView.Size = new System.Drawing.Size(512, 286);
            this.replaceTextsView.TabIndex = 22;
            // 
            // replaceText
            // 
            this.replaceText.HeaderText = "置換前の文字列";
            this.replaceText.Name = "replaceText";
            // 
            // replaced
            // 
            this.replaced.HeaderText = "置換後の文字列";
            this.replaced.Name = "replaced";
            // 
            // TagConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TagConfig";
            this.Text = "タグ抽出条件の編集";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTextsView)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagName;
        private System.Windows.Forms.DataGridView replaceTextsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceText;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaced;
    }
}