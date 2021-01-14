using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    public class ClassManager
    {
        public Main mainRef;
        public SolidworksManager swManager;
        public FileManager fileManager;
        public FormManager formManager;
        public ClassManager(Main _mainRef)
        {
            mainRef = _mainRef;
            swManager = new SolidworksManager(this);
            fileManager = new FileManager(this);
            formManager = new FormManager(this);
        }

        private void InitClasses()
        {
            // todo: initialize in seperate thread

            //swManager.Init();

        }
        public void Run()
        {

        }
    }
}
