using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPC
{
    public partial class RPS : Form
    {
        int score1 = 0;
        int score2 = 0;
        public RPS()
        {
            InitializeComponent();
        }

        private async void RockButton_Click(object sender, EventArgs e)
        {
            String picPath3 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\initial.png";
            player2Pic.Image = Image.FromFile(picPath3);
            RockButton.Enabled = false;
            PaperButton.Enabled = false;
            ScissorsButton.Enabled = false;
            int mydelay = 1000;
            TieLabel.Text = "";
            String picPath = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic1.png";
            player1Pic.Image = Image.FromFile(picPath);
            
            
            await Task.Delay(mydelay);
            Random rnd = new Random();
            int p = rnd.Next(1, 4);
            String picPath2 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic" + p + ".png";
            player2Pic.Image = Image.FromFile(picPath2);

            if (p == 2)
            {
                score2++;
                player2Score.Text = score2.ToString();
                if (score2 == 10)
                {
                    MessageBox.Show("You Lose! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            else if(p == 1)
            {
                TieLabel.Text = ("Tie!! Shoot again why don't ya?");
            }
            else
            {
                score1++;
                player1Score.Text = score1.ToString();
                if (score1 == 10)
                {
                    MessageBox.Show("You Win! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            if (score2 != 10 && score1 != 10)
            {
                RockButton.Enabled = true;
                PaperButton.Enabled = true;
                ScissorsButton.Enabled = true;
            }
        }

        private async void PaperButton_Click(object sender, EventArgs e)
        {
            String picPath3 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\initial.png";
            player2Pic.Image = Image.FromFile(picPath3);
            RockButton.Enabled = false;
            PaperButton.Enabled = false;
            ScissorsButton.Enabled = false;
            int mydelay = 1000;
            TieLabel.Text = "";
            String picPath = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic2.png";
            player1Pic.Image= Image.FromFile(picPath);

            await Task.Delay(mydelay);
            Random rnd = new Random();
            int p = rnd.Next(1, 4);
            String picPath2 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic" + p + ".png";
            player2Pic.Image = Image.FromFile(picPath2);
            if (p == 3)
            {
                score2++;
                player2Score.Text = score2.ToString();
                if (score2 == 10)
                {
                    MessageBox.Show("You Lose! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            else if (p == 2)
            {
                TieLabel.Text = ("Tie!! Shoot again why don't ya?");
            }
            else
            {
                score1++;
                player1Score.Text = score1.ToString();
                if (score1 == 10)
                {
                    MessageBox.Show("You Win! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            if (score2 != 10 && score1 != 10)
            {
                RockButton.Enabled = true;
                PaperButton.Enabled = true;
                ScissorsButton.Enabled = true;
            }
        }

        private async void ScissorsButton_Click(object sender, EventArgs e)
        {
            String picPath3 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\initial.png";
            player2Pic.Image = Image.FromFile(picPath3);
            RockButton.Enabled = false;
            PaperButton.Enabled = false;
            ScissorsButton.Enabled = false;
            int mydelay = 1000;
            TieLabel.Text = "";
            String picPath = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic3.png";
            player1Pic.Image = Image.FromFile(picPath);

            await Task.Delay(mydelay);
            Random rnd = new Random();
            int p = rnd.Next(1, 4);
            String picPath2 = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\pic" + p + ".png";
            player2Pic.Image = Image.FromFile(picPath2);
            if (p == 1)
            {
                score2++;
                player2Score.Text = score2.ToString();
                if(score2 == 10)
                {
                    MessageBox.Show("You Lose! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            else if (p == 3)
            {
                TieLabel.Text = ("Tie!! Shoot again why don't ya?");
            }
            else
            {
                score1++;
                player1Score.Text = score1.ToString();
                if (score1 == 10)
                {
                    MessageBox.Show("You Win! Play again? Press restart to play agian");
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                }
            }
            if(score2 != 10 && score1 != 10)
            {
                RockButton.Enabled = true;
                PaperButton.Enabled = true;
                ScissorsButton.Enabled = true;
            }
           

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            String picPath = "C:\\Users\\FABI54148\\OneDrive - lhcgroup.com\\Desktop\\Programs\\RPC\\pictures\\initial.png";
            player1Pic.Image = Image.FromFile(picPath);
            player2Pic.Image = Image.FromFile(picPath);
            score1 = 0;
            score2 = 0;
            player1Score.Text = score1.ToString();
            player2Score.Text = score2.ToString();
            TieLabel.Text = "";
            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
