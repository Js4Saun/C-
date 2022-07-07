namespace Final_Build
{
    partial class Trachoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trachoma));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gobak = new System.Windows.Forms.Button();
            this.BTN_PlaySound = new System.Windows.Forms.Button();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trachoma";
            // 
            // btn_gobak
            // 
            this.btn_gobak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gobak.Location = new System.Drawing.Point(320, 283);
            this.btn_gobak.Name = "btn_gobak";
            this.btn_gobak.Size = new System.Drawing.Size(104, 60);
            this.btn_gobak.TabIndex = 1;
            this.btn_gobak.Text = "Back";
            this.btn_gobak.UseVisualStyleBackColor = true;
            this.btn_gobak.Click += new System.EventHandler(this.btn_gobak_Click);
            // 
            // BTN_PlaySound
            // 
            this.BTN_PlaySound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PlaySound.Location = new System.Drawing.Point(40, 283);
            this.BTN_PlaySound.Name = "BTN_PlaySound";
            this.BTN_PlaySound.Size = new System.Drawing.Size(102, 60);
            this.BTN_PlaySound.TabIndex = 2;
            this.BTN_PlaySound.Text = "Play Sound";
            this.BTN_PlaySound.UseVisualStyleBackColor = true;
            this.BTN_PlaySound.Click += new System.EventHandler(this.BTN_PlaySound_Click);
            // 
            // textBoxT
            // 
            this.textBoxT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxT.Location = new System.Drawing.Point(28, 62);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(396, 215);
            this.textBoxT.TabIndex = 3;
            this.textBoxT.Text = resources.GetString("textBoxT.Text");
            // 
            // Trachoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 355);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.BTN_PlaySound);
            this.Controls.Add(this.btn_gobak);
            this.Controls.Add(this.label1);
            this.Name = "Trachoma";
            this.Text = "Trachoma";
            this.Load += new System.EventHandler(this.Trachoma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gobak;
        private System.Windows.Forms.Button BTN_PlaySound;
        private System.Windows.Forms.TextBox textBoxT;
    }
}