using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowaPasswd.models
{
    class Categorie
    {
        private string name_;
        private List<Credential> credentials_;

        public Categorie(string name, List<Credential> credentials)
        {
            this.Name_ = name;
            this.Credentials_ = credentials;
        }

        public string Name_ { get => name_; set => name_ = value; }
        internal List<Credential> Credentials_ { get => credentials_; set => credentials_ = value; }
    }
}
