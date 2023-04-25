using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipleDemo
{
    //contravariance 
    //covariance
    //preconditions and postconditions
    //invariants
    //history constraint
    public class Project
    {
        public List<ProjectFile> AllFiles { get; set; }
        public List<WritableFile> WritableFiles { get; set; } 
        public void LoadAllFiles()
        {
            foreach (ProjectFile file in AllFiles)
            {
                file.LoadFileData();
            }
        }

        public void SaveAllFiles()
        {
            foreach (WritableFile file in WritableFiles)
            {
                file.SaveFileData();
            }
        }
    }
}
