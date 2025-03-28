namespace PokemonGame
{
    partial class Move
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
            gbMoves = new GroupBox();
            rbAuraSpher = new RadioButton();
            rb = new RadioButton();
            gbMoves.SuspendLayout();
            SuspendLayout();
            // 
            // gbMoves
            // 
            gbMoves.Controls.Add(rb);
            gbMoves.Controls.Add(rbAuraSpher);
            gbMoves.Location = new Point(20, 13);
            gbMoves.Name = "gbMoves";
            gbMoves.Size = new Size(920, 550);
            gbMoves.TabIndex = 0;
            gbMoves.TabStop = false;
            gbMoves.Text = "Moves";
            // 
            // rbAuraSpher
            // 
            rbAuraSpher.AutoSize = true;
            rbAuraSpher.Location = new Point(27, 35);
            rbAuraSpher.Name = "rbAuraSpher";
            rbAuraSpher.Size = new Size(111, 24);
            rbAuraSpher.TabIndex = 0;
            rbAuraSpher.TabStop = true;
            rbAuraSpher.Text = "Aura Sphere";
            rbAuraSpher.UseVisualStyleBackColor = true;
            // 
            // rb
            // 
            rb.AutoSize = true;
            rb.Location = new Point(27, 74);
            rb.Name = "rb";
            rb.Size = new Size(117, 24);
            rb.TabIndex = 1;
            rb.TabStop = true;
            rb.Text = "radioButton1";
            rb.UseVisualStyleBackColor = true;
            // 
            // Move
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 575);
            Controls.Add(gbMoves);
            Name = "Move";
            Text = "Move";
            gbMoves.ResumeLayout(false);
            gbMoves.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMoves;
        private RadioButton rb;
        private RadioButton rbAuraSpher;
    }
}