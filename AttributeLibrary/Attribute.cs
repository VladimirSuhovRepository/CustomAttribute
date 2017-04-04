using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    [AttributeUsage(AttributeTargets.All)]
    public class AuthorizeAttribute : Attribute
    {
        private readonly string role;
        private string currentUser = "Vova";

        public AuthorizeAttribute(string role)
        {
            this.role = role;
        }

        public virtual string Role => role;

        public virtual string CurrentUser => currentUser;

        public virtual bool HasAccess => (DB.Users.FirstOrDefault(t => t.Role == role && t.Name == currentUser) != null);
    }
}
