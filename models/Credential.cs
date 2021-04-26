using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowaPasswd.models
{
    class Credential
    {
        private string label_;
        private string login_;
        private string password_;

        public Credential(string label, string login, string password)
        {
            this.label_ = label;
            this.Login_ = login;
            this.Password_ = password;
        }

        public string Label_ { get => label_; set => label_ = value; }
        public string Login_ { get => login_; set => login_ = value; }
        public string Password_ { get => password_; set => password_ = value; }
    }
}
