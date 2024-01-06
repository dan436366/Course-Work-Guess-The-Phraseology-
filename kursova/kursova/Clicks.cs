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
        private void CheckButton_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToLower().Trim();

            input = input.Replace(".", "");

            if (input.Length > 0)
            {
                int distance = LevenshteinDistance(input, currentPhrase.ToLower());

                if (distance == 0)
                {
                    resultLb.Text = "Правильно!";
                    score++;
                    UpdateScoreLabel();
                    currentIndex++;

                    if (currentIndex < phrases.Length)
                    {
                        SetPhraseAndImage();
                        pictureBox1.Image = Image.FromFile(images[currentIndex]);
                        textBox1.Text = "";
                    }
                    else
                    {
                        resultLb.Text = "Гра завершена!";
                        button1.Hide();
                        textBox1.Hide();
                        MissButton.Hide();
                        pictureBox1.Hide();
                        CloseButtonDuringTheGame.Hide();
                        CloseButton.Show();
                        PlayAgain.Show();
                    }
                }
                else
                {
                    if (distance <= 5)
                    {
                        resultLb.Text = "Майже правильно!";
                    }
                    else if (distance <= 10)
                    {
                        resultLb.Text = "Непогано, але можна ще краще!";
                    }
                    else
                    {
                        resultLb.Text = "Спробуйте ще раз!";
                    }
                }
            }
            else
            {
                resultLb.Text = "Поле не може бути пустим!";
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            score = 0;
            UpdateScoreLabel();
            SetPhraseAndImage();
            pictureBox1.Image = Image.FromFile(images[currentIndex]);
            textBox1.Text = "";
            resultLb.Text = "";

            button1.Show();
            textBox1.Show();
            MissButton.Show();
            pictureBox1.Show();
            CloseButton.Hide();
            PlayAgain.Hide();
            CloseButtonDuringTheGame.Show();
        }

        private void MissButton_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex < phrases.Length)
            {
                SetPhraseAndImage();
                pictureBox1.Image = Image.FromFile(images[currentIndex]);
                textBox1.Text = "";
                resultLb.Text = "";
            }
            else
            {
                resultLb.Text = "Гра завершена!";
                button1.Hide();
                textBox1.Hide();
                MissButton.Hide();
                pictureBox1.Hide();
                CloseButtonDuringTheGame.Hide();
                CloseButton.Show();
                PlayAgain.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButtonDuringTheGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
