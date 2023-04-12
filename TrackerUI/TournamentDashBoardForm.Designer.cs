namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentBtn = new Button();
            createTournamentBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(281, 23);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(385, 50);
            headerLabel.TabIndex = 4;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(281, 164);
            loadExistingTournamentDropDown.Margin = new Padding(5, 6, 5, 6);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(385, 38);
            loadExistingTournamentDropDown.TabIndex = 16;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingTournamentLabel.Location = new Point(315, 100);
            loadExistingTournamentLabel.Margin = new Padding(5, 0, 5, 0);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(322, 37);
            loadExistingTournamentLabel.TabIndex = 17;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentBtn
            // 
            loadTournamentBtn.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentBtn.FlatStyle = FlatStyle.Flat;
            loadTournamentBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentBtn.ForeColor = SystemColors.MenuHighlight;
            loadTournamentBtn.Location = new Point(350, 229);
            loadTournamentBtn.Name = "loadTournamentBtn";
            loadTournamentBtn.Size = new Size(241, 49);
            loadTournamentBtn.TabIndex = 35;
            loadTournamentBtn.Text = "Load Tournament";
            loadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentBtn
            // 
            createTournamentBtn.FlatAppearance.BorderColor = Color.Silver;
            createTournamentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentBtn.FlatStyle = FlatStyle.Flat;
            createTournamentBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentBtn.ForeColor = SystemColors.MenuHighlight;
            createTournamentBtn.Location = new Point(336, 305);
            createTournamentBtn.Name = "createTournamentBtn";
            createTournamentBtn.Size = new Size(269, 84);
            createTournamentBtn.TabIndex = 36;
            createTournamentBtn.Text = "Create Tournament";
            createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1371, 900);
            Controls.Add(createTournamentBtn);
            Controls.Add(loadTournamentBtn);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashBoardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentBtn;
        private Button createTournamentBtn;
    }
}