using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleTest
{

    class Program
    {
        static void Maaaain(string[] args)
        {
            string path = @"C:\Users\abhi\Downloads\StrangerThings\Coldplay";
            if (Directory.Exists(path))
            {
                RenameFile(path);
            }
        }

        private static void RenameFile(string path)
        {
            int i = 1;
            string[] files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                System.IO.File.Move(item, @"C:\Users\abhi\Downloads\StrangerThings\Coldplay\Coldplay" + i.ToString() + ".jpg");
                i++;
            }
        }



    }
}
