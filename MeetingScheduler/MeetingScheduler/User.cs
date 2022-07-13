using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class User
    {
        private string UserName;
        private string[,] PreferredTimeSlots = new string[6,9];
        private string[,] ExcludedTimeSlots = new string[6,9];
        public User(String Name)
        {
            this.UserName = Name;
        }

        public String getUserName() { return UserName; }
        public void setUserName(String name) { UserName = name; }
        
        public void addExclusionSlot(String timeSlot)
        {
            int Day = (int)(DateTime.Today).DayOfWeek;
            ExcludedTimeSlots[Day - 1, TimeSlotIndex(timeSlot)] = timeSlot;
        }

        public void removeExclusionSlot(String timeSlot)
        {
            int Day = (int)(DateTime.Today).DayOfWeek;
            ExcludedTimeSlots[Day - 1, TimeSlotIndex(timeSlot)] = null;
        }

        public void addPreferredSlot(String timeSlot)
        {
            int Day = (int)(DateTime.Today).DayOfWeek;
            PreferredTimeSlots[Day - 1, TimeSlotIndex(timeSlot)] = timeSlot;
        }

        public void removePreferredSlot(String timeSlot)
        {
            int Day = (int)(DateTime.Today).DayOfWeek;
            PreferredTimeSlots[Day - 1, TimeSlotIndex(timeSlot)] = null;
        }

        private int TimeSlotIndex(String timeSlot)
        {
            int index  = -1;
            switch (timeSlot)
            {
                case "08:00-09:00":
                    index = 0;
                    break;
                case "09:00-10:00":
                    index = 1;
                    break;
                case "10:00-11:00":
                    index = 2;
                    break;
                case "11:00-12:00":
                    index = 3;
                    break;
                case "12:00-13:00":
                    index = 4;
                    break;
                case "13:00-14:00":
                    index = 5;
                    break;
                case "14:00-15:00":
                    index = 6;
                    break;
                case "15:00-16:00":
                    index = 7;
                    break;
                case "16:00-17:00":
                    index = 8;
                    break;
            }
            return index;
        }

    }
}

