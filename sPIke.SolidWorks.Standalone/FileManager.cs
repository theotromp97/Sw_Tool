using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    public class FileManager
    {
        public ClassManager classManager;
        public object[] folstucProjects;

        //All different paths to files in the windows explorer
        public string pthNLGoogle = "G:\\Gedeelde drives\\RTPI Projects\\";
        public string pthENGoogle = "G:\\Shared drives\\RTPI Projects\\";
        public static string pthProjFol;

        public FileManager(ClassManager classMngr)
        {
            classManager = classMngr;
        }

        public string[] GetFiles(string path, string fileType)
        {

            DirectoryInfo fileDirectoryProj = new DirectoryInfo(path);
            FileInfo[] projFiles = fileDirectoryProj.GetFiles();

            string[] fileNameList = new string[projFiles.Length];
            foreach (FileInfo file in projFiles)
            {
                fileNameList.Append(file.Name);
            }
            return fileNameList;
        }

        public object[] createProjectList()
        {
            //sets the directory from which a list must be made
            //Makes that array of directories
            DirectoryInfo dirProjects = new DirectoryInfo(GUI.pthProjFolder);
            DirectoryInfo[] folProjects = dirProjects.GetDirectories().OrderBy(p => p.Name).ToArray();

            //Make the list an object that can be read by another class
            return folProjects;
        }

        public static void loadProjectListGoogle()
        {
            if (Directory.Exists(pthNLGoogle))
            {
                errorMessageHanding(4);
                pthProjFol = pthNLGoogle;
                pthSaveLoc = pthNLGoogle;
                createProjectList();
            }
            else if (Directory.Exists(pthENGoogle))
            {
                errorMessageHanding(4);
                pthProjFol = pthENGoogle;
                pthSaveLoc = pthENGoogle;
                createProjectList();
            }
            else
            {
                errorMessageHanding(5);
            }
        }
    }
}
