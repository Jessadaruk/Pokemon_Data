namespace ProjectPokemon
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
            button1 = new Button();
            pictureBoxPokemon = new PictureBox();
            lblPokemonName = new Label();
            lblPokemonType = new Label();
            lblPokemonStatus = new Label();
            df = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 26);
            button1.Name = "button1";
            button1.Size = new Size(100, 41);
            button1.TabIndex = 0;
            button1.Text = "Pikachu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(254, 26);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(248, 247);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPokemon.TabIndex = 1;
            pictureBoxPokemon.TabStop = false;
            // 
            // lblPokemonName
            // 
            lblPokemonName.AutoSize = true;
            lblPokemonName.Location = new Point(535, 39);
            lblPokemonName.Name = "lblPokemonName";
            lblPokemonName.Size = new Size(39, 15);
            lblPokemonName.TabIndex = 2;
            lblPokemonName.Text = "Name";
            // 
            // lblPokemonType
            // 
            lblPokemonType.AutoSize = true;
            lblPokemonType.Location = new Point(535, 103);
            lblPokemonType.Name = "lblPokemonType";
            lblPokemonType.Size = new Size(31, 15);
            lblPokemonType.TabIndex = 3;
            lblPokemonType.Text = "Type";
            // 
            // lblPokemonStatus
            // 
            lblPokemonStatus.AutoSize = true;
            lblPokemonStatus.Location = new Point(535, 157);
            lblPokemonStatus.Name = "lblPokemonStatus";
            lblPokemonStatus.Size = new Size(39, 15);
            lblPokemonStatus.TabIndex = 4;
            lblPokemonStatus.Text = "Status";
            // 
            // df
            // 
            df.Location = new Point(33, 77);
            df.Name = "df";
            df.Size = new Size(100, 41);
            df.TabIndex = 5;
            df.Text = "Celebi";
            df.UseVisualStyleBackColor = true;
            df.Click += df_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 131);
            button2.Name = "button2";
            button2.Size = new Size(100, 41);
            button2.TabIndex = 6;
            button2.Text = "Groudon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 187);
            button3.Name = "button3";
            button3.Size = new Size(100, 41);
            button3.TabIndex = 7;
            button3.Text = "Piplup";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 243);
            button4.Name = "button4";
            button4.Size = new Size(100, 41);
            button4.TabIndex = 8;
            button4.Text = "Chatot";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(33, 302);
            button5.Name = "button5";
            button5.Size = new Size(100, 41);
            button5.TabIndex = 9;
            button5.Text = "Greninja";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(df);
            Controls.Add(lblPokemonStatus);
            Controls.Add(lblPokemonType);
            Controls.Add(lblPokemonName);
            Controls.Add(pictureBoxPokemon);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBoxPokemon;
        private Label lblPokemonName;
        private Label lblPokemonType;
        private Label lblPokemonStatus;
        private Button df;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
