namespace PingPonOOPWay
{
    partial class PingPong
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
            this.PlayerA = new System.Windows.Forms.PictureBox();
            this.PlayerB = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.MiddleLine = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleLine)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerA
            // 
            this.PlayerA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PlayerA.Location = new System.Drawing.Point(13, 139);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.Size = new System.Drawing.Size(13, 125);
            this.PlayerA.TabIndex = 0;
            this.PlayerA.TabStop = false;
            // 
            // PlayerB
            // 
            this.PlayerB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PlayerB.Location = new System.Drawing.Point(775, 139);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(13, 125);
            this.PlayerB.TabIndex = 1;
            this.PlayerB.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Location = new System.Drawing.Point(139, 241);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(22, 23);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // MiddleLine
            // 
            this.MiddleLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MiddleLine.Location = new System.Drawing.Point(396, -32);
            this.MiddleLine.Name = "MiddleLine";
            this.MiddleLine.Size = new System.Drawing.Size(10, 512);
            this.MiddleLine.TabIndex = 3;
            this.MiddleLine.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MiddleLine);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.PlayerA);
            this.Name = "PingPong";
            this.Text = "Ping Pong OOP Way";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerA;
        private System.Windows.Forms.PictureBox PlayerB;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox MiddleLine;
        private System.Windows.Forms.Timer gameTimer;
    }
}

