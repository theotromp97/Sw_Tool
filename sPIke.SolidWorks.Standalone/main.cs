using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    public class Main
    {
        public ClassManager classManager;
        public Main()
        {
            classManager = new ClassManager(this);
        }

        public void Start()
        {
            Application.Run(classManager.formManager.gui);
        }
    }
}
