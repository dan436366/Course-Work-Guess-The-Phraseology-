using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form1 : Form
    {
        private string currentPhrase; 

        private string[] phrases = { "Розвісити вуха", "Водити за носа", "Ходити на голові", "Чесати язика", "Мурашки по спині бігають"}; 

        private string[] images = { "image1.png", "image2.png", "image3.png", "image4.png", "image5.png" }; 

        private int currentIndex = 0;

        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            CloseButton.Hide();
            PlayAgain.Hide();

            CloseButton.Click += CloseButton_Click;
            Controls.Add(CloseButton);

            MissButton.Click += MissButton_Click;
            Controls.Add(MissButton);

            UpdateScoreLabel();
            Controls.Add(scoreLabel);

            resultLb.Text = "Введіть фразеологізм";

            SetPhraseAndImage(); 
        }

        private void SetPhraseAndImage()
        {
            currentPhrase = phrases[currentIndex];
            pictureBox1.Image = Image.FromFile(images[currentIndex]);
        }

        private void UpdateScoreLabel()
        {
            scoreLabel.Text = $"Ваш рахунок: {score}/{phrases.Length}";
        }

        private int LevenshteinDistance(string s1, string s2)
        {
            int[,] d = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i == 0)
                        d[i, j] = j;
                    else if (j == 0)
                        d[i, j] = i;
                    else
                        d[i, j] = Math.Min(
                            Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                            d[i - 1, j - 1] + (s1[i - 1] == s2[j - 1] ? 0 : 1)
                        );
                }
            }

            return d[s1.Length, s2.Length];
        }
    }
}
