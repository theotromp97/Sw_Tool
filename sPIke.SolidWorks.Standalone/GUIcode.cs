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


        
    }
}
