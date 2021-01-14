using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sPIke.SolidWorks.Standalone
{
    public class FormManager
    {
        public ClassManager classManager;
        public GUI gui;
        private CreatePart formCreatePart;
        private CreateAssembly formCreateAssembly;
        public FormManager(ClassManager manager)
        {
            classManager = manager;
            gui = new GUI(this);
        }

        public void Open_CreatePart()
        {
            formCreatePart = new CreatePart(this);
            formCreatePart.Show();
        }
        public void Open_CreateAssembly()
        {
            formCreateAssembly = new CreateAssembly(this);
            formCreateAssembly.Show();
        }
    }
}
