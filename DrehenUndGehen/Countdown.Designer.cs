namespace DrehenUndGehen
{
    partial class Countdown
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
            this.pbCounter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCounter
            // 
            this.pbCounter.BackColor = System.Drawing.Color.Transparent;
            this.pbCounter.Location = new System.Drawing.Point(522, 183);
            this.pbCounter.Name = "pbCounter";
            this.pbCounter.Size = new System.Drawing.Size(302, 240);
            this.pbCounter.TabIndex = 1;
            this.pbCounter.TabStop = false;
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DrehenUndGehen.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1311, 620);
            this.ControlBox = false;
            this.Controls.Add(this.pbCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Countdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            ((System.ComponentModel.ISupportInitialize)(this.pbCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCounter;
    }
}