namespace Final_Build
{
    partial class AMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMD));
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_SoundAMD = new System.Windows.Forms.Button();
            this.textBoxAMD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BACK.Location = new System.Drawing.Point(466, 348);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(124, 58);
            this.BTN_BACK.TabIndex = 0;
            this.BTN_BACK.Text = "Back";
            this.BTN_BACK.UseVisualStyleBackColor = true;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMD Age related Malcular Degeneration";
            // 
            // BTN_SoundAMD
            // 
            this.BTN_SoundAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SoundAMD.Location = new System.Drawing.Point(85, 348);
            this.BTN_SoundAMD.Name = "BTN_SoundAMD";
            this.BTN_SoundAMD.Size = new System.Drawing.Size(128, 58);
            this.BTN_SoundAMD.TabIndex = 2;
            this.BTN_SoundAMD.Text = "Play Sound";
            this.BTN_SoundAMD.UseVisualStyleBackColor = true;
            this.BTN_SoundAMD.Click += new System.EventHandler(this.BTN_SoundAMD_Click);
            // 
            // textBoxAMD
            // 
            this.textBoxAMD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAMD.Location = new System.Drawing.Point(142, 153);
            this.textBoxAMD.Multiline = true;
            this.textBoxAMD.Name = "textBoxAMD";
            this.textBoxAMD.ReadOnly = true;
            this.textBoxAMD.Size = new System.Drawing.Size(420, 163);
            this.textBoxAMD.TabIndex = 3;
            this.textBoxAMD.Text = resources.GetString("textBoxAMD.Text");
            // 
            // AMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 460);
            this.Controls.Add(this.textBoxAMD);
            this.Controls.Add(this.BTN_SoundAMD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_BACK);
            this.Name = "AMD";
            this.Text = "AMD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BACK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_SoundAMD;
        private System.Windows.Forms.TextBox textBoxAMD;
    }
}