using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    internal class Notes
    {
        public string Data { get; set; }
        public Notes next { get; set; }

        public Notes( string data)
        {
            Data = data;
            next = null;

        }
      
    }
}
