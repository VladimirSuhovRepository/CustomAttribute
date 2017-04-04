using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    public static class Configuration
    {
        public static void Execute(object dest)
        {
            var destinationType = dest.GetType();
            var dnAttribute =
                destinationType.GetCustomAttributes(typeof(AuthorizeAttribute), true).FirstOrDefault() as
                    AuthorizeAttribute;
            var accessObtained = dnAttribute.HasAccess;
            var role = dnAttribute.Role;

            if (accessObtained)
            {
                Type type = destinationType;

                if (type != null)
                {
                    MethodInfo methodInfo = type.GetMethod("Config" + role);

                    if (methodInfo != null)
                    {
                        object result = null;
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        //object classInstance = Activator.CreateInstance(type, null);
                        result = methodInfo.Invoke(dest, null);

                    }
                }

            }
            else
            {
                Type type = destinationType;

                if (type != null)
                {
                    MethodInfo methodInfo = type.GetMethod("ConfigDefault");

                    if (methodInfo != null)
                    {
                        object result = null;
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        //object classInstance = Activator.CreateInstance(type, null);
                        result = methodInfo.Invoke(dest, null);

                    }
                }
            }
        }
    }
}
