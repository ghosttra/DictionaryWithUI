namespace DictionaryWithUI
{
    partial class Dictionary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DictionarymenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportWordToSeparateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindWordTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ResultComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.vievToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictionariesPanel = new System.Windows.Forms.Panel();
            this.FirstLanguageTextBox = new System.Windows.Forms.TextBox();
            this.TranslatedTextBox = new System.Windows.Forms.TextBox();
            this.AddWordPanel = new System.Windows.Forms.Panel();
            this.AddWordcustomButton = new DictionaryWithUI.CustomButton();
            this.ForeignLabel = new DictionaryWithUI.CustomLabel();
            this.FirstLanguageLabel = new DictionaryWithUI.CustomLabel();
            this.ExprToTranslateLabel = new DictionaryWithUI.CustomLabel();
            this.TranslatedExprLabel = new DictionaryWithUI.CustomLabel();
            this.WordsShowPanel = new System.Windows.Forms.Panel();
            this.DeletewordBtn = new DictionaryWithUI.CustomButton();
            this.TranslatedWords = new System.Windows.Forms.ListBox();
            this.WordsFirstLanguage = new System.Windows.Forms.ListBox();
            this.DictionarymenuStrip.SuspendLayout();
            this.AddWordPanel.SuspendLayout();
            this.WordsShowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionarymenuStrip
            // 
            this.DictionarymenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.DictionarymenuStrip.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionarymenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.translatorToolStripMenuItem,
            this.vievToolStripMenuItem});
            this.DictionarymenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DictionarymenuStrip.Name = "DictionarymenuStrip";
            this.DictionarymenuStrip.Size = new System.Drawing.Size(800, 26);
            this.DictionarymenuStrip.TabIndex = 1;
            this.DictionarymenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportWordToSeparateFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportWordToSeparateFileToolStripMenuItem
            // 
            this.exportWordToSeparateFileToolStripMenuItem.Name = "exportWordToSeparateFileToolStripMenuItem";
            this.exportWordToSeparateFileToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.exportWordToSeparateFileToolStripMenuItem.Text = "Export word to separate file";
            this.exportWordToSeparateFileToolStripMenuItem.Click += new System.EventHandler(this.exportWordToSeparateFileToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addWordToolStripMenuItem,
            this.toolStripSeparator2,
            this.addDictionaryToolStripMenuItem,
            this.deleteDictionaryToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.dictionaryToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addWordToolStripMenuItem.Text = "Add word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // addDictionaryToolStripMenuItem
            // 
            this.addDictionaryToolStripMenuItem.Name = "addDictionaryToolStripMenuItem";
            this.addDictionaryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addDictionaryToolStripMenuItem.Text = "Add dictionary";
            this.addDictionaryToolStripMenuItem.Click += new System.EventHandler(this.addDictionaryToolStripMenuItem_Click);
            // 
            // deleteDictionaryToolStripMenuItem
            // 
            this.deleteDictionaryToolStripMenuItem.Name = "deleteDictionaryToolStripMenuItem";
            this.deleteDictionaryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteDictionaryToolStripMenuItem.Text = "Delete dictionary";
            this.deleteDictionaryToolStripMenuItem.Click += new System.EventHandler(this.deleteDictionaryToolStripMenuItem_Click);
            // 
            // translatorToolStripMenuItem
            // 
            this.translatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findWordToolStripMenuItem});
            this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
            this.translatorToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.translatorToolStripMenuItem.Text = "Translator";
            this.translatorToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.translatorToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // findWordToolStripMenuItem
            // 
            this.findWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindWordTextBox,
            this.toolStripSeparator3,
            this.ResultComboBox});
            this.findWordToolStripMenuItem.Name = "findWordToolStripMenuItem";
            this.findWordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.findWordToolStripMenuItem.Text = "Find word";
            // 
            // FindWordTextBox
            // 
            this.FindWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindWordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FindWordTextBox.Name = "FindWordTextBox";
            this.FindWordTextBox.Size = new System.Drawing.Size(100, 23);
            this.FindWordTextBox.TextChanged += new System.EventHandler(this.FindWordTextBox_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // ResultComboBox
            // 
            this.ResultComboBox.Name = "ResultComboBox";
            this.ResultComboBox.Size = new System.Drawing.Size(121, 23);
            this.ResultComboBox.Text = "Result";
            // 
            // vievToolStripMenuItem
            // 
            this.vievToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            this.vievToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.vievToolStripMenuItem.Text = "View";
            this.vievToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.vievToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // DictionariesPanel
            // 
            this.DictionariesPanel.AutoScroll = true;
            this.DictionariesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DictionariesPanel.Location = new System.Drawing.Point(0, 26);
            this.DictionariesPanel.Name = "DictionariesPanel";
            this.DictionariesPanel.Size = new System.Drawing.Size(800, 61);
            this.DictionariesPanel.TabIndex = 2;
            // 
            // FirstLanguageTextBox
            // 
            this.FirstLanguageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.FirstLanguageTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstLanguageTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.FirstLanguageTextBox.Location = new System.Drawing.Point(3, 92);
            this.FirstLanguageTextBox.Multiline = true;
            this.FirstLanguageTextBox.Name = "FirstLanguageTextBox";
            this.FirstLanguageTextBox.Size = new System.Drawing.Size(356, 136);
            this.FirstLanguageTextBox.TabIndex = 3;
            this.FirstLanguageTextBox.TextChanged += new System.EventHandler(this.FirstLanguageTextBox_TextChanged);
            // 
            // TranslatedTextBox
            // 
            this.TranslatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.TranslatedTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslatedTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.TranslatedTextBox.Location = new System.Drawing.Point(420, 92);
            this.TranslatedTextBox.Multiline = true;
            this.TranslatedTextBox.Name = "TranslatedTextBox";
            this.TranslatedTextBox.Size = new System.Drawing.Size(356, 136);
            this.TranslatedTextBox.TabIndex = 4;
            this.TranslatedTextBox.TextChanged += new System.EventHandler(this.FirstLanguageTextBox_TextChanged);
            // 
            // AddWordPanel
            // 
            this.AddWordPanel.Controls.Add(this.AddWordcustomButton);
            this.AddWordPanel.Controls.Add(this.FirstLanguageTextBox);
            this.AddWordPanel.Controls.Add(this.ForeignLabel);
            this.AddWordPanel.Controls.Add(this.TranslatedTextBox);
            this.AddWordPanel.Controls.Add(this.FirstLanguageLabel);
            this.AddWordPanel.Controls.Add(this.ExprToTranslateLabel);
            this.AddWordPanel.Controls.Add(this.TranslatedExprLabel);
            this.AddWordPanel.Location = new System.Drawing.Point(12, 96);
            this.AddWordPanel.Name = "AddWordPanel";
            this.AddWordPanel.Size = new System.Drawing.Size(788, 342);
            this.AddWordPanel.TabIndex = 9;
            this.AddWordPanel.Visible = false;
            // 
            // AddWordcustomButton
            // 
            this.AddWordcustomButton.Checked = false;
            this.AddWordcustomButton.Location = new System.Drawing.Point(674, 234);
            this.AddWordcustomButton.Name = "AddWordcustomButton";
            this.AddWordcustomButton.Size = new System.Drawing.Size(102, 37);
            this.AddWordcustomButton.TabIndex = 9;
            this.AddWordcustomButton.TextOnTheButton = "Add";
            this.AddWordcustomButton.Clicked += new System.EventHandler(this.AddWordcustomButton_Clicked);
            // 
            // ForeignLabel
            // 
            this.ForeignLabel.LabelText = "ForeignLanguage";
            this.ForeignLabel.Location = new System.Drawing.Point(423, 6);
            this.ForeignLabel.Name = "ForeignLabel";
            this.ForeignLabel.Size = new System.Drawing.Size(356, 37);
            this.ForeignLabel.TabIndex = 7;
            // 
            // FirstLanguageLabel
            // 
            this.FirstLanguageLabel.LabelText = "FirstLanguage";
            this.FirstLanguageLabel.Location = new System.Drawing.Point(3, 6);
            this.FirstLanguageLabel.Name = "FirstLanguageLabel";
            this.FirstLanguageLabel.Size = new System.Drawing.Size(356, 37);
            this.FirstLanguageLabel.TabIndex = 7;
            // 
            // ExprToTranslateLabel
            // 
            this.ExprToTranslateLabel.LabelText = "Expression to translate";
            this.ExprToTranslateLabel.Location = new System.Drawing.Point(3, 49);
            this.ExprToTranslateLabel.Name = "ExprToTranslateLabel";
            this.ExprToTranslateLabel.Size = new System.Drawing.Size(356, 37);
            this.ExprToTranslateLabel.TabIndex = 5;
            // 
            // TranslatedExprLabel
            // 
            this.TranslatedExprLabel.LabelText = "Translated expression";
            this.TranslatedExprLabel.Location = new System.Drawing.Point(423, 49);
            this.TranslatedExprLabel.Name = "TranslatedExprLabel";
            this.TranslatedExprLabel.Size = new System.Drawing.Size(356, 37);
            this.TranslatedExprLabel.TabIndex = 6;
            // 
            // WordsShowPanel
            // 
            this.WordsShowPanel.Controls.Add(this.DeletewordBtn);
            this.WordsShowPanel.Controls.Add(this.TranslatedWords);
            this.WordsShowPanel.Controls.Add(this.WordsFirstLanguage);
            this.WordsShowPanel.Location = new System.Drawing.Point(12, 96);
            this.WordsShowPanel.Name = "WordsShowPanel";
            this.WordsShowPanel.Size = new System.Drawing.Size(798, 342);
            this.WordsShowPanel.TabIndex = 10;
            // 
            // DeletewordBtn
            // 
            this.DeletewordBtn.Checked = false;
            this.DeletewordBtn.Location = new System.Drawing.Point(337, 295);
            this.DeletewordBtn.Name = "DeletewordBtn";
            this.DeletewordBtn.Size = new System.Drawing.Size(102, 37);
            this.DeletewordBtn.TabIndex = 3;
            this.DeletewordBtn.TextOnTheButton = "Delete";
            this.DeletewordBtn.Clicked += new System.EventHandler(this.DeletewordBtn_Clicked);
            // 
            // TranslatedWords
            // 
            this.TranslatedWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.TranslatedWords.ForeColor = System.Drawing.Color.White;
            this.TranslatedWords.FormattingEnabled = true;
            this.TranslatedWords.Location = new System.Drawing.Point(462, 3);
            this.TranslatedWords.Name = "TranslatedWords";
            this.TranslatedWords.Size = new System.Drawing.Size(314, 329);
            this.TranslatedWords.TabIndex = 1;
            this.TranslatedWords.Tag = "2";
            // 
            // WordsFirstLanguage
            // 
            this.WordsFirstLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.WordsFirstLanguage.ForeColor = System.Drawing.Color.White;
            this.WordsFirstLanguage.FormattingEnabled = true;
            this.WordsFirstLanguage.Location = new System.Drawing.Point(0, 3);
            this.WordsFirstLanguage.Name = "WordsFirstLanguage";
            this.WordsFirstLanguage.Size = new System.Drawing.Size(314, 329);
            this.WordsFirstLanguage.TabIndex = 0;
            this.WordsFirstLanguage.Tag = "1";
            this.WordsFirstLanguage.Click += new System.EventHandler(this.WordsFirstLanguage_Click);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DictionariesPanel);
            this.Controls.Add(this.DictionarymenuStrip);
            this.Controls.Add(this.AddWordPanel);
            this.Controls.Add(this.WordsShowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.DictionarymenuStrip;
            this.MaximizeBox = false;
            this.Name = "Dictionary";
            this.ShowIcon = false;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dictionary_FormClosing);
            this.DictionarymenuStrip.ResumeLayout(false);
            this.DictionarymenuStrip.PerformLayout();
            this.AddWordPanel.ResumeLayout(false);
            this.AddWordPanel.PerformLayout();
            this.WordsShowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip DictionarymenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vievToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.Panel DictionariesPanel;
        private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
        private System.Windows.Forms.TextBox FirstLanguageTextBox;
        private System.Windows.Forms.TextBox TranslatedTextBox;
        private CustomLabel ExprToTranslateLabel;
        private CustomLabel TranslatedExprLabel;
        private CustomLabel FirstLanguageLabel;
        private CustomLabel ForeignLabel;
        private System.Windows.Forms.Panel AddWordPanel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private CustomButton AddWordcustomButton;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Panel WordsShowPanel;
        private System.Windows.Forms.ListBox TranslatedWords;
        private System.Windows.Forms.ListBox WordsFirstLanguage;
        private System.Windows.Forms.ToolStripMenuItem findWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox FindWordTextBox;
        private CustomButton DeletewordBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportWordToSeparateFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox ResultComboBox;
    }
}

