namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            roundsLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoLabel = new Label();
            scoreBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(21, 18);
            headerLabel.Margin = new Padding(5, 0, 5, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(245, 18);
            tournamentNameLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(150, 50);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundsLabel
            // 
            roundsLabel.AutoSize = true;
            roundsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundsLabel.ForeColor = SystemColors.MenuHighlight;
            roundsLabel.Location = new Point(21, 102);
            roundsLabel.Margin = new Padding(5, 0, 5, 0);
            roundsLabel.Name = "roundsLabel";
            roundsLabel.Size = new Size(94, 37);
            roundsLabel.TabIndex = 10;
            roundsLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(125, 101);
            roundDropDown.Margin = new Padding(5, 6, 5, 6);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(270, 38);
            roundDropDown.TabIndex = 15;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedCheckBox
            // 
            unplayedCheckBox.AutoSize = true;
            unplayedCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedCheckBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedCheckBox.Location = new Point(162, 166);
            unplayedCheckBox.Margin = new Padding(5, 6, 5, 6);
            unplayedCheckBox.Name = "unplayedCheckBox";
            unplayedCheckBox.Size = new Size(165, 34);
            unplayedCheckBox.TabIndex = 16;
            unplayedCheckBox.Text = "Unplayed Only";
            unplayedCheckBox.UseVisualStyleBackColor = true;
            unplayedCheckBox.CheckedChanged += unplayedCheckBox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(21, 212);
            matchupListBox.Margin = new Padding(5, 6, 5, 6);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(374, 302);
            matchupListBox.TabIndex = 19;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneLabel.Location = new Point(484, 212);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(165, 37);
            teamOneLabel.TabIndex = 20;
            teamOneLabel.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(484, 267);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 21;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(572, 269);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(111, 35);
            teamOneScoreValue.TabIndex = 22;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(572, 416);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(111, 35);
            teamTwoScoreValue.TabIndex = 25;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(484, 414);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(82, 37);
            teamTwoScoreLabel.TabIndex = 24;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoLabel.Location = new Point(484, 359);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(165, 37);
            teamTwoLabel.TabIndex = 23;
            teamTwoLabel.Text = "<team two>";
            // 
            // scoreBtn
            // 
            scoreBtn.FlatAppearance.BorderColor = Color.Silver;
            scoreBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreBtn.FlatStyle = FlatStyle.Flat;
            scoreBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreBtn.ForeColor = SystemColors.MenuHighlight;
            scoreBtn.Location = new Point(726, 332);
            scoreBtn.Name = "scoreBtn";
            scoreBtn.Size = new Size(145, 49);
            scoreBtn.TabIndex = 26;
            scoreBtn.Text = "Score";
            scoreBtn.UseVisualStyleBackColor = true;
            scoreBtn.Click += scoreBtn_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 547);
            Controls.Add(scoreBtn);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundsLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameLabel;
        private Label roundsLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedCheckBox;
        private ListBox matchupListBox;
        private Label teamOneLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Button scoreBtn;
    }
}