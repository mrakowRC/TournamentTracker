namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            prizeAmountTextBox = new TextBox();
            PrizeAmountLabel = new Label();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeBtn = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 50);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(201, 90);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(212, 23);
            placeNumberValue.TabIndex = 13;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(12, 76);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 12;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Location = new Point(201, 139);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(212, 23);
            placeNameTextBox.TabIndex = 15;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(12, 125);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 14;
            placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Location = new Point(201, 189);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(212, 23);
            prizeAmountTextBox.TabIndex = 17;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            PrizeAmountLabel.Location = new Point(12, 175);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(176, 37);
            PrizeAmountLabel.TabIndex = 16;
            PrizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Location = new Point(230, 292);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(212, 23);
            prizePercentageTextBox.TabIndex = 19;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(12, 278);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 18;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(155, 232);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(78, 37);
            orLabel.TabIndex = 20;
            orLabel.Text = "- or -";
            // 
            // createPrizeBtn
            // 
            createPrizeBtn.FlatAppearance.BorderColor = Color.Silver;
            createPrizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeBtn.FlatStyle = FlatStyle.Flat;
            createPrizeBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeBtn.ForeColor = SystemColors.MenuHighlight;
            createPrizeBtn.Location = new Point(90, 352);
            createPrizeBtn.Name = "createPrizeBtn";
            createPrizeBtn.Size = new Size(241, 49);
            createPrizeBtn.TabIndex = 21;
            createPrizeBtn.Text = "Create Prize";
            createPrizeBtn.UseVisualStyleBackColor = true;
            createPrizeBtn.Click += createPrizeBtn_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(501, 450);
            Controls.Add(createPrizeBtn);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Name = "CreatePrizeForm";
            Text = "CreatePrize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private TextBox prizeAmountTextBox;
        private Label PrizeAmountLabel;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeBtn;
    }
}