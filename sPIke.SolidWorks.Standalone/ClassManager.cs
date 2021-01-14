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



            InitClasses();
        }

        private void InitClasses()
        {
            formManager.InitFormManager();
        }
        public void Run()
        {

        }
    }
}
