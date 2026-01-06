namespace quiz_4
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
            this.q1button = new System.Windows.Forms.Button();
            this.q2button = new System.Windows.Forms.Button();
            this.q3button = new System.Windows.Forms.Button();
            this.q4button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // q1button
            // 
            this.q1button.Location = new System.Drawing.Point(54, 71);
            this.q1button.Name = "q1button";
            this.q1button.Size = new System.Drawing.Size(75, 23);
            this.q1button.TabIndex = 0;
            this.q1button.Text = "button1";
            this.q1button.UseVisualStyleBackColor = true;
            this.q1button.Click += new System.EventHandler(this.q1button_Click);
            // 
            // q2button
            // 
            this.q2button.Location = new System.Drawing.Point(237, 47);
            this.q2button.Name = "q2button";
            this.q2button.Size = new System.Drawing.Size(75, 23);
            this.q2button.TabIndex = 1;
            this.q2button.Text = "button2";
            this.q2button.UseVisualStyleBackColor = true;
            this.q2button.Click += new System.EventHandler(this.q2button_Click);
            // 
            // q3button
            // 
            this.q3button.Location = new System.Drawing.Point(468, 120);
            this.q3button.Name = "q3button";
            this.q3button.Size = new System.Drawing.Size(75, 23);
            this.q3button.TabIndex = 2;
            this.q3button.Text = "button3";
            this.q3button.UseVisualStyleBackColor = true;
            this.q3button.Click += new System.EventHandler(this.q3button_Click);
            // 
            // q4button
            // 
            this.q4button.Location = new System.Drawing.Point(546, 188);
            this.q4button.Name = "q4button";
            this.q4button.Size = new System.Drawing.Size(75, 23);
            this.q4button.TabIndex = 3;
            this.q4button.Text = "button4";
            this.q4button.UseVisualStyleBackColor = true;
            this.q4button.Click += new System.EventHandler(this.q4button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 296);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 133);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.q4button);
            this.Controls.Add(this.q3button);
            this.Controls.Add(this.q2button);
            this.Controls.Add(this.q1button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button q1button;
        private System.Windows.Forms.Button q2button;
        private System.Windows.Forms.Button q3button;
        private System.Windows.Forms.Button q4button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

