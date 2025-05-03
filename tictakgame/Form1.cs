using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictakgame
{
    public partial class Form1 : Form
    {

        int player1totalwin = 0;
        int player2totalwin = 0;

        int totalclick = 1;
        



        public Form1()
        {
            InitializeComponent();
        }

        public void all_buttons_off()
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
        }

        public void checkwin()
        {
            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
            {
                player1totalwin++;
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b4.Text == "X" && b5.Text == "X" && b6.Text == "X")
            {
                player1totalwin++;
                b4.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b6.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b7.Text == "X" && b8.Text == "X" && b9.Text == "X")
            {
                player1totalwin++;
                b7.BackColor = Color.Green;
                b8.BackColor = Color.Green;
                b9.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b1.Text == "X" && b4.Text == "X" && b7.Text == "X")
            {
                player1totalwin++;
                b1.BackColor = Color.Green;
                b4.BackColor = Color.Green;
                b7.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")
            {
                player1totalwin++;
                b2.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b8.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b3.Text == "X" && b6.Text == "X" && b9.Text == "X")
            {
                player1totalwin++;
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")
            {
                player1totalwin++;
                b1.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b9.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player1win.Text = Convert.ToString(player1totalwin);
            }

            else if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            {
                player1totalwin++;
                b3.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b7.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b1.Text == "O" && b2.Text == "0" && b3.Text == "0")
            {
                player2totalwin++;
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b4.Text == "0" && b5.Text == "0" && b6.Text == "0")
            {
                player2totalwin++;
                b4.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b6.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b7.Text == "0" && b8.Text == "0" && b9.Text == "0")
            {
                player2totalwin++;
                b7.BackColor = Color.Green;
                b8.BackColor = Color.Green;
                b9.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }
            else if (b1.Text == "0" && b2.Text == "0" && b3.Text == "0")
            {
                player2totalwin++;
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b1.Text == "0" && b4.Text == "0" && b7.Text == "0")
            {
                player2totalwin++;
                b1.BackColor = Color.Green;
                b4.BackColor = Color.Green;
                b7.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b2.Text == "0" && b5.Text == "0" && b8.Text == "0")
            {
                player2totalwin++;
                b2.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b8.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b3.Text == "0" && b6.Text == "0" && b9.Text == "0")
            {
                player2totalwin++;
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b1.Text == "0" && b5.Text == "0" && b9.Text == "0")
            {
                player2totalwin++;
                b1.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b9.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if (b3.Text == "0" && b5.Text == "0" && b7.Text == "0")
            {
                player2totalwin++;
                b3.BackColor = Color.Green;
                b5.BackColor = Color.Green;
                b7.BackColor = Color.Green;
                all_buttons_off();
                tbnextplayer.Text = "";
                player2win.Text = Convert.ToString(player2totalwin);
            }

            else if(totalclick> 9)
            {
                MessageBox.Show("the game is tied");
                tbnextplayer.Text = "";
            }

            


        }
        
        private void b1_Click(object sender, EventArgs e)
        {
            if(totalclick % 2 ==1)
            {

                b1.Text = "X";
                b1.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b1.Text = "0";
                b1.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();


            }
            

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b2.Text = "X";
                b2.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b2.Text = "0";
                b2.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b3.Text = "X";
                b3.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b3.Text = "0";
                b3.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b4.Text = "X";
                b4.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b4.Text = "0";
                b4.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b5.Text = "X";
                b5.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b5.Text = "0";
                b5.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b6.Text = "X";
                b6.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b6.Text = "0";
                b6.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b7.Text = "X";
                b7.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b7.Text = "0";
                b7.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b8.Text = "X";
                b8.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b8.Text = "0";
                b8.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (totalclick % 2 == 1)
            {
                b9.Text = "X";
                b9.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 2";
                checkwin();
            }
            else
            {
                b9.Text = "0";
                b9.Enabled = false;
                totalclick++;
                tbnextplayer.Text = "player 1";
                checkwin();

            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";

            b1.BackColor = Color.WhiteSmoke;
            b2.BackColor = Color.WhiteSmoke;
            b3.BackColor = Color.WhiteSmoke;
            b4.BackColor = Color.WhiteSmoke;
            b5.BackColor = Color.WhiteSmoke;
            b6.BackColor = Color.WhiteSmoke;
            b7.BackColor = Color.WhiteSmoke;
            b8.BackColor = Color.WhiteSmoke;
            b9.BackColor = Color.WhiteSmoke;

            totalclick = 1;
            player1totalwin = 0;
            player2totalwin = 0;

            player1win.Text = "";
            player2win.Text = "";
            tbnextplayer.Text = "";
        }

        private void playagainbutton_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";

            b1.BackColor = Color.WhiteSmoke;
            b2.BackColor = Color.WhiteSmoke;
            b3.BackColor = Color.WhiteSmoke;
            b4.BackColor = Color.WhiteSmoke;
            b5.BackColor = Color.WhiteSmoke;
            b6.BackColor = Color.WhiteSmoke;
            b7.BackColor = Color.WhiteSmoke;
            b8.BackColor = Color.WhiteSmoke;
            b9.BackColor = Color.WhiteSmoke;

            totalclick = 1;


        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
