using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//created by Filip Komárek & Šimon Konečný

namespace forms_game
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, shooting, isGameOver;
        int score;
        double playerSpeed = 15;
        double enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainGameTimeEvent(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();

            enemyOne.Top += System.Convert.ToInt32(enemySpeed);
            enemyTwo.Top += System.Convert.ToInt32(enemySpeed);
            enemyThree.Top += System.Convert.ToInt32(enemySpeed);

            if (enemyOne.Top > 520 || enemyTwo.Top > 520 || enemyThree.Top > 520)
            {
                gameOver();
            }

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= System.Convert.ToInt32(playerSpeed);
            }
            if (goRight == true && player.Left < 700)
            {
                player.Left += System.Convert.ToInt32(playerSpeed);
            }

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
                enemySpeed = enemySpeed + 0.5;
                playerSpeed = playerSpeed + 0.5;
            }

            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
                enemySpeed = enemySpeed + 0.5;
                playerSpeed = playerSpeed + 0.5;
            }

            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
                enemySpeed = enemySpeed + 0.5;
                playerSpeed = playerSpeed + 0.5;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 60;
                bullet.Left = player.Left + (player.Width / 2 - 18);
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                resetGame();
            }
            if (e.KeyCode == Keys.Space && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            isGameOver = false;
            shooting = false;

            gametimer.Start();
            enemySpeed = 1;

            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 200) * -1;
            enemyThree.Top = rnd.Next(0, 200) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;

            txtScore.Text = score.ToString();
        }

        private void gameOver()
        {
            isGameOver = true;
            gametimer.Stop();

            //tohle z nějakýho důvodu nefunguje
            //txtScore.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press Enter to try again";
        }
    }
}
