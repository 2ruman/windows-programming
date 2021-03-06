﻿
namespace ScreensaverPreventer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.chbMouseMove = new System.Windows.Forms.CheckBox();
            this.chbKeyEvent = new System.Windows.Forms.CheckBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.chbLeftMouse = new System.Windows.Forms.CheckBox();
            this.chbRightMouse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(287, 112);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hello";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(264, 53);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chbMouseMove
            // 
            this.chbMouseMove.AutoSize = true;
            this.chbMouseMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbMouseMove.Location = new System.Drawing.Point(12, 139);
            this.chbMouseMove.Name = "chbMouseMove";
            this.chbMouseMove.Size = new System.Drawing.Size(95, 18);
            this.chbMouseMove.TabIndex = 2;
            this.chbMouseMove.Text = "Mouse Move";
            this.chbMouseMove.UseVisualStyleBackColor = true;
            this.chbMouseMove.CheckedChanged += new System.EventHandler(this.chbchbMouseMove_CheckedChanged);
            // 
            // chbKeyEvent
            // 
            this.chbKeyEvent.AutoSize = true;
            this.chbKeyEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbKeyEvent.Location = new System.Drawing.Point(13, 115);
            this.chbKeyEvent.Name = "chbKeyEvent";
            this.chbKeyEvent.Size = new System.Drawing.Size(76, 18);
            this.chbKeyEvent.TabIndex = 1;
            this.chbKeyEvent.Text = "Key Event";
            this.chbKeyEvent.UseVisualStyleBackColor = true;
            this.chbKeyEvent.CheckedChanged += new System.EventHandler(this.chbKeyEvent_CheckedChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(13, 235);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(263, 53);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // chbLeftMouse
            // 
            this.chbLeftMouse.AutoSize = true;
            this.chbLeftMouse.Location = new System.Drawing.Point(142, 116);
            this.chbLeftMouse.Name = "chbLeftMouse";
            this.chbLeftMouse.Size = new System.Drawing.Size(113, 18);
            this.chbLeftMouse.TabIndex = 4;
            this.chbLeftMouse.Text = "Left Mouse Click";
            this.chbLeftMouse.UseVisualStyleBackColor = true;
            this.chbLeftMouse.CheckedChanged += new System.EventHandler(this.chbLeftMouse_CheckedChanged);
            // 
            // chbRightMouse
            // 
            this.chbRightMouse.AutoSize = true;
            this.chbRightMouse.Location = new System.Drawing.Point(142, 141);
            this.chbRightMouse.Name = "chbRightMouse";
            this.chbRightMouse.Size = new System.Drawing.Size(122, 18);
            this.chbRightMouse.TabIndex = 5;
            this.chbRightMouse.Text = "Right Mouse Click";
            this.chbRightMouse.UseVisualStyleBackColor = true;
            this.chbRightMouse.CheckedChanged += new System.EventHandler(this.chbRightMouse_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 299);
            this.Controls.Add(this.chbRightMouse);
            this.Controls.Add(this.chbLeftMouse);
            this.Controls.Add(this.chbKeyEvent);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chbMouseMove);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screensaver Preventer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chbMouseMove;
        private System.Windows.Forms.CheckBox chbKeyEvent;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.CheckBox chbLeftMouse;
        private System.Windows.Forms.CheckBox chbRightMouse;
    }
}

