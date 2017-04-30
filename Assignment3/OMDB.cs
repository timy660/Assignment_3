using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{

    public partial class OMDB : Form
    {
        static class Constants
        {
            public const int NUM_OF_QUESTIONS = 10;
            public const int NUM_OF_PLAYERS = 2;

        }
        int score1 = 0, score2 = 0;
        private bool button1WasClicked = false;
        private bool button2WasClicked = false;
        public OMDB()
        {
            InitializeComponent();
        }
        private void OMDB_Load(object sender, EventArgs e)
        {
            //q1
            label2.Text = Questions.ActorQuestion();

            var ans1 = MovieData.GetActors(textBox1.Text);
            var ans2 = MovieData.GetActors(textBox2.Text);
            if (button1WasClicked == true && button2WasClicked == true)
            {
                if (label2.Text.Contains(ans1))
                {
                    score1++;
                }
                else if (label2.Text.Contains(ans2))
                {
                    score2++;
                }

            }
            button1WasClicked = false;
            button2WasClicked = false;
            textBox1.Text = "";
            textBox2.Text = "";

            //q2
            label2.Text = Questions.DurationQuestion();
            ans1 = MovieData.GetDuration(textBox1.Text);
            ans2 = MovieData.GetDuration(textBox2.Text);
            int num = Convert.ToInt32(ans1);
            int num2 = Convert.ToInt32(ans2);

            if (button1WasClicked == true && button2WasClicked == true)
            {
                if (num > num2)
                {
                    score1++;
                }
                else if (num < num2)
                {
                    score2++;
                }

            }
            button1WasClicked = false;
            button2WasClicked = false;
            textBox1.Text = "";
            textBox2.Text = "";
           
                //q3
            label2.Text = Questions.OscarQuestion();
            ans1 = MovieData.GetOsacrs(textBox1.Text);
            ans2 = MovieData.GetOsacrs(textBox2.Text);


            if (button1WasClicked == true && button2WasClicked == true)
            {
                if (Convert.ToInt32(ans1) > Convert.ToInt32(ans2))
                {
                    score1++;
                }
                else if (Convert.ToInt32(ans1) < Convert.ToInt32(ans2))
                {
                    score2++;
                }

            }
            textBox1.Text = "";
            textBox2.Text = "";
            button1WasClicked = false;
            button2WasClicked = false;

            //q4
            label2.Text = Questions.ScoreQuestion();
            double sco = MovieData.GetScore(textBox1.Text);
            double sco2 = MovieData.GetScore(textBox2.Text);


            if (button1WasClicked == true && button2WasClicked == true)
            {
                if (sco > sco2) 
                {
                    score1++;
                }
                else if (sco<sco2)
                {
                    score2++;
                }

            }
            textBox1.Text = "";
            textBox2.Text = "";
            button1WasClicked = false;
            button2WasClicked = false;

            //q5
            label2.Text = Questions.YearQuestion();
            ans1 = MovieData.GetReleaseYear(textBox1.Text);
            ans2 = MovieData.GetReleaseYear(textBox2.Text);


            if (button1WasClicked == true && button2WasClicked == true)
            {
                if (Convert.ToInt32(ans1) < Convert.ToInt32(ans2))
                {
                    score1++;
                }
                else if (Convert.ToInt32(ans1) > Convert.ToInt32(ans2))
                {
                    score2++;
                }

            }
            ///anounce winner
            
            if(score1>score2)
            {
                MessageBox.Show("Player1 won!");
            }
            if (score1 < score2)
            {
                MessageBox.Show("Player2 won!");
            }
            if (score1 == score2)
            {
                MessageBox.Show("You both won!");
            }
            if (score1==0 && score2==0)
            {
                MessageBox.Show("You both lost!");
            }

        }
        private void Button1_Click(object sender, EventArgs e)
        {
          button1WasClicked = true;  

        }

       

        private void Button2_Click(object sender, EventArgs e)
        {

            button2WasClicked = true;

        }
        
    }
    
}
