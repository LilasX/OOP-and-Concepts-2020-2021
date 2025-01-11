namespace LabTrafficLight
{
    partial class Traffic_Light
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
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            this.pictureYellow = new System.Windows.Forms.PictureBox();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureGreen
            // 
            this.pictureGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGreen.Image = global::LabTrafficLight.Properties.Resources.GreenLight;
            this.pictureGreen.Location = new System.Drawing.Point(0, 0);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(150, 400);
            this.pictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGreen.TabIndex = 2;
            this.pictureGreen.TabStop = false;
            this.pictureGreen.Click += new System.EventHandler(this.pictureGreen_Click);
            // 
            // pictureYellow
            // 
            this.pictureYellow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureYellow.Image = global::LabTrafficLight.Properties.Resources.YellowLight;
            this.pictureYellow.Location = new System.Drawing.Point(0, 0);
            this.pictureYellow.Name = "pictureYellow";
            this.pictureYellow.Size = new System.Drawing.Size(150, 400);
            this.pictureYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureYellow.TabIndex = 1;
            this.pictureYellow.TabStop = false;
            // 
            // pictureRed
            // 
            this.pictureRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureRed.Image = global::LabTrafficLight.Properties.Resources.RedLight;
            this.pictureRed.Location = new System.Drawing.Point(0, 0);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(150, 400);
            this.pictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRed.TabIndex = 0;
            this.pictureRed.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Traffic_Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(150, 400);
            this.Controls.Add(this.pictureGreen);
            this.Controls.Add(this.pictureYellow);
            this.Controls.Add(this.pictureRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 200);
            this.Name = "Traffic_Light";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureYellow;
        private System.Windows.Forms.PictureBox pictureGreen;
        private System.Windows.Forms.Timer timer1;
    }
}

