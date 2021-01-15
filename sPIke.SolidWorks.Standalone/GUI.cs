﻿using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.IO;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public partial class GUI : Form
    {
        public FormManager formManager;
        public static string pthProjFolder;
        public static string AuthorName;
        public static string GUIProj;
        public static string extensionSolidWorks;
        public static string PartAssySolidWorkstoOpen;
        public static string pthDrwtoOpen;
        public static string itmDrwtoOpen;

        public static FileInfo projFiles;

        public GUI(FormManager _formManager)
        {
            formManager = _formManager;
            InitializeComponent();

            string[] extensions = new string[] { "PDF" ,"SLDPRT", "SLDASM", "STEP", "STL" };
            ccbxExtensions.Items.AddRange(extensions);
            ccbxExtensions.SelectedItem = extensions[0];

            formManager.classManager.fileManager.loadProjectListGoogle();

            if (formManager.classManager.fileManager.folstucProjects != null)
            {
                GUIProjList.DataSource = formManager.classManager.fileManager.folstucProjects;
                projectFolderToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
                projectFolderToolStripMenuItem.Enabled = false;
            }


            pnlAuthorName.Hide();
        }

        // check if this can get deleted
        /*
        SldWorks swApp = SolidWorksSingleton.swApp;

        private void GUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (swApp != null)
            {
                toolStripStatusLabel1.Text = "SolidWorks instance exist";
            }
            else if (swApp == null)
            {
                toolStripStatusLabel1.Text = "SolidWorks instance does not exist";
            }

        }
        */
        private void sWPartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (GUI.GUIProj != null)
            {
                formManager.show(formManager.formCreatePart);
            }
            else if (formManager.classManager.swManager.GetSolidWorksInstance())
            {
                ErrorHandler.errorMessageHandling(3);
            }
            else if (AuthorName == null)
            {
                ErrorHandler.errorMessageHandling(2);
            }
            else
            {
                ErrorHandler.errorMessageHandling(1);
            }
        }

        private void sWAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            if (GUI.GUIProj != null)
            {
                formManager.show(formManager.formCreateAssembly);
            }
            else if (formManager.classManager.swManager.GetSolidWorksInstance())
            {
                ErrorHandler.errorMessageHandling(3);
            }
            else if(AuthorName == null)
            {
                ErrorHandler.errorMessageHandling(2);
            }
            else
            {
                ErrorHandler.errorMessageHandling(1);
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
            pthProjFolder = projectfolderBrowsingDialog.SelectedPath + "/";



            GUIProjList.DataSource = formManager.classManager.fileManager.createProjectList();

            showProjectFiles(ccbxExtensions.Text);
        }

        private void showProjectFiles(string fileType)
        {
            projFilesListBox.Items.Clear();

            DirectoryInfo fileDirectoryProj = new DirectoryInfo(pthProjFolder + "/" + GUIProjList.SelectedItem);
            FileInfo[] projFiles = fileDirectoryProj.GetFiles(fileType);
            string[] fileList = formManager.classManager.fileManager.GetFileNames(pthProjFolder + "/" + GUIProjList.SelectedItem, fileType);

            if (fileList.Length > 0)
            {
                projFilesListBox.Items.Add(fileList);
            }
        }

        private void GUIProjList_SelectedIndexChanged(object sender, EventArgs e)
        {
            projFilesListBox.Items.Clear();
            showProjectFiles("*." + ccbxExtensions.SelectedItem);

            GUIProj = GUIProjList.SelectedItem.ToString();
        }

        private void ccbxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            projFilesListBox.Items.Clear();
            showProjectFiles("*." + ccbxExtensions.SelectedItem);
        }

        private void projFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Bitmap previewPicture;

            //string projFilePreview = GUI.pthProjFolder + "/" + projFilesListBox.SelectedItem.ToString();
            string projFilePreview = "G:/Gedeelde drives/RTPI Projects/EXPO_201/12 T small pulley.SLDPRT";

            //System.Drawing.Image.GetThumbnailImageAbort myCallback = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
            //System.Drawing.Bitmap myBitmap = new System.Drawing.Bitmap("Climber.jpg");
            // System.Drawing.Image myThumbnail = myBitmap.GetThumbnailImage(
            // 40, 40, myCallback, IntPtr.Zero);

            //previewBox.Image = System.Drawing.Image.FromFile(projFilePreview);


            

        }

        private void btnCreateDrawing_Click(object sender, EventArgs e)
        {
            if (formManager.classManager.swManager.GetSolidWorksInstance())
            {
                if (GUIProj != null && projFilesListBox.SelectedItem != null && ccbxExtensions.Text == "SLDPRT" || ccbxExtensions.Text == "SLDASM")
                {
                    PartAssySolidWorkstoOpen = projFilesListBox.SelectedItem.ToString();
                    pthDrwtoOpen = GUI.pthProjFolder + "\\" + GUI.GUIProj + "\\" + GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";
                    itmDrwtoOpen = GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";

                    showProjectFiles("*.SLDDRW");

                    if (projFilesListBox.Items.Contains(itmDrwtoOpen) == true)
                    {
                        //SolidWorksCreation.createSWDrawing(false);
                        //formManager.classManager.swManager.CreateNewDrawing();
                    }
                    else
                    {
                        //SolidWorksCreation.createSWDrawing(true);
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

            showProjectFiles("*." + ccbxExtensions.SelectedItem);
        }

        private void appAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAuthorName.Show();
        }

        private void btnFileListRefresh(object sender, EventArgs e)
        {
            showProjectFiles("*." + ccbxExtensions.SelectedItem);
        }

        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            AuthorName = txtbxAuthorName.Text;
            pnlAuthorName.Hide();

            authorNameToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            authorNameToolStripMenuItem.Enabled = false;
        }

        private void btnPartAssySpecs_Click(object sender, EventArgs e)
        {
            if (formManager.classManager.swManager.GetSolidWorksInstance())
            {
                ErrorHandler.errorMessageHandling(3);
            }
            else if(GUI.GUIProj != null)
            {
                extensionSolidWorks = ccbxExtensions.Text;
                PartAssySolidWorkstoOpen = projFilesListBox.SelectedItem.ToString();

                //SolidWorksCreation.openPartAssy();
            }
            else
            {
                ErrorHandler.errorMessageHandling(1);
            }
        }
    }
}
