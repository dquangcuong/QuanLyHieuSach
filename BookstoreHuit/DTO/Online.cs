using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Online
    {
        public string Username { get; set; }
        public string Password{ get; set; }
        public Online(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
