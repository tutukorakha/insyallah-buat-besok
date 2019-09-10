namespace Insyallah_buat_besok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.media_track = new Bunifu.Framework.UI.BunifuTrackbar();
            this.stg_volume = new Bunifu.Framework.UI.BunifuTrackbar();
            this.btn_normal = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_maximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_backward = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_forward = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "メディアプレーヤー";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 80);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(951, 304);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // media_track
            // 
            this.media_track.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.media_track.BackColor = System.Drawing.Color.Transparent;
            this.media_track.BackgroudColor = System.Drawing.Color.LightGreen;
            this.media_track.BorderRadius = 0;
            this.media_track.IndicatorColor = System.Drawing.Color.ForestGreen;
            this.media_track.Location = new System.Drawing.Point(15, 390);
            this.media_track.MaximumValue = 100;
            this.media_track.Name = "media_track";
            this.media_track.Size = new System.Drawing.Size(948, 30);
            this.media_track.SliderRadius = 0;
            this.media_track.TabIndex = 13;
            this.media_track.Value = 0;
            this.media_track.ValueChanged += new System.EventHandler(this.media_track_ValueChanged);
            // 
            // stg_volume
            // 
            this.stg_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stg_volume.BackColor = System.Drawing.Color.Transparent;
            this.stg_volume.BackgroudColor = System.Drawing.Color.LightGreen;
            this.stg_volume.BorderRadius = 0;
            this.stg_volume.IndicatorColor = System.Drawing.Color.ForestGreen;
            this.stg_volume.Location = new System.Drawing.Point(620, 426);
            this.stg_volume.MaximumValue = 100;
            this.stg_volume.Name = "stg_volume";
            this.stg_volume.Size = new System.Drawing.Size(343, 30);
            this.stg_volume.SliderRadius = 0;
            this.stg_volume.TabIndex = 16;
            this.stg_volume.Value = 0;
            this.stg_volume.ValueChanged += new System.EventHandler(this.stg_volume_ValueChanged);
            // 
            // btn_normal
            // 
            this.btn_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_normal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_normal.Image = ((System.Drawing.Image)(resources.GetObject("btn_normal.Image")));
            this.btn_normal.ImageActive = null;
            this.btn_normal.Location = new System.Drawing.Point(831, 9);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(40, 40);
            this.btn_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_normal.TabIndex = 12;
            this.btn_normal.TabStop = false;
            this.btn_normal.Zoom = 10;
            this.btn_normal.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageActive = null;
            this.btn_minimize.Location = new System.Drawing.Point(785, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 11;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Zoom = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.ImageActive = null;
            this.btn_maximize.Location = new System.Drawing.Point(877, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(40, 40);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximize.TabIndex = 10;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Zoom = 10;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(923, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 9;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageActive = null;
            this.btn_stop.Location = new System.Drawing.Point(127, 426);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(49, 48);
            this.btn_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_stop.TabIndex = 7;
            this.btn_stop.TabStop = false;
            this.btn_stop.Zoom = 10;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.ImageActive = null;
            this.btn_pause.Location = new System.Drawing.Point(70, 426);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(49, 48);
            this.btn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pause.TabIndex = 6;
            this.btn_pause.TabStop = false;
            this.btn_pause.Zoom = 10;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.Location = new System.Drawing.Point(15, 426);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(49, 48);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 5;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_search
            // 
            this.btn_search.ActiveBorderThickness = 1;
            this.btn_search.ActiveCornerRadius = 20;
            this.btn_search.ActiveFillColor = System.Drawing.Color.GreenYellow;
            this.btn_search.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_search.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btn_search.BackColor = System.Drawing.Color.Black;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_search.IdleBorderThickness = 1;
            this.btn_search.IdleCornerRadius = 20;
            this.btn_search.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.btn_search.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_search.Location = new System.Drawing.Point(15, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(161, 34);
            this.btn_search.TabIndex = 2;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.ActiveBorderThickness = 1;
            this.btn_logout.ActiveCornerRadius = 20;
            this.btn_logout.ActiveFillColor = System.Drawing.Color.GreenYellow;
            this.btn_logout.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_logout.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Black;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.ButtonText = "Log Out";
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_logout.IdleBorderThickness = 1;
            this.btn_logout.IdleCornerRadius = 20;
            this.btn_logout.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.btn_logout.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_logout.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_logout.Location = new System.Drawing.Point(673, 15);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(103, 34);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_backward
            // 
            this.btn_backward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_backward.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backward.Image = ((System.Drawing.Image)(resources.GetObject("btn_backward.Image")));
            this.btn_backward.ImageActive = null;
            this.btn_backward.Location = new System.Drawing.Point(368, 426);
            this.btn_backward.Name = "btn_backward";
            this.btn_backward.Size = new System.Drawing.Size(49, 48);
            this.btn_backward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_backward.TabIndex = 18;
            this.btn_backward.TabStop = false;
            this.btn_backward.Zoom = 10;
            this.btn_backward.Click += new System.EventHandler(this.btn_backward_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_forward.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.ImageActive = null;
            this.btn_forward.Location = new System.Drawing.Point(509, 426);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(49, 48);
            this.btn_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_forward.TabIndex = 19;
            this.btn_forward.TabStop = false;
            this.btn_forward.Zoom = 10;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(975, 490);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_backward);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.stg_volume);
            this.Controls.Add(this.media_track);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_stop;
        private Bunifu.Framework.UI.BunifuImageButton btn_pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_play;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_search;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximize;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_normal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuTrackbar media_track;
        private Bunifu.Framework.UI.BunifuTrackbar stg_volume;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_logout;
        private Bunifu.Framework.UI.BunifuImageButton btn_backward;
        private Bunifu.Framework.UI.BunifuImageButton btn_forward;
    }
}

