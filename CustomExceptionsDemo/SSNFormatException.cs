//Nicholas Mitchell nmitchell11@cnm.edu
//Custom Exceptions Demo


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsDemo
{
    internal class SSNFormatException:Exception
    {
        public SSNFormatException() : base("Not a valid Social Social Security Number.")
        {
        }

    }
}
