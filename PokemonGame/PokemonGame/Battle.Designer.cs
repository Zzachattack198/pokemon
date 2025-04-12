namespace PokemonGame
{
    partial class Battle
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
        /// 
        
        private void InitializeComponent()
        {
            team1Poke = new PictureBox();
            team2Poke = new PictureBox();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            TextBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)team1Poke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)team2Poke).BeginInit();
            SuspendLayout();
            // 
            // team1Poke
            // 
            team1Poke.Location = new Point(98, 285);
            team1Poke.Name = "team1Poke";
            team1Poke.Size = new Size(230, 165);
            team1Poke.TabIndex = 0;
            team1Poke.TabStop = false;
            // 
            // team2Poke
            // 
            team2Poke.Location = new Point(596, 167);
            team2Poke.Name = "team2Poke";
            team2Poke.Size = new Size(230, 165);
            team2Poke.TabIndex = 1;
            team2Poke.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(652, 451);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(228, 37);
            progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(93, 44);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(228, 37);
            progressBar2.TabIndex = 3;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(203, 204);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(125, 27);
            TextBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(2, 410);
            button1.Name = "button1";
            button1.Size = new Size(261, 131);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(259, 410);
            button2.Name = "button2";
            button2.Size = new Size(261, 131);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(516, 410);
            button3.Name = "button3";
            button3.Size = new Size(261, 131);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Battle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(935, 541);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TextBox1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(team2Poke);
            Controls.Add(team1Poke);
            Name = "Battle";
            Text = "Battle";
            ((System.ComponentModel.ISupportInitialize)team1Poke).EndInit();
            ((System.ComponentModel.ISupportInitialize)team2Poke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        } 

        #endregion

        private PictureBox team1Poke;
        private PictureBox team2Poke;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private TextBox TextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}