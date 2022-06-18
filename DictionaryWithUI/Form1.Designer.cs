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
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vievToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customButton2 = new DictionaryWithUI.CustomButton();
            this.button1 = new System.Windows.Forms.Button();
            this.customButton1 = new DictionaryWithUI.CustomButton();
            this.DictionarymenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionarymenuStrip
            // 
            this.DictionarymenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.DictionarymenuStrip.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionarymenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.vievToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.DictionarymenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DictionarymenuStrip.Name = "DictionarymenuStrip";
            this.DictionarymenuStrip.Size = new System.Drawing.Size(800, 26);
            this.DictionarymenuStrip.TabIndex = 1;
            this.DictionarymenuStrip.Text = "menuStrip1";
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // vievToolStripMenuItem
            // 
            this.vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            this.vievToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.vievToolStripMenuItem.Text = "Viev";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 61);
            this.panel1.TabIndex = 2;
            this.panel1.MouseEnter += new System.EventHandler(this.CheckIfCheckedExists);
            // 
            // customButton2
            // 
            this.customButton2.Checked = false;
            this.customButton2.Location = new System.Drawing.Point(3, 3);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(102, 37);
            this.customButton2.TabIndex = 0;
            this.customButton2.TextOnTheButton = "LuckyBoiiiiii1111111111";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(243, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customButton1
            // 
            this.customButton1.Checked = false;
            this.customButton1.Location = new System.Drawing.Point(288, 147);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(102, 37);
            this.customButton1.TabIndex = 4;
            this.customButton1.TextOnTheButton = "button";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DictionarymenuStrip);
            this.MainMenuStrip = this.DictionarymenuStrip;
            this.Name = "Dictionary";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DictionarymenuStrip.ResumeLayout(false);
            this.DictionarymenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip DictionarymenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vievToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private CustomButton customButton2;
        private System.Windows.Forms.Button button1;
        private CustomButton customButton1;
    }
}

