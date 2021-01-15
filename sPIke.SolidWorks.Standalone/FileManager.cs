﻿using System;
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

        //private static string pthProjFol;
        public static string pthPRTTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi PART.PRTDOT";
        public static string pthASMTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi ASM.ASMDOT";
        public static string pthDRWVendorTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Vendor.DRWDOT";
        public static string pthDRWModiVendorTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Modified Vendor.DRWDOT";
        public static string pthDRWManufacTempl = pthProjFol + "Ξ_SolidWorks Standard Library\\Templates\\RTPi DRAWING A3 - Manufacturing.DRWDOT";

        public FileManager(ClassManager classMngr)
        {
            classManager = classMngr;
        }

        public string[] GetFileNames(string path, string fileType)
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
                pthProjFol = pthNLGoogle;
                createProjectList();
            }
            else if (Directory.Exists(pthENGoogle))
            {
                ErrorHandler.errorMessageHandling(4);
                pthProjFol = pthENGoogle;
                createProjectList();
            }
            else
            {
                ErrorHandler.errorMessageHandling(6);
            }

            return pthProjFol;
        }
    }
}
