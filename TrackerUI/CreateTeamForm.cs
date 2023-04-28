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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModal> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModal> selectedTeamMembers = new List<PersonModal>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModal { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModal { FirstName = "Megan", LastName = "Jim" });

            selectedTeamMembers.Add(new PersonModal { FirstName = "Megan", LastName = "john" });
            selectedTeamMembers.Add(new PersonModal { FirstName = "Jimmy", LastName = "Buffet" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";


        }

        private void createMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModal p = new PersonModal();
                p.FirstName = FirstNameValue.Text;
                p.LastName = lastnameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = phoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                FirstNameValue.Text = "";
                lastnameValue.Text = "";
                emailValue.Text = "";
                phoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastnameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (phoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addTeamMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModal p = (PersonModal)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeSelectedMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModal p = (PersonModal)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void createTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
