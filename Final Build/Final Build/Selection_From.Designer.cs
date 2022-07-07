namespace Final_Build
{
    partial class Selection_From
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection_From));
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.RBTN_Cat = new System.Windows.Forms.RadioButton();
            this.RDBTN_AMD = new System.Windows.Forms.RadioButton();
            this.RDBTN_Galucoma = new System.Windows.Forms.RadioButton();
            this.RDBTN_Trachoma = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.Location = new System.Drawing.Point(325, 383);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(100, 62);
            this.BTN_Ok.TabIndex = 0;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.Location = new System.Drawing.Point(87, 383);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(107, 62);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "Exit";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // RBTN_Cat
            // 
            this.RBTN_Cat.AutoSize = true;
            this.RBTN_Cat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_Cat.Location = new System.Drawing.Point(325, 109);
            this.RBTN_Cat.Name = "RBTN_Cat";
            this.RBTN_Cat.Size = new System.Drawing.Size(100, 23);
            this.RBTN_Cat.TabIndex = 2;
            this.RBTN_Cat.TabStop = true;
            this.RBTN_Cat.Text = "Cataracts";
            this.RBTN_Cat.UseVisualStyleBackColor = true;
            // 
            // RDBTN_AMD
            // 
            this.RDBTN_AMD.AutoSize = true;
            this.RDBTN_AMD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN_AMD.Location = new System.Drawing.Point(325, 174);
            this.RDBTN_AMD.Name = "RDBTN_AMD";
            this.RDBTN_AMD.Size = new System.Drawing.Size(63, 23);
            this.RDBTN_AMD.TabIndex = 3;
            this.RDBTN_AMD.TabStop = true;
            this.RDBTN_AMD.Text = "AMD";
            this.RDBTN_AMD.UseVisualStyleBackColor = true;
            // 
            // RDBTN_Galucoma
            // 
            this.RDBTN_Galucoma.AutoSize = true;
            this.RDBTN_Galucoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN_Galucoma.Location = new System.Drawing.Point(325, 241);
            this.RDBTN_Galucoma.Name = "RDBTN_Galucoma";
            this.RDBTN_Galucoma.Size = new System.Drawing.Size(104, 23);
            this.RDBTN_Galucoma.TabIndex = 4;
            this.RDBTN_Galucoma.TabStop = true;
            this.RDBTN_Galucoma.Text = "Galcuoma";
            this.RDBTN_Galucoma.UseVisualStyleBackColor = true;
            // 
            // RDBTN_Trachoma
            // 
            this.RDBTN_Trachoma.AutoSize = true;
            this.RDBTN_Trachoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBTN_Trachoma.Location = new System.Drawing.Point(325, 310);
            this.RDBTN_Trachoma.Name = "RDBTN_Trachoma";
            this.RDBTN_Trachoma.Size = new System.Drawing.Size(103, 23);
            this.RDBTN_Trachoma.TabIndex = 6;
            this.RDBTN_Trachoma.TabStop = true;
            this.RDBTN_Trachoma.Text = "Trachoma";
            this.RDBTN_Trachoma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please choose one of the following options";
            // 
            // Selection_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(530, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RDBTN_Trachoma);
            this.Controls.Add(this.RDBTN_Galucoma);
            this.Controls.Add(this.RDBTN_AMD);
            this.Controls.Add(this.RBTN_Cat);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Ok);
            this.Name = "Selection_From";
            this.Text = "Main Contents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.RadioButton RBTN_Cat;
        private System.Windows.Forms.RadioButton RDBTN_AMD;
        private System.Windows.Forms.RadioButton RDBTN_Galucoma;
        private System.Windows.Forms.RadioButton RDBTN_Trachoma;
        private System.Windows.Forms.Label label1;
    }
}