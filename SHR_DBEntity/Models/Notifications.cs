using System;
using System.Collections.Generic;

namespace NotificationManagementDBEntity.Models
{
    public partial class Notifications
    {
        public string Notificationid { get; set; }
        public string Notificationname { get; set; }
        public string Description { get; set; }
        public DateTime? Createddatetime { get; set; }
        public string Userid { get; set; }

        public virtual UserDetails User { get; set; }
    }
}
