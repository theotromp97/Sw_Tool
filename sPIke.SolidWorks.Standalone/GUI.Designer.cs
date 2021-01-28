namespace sPIke.SolidWorks.Standalone
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Configuration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ConfigurationSolidworks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ConfigurationProjectfolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ConfigurationAuthorName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewSWCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewSWCreatePart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewSWCreateAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewExportSWDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewExportSWStep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrowsingDialog_ProjectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.comb_ProjectList = new System.Windows.Forms.ComboBox();
            this.listBox_FileList = new System.Windows.Forms.ListBox();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.lbl_Extension = new System.Windows.Forms.Label();
            this.comb_ExtentionList = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pic_Preview = new System.Windows.Forms.PictureBox();
            this.btnCreateDrawing = new System.Windows.Forms.Button();
            this.pnlAuthorName = new System.Windows.Forms.Panel();
            this.btn_SaveUserName = new System.Windows.Forms.Button();
            this.i_UserName = new System.Windows.Forms.TextBox();
            this.lbl_EnterName = new System.Windows.Forms.Label();
            this.btn_OpenPartAssySpecs = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).BeginInit();
            this.pnlAuthorName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Configuration,
            this.toolStripMenuItem_New,
            this.toolStripMenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Configuration
            // 
            this.toolStripMenuItem_Configuration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ConfigurationSolidworks,
            this.toolStripMenuItem_ConfigurationProjectfolder,
            this.toolStripMenuItem_ConfigurationAuthorName});
            this.toolStripMenuItem_Configuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem_Configuration.Name = "toolStripMenuItem_Configuration";
            this.toolStripMenuItem_Configuration.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem_Configuration.Text = "Configuration";
            // 
            // toolStripMenuItem_ConfigurationSolidworks
            // 
            this.toolStripMenuItem_ConfigurationSolidworks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_ConfigurationSolidworks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance,
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance});
            this.toolStripMenuItem_ConfigurationSolidworks.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_ConfigurationSolidworks.Name = "toolStripMenuItem_ConfigurationSolidworks";
            this.toolStripMenuItem_ConfigurationSolidworks.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_ConfigurationSolidworks.Text = "SolidWorks";
            // 
            // toolStripMenuItem_ConfigurationSolidworksStartinstance
            // 
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.Name = "toolStripMenuItem_ConfigurationSolidworksStartinstance";
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.Text = "Start Instance";
            this.toolStripMenuItem_ConfigurationSolidworksStartinstance.Click += new System.EventHandler(this.startInstanceToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem_ConfigurationSolidworksCloseinstance
            // 
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.Name = "toolStripMenuItem_ConfigurationSolidworksCloseinstance";
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.Text = "Close Instance";
            this.toolStripMenuItem_ConfigurationSolidworksCloseinstance.Click += new System.EventHandler(this.exitInstanceToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem_ConfigurationProjectfolder
            // 
            this.toolStripMenuItem_ConfigurationProjectfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_ConfigurationProjectfolder.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_ConfigurationProjectfolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem_ConfigurationProjectfolder.Name = "toolStripMenuItem_ConfigurationProjectfolder";
            this.toolStripMenuItem_ConfigurationProjectfolder.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_ConfigurationProjectfolder.Text = "Project folder";
            this.toolStripMenuItem_ConfigurationProjectfolder.Click += new System.EventHandler(this.projectFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_ConfigurationAuthorName
            // 
            this.toolStripMenuItem_ConfigurationAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_ConfigurationAuthorName.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_ConfigurationAuthorName.Name = "toolStripMenuItem_ConfigurationAuthorName";
            this.toolStripMenuItem_ConfigurationAuthorName.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_ConfigurationAuthorName.Text = "Author Name";
            this.toolStripMenuItem_ConfigurationAuthorName.Click += new System.EventHandler(this.toolStripMenuItem_ConfigurationAuthorName_Click);
            // 
            // toolStripMenuItem_New
            // 
            this.toolStripMenuItem_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewSWCreate,
            this.toolStripMenuItem_NewExport});
            this.toolStripMenuItem_New.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_New.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem_New.Name = "toolStripMenuItem_New";
            this.toolStripMenuItem_New.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem_New.Text = "New";
            // 
            // toolStripMenuItem_NewSWCreate
            // 
            this.toolStripMenuItem_NewSWCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_NewSWCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewSWCreatePart,
            this.toolStripMenuItem_NewSWCreateAssembly});
            this.toolStripMenuItem_NewSWCreate.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_NewSWCreate.Name = "toolStripMenuItem_NewSWCreate";
            this.toolStripMenuItem_NewSWCreate.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem_NewSWCreate.Text = "SW Create";
            // 
            // toolStripMenuItem_NewSWCreatePart
            // 
            this.toolStripMenuItem_NewSWCreatePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_NewSWCreatePart.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_NewSWCreatePart.Name = "toolStripMenuItem_NewSWCreatePart";
            this.toolStripMenuItem_NewSWCreatePart.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem_NewSWCreatePart.Text = "SW Part";
            this.toolStripMenuItem_NewSWCreatePart.Click += new System.EventHandler(this.toolStripMenuItem_NewSWCreatePart_Click);
            // 
            // toolStripMenuItem_NewSWCreateAssembly
            // 
            this.toolStripMenuItem_NewSWCreateAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripMenuItem_NewSWCreateAssembly.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_NewSWCreateAssembly.Name = "toolStripMenuItem_NewSWCreateAssembly";
            this.toolStripMenuItem_NewSWCreateAssembly.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem_NewSWCreateAssembly.Text = "SW Assembly";
            this.toolStripMenuItem_NewSWCreateAssembly.Click += new System.EventHandler(this.toolStripMenuItem_NewSWCreateAssembly_Click);
            // 
            // toolStripMenuItem_NewExport
            // 
            this.toolStripMenuItem_NewExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewExportSWDrawing,
            this.toolStripMenuItem_NewExportSWStep});
            this.toolStripMenuItem_NewExport.Name = "toolStripMenuItem_NewExport";
            this.toolStripMenuItem_NewExport.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem_NewExport.Text = "Export";
            // 
            // toolStripMenuItem_NewExportSWDrawing
            // 
            this.toolStripMenuItem_NewExportSWDrawing.Name = "toolStripMenuItem_NewExportSWDrawing";
            this.toolStripMenuItem_NewExportSWDrawing.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_NewExportSWDrawing.Text = "SW Drawing Package";
            // 
            // toolStripMenuItem_NewExportSWStep
            // 
            this.toolStripMenuItem_NewExportSWStep.Name = "toolStripMenuItem_NewExportSWStep";
            this.toolStripMenuItem_NewExportSWStep.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem_NewExportSWStep.Text = "SW STEP Files";
            // 
            // toolStripMenuItem_Help
            // 
            this.toolStripMenuItem_Help.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem_Help.Name = "toolStripMenuItem_Help";
            this.toolStripMenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem_Help.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // comb_ProjectList
            // 
            this.comb_ProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comb_ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_ProjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comb_ProjectList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_ProjectList.ForeColor = System.Drawing.Color.White;
            this.comb_ProjectList.FormattingEnabled = true;
            this.comb_ProjectList.Location = new System.Drawing.Point(154, 56);
            this.comb_ProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.comb_ProjectList.Name = "comb_ProjectList";
            this.comb_ProjectList.Size = new System.Drawing.Size(236, 25);
            this.comb_ProjectList.TabIndex = 16;
            this.comb_ProjectList.SelectedIndexChanged += new System.EventHandler(this.comb_ProjectList_SelectedIndexChanged);
            // 
            // listBox_FileList
            // 
            this.listBox_FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox_FileList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_FileList.ForeColor = System.Drawing.Color.White;
            this.listBox_FileList.FormattingEnabled = true;
            this.listBox_FileList.ItemHeight = 17;
            this.listBox_FileList.Location = new System.Drawing.Point(11, 86);
            this.listBox_FileList.Name = "listBox_FileList";
            this.listBox_FileList.Size = new System.Drawing.Size(379, 463);
            this.listBox_FileList.TabIndex = 17;
            this.listBox_FileList.SelectedIndexChanged += new System.EventHandler(this.listBox_FileList_SelectedIndexChanged);
            // 
            // lbl_Project
            // 
            this.lbl_Project.AutoSize = true;
            this.lbl_Project.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project.ForeColor = System.Drawing.Color.White;
            this.lbl_Project.Location = new System.Drawing.Point(155, 31);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(48, 17);
            this.lbl_Project.TabIndex = 23;
            this.lbl_Project.Text = "Project";
            // 
            // lbl_Extension
            // 
            this.lbl_Extension.AutoSize = true;
            this.lbl_Extension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extension.ForeColor = System.Drawing.Color.White;
            this.lbl_Extension.Location = new System.Drawing.Point(391, 31);
            this.lbl_Extension.Name = "lbl_Extension";
            this.lbl_Extension.Size = new System.Drawing.Size(63, 17);
            this.lbl_Extension.TabIndex = 24;
            this.lbl_Extension.Text = "Extension";
            // 
            // comb_ExtentionList
            // 
            this.comb_ExtentionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.comb_ExtentionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_ExtentionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comb_ExtentionList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_ExtentionList.ForeColor = System.Drawing.Color.White;
            this.comb_ExtentionList.FormattingEnabled = true;
            this.comb_ExtentionList.Location = new System.Drawing.Point(394, 56);
            this.comb_ExtentionList.Margin = new System.Windows.Forms.Padding(2);
            this.comb_ExtentionList.Name = "comb_ExtentionList";
            this.comb_ExtentionList.Size = new System.Drawing.Size(110, 25);
            this.comb_ExtentionList.TabIndex = 25;
            this.comb_ExtentionList.SelectedIndexChanged += new System.EventHandler(this.comb_ExtensionList_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Image = global::sPIke.SolidWorks.Standalone.Properties.Resources.Red_digital_logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 28);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(137, 53);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 26;
            this.pbLogo.TabStop = false;
            // 
            // pic_Preview
            // 
            this.pic_Preview.BackColor = System.Drawing.Color.White;
            this.pic_Preview.Location = new System.Drawing.Point(394, 86);
            this.pic_Preview.Name = "pic_Preview";
            this.pic_Preview.Size = new System.Drawing.Size(404, 463);
            this.pic_Preview.TabIndex = 27;
            this.pic_Preview.TabStop = false;
            // 
            // btnCreateDrawing
            // 
            this.btnCreateDrawing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btnCreateDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateDrawing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateDrawing.FlatAppearance.BorderSize = 0;
            this.btnCreateDrawing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDrawing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDrawing.ForeColor = System.Drawing.Color.White;
            this.btnCreateDrawing.Location = new System.Drawing.Point(581, 55);
            this.btnCreateDrawing.Name = "btnCreateDrawing";
            this.btnCreateDrawing.Size = new System.Drawing.Size(217, 25);
            this.btnCreateDrawing.TabIndex = 28;
            this.btnCreateDrawing.Text = "Open SW Drawing Specifications";
            this.btnCreateDrawing.UseVisualStyleBackColor = false;
            this.btnCreateDrawing.Click += new System.EventHandler(this.btn_CreateDrawing_Click);
            // 
            // pnlAuthorName
            // 
            this.pnlAuthorName.Controls.Add(this.btn_SaveUserName);
            this.pnlAuthorName.Controls.Add(this.i_UserName);
            this.pnlAuthorName.Controls.Add(this.lbl_EnterName);
            this.pnlAuthorName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuthorName.Location = new System.Drawing.Point(0, 501);
            this.pnlAuthorName.Name = "pnlAuthorName";
            this.pnlAuthorName.Size = new System.Drawing.Size(810, 62);
            this.pnlAuthorName.TabIndex = 29;
            // 
            // btn_SaveUserName
            // 
            this.btn_SaveUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btn_SaveUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SaveUserName.FlatAppearance.BorderSize = 0;
            this.btn_SaveUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveUserName.ForeColor = System.Drawing.Color.White;
            this.btn_SaveUserName.Location = new System.Drawing.Point(218, 30);
            this.btn_SaveUserName.Name = "btn_SaveUserName";
            this.btn_SaveUserName.Size = new System.Drawing.Size(127, 25);
            this.btn_SaveUserName.TabIndex = 2;
            this.btn_SaveUserName.Text = "Save Author Name";
            this.btn_SaveUserName.UseVisualStyleBackColor = false;
            this.btn_SaveUserName.Click += new System.EventHandler(this.btn_SaveUserName_Click);
            // 
            // i_UserName
            // 
            this.i_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.i_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i_UserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i_UserName.ForeColor = System.Drawing.Color.White;
            this.i_UserName.Location = new System.Drawing.Point(12, 30);
            this.i_UserName.Name = "i_UserName";
            this.i_UserName.Size = new System.Drawing.Size(200, 25);
            this.i_UserName.TabIndex = 1;
            // 
            // lbl_EnterName
            // 
            this.lbl_EnterName.AutoSize = true;
            this.lbl_EnterName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterName.ForeColor = System.Drawing.Color.White;
            this.lbl_EnterName.Location = new System.Drawing.Point(14, 7);
            this.lbl_EnterName.Name = "lbl_EnterName";
            this.lbl_EnterName.Size = new System.Drawing.Size(104, 17);
            this.lbl_EnterName.TabIndex = 0;
            this.lbl_EnterName.Text = "Enter your name";
            // 
            // btn_OpenPartAssySpecs
            // 
            this.btn_OpenPartAssySpecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btn_OpenPartAssySpecs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_OpenPartAssySpecs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenPartAssySpecs.FlatAppearance.BorderSize = 0;
            this.btn_OpenPartAssySpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenPartAssySpecs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenPartAssySpecs.ForeColor = System.Drawing.Color.White;
            this.btn_OpenPartAssySpecs.Location = new System.Drawing.Point(581, 27);
            this.btn_OpenPartAssySpecs.Name = "btn_OpenPartAssySpecs";
            this.btn_OpenPartAssySpecs.Size = new System.Drawing.Size(217, 25);
            this.btn_OpenPartAssySpecs.TabIndex = 30;
            this.btn_OpenPartAssySpecs.Text = "Open SW Part/Assy Specifications";
            this.btn_OpenPartAssySpecs.UseVisualStyleBackColor = false;
            this.btn_OpenPartAssySpecs.Click += new System.EventHandler(this.btn_OpenSpecs_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(810, 585);
            this.Controls.Add(this.btn_OpenPartAssySpecs);
            this.Controls.Add(this.pnlAuthorName);
            this.Controls.Add(this.btnCreateDrawing);
            this.Controls.Add(this.pic_Preview);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.comb_ExtentionList);
            this.Controls.Add(this.lbl_Extension);
            this.Controls.Add(this.lbl_Project);
            this.Controls.Add(this.listBox_FileList);
            this.Controls.Add(this.comb_ProjectList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI";
            this.Text = "KarPi (Robotics Team Pi)";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).EndInit();
            this.pnlAuthorName.ResumeLayout(false);
            this.pnlAuthorName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewSWCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewSWCreatePart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewSWCreateAssembly;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Configuration;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ConfigurationSolidworks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ConfigurationSolidworksStartinstance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ConfigurationSolidworksCloseinstance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ConfigurationProjectfolder;
        private System.Windows.Forms.FolderBrowserDialog BrowsingDialog_ProjectFolder;
        private System.Windows.Forms.ComboBox comb_ProjectList;
        private System.Windows.Forms.ListBox listBox_FileList;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.Label lbl_Extension;
        private System.Windows.Forms.ComboBox comb_ExtentionList;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pic_Preview;
        private System.Windows.Forms.Button btnCreateDrawing;
        private System.Windows.Forms.Panel pnlAuthorName;
        private System.Windows.Forms.TextBox i_UserName;
        private System.Windows.Forms.Label lbl_EnterName;
        private System.Windows.Forms.Button btn_SaveUserName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ConfigurationAuthorName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewExportSWDrawing;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewExportSWStep;
        private System.Windows.Forms.Button btn_OpenPartAssySpecs;
    }
}

