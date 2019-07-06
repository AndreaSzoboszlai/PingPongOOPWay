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
            this.PlayerA = new System.Windows.Forms.PictureBox();
            this.PlayerB = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.MiddleLine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
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
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ball.Location = new System.Drawing.Point(139, 241);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(22, 23);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
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
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MiddleLine);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.PlayerA);
            this.Name = "PingPong";
            this.Text = "Ping Pong OOP Way";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerA;
        private System.Windows.Forms.PictureBox PlayerB;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox MiddleLine;
    }
}

