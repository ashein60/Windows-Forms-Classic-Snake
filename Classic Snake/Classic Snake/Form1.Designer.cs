namespace Classic_Snake
{
    partial class mainForm
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
            this.gameName = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.insane = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameName.Location = new System.Drawing.Point(77, 90);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(370, 60);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Classic Snake";
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.LimeGreen;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(112, 200);
            this.easy.Margin = new System.Windows.Forms.Padding(10);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(300, 50);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.Click_easy);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.LimeGreen;
            this.medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.Location = new System.Drawing.Point(112, 270);
            this.medium.Margin = new System.Windows.Forms.Padding(10);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(300, 50);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.Click_medium);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.LimeGreen;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(112, 340);
            this.hard.Margin = new System.Windows.Forms.Padding(10);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(300, 50);
            this.hard.TabIndex = 3;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.Click_hard);
            // 
            // insane
            // 
            this.insane.BackColor = System.Drawing.Color.LimeGreen;
            this.insane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insane.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insane.Location = new System.Drawing.Point(112, 410);
            this.insane.Margin = new System.Windows.Forms.Padding(10);
            this.insane.Name = "insane";
            this.insane.Size = new System.Drawing.Size(300, 50);
            this.insane.TabIndex = 4;
            this.insane.Text = "Insane";
            this.insane.UseVisualStyleBackColor = false;
            this.insane.Click += new System.EventHandler(this.Click_insane);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(13, 13);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(96, 25);
            this.pointsLabel.TabIndex = 6;
            this.pointsLabel.Text = "Points: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.pointsLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 50);
            this.panel1.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(524, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insane);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.gameName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_mainForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button insane;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

