namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamBtn = new Button();
            createPrizeBtn = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPrizeBtn = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPlayerBtn = new Button();
            createTournamentBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(27, 25);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(27, 135);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(305, 35);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(27, 95);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(163, 198);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 35);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            entryFeeValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(39, 198);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            entryFeeLabel.Click += teamonescoreLabel_Click;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(39, 305);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(305, 38);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(39, 265);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(225, 271);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamBtn
            // 
            addTeamBtn.FlatAppearance.BorderColor = Color.Silver;
            addTeamBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamBtn.FlatStyle = FlatStyle.Flat;
            addTeamBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamBtn.ForeColor = SystemColors.MenuHighlight;
            addTeamBtn.Location = new Point(65, 363);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(241, 49);
            addTeamBtn.TabIndex = 16;
            addTeamBtn.Text = "Add Team";
            addTeamBtn.UseVisualStyleBackColor = true;
            // 
            // createPrizeBtn
            // 
            createPrizeBtn.FlatAppearance.BorderColor = Color.Silver;
            createPrizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeBtn.FlatStyle = FlatStyle.Flat;
            createPrizeBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeBtn.ForeColor = SystemColors.MenuHighlight;
            createPrizeBtn.Location = new Point(65, 445);
            createPrizeBtn.Name = "createPrizeBtn";
            createPrizeBtn.Size = new Size(241, 49);
            createPrizeBtn.TabIndex = 17;
            createPrizeBtn.Text = "Create Prize";
            createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(406, 135);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(321, 152);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(406, 95);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(198, 37);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPrizeBtn
            // 
            deleteSelectedPrizeBtn.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeBtn.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeBtn.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrizeBtn.Location = new Point(769, 380);
            deleteSelectedPrizeBtn.Name = "deleteSelectedPrizeBtn";
            deleteSelectedPrizeBtn.Size = new Size(130, 81);
            deleteSelectedPrizeBtn.TabIndex = 23;
            deleteSelectedPrizeBtn.Text = "Delete Selected";
            deleteSelectedPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(406, 302);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(85, 37);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(406, 342);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(321, 152);
            prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedPlayerBtn
            // 
            deleteSelectedPlayerBtn.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerBtn.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayerBtn.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPlayerBtn.Location = new Point(769, 176);
            deleteSelectedPlayerBtn.Name = "deleteSelectedPlayerBtn";
            deleteSelectedPlayerBtn.Size = new Size(130, 81);
            deleteSelectedPlayerBtn.TabIndex = 24;
            deleteSelectedPlayerBtn.Text = "Delete Selected";
            deleteSelectedPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentBtn
            // 
            createTournamentBtn.FlatAppearance.BorderColor = Color.Silver;
            createTournamentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentBtn.FlatStyle = FlatStyle.Flat;
            createTournamentBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentBtn.ForeColor = SystemColors.MenuHighlight;
            createTournamentBtn.Location = new Point(321, 568);
            createTournamentBtn.Name = "createTournamentBtn";
            createTournamentBtn.Size = new Size(241, 49);
            createTournamentBtn.TabIndex = 25;
            createTournamentBtn.Text = "Create Tournament";
            createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 637);
            Controls.Add(createTournamentBtn);
            Controls.Add(deleteSelectedPlayerBtn);
            Controls.Add(deleteSelectedPrizeBtn);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeBtn);
            Controls.Add(addTeamBtn);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamBtn;
        private Button createPrizeBtn;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPrizeBtn;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedPlayerBtn;
        private Button createTournamentBtn;
    }
}