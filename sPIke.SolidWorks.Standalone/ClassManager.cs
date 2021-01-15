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
        public ErrorHandler errorHandler;
        public FileManager fileManager;
        public FormManager formManager;
        public SolidworksManager swManager;
        public ClassManager(Main _mainRef)
        {
            // reference to main class
            mainRef = _mainRef;
            errorHandler = new ErrorHandler(this);
            fileManager = new FileManager(this);
            formManager = new FormManager(this);
            swManager = new SolidworksManager(this);

            // initialize classes

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
