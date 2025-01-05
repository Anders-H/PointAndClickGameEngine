namespace TestGame
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
            this.optionStamp = new System.Windows.Forms.RadioButton();
            this.optionButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // optionStamp
            // 
            this.optionStamp.AutoSize = true;
            this.optionStamp.Checked = true;
            this.optionStamp.Location = new System.Drawing.Point(4, 60);
            this.optionStamp.Name = "optionStamp";
            this.optionStamp.Size = new System.Drawing.Size(55, 17);
            this.optionStamp.TabIndex = 0;
            this.optionStamp.Text = "Stamp";
            this.optionStamp.UseVisualStyleBackColor = true;
            this.optionStamp.CheckedChanged += new System.EventHandler(this.optionStamp_CheckedChanged);
            // 
            // optionButton
            // 
            this.optionButton.AutoSize = true;
            this.optionButton.Location = new System.Drawing.Point(4, 80);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(61, 17);
            this.optionButton.TabIndex = 1;
            this.optionButton.Text = "Buttons";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionButton);
            this.Controls.Add(this.optionStamp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optionStamp;
        private System.Windows.Forms.RadioButton optionButton;
    }
}