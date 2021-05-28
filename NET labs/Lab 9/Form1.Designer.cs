namespace WindowsFormsApp14
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.patternBox = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(46, 48);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(524, 48);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(41, 13);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "Pattern";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(46, 155);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 2;
            this.resultsLabel.Text = "Results";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(49, 74);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 3;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // patternBox
            // 
            this.patternBox.Location = new System.Drawing.Point(527, 74);
            this.patternBox.Name = "patternBox";
            this.patternBox.Size = new System.Drawing.Size(100, 20);
            this.patternBox.TabIndex = 4;
            this.patternBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patternBox_KeyDown);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(49, 181);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsBox.Size = new System.Drawing.Size(578, 78);
            this.resultsBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 291);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.patternBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.inputLabel);
            this.Name = "Form1";
            this.Text = "Regex Split";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox patternBox;
        private System.Windows.Forms.TextBox resultsBox;
    }
}

