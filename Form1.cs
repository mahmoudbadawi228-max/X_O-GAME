using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3WithTicToeGameProgect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string currentplayer = "X";
        

        void DisableAll()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        bool ChecckedWinner()
        {
            if(btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "?")
            {
                lbwin.Text = "Player " + btn1.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "?")
            {
                lbwin.Text = "Player " + btn4.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "?")
            {
                lbwin.Text = "Player " + btn7.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "?")
            {
                lbwin.Text = "Player " + btn1.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "?")
            {
                
                lbwin.Text = "Player " + btn2.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "?")
            {
                lbwin.Text = "Player " + btn3.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "?")
            {
                lbwin.Text = "Player " + btn1.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "?")
            {
                lbwin.Text = "Player " + btn3.Text + " Wins";
                lbGameover.Text = "GAME OVER";
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                DisableAll();
                return true;
            }
            if(btn1.Text != "?" && btn2.Text != "?" && btn3.Text != "?" && btn4.Text != "?"
                && btn5.Text != "?" && btn6.Text != "?" && btn7.Text != "?" && btn8.Text != "?" && btn9.Text != "?")
            {
                lbwin.Text = "DRAW";
                lbGameover.Text = "GAME OVER";
                DisableAll();
                return true;

            }
           
            return false;
        }

        void RestartGame()
        {
            btn1.Text = "?"; 
            btn2.Text = "?"; 
            btn3.Text = "?"; 
            btn4.Text = "?"; 
            btn5.Text = "?"; 
            btn6.Text = "?"; 
            btn7.Text = "?"; 
            btn8.Text = "?";
            btn9.Text = "?";
            
            currentplayer = "X";
            lbwin.Text = "RESULT";

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        /* Game With Computer
        void ComputerPlayRandom()
        {
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            Random rnd = new Random();
            int index;
            do
            {
                index = rnd.Next(0, 9);
            } while (btns[index].Text != "?");

            btns[index].Text = "O";

        }
        */
      private void Buttun_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "?")
            {
                MessageBox.Show("This Buttun Already Reserved");
                return;
            }
           
             btn.Text = currentplayer;
            
            
            if(ChecckedWinner())
            {
                return;
            }
            if(currentplayer == "X")
            {
                currentplayer = "O";
            }
            else
            {
                currentplayer = "X";
            }

       
            /*
            if(ChecckedWinner())
            {
                return;
            }
            ComputerPlayRandom();
            if (ChecckedWinner())
            {
                return;
            }
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}



























