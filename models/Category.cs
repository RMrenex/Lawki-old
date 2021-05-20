using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowaPasswd.models
{
    class Category
    {
        private static List<Category> categories_ = new List<Category>();
        private string name_;
        private List<Credential> credentials_;

        public Category(string name, List<Credential> credentials)
        {
            this.Name_ = name;
            this.Credentials = credentials;
        }

        public static List<Category> Categories_ { get => categories_; }
        public string Name_ { get => name_; set => name_ = value; }
        public List<Credential> Credentials { get => credentials_; set => credentials_ = value; }
    }
}
