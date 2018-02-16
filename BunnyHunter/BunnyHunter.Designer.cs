namespace BunnyHunter
{
    partial class BunnyHunter
    {
        #region Windows Form Designer generated code
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BunnyHunter));
            this.timerGameLoop = new System.Windows.Forms.Timer(this.components);
            this.backgroundSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.gunshotSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.startSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.stopSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.resetSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.quitSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.nextPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.standbySound = new AxWMPLib.AxWindowsMediaPlayer();
            this.fly1Sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunnyHitSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.fly2Sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.fly3Sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunnySound = new AxWMPLib.AxWindowsMediaPlayer();
            this.wildDucksSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.eagleSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.gameOverSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.standbyBackground = new System.Windows.Forms.PictureBox();
            this.gameOverBackground = new System.Windows.Forms.PictureBox();
            this.demo1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunshotSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbySound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly1Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyHitSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly2Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly3Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildDucksSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbyBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGameLoop
            // 
            this.timerGameLoop.Tick += new System.EventHandler(this.timerGameLoop_Tick);
            // 
            // backgroundSound
            // 
            this.backgroundSound.Enabled = true;
            this.backgroundSound.Location = new System.Drawing.Point(97, 56);
            this.backgroundSound.Name = "backgroundSound";
            this.backgroundSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("backgroundSound.OcxState")));
            this.backgroundSound.Size = new System.Drawing.Size(11, 10);
            this.backgroundSound.TabIndex = 3;
            this.backgroundSound.Visible = false;
            // 
            // gunshotSound
            // 
            this.gunshotSound.Enabled = true;
            this.gunshotSound.Location = new System.Drawing.Point(156, 56);
            this.gunshotSound.Name = "gunshotSound";
            this.gunshotSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gunshotSound.OcxState")));
            this.gunshotSound.Size = new System.Drawing.Size(11, 10);
            this.gunshotSound.TabIndex = 4;
            this.gunshotSound.Visible = false;
            // 
            // startSound
            // 
            this.startSound.Enabled = true;
            this.startSound.Location = new System.Drawing.Point(71, 13);
            this.startSound.Name = "startSound";
            this.startSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("startSound.OcxState")));
            this.startSound.Size = new System.Drawing.Size(10, 10);
            this.startSound.TabIndex = 5;
            this.startSound.Visible = false;
            // 
            // stopSound
            // 
            this.stopSound.Enabled = true;
            this.stopSound.Location = new System.Drawing.Point(87, 13);
            this.stopSound.Name = "stopSound";
            this.stopSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("stopSound.OcxState")));
            this.stopSound.Size = new System.Drawing.Size(10, 10);
            this.stopSound.TabIndex = 6;
            this.stopSound.Visible = false;
            // 
            // resetSound
            // 
            this.resetSound.Enabled = true;
            this.resetSound.Location = new System.Drawing.Point(103, 13);
            this.resetSound.Name = "resetSound";
            this.resetSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("resetSound.OcxState")));
            this.resetSound.Size = new System.Drawing.Size(10, 10);
            this.resetSound.TabIndex = 7;
            this.resetSound.Visible = false;
            // 
            // quitSound
            // 
            this.quitSound.Enabled = true;
            this.quitSound.Location = new System.Drawing.Point(119, 13);
            this.quitSound.Name = "quitSound";
            this.quitSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("quitSound.OcxState")));
            this.quitSound.Size = new System.Drawing.Size(10, 10);
            this.quitSound.TabIndex = 8;
            this.quitSound.Visible = false;
            // 
            // nextPlay
            // 
            this.nextPlay.Enabled = true;
            this.nextPlay.Location = new System.Drawing.Point(56, 13);
            this.nextPlay.Name = "nextPlay";
            this.nextPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("nextPlay.OcxState")));
            this.nextPlay.Size = new System.Drawing.Size(10, 10);
            this.nextPlay.TabIndex = 10;
            this.nextPlay.Visible = false;
            // 
            // standbySound
            // 
            this.standbySound.Enabled = true;
            this.standbySound.Location = new System.Drawing.Point(156, 40);
            this.standbySound.Name = "standbySound";
            this.standbySound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("standbySound.OcxState")));
            this.standbySound.Size = new System.Drawing.Size(10, 10);
            this.standbySound.TabIndex = 15;
            this.standbySound.Visible = false;
            // 
            // fly1Sound
            // 
            this.fly1Sound.Enabled = true;
            this.fly1Sound.Location = new System.Drawing.Point(74, 86);
            this.fly1Sound.Name = "fly1Sound";
            this.fly1Sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fly1Sound.OcxState")));
            this.fly1Sound.Size = new System.Drawing.Size(10, 10);
            this.fly1Sound.TabIndex = 17;
            this.fly1Sound.Visible = false;
            // 
            // bunnyHitSound
            // 
            this.bunnyHitSound.Enabled = true;
            this.bunnyHitSound.Location = new System.Drawing.Point(40, 40);
            this.bunnyHitSound.Name = "bunnyHitSound";
            this.bunnyHitSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bunnyHitSound.OcxState")));
            this.bunnyHitSound.Size = new System.Drawing.Size(10, 10);
            this.bunnyHitSound.TabIndex = 18;
            this.bunnyHitSound.Visible = false;
            // 
            // fly2Sound
            // 
            this.fly2Sound.Enabled = true;
            this.fly2Sound.Location = new System.Drawing.Point(93, 86);
            this.fly2Sound.Name = "fly2Sound";
            this.fly2Sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fly2Sound.OcxState")));
            this.fly2Sound.Size = new System.Drawing.Size(10, 10);
            this.fly2Sound.TabIndex = 20;
            this.fly2Sound.Visible = false;
            // 
            // fly3Sound
            // 
            this.fly3Sound.Enabled = true;
            this.fly3Sound.Location = new System.Drawing.Point(115, 86);
            this.fly3Sound.Name = "fly3Sound";
            this.fly3Sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fly3Sound.OcxState")));
            this.fly3Sound.Size = new System.Drawing.Size(10, 10);
            this.fly3Sound.TabIndex = 21;
            this.fly3Sound.Visible = false;
            // 
            // bunnySound
            // 
            this.bunnySound.Enabled = true;
            this.bunnySound.Location = new System.Drawing.Point(40, 56);
            this.bunnySound.Name = "bunnySound";
            this.bunnySound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bunnySound.OcxState")));
            this.bunnySound.Size = new System.Drawing.Size(10, 10);
            this.bunnySound.TabIndex = 23;
            this.bunnySound.Visible = false;
            // 
            // wildDucksSound
            // 
            this.wildDucksSound.Enabled = true;
            this.wildDucksSound.Location = new System.Drawing.Point(97, 40);
            this.wildDucksSound.Name = "wildDucksSound";
            this.wildDucksSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wildDucksSound.OcxState")));
            this.wildDucksSound.Size = new System.Drawing.Size(10, 10);
            this.wildDucksSound.TabIndex = 26;
            this.wildDucksSound.Visible = false;
            // 
            // eagleSound
            // 
            this.eagleSound.Enabled = true;
            this.eagleSound.Location = new System.Drawing.Point(97, 56);
            this.eagleSound.Name = "eagleSound";
            this.eagleSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eagleSound.OcxState")));
            this.eagleSound.Size = new System.Drawing.Size(10, 10);
            this.eagleSound.TabIndex = 27;
            this.eagleSound.Visible = false;
            // 
            // gameOverSound
            // 
            this.gameOverSound.Enabled = true;
            this.gameOverSound.Location = new System.Drawing.Point(136, 13);
            this.gameOverSound.Name = "gameOverSound";
            this.gameOverSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gameOverSound.OcxState")));
            this.gameOverSound.Size = new System.Drawing.Size(10, 10);
            this.gameOverSound.TabIndex = 28;
            this.gameOverSound.Visible = false;
            // 
            // standbyBackground
            // 
            this.standbyBackground.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.standbyBackground.BackColor = System.Drawing.Color.Transparent;
            this.standbyBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.standbyBackground.Image = ((System.Drawing.Image)(resources.GetObject("standbyBackground.Image")));
            this.standbyBackground.Location = new System.Drawing.Point(1, 0);
            this.standbyBackground.Name = "standbyBackground";
            this.standbyBackground.Size = new System.Drawing.Size(612, 675);
            this.standbyBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.standbyBackground.TabIndex = 29;
            this.standbyBackground.TabStop = false;
            this.standbyBackground.Visible = false;
            this.standbyBackground.MouseClick += new System.Windows.Forms.MouseEventHandler(this.standbyBackground_MouseClick);
            this.standbyBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.standbyBackground_MouseMove);
            // 
            // gameOverBackground
            // 
            this.gameOverBackground.BackColor = System.Drawing.Color.Transparent;
            this.gameOverBackground.Image = ((System.Drawing.Image)(resources.GetObject("gameOverBackground.Image")));
            this.gameOverBackground.Location = new System.Drawing.Point(1, 0);
            this.gameOverBackground.Name = "gameOverBackground";
            this.gameOverBackground.Size = new System.Drawing.Size(612, 675);
            this.gameOverBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOverBackground.TabIndex = 30;
            this.gameOverBackground.TabStop = false;
            this.gameOverBackground.Visible = false;
            this.gameOverBackground.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameOverBackground_MouseClick);
            this.gameOverBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gameOverBackground_MouseMove);
            // 
            // demo1
            // 
            this.demo1.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.demo1.BackColor = System.Drawing.Color.Transparent;
            this.demo1.Image = ((System.Drawing.Image)(resources.GetObject("demo1.Image")));
            this.demo1.Location = new System.Drawing.Point(435, 215);
            this.demo1.Name = "demo1";
            this.demo1.Size = new System.Drawing.Size(160, 110);
            this.demo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.demo1.TabIndex = 32;
            this.demo1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.CadetBlue;
            this.progressBar1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBar1.Location = new System.Drawing.Point(516, 65);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(81, 7);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Value = 20;
            this.progressBar1.Visible = false;
            // 
            // BunnyHunter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 676);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.demo1);
            this.Controls.Add(this.gameOverBackground);
            this.Controls.Add(this.standbyBackground);
            this.Controls.Add(this.gameOverSound);
            this.Controls.Add(this.eagleSound);
            this.Controls.Add(this.wildDucksSound);
            this.Controls.Add(this.bunnySound);
            this.Controls.Add(this.fly3Sound);
            this.Controls.Add(this.fly2Sound);
            this.Controls.Add(this.bunnyHitSound);
            this.Controls.Add(this.fly1Sound);
            this.Controls.Add(this.standbySound);
            this.Controls.Add(this.nextPlay);
            this.Controls.Add(this.quitSound);
            this.Controls.Add(this.resetSound);
            this.Controls.Add(this.stopSound);
            this.Controls.Add(this.startSound);
            this.Controls.Add(this.gunshotSound);
            this.Controls.Add(this.backgroundSound);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BunnyHunter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bunny Hunter";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BunnyHunter_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BunnyHunter_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunshotSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbySound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly1Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnyHitSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly2Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fly3Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildDucksSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbyBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGameLoop;
        private AxWMPLib.AxWindowsMediaPlayer backgroundSound;
        private AxWMPLib.AxWindowsMediaPlayer gunshotSound;
        private AxWMPLib.AxWindowsMediaPlayer startSound;
        private AxWMPLib.AxWindowsMediaPlayer stopSound;
        private AxWMPLib.AxWindowsMediaPlayer resetSound;
        private AxWMPLib.AxWindowsMediaPlayer quitSound;
        private AxWMPLib.AxWindowsMediaPlayer nextPlay;
        private AxWMPLib.AxWindowsMediaPlayer standbySound;
        private AxWMPLib.AxWindowsMediaPlayer fly1Sound;
        private AxWMPLib.AxWindowsMediaPlayer bunnyHitSound;
        private AxWMPLib.AxWindowsMediaPlayer fly2Sound;
        private AxWMPLib.AxWindowsMediaPlayer fly3Sound;
        private AxWMPLib.AxWindowsMediaPlayer bunnySound;
        private AxWMPLib.AxWindowsMediaPlayer wildDucksSound;
        private AxWMPLib.AxWindowsMediaPlayer eagleSound;
        private AxWMPLib.AxWindowsMediaPlayer gameOverSound;
        private System.Windows.Forms.PictureBox standbyBackground;
        private System.Windows.Forms.PictureBox gameOverBackground;
        private System.Windows.Forms.PictureBox demo1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

