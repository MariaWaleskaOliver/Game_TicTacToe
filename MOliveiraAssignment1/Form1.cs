using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOAssignment1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
        //call the method 
            FillButtonText(sender);
        }
        //Method to fill the Buttons 
        private void FillButtonText(object sender)
        {
            //Creating an event for all buttons 
            Button btn = (Button)sender;

            // find the index of the button 
            int buttonIndex = btn.TabIndex;
           
            //check if the button is empyte or if it is the end of the game 
            if (btn.Text == "" && endGame == false)
            {
                if (round == true)
                {
                    //check witch is the buttom to add the image in the img Box for X
                    string buttanNameForX = btn.Name;

                    switch (buttanNameForX)
                    {
                        case "btn1":
                            
                            btn.Enabled = false;    
                            pictureBox1.Visible = true;
                            pictureBox1.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn2":
                            btn.Enabled = false;
                            pictureBox2.Visible = true;
                            pictureBox2.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn3":
                            btn.Enabled = false;
                            pictureBox3.Visible = true;
                            pictureBox3.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn4":
                            btn.Enabled = false;
                            pictureBox4.Visible = true;
                            pictureBox4.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn5":
                            btn.Enabled = false;
                            pictureBox5.Visible = true;
                            pictureBox5.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn6":
                            btn.Enabled = false;
                            pictureBox6.Visible = true;
                            pictureBox6.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn7":
                            btn.Enabled = false;
                            pictureBox7.Visible = true;
                            pictureBox7.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn8":
                            btn.Enabled = false;
                            pictureBox8.Visible = true;
                            pictureBox8.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                        case "btn9":
                            btn.Enabled = false;
                            pictureBox9.Visible = true;
                            pictureBox9.Image = MOAssignment1.Properties.Resources.XVermelho;
                            break;
                    }
                    //add to the array what is inside the button in the same index in the array
                    _text[buttonIndex - 1] = "X";
                    round = false;
                    ChecagemPlayer(1);
                }
                else
                {//check witch is the buttom to add the image in the img Box for O
                    string buttanNameForO = btn.Name;

                    switch (buttanNameForO)
                    {
                        case "btn1":

                            btn.Enabled = false;
                            pictureBox1.Visible = true;
                            pictureBox1.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn2":
                            btn.Enabled = false;
                            pictureBox2.Visible = true;
                            pictureBox2.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn3":
                            btn.Enabled = false;
                            pictureBox3.Visible = true;
                            pictureBox3.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn4":
                            btn.Enabled = false;
                            pictureBox4.Visible = true;
                            pictureBox4.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn5":
                            btn.Enabled = false;
                            pictureBox5.Visible = true;
                            pictureBox5.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn6":
                            btn.Enabled = false;
                            pictureBox6.Visible = true;
                            pictureBox6.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn7":
                            btn.Enabled = false;
                            pictureBox7.Visible = true;
                            pictureBox7.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn8":
                            btn.Enabled = false;
                            pictureBox8.Visible = true;
                            pictureBox8.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                        case "btn9":
                            btn.Enabled = false;
                            pictureBox9.Visible = true;
                            pictureBox9.Image = MOAssignment1.Properties.Resources.circulo2;
                            break;
                    }
                    //add to the array what is inside the button in the same index in the array
                    _text[buttonIndex - 1] = "O";
                    round = true;
                    ChecagemPlayer(2);
                }
            }
        }
        //method the cleck who is the winner 
        void ChecagemPlayer(int player)
        {
            string helper;

            if (player == 1)
            {
                helper = "X";
            }
            else
            {
                helper = "O";
            }
            //check is there is an winner in the horizontal 
            for (int horizontal = 0; horizontal <= maxStartingIndex; horizontal += nextRow)
            {
                if (helper == _text[horizontal])
                {
                    if (_text[horizontal] == _text[horizontal + 1]
                        && _text[horizontal] == _text[horizontal + 2])
                    {
                        MessageBox.Show($"{_text[horizontal]} is the winner!");
                        endGame = true;
                        break;
                    }
                }
            }
            //check is there is an winner in the vertical

            for (int vertical = 0; vertical <= 2; vertical += 1)
            {
                if (helper == _text[vertical])
                {
                    if (_text[vertical] == _text[vertical + 3]
                        && _text[vertical] == _text[vertical + 6])
                    {
                        MessageBox.Show($"{_text[vertical]} is the winner!");
                        endGame = true;
                        break;
                    }
                }
            }
            //check is there is an winner in the diagonal 
            if ((_text[0]) == helper)
            {
                if (_text[0] == _text[4] && _text[0] == _text[8])
                {
                    MessageBox.Show($"{helper} is the winner!");
                    endGame = true;

                }
            }
            if (_text[2] == helper)
            {
                if (_text[2] == _text[4] && _text[2] == _text[6])
                {
                    MessageBox.Show($"{helper} is the winner!");
                    endGame = true;

                }
            }
            // checking if it is the end of the game
            if (endGame)
            { 
                ResetGame();
                return;
            }
            // checking if it is the end of the game and cgecking if there is a tie
            if (!endGame && !_text.Contains(""))
            {
                
                MessageBox.Show("Its is a tie!");
                ResetGame();
                return;
            }
        }
        //method to reset the game
        private void ResetGame()
        {
            round = true;
            endGame = false;

            for (int i = 0; i < _text.Length; i++)
            {
                _text[i] = "";
            }

            btn1.Text = "";
            btn1.Enabled = true;
            btn2.Text = "";
            btn2.Enabled = true;
            btn3.Text = "";
            btn3.Enabled = true;
            btn4.Text = "";
            btn4.Enabled = true;
            btn5.Text = "";
            btn5.Enabled = true;
            btn6.Text = "";
            btn6.Enabled = true;
            btn7.Text = "";
            btn7.Enabled = true;
            btn8.Text = "";
            btn8.Enabled = true;
            btn9.Text = "";
            btn9.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private int nextRow = 3;
        private int maxStartingIndex = 6;
        private bool round = true;
        private bool endGame = false;
        private string[] _text = new string[9] { "", "", "", "", "", "", "", "", "" };
       
    }
}