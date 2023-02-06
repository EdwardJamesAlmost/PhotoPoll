using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoPoll
{
    public partial class PhotoPollForm : Form
    {
        // global vote count vars
        int person1VoteTotal, person2VoteTotal = 0;

        public PhotoPollForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void person1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person2RadioButton.Checked = false;
        }


        private void castVoteButton_Click(object sender, EventArgs e)
        {
            winnerPictureBox.Visible = true;
            var person1Img = Properties.Resources.alluarjun;
            var person2Img = Properties.Resources.ramcharan;

            if (person1RadioButton.Checked) {
                person1VoteTotal = person1VoteTotal + 1;
                person1TotalVotesLabel.Text = Convert.ToString(person1VoteTotal);

            }
            else if (person2RadioButton.Checked) {
                person2VoteTotal = person2VoteTotal + 1;
                person2TotalVotesLabel.Text = Convert.ToString(person2VoteTotal);

            }

            if (person1VoteTotal > person2VoteTotal)
            {
                winnerPictureBox.Image = person1Img;
            }
            else if (person2VoteTotal > person1VoteTotal)
            {
                winnerPictureBox.Image = person2Img;
            }
            else { winnerPictureBox.Visible = false; }


            person1RadioButton.Checked = false;
            person2RadioButton.Checked = false;

        }

    }
}
