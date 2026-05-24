
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

        void Disable()
        {
            Button[] allbuttun = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var buttun in allbuttun)
            {
                buttun.Enabled = false;
            }
        }
        void ColorPaint(Button a, Button b, Button c)
        {
            a.BackColor = Color.Green;
            b.BackColor = Color.Green;
            c.BackColor = Color.Green;
        }
        void AnyWinner(Button a, Button b, Button c)
        {
            lbwin.Text = "Player " + a.Text + " Wins!";
            lbGameover.Text = "GAME OVER";
            ColorPaint(a, b, c);
            Disable();
        }
        bool ChecckedWinner()
        {
            if(btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "?")
            {
                AnyWinner(btn1, btn2, btn3);
                return true;
            }
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "?")
            {
                AnyWinner(btn4, btn5, btn6);
                return true;
            }
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "?")
            {
                AnyWinner(btn7, btn8, btn9);
                return true;
            }
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "?")
            {
                AnyWinner(btn1, btn4, btn7);
                return true;
            }
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "?")
            {

                AnyWinner(btn2, btn5, btn8);
                return true;
            }
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "?")
            {
                AnyWinner(btn3, btn6, btn9);
                return true;
            }
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "?")
            {
                AnyWinner(btn1, btn5, btn9);
                return true;
            }
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "?")
            {
                AnyWinner(btn3, btn5, btn7);
                return true;
            }
            if(btn1.Text != "?" && btn2.Text != "?" && btn3.Text != "?" && btn4.Text != "?"
                && btn5.Text != "?" && btn6.Text != "?" && btn7.Text != "?" && btn8.Text != "?" && btn9.Text != "?")
            {
                lbwin.Text = "DRAW";
                lbGameover.Text = "GAME OVER";
                Disable();
                return true;
            }
            return false;
        }
        void RestartGame()
        {
            Button[] allbuttuns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach(var V in allbuttuns)
            {
                V.Text = "?";
                V.BackColor = Color.White;
                V.Enabled = true;
            }
            currentplayer = "X";
            lbwin.Text = "RESULT";
        }

        // Game With Computer
        //void ComputerPlayRandom()
        //{
        //    Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

        //    Random rnd = new Random();
        //    int index;
        //    do
        //    {
        //        index = rnd.Next(0, 9);
        //    } while (btns[index].Text != "?");

        //    btns[index].Text = "O";

        //}

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
            //if(ChecckedWinner())
            //{
            //    return;
            //}
            //ComputerPlayRandom();
            //if (ChecckedWinner())
            //{
            //    return;
            //}
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}






























