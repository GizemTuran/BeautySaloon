using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySaloon.Models
{
    public class StaffMembers
    {
        public int StaffMembersID { get; set; }
        public bool StaffMembersAvailability { get; set; }
        public string StaffMembersProfecinality { get; set; }
        public float StaffMembersFees { get; set; }
    }

}