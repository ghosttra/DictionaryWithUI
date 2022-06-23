namespace DictionaryWithUI
{
    partial class AddDictionaryForm
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
            this.firstLanguageCombBox = new System.Windows.Forms.ComboBox();
            this.secondLanguageCombBox = new System.Windows.Forms.ComboBox();
            this.NewDictionaryLabel = new DictionaryWithUI.CustomLabel();
            this.AddDictionaryBtn = new DictionaryWithUI.CustomButton();
            this.SuspendLayout();
            // 
            // firstLanguageCombBox
            // 
            this.firstLanguageCombBox.FormattingEnabled = true;
            this.firstLanguageCombBox.Location = new System.Drawing.Point(12, 12);
            this.firstLanguageCombBox.Name = "firstLanguageCombBox";
            this.firstLanguageCombBox.Size = new System.Drawing.Size(258, 21);
            this.firstLanguageCombBox.TabIndex = 5;
            this.firstLanguageCombBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // secondLanguageCombBox
            // 
            this.secondLanguageCombBox.Enabled = false;
            this.secondLanguageCombBox.FormattingEnabled = true;
            this.secondLanguageCombBox.Location = new System.Drawing.Point(12, 82);
            this.secondLanguageCombBox.Name = "secondLanguageCombBox";
            this.secondLanguageCombBox.Size = new System.Drawing.Size(258, 21);
            this.secondLanguageCombBox.TabIndex = 6;
            this.secondLanguageCombBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // NewDictionaryLabel
            // 
            this.NewDictionaryLabel.LabelText = "";
            this.NewDictionaryLabel.Location = new System.Drawing.Point(87, 39);
            this.NewDictionaryLabel.Name = "NewDictionaryLabel";
            this.NewDictionaryLabel.Size = new System.Drawing.Size(102, 37);
            this.NewDictionaryLabel.TabIndex = 4;
            // 
            // AddDictionaryBtn
            // 
            this.AddDictionaryBtn.Checked = false;
            this.AddDictionaryBtn.Location = new System.Drawing.Point(139, 112);
            this.AddDictionaryBtn.Name = "AddDictionaryBtn";
            this.AddDictionaryBtn.Size = new System.Drawing.Size(131, 37);
            this.AddDictionaryBtn.TabIndex = 3;
            this.AddDictionaryBtn.TextOnTheButton = "Add dictionary";
            this.AddDictionaryBtn.Clicked += new System.EventHandler(this.AddDictionaryBtn_Clicked);
            // 
            // AddDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(282, 161);
            this.Controls.Add(this.secondLanguageCombBox);
            this.Controls.Add(this.firstLanguageCombBox);
            this.Controls.Add(this.NewDictionaryLabel);
            this.Controls.Add(this.AddDictionaryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDictionaryForm";
            this.ShowIcon = false;
            this.Text = "Add dictionary";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton AddDictionaryBtn;
        private CustomLabel NewDictionaryLabel;
        private System.Windows.Forms.ComboBox firstLanguageCombBox;
        private System.Windows.Forms.ComboBox secondLanguageCombBox;
    }
}