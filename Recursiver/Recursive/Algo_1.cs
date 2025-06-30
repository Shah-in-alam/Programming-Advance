using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recursive
{
    internal class Algo_1
    {
        public string Algorithm1(string basedFolder)
        {
            List<string> folder = new List<string>();
            folder.Add(basedFolder);
            {
                while(folder.Count > 0)
                {
                    string files =folder.First();
                    if(Directory.GetFiles(files).Length > 0)
                    {
                        return files;
                    }
                    folder.AddRange(Directory.GetDirectories(files));
                    folder.Remove(files);
                }

            }
            return basedFolder;
        }   
    }
    
}
