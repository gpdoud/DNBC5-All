namespace SimplifiedCrapsForm {
    partial class SimpleCrapsForm {
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
            this.Roll = new System.Windows.Forms.Button();
            this.GameStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastRoll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Games = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Loses = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll.Location = new System.Drawing.Point(157, 114);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(118, 59);
            this.Roll.TabIndex = 0;
            this.Roll.Text = "ROLL";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameStatus
            // 
            this.GameStatus.AutoSize = true;
            this.GameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStatus.Location = new System.Drawing.Point(126, 13);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(55, 20);
            this.GameStatus.TabIndex = 1;
            this.GameStatus.Text = "Ready";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Status:";
            // 
            // LastRoll
            // 
            this.LastRoll.AutoSize = true;
            this.LastRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastRoll.Location = new System.Drawing.Point(126, 33);
            this.LastRoll.Name = "LastRoll";
            this.LastRoll.Size = new System.Drawing.Size(18, 20);
            this.LastRoll.TabIndex = 1;
            this.LastRoll.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Roll:";
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.Location = new System.Drawing.Point(126, 56);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(18, 20);
            this.Point.TabIndex = 1;
            this.Point.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Point:";
            // 
            // Games
            // 
            this.Games.AutoSize = true;
            this.Games.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games.Location = new System.Drawing.Point(330, 13);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(18, 20);
            this.Games.TabIndex = 1;
            this.Games.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Games:";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wins.Location = new System.Drawing.Point(330, 33);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(18, 20);
            this.Wins.TabIndex = 1;
            this.Wins.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Wins:";
            // 
            // Loses
            // 
            this.Loses.AutoSize = true;
            this.Loses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loses.Location = new System.Drawing.Point(330, 53);
            this.Loses.Name = "Loses";
            this.Loses.Size = new System.Drawing.Size(18, 20);
            this.Loses.TabIndex = 1;
            this.Loses.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Loses:";
            // 
            // SimpleCrapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 206);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loses);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.LastRoll);
            this.Controls.Add(this.GameStatus);
            this.Controls.Add(this.Roll);
            this.Name = "SimpleCrapsForm";
            this.Text = "Simple Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.Label GameStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LastRoll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Games;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Loses;
        private System.Windows.Forms.Label label12;
    }
}

