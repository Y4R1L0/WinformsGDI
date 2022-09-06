using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Maze
{
    public partial class Form1 : Form
    {
        Labirint labirint;
        SoundPlayer MedKitSound = new SoundPlayer(@"C:\2\MedKit.wav");
        SoundPlayer MedalPickSound = new SoundPlayer(@"C:\2\MedalPick.wav");
        SoundPlayer music = new SoundPlayer(@"C:\2\music.wav"); 
        bool musicButtonPressed = true;
        bool soundButtonPressed = true;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
            music.PlayLooping();
            buttonMusic.BackColor = Color.LightGreen; 
            buttonSound.BackColor = Color.LightGreen;
        }

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame() {
            Labirint l = new Labirint(this, 40, 20);
            l.Show();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, System.EventArgs e)
        {
            if(progressBarHealth.Value >= 75)
            {
                progressBarHealth.ForeColor = Color.Green;
            }
            if (progressBarHealth.Value >= 35)
            {
                progressBarHealth.ForeColor = Color.Yellow;
            }
            if(progressBarHealth.Value > 0)
            {
                progressBarHealth.ForeColor = Color.Red;
            }
            
        }

        private void buttonMusic_Click(object sender, System.EventArgs e)
        {
            if (musicButtonPressed)
            {
                musicButtonPressed = false;
                buttonMusic.BackColor = Color.FromArgb(255, 255, 100, 100); ;
                music.Stop();
            }
            else
            {
                musicButtonPressed = true;
                buttonMusic.BackColor = Color.LightGreen;
                music.PlayLooping();
            }
        }

        private void buttonSound_Click(object sender, System.EventArgs e)
        {
            if (soundButtonPressed)
            {
                soundButtonPressed = false;
                buttonSound.BackColor = Color.FromArgb(255, 255, 100, 100); ; 
            }
            else
            {
                soundButtonPressed = true;
                buttonSound.BackColor = Color.LightGreen; 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                labirint.Move(MazeObject.MoveDirection.Up);
            }
            else if (e.KeyCode == Keys.S)
            {
                labirint.Move(MazeObject.MoveDirection.Down);
            }
            else if (e.KeyCode == Keys.A)
            {
                labirint.Move(MazeObject.MoveDirection.Left);
            }

            else if (e.KeyCode == Keys.D)
            {
                labirint.Move(MazeObject.MoveDirection.Right);
            }
        }
    }
}
