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
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.vievToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DictionariesPanel = new System.Windows.Forms.Panel();
            this.customButton2 = new DictionaryWithUI.CustomButton();
            this.FirstLanguageTextBox = new System.Windows.Forms.TextBox();
            this.TranslatedTextBox = new System.Windows.Forms.TextBox();
            this.AddWordPanel = new System.Windows.Forms.Panel();
            this.AddWordcustomButton = new DictionaryWithUI.CustomButton();
            this.reversePicture = new System.Windows.Forms.PictureBox();
            this.ForeignLabel = new DictionaryWithUI.CustomLabel();
            this.FirstLanguageLabel = new DictionaryWithUI.CustomLabel();
            this.ExprToTranslateLabel = new DictionaryWithUI.CustomLabel();
            this.TranslatedExprLabel = new DictionaryWithUI.CustomLabel();
            this.WordsShowPanel = new System.Windows.Forms.Panel();
            this.TranslatedWords = new System.Windows.Forms.ListBox();
            this.WordsFirstLanguage = new System.Windows.Forms.ListBox();
            this.DictionarymenuStrip.SuspendLayout();
            this.DictionariesPanel.SuspendLayout();
            this.AddWordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reversePicture)).BeginInit();
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
            this.vievToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.saveToolStripMenuItem});
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addWordToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.dictionaryToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addWordToolStripMenuItem.Text = "Add word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
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
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.findWordToolStripMenuItem.Name = "findWordToolStripMenuItem";
            this.findWordToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.findWordToolStripMenuItem.Text = "Find word";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // vievToolStripMenuItem
            // 
            this.vievToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.thremeToolStripMenuItem});
            this.vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            this.vievToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.vievToolStripMenuItem.Text = "Viev";
            this.vievToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.vievToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // thremeToolStripMenuItem
            // 
            this.thremeToolStripMenuItem.Name = "thremeToolStripMenuItem";
            this.thremeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thremeToolStripMenuItem.Text = "Theme";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // DictionariesPanel
            // 
            this.DictionariesPanel.AutoScroll = true;
            this.DictionariesPanel.Controls.Add(this.customButton2);
            this.DictionariesPanel.Location = new System.Drawing.Point(12, 29);
            this.DictionariesPanel.Name = "DictionariesPanel";
            this.DictionariesPanel.Size = new System.Drawing.Size(776, 61);
            this.DictionariesPanel.TabIndex = 2;
            // 
            // customButton2
            // 
            this.customButton2.Checked = false;
            this.customButton2.Location = new System.Drawing.Point(3, 3);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(102, 37);
            this.customButton2.TabIndex = 0;
            this.customButton2.TextOnTheButton = "English|Ukrainian";
            this.customButton2.Clicked += new System.EventHandler(this.CheckIfCheckedExists);
            // 
            // FirstLanguageTextBox
            // 
            this.FirstLanguageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(87)))));
            this.FirstLanguageTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.AddWordPanel.Controls.Add(this.reversePicture);
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
            // reversePicture
            // 
            this.reversePicture.Image = global::DictionaryWithUI.Properties.Resources.reverseButtonWhite;
            this.reversePicture.Location = new System.Drawing.Point(371, 5);
            this.reversePicture.Name = "reversePicture";
            this.reversePicture.Size = new System.Drawing.Size(40, 40);
            this.reversePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reversePicture.TabIndex = 8;
            this.reversePicture.TabStop = false;
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
            this.WordsShowPanel.Controls.Add(this.TranslatedWords);
            this.WordsShowPanel.Controls.Add(this.WordsFirstLanguage);
            this.WordsShowPanel.Location = new System.Drawing.Point(12, 96);
            this.WordsShowPanel.Name = "WordsShowPanel";
            this.WordsShowPanel.Size = new System.Drawing.Size(798, 342);
            this.WordsShowPanel.TabIndex = 10;
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
            // 
            // WordsFirstLanguage
            // 
            this.WordsFirstLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.WordsFirstLanguage.ForeColor = System.Drawing.Color.White;
            this.WordsFirstLanguage.FormattingEnabled = true;
            this.WordsFirstLanguage.Location = new System.Drawing.Point(3, 3);
            this.WordsFirstLanguage.Name = "WordsFirstLanguage";
            this.WordsFirstLanguage.Size = new System.Drawing.Size(314, 329);
            this.WordsFirstLanguage.TabIndex = 0;
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
            this.Controls.Add(this.WordsShowPanel);
            this.Controls.Add(this.AddWordPanel);
            this.MainMenuStrip = this.DictionarymenuStrip;
            this.Name = "Dictionary";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DictionarymenuStrip.ResumeLayout(false);
            this.DictionarymenuStrip.PerformLayout();
            this.DictionariesPanel.ResumeLayout(false);
            this.AddWordPanel.ResumeLayout(false);
            this.AddWordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reversePicture)).EndInit();
            this.WordsShowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip DictionarymenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vievToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.Panel DictionariesPanel;
        private CustomButton customButton2;
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
        private System.Windows.Forms.PictureBox reversePicture;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Panel WordsShowPanel;
        private System.Windows.Forms.ListBox TranslatedWords;
        private System.Windows.Forms.ListBox WordsFirstLanguage;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem thremeToolStripMenuItem;
    }
}

