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

        private static string pth_ProjFol;
        public static string pth_PRTTempl = pth_ProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi PART.PRTDOT";
        public static string pth_ASMTempl = pth_ProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi ASM.ASMDOT";
        public static string pth_DRWVendorTempl = pth_ProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Vendor.DRWDOT";
        public static string pth_DRWModiVendorTempl = pth_ProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Modified Vendor.DRWDOT";
        public static string pth_DRWManufacTempl = pth_ProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Manufacturing.DRWDOT";
        public static string pth_SaveName;
        

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

        public string loadProjectListGoogle()
        {
            string pthNLGoogle = "G:\\Gedeelde drives\\RTPI Projects\\";
            string pthENGoogle = "G:\\Shared drives\\RTPI Projects\\";

            if (Directory.Exists(pthNLGoogle))
            {
                ErrorHandler.errorMessageHandling(4);
                pth_ProjFol = pthNLGoogle;
                createProjectList();
            }
            else if (Directory.Exists(pthENGoogle))
            {
                ErrorHandler.errorMessageHandling(4);
                pth_ProjFol = pthENGoogle;
                createProjectList();
            }
            else
            {
                ErrorHandler.errorMessageHandling(6);
            }

            return pth_ProjFol;
        }

        public static string create_PartAssyDrawNumber(int SWtype)
        {
            /// <summary>
            /// Create the prefix of the part number
            /// </summary>
             
            string prefixPartNumber = null;

            if (CreatePart.choforProject == null && CreateAssembly.choforProject == null)
            {
                prefixPartNumber = "ERROR, NO PROJECT CHOSEN";
            }

            else if (CreatePart.choforProject != null && CreateAssembly.choforProject == null && SWtype == 1)
            { 
                prefixPartNumber = CreatePart.choforProject.Substring(CreatePart.choforProject.Length - 3, 3);
            }

            else if (CreatePart.choforProject == null && CreateAssembly.choforProject != null && SWtype == 2)
            {
                prefixPartNumber = CreateAssembly.choforProject.Substring(CreateAssembly.choforProject.Length - 3, 3);
            }

            else if (CreatePart.choforProject != null && CreateAssembly.choforProject != null)
            {
                ErrorHandler.errorMessageHandling(7);
            }

            /// <summary>
            /// Create the suffix of the part number
            /// </summary>

            string suffixPartNumber;
            string pth_ProjDirectory = pth_ProjFol + CreatePart.choforProject + "\\SolidWorks\\";

            if (prefixPartNumber == "ERROR, NO PROJECT CHOSEN" && prefixPartNumber != null)
            {
                suffixPartNumber = "";
            }

            else if (CreateAssembly.choforAssyType == "Main Assembly")
            {
                suffixPartNumber = "0000";
            }

            else
            {
                // sets the directory from where files are showed //
                // makes a list of all the files //
                DirectoryInfo dirParts = new DirectoryInfo(pth_ProjDirectory);
                FileInfo[] listParts = dirParts.GetFiles().OrderBy(p => p.Name).ToArray();

                // If the list does not contain any files make the first file. part xxx-0000 will always be the main assembly //
                if (listParts.Length == 0)
                {
                    suffixPartNumber = "0001";
                }
                else
                {
                    // checks the last files that is in the array //
                    // gets the suffixnumber from the file //
                    // create a integer from that suffix number string //
                    string lastfolPart = listParts.Last().ToString();
                    string lastnrPart = lastfolPart.Substring(lastfolPart.Length - (lastfolPart.Length - 4), 4);
                    int intlastnrPart = Int32.Parse(lastnrPart);
                    // creates a 'random' number which is always 1 higher than the last file //
                    System.Random random = new System.Random();
                    int intsuffixPartNumber = random.Next(intlastnrPart + 1, intlastnrPart + 1);

                    // tells that the suffix number always needs to have 4 numbers with leading zeros if necessar //
                    suffixPartNumber = intsuffixPartNumber.ToString("0000");
                }
            }

            /// <summary>
            /// set the folder that the part needs to be saved in, creates the full number, creates the full string where and how the part needs to be saved
            /// </summary>

            string PartNumber;
            string extension_Part = ".SLDPRT";
            string extension_Assembly = ".SLDASM";

            if (SWtype == 1)
            
                if (prefixPartNumber == "ERROR, NO PROJECT CHOSEN")
                {
                    pth_SaveName = prefixPartNumber;
                }
                else
                {
                    if (CreatePart.choforItemType == "Vendor")
                    {
                        if (CreatePart.modifiedCheck == 1)
                        {
                            PartNumber = prefixPartNumber + "-" + suffixPartNumber + "-MV";
                            pth_SaveName = pth_ProjDirectory + PartNumber + extension_Part;
                        }
                        else if (CreatePart.modifiedCheck == 2)
                        {
                            PartNumber = prefixPartNumber + "-" + suffixPartNumber + "-V";
                            pth_SaveName = pth_ProjDirectory + PartNumber + extension_Part;
                        }
                        else
                        {
                            PartNumber = "ERROR, SOMETHING WENT WRONG";
                        }
                    }
                    else
                    {
                        PartNumber = prefixPartNumber + "-" + suffixPartNumber;
                        pth_SaveName = pth_ProjDirectory + PartNumber + extension_Part;
                    }
                }

            else if (SWtype == 2)
            {
                PartNumber = prefixPartNumber + "-" + suffixPartNumber;
                pth_SaveName = pth_ProjDirectory + PartNumber + extension_Assembly;
            }

            else if (SWtype == 3)
            {
                pth_SaveName = GUI.pthDrwtoOpen;
            }

            return pth_SaveName;
        }

        
    }

}
