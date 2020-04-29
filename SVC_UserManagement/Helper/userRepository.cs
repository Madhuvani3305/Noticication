using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Helper
{
    public class userRepository
    {
        private readonly notificationDbContext _context;
        public userRepository(notificationDbContext context)
        {
            _context = context;
        }
        public UserDetails GetUser(string userid)
        {
            return _context.UserDetails.Find(userid);
        }

        public void UpdateUser(UserDetails obj)
        {
            _context.UserDetails.Update(obj);
            _context.SaveChanges();
        }

        public UserDetails UserLogin(string uname, string pwd)
        {
            return _context.UserDetails.SingleOrDefault(e => e.Username == uname && e.Password == pwd);
        }

        public void UserRegister(UserDetails obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
