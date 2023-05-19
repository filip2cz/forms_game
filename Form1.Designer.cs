namespace forms_game
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::forms_game.Properties.Resources.Cumz4AC;
            this.player.Location = new System.Drawing.Point(350, 437);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 88);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::forms_game.Properties.Resources.bullet_hd_png_transparent_gun_shooting_bullet_png_1024_300x400;
            this.bullet.Location = new System.Drawing.Point(382, 335);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(34, 50);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::forms_game.Properties.Resources._158e7dea685f696236731c27cc6adb15;
            this.enemyThree.Location = new System.Drawing.Point(585, -100);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 80);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyThree.TabIndex = 2;
            this.enemyThree.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::forms_game.Properties.Resources._158e7dea685f696236731c27cc6adb15;
            this.enemyOne.Location = new System.Drawing.Point(115, -100);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 80);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyOne.TabIndex = 1;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::forms_game.Properties.Resources._158e7dea685f696236731c27cc6adb15;
            this.enemyTwo.Location = new System.Drawing.Point(350, -100);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 80);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyTwo.TabIndex = 0;
            this.enemyTwo.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.Location = new System.Drawing.Point(-1, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(801, 70);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.mainGameTimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.txtScore);
            this.Name = "Form1";
            this.Text = "Komárek a Konečný: videohra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gametimer;
    }
}

