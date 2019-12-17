using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filez
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get a new FileStream object.
            FileInfo f2 = new FileInfo(@"..\..\..\HelloThere.ini");
            FileStream s = f2.Open(FileMode.OpenOrCreate,
                           FileAccess.ReadWrite,
                           FileShare.None);

            // Write 20 bytes to the  file...
            for (int i = 0; i < 256; i++)
            {
                s.WriteByte((byte)i);
            }
            s.Close();

        }
    }
}
