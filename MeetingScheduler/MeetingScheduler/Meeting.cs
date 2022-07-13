using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
    class Meeting
    {
        private User Initiator;
        private User[] Attendees = new User[4];
        private DateTime dateTime;

        public Meeting(User Initiator, User[] Attendees, DateTime dateTime)
        {
            this.Initiator = Initiator;
            this.Attendees = Attendees;
            this.dateTime = dateTime;

        }
    }
}
