namespace RPC
{
    partial class RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.RockButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.player1Pic = new System.Windows.Forms.PictureBox();
            this.player2Pic = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.TieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.BackColor = System.Drawing.Color.PeachPuff;
            this.RockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RockButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RockButton.Location = new System.Drawing.Point(12, 201);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 23);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = false;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ScissorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScissorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ScissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScissorsButton.Location = new System.Drawing.Point(53, 230);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorsButton.TabIndex = 1;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = false;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.BackColor = System.Drawing.Color.PeachPuff;
            this.PaperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaperButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.PaperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaperButton.Location = new System.Drawing.Point(93, 201);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = false;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // player1Pic
            // 
            this.player1Pic.Cursor = System.Windows.Forms.Cursors.No;
            this.player1Pic.Image = ((System.Drawing.Image)(resources.GetObject("player1Pic.Image")));
            this.player1Pic.Location = new System.Drawing.Point(12, 46);
            this.player1Pic.Name = "player1Pic";
            this.player1Pic.Size = new System.Drawing.Size(156, 129);
            this.player1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Pic.TabIndex = 3;
            this.player1Pic.TabStop = false;
            // 
            // player2Pic
            // 
            this.player2Pic.Cursor = System.Windows.Forms.Cursors.No;
            this.player2Pic.Image = ((System.Drawing.Image)(resources.GetObject("player2Pic.Image")));
            this.player2Pic.Location = new System.Drawing.Point(369, 46);
            this.player2Pic.Name = "player2Pic";
            this.player2Pic.Size = new System.Drawing.Size(156, 129);
            this.player2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Pic.TabIndex = 4;
            this.player2Pic.TabStop = false;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.PeachPuff;
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartButton.Location = new System.Drawing.Point(196, 300);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 5;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(277, 300);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(190, 91);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(45, 50);
            this.player1Score.TabIndex = 7;
            this.player1Score.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(307, 91);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(45, 50);
            this.player2Score.TabIndex = 8;
            this.player2Score.Text = "0";
            // 
            // divider
            // 
            this.divider.AutoSize = true;
            this.divider.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.Location = new System.Drawing.Point(250, 91);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(38, 50);
            this.divider.TabIndex = 9;
            this.divider.Text = "-";
            // 
            // TieLabel
            // 
            this.TieLabel.AutoSize = true;
            this.TieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieLabel.Location = new System.Drawing.Point(88, 9);
            this.TieLabel.Name = "TieLabel";
            this.TieLabel.Size = new System.Drawing.Size(0, 29);
            this.TieLabel.TabIndex = 10;
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.TieLabel);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.player2Pic);
            this.Controls.Add(this.player1Pic);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.RockButton);
            this.Name = "RPS";
            this.Text = "RPS";
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.PictureBox player1Pic;
        private System.Windows.Forms.PictureBox player2Pic;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label TieLabel;
    }
}

