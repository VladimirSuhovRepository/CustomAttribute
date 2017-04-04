using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLibrary
{
    public class DoWork
    {
        [Authorize("Vova")]
        public string  ButtonShow
        {
            get
            {
                return "Hello Vova";
            }
        }
    }
}
