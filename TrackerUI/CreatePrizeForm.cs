using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModal modal = new PrizeModal(placeNumberValue.Text, placeNameTextBox.Text, prizeAmountTextBox.Text, prizePercentageTextBox.Text);

               
               GlobalConfig.Connection.CreatePrize(modal);

                callingForm.PrizeComplete(modal);

                //placeNumberValue.Text = "";
                //placeNameTextBox.Text = "";
                //prizeAmountTextBox.Text = "0";
                //prizePercentageTextBox.Text = "0";
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information, please try agian!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            

            return output;
        }
    }
}
