namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            addTeamMemberBtn = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeammemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberBtn = new Button();
            phoneValue = new TextBox();
            phoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastnameValue = new TextBox();
            lastNameLabel = new Label();
            FirstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberBtn = new Button();
            createTeamBtn = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(33, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(213, 50);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(33, 89);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 10;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(33, 129);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(437, 35);
            teamNameValue.TabIndex = 11;
            // 
            // addTeamMemberBtn
            // 
            addTeamMemberBtn.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberBtn.FlatStyle = FlatStyle.Flat;
            addTeamMemberBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberBtn.ForeColor = SystemColors.MenuHighlight;
            addTeamMemberBtn.Location = new Point(117, 289);
            addTeamMemberBtn.Name = "addTeamMemberBtn";
            addTeamMemberBtn.Size = new Size(241, 49);
            addTeamMemberBtn.TabIndex = 19;
            addTeamMemberBtn.Text = "Add Member";
            addTeamMemberBtn.UseVisualStyleBackColor = true;
            addTeamMemberBtn.Click += addTeamMemberBtn_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(33, 229);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(437, 38);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeammemberLabel
            // 
            selectTeammemberLabel.AutoSize = true;
            selectTeammemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeammemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeammemberLabel.Location = new Point(33, 189);
            selectTeammemberLabel.Name = "selectTeammemberLabel";
            selectTeammemberLabel.Size = new Size(263, 37);
            selectTeammemberLabel.TabIndex = 17;
            selectTeammemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberBtn);
            addNewMemberGroupBox.Controls.Add(phoneValue);
            addNewMemberGroupBox.Controls.Add(phoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastnameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(FirstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = Color.FromArgb(51, 153, 255);
            addNewMemberGroupBox.Location = new Point(33, 374);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(437, 334);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberBtn
            // 
            createMemberBtn.FlatAppearance.BorderColor = Color.Silver;
            createMemberBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberBtn.FlatStyle = FlatStyle.Flat;
            createMemberBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberBtn.ForeColor = SystemColors.MenuHighlight;
            createMemberBtn.Location = new Point(84, 270);
            createMemberBtn.Name = "createMemberBtn";
            createMemberBtn.Size = new Size(241, 49);
            createMemberBtn.TabIndex = 31;
            createMemberBtn.Text = "Create Member";
            createMemberBtn.UseVisualStyleBackColor = true;
            createMemberBtn.Click += createMemberBtn_Click;
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(152, 207);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(211, 43);
            phoneValue.TabIndex = 30;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.ForeColor = SystemColors.MenuHighlight;
            phoneLabel.Location = new Point(5, 204);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(138, 37);
            phoneLabel.TabIndex = 29;
            phoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(152, 157);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(211, 43);
            emailValue.TabIndex = 28;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(5, 154);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email";
            // 
            // lastnameValue
            // 
            lastnameValue.Location = new Point(152, 97);
            lastnameValue.Name = "lastnameValue";
            lastnameValue.Size = new Size(211, 43);
            lastnameValue.TabIndex = 26;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(5, 94);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 25;
            lastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            FirstNameValue.Location = new Point(152, 47);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(211, 43);
            FirstNameValue.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(5, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 23;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(509, 134);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(321, 572);
            teamMembersListBox.TabIndex = 21;
            // 
            // removeSelectedMemberBtn
            // 
            removeSelectedMemberBtn.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMemberBtn.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMemberBtn.ForeColor = SystemColors.MenuHighlight;
            removeSelectedMemberBtn.Location = new Point(859, 405);
            removeSelectedMemberBtn.Name = "removeSelectedMemberBtn";
            removeSelectedMemberBtn.Size = new Size(130, 81);
            removeSelectedMemberBtn.TabIndex = 25;
            removeSelectedMemberBtn.Text = "Remove Selected";
            removeSelectedMemberBtn.UseVisualStyleBackColor = true;
            removeSelectedMemberBtn.Click += removeSelectedMemberBtn_Click;
            // 
            // createTeamBtn
            // 
            createTeamBtn.FlatAppearance.BorderColor = Color.Silver;
            createTeamBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamBtn.FlatStyle = FlatStyle.Flat;
            createTeamBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamBtn.ForeColor = SystemColors.MenuHighlight;
            createTeamBtn.Location = new Point(349, 756);
            createTeamBtn.Name = "createTeamBtn";
            createTeamBtn.Size = new Size(241, 49);
            createTeamBtn.TabIndex = 26;
            createTeamBtn.Text = "Create Team";
            createTeamBtn.UseVisualStyleBackColor = true;
            createTeamBtn.Click += createTeamBtn_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1017, 831);
            Controls.Add(createTeamBtn);
            Controls.Add(removeSelectedMemberBtn);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberBtn);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeammemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Button addTeamMemberBtn;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeammemberLabel;
        private GroupBox addNewMemberGroupBox;
        private Button createMemberBtn;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastnameValue;
        private Label lastNameLabel;
        private TextBox FirstNameValue;
        private Label firstNameLabel;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberBtn;
        private Button createTeamBtn;
    }
}