using System;
using System.Collections.Generic;

namespace NotificationManagementDBEntity.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            Notifications = new HashSet<Notifications>();
        }

        public string Userid { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailid { get; set; }
        public string Contactnumber { get; set; }
        public DateTime? Registereddatetime { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Notifications> Notifications { get; set; }
    }
}
