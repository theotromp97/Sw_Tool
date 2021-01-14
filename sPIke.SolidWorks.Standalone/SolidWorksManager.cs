using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace sPIke.SolidWorks.Standalone
{
    public class SolidworksManager
    {
        public ClassManager classManager;

        private SldWorks swApp;

        private IModelDoc2 swModel;
        private PartDoc swPart;
        private AssemblyDoc swAssy;
        private CustomPropertyManager CusProMan;

        private object liststucParts;

        //private string saveName;
        private string choProject;
        private string prefixPartNumber;
        private string dirSaveName;
        private string PartNumber;
        private string suffixPartNumber;
        private string prefixAssyName;

        // Constructor
        public SolidworksManager(ClassManager classMngr)
        {
            classManager = classMngr;
        }

        public async Task<SldWorks> OpenSolidWorks()
        {
            // This methods opens an instance of solidworks when solidworks is not opened yet
            if (swApp == null)
            {
                return await Task<SldWorks>.Run(() =>
                {
                    swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.application")) as SldWorks;
                    swApp.Visible = true;
                    bool tst = swApp.StartupProcessCompleted;
                    return swApp;
                });

            }
            return swApp;
        }
        public void CloseSolidWorks()
        {
            if (swApp != null)
            {
                swApp.ExitApp();
                swApp = null;
            }
        }



        public void CreateNewPart(string saveName)
        {
            if (CreatePart.exisCheck == 1)
            {
                //Open existing part
                swApp.OpenDoc6(CreatePart.pthfileName, 1, 1, "", 0, 0);
            }
            else
            {
                //create a part
                PartDoc swPart = swApp.INewPart();
            }

            //activate part

            IModelDoc2 swModel; swModel = swApp.ActiveDoc;

            assignModelProperties();

            //createPartNumber();

            //Save the part under a specific number
            swModel.SaveAs(saveName);


        }
        public void CreateAssembly()
        {

        }


        private void assignModelProperties()
        {
            //Activate the model document
            //asign custom property manager
            swModel = swApp.ActiveDoc;
            CusProMan = swModel.Extension.CustomPropertyManager[""];


            //set the author name
            swModel.SummaryInfo[2] = CreatePart.txtAuthor;

            if (CreatePart.choforItemType == "Vendor")
            {
                if (CreatePart.exisCheck == 1)
                {
                    //create different custom properties that are assigned to the document
                    CusProMan.Add3("Vendor SKU", 30, CreatePart.txtVenSKU, 2);
                    CusProMan.Add3("Vendor Name", 30, CreatePart.txtVendor, 2);
                    CusProMan.Add3("Vendor Costs", 30, CreatePart.txtVenCost, 2);
                }
                else
                {
                    swModel.SummaryInfo[0] = CreatePart.txtVenName;
                    CusProMan.Add3("Vendor SKU", 30, CreatePart.txtVenSKU, 2);
                    CusProMan.Add3("Vendor Name", 30, CreatePart.txtVendor, 0);
                    CusProMan.Add3("Vendor Costs", 30, CreatePart.txtVenCost, 2);
                }
            }
            else
            {
                //set the name of the part
                swModel.SummaryInfo[0] = CreatePart.txtManName;
            }
        }



    }
}
