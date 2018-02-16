//#define My_Debug
using BunnyHunter.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BunnyHunter
{
    public partial class BunnyHunter : Form
    {
        const int maxRandomMoveFrame = 7;
        const int maxSplatTime = 3;
        const int maxFlyFrames = 24;
        const int maxDucksFrames = 5;
        const int maxUpdateFrames = 12;
        const int maxLevelsFrames = 9;
        int[] pictureBoxesPosition = new int[6] { 0, 0, 0, 0, 435, 215 };
        int[] frames = new int[4] { 1, 1, 1, 1 };
        int randomMoveFrame = 0;
        int moveFrame = 0;
        int splatBunny1Time = 0;
        int splatFly1Time = 0;
        int splatFly2Time = 0;
        int splatFly3Time = 0;
        int hits = 0;
        int misses = 0;
        int totalScore = 10;
        int totalInsects = 0;
        double averageHits = 0.0;
        bool isActivePlayButton = false;
        bool isActiveStopButton = false;
        bool isActiveResetButton = false;
        bool isActiveQuitButton = false;
        bool isLevel1 = true;
        bool isLevel2 = false;
        bool isLevel3 = false;
        bool isBonus = false;
        bool isSound = true;
        bool isBunny1Hit = false;
        bool isJump = false;
        bool isFly1Hit = false;
        bool isFly2Hit = false;
        bool isFly3Hit = false;
        bool isFly1 = false;
        bool isFly2 = false;
        bool isFly3 = false;
        bool canBuzz1 = true;
        bool canBuzz2 = true;
        bool canBuzz3 = true;
        bool isPlayed = false;
        bool isOver = false;
        bool canPlay = true;
        CLevel levels;
        CLifeBar lifeBar;
        CBunny bunny;
        CFly fly1;
        CFly fly2;
        CFly fly3;
        CSign sign;
        CTree tree;
        CMusicOn music;
        CDucks ducks;
        CSplat splat;
        CScoreFrame score;
        CInfo info;
        Random nextMove = new Random();
        Bitmap cursor;
#if My_Debug
        int cursX = 0;
        int cursY = 0;
#endif

        public BunnyHunter()
        {
            levels = new CLevel();
            lifeBar = new CLifeBar() { Left = 430, Top = 30 };
            bunny = new CBunny(Resources.Bunny, 60, 60);
            sign = new CSign() { Left = 320, Top = 80 };
            tree = new CTree() { Left = 85, Top = 83 };
            music = new CMusicOn() { Left = 220, Top = 580 };
            ducks = new CDucks() { Left = 50, Top = 5};
            fly1 = new CFly();
            fly2 = new CFly();
            fly3 = new CFly();
            splat = new CSplat();
            score = new CScoreFrame();
            info = new CInfo() { Left = 440, Top = 150 };

            InitializeComponent();
            PlayBackgroundSound();
            InitializePictureBoxes(pictureBoxesPosition);
            SetCursor(Resources.Target_1);
        }

        private void SetCursor(Bitmap  resource)
        {
            cursor = new Bitmap(resource);
            this.Cursor = CustomCursor.CreateCursor(cursor, cursor.Height / 2, cursor.Width / 2);
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            OnBunnyHit(bunny, ref splatBunny1Time);
            OnFlyHit(fly1, fly1Sound, ref splatFly1Time, ref isFly1, ref isFly1Hit, ref canBuzz1);
            OnFlyHit(fly2, fly2Sound, ref splatFly2Time, ref isFly2, ref isFly2Hit, ref canBuzz2);
            OnFlyHit(fly3, fly3Sound, ref splatFly3Time, ref isFly3, ref isFly3Hit, ref canBuzz3);
            FlyByTotalScore(ref isFly1, ref isFly2, ref isFly3);
            GameUpdate(ref randomMoveFrame, ref moveFrame);
            FrameByFrame(ref frames);
            GameOver();

            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics dc = e.Graphics;

            if (isPlayed)
            {
                
                ducks.DrawImage(dc);
                lifeBar.DrawImage(dc);
                sign.ChangeResource(Resources.Sign_2);
                sign.DrawImage(dc);
                score.DrawImage(dc);
                info.DrawImage(dc);
                tree.DrawImage(dc);
                if (!isJump)
                {

                    bunny.ChangeResource(Resources.Bunny, 90, 75);
                    bunny.Left = 100;
                    bunny.Top = 400;
                    isJump = true;
                }

                ShowBunny(bunny, dc);
                ShowFly(fly1, dc, isFly1Hit, isFly1);
                ShowFly(fly2, dc, isFly2Hit, isFly2);
                ShowFly(fly3, dc, isFly3Hit, isFly3);
            }
            else
            {
                bunny.Left = 20;
                bunny.Top = 185;
                isJump = false;

                sign.ChangeResource(Resources.Sign_1);
                bunny.ChangeResource(Resources.Bunny, 60, 50);

                sign.DrawImage(dc);
                bunny.DrawImage(dc);
                tree.DrawImage(dc);
            }
            music.DrawImage(dc);
            ShowText(dc);
        }

        private void InitializePictureBoxes(int[] coordinates)
        {
            standbyBackground.Left = coordinates[0];
            standbyBackground.Top = coordinates[1];
            gameOverBackground.Left = coordinates[2];
            gameOverBackground.Top = coordinates[3];
            demo1.Left = coordinates[4];
            demo1.Top = coordinates[5];
        }

        private void LevelByTotalScore()
        {
            if (totalScore == 10)
            {
                isLevel1 = true;
            }

            if (totalScore == 300 && !isBonus)
            {
                isBonus = true;
            }

            if (totalScore == 300 && !isBonus && !isLevel2)
            {
                isLevel2 = true;
            }

            if (totalScore == 600 && !isBonus)
            {
                isBonus = true;
            }
        }
        private void ShowText(Graphics g)
        {
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _fontTitleBig = new Font("Elephant", 16, FontStyle.Regular);
            Font _fontTitleSmall = new Font("Elephant", 10, FontStyle.Regular);
            Font _fontText = new Font("Elephant", 13, FontStyle.Regular);

            if (isPlayed)
            {
                TextRenderer.DrawText(g, "Stop", _fontTitleBig,
                new Rectangle(493, 185, 560, 210), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Reset", _fontTitleBig,
                new Rectangle(485, 215, 530, 230), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Quit", _fontTitleBig,
                new Rectangle(493, 245, 530, 260), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Results", _fontTitleBig,
                new Rectangle(50, 10, 160, 60), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Hits:  " + hits, _fontText,
                new Rectangle(30, 50, 150, 70), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Misses: " + misses, _fontText,
                new Rectangle(30, 70, 150, 90), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Score: " + totalScore, _fontText,
                new Rectangle(30, 90, 150, 110), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Average: " + (int)averageHits + " %", _fontText,
                new Rectangle(30, 113, 170, 130), SystemColors.GradientInactiveCaption, flags);
            }
            else
            {
                TextRenderer.DrawText(g, "Start", _fontTitleBig,
                new Rectangle(485, 160, 530, 150), SystemColors.GradientInactiveCaption, flags);
                TextRenderer.DrawText(g, "Quit", _fontTitleBig,
                new Rectangle(490, 195, 530, 230), SystemColors.GradientInactiveCaption, flags);
            }

            TextRenderer.DrawText(g, "BunnyHunter", _fontTitleSmall,
            new Rectangle(475, 120, 575, 130), SystemColors.GradientInactiveCaption, flags);

#if My_Debug
            Font _fontTest = new Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(g, "X=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(), _fontTest, 
            new Rectangle(0,0,120,20), SystemColors.ControlLight, flags);
#endif
        }


        private void TextByScore(Graphics g, string message, Font font, TextFormatFlags flags)
        {

            TextRenderer.DrawText(g, message, font, new Rectangle(475, 120, 575, 130), SystemColors.GradientInactiveCaption, flags);
        }

        private void BunnyHunter_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >= 465) && (e.X <= 560) && (e.Y >= 165) && (e.Y <= 185) && !isActivePlayButton && !isPlayed)
            {
                PlayButtonHoverSound(startSound);
                isActivePlayButton = true;
            }

            if (((e.X >= 480) && (e.X <= 550) && (e.Y >= 200) && (e.Y <= 220) && !isActiveQuitButton && !isPlayed)
                    || ((e.X >= 475) && (e.X <= 565) && (e.Y >= 250) && (e.Y <= 270) && !isActiveQuitButton && isPlayed))
            {
                PlayButtonHoverSound(quitSound);
                isActiveQuitButton = true;
            }

            if ((e.X >= 475) && (e.X <= 565) && (e.Y >= 190) && (e.Y <= 210) && !isActiveStopButton && isPlayed)
            {
                PlayButtonHoverSound(stopSound);
                isActiveStopButton = true;
            }

            if ((e.X >= 480) && (e.X <= 560) && (e.Y >= 220) && (e.Y <= 240) && !isActiveResetButton && isPlayed)
            {
                PlayButtonHoverSound(resetSound);
                isActiveResetButton = true;
            }

            if ((e.X <= 465) || (e.X >= 560) || (e.Y <= 165) || (e.Y >= 185) && isActivePlayButton && !isPlayed)
            {
                isActivePlayButton = false;
            }

            if (((e.X <= 480) || (e.X >= 550) || (e.Y <= 200) || (e.Y >= 220) && isActiveQuitButton && !isPlayed)
               && ((e.X <= 475) || (e.X >= 565) || (e.Y <= 250) || (e.Y >= 270) && isActiveQuitButton && !isPlayed))
            {
                isActiveQuitButton = false;
            }

            if ((e.X <= 475) || (e.X >= 565) || (e.Y <= 190) || (e.Y >= 210) && isActiveStopButton && isPlayed)
            {
                isActiveStopButton = false;
            }

            if ((e.X <= 480) || (e.X >= 560) || (e.Y <= 220) || (e.Y >= 240) && isActiveResetButton && isPlayed)
            {
                isActiveResetButton = false;
            }

