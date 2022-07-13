using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class Form1 : Form
    {
        User CurrentUser = new User("");
        User Mehmet = new User("Mehmet");
        User Jing = new User("Jing");
        User Mike = new User("Mike");
        User Babak = new User("Babak");
        User[] Users = new User[5];
      

        public Form1()
        {
            setUsers(ref Users);
            InitializeComponent();

        }
        private void setUsers(ref User[] Users)
        {
            Users[0] = CurrentUser;
            Users[1] = Mehmet;
            Users[2] = Jing;
            Users[3] = Mike;
            Users[4] = Babak;
        }

        private void ScheduleMeetingButton_Click(object sender, EventArgs e)
        {
            //Meeting meeting = new Meeting();
        }



        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Users.Length; i ++)
            {
                if (Users[i].getUserName() == SelectUserComboBox.SelectedItem.ToString())
                {
                    for (int j = 0; j < Users.Length; j ++)
                    {
                        if (Users[j].getUserName() == CurrentUserLabel.Text.ToString())
                        {
                            Users[j] = CurrentUser;
                            AttendeeListBox.Items.Remove(CurrentUser.getUserName());
                            AttendeeListComboBox.Items.Add(CurrentUser.getUserName());
                            
                        }
                    }
                    CurrentUser = Users[i];
                    CurrentUserLabel.Text = CurrentUser.getUserName();
                    AttendeeListBox.Items.Clear();
                    MeetingTimeListBox.ClearSelected();
                    AttendeeListBox.Items.Add(CurrentUser.getUserName());
                    AttendeeListComboBox.Items.Remove(CurrentUser.getUserName());
                    

                }
            }
        }


        private void AttendeAddButton_Click(object sender, EventArgs e)
        {
            AttendeeListBox.Items.Add(AttendeeListComboBox.SelectedItem.ToString());
            //Need validation so adds a attendee only once ;)
        }

        private void AttendeeRemoveButton_Click(object sender, EventArgs e)
        {
            AttendeeListBox.Items.Remove(AttendeeListBox.SelectedItem);
        }

        private void ExcAddButton_Click(object sender, EventArgs e)
        {

            CurrentUser.addExclusionSlot(ExcludedTimeSlotsListBox.SelectedItem.ToString());
            ExcludedTimeSlotsListBox.Items.Add(AvailiableTimeSlotsListBox.SelectedItem);
            AvailiableTimeSlotsListBox.Items.Remove(AvailiableTimeSlotsListBox.SelectedItem);
        }

        private void ExcRemoveButton_Click(object sender, EventArgs e)
        {
            CurrentUser.removeExclusionSlot(ExcludedTimeSlotsListBox.SelectedItem.ToString());
            AvailiableTimeSlotsListBox.Items.Add(ExcludedTimeSlotsListBox.SelectedItem);
            ExcludedTimeSlotsListBox.Items.Remove(ExcludedTimeSlotsListBox.SelectedItem);
        }

        private void PrefAddButton_Click(object sender, EventArgs e)
        {
            CurrentUser.addPreferredSlot(PreferredTimeSlotsListBox.SelectedItem.ToString());
            PreferredTimeSlotsListBox.Items.Add(AvailiableTimeSlotsListBox.SelectedItem);
            AvailiableTimeSlotsListBox.Items.Remove(AvailiableTimeSlotsListBox.SelectedItem);
        }

        private void PrefRemoveButton_Click(object sender, EventArgs e)
        {
            CurrentUser.removePreferredSlot(PreferredTimeSlotsListBox.SelectedItem.ToString());
            AvailiableTimeSlotsListBox.Items.Add(PreferredTimeSlotsListBox.SelectedItem);
            PreferredTimeSlotsListBox.Items.Remove(PreferredTimeSlotsListBox.SelectedItem);
        }
    }
}