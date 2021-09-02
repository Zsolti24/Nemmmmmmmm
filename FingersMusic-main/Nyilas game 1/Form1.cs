using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Nyilas_game_1
{
    public partial class Form1 : Form
    {

        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("i.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            MessageBox.Show("asd");
            timer1.Enabled = Enabled;
        }
    }
}

