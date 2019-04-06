namespace CalculatorForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Op1 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Op2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Modulus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Op1
            // 
            this.Op1.Location = new System.Drawing.Point(12, 12);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(100, 22);
            this.Op1.TabIndex = 0;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(118, 12);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "Add";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(118, 41);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "Subtract";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(118, 70);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(75, 23);
            this.Times.TabIndex = 1;
            this.Times.Text = "Times";
            this.Times.UseVisualStyleBackColor = true;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(118, 99);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 1;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Op2
            // 
            this.Op2.Location = new System.Drawing.Point(199, 13);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(100, 22);
            this.Op2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equals";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(357, 16);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(46, 17);
            this.Answer.TabIndex = 2;
            this.Answer.Text = "label1";
            // 
            // Modulus
            // 
            this.Modulus.Location = new System.Drawing.Point(118, 128);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(75, 23);
            this.Modulus.TabIndex = 1;
            this.Modulus.Text = "Modulus";
            this.Modulus.UseVisualStyleBackColor = true;
            this.Modulus.Click += new System.EventHandler(this.Modulus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 271);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Op2);
            this.Controls.Add(this.Op1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Op1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox Op2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button Modulus;
    }
}

