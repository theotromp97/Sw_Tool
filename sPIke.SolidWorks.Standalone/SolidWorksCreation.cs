using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Linq;
using System.IO;

namespace sPIke.SolidWorks.Standalone
{
    internal class SolidWorksCreation
    {

        /// <summary>
        /// Variables for creating part
        /// </summary> 

        public static SldWorks swApp;
        public static IModelDoc2 swModel;
        public static PartDoc swPart;
        public static AssemblyDoc swAssy;
        public static DrawingDoc swDraw;
        public static CustomPropertyManager CusProMan;

        public static object liststucParts;

        public static string saveName;
        public static string choProject;
        public static string prefixPartNumber;
        public static string dirSaveName;
        public static string PartNumber;
        public static string suffixPartNumber;
        public static string prefixAssyName;
        public static string pthPartAssytoOpen;

        /// <summary>
        /// The main code of the SW part creation
        /// </summary>

        public static void createSWPart()
        {
            swApp = SolidWorksSingleton.swApp;

            if (createPart.exisCheck == 1)
            {
                //Open existing part
                swApp.OpenDoc6(createPart.pthfileName, 1, 256, "", 0, 0);
            }
            else
            {
                //create a part
                swPart = swApp.NewPart();
            }

            //activate part
            swModel = swApp.ActiveDoc;

            assignModelProperties();

            createPartNumber(1);

            //Save the part under a specific number
            swModel.SaveAs3(saveName, 0, 1);
        }

        public static void createSWAssembly()
        {
            swApp = SolidWorksSingleton.swApp;

            //create a assembly
            swAssy = swApp.INewAssembly();

            //activate assembly
            swModel = swApp.ActiveDoc;

            assignAssyProperties();

            createPartNumber(2);

            //Save the assy under a specific number
            swModel.SaveAs(saveName);
        }

        public static void createSWDrawing(bool createDrawBool)
        {
            swApp = SolidWorksSingleton.swApp;
            string pthTemplateFolder = GUI.pthProjFolder + "\\" + "Ξ_SolidWorks Standard Library" + "\\" + "Templates" + "\\" + "RTPi DRW.DRWDOT";
            pthPartAssytoOpen = GUI.pthProjFolder + "\\" + GUI.GUIProj + "\\" + GUI.PartAssySolidWorkstoOpen;

            //if drawing exist open it, otherwise create the drawing.
            if (createDrawBool == false)
            {
                swApp.OpenDoc6(GUI.pthDrwtoOpen, 3, 256, "", 0, 0);
            }
            else
            {
                //create a drawing
                swModel = (ModelDoc2)swApp.NewDocument(pthTemplateFolder, 0, 0, 0);

                //activate drawing
                swDraw = (DrawingDoc)swModel;

                createPartNumber(3);

                //save the part under a specific number
                swModel.SaveAs(saveName);
            }
        }

        /// <summary>
        /// The functions that take care that the part can be created
        /// </summary>

        public static void createPartNumber(int SWtype)
        {
            //create the prefix and suffix of the partnumber
            createPrefixPartNumber();
            createSuffixPartNumber();

            //set the folder that the part needs to be saved in
            //creates the full number
            //creates the full string where and how the part needs to be saved
            if (SWtype == 1)
            {
                if (prefixPartNumber == "ERROR")
                {
                    PartNumber = prefixPartNumber;
                }
                else
                {
                    dirSaveName = GUIcode.pthSaveLoc + "/" + createPart.choforProject + "/";

                    if (createPart.choforItemType == "Vendor")
                    {
                        if (createPart.modifiedCheck == 1)
                        {
                            PartNumber = prefixPartNumber + "-" + suffixPartNumber + "-MV";
                            saveName = dirSaveName + PartNumber + ".sldprt";
                        }
                        else if (createPart.modifiedCheck == 2)
                        {
                            PartNumber = prefixPartNumber + "-" + suffixPartNumber + "-V";
                            saveName = dirSaveName + PartNumber + ".sldprt";
                        }
                        else
                        {
                            PartNumber = "ERROR";
                        }
                    }
                    else
                    {
                        PartNumber = prefixPartNumber + "-" + suffixPartNumber;
                        saveName = dirSaveName + PartNumber + ".sldprt";
                    }
                }
            }
            else if (SWtype == 2)
            {
                PartNumber = prefixPartNumber + "-" + suffixPartNumber;
                saveName = dirSaveName + PartNumber + ".sldasm";
            }
            else if (SWtype == 3)
            {
                saveName = GUI.pthDrwtoOpen;
            }
        }

        //Creates the array that holds all the directories that are made within the projects directory of RTPi


