namespace Final_Build
{
    partial class Cataracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cataracts));
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.BTN_Sound = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cataracts";
            // 
            // BTN_Back
            // 
            this.BTN_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Back.Location = new System.Drawing.Point(415, 286);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(105, 54);
            this.BTN_Back.TabIndex = 2;
            this.BTN_Back.Text = "Back";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_Sound
            // 
            this.BTN_Sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sound.Location = new System.Drawing.Point(134, 286);
            this.BTN_Sound.Name = "BTN_Sound";
            this.BTN_Sound.Size = new System.Drawing.Size(105, 54);
            this.BTN_Sound.TabIndex = 3;
            this.BTN_Sound.Text = "Play Sound";
            this.BTN_Sound.UseVisualStyleBackColor = true;
            this.BTN_Sound.Click += new System.EventHandler(this.BTN_Sound_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(134, 65);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(386, 200);
            this.textBoxC.TabIndex = 4;
            this.textBoxC.Text = resources.GetString("textBoxC.Text");
            // 
            // Cataracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(659, 364);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.BTN_Sound);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.label1);
            this.Name = "Cataracts";
            this.Text = "Cataracts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Button BTN_Sound;
        private System.Windows.Forms.TextBox textBoxC;
    }
}