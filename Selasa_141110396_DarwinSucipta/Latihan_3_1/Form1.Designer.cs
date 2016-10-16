namespace Latihan_3_1
{
    partial class Form1
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
            this.Bold = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bold.Location = new System.Drawing.Point(12, 9);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(37, 20);
            this.Bold.TabIndex = 0;
            this.Bold.Text = "B";
            this.Bold.UseVisualStyleBackColor = true;
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic.Location = new System.Drawing.Point(55, 9);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(31, 20);
            this.Italic.TabIndex = 1;
            this.Italic.Text = "I";
            this.Italic.UseVisualStyleBackColor = true;
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Underline.Location = new System.Drawing.Point(92, 9);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(38, 20);
            this.Underline.TabIndex = 2;
            this.Underline.Text = "U";
            this.Underline.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 331);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 378);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.CheckBox Underline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

