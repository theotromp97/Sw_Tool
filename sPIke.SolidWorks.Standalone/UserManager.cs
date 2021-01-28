using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    public class UserManager
    {
        public string thisClassName = "UserManager";
        public ClassManager classManager;
        public UserManager(ClassManager _classManager)
        {
            classManager = _classManager;
        }


        private string userName;

        public string UserName { get; set; }  // property
    }
}
