using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    public class WritableFile : ProjectFile
    {
        public void SaveFileData()
        {
            Console.WriteLine("Writable File Saved.");
        }

        public override void LoadFileData()
        {
            Console.WriteLine("Writable File Loaded.");
        }
    }
}
