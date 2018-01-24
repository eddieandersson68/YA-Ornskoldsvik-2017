using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL_V01
{
    public partial class Form1 : Form
    {
        Game g;
        List <Game> ListOfSavedGames = new List<Game>();
        GUI_Options GUI = new GUI_Options();
        public Form1()
        {
            InitializeComponent();
            CreateGrid();
        }

        private void CreateGrid()
        {
            var str = GameGrid_Panel.Size;
            str.Height = str.Width; //Fyrkantig

            Button b;
            int gridsize = 50;
            int buttonsize = str.Height / gridsize;

            int x = 0, y = 0;

            for (int i = 0; i < gridsize; i++)
            {
                for (int j = 0; j < gridsize; j++)
                {
                    Point templocation = new Point(x, y);

                    b = new Button
                    {
                        Parent = GameGrid_Panel,
                        Size = new Size(buttonsize, buttonsize),
                        Location = templocation
                    };
                    x += buttonsize;
                }

                x = 0;
                y += buttonsize;
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txbNameOfTheGame.Text != null)
            g = new Game (txbNameOfTheGame.Text);
            
            GUI.StartGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            GUI.StopGame();
            lstBxSavedGames.Items.Add(g);
            ListOfSavedGames.Add(g);
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            int LoadIndexNr;
            if (lstBxSavedGames.SelectedItem != null)
                LoadIndexNr = lstBxSavedGames.SelectedIndex - 1;


            GUI.LoadGame(LoadIndexNr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int indexNr;

            if (lstBxSavedGames.SelectedIndex == -1)
            {
                indexNr = lstBxSavedGames.SelectedIndex - 1;
            }
            else
            {
                indexNr = lstBxSavedGames.SelectedIndex;
               
                ListOfSavedGames.RemoveAt(indexNr);
               
            }
            
            //GUI.DeleteGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

