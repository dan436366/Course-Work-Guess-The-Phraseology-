namespace kursova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultLb = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.MissButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.CloseButtonDuringTheGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(583, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Перевірити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(12, 467);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 100);
            this.textBox1.TabIndex = 2;
            // 
            // resultLb
            // 
            this.resultLb.AutoSize = true;
            this.resultLb.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLb.ForeColor = System.Drawing.Color.White;
            this.resultLb.Location = new System.Drawing.Point(10, 581);
            this.resultLb.Name = "resultLb";
            this.resultLb.Size = new System.Drawing.Size(0, 33);
            this.resultLb.TabIndex = 3;
            this.resultLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CloseButton.Location = new System.Drawing.Point(377, 270);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(345, 191);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Завершити гру";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.White;
            this.PlayAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayAgain.BackgroundImage")));
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F);
            this.PlayAgain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlayAgain.Location = new System.Drawing.Point(12, 270);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(345, 191);
            this.PlayAgain.TabIndex = 5;
            this.PlayAgain.Text = "Почати заново";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // MissButton
            // 
            this.MissButton.BackColor = System.Drawing.Color.LightGray;
            this.MissButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MissButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MissButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MissButton.Location = new System.Drawing.Point(438, 467);
            this.MissButton.Name = "MissButton";
            this.MissButton.Size = new System.Drawing.Size(139, 100);
            this.MissButton.TabIndex = 6;
            this.MissButton.Text = "Пропустити";
            this.MissButton.UseVisualStyleBackColor = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(553, 581);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 33);
            this.scoreLabel.TabIndex = 7;
            // 
            // CloseButtonDuringTheGame
            // 
            this.CloseButtonDuringTheGame.BackColor = System.Drawing.Color.White;
            this.CloseButtonDuringTheGame.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtonDuringTheGame.ForeColor = System.Drawing.Color.Red;
            this.CloseButtonDuringTheGame.Location = new System.Drawing.Point(496, 649);
            this.CloseButtonDuringTheGame.Name = "CloseButtonDuringTheGame";
            this.CloseButtonDuringTheGame.Size = new System.Drawing.Size(226, 50);
            this.CloseButtonDuringTheGame.TabIndex = 9;
            this.CloseButtonDuringTheGame.Text = "Завершити гру";
            this.CloseButtonDuringTheGame.UseVisualStyleBackColor = false;
            this.CloseButtonDuringTheGame.Click += new System.EventHandler(this.CloseButtonDuringTheGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.CloseButtonDuringTheGame);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.MissButton);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.resultLb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Вгадай фразеологізм";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLb;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button MissButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button CloseButtonDuringTheGame;
    }
}

