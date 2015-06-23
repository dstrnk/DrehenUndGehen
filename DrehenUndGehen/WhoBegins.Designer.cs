namespace DrehenUndGehen
{
    partial class WhoBegins
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
            this.components = new System.ComponentModel.Container();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(216, 490);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(152, 49);
            this.btnGameStart.TabIndex = 0;
            this.btnGameStart.Text = "Spiel Starten";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Visible = false;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // WhoBegins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btnGameStart);
            this.Name = "WhoBegins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhoBegins";
            this.Load += new System.EventHandler(this.WhoBegins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameStart;
    }
}