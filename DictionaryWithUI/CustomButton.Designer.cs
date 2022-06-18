namespace DictionaryWithUI
{
    partial class CustomButton
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonText = new System.Windows.Forms.Label();
            this.pictureBoxRightEdge = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftEdge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftEdge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonText
            // 
            this.buttonText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.buttonText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonText.ForeColor = System.Drawing.Color.White;
            this.buttonText.Location = new System.Drawing.Point(17, 0);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(68, 37);
            this.buttonText.TabIndex = 3;
            this.buttonText.Text = "button";
            this.buttonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            this.buttonText.MouseEnter += new System.EventHandler(this.MouseOnButton);
            this.buttonText.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // pictureBoxRightEdge
            // 
            this.pictureBoxRightEdge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxRightEdge.Image = global::DictionaryWithUI.Properties.Resources.graycustbuttonRIGHTedge;
            this.pictureBoxRightEdge.Location = new System.Drawing.Point(85, 0);
            this.pictureBoxRightEdge.Name = "pictureBoxRightEdge";
            this.pictureBoxRightEdge.Size = new System.Drawing.Size(17, 37);
            this.pictureBoxRightEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRightEdge.TabIndex = 2;
            this.pictureBoxRightEdge.TabStop = false;
            this.pictureBoxRightEdge.Click += new System.EventHandler(this.buttonText_Click);
            this.pictureBoxRightEdge.MouseEnter += new System.EventHandler(this.MouseOnButton);
            this.pictureBoxRightEdge.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // pictureBoxLeftEdge
            // 
            this.pictureBoxLeftEdge.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLeftEdge.Image = global::DictionaryWithUI.Properties.Resources.graycustbuttonLEFTedge;
            this.pictureBoxLeftEdge.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeftEdge.Name = "pictureBoxLeftEdge";
            this.pictureBoxLeftEdge.Size = new System.Drawing.Size(17, 37);
            this.pictureBoxLeftEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLeftEdge.TabIndex = 1;
            this.pictureBoxLeftEdge.TabStop = false;
            this.pictureBoxLeftEdge.Click += new System.EventHandler(this.buttonText_Click);
            this.pictureBoxLeftEdge.MouseEnter += new System.EventHandler(this.MouseOnButton);
            this.pictureBoxLeftEdge.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.pictureBoxRightEdge);
            this.Controls.Add(this.pictureBoxLeftEdge);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(102, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftEdge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLeftEdge;
        private System.Windows.Forms.PictureBox pictureBoxRightEdge;
        private System.Windows.Forms.Label buttonText;
    }
}
