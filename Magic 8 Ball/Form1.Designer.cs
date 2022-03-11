namespace Magic_8_Ball
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
            this.label1 = new System.Windows.Forms.Label();
            this.eightBallButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(328, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Think of a question";
            // 
            // eightBallButton
            // 
            this.eightBallButton.FlatAppearance.BorderSize = 0;
            this.eightBallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eightBallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBallButton.Image = global::Magic_8_Ball.Properties.Resources.clickBall;
            this.eightBallButton.Location = new System.Drawing.Point(163, 62);
            this.eightBallButton.Name = "eightBallButton";
            this.eightBallButton.Size = new System.Drawing.Size(528, 460);
            this.eightBallButton.TabIndex = 1;
            this.eightBallButton.UseVisualStyleBackColor = true;
            this.eightBallButton.Click += new System.EventHandler(this.eightBallButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.outputLabel.Location = new System.Drawing.Point(311, 536);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(218, 25);
            this.outputLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 613);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.eightBallButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eightBallButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

