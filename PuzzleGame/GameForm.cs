using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class GameForm : Form
    {
        int time = 0;
        int score = 0;
        int[,] tab = new int[4, 4];
        public GameForm()
        {
            InitializeComponent();
            Box1.Click += new System.EventHandler(PicClick);
            Box2.Click += new System.EventHandler(PicClick);
            Box3.Click += new System.EventHandler(PicClick);
            Box4.Click += new System.EventHandler(PicClick);
            Box5.Click += new System.EventHandler(PicClick);
            Box6.Click += new System.EventHandler(PicClick);
            Box7.Click += new System.EventHandler(PicClick);
            Box8.Click += new System.EventHandler(PicClick);
            Box9.Click += new System.EventHandler(PicClick);
            Box10.Click += new System.EventHandler(PicClick);
            Box11.Click += new System.EventHandler(PicClick);
            Box12.Click += new System.EventHandler(PicClick);
            Box13.Click += new System.EventHandler(PicClick);
            Box14.Click += new System.EventHandler(PicClick);
            Box15.Click += new System.EventHandler(PicClick);
            Box16.Click += new System.EventHandler(PicClick);
            Reset();

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            switch (SendBtn.Text)
            {
                case "Play":
                    Box1.Enabled = true;
                    Box2.Enabled = true;
                    Box3.Enabled = true;
                    Box4.Enabled = true;
                    Box5.Enabled = true;
                    Box6.Enabled = true;
                    Box7.Enabled = true;
                    Box8.Enabled = true;
                    Box9.Enabled = true;
                    Box10.Enabled = true;
                    Box11.Enabled = true;
                    Box12.Enabled = true;
                    Box13.Enabled = true;
                    Box14.Enabled = true;
                    Box15.Enabled = true;
                    Box16.Enabled = true;
                    timer1.Enabled = true;
                    Rand();
                    SendBtn.Text = "Send";
                    SendBtn.Enabled = false;
                    break;
                case "Send":
                    Decis();
                    SendBtn.Text = "Play";
                    SendBtn.Enabled = true;
                    break;
            }
        }
        private void Rand()
        {
            Random _r = new Random();
            HashSet<int> IdenCol = new HashSet<int>();
            while (IdenCol.Count < 4) IdenCol.Add(_r.Next(1, 5));
            int[] IdenColArray = IdenCol.ToArray();
            for(int i = 0; i < 4; i++)
            {
                int x = IdenColArray[i];
                int y = _r.Next(2, 4);
                switch (i)
                {
                    case 0:
                        if (x == 1) { Box1.Load("Res/box" + y.ToString() + ".png"); Box1.Enabled = false; tab[0, 0] = y; }
                        else if (x == 2) { Box2.Load("Res/box" + y.ToString() + ".png"); Box2.Enabled = false; tab[0, 1] = y; }
                        else if (x == 3) { Box3.Load("Res/box" + y.ToString() + ".png"); Box3.Enabled = false; tab[0, 2] = y; }
                        else if (x == 4) { Box4.Load("Res/box" + y.ToString() + ".png"); Box4.Enabled = false; tab[0, 3] = y; }
                        break;
                    case 1:
                        if (x == 1) { Box5.Load("Res/box" + y.ToString() + ".png"); Box5.Enabled = false; tab[1, 0] = y; }
                        else if (x == 2) { Box6.Load("Res/box" + y.ToString() + ".png"); Box6.Enabled = false; tab[1, 1] = y; }
                        else if (x == 3) { Box7.Load("Res/box" + y.ToString() + ".png"); Box7.Enabled = false; tab[1, 2] = y; }
                        else if (x == 4) { Box8.Load("Res/box" + y.ToString() + ".png"); Box8.Enabled = false; tab[1, 3] = y; }
                        break;
                    case 2:
                        if (x == 1) { Box9.Load("Res/box" + y.ToString() + ".png"); Box9.Enabled = false; tab[2, 0] = y; }
                        else if (x == 2) { Box10.Load("Res/box" + y.ToString() + ".png"); Box10.Enabled = false; tab[2, 1] = y; }
                        else if (x == 3) { Box11.Load("Res/box" + y.ToString() + ".png"); Box11.Enabled = false; tab[2, 2] = y; }
                        else if (x == 4) { Box12.Load("Res/box" + y.ToString() + ".png"); Box12.Enabled = false; tab[2, 3] = y; }
                        break;
                    case 3:
                        if (x == 1) { Box13.Load("Res/box" + y.ToString() + ".png"); Box13.Enabled = false; tab[3, 0] = y; }
                        else if (x == 2) { Box14.Load("Res/box" + y.ToString() + ".png"); Box14.Enabled = false; tab[3, 1] = y; }
                        else if (x == 3) { Box15.Load("Res/box" + y.ToString() + ".png"); Box15.Enabled = false; tab[3, 2] = y; }
                        else if (x == 4) { Box16.Load("Res/box" + y.ToString() + ".png"); Box16.Enabled = false; tab[3, 3] = y; }
                        break;

                }
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            TimeLabel.Text = "Time : " + time.ToString();
        }
        private void PicClick(object sender,EventArgs e)
        {
            int Current = 0;
            PictureBox SelectPic = (PictureBox)sender;
            switch (SelectPic.ImageLocation.ToString())
            {
                case "Res/box1.png":
                    SelectPic.Load("Res/box2.png");
                    Current = 2;
                    break;
                case "Res/box2.png":
                    SelectPic.Load("Res/box3.png");
                    Current = 3;
                    break;
                case "Res/box3.png":
                    SelectPic.Load("Res/box1.png");
                    Current = 1;
                    break;
            }
            switch (SelectPic.Name.ToString())
            {
                case "Box1":
                    tab[0, 0] = Current;
                    break;
                case "Box2":
                    tab[0, 1] = Current;
                    break;
                case "Box3":
                    tab[0, 2] = Current;
                    break;
                case "Box4":
                    tab[0, 3] = Current;
                    break;
                case "Box5":
                    tab[1, 0] = Current;
                    break;
                case "Box6":
                    tab[1, 1] = Current;
                    break;
                case "Box7":
                    tab[1, 2] = Current;
                    break;
                case "Box8":
                    tab[1, 3] = Current;
                    break;
                case "Box9":
                    tab[2, 0] = Current;
                    break;
                case "Box10":
                    tab[2, 1] = Current;
                    break;
                case "Box11":
                    tab[2, 2] = Current;
                    break;
                case "Box12":
                    tab[2, 3] = Current;
                    break;
                case "Box13":
                    tab[3, 0] = Current;
                    break;
                case "Box14":
                    tab[3, 1] = Current;
                    break;
                case "Box15":
                    tab[3, 2] = Current;
                    break;
                case "Box16":
                    tab[3, 3] = Current;
                    break;
            }
            Check();
        }
        private void Check()
        {
            bool arg = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tab[i, j] == 1)
                    {
                        arg = false;
                        break;
                    }
                }
            }
            if (arg) SendBtn.Enabled = true;
            else SendBtn.Enabled = false;
        }
        private void Decis()
        {
            bool result = true;
            for (int i= 0; i < 4; i++)
            {
                int check_2_row = 0;
                int check_2_col = 0;
                int check_3_row = 0;
                int check_3_col = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (tab[i, j] == 2) check_2_row++;
                    if (tab[i, j] == 3) check_3_row++;
                    if (tab[j, i] == 2) check_2_col++;
                    if (tab[j, i] == 3) check_3_col++;
                }
                if (check_2_col != 2 || check_2_row != 2 || check_3_col != 2 || check_3_row != 2) { result = false;break; }
            }
            if(!result) Reset();
            else
            {
                score += 100 / time;
                ScoreLabel.Text = "Score : " + score.ToString() ;
                Reset();
                time = 0;
                TimeLabel.Text = "Time : " + time.ToString();
            }
        }
        private void Reset()
        {
            Box1.Load("Res/box1.png");
            Box2.Load("Res/box1.png");
            Box3.Load("Res/box1.png");
            Box4.Load("Res/box1.png");
            Box5.Load("Res/box1.png");
            Box6.Load("Res/box1.png");
            Box7.Load("Res/box1.png");
            Box8.Load("Res/box1.png");
            Box9.Load("Res/box1.png");
            Box10.Load("Res/box1.png");
            Box11.Load("Res/box1.png");
            Box12.Load("Res/box1.png");
            Box13.Load("Res/box1.png");
            Box14.Load("Res/box1.png");
            Box15.Load("Res/box1.png");
            Box16.Load("Res/box1.png");
            Box1.Enabled = false;
            Box2.Enabled = false;
            Box3.Enabled = false;
            Box4.Enabled = false;
            Box5.Enabled = false;
            Box6.Enabled = false;
            Box7.Enabled = false;
            Box8.Enabled = false;
            Box9.Enabled = false;
            Box10.Enabled = false;
            Box11.Enabled = false;
            Box12.Enabled = false;
            Box13.Enabled = false;
            Box14.Enabled = false;
            Box15.Enabled = false;
            Box16.Enabled = false;
            timer1.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tab[i, j] = 1;
                }
            }
        }
    }
}
