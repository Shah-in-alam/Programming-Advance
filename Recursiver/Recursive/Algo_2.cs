using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    internal class Algo_2
    {  /*Check evry items in the folder */
        public string Algorithm2(string basedFolder)
        {
            foreach(var item in Directory.EnumerateFileSystemEntries(basedFolder))
            {
                Console.WriteLine(item);
                if(Directory.Exists(item))
                {
                    string value =Algorithm2(item);
                    if(value != null)
                    {
                        return value;
                    }
                    else if(File.Exists(item))
                    {
                        return item;
                    }
                    
                }
            }
            return null;

        }
    
    }
}
