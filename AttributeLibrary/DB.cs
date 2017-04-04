using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    public static class DB
    {
        public static List<User> Users = new List<User>()
        {
            new User() { Name = "Vova", Role = "Admin", Email = "Test"},
            new User() { Name = "Egor",  Role = "User", Email = "Test"},
            new User() { Name = "Vadim",  Role = "User", Email = "Test"}
        };
    }
}
