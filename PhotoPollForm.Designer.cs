namespace PhotoPoll
{
    partial class PhotoPollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.person1PictureBox = new System.Windows.Forms.PictureBox();
            this.person2PictureBox = new System.Windows.Forms.PictureBox();
            this.winnerPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.person2VoteCountLabel = new System.Windows.Forms.Label();
            this.person1VoteCountLabel = new System.Windows.Forms.Label();
            this.castVoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.person2TotalVotesLabel = new System.Windows.Forms.Label();
            this.person1TotalVotesLabel = new System.Windows.Forms.Label();
            this.person1RadioButton = new System.Windows.Forms.RadioButton();
            this.person2RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.person1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // person1PictureBox
            // 
            this.person1PictureBox.Image = global::PhotoPoll.Properties.Resources.alluarjun;
            this.person1PictureBox.Location = new System.Drawing.Point(44, 132);
            this.person1PictureBox.Name = "person1PictureBox";
            this.person1PictureBox.Size = new System.Drawing.Size(259, 194);
            this.person1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.person1PictureBox.TabIndex = 0;
            this.person1PictureBox.TabStop = false;
            // 
            // person2PictureBox
            // 
            this.person2PictureBox.Image = global::PhotoPoll.Properties.Resources.ramcharan;
            this.person2PictureBox.Location = new System.Drawing.Point(356, 132);
            this.person2PictureBox.Name = "person2PictureBox";
            this.person2PictureBox.Size = new System.Drawing.Size(275, 183);
            this.person2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.person2PictureBox.TabIndex = 1;
            this.person2PictureBox.TabStop = false;
            // 
            // winnerPictureBox
            // 
            this.winnerPictureBox.Location = new System.Drawing.Point(763, 132);
            this.winnerPictureBox.Name = "winnerPictureBox";
            this.winnerPictureBox.Size = new System.Drawing.Size(259, 194);
            this.winnerPictureBox.TabIndex = 2;
            this.winnerPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(40, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 29);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Select a Best Actor Nominee";
            // 
            // person2VoteCountLabel
            // 
            this.person2VoteCountLabel.AutoSize = true;
            this.person2VoteCountLabel.Location = new System.Drawing.Point(365, 367);
            this.person2VoteCountLabel.Name = "person2VoteCountLabel";
            this.person2VoteCountLabel.Size = new System.Drawing.Size(181, 20);
            this.person2VoteCountLabel.TabIndex = 4;
            this.person2VoteCountLabel.Text = "Ram Charan vote count:";
            // 
            // person1VoteCountLabel
            // 
            this.person1VoteCountLabel.AutoSize = true;
            this.person1VoteCountLabel.Location = new System.Drawing.Point(54, 367);
            this.person1VoteCountLabel.Name = "person1VoteCountLabel";
            this.person1VoteCountLabel.Size = new System.Drawing.Size(158, 20);
            this.person1VoteCountLabel.TabIndex = 5;
            this.person1VoteCountLabel.Text = "Allu Arjun vote count:";
            // 
            // castVoteButton
            // 
            this.castVoteButton.Location = new System.Drawing.Point(44, 406);
            this.castVoteButton.Name = "castVoteButton";
            this.castVoteButton.Size = new System.Drawing.Size(587, 54);
            this.castVoteButton.TabIndex = 6;
            this.castVoteButton.Text = "Vote for Selected Actor";
            this.castVoteButton.UseVisualStyleBackColor = true;
            this.castVoteButton.Click += new System.EventHandler(this.castVoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(763, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 54);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // person2TotalVotesLabel
            // 
            this.person2TotalVotesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.person2TotalVotesLabel.Location = new System.Drawing.Point(580, 367);
            this.person2TotalVotesLabel.Name = "person2TotalVotesLabel";
            this.person2TotalVotesLabel.Size = new System.Drawing.Size(51, 20);
            this.person2TotalVotesLabel.TabIndex = 8;
            // 
            // person1TotalVotesLabel
            // 
            this.person1TotalVotesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.person1TotalVotesLabel.Location = new System.Drawing.Point(253, 367);
            this.person1TotalVotesLabel.Name = "person1TotalVotesLabel";
            this.person1TotalVotesLabel.Size = new System.Drawing.Size(51, 20);
            this.person1TotalVotesLabel.TabIndex = 9;
            // 
            // person1RadioButton
            // 
            this.person1RadioButton.AutoSize = true;
            this.person1RadioButton.Location = new System.Drawing.Point(310, 222);
            this.person1RadioButton.Name = "person1RadioButton";
            this.person1RadioButton.Size = new System.Drawing.Size(38, 24);
            this.person1RadioButton.TabIndex = 10;
            this.person1RadioButton.TabStop = true;
            this.person1RadioButton.Text = " ";
            this.person1RadioButton.UseVisualStyleBackColor = true;
            this.person1RadioButton.CheckedChanged += new System.EventHandler(this.person1RadioButton_CheckedChanged);
            // 
            // person2RadioButton
            // 
            this.person2RadioButton.AutoSize = true;
            this.person2RadioButton.Location = new System.Drawing.Point(638, 221);
            this.person2RadioButton.Name = "person2RadioButton";
            this.person2RadioButton.Size = new System.Drawing.Size(38, 24);
            this.person2RadioButton.TabIndex = 11;
            this.person2RadioButton.TabStop = true;
            this.person2RadioButton.Text = " ";
            this.person2RadioButton.UseVisualStyleBackColor = true;
            // 
            // PhotoPollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 720);
            this.Controls.Add(this.person2RadioButton);
            this.Controls.Add(this.person1RadioButton);
            this.Controls.Add(this.person1TotalVotesLabel);
            this.Controls.Add(this.person2TotalVotesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.castVoteButton);
            this.Controls.Add(this.person1VoteCountLabel);
            this.Controls.Add(this.person2VoteCountLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.winnerPictureBox);
            this.Controls.Add(this.person2PictureBox);
            this.Controls.Add(this.person1PictureBox);
            this.Name = "PhotoPollForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.person1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox person1PictureBox;
        private System.Windows.Forms.PictureBox person2PictureBox;
        private System.Windows.Forms.PictureBox winnerPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label person2VoteCountLabel;
        private System.Windows.Forms.Label person1VoteCountLabel;
        private System.Windows.Forms.Button castVoteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label person2TotalVotesLabel;
        private System.Windows.Forms.Label person1TotalVotesLabel;
        private System.Windows.Forms.RadioButton person1RadioButton;
        private System.Windows.Forms.RadioButton person2RadioButton;
    }
}

