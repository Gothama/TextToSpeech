namespace TextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 589);
            this.textBox1.TabIndex = 0;
            // 
            // btnFemale
            // 
            this.btnFemale.Location = new System.Drawing.Point(592, 22);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(165, 50);
            this.btnFemale.TabIndex = 1;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnMale
            // 
            this.btnMale.Location = new System.Drawing.Point(592, 96);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(165, 50);
            this.btnMale.TabIndex = 2;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(592, 172);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(165, 50);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(592, 250);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(165, 50);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.Text = "Pause";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(592, 325);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(165, 50);
            this.btnResume.TabIndex = 5;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 685);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Text 2 Speech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnResume;
    }
}

