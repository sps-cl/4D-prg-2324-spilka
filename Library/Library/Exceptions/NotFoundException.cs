using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Exception;
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message = "Polo�ka nebyla nalezena") : base(message)
        {
            
        }
    }
}
