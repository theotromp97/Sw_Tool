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
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidWorksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWDrawingPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWSTEPFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectfolderBrowsingDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GUIProjList = new System.Windows.Forms.ComboBox();
            this.projFilesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbxExtensions = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.btnCreateDrawing = new System.Windows.Forms.Button();
            this.pnlAuthorName = new System.Windows.Forms.Panel();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.txtbxAuthorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPartAssySpecs = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.pnlAuthorName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidWorksToolStripMenuItem,
            this.projectFolderToolStripMenuItem,
            this.authorNameToolStripMenuItem});
            this.configurationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // solidWorksToolStripMenuItem
            // 
            this.solidWorksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.solidWorksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startInstanceToolStripMenuItem,
            this.exitInstanceToolStripMenuItem});
            this.solidWorksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.solidWorksToolStripMenuItem.Name = "solidWorksToolStripMenuItem";
            this.solidWorksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solidWorksToolStripMenuItem.Text = "SolidWorks";
            // 
            // startInstanceToolStripMenuItem
            // 
            this.startInstanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.startInstanceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.startInstanceToolStripMenuItem.Name = "startInstanceToolStripMenuItem";
            this.startInstanceToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.startInstanceToolStripMenuItem.Text = "Start Instance";
            this.startInstanceToolStripMenuItem.Click += new System.EventHandler(this.startInstanceToolStripMenuItem1_Click);
            // 
            // exitInstanceToolStripMenuItem
            // 
            this.exitInstanceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.exitInstanceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitInstanceToolStripMenuItem.Name = "exitInstanceToolStripMenuItem";
            this.exitInstanceToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitInstanceToolStripMenuItem.Text = "Exit Instance";
            this.exitInstanceToolStripMenuItem.Click += new System.EventHandler(this.exitInstanceToolStripMenuItem1_Click);
            // 
            // projectFolderToolStripMenuItem
            // 
            this.projectFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.projectFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.projectFolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projectFolderToolStripMenuItem.Name = "projectFolderToolStripMenuItem";
            this.projectFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectFolderToolStripMenuItem.Text = "Project folder";
            this.projectFolderToolStripMenuItem.Click += new System.EventHandler(this.projectFolderToolStripMenuItem_Click);
            // 
            // authorNameToolStripMenuItem
            // 
            this.authorNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.authorNameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.authorNameToolStripMenuItem.Name = "authorNameToolStripMenuItem";
            this.authorNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorNameToolStripMenuItem.Text = "Author Name";
            this.authorNameToolStripMenuItem.Click += new System.EventHandler(this.appAuthorToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.optionsToolStripMenuItem.Text = "Creation";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sWPartToolStripMenuItem,
            this.sWAssemblyToolStripMenuItem});
            this.createToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.createToolStripMenuItem.Text = "SW Create";
            // 
            // sWPartToolStripMenuItem
            // 
            this.sWPartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.sWPartToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sWPartToolStripMenuItem.Name = "sWPartToolStripMenuItem";
            this.sWPartToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sWPartToolStripMenuItem.Text = "SW Part";
            this.sWPartToolStripMenuItem.Click += new System.EventHandler(this.sWPartToolStripMenuItem_Click);
            // 
            // sWAssemblyToolStripMenuItem
            // 
            this.sWAssemblyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.sWAssemblyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sWAssemblyToolStripMenuItem.Name = "sWAssemblyToolStripMenuItem";
            this.sWAssemblyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sWAssemblyToolStripMenuItem.Text = "SW Assembly";
            this.sWAssemblyToolStripMenuItem.Click += new System.EventHandler(this.sWAssemblyToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sWDrawingPackageToolStripMenuItem,
            this.sWSTEPFilesToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // sWDrawingPackageToolStripMenuItem
            // 
            this.sWDrawingPackageToolStripMenuItem.Name = "sWDrawingPackageToolStripMenuItem";
            this.sWDrawingPackageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sWDrawingPackageToolStripMenuItem.Text = "SW Drawing Package";
            // 
            // sWSTEPFilesToolStripMenuItem
            // 
            this.sWSTEPFilesToolStripMenuItem.Name = "sWSTEPFilesToolStripMenuItem";
            this.sWSTEPFilesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sWSTEPFilesToolStripMenuItem.Text = "SW STEP Files";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            // GUIProjList
            // 
            this.GUIProjList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GUIProjList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GUIProjList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GUIProjList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIProjList.ForeColor = System.Drawing.Color.White;
            this.GUIProjList.FormattingEnabled = true;
            this.GUIProjList.Location = new System.Drawing.Point(154, 56);
            this.GUIProjList.Margin = new System.Windows.Forms.Padding(2);
            this.GUIProjList.Name = "GUIProjList";
            this.GUIProjList.Size = new System.Drawing.Size(236, 25);
            this.GUIProjList.TabIndex = 16;
            this.GUIProjList.SelectedIndexChanged += new System.EventHandler(this.GUIProjList_SelectedIndexChanged);
            // 
            // projFilesListBox
            // 
            this.projFilesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.projFilesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projFilesListBox.ForeColor = System.Drawing.Color.White;
            this.projFilesListBox.FormattingEnabled = true;
            this.projFilesListBox.ItemHeight = 17;
            this.projFilesListBox.Location = new System.Drawing.Point(11, 86);
            this.projFilesListBox.Name = "projFilesListBox";
            this.projFilesListBox.Size = new System.Drawing.Size(379, 463);
            this.projFilesListBox.TabIndex = 17;
            this.projFilesListBox.SelectedIndexChanged += new System.EventHandler(this.projFilesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Extension";
            // 
            // ccbxExtensions
            // 
            this.ccbxExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ccbxExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbxExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccbxExtensions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbxExtensions.ForeColor = System.Drawing.Color.White;
            this.ccbxExtensions.FormattingEnabled = true;
            this.ccbxExtensions.Location = new System.Drawing.Point(394, 56);
            this.ccbxExtensions.Margin = new System.Windows.Forms.Padding(2);
            this.ccbxExtensions.Name = "ccbxExtensions";
            this.ccbxExtensions.Size = new System.Drawing.Size(110, 25);
            this.ccbxExtensions.TabIndex = 25;
            this.ccbxExtensions.SelectedIndexChanged += new System.EventHandler(this.ccbxExtensions_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::sPIke.SolidWorks.Standalone.Properties.Resources.Red_digital_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.White;
            this.previewBox.Location = new System.Drawing.Point(394, 86);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(404, 463);
            this.previewBox.TabIndex = 27;
            this.previewBox.TabStop = false;
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
            this.btnCreateDrawing.Click += new System.EventHandler(this.btnCreateDrawing_Click);
            // 
            // pnlAuthorName
            // 
            this.pnlAuthorName.Controls.Add(this.btnAuthorSave);
            this.pnlAuthorName.Controls.Add(this.txtbxAuthorName);
            this.pnlAuthorName.Controls.Add(this.label3);
            this.pnlAuthorName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAuthorName.Location = new System.Drawing.Point(0, 501);
            this.pnlAuthorName.Name = "pnlAuthorName";
            this.pnlAuthorName.Size = new System.Drawing.Size(810, 62);
            this.pnlAuthorName.TabIndex = 29;
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btnAuthorSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAuthorSave.FlatAppearance.BorderSize = 0;
            this.btnAuthorSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorSave.ForeColor = System.Drawing.Color.White;
            this.btnAuthorSave.Location = new System.Drawing.Point(218, 30);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(127, 25);
            this.btnAuthorSave.TabIndex = 2;
            this.btnAuthorSave.Text = "Save Author Name";
            this.btnAuthorSave.UseVisualStyleBackColor = false;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // txtbxAuthorName
            // 
            this.txtbxAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtbxAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxAuthorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAuthorName.ForeColor = System.Drawing.Color.White;
            this.txtbxAuthorName.Location = new System.Drawing.Point(12, 30);
            this.txtbxAuthorName.Name = "txtbxAuthorName";
            this.txtbxAuthorName.Size = new System.Drawing.Size(200, 25);
            this.txtbxAuthorName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your name";
            // 
            // btnPartAssySpecs
            // 
            this.btnPartAssySpecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btnPartAssySpecs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPartAssySpecs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartAssySpecs.FlatAppearance.BorderSize = 0;
            this.btnPartAssySpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartAssySpecs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAssySpecs.ForeColor = System.Drawing.Color.White;
            this.btnPartAssySpecs.Location = new System.Drawing.Point(581, 27);
            this.btnPartAssySpecs.Name = "btnPartAssySpecs";
            this.btnPartAssySpecs.Size = new System.Drawing.Size(217, 25);
            this.btnPartAssySpecs.TabIndex = 30;
            this.btnPartAssySpecs.Text = "Open SW Part/Assy Specifications";
            this.btnPartAssySpecs.UseVisualStyleBackColor = false;
            this.btnPartAssySpecs.Click += new System.EventHandler(this.btnPartAssySpecs_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(810, 585);
            this.Controls.Add(this.btnPartAssySpecs);
            this.Controls.Add(this.pnlAuthorName);
            this.Controls.Add(this.btnCreateDrawing);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ccbxExtensions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projFilesListBox);
            this.Controls.Add(this.GUIProjList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUI";
            this.Text = "KarPi (Robotics Team Pi)";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GUI_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.pnlAuthorName.ResumeLayout(false);
            this.pnlAuthorName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWAssemblyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidWorksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startInstanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitInstanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog projectfolderBrowsingDialog;
        private System.Windows.Forms.ComboBox GUIProjList;
        private System.Windows.Forms.ListBox projFilesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ccbxExtensions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button btnCreateDrawing;
        private System.Windows.Forms.Panel pnlAuthorName;
        private System.Windows.Forms.TextBox txtbxAuthorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.ToolStripMenuItem authorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWDrawingPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWSTEPFilesToolStripMenuItem;
        private System.Windows.Forms.Button btnPartAssySpecs;
    }
}

