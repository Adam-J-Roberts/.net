namespace Lab_12
{
    partial class PrimeForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResultsTextbox = new System.Windows.Forms.TextBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.PrimaryLabel = new System.Windows.Forms.Label();
            this.CeilingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(138, 255);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(84, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button_start_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(305, 255);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 45);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // ResultsTextbox
            // 
            this.ResultsTextbox.Location = new System.Drawing.Point(215, 183);
            this.ResultsTextbox.Name = "ResultsTextbox";
            this.ResultsTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResultsTextbox.TabIndex = 2;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(215, 85);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextbox.TabIndex = 3;
            // 
            // PrimaryLabel
            // 
            this.PrimaryLabel.AutoSize = true;
            this.PrimaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryLabel.Location = new System.Drawing.Point(142, 136);
            this.PrimaryLabel.Name = "PrimaryLabel";
            this.PrimaryLabel.Size = new System.Drawing.Size(256, 26);
            this.PrimaryLabel.TabIndex = 4;
            this.PrimaryLabel.Text = "Primary Numbers Found:";
            // 
            // CeilingLabel
            // 
            this.CeilingLabel.AutoSize = true;
            this.CeilingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CeilingLabel.Location = new System.Drawing.Point(189, 45);
            this.CeilingLabel.Name = "CeilingLabel";
            this.CeilingLabel.Size = new System.Drawing.Size(151, 26);
            this.CeilingLabel.TabIndex = 5;
            this.CeilingLabel.Text = "Search Up To:";
            this.CeilingLabel.Click += new System.EventHandler(this.CeilingLabel_Click);
            // 
            // PrimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 348);
            this.Controls.Add(this.CeilingLabel);
            this.Controls.Add(this.PrimaryLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.ResultsTextbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Name = "PrimeForm";
            this.Text = "Find Primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ResultsTextbox;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label PrimaryLabel;
        private System.Windows.Forms.Label CeilingLabel;
    }
}