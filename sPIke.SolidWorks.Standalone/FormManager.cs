using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public class FormManager
    {
        public ClassManager classManager;
        public GUI gui;
        public CreatePart formCreatePart;
        public CreateAssembly formCreateAssembly;
        public FormManager(ClassManager manager)
        {
            classManager = manager;
            gui = new GUI(this);
        }

        public void show(Form f)
        {
            f.Show();
        }

        public void InitFormManager()
        {
            formCreatePart = new CreatePart(this);
            formCreateAssembly = new CreateAssembly(this);
        }
    }
}
