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

        /// <summary>
        /// All different paths to files in the windows explorer
        /// </summary>
        
        public string pthNLGoogle = "G:\\Gedeelde drives\\RTPI Projects\\";
        public string pthENGoogle = "G:\\Shared drives\\RTPI Projects\\";
        public string pthProjFol;
        public string pthPRTTempl;
        public string pthASMTempl;
        public string pthDRWVendorTempl;
        public string pthDRWModiVendorTempl;
        public string pthDRWManufacTempl;

        public FileManager(ClassManager classMngr)
        {
            classManager = classMngr;
        }

        void pthHandler()
        {
            pthPRTTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi PART.PRTDOT";
            pthASMTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi ASM.ASMDOT";
            pthDRWVendorTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Vendor.DRWDOT";
            pthDRWModiVendorTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Modified Vendor.DRWDOT";
            pthDRWManufacTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Manufacturing.DRWDOT";
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

        public void loadProjectListGoogle()
        {
            if (Directory.Exists(pthNLGoogle))
            {
                errorMessageHandling(4);
                pthProjFol = pthNLGoogle;
                createProjectList();
            }
            else if (Directory.Exists(pthENGoogle))
            {
                errorMessageHanding(4);
                pthProjFol = pthENGoogle;
                createProjectList();
            }
            else
            {
                errorMessageHandling(5);
            }
        }
    }
}
