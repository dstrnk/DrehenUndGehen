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
            this.btnGameStart = new System.Windows.Forms.Button();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(30, 376);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(169, 50);
            this.btnPlayer1.TabIndex = 1;
            this.btnPlayer1.Text = "Spieler 1 würfeln!";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.Location = new System.Drawing.Point(393, 376);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(169, 50);
            this.btnPlayer2.TabIndex = 2;
            this.btnPlayer2.Text = "Spieler 2 würfeln!";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 73);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(362, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 73);
            this.label2.TabIndex = 4;
            // 
            // WhoBegins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.btnGameStart);
            this.Name = "WhoBegins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhoBegins";
            this.Load += new System.EventHandler(this.WhoBegins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}