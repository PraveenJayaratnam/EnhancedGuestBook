using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLibrary.Models
{
    public class Guest
    {
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        public string MessageToHost { get; set; } = string.Empty;
        public string UserInfo
        {
            get
            {
                return $"{FirstName} {LastName} : {MessageToHost}";
            }
        }
    }
}
