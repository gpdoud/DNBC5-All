using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplifiedCrapsForm {
    public partial class SimpleCrapsForm : Form {
        public SimpleCrapsForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            SimpliedCraps.Roll();
            GameStatus.Text = SimpliedCraps.GameStatus.ToString();
            LastRoll.Text = SimpliedCraps.LastRoll.ToString();
            Point.Text = SimpliedCraps.Point.ToString();
            Games.Text = SimpliedCraps.GamesPlayed.ToString();
            Wins.Text = SimpliedCraps.Wins.ToString();
            Loses.Text = SimpliedCraps.Loses.ToString();
        }


    }
}
