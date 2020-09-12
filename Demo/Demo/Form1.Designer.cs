namespace Demo
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
            this.readSettings = new System.Windows.Forms.Button();
            this.writeSettings = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readSettings
            // 
            this.readSettings.Location = new System.Drawing.Point(253, 68);
            this.readSettings.Name = "readSettings";
            this.readSettings.Size = new System.Drawing.Size(184, 36);
            this.readSettings.TabIndex = 0;
            this.readSettings.Text = "Read Settings";
            this.readSettings.UseVisualStyleBackColor = true;
            this.readSettings.Click += new System.EventHandler(this.readSettings_Click);
            // 
            // writeSettings
            // 
            this.writeSettings.Location = new System.Drawing.Point(43, 68);
            this.writeSettings.Name = "writeSettings";
            this.writeSettings.Size = new System.Drawing.Size(184, 36);
            this.writeSettings.TabIndex = 1;
            this.writeSettings.Text = "Write Settings";
            this.writeSettings.UseVisualStyleBackColor = true;
            this.writeSettings.Click += new System.EventHandler(this.writeSettings_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(43, 26);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(394, 20);
            this.url.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 131);
            this.Controls.Add(this.url);
            this.Controls.Add(this.writeSettings);
            this.Controls.Add(this.readSettings);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readSettings;
        private System.Windows.Forms.Button writeSettings;
        private System.Windows.Forms.TextBox url;
    }
}

