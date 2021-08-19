
namespace Nopyfy_information_decrypter
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
            this.decoderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.ConvertCLTitelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decoderButton
            // 
            this.decoderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.decoderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.decoderButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.decoderButton.Location = new System.Drawing.Point(471, 251);
            this.decoderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decoderButton.Name = "decoderButton";
            this.decoderButton.Size = new System.Drawing.Size(143, 48);
            this.decoderButton.TabIndex = 0;
            this.decoderButton.Text = "Decode";
            this.decoderButton.UseVisualStyleBackColor = false;
            this.decoderButton.Click += new System.EventHandler(this.decoderButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(669, 251);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 48);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clTextBox.Location = new System.Drawing.Point(132, 103);
            this.clTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(1126, 39);
            this.clTextBox.TabIndex = 2;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.litreTextBox.Location = new System.Drawing.Point(132, 160);
            this.litreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(1126, 41);
            this.litreTextBox.TabIndex = 3;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvertCLTitelLabel
            // 
            this.ConvertCLTitelLabel.AutoSize = true;
            this.ConvertCLTitelLabel.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertCLTitelLabel.ForeColor = System.Drawing.Color.Black;
            this.ConvertCLTitelLabel.Location = new System.Drawing.Point(399, 9);
            this.ConvertCLTitelLabel.Name = "ConvertCLTitelLabel";
            this.ConvertCLTitelLabel.Size = new System.Drawing.Size(415, 38);
            this.ConvertCLTitelLabel.TabIndex = 6;
            this.ConvertCLTitelLabel.Text = "Future_World Decoder";
            this.ConvertCLTitelLabel.Click += new System.EventHandler(this.ConvertCLTitelLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pass: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1270, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertCLTitelLabel);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decoderButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nopyfy-Information-Decrypter";
            this.Load += new System.EventHandler(this.volumeConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decoderButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Label ConvertCLTitelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

