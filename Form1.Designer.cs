namespace ReadGhost
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Page = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FindNewWords = new System.Windows.Forms.Button();
            this.listBox_NewWords = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddToBook = new System.Windows.Forms.Button();
            this.btn_YouDaoTranslate = new System.Windows.Forms.Button();
            this.textBox_TranslateResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_MSTranslate = new System.Windows.Forms.Button();
            this.checkBox_SelectAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Page
            // 
            this.textBox_Page.Location = new System.Drawing.Point(12, 24);
            this.textBox_Page.Multiline = true;
            this.textBox_Page.Name = "textBox_Page";
            this.textBox_Page.Size = new System.Drawing.Size(293, 343);
            this.textBox_Page.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入一篇英文文章";
            // 
            // btn_FindNewWords
            // 
            this.btn_FindNewWords.Location = new System.Drawing.Point(319, 24);
            this.btn_FindNewWords.Name = "btn_FindNewWords";
            this.btn_FindNewWords.Size = new System.Drawing.Size(75, 23);
            this.btn_FindNewWords.TabIndex = 2;
            this.btn_FindNewWords.Text = "查找生词";
            this.btn_FindNewWords.UseVisualStyleBackColor = true;
            this.btn_FindNewWords.Click += new System.EventHandler(this.btn_FindNewWords_Click);
            // 
            // listBox_NewWords
            // 
            this.listBox_NewWords.Font = new System.Drawing.Font("宋体", 12F);
            this.listBox_NewWords.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox_NewWords.FormattingEnabled = true;
            this.listBox_NewWords.ItemHeight = 16;
            this.listBox_NewWords.Location = new System.Drawing.Point(410, 27);
            this.listBox_NewWords.Name = "listBox_NewWords";
            this.listBox_NewWords.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_NewWords.Size = new System.Drawing.Size(163, 292);
            this.listBox_NewWords.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "找到如下生词";
            // 
            // btn_AddToBook
            // 
            this.btn_AddToBook.Location = new System.Drawing.Point(471, 325);
            this.btn_AddToBook.Name = "btn_AddToBook";
            this.btn_AddToBook.Size = new System.Drawing.Size(102, 23);
            this.btn_AddToBook.TabIndex = 5;
            this.btn_AddToBook.Text = "加入到生词本";
            this.btn_AddToBook.UseVisualStyleBackColor = true;
            this.btn_AddToBook.Click += new System.EventHandler(this.btn_AddToBook_Click);
            // 
            // btn_YouDaoTranslate
            // 
            this.btn_YouDaoTranslate.Location = new System.Drawing.Point(319, 85);
            this.btn_YouDaoTranslate.Name = "btn_YouDaoTranslate";
            this.btn_YouDaoTranslate.Size = new System.Drawing.Size(85, 23);
            this.btn_YouDaoTranslate.TabIndex = 6;
            this.btn_YouDaoTranslate.Text = "有道翻译生词";
            this.btn_YouDaoTranslate.UseVisualStyleBackColor = true;
            this.btn_YouDaoTranslate.Click += new System.EventHandler(this.btn_YouDaoTranslate_Click);
            // 
            // textBox_TranslateResult
            // 
            this.textBox_TranslateResult.Location = new System.Drawing.Point(589, 87);
            this.textBox_TranslateResult.Multiline = true;
            this.textBox_TranslateResult.Name = "textBox_TranslateResult";
            this.textBox_TranslateResult.Size = new System.Drawing.Size(174, 232);
            this.textBox_TranslateResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "翻译结果如下";
            // 
            // btn_MSTranslate
            // 
            this.btn_MSTranslate.Location = new System.Drawing.Point(319, 144);
            this.btn_MSTranslate.Name = "btn_MSTranslate";
            this.btn_MSTranslate.Size = new System.Drawing.Size(86, 23);
            this.btn_MSTranslate.TabIndex = 9;
            this.btn_MSTranslate.Text = "微软翻译生词";
            this.btn_MSTranslate.UseVisualStyleBackColor = true;
            this.btn_MSTranslate.Click += new System.EventHandler(this.btn_MSTranslate_Click);
            // 
            // checkBox_SelectAll
            // 
            this.checkBox_SelectAll.AutoSize = true;
            this.checkBox_SelectAll.Location = new System.Drawing.Point(507, 9);
            this.checkBox_SelectAll.Name = "checkBox_SelectAll";
            this.checkBox_SelectAll.Size = new System.Drawing.Size(48, 16);
            this.checkBox_SelectAll.TabIndex = 10;
            this.checkBox_SelectAll.Text = "全选";
            this.checkBox_SelectAll.UseVisualStyleBackColor = true;
            this.checkBox_SelectAll.CheckedChanged += new System.EventHandler(this.checkBox_SelectAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 410);
            this.Controls.Add(this.checkBox_SelectAll);
            this.Controls.Add(this.btn_MSTranslate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TranslateResult);
            this.Controls.Add(this.btn_YouDaoTranslate);
            this.Controls.Add(this.btn_AddToBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_NewWords);
            this.Controls.Add(this.btn_FindNewWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Page);
            this.Name = "Form1";
            this.Text = "阅读精灵";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_FindNewWords;
        private System.Windows.Forms.ListBox listBox_NewWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddToBook;
        private System.Windows.Forms.Button btn_YouDaoTranslate;
        private System.Windows.Forms.TextBox textBox_TranslateResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_MSTranslate;
        private System.Windows.Forms.CheckBox checkBox_SelectAll;
    }
}

