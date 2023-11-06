namespace music_player
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameSong = new System.Windows.Forms.TextBox();
            this.textBoxNameAlbom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnReturnSongs = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInfoSongs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя песни";
            // 
            // textBoxNameSong
            // 
            this.textBoxNameSong.Location = new System.Drawing.Point(31, 52);
            this.textBoxNameSong.Name = "textBoxNameSong";
            this.textBoxNameSong.Size = new System.Drawing.Size(209, 20);
            this.textBoxNameSong.TabIndex = 1;
            // 
            // textBoxNameAlbom
            // 
            this.textBoxNameAlbom.Location = new System.Drawing.Point(31, 120);
            this.textBoxNameAlbom.Name = "textBoxNameAlbom";
            this.textBoxNameAlbom.Size = new System.Drawing.Size(209, 20);
            this.textBoxNameAlbom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(79, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя альбома";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(32, 75);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(28, 20);
            this.btnAddSong.TabIndex = 4;
            this.btnAddSong.Text = "+";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(64, 75);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(28, 20);
            this.btnDeleteSong.TabIndex = 5;
            this.btnDeleteSong.Text = "--";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnReturnSongs
            // 
            this.btnReturnSongs.Location = new System.Drawing.Point(96, 75);
            this.btnReturnSongs.Name = "btnReturnSongs";
            this.btnReturnSongs.Size = new System.Drawing.Size(28, 20);
            this.btnReturnSongs.TabIndex = 6;
            this.btnReturnSongs.Text = "↺";
            this.btnReturnSongs.UseVisualStyleBackColor = true;
            this.btnReturnSongs.Click += new System.EventHandler(this.btnReturnSongs_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(130, 75);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(28, 20);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "<|";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnInfoSongs
            // 
            this.btnInfoSongs.Location = new System.Drawing.Point(164, 75);
            this.btnInfoSongs.Name = "btnInfoSongs";
            this.btnInfoSongs.Size = new System.Drawing.Size(28, 20);
            this.btnInfoSongs.TabIndex = 8;
            this.btnInfoSongs.Text = "🔍︎";
            this.btnInfoSongs.UseVisualStyleBackColor = true;
            this.btnInfoSongs.Click += new System.EventHandler(this.btnInfoSongs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(275, 176);
            this.Controls.Add(this.btnInfoSongs);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnReturnSongs);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.textBoxNameAlbom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameSong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Music Player";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnInfoSongs;

        private System.Windows.Forms.Button btnPlay;

        private System.Windows.Forms.Button btnReturnSongs;

        private System.Windows.Forms.Button btnDeleteSong;

        private System.Windows.Forms.Button btnAddSong;

        private System.Windows.Forms.TextBox textBoxNameSong;
        private System.Windows.Forms.TextBox textBoxNameAlbom;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}