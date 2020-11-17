using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ScreensaverPreventer
{
    public partial class MainForm : Form
    {
        private static bool welcomeToggle = false;
        private const int DELAY_MS = 3000;
        private Thread mWorkThread = null;
        private bool keyEventFlag = true;
        private bool mouseEventFlag = true;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public MainForm()
        {
            InitializeComponent();
        }

        private void pressLWinKey()
        {
            keybd_event((byte)Keys.LWin, 0x45, 0x00, 0);
            keybd_event((byte)Keys.LWin, 0x45, 0x02, 0);
        }

        private void makeCursorRunawayFromCenter()
        {
            Cursor = new Cursor(Cursor.Current.Handle);
            int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
            int centerY = Screen.PrimaryScreen.Bounds.Height / 2;
            int destX, destY;

            if( Cursor.Position.X > centerX )
            {
                destX = centerX - 200;
            }
            else
            {
                destX = centerX + 200;
            }
            destY = centerY;
            Cursor.Position = new Point(destX, destY);
        }

        private void prevent()
        {
            while(true)
            {
                if( keyEventFlag )
                {
                    pressLWinKey();
                }
                if( mouseEventFlag)
                {
                    makeCursorRunawayFromCenter();
                }
                Thread.Sleep(DELAY_MS);
            }
        }

        private void abort()
        {
            Debug.WriteLine("Abort!!!");
            if (mWorkThread != null)
            {
                mWorkThread.Abort();
                mWorkThread = null;
            }

            Environment.Exit(0);
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            if( welcomeToggle = !welcomeToggle )
            {
                lblWelcome.Text = "^.<";
            }
            else
            {
                lblWelcome.Text = "Hello";
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            chbKeyEvent.Enabled = chbMouseEvent.Enabled = btnStart.Enabled = false;
            mWorkThread = new Thread(prevent);
            mWorkThread.Start();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            abort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chbKeyEvent.Checked = keyEventFlag;
            chbMouseEvent.Checked = mouseEventFlag;
        }

        private void chbKeyEvent_CheckedChanged(object sender, EventArgs e)
        {
            keyEventFlag = chbKeyEvent.Checked;
        }

        private void chbMouseEvent_CheckedChanged(object sender, EventArgs e)
        {
            mouseEventFlag = chbMouseEvent.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            abort();
        }
    }
}
