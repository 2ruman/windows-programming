using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ScreensaverPreventer
{
    public partial class MainForm : Form
    {
        private static bool welcomeToggle = false;
        private const int DELAY_MS = 5000;
        private Thread mWorkThread = null;
        private bool keyEventFlag = true;
        private bool mouseMoveEventFlag = true;
        private bool lMouseClickEventFlag = true;
        private bool rMouseClickEventFlag = false;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

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

            if (Cursor.Position.X > centerX)
            {
                destX = centerX - 100;
            }
            else
            {
                destX = centerX + 100;
            }
            destY = centerY;
            Cursor.Position = new Point(destX, destY);
        }

        private void clickLeftMouse()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        private void clickRightMouse()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void prevent()
        {
            while(true)
            {
                if (keyEventFlag)
                {
                    pressLWinKey();
                }
                if (mouseMoveEventFlag)
                {
                    makeCursorRunawayFromCenter();
                }
                if (lMouseClickEventFlag)
                {
                    clickLeftMouse();
                }
                if (rMouseClickEventFlag)
                {
                    clickRightMouse();
                }
                Thread.Sleep(DELAY_MS);
            }
        }

        private void abort()
        {
            if (mWorkThread != null)
            {
                mWorkThread.Abort();
                mWorkThread = null;
            }

            Environment.Exit(0);
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            if (welcomeToggle = !welcomeToggle)
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
            chbKeyEvent.Enabled = chbMouseMove.Enabled = btnStart.Enabled = chbLeftMouse.Enabled = chbRightMouse.Enabled = false;
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
            chbMouseMove.Checked = mouseMoveEventFlag;
            chbLeftMouse.Checked = lMouseClickEventFlag;
            chbRightMouse.Checked = rMouseClickEventFlag;
        }

        private void chbKeyEvent_CheckedChanged(object sender, EventArgs e)
        {
            keyEventFlag = chbKeyEvent.Checked;
        }

        private void chbchbMouseMove_CheckedChanged(object sender, EventArgs e)
        {
            mouseMoveEventFlag = chbMouseMove.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            abort();
        }

        private void chbLeftMouse_CheckedChanged(object sender, EventArgs e)
        {
            lMouseClickEventFlag = chbLeftMouse.Checked;
        }

        private void chbRightMouse_CheckedChanged(object sender, EventArgs e)
        {
            rMouseClickEventFlag = chbRightMouse.Checked;
        }
    }
}