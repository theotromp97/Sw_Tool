using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public class ErrorHandler
    {
        public ClassManager classManager;
        public ErrorHandler(ClassManager _classManager)
        {
            classManager = _classManager;
        }

        /// <summary>
        /// test code for errormessages
        /// </summary> 
        /*
        public enum ErrorMessages { 
            NoProject = 1,
            NoNameSelected = 2,
            NoSolidWorksAvailable = 3,
            ProjectFolderFound = 4,
            ProjectFolderNotFound = 5,
            ProjectFolderNotSelected = 6
        }
        */

        public static void errorMessageHandling(int errorMessage)
        {
            if (errorMessage == 1)
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
    }
}
