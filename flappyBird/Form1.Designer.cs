
namespace flappyBird
{
    partial class fBird
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
            this.downpipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.uppipe = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scoretext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.downpipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uppipe)).BeginInit();
            this.SuspendLayout();
            // 
            // downpipe
            // 
            this.downpipe.Image = global::flappyBird.Properties.Resources.pipe;
            this.downpipe.Location = new System.Drawing.Point(594, 427);
            this.downpipe.Name = "downpipe";
            this.downpipe.Size = new System.Drawing.Size(130, 197);
            this.downpipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downpipe.TabIndex = 0;
            this.downpipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 617);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(800, 82);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::flappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(88, 265);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(78, 60);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // uppipe
            // 
            this.uppipe.Image = global::flappyBird.Properties.Resources.pipedown;
            this.uppipe.Location = new System.Drawing.Point(497, -3);
            this.uppipe.Name = "uppipe";
            this.uppipe.Size = new System.Drawing.Size(130, 188);
            this.uppipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uppipe.TabIndex = 3;
            this.uppipe.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerEvent);
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Moccasin;
            this.scoretext.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(282, 617);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(123, 51);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score:0";
            this.scoretext.Click += new System.EventHandler(this.scoretext_Click);
            // 
            // fBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(798, 699);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.uppipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.downpipe);
            this.Name = "fBird";
            this.Text = "flappy Bird game -Moo ICT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.downpipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uppipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox downpipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox uppipe;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label scoretext;
    }
}

