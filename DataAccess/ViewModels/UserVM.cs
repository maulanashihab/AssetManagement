using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string StatusActive { get; set; }
        public UserVM() { }
        public UserVM(string Email, string Password, string StatusActive)
        {
            this.Email = Email;
            this.Password = Password;
            this.StatusActive = StatusActive;
        }
        public void Update(string Email, string Password, string StatusActive)
        {
            this.Email = Email;
            this.Password = Password;
            this.StatusActive = StatusActive;
        }
    }
}