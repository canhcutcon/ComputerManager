using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ComputerManager
{
    public class DTO_UserInfo
    {
        private string username, password;

        public DTO_UserInfo() { }
        public DTO_UserInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
