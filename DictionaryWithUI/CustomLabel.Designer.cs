namespace DictionaryWithUI
{
    partial class CustomLabel
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
            this.labeltext = new System.Windows.Forms.Label();
            this.pictureBoxRightEdge = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftEdge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftEdge)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltext
            // 
            this.labeltext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(100)))), ((int)(((byte)(111)))));
            this.labeltext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltext.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext.ForeColor = System.Drawing.Color.White;
            this.labeltext.Location = new System.Drawing.Point(17, 0);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(68, 37);
            this.labeltext.TabIndex = 6;
            this.labeltext.Text = "label";
            this.labeltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxRightEdge
            // 
            this.pictureBoxRightEdge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxRightEdge.Image = global::DictionaryWithUI.Properties.Resources.graycustbuttonRIGHTedge;
            this.pictureBoxRightEdge.Location = new System.Drawing.Point(85, 0);
            this.pictureBoxRightEdge.Name = "pictureBoxRightEdge";
            this.pictureBoxRightEdge.Size = new System.Drawing.Size(17, 37);
            this.pictureBoxRightEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRightEdge.TabIndex = 5;
            this.pictureBoxRightEdge.TabStop = false;
            // 
            // pictureBoxLeftEdge
            // 
            this.pictureBoxLeftEdge.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLeftEdge.Image = global::DictionaryWithUI.Properties.Resources.graycustbuttonLEFTedge;
            this.pictureBoxLeftEdge.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeftEdge.Name = "pictureBoxLeftEdge";
            this.pictureBoxLeftEdge.Size = new System.Drawing.Size(17, 37);
            this.pictureBoxLeftEdge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLeftEdge.TabIndex = 4;
            this.pictureBoxLeftEdge.TabStop = false;
            // 
            // CustomLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.pictureBoxRightEdge);
            this.Controls.Add(this.pictureBoxLeftEdge);
            this.Name = "CustomLabel";
            this.Size = new System.Drawing.Size(102, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftEdge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.PictureBox pictureBoxRightEdge;
        private System.Windows.Forms.PictureBox pictureBoxLeftEdge;
    }
}
