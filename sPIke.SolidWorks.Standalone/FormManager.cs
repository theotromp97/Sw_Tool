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
        public FormManager(ClassManager _classManager)
        {
            // reference to classmanager
            classManager = _classManager;
            gui = new GUI(this);
        }

        public void InitFormManager()
        {
            // initialize formManager --> this function is called in classManager.Init()

            // Creates instances of creation forms
            formCreatePart = new CreatePart(this);
            formCreateAssembly = new CreateAssembly(this);
        }

        public void show(Form form)
        {
            // shows the form in the parameter.
            form.Show();
        }

        public void Close(Form form)
        {
            try
            {
                // shows the form in the parameter.
                form.Show();
            }
            catch
            {

            }
        }


    }
}
