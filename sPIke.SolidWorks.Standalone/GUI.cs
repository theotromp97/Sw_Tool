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

            GUIcode.loadProjectListGoogle();

            if (GUIcode.folstucProjects != null)
            {
                GUIProjList.DataSource = GUIcode.folstucProjects;
                projectFolderToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
                projectFolderToolStripMenuItem.Enabled = false;
            }


            pnlAuthorName.Hide();
        }

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

        private void sWPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManager.show(formManager.formCreatePart);
            //CreatePart partCreation = new CreatePart();

            if (GUI.GUIProj != null)
            {
                partCreation.Show();
            }
            else if (swApp == null)
            {
                GUIcode.errorMessageHanding(3);
            }
            else if (AuthorName == null)
            {
                GUIcode.errorMessageHanding(2);
            }
            else
            {
                GUIcode.errorMessageHanding(1);
            }
        }

        private void sWAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAssembly assemblyCreation = new CreateAssembly();
                        
            if (GUI.GUIProj != null)
            {
                assemblyCreation.Show();
            }
            else if (swApp == null)
            {
                GUIcode.errorMessageHanding(3);
            }
            else if(AuthorName == null)
            {
                GUIcode.errorMessageHanding(2);
            }
            else
            {
                GUIcode.errorMessageHanding(1);
            }
        }

        private async void startInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            swApp = await SolidWorksSingleton.getApplication();
        }

        private void exitInstanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SolidWorksSingleton.Dispose();
            swApp = SolidWorksSingleton.swApp;
        }

        private void projectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectfolderBrowsingDialog.ShowDialog();
            pthProjFolder = projectfolderBrowsingDialog.SelectedPath;

            GUIcode.createProjectList();

            GUIProjList.DataSource = GUIcode.folstucProjects;

            showProjectFiles("*." + ccbxExtensions.SelectedItem);
        }

        private void showProjectFiles(string fileType)
        {
            projFilesListBox.Items.Clear();

            DirectoryInfo fileDirectoryProj = new DirectoryInfo(pthProjFolder + "/" + GUIProjList.SelectedItem);
            FileInfo[] projFiles = fileDirectoryProj.GetFiles(fileType);

            foreach (FileInfo file in projFiles)
            {
                projFilesListBox.Items.Add(file.Name);
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
            if (swApp != null)
            {
                if (GUIProj != null && projFilesListBox.SelectedItem != null && ccbxExtensions.Text == "SLDPRT" || ccbxExtensions.Text == "SLDASM")
                {
                    PartAssySolidWorkstoOpen = projFilesListBox.SelectedItem.ToString();
                    pthDrwtoOpen = GUI.pthProjFolder + "\\" + GUI.GUIProj + "\\" + GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";
                    itmDrwtoOpen = GUI.PartAssySolidWorkstoOpen.Remove(GUI.PartAssySolidWorkstoOpen.Length - 7, 7) + ".SLDDRW";

                    showProjectFiles("*.SLDDRW");

                    if (projFilesListBox.Items.Contains(itmDrwtoOpen) == true)
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
                    GUIcode.errorMessageHanding(1);
                }
            }
            else
            {
                GUIcode.errorMessageHanding(3);
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
            if (swApp == null)
            {
                GUIcode.errorMessageHanding(3);
            }
            else if(GUI.GUIProj != null)
            {
                extensionSolidWorks = ccbxExtensions.Text;
                PartAssySolidWorkstoOpen = projFilesListBox.SelectedItem.ToString();

                SolidWorksCreation.openPartAssy();
            }
            else
            {
                GUIcode.errorMessageHanding(1);
            }
        }
    }
}
