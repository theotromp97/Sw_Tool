using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public partial class CreatePart : Form
    {

        public FormManager formManager;

        public static string choforProject;
        public static string choforItemType;
        public static string pthfileName;
        public static string txtAuthor;
        public static string txtManName;
        public static string txtVenName;
        public static string txtVenCost;
        public static string txtVenSKU;
        public static string txtVendor;

        public static int modifiedCheck;
        public static int exisCheck;
       

        public CreatePart(FormManager _formManager)
        {
            formManager = _formManager;
            InitializeComponent();
        }


        private void createPart_Load(object sender, EventArgs e)
        {
            formManager.classManager.fileManager.createProjectList();
            cbbxProjectList.DataSource = formManager.classManager.fileManager.folstucProjects;

            pnlManuComp.Hide();
            pnlVendComp.Hide();
            pnlExisYes.Hide();
            pnlExisNo.Hide();

            modifiedCheck = 0;

            string[] Vendors = new string[] { "VEXPRO Robotics", "Cross the Road Electronics", "Elobau", "MISUMI", "AndyMark", "REVRobotics", "BaneBots", "Steenkist", "SMC", "RS Components", "247Industries", "ERIKS", "IGUS", "Helukabel", "123-3D", "Newton Automation", "MCB" };
            cbbxVendor.Items.AddRange(Vendors);

            lblAuthorName.Text = GUI.AuthorName;
        }

        /// <summary>
        /// 
        /// </summary>

        private void btnCreatePart_Click(object sender, EventArgs e)
        {
            txtAuthor = lblAuthorName.Text;
            txtManName = txtbxPartName.Text;
            txtVenName = txtExisPartName.Text;
            txtVenCost = txtVendCosts.Text + " " + cbbxValuta.Text;
            txtVenSKU = txtSKU.Text;
            txtVendor = cbbxVendor.Text;

            //formManager.classManager.swManager.CreateNewPart();

            txtbxPartName.Text = "";
            txtExisPartName.Text = "";
            txtVendCosts.Text = "";
            txtSKU.Text = "";
            cbbxVendor.Text = "";
        }

        /// <summary>
        /// Refresh the number so it can be used for a part
        /// </summary>

        private void btnPartNumberRefresh_Click(object sender, EventArgs e)
        {
            SolidWorksCreation.createPartNumber(1);
            string forPartNumber = SolidWorksCreation.PartNumber;

            lblPartNumber.Text = forPartNumber;
        }

        /// <summary>
        /// 
        /// </summary>

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            karPiopenFileDialogExisPart.ShowDialog();
            pthfileName = karPiopenFileDialogExisPart.FileName;
            string exisPartFileName = Path.GetFileName(pthfileName);

            txtExisPart.Text = exisPartFileName;
        }

        /// <summary>
        /// All label helper status changes
        /// </summary>

        private void cbbxProjectList_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Select the project where the part needs to be added to.";
        }

        private void cbbxProjectList_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void cbbxItemType_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Select the item type for the part you are going to create.";
        }

        private void cbbxItemType_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void btnCancelPart_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Cancel the creation of a part.";
        }

        private void btnCancelPart_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void btnCreatePart_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Create the part with number " + lblPartNumber.Text + ".";
        }

        private void btnCreatePart_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void btnPartNumberRefresh_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Refreshes the part number.";
        }

        private void btnPartNumberRefresh_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void cbbxVendor_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Choose the vendor that sells the product";
        }

        private void cbbxVendor_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void txtSKU_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Enter the SKU# of the product.";
        }

        private void txtSKU_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void cbbxValuta_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Choose the valuta that the product is sold in.";
        }

        private void cbbxValuta_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void txtVendCosts_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Enter the price of the product.";
        }

        private void txtVendCosts_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void rbModiYes_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Enter if the product is being modified.";
        }

        private void rbModiYes_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void rbModiNo_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Enter if the product is being modified.";
        }

        private void rbModiNo_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void txtbxPartName_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Fill in a (functional) part name.";
        }

        private void txtbxPartName_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        private void txtbxAuthor_MouseHover(object sender, EventArgs e)
        {
            tsslHelper.Text = "Fill in your full name.";
        }

        private void txtbxAuthor_MouseLeave(object sender, EventArgs e)
        {
            tsslHelper.Text = "Hover on top of a textbox to see extra information.";
        }

        ///<summary>
        ///Updates the variables in SolidWorksPartCreation 
        ///</summary>

        private void cbbxProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecProject = cbbxProjectList.SelectedItem;
            choforProject = selecProject.ToString();
        }

        private void cbbxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecItemType = cbbxItemType.SelectedItem;
            choforItemType = selecItemType.ToString();

            if(cbbxItemType.SelectedItem.ToString() == "Manufactured")
            {
                exisCheck = 0;

                pnlVendComp.Hide();
                pnlManuComp.Show();
            }
            else if(cbbxItemType.SelectedItem.ToString() == "Vendor")
            {
                pnlManuComp.Hide();
                pnlVendComp.Show();
            }
        }

        private void rbModiYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModiYes.Checked == true)
            {
                modifiedCheck = 1;
            }
        }

        private void rbModiNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModiNo.Checked == true)
            {
                modifiedCheck = 2;
            }
        }

        private void rbExisYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExisYes.Checked == true)
            {
                pnlExisNo.Hide();
                pnlExisYes.Show();

                exisCheck = 1;
            }
        }

        private void rbExisNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExisNo.Checked == true)
            {
                pnlExisYes.Hide();
                pnlExisNo.Show();

                exisCheck = 2;
            }
        }

        ///<summary>
        /// Close the create a part form
        /// </summary>

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
