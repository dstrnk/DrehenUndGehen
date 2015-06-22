namespace DrehenUndGehen
{
    partial class ChooseYourMap
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.rbBeginner = new System.Windows.Forms.RadioButton();
            this.rbFortgeschrittene = new System.Windows.Forms.RadioButton();
            this.rbExperten = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(464, 433);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 29);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "weiter";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 433);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(97, 29);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pbMap
            // 
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMap.Location = new System.Drawing.Point(298, 86);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(247, 249);
            this.pbMap.TabIndex = 2;
            this.pbMap.TabStop = false;
            // 
            // rbBeginner
            // 
            this.rbBeginner.AutoSize = true;
            this.rbBeginner.Checked = true;
            this.rbBeginner.Location = new System.Drawing.Point(6, 41);
            this.rbBeginner.Name = "rbBeginner";
            this.rbBeginner.Size = new System.Drawing.Size(67, 17);
            this.rbBeginner.TabIndex = 3;
            this.rbBeginner.TabStop = true;
            this.rbBeginner.Text = "Beginner";
            this.rbBeginner.UseVisualStyleBackColor = true;
            // 
            // rbFortgeschrittene
            // 
            this.rbFortgeschrittene.AutoSize = true;
            this.rbFortgeschrittene.Location = new System.Drawing.Point(6, 86);
            this.rbFortgeschrittene.Name = "rbFortgeschrittene";
            this.rbFortgeschrittene.Size = new System.Drawing.Size(101, 17);
            this.rbFortgeschrittene.TabIndex = 4;
            this.rbFortgeschrittene.Text = "Fortgeschrittene";
            this.rbFortgeschrittene.UseVisualStyleBackColor = true;
            // 
            // rbExperten
            // 
            this.rbExperten.AutoSize = true;
            this.rbExperten.Location = new System.Drawing.Point(6, 135);
            this.rbExperten.Name = "rbExperten";
            this.rbExperten.Size = new System.Drawing.Size(67, 17);
            this.rbExperten.TabIndex = 5;
            this.rbExperten.Text = "Experten";
            this.rbExperten.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbExperten);
            this.groupBox1.Controls.Add(this.rbFortgeschrittene);
            this.groupBox1.Controls.Add(this.rbBeginner);
            this.groupBox1.Location = new System.Drawing.Point(26, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schwierigkeitsgrad:";
            // 
            // ChooseYourMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnNext);
            this.Name = "ChooseYourMap";
            this.Text = "ChooseYourMap";
            this.Load += new System.EventHandler(this.ChooseYourMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.RadioButton rbBeginner;
        private System.Windows.Forms.RadioButton rbFortgeschrittene;
        private System.Windows.Forms.RadioButton rbExperten;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}