namespace Pongerino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerOne = new System.Windows.Forms.PictureBox();
            this.PlayerTwo = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerOne
            // 
            this.PlayerOne.BackColor = System.Drawing.Color.DarkOrange;
            this.PlayerOne.Location = new System.Drawing.Point(12, 370);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(20, 105);
            this.PlayerOne.TabIndex = 0;
            this.PlayerOne.TabStop = false;
            // 
            // PlayerTwo
            // 
            this.PlayerTwo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PlayerTwo.Location = new System.Drawing.Point(1751, 370);
            this.PlayerTwo.Name = "PlayerTwo";
            this.PlayerTwo.Size = new System.Drawing.Size(20, 105);
            this.PlayerTwo.TabIndex = 1;
            this.PlayerTwo.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.White;
            this.Ball.Location = new System.Drawing.Point(880, 400);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(18, 18);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(417, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 158);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(1250, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 158);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.PlayerTwo);
            this.Controls.Add(this.PlayerOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PlayerOne;
        private PictureBox PlayerTwo;
        private PictureBox Ball;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}