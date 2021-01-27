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
        public string thisClassName = "ClassManager";
        public SolidworksManager swManager;
        public FileManager fileManager;
        public FormManager formManager;
        public ErrorHandler errorHandler;
        public ClassManager(Main _mainRef)
        {
            string thisMethodName = "Constructor";
            // reference to main class
            mainRef = _mainRef;
            try
            {
                swManager = new SolidworksManager(this);
                fileManager = new FileManager(this);
                formManager = new FormManager(this);
                errorHandler = new ErrorHandler(this);
            }
            catch(Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
            // initialize classes

            InitClasses();
        }

        private void InitClasses()
        {
            string thisMethodName = "initClasses";
            try
            {
                formManager.InitFormManager();
            }


            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }
        public void Run()
        {
            string thisMethodName = "Run";

            try
            { 
            
            }

            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }

        }
    }
}
