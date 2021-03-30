using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowaPasswd.models
{
    class Credential
    {
        private string login_;
        private string password_;

        public Credential(string login, string password)
        {
            this.Login_ = login;
            this.Password_ = password;
        }

        public string Login_ { get => login_; set => login_ = value; }
        public string Password_ { get => password_; set => password_ = value; }
    }
}
