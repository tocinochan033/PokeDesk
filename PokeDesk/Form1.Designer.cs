namespace PokeDesk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.pokemonTextBox = new System.Windows.Forms.TextBox();
            this.pokemonButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pokemonDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonPictureBox
            // 
            this.pokemonPictureBox.BackColor = System.Drawing.Color.White;
            this.pokemonPictureBox.Location = new System.Drawing.Point(169, 116);
            this.pokemonPictureBox.Name = "pokemonPictureBox";
            this.pokemonPictureBox.Size = new System.Drawing.Size(240, 240);
            this.pokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemonPictureBox.TabIndex = 0;
            this.pokemonPictureBox.TabStop = false;
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.BackColor = System.Drawing.Color.White;
            this.pokemonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonNameLabel.Location = new System.Drawing.Point(88, 317);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(89, 38);
            this.pokemonNameLabel.TabIndex = 1;
            this.pokemonNameLabel.Text = "5555";
            // 
            // pokemonTextBox
            // 
            this.pokemonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonTextBox.Location = new System.Drawing.Point(214, 627);
            this.pokemonTextBox.Name = "pokemonTextBox";
            this.pokemonTextBox.Size = new System.Drawing.Size(140, 30);
            this.pokemonTextBox.TabIndex = 2;
            this.pokemonTextBox.TextChanged += new System.EventHandler(this.pokemonTextBox_TextChanged);
            // 
            // pokemonButton
            // 
            this.pokemonButton.AllowDrop = true;
            this.pokemonButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.pokemonButton.Location = new System.Drawing.Point(54, 523);
            this.pokemonButton.Name = "pokemonButton";
            this.pokemonButton.Size = new System.Drawing.Size(89, 85);
            this.pokemonButton.TabIndex = 3;
            this.pokemonButton.UseVisualStyleBackColor = false;
            this.pokemonButton.Click += new System.EventHandler(this.pokemonButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pokemonDescriptionLabel
            // 
            this.pokemonDescriptionLabel.AutoSize = true;
            this.pokemonDescriptionLabel.Location = new System.Drawing.Point(748, 101);
            this.pokemonDescriptionLabel.Name = "pokemonDescriptionLabel";
            this.pokemonDescriptionLabel.Size = new System.Drawing.Size(44, 16);
            this.pokemonDescriptionLabel.TabIndex = 5;
            this.pokemonDescriptionLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 713);
            this.Controls.Add(this.pokemonDescriptionLabel);
            this.Controls.Add(this.pokemonButton);
            this.Controls.Add(this.pokemonTextBox);
            this.Controls.Add(this.pokemonNameLabel);
            this.Controls.Add(this.pokemonPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemonPictureBox;
        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.TextBox pokemonTextBox;
        private System.Windows.Forms.Button pokemonButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pokemonDescriptionLabel;
    }
}

