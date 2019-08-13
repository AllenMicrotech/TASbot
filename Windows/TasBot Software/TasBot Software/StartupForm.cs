using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using TasBot_Software.Properties;
using System.Runtime.InteropServices;

namespace TasBot_Software
{
    public partial class StartupForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Enums.StartupState startupState;
        public int heightSmall = 128;
        public int heightLarge = 228;
        public int heightStart = 110;

        SoundPlayer soundPlayer;
        bool timerLocked = false;

        Thread updateChecker;

        public StartupForm()
        {
            InitializeComponent();
        }

        void PlaySound(Stream steam)
        {
            soundPlayer = new SoundPlayer(steam);
            soundPlayer.Play();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            Height = heightStart;
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            panelFirstLaunch.Location = new Point(5,107);
            panelFirstLaunch.Parent = this;
            this.Location = new Point(resolution.Width/2 - 150,resolution.Height/2 - 256);
            this.BringToFront();
            SetLabel("Starting Up...");
            Globals.startupForm = this;
            startupState = Enums.StartupState.Init;
            timerStartup.Enabled = true;
        }

        void SetLabel(string labelText)
        {
            if (this.labelLoading.InvokeRequired)
            {
                this.labelLoading.BeginInvoke((MethodInvoker)delegate () { this.labelLoading.Text = labelText; });
            }
            else
            {
                this.labelLoading.Text = labelText;
            }
        }

        private void timerStartup_Tick(object sender, EventArgs e)
        {
            if(timerLocked)
            {
                return;
            }
            timerLocked = true;

            if (startupState == Enums.StartupState.Init)
            {
                Settings.Init();
                startupState = Enums.StartupState.FadingIn;
                timerStartup.Interval = 50;
            }
            else if (startupState == Enums.StartupState.FadingIn)
            {
                if (Opacity < 1)
                {
                    Opacity += 0.05;
                }
                else
                {
                    Opacity = 1;
                    timerStartup.Interval = 100;
                    if (Settings.HasConfigFile())
                    {
                        startupState = Enums.StartupState.Loading;
                        SetLabel("Loading Config File");
                    }
                    else
                    {
                        startupState = Enums.StartupState.AwaitingInputConfig;
                        SetLabel("No Config File Found");
                        panelFirstLaunch.Visible = true;
                        panelFirstLaunch.BringToFront();
                        Height = heightLarge;
                        PlaySound(Resources.AlertTest);
                        this.BringToFront();
                    }
                }
            }
            else if (startupState == Enums.StartupState.Starting)
            {
                //MessageBox.Show("Welcome!");
            }
            else if (startupState == Enums.StartupState.Loading)
            {

            }
            timerLocked = false;
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonConfigYes_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfigSkip_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateYes_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateNo_Click(object sender, EventArgs e)
        {

        }
    }
}
