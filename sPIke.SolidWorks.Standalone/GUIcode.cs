using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    class GUIcode
    {
        public static string pthNLGoogle = "G:\\Gedeelde drives\\RTPI Projects\\";
        public static string pthENGoogle = "G:\\Shared drives\\RTPI Projects\\";
        public static string pthSaveLoc;
        public static object[] folstucProjects;

        public static void createProjectList()
        {
            if (GUI.pthProjFolder != "")
            {
                //sets the directory from which a list must be made ;;;
                //Makes that array of directories
                DirectoryInfo dirProjects = new DirectoryInfo(GUI.pthProjFolder);
                DirectoryInfo[] folProjects = dirProjects.GetDirectories().OrderBy(p => p.Name).ToArray();

                //Make the list an object that can be read by another class
                folstucProjects = folProjects;
            }
            else
            {
                errorMessageHanding(6);
            }
            
        }

        public static void errorMessageHanding(int errorMessage)
        {
            if(errorMessage == 1)
            {
                MessageBox.Show("No project selected or the right extensions is not selected. Meaning that there is no possibility for creating a part, assembly or drawing.", "NO PROJECT/EXTENSION FOUND", 0, MessageBoxIcon.Stop);
            }
            else if (errorMessage == 2)
            {
                MessageBox.Show("You did not enter your name.", "NO AUTHOR NAME FOUND", 0, MessageBoxIcon.Stop);
            }
            else if (errorMessage == 3)
            {
                MessageBox.Show("There is no instance of SolidWorks available for usage.", "NO INSTANCE OF SOLIDWORKS FOUND", 0, MessageBoxIcon.Stop);
            }
            else if (errorMessage == 4)
            {
                MessageBox.Show("The google folder is found so no further action is required to connect the program to the project folder list.", "PROJECT FOLDER FOUND", 0, MessageBoxIcon.Information);
            }
            else if (errorMessage == 5)
            {
                MessageBox.Show("The google folder is NOT found so a manual action is required to connect the program to the project folder list.", "PROJECT FOLDER NOT FOUND", 0, MessageBoxIcon.Stop);
            }
            else if (errorMessage == 6)
            {
                MessageBox.Show("There is no folder selected so the action has failed.", "PROJECT FOLDER NOT SELECTED", 0, MessageBoxIcon.Stop);
            }
        }

        public static void loadProjectListGoogle()
        {
            if (Directory.Exists(pthNLGoogle))
            {
                errorMessageHanding(4);
                GUI.pthProjFolder = pthNLGoogle;
                pthSaveLoc = pthNLGoogle;
                createProjectList();
            }
            else if (Directory.Exists(pthENGoogle))
            {
                errorMessageHanding(4);
                GUI.pthProjFolder = pthENGoogle;
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
