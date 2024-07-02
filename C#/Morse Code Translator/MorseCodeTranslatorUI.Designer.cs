
namespace Morse_Code_Translator
{
    partial class MorseCodeTranslatorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorseCodeTranslatorUI));
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.morseTextBox = new System.Windows.Forms.TextBox();
            this.toMorseBtn = new System.Windows.Forms.Button();
            this.toEnglishBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // englishTextBox
            // 
            this.englishTextBox.Location = new System.Drawing.Point(99, 195);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(240, 22);
            this.englishTextBox.TabIndex = 0;
            // 
            // morseTextBox
            // 
            this.morseTextBox.Location = new System.Drawing.Point(434, 195);
            this.morseTextBox.Name = "morseTextBox";
            this.morseTextBox.Size = new System.Drawing.Size(240, 22);
            this.morseTextBox.TabIndex = 1;
            // 
            // toMorseBtn
            // 
            this.toMorseBtn.Location = new System.Drawing.Point(174, 261);
            this.toMorseBtn.Name = "toMorseBtn";
            this.toMorseBtn.Size = new System.Drawing.Size(81, 23);
            this.toMorseBtn.TabIndex = 2;
            this.toMorseBtn.Text = "Translate";
            this.toMorseBtn.UseVisualStyleBackColor = true;
            this.toMorseBtn.Click += new System.EventHandler(this.toMorseBtn_Click);
            // 
            // toEnglishBtn
            // 
            this.toEnglishBtn.Location = new System.Drawing.Point(517, 261);
            this.toEnglishBtn.Name = "toEnglishBtn";
            this.toEnglishBtn.Size = new System.Drawing.Size(80, 23);
            this.toEnglishBtn.TabIndex = 3;
            this.toEnglishBtn.Text = "Translate";
            this.toEnglishBtn.UseVisualStyleBackColor = true;
            this.toEnglishBtn.Click += new System.EventHandler(this.toEnglishBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morse Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Morse Code Translator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MorseCodeTranslatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toEnglishBtn);
            this.Controls.Add(this.toMorseBtn);
            this.Controls.Add(this.morseTextBox);
            this.Controls.Add(this.englishTextBox);
            this.Name = "MorseCodeTranslatorUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox morseTextBox;
        private System.Windows.Forms.Button toMorseBtn;
        private System.Windows.Forms.Button toEnglishBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

