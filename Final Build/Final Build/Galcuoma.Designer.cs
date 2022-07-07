namespace Final_Build
{
    partial class Galcuoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galcuoma));
            this.BUTTON_BK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Audio = new System.Windows.Forms.Button();
            this.TXT_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BUTTON_BK
            // 
            this.BUTTON_BK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_BK.Location = new System.Drawing.Point(403, 408);
            this.BUTTON_BK.Name = "BUTTON_BK";
            this.BUTTON_BK.Size = new System.Drawing.Size(94, 43);
            this.BUTTON_BK.TabIndex = 0;
            this.BUTTON_BK.Text = "Back";
            this.BUTTON_BK.UseVisualStyleBackColor = true;
            this.BUTTON_BK.Click += new System.EventHandler(this.BUTTON_BK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Galcuoma";
            // 
            // BTN_Audio
            // 
            this.BTN_Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Audio.Location = new System.Drawing.Point(35, 406);
            this.BTN_Audio.Name = "BTN_Audio";
            this.BTN_Audio.Size = new System.Drawing.Size(94, 45);
            this.BTN_Audio.TabIndex = 2;
            this.BTN_Audio.Text = "Play Sound";
            this.BTN_Audio.UseVisualStyleBackColor = true;
            this.BTN_Audio.Click += new System.EventHandler(this.BTN_Audio_Click);
            // 
            // TXT_Box
            // 
            this.TXT_Box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Box.Location = new System.Drawing.Point(35, 52);
            this.TXT_Box.Multiline = true;
            this.TXT_Box.Name = "TXT_Box";
            this.TXT_Box.ReadOnly = true;
            this.TXT_Box.Size = new System.Drawing.Size(462, 318);
            this.TXT_Box.TabIndex = 3;
            this.TXT_Box.Text = resources.GetString("TXT_Box.Text");
            // 
            // Galcuoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 477);
            this.Controls.Add(this.TXT_Box);
            this.Controls.Add(this.BTN_Audio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BUTTON_BK);
            this.Name = "Galcuoma";
            this.Text = "Galcuoma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUTTON_BK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Audio;
        private System.Windows.Forms.TextBox TXT_Box;
    }
}