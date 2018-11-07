/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;  

        // random number generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You are lost in a forest";
            redLabel.Text = "Go North";
            blueLabel.Text = "Go South";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
               
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You are lost in a forest";
                    redLabel.Text = "Go North";
                    blueLabel.Text = "Go South";
                    break;
                case 1:
                    outputLabel.Text = "You arrive at a lake, Take a drink?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You fall into a pit and die";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Water is stagnant";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "There's a horse, do you ride it?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    outputLabel.Text = "You rode the horse and ride it to safety";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "The horse walks past and you die of loneliness";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
