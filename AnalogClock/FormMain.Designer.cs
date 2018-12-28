namespace AnalogClock
{
    partial class FormMain
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
            this.labelNumber12 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.labelNumber6 = new System.Windows.Forms.Label();
            this.labelNumber9 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelNumber12
            // 
            this.labelNumber12.AutoSize = true;
            this.labelNumber12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumber12.Location = new System.Drawing.Point(172, 9);
            this.labelNumber12.Name = "labelNumber12";
            this.labelNumber12.Size = new System.Drawing.Size(38, 25);
            this.labelNumber12.TabIndex = 0;
            this.labelNumber12.Text = "12";
            // 
            // labelNumber3
            // 
            this.labelNumber3.AutoSize = true;
            this.labelNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumber3.Location = new System.Drawing.Point(351, 159);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(25, 25);
            this.labelNumber3.TabIndex = 1;
            this.labelNumber3.Text = "3";
            // 
            // labelNumber6
            // 
            this.labelNumber6.AutoSize = true;
            this.labelNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumber6.Location = new System.Drawing.Point(180, 328);
            this.labelNumber6.Name = "labelNumber6";
            this.labelNumber6.Size = new System.Drawing.Size(25, 25);
            this.labelNumber6.TabIndex = 2;
            this.labelNumber6.Text = "6";
            // 
            // labelNumber9
            // 
            this.labelNumber9.AutoSize = true;
            this.labelNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumber9.Location = new System.Drawing.Point(12, 159);
            this.labelNumber9.Name = "labelNumber9";
            this.labelNumber9.Size = new System.Drawing.Size(25, 25);
            this.labelNumber9.TabIndex = 3;
            this.labelNumber9.Text = "9";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.labelNumber9);
            this.Controls.Add(this.labelNumber6);
            this.Controls.Add(this.labelNumber3);
            this.Controls.Add(this.labelNumber12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormMain";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber12;
        private System.Windows.Forms.Label labelNumber3;
        private System.Windows.Forms.Label labelNumber6;
        private System.Windows.Forms.Label labelNumber9;
        private System.Windows.Forms.Timer timerMain;
    }
}

