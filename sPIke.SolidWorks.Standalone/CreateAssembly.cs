using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sPIke.SolidWorks.Standalone
{
    public partial class CreateAssembly : Form
    {
        public static string txtAuthor;
        public static string txtAssyName;
        public static string choforProject;
        public static string choforAssyType;

        public CreateAssembly()
        {
            InitializeComponent();
        }

        private void CreateAssembly_Load(object sender, EventArgs e)
        {
            GUIcode.createProjectList();
            cbbxProjectList.DataSource = GUIcode.folstucProjects;

            lblAuthorName.Text = GUI.AuthorName;
        }

        private void btnCreateAssembly_Click(object sender, EventArgs e)
        {
            txtAuthor = lblAuthorName.Text;
            txtAssyName = txtbxAssyName.Text;
        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPartNumberRefresh_Click(object sender, EventArgs e)
        {
            SolidWorksCreation.createPartNumber(1);
            string forPartNumber = SolidWorksCreation.PartNumber;

            lblPartNumber.Text = forPartNumber;
        }

        private void cbbxProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecProject = cbbxProjectList.SelectedItem;
            choforProject = selecProject.ToString();
        }

        private void cbbxAssyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecItemType = cbbxAssyType.SelectedItem;
            choforAssyType = selecItemType.ToString();

            SolidWorksCreation.createPrefixAssyName();

            lblPrefixAssyName.Text = SolidWorksCreation.prefixAssyName;
        }
    }
}