#if My_Debug
            cursX = e.X;
            cursY = e.Y;
#endif
        }

        private void BunnyHunter_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.X >= 465) && (e.X <= 560) && (e.Y >= 165) && (e.Y <= 185) && !isPlayed)
            {
                isPlayed = true;
                demo1.Visible = false;
                progressBar1.Visible = true;

                timerGameLoop.Start();
                backgroundSound.Ctlcontrols.stop();
                PlayButtonClickSound(startSound);
                PlayRandomSound();
            }
            else if ((e.X >= 475) && (e.X <= 565) && (e.Y >= 190) && (e.Y <= 215) && isPlayed)
            {
                progressBar1.Visible = false;
                standbyBackground.Visible = true;
                isPlayed = false;

                timerGameLoop.Stop();
                nextPlay.Ctlcontrols.pause();
                fly1Sound.Ctlcontrols.pause();
                fly2Sound.Ctlcontrols.pause();
                fly3Sound.Ctlcontrols.pause();
                PlayButtonClickSound(stopSound);
                PlayStandBySound();
            }
            else if ((e.X >= 480) && (e.X <= 560) && (e.Y >= 220) && (e.Y <= 240) && isPlayed)
            {
                hits = 0;
                misses = 0;
                totalInsects = 0;
                totalScore = 10;
                averageHits = 0;
                progressBar1.Value = progressBar1.Maximum;
                isFly1 = false;
                isFly2 = false;
                isFly3 = false;

                fly1Sound.Ctlcontrols.stop();
                fly2Sound.Ctlcontrols.stop();
                fly3Sound.Ctlcontrols.stop();
                timerGameLoop.Start();
                PlayButtonClickSound(resetSound);
                PlayRandomSound();
            }
            else if (((e.X >= 480) && (e.X <= 550) && (e.Y >= 200) && (e.Y <= 220) && !isPlayed) || ((e.X >= 475) && (e.X <= 565) && (e.Y >= 250) && (e.Y <= 270) && isPlayed))
            {
                this.Close();
            }
            else if ((e.X >= 270) && (e.X <= 290) && (e.Y >= 620) && (e.Y <= 640))
            {
                isSound = true;

                if (isPlayed)
                {
                    nextPlay.settings.mute = false;
                    fly1Sound.settings.mute = false;
                    fly2Sound.settings.mute = false;
                    fly3Sound.settings.mute = false;
                }
                else backgroundSound.settings.mute = false;
            }
            else if (e.X >= 305 && e.X <= 340 && e.Y >= 620 && e.Y <= 640)
            {
                isSound = false;

                if (isPlayed)
                {

                    nextPlay.settings.mute = true;
                    fly1Sound.settings.mute = true;
                    fly2Sound.settings.mute = true;
                    fly3Sound.settings.mute = true;
                }
                else
                {
                    backgroundSound.settings.mute = true;
                }
            }
            else
            {
                PlayFireGunSound();
                HitTheBunny(e);

                if (isFly1)
                {
                    HitTheFly(e, fly1, fly1Sound, ref isFly1Hit);
                }

                if (isFly2)
                {
                    HitTheFly(e, fly2, fly2Sound, ref isFly2Hit);
                }

                if (isFly3)
                {
                    HitTheFly(e, fly3, fly3Sound, ref isFly3Hit);
                }
            }
        }

        private void PlayBackgroundSound()
        {
            backgroundSound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\Background.wav";

            backgroundSound.settings.setMode("loop", true);

            if (!isSound)
            {
                backgroundSound.settings.mute = true;
            }
        }
        private void PlayRandomSound()
        {
            Random choose = new Random();
            int next = choose.Next(1, 9);
            nextPlay.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\PlayBackground " + next + ".wav";

            nextPlay.settings.setMode("loop", true);

            if (!isSound)
            {
                nextPlay.settings.mute = true;
            }
        }

        private void PlayFireGunSound()
        {
            if (isSound && isPlayed && totalScore >= 10)
            {
                gunshotSound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\ButtonClickSound.wav";

                gunshotSound.Ctlcontrols.play();
            }
        }

        private void PlayBunnySound()
        {
            if (isSound)
            {
                bunnySound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\BunnySound.wav";

                bunnySound.Ctlcontrols.play();
            }
        }

        private void PlayBunnyHitSound()
        {
            if (isSound)
            {
                bunnyHitSound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\BunnyHitSound.wav";

                bunnyHitSound.Ctlcontrols.play();
            }
        }

        private void PlayFlySound(AxWMPLib.AxWindowsMediaPlayer fly)
        {

            fly.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\FlySound.wav";

            fly.settings.setMode("loop", true);

            if (!isSound)
            {
                fly.settings.mute = true;
            }
        }

        private void PlayFlyHitSound(AxWMPLib.AxWindowsMediaPlayer fly)
        {
            if (isSound)
            {
                fly.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\FlyHitSound.wav";

                fly.settings.setMode("loop", false);
            }
        }

        private void PlayButtonHoverSound(AxWMPLib.AxWindowsMediaPlayer button)
        {
            if (isSound)
            {
                button.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\ButtonHoverSound.wav";

                button.Ctlcontrols.play();
            }
        }

        private void PlayButtonClickSound(AxWMPLib.AxWindowsMediaPlayer button)
        {
            if (isSound)
            {
                button.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\ButtonClickSound.wav";

                button.Ctlcontrols.play();
            }
        }

        private void PlayStandBySound()
        {
            if (isSound)
            {
                standbySound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\StandbySound.wav";

                standbySound.settings.setMode("loop", true);
            }
        }

        private void PlayGameOverSound()
        {
            if (isSound)
            {
                gameOverSound.URL = @"D:\Limbaje de programare - editare - design\C#\Aplicatii\Hunter\BunnyHunter\Resources\Sounds\GameOverSound.wav";

                gameOverSound.Ctlcontrols.play();
            }
        }

        private void BunnyUpdate()
        {
            PlayBunnySound();

            int xHotSpot = nextMove.Next(Resources.Bunny.Width, this.Width - Resources.Bunny.Width - 10);

            if ((xHotSpot <= 120) || (xHotSpot > 430))
            {
                int YHotSpot = nextMove.Next(305, 480);
                bunny.Update(xHotSpot, YHotSpot);
            }
            else if ((xHotSpot > 120) && (xHotSpot <= 380))
            {
                int yHotSpot = nextMove.Next(370, 450);
                bunny.Update(xHotSpot, yHotSpot);
            }
            else if ((xHotSpot > 380) && (xHotSpot <= 430))
            {
                int yHotSpot = nextMove.Next(285, 460);
                bunny.Update(xHotSpot, yHotSpot);
            }
        }

        private void HitTheBunny(MouseEventArgs e)
        {
            if (bunny.Hit(e.X, e.Y))
            {
                hits++;
                isBunny1Hit = true;
                splat.Left = bunny.Left - Resources.BloodSplat.Width / 3;
                splat.Top = bunny.Top - Resources.BloodSplat.Height / 3;

                PlayBunnyHitSound();
            }
            else
            {
                misses++;
                progressBar1.Value --;
            }

            totalScore = 10 + hits * 5 + totalInsects * 10;
            averageHits = (double)hits / (hits + misses) * 100;
        }

        private void ShowBunny(CBunny bunny, Graphics g)
        {
            if (isBunny1Hit)
            {
                splat.DrawImage(g);
            }
            else if (isPlayed)
            {
                bunny.DrawImage(g);
            }
        }

        private void ShowFly(CFly fly, Graphics g, bool isFlyHit, bool isFly)
        {
            if (isFlyHit)
            {
                splat.DrawImage(g);
            }
            else if (isFly && isPlayed)
            {
                fly.DrawImage(g);
            }
        }

        private void OnBunnyHit(CBunny bunny, ref int splatBunnyTime)
        {
            if (isBunny1Hit)
            {
                if (splatBunnyTime >= maxSplatTime)
                {
                    isBunny1Hit = false;
                    splatBunnyTime = 0;
                    BunnyUpdate();
                }
                splatBunnyTime++;
            }
        }

        private void FrameByFrame(ref int[] frames)
        {
            if (frames[0] <= maxFlyFrames)
            {
                fly1.Animated(frames[0]);
                fly2.Animated(frames[0]);
                fly3.Animated(frames[0]);
                frames[0]++;
            }
            else
            {
                frames[0] = 1;
            }

            if (frames[1] <= maxDucksFrames)
            {
                ducks.Animated(frames[1]);
                frames[1]++;
            }
            else
            {
                frames[1] = 1;
            }

            if (frames[2] <= maxUpdateFrames)
            {
                info.Animated(frames[2]);
                frames[2]++;
            }
            else
            {
                frames[2] = 1;
            }

            if (frames[3] <= maxLevelsFrames)
            {
                levels.Animated(frames[2], ref isLevel1, ref isLevel2, ref isLevel3, ref isBonus);
                frames[3]++;
            }
            else
            {
                frames[3] = 1;
            }
        }

        private void DucksUpdate()
        {
            ducks.Left += 3;

            if (ducks.Left == 620)
            {
                ducks.Left = 50;
            }
        }
        private void FlyUpdate(CFly fly, AxWMPLib.AxWindowsMediaPlayer flySound, bool isFly, ref bool canBuzz)
        {
            if (isFly && canBuzz)
            {
                PlayFlySound(flySound);
                canBuzz = false;
            }

            int xHotSpot = nextMove.Next(Resources.Fly_1.Width, this.Width - 10 - Resources.Fly_1.Width);

            if (xHotSpot <= 180)
            {
                int YHotSpot = nextMove.Next(140, 340);
                fly.Update(xHotSpot, YHotSpot);
            }
            else if ((xHotSpot > 180) && (xHotSpot <= 415))
            {
                int yHotSpot = nextMove.Next(90, 340);
                fly.Update(xHotSpot, yHotSpot);
            }
            else
            {
                int yHotSpot = nextMove.Next(260, 340);
                fly.Update(xHotSpot, yHotSpot);
            }
        }

        private void HitTheFly(MouseEventArgs e, CFly fly, AxWMPLib.AxWindowsMediaPlayer flySound, ref bool isFlyHit)
        {
            if (fly.Hit(e.X, e.Y))
            {
                totalInsects++;
                hits++;
                isFlyHit = true;
                splat.Left = fly.Left - Resources.BloodSplat.Width / 3;
                splat.Top = fly.Top - Resources.BloodSplat.Height / 3;
                PlayFlyHitSound(flySound);
            }

            totalScore = 10 + hits * 5 + totalInsects * 10;
            averageHits = (double)hits / (hits + misses) * 100;
        }



        private void OnFlyHit(CFly fly, AxWMPLib.AxWindowsMediaPlayer flySound, ref int splatFlyTime, ref bool isFly, ref bool isFlyHit, ref bool canBuzz)
        {
            if (isFlyHit)
            {
                canBuzz = true;
                isFly = false;
                if (splatFlyTime >= maxSplatTime)
                {
                    isFlyHit = false;
                    splatFlyTime = 0;
                    FlyUpdate(fly, flySound, isFly, ref canBuzz);
                }
                splatFlyTime++;
            }
        }

        private void FlyByTotalScore(ref bool isFly1, ref bool isFly2, ref bool isFly3)
        {
            if (totalScore != 0)
            {
                if ((totalScore % 25 == 0) && ((totalScore / 25) % 2 != 0))
                {
                    isFly1 = true;
                }

                else if ((totalScore % 50 == 0) && ((totalScore / 50) % 2 != 0))
                {
                    isFly1 = true;
                    isFly2 = true;
                }
                else if (totalScore % 100 == 0)
                {
                    isFly1 = true;
                    isFly2 = true;
                    isFly3 = true;
                }
            }

        }

        private void GameUpdate(ref int randomMoveFrame, ref int moveFrame)
        {

            if (randomMoveFrame >= maxRandomMoveFrame)
            {
                BunnyUpdate();
                FlyUpdate(fly1, fly1Sound, isFly1, ref canBuzz1);
                FlyUpdate(fly2, fly2Sound, isFly2, ref canBuzz2);
                FlyUpdate(fly3, fly3Sound, isFly3, ref canBuzz3);
                randomMoveFrame = 0;
            }
            randomMoveFrame++;

            DucksUpdate();

        }

        private void standbyBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >= 250) && (e.X <= 370) && (e.Y >= 350) && (e.Y <= 380) && !isActivePlayButton)
            {
                PlayButtonHoverSound(startSound);
                isActivePlayButton = true;
            }

            if ((e.X >= 270) && (e.X <= 360) && (e.Y >= 390) && (e.Y <= 420) && !isActiveResetButton)
            {
                PlayButtonHoverSound(resetSound);
                isActiveResetButton = true;
            }

            if ((e.X >= 260) && (e.X <= 365) && (e.Y >= 445) && (e.Y <= 490) && !isActiveQuitButton)
            {
                PlayButtonHoverSound(quitSound);
                isActiveQuitButton = true;
            }

            if ((e.X <= 250) || (e.X >= 370) || (e.Y <= 350) || (e.Y >= 380) && isActivePlayButton)
            {
                isActivePlayButton = false;
            }

            if ((e.X <= 270) || (e.X >= 360) || (e.Y <= 390) || (e.Y >= 420) && isActiveResetButton)
            {
                isActiveResetButton = false;
            }

            if ((e.X <= 260) || (e.X >= 365) || (e.Y <= 445) || (e.Y >= 490) && isActiveQuitButton)
            {
                isActiveQuitButton = false;
            }
        }

        private void standbyBackground_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.X >= 250) && (e.X <= 370) && (e.Y >= 350) && (e.Y <= 380))
            {
                standbyBackground.Visible = false;
                progressBar1.Visible = true;
                isPlayed = true;

                timerGameLoop.Start();
                standbySound.Ctlcontrols.stop();
                PlayButtonClickSound(resetSound);
                nextPlay.Ctlcontrols.play();
                fly1Sound.Ctlcontrols.play();
                fly2Sound.Ctlcontrols.play();
                fly3Sound.Ctlcontrols.play();
            }
            else if ((e.X >= 270) && (e.X <= 360) && (e.Y >= 390) && (e.Y <= 420))
            {

                hits = 0;
                misses = 0;
                totalInsects = 0;
                totalScore = 10;
                averageHits = 0;
                progressBar1.Value = progressBar1.Maximum;
                isPlayed = true;
                progressBar1.Visible = true;
                standbyBackground.Visible = false;
                isFly1 = false;
                isFly2 = false;
                isFly3 = false;

                fly1Sound.Ctlcontrols.stop();
                fly2Sound.Ctlcontrols.stop();
                fly3Sound.Ctlcontrols.stop();
                timerGameLoop.Start();
                standbySound.Ctlcontrols.stop();
                PlayButtonClickSound(resetSound);
                PlayRandomSound();
            }
            else if ((e.X >= 260) && (e.X <= 365) && (e.Y >= 445) && (e.Y <= 490))
            {
                standbyBackground.Visible = false;
                demo1.Visible = true;

                timerGameLoop.Stop();
                standbySound.Ctlcontrols.stop();
                PlayBackgroundSound();
            }
        }

        private void gameOverBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if ((int)gameOverSound.playState == 1 || !isSound)
            {
                if ((e.X >= 180) && (e.X <= 290) && (e.Y >= 360) && (e.Y <= 410) && !isActiveQuitButton)
                {
                    PlayButtonHoverSound(resetSound);
                    isActiveQuitButton = true;
                }

                if ((e.X >= 300) && (e.X <= 410) && (e.Y >= 360) && (e.Y <= 410) && !isActiveResetButton)
                {
                    PlayButtonHoverSound(quitSound);
                    isActiveResetButton = true;
                }

                if ((e.X <= 180) || (e.X >= 290) || (e.Y <= 360) || (e.Y >= 410) && isActiveQuitButton)
                {
                    isActiveQuitButton = false;
                }

                if ((e.X <= 300) || (e.X >= 410) || (e.Y <= 360) || (e.Y >= 410) && isActiveResetButton)
                {
                    isActiveResetButton = false;
                }
            }
        }

        private void gameOverBackground_MouseClick(object sender, MouseEventArgs e)
        {
            if ((int)gameOverSound.playState == 1)
            {
                if ((e.X >= 180) && (e.X <= 290) && (e.Y >= 360) && (e.Y <= 410))
                {
                    this.Close();
                }
                else if ((e.X >= 300) && (e.X <= 410) && (e.Y >= 360) && (e.Y <= 410))
                {

                    gameOverBackground.Visible = false;
                    gunshotSound.settings.mute = false;
                    isFly1 = false;
                    isFly2 = false;
                    isFly3 = false;
                    isOver = false;
                    isPlayed = true;
                    canPlay = true;
                    hits = 0;
                    misses = 0;
                    totalInsects = 0;
                    totalScore = 10;
                    averageHits = 0;
                    progressBar1.Value = progressBar1.Maximum;
                    progressBar1.Visible = true;
                    timerGameLoop.Start();
                    PlayButtonClickSound(resetSound);
                    PlayRandomSound();
                }
            }

        }

        private void GameOver()
        {

            if (progressBar1.Value == 0)
            {
                progressBar1.Visible = false;
                gameOverBackground.Visible = true;
                isPlayed = false;
                isOver = true;


                timerGameLoop.Stop();
                nextPlay.Ctlcontrols.stop();
                fly1Sound.Ctlcontrols.stop();
                fly2Sound.Ctlcontrols.stop();
                fly3Sound.Ctlcontrols.stop();
            }

            if (isOver && canPlay)
            {
                canPlay = false;

                PlayGameOverSound();
            }
        }

    }
}