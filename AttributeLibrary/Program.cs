using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new DoWork();
           
            Console.WriteLine(res.ButtonShow);
            Console.ReadKey();
        }

        private static Dictionary<string, string> SetConfiguration(Type destinationType)
        {
            PropertyInfo[] destinationProperties = destinationType.GetProperties();
            Dictionary<string, string> aliases = new Dictionary<string, string>();

            foreach (PropertyInfo property in destinationProperties)
            {
                object[] authAttributes =
                property.GetCustomAttributes(typeof(AuthorizeAttribute), true);

                foreach (object attribute in authAttributes)
                {
                    var item = (AuthorizeAttribute)attribute;
                    var t = item.Role;
                    var access = item.HasAccess;
                }


                //We also need to add the property name
                // as an alias.
                aliases.Add(property.Name, property.Name);
            }

            return aliases;
        }

    }
}
