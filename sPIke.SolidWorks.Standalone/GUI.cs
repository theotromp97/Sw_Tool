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
        public static FileInfo projFiles;

        public string currentProject;

        private string authorName;
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
                if (currentProject != null)
                {
                    formManager.show(formManager.formCreatePart);
                }
                else if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "SolidWorks does not exist");
                    ErrorHandler.errorMessageHandling(3);
                }
                else if (authorName == null)
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
                if (currentProject != null)
                {
                    formManager.show(formManager.formCreateAssembly);
                }
                else if (formManager.classManager.swManager.GetSolidWorksInstance())
                {
                    ErrorHandler.GenerateMessage(ErrorHandler.MessageType.Error, thisClassName, thisMethodName, "SolidWorks does not exist");
                    ErrorHandler.errorMessageHandling(3);
                }
                else if (authorName == null)
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
            await formManager.classManager.swManager.OpenSolidWorks();
        }

        private void exitInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formManager.classManager.swManager.CloseSolidWorks();
        }

        private void projectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            projectfolderBrowsingDialog.ShowDialog();
            formManager.classManager.fileManager.GetProjectFolder(projectfolderBrowsingDialog.SelectedPath);
        }

        private void showProjectFiles(string fileType)
        {
            listBox_FileList.Items.Clear();

            DirectoryInfo fileDirectoryProj = new DirectoryInfo(pthProjFolder + "/" + comb_ProjectList.SelectedItem);
            FileInfo[] projFiles = fileDirectoryProj.GetFiles(fileType);
            string[] fileList = formManager.classManager.fileManager.GetFileNames(pthProjFolder + "/" + comb_ProjectList.SelectedItem, fileType);

            if (fileList.Length > 0)
            {
                listBox_FileList.Items.Add(fileList);
            }
        }

        private void GUIProjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_FileList.Items.Clear();
            showProjectFiles("*." + comb_ExtentionList.SelectedItem);

            currentProject = comb_ProjectList.SelectedItem.ToString();
        }

        private void comb_ExtensionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_FileList.Items.Clear();
            showProjectFiles("*." + comb_ExtentionList.SelectedItem);
        }

        private void listBox_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //UpdatePreview();
        }

        private void btn_CreateDrawing_Click(object sender, EventArgs e)
        {
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

            showProjectFiles("*." + comb_ExtentionList.SelectedItem);
        }

        private void appAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAuthorName.Show();
        }

        private void btnFileListRefresh(object sender, EventArgs e)
        {
            showProjectFiles("*." + comb_ExtentionList.SelectedItem);
        }



        private void btn_PartAssySpecs_Click(object sender, EventArgs e)
        {

            if (formManager.classManager.swManager.GetSolidWorksInstance())
            {
                ErrorHandler.errorMessageHandling(3);
            }
            else if(GUI.GUIProj != null)
            {
                extensionSolidWorks = comb_ExtentionList.Text;
                PartAssySolidWorkstoOpen = listBox_FileList.SelectedItem.ToString();

                SolidWorksCreation.openPartAssy();
            }
            else
            {
                ErrorHandler.errorMessageHandling(1);
            }
        }
   
        private void btn_SaveUserName_Click(object sender, EventArgs e)
        {
            AuthorName = i_UserName.Text;
            pnlAuthorName.Hide();

            toolStripMenuItem_ConfigurationAuthorName.BackColor = System.Drawing.Color.Gray;
            toolStripMenuItem_ConfigurationAuthorName.Enabled = false;

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

            string[] extensions = new string[] { "PDF", "SLDPRT", "SLDASM", "STEP", "STL" };
            comb_ExtentionList.Items.AddRange(extensions);
            comb_ExtentionList.SelectedItem = extensions[0];
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
