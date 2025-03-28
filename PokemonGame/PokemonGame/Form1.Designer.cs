namespace PokemonGame
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
            butPlay = new Button();
            pictureBox1 = new PictureBox();
            butQuit = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butPlay
            // 
            butPlay.Anchor = AnchorStyles.None;
            butPlay.Location = new Point(397, 321);
            butPlay.Name = "butPlay";
            butPlay.Size = new Size(174, 107);
            butPlay.TabIndex = 0;
            butPlay.Text = "Play";
            butPlay.UseVisualStyleBackColor = true;
            butPlay.Click += butPlay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(285, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // butQuit
            // 
            butQuit.Anchor = AnchorStyles.None;
            butQuit.Location = new Point(632, 321);
            butQuit.Name = "butQuit";
            butQuit.Size = new Size(174, 107);
            butQuit.TabIndex = 2;
            butQuit.Text = "Quit";
            butQuit.UseVisualStyleBackColor = true;
            butQuit.Click += butQuit_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(157, 321);
            button3.Name = "button3";
            button3.Size = new Size(174, 107);
            button3.TabIndex = 3;
            button3.Text = "Rules";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 536);
            Controls.Add(button3);
            Controls.Add(butQuit);
            Controls.Add(pictureBox1);
            Controls.Add(butPlay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butPlay;
        private PictureBox pictureBox1;
        private Button butQuit;
        private Button button3;
    }
}