        //create the prefix of the part number
        public static void createPrefixPartNumber()
        {

            if (createPart.choforProject == null & CreateAssembly.choforProject == null)
            {
                //give error if no item type is chosen by the user
                prefixPartNumber = "ERROR";
            }
            //Checks if the item type is either manufactured, vendor or null
            else if (createPart.choforProject != null || CreateAssembly.choforProject == null)
            {
                //gets the variable at another class
                choProject = createPart.choforProject;

                if (choProject == ".grabcad")
                {
                    prefixPartNumber = "ERROR";
                }
                else
                {
                    //create the prefix with the chosen directory
                    prefixPartNumber = choProject.Substring(choProject.Length - 3, 3);
                }
            }
            else if (createPart.choforProject == null || CreateAssembly.choforProject != null)
            {
                //gets the variable at another class
                choProject = CreateAssembly.choforProject;

                if (choProject == ".grabcad")
                {
                    prefixPartNumber = "ERROR";
                }
                else
                {
                    //create the prefix with the chosen directory
                    prefixPartNumber = choProject.Substring(choProject.Length - 3, 3);
                }
            }
        }

        //create the prefix of the part number
        public static void createSuffixPartNumber()
        {
            if(prefixPartNumber == "ERROR")
            {
                suffixPartNumber = "";
            }
            else if(CreateAssembly.choforAssyType == "Main Assembly")
            {
                suffixPartNumber = "0000";
            }
            else
            {
                //sets the directory from where files are showed
                //makes a list of all the files
                DirectoryInfo dirParts = new DirectoryInfo(GUI.pthProjFolder + choProject);
                FileInfo[] listParts = dirParts.GetFiles().OrderBy(p => p.Name).ToArray();

                liststucParts = listParts;

                //If the list does not contain any files make the first file. part xxx-0000 will always be the main assembly
                if (listParts.Length == 0)
                {
                    suffixPartNumber = "0001";
                }
                else
                {
                    //checks the last files that is in the array
                    //gets the suffixnumber from the file
                    //create a integer from that suffix number string
                    string lastfolPart = listParts.Last().ToString();
                    string lastnrPart = lastfolPart.Substring(lastfolPart.Length - (lastfolPart.Length - 4), 4);
                    int intlastnrPart = Int32.Parse(lastnrPart);
                    //creates a 'random' number which is always 1 higher than the last file
                    System.Random random = new System.Random();
                    int intsuffixPartNumber = random.Next(intlastnrPart + 1, intlastnrPart + 1);

                    //tells that the suffix number always needs to have 4 numbers with leading zeros if necessary
                    //create a string from the integer
                    string leadZero = "0000";
                    suffixPartNumber = intsuffixPartNumber.ToString(leadZero);
                }
            }
        }

        public static void assignModelProperties()
        {
            //Activate the model document
            //asign custom property manager
            swModel = swApp.ActiveDoc;
            CusProMan = swModel.Extension.CustomPropertyManager[""];

            //set the author name
            swModel.SummaryInfo[2] = GUI.AuthorName;

            if (createPart.choforItemType == "Vendor")
            {
                if (createPart.exisCheck == 1)
                {
                    //create different custom properties that are assigned to the document
                    CusProMan.Add3("Vendor SKU", 30, createPart.txtVenSKU, 2);
                    CusProMan.Add3("Vendor Name", 30, createPart.txtVendor, 2);
                    CusProMan.Add3("Vendor Costs", 30, createPart.txtVenCost, 2);
                }
                else
                {
                    swModel.SummaryInfo[0] = createPart.txtVenName;
                    CusProMan.Add3("Vendor SKU", 30, createPart.txtVenSKU, 2);
                    CusProMan.Add3("Vendor Name", 30, createPart.txtVendor, 0);
                    CusProMan.Add3("Vendor Costs", 30, createPart.txtVenCost, 2);
                }
            }
            else
            {
                //set the name of the part
                swModel.SummaryInfo[0] = createPart.txtManName;
            }
        }

        public static void assignAssyProperties()
        {
            //Activate the model document
            swModel = swApp.ActiveDoc;

            //set the author name
            //set the name of the part
            swModel.SummaryInfo[2] = CreateAssembly.txtAuthor;
            swModel.SummaryInfo[0] = CreateAssembly.txtAssyName;
        }

        public static void createPrefixAssyName()
        {
            if (CreateAssembly.choforAssyType == "Normal Assembly")
            {
                prefixAssyName = "ASSY";
            }
            else if(CreateAssembly.choforAssyType == "Weldment Assembly")
            {
                prefixAssyName = "WELD ASSY";
            }
            else
            {
                prefixAssyName = "MAIN ASSY";
            }
        }

        /// <summary>
        /// Open documents
        /// </summary>

        public static void openPartAssy()
        {
            swApp = SolidWorksSingleton.swApp;
            pthPartAssytoOpen = GUI.pthProjFolder + "\\" + GUI.GUIProj + "\\" + GUI.PartAssySolidWorkstoOpen;

            if (GUI.extensionSolidWorks == "SLDPRT")
            {
                swApp.OpenDoc6(pthPartAssytoOpen, 1, 256, "", 0, 0);
            }
            else if (GUI.extensionSolidWorks == "SLDASM")
            {
                swApp.OpenDoc6(pthPartAssytoOpen, 2, 256, "", 0, 0);
            }
        }

    }
}
