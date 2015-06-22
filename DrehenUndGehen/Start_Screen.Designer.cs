namespace DrehenUndGehen
{
    partial class Start_Screen
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
            this.btnStarten = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStarten
            // 
            this.btnStarten.BackColor = System.Drawing.Color.Transparent;
            this.btnStarten.Location = new System.Drawing.Point(167, 275);
            this.btnStarten.Name = "btnStarten";
            this.btnStarten.Size = new System.Drawing.Size(248, 51);
            this.btnStarten.TabIndex = 0;
            this.btnStarten.Text = "Starten";
            this.btnStarten.UseVisualStyleBackColor = false;
            this.btnStarten.Click += new System.EventHandler(this.btnStarten_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(167, 355);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(248, 52);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 558);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnStarten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spielname";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStarten;
        private System.Windows.Forms.Button btnBeenden;
    }
}