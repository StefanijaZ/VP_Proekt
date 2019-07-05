namespace ProektVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Label();
            this.naslov1 = new System.Windows.Forms.Label();
            this.gameRules = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Label();
            this.naslov2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play.Location = new System.Drawing.Point(240, 279);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(107, 60);
            this.play.TabIndex = 0;
            this.play.Text = "PLAY";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // naslov1
            // 
            this.naslov1.AutoSize = true;
            this.naslov1.Font = new System.Drawing.Font("Snap ITC", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.naslov1.Location = new System.Drawing.Point(45, 9);
            this.naslov1.Name = "naslov1";
            this.naslov1.Size = new System.Drawing.Size(557, 108);
            this.naslov1.TabIndex = 1;
            this.naslov1.Text = "CHICKEN ";
            this.naslov1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameRules
            // 
            this.gameRules.AutoSize = true;
            this.gameRules.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameRules.Location = new System.Drawing.Point(240, 351);
            this.gameRules.Name = "gameRules";
            this.gameRules.Size = new System.Drawing.Size(248, 60);
            this.gameRules.TabIndex = 2;
            this.gameRules.Text = "GAME RULES";
            this.gameRules.Click += new System.EventHandler(this.gameRules_Click);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit.Location = new System.Drawing.Point(240, 428);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(104, 60);
            this.quit.TabIndex = 3;
            this.quit.Text = "QUIT";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // naslov2
            // 
            this.naslov2.AutoSize = true;
            this.naslov2.Font = new System.Drawing.Font("Snap ITC", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.naslov2.Location = new System.Drawing.Point(45, 124);
            this.naslov2.Name = "naslov2";
            this.naslov2.Size = new System.Drawing.Size(585, 108);
            this.naslov2.TabIndex = 4;
            this.naslov2.Text = "INVADERS";
            this.naslov2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProektVP.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.naslov2);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.gameRules);
            this.Controls.Add(this.naslov1);
            this.Controls.Add(this.play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chicken Invaders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Label naslov1;
        private System.Windows.Forms.Label gameRules;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Label naslov2;
    }
}

