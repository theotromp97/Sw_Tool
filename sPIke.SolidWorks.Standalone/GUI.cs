using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.IO;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public partial class GUI : Form
    {
        public FormManager formManager;
        private string thisClassName = "GUI";



        private enum Extentions
        {
            PDF, SLDPRT, SLDASM, STEP, STL
        };
        //public static FileInfo projFiles;

        public GUI(FormManager _formManager)
        {
            string thisMethodName = "Constructor";

            try
            {
                InitializeComponent();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void toolStripMenuItem_NewSWCreatePart_Click(object sender, EventArgs e)
        {
            string thisMethodName = "toolStripMenuItem_New_SWCreate_Part_Click";
            try
            {
                if (formManager.classManager.fileManager.currentProject != null)
                {
                    formManager.show(formManager.formCreatePart);
                }
                else if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "SolidWorks does not exist");
                    ErrorHandler.errorMessageHandling(3);
                }
                else if (formManager.classManager.userManager.UserName == null)
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "Author does not exist");
                    ErrorHandler.errorMessageHandling(2);
                }
                else // no project selected
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "No project selected");
                    ErrorHandler.errorMessageHandling(1);
                }
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void toolStripMenuItem_NewSWCreateAssembly_Click(object sender, EventArgs e)
        {
            string thisMethodName = "toolStripMenuItem_New_SWCreate_Assembly_Click";
            try
            {
                if (formManager.classManager.fileManager.currentProject != null)
                {
                    formManager.show(formManager.formCreateAssembly);
                }
                else if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "SolidWorks does not exist");
                    ErrorHandler.errorMessageHandling(3);
                }
                // test this
                else if (formManager.classManager.userManager.UserName == null)
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "Author does not exist");
                    ErrorHandler.errorMessageHandling(2);
                }
                else
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "No project selected");
                    ErrorHandler.errorMessageHandling(1);
                }
            }

            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private async void startInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string thisMethodName = "projectFolderToolStripMenuItem_Click";
            try
            {
                await formManager.classManager.swManager.OpenSolidWorks();
            }

            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
}

        private void exitInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string thisMethodName = "projectFolderToolStripMenuItem_Click";

            try
            {
                formManager.classManager.swManager.CloseSolidWorks();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void projectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string thisMethodName = "projectFolderToolStripMenuItem_Click";

            try { 
                BrowsingDialog_ProjectFolder.ShowDialog();
                formManager.classManager.fileManager.GetProjectFolder(BrowsingDialog_ProjectFolder.SelectedPath);
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void ShowProjectFiles()
        {
            string thisMethodName = "ShowProjectFiles";
            try
            {
                listBox_FileList.Items.Clear();
                //TODO
                string[] fileList = formManager.classManager.fileManager.GetFileNames(formManager.classManager.fileManager.currentProject, comb_ProjectList.SelectedItem.ToString(), comb_ExtentionList.SelectedItem.ToString());

                if (fileList.Length > 0)
                {
                    listBox_FileList.Items.Add(fileList);
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Message, thisClassName, thisMethodName, "Project files added successfully");
                }

                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Warning, thisClassName, thisMethodName, "No project files found");
            }

            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void comb_ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thisMethodName = "comb_ProjectList_SelectedIndexChanged";
            try
            {
                formManager.classManager.fileManager.currentProject = comb_ProjectList.SelectedItem.ToString();
                ShowProjectFiles();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void comb_ExtensionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thisMethodName = "comb_ExtensionList_SelectedIndexChanged";
            try
            {
                ShowProjectFiles();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void listBox_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thisMethodName = "listBox_FileList_SelectedIndexChanged";
            try
            {
                //UpdatePreview();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        // TODO
        private void btn_CreateDrawing_Click(object sender, EventArgs e)
        {
            string thisMethodName = "btn_CreateDrawing_Click";
            try
            {
                /*
                if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    if (GUIProj != null && listBox_FileList.SelectedItem != null && comb_ExtentionList.Text == "SLDPRT" || comb_ExtentionList.Text == "SLDASM")
                    {
                        PartAssySolidWorkstoOpen = listBox_FileList.SelectedItem.ToString();
                        pthDrwtoOpen = GUI.pthProjFolder + "\\" + GUI.GUIProj + "\\" + GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";
                        itmDrwtoOpen = GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";

                        showProjectFiles("*.SLDDRW");

                        if (listBox_FileList.Items.Contains(itmDrwtoOpen) == true)
                        {
                            SolidWorksCreation.createSWDrawing(false);
                        }
                        else
                        {
                            SolidWorksCreation.createSWDrawing(true);
                        }
                    }
                    else
                    {
                        ErrorHandler.errorMessageHandling(1);
                    }
                }
                else
                {
                    ErrorHandler.errorMessageHandling(1);
                }
                */
            }
            catch (Exception er)
            {

                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }

            //ShowProjectFiles();
        }

        private void toolStripMenuItem_ConfigurationAuthorName_Click(object sender, EventArgs e)
        {
            string thisMethodName = "toolStripMenuItem_ConfigurationAuthorName_Click";
            try
            {
                pnlAuthorName.Show();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }

        private void btnFileListRefresh(object sender, EventArgs e)
        {
            string thisMethodName = "btnFileListRefresh";
            try
            {

            ShowProjectFiles();
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
            
        }

        //TODO
        private void btn_OpenSpecs_Click(object sender, EventArgs e)
        {
            string thisMethodName = "btn_OpenSpecs_Click";
            try
            {
                /*
                if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    ErrorHandler.errorMessageHandling(3);
                }
                else if (formManager.classManager.fileManager.currentProject != null)
                {
                    extensionSolidWorks = comb_ExtentionList.Text;
                    PartAssySolidWorkstoOpen = listBox_FileList.SelectedItem.ToString();

                    SolidWorksCreation.openPartAssy();
                }
                else
                {
                    ErrorHandler.errorMessageHandling(1);
                }
                */
            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }
        }
   

        private void btn_SaveUserName_Click(object sender, EventArgs e)
        {
            string thisMethodName = "btn_SaveUserName_Click";
            try
            {
                formManager.classManager.userManager.UserName = i_UserName.Text;
                pnlAuthorName.Hide();

                toolStripMenuItem_ConfigurationAuthorName.BackColor = System.Drawing.Color.Gray;
                toolStripMenuItem_ConfigurationAuthorName.Enabled = false;

            }
            catch (Exception er)
            {
                ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, er.Message);
            }

        }

    
        private void UpdatePreview()
        {

            //string projFilePreview = GUI.pthProjFolder + "/" + projFilesListBox.SelectedItem.ToString();
            string projFilePreview = "G:/Gedeelde drives/RTPI Projects/EXPO_201/12 T small pulley.SLDPRT";

            //System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
            //System.Drawing.Bitmap myBitmap = new System.Drawing.Bitmap("Climber.jpg");
            // System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(
            // 40, 40, myCallback, IntPtr.Zero);

            //previewBox.Image = System.Drawing.Image.FromFile(projFilePreview);
        }

        private void GUI_Load(object sender, EventArgs e)
        {

            comb_ExtentionList.DataSource = Enum.GetValues(typeof(Extentions));
            
            /*
           //formManager.classManager.fileManager.loadProjectListGoogle();

           if (formManager.classManager.fileManager.folstucProjects != null)
           {
               comb_ProjectList.DataSource = formManager.classManager.fileManager.folstucProjects;
               toolStripMenuItem_ConfigurationProjectfolder.BackColor = System.Drawing.Color.Gray;
               toolStripMenuItem_ConfigurationProjectfolder.Enabled = false;
           }

           pnlAuthorName.Hide();
           */

        }

    }


}
