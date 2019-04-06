namespace HelloWorldForms {
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
            this.Minus_button = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Label();
            this.Plus_button = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Minus_button
            // 
            this.Minus_button.Location = new System.Drawing.Point(12, 12);
            this.Minus_button.Name = "Minus_button";
            this.Minus_button.Size = new System.Drawing.Size(75, 23);
            this.Minus_button.TabIndex = 0;
            this.Minus_button.Text = "-";
            this.Minus_button.UseVisualStyleBackColor = true;
            this.Minus_button.Click += new System.EventHandler(this.Minus_button_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(93, 18);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(46, 23);
            this.Number.TabIndex = 1;
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus_button
            // 
            this.Plus_button.Location = new System.Drawing.Point(145, 12);
            this.Plus_button.Name = "Plus_button";
            this.Plus_button.Size = new System.Drawing.Size(75, 23);
            this.Plus_button.TabIndex = 2;
            this.Plus_button.Text = "+";
            this.Plus_button.UseVisualStyleBackColor = true;
            this.Plus_button.Click += new System.EventHandler(this.Plus_button_Click);
            // 
            // InputNumber
            // 
            this.InputNumber.Location = new System.Drawing.Point(186, 100);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(261, 22);
            this.InputNumber.TabIndex = 3;
            this.InputNumber.Text = "123";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.Plus_button);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Minus_button);
            this.Name = "Form1";
            this.Text = "Counter Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Minus_button;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button Plus_button;
        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

