using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    public class ProjectFile
    {
        public string FilePath { get; set; }

        public byte[] FileData { get; set; }

        public virtual void LoadFileData()
        {
            Console.WriteLine("File Loaded.");
        }
    }
}
