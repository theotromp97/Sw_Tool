namespace sPIke.SolidWorks.Standalone
{
    partial class CreateAssembly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAssembly));
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPartNumberRefresh = new System.Windows.Forms.Button();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.btnCreateAssembly = new System.Windows.Forms.Button();
            this.ssLabelHelper = new System.Windows.Forms.StatusStrip();
            this.tsslHelper = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbbxProjectList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbxAssyType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxAssyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrefixAssyName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.ssLabelHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New assembly creation for Robotics Team Pi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(73, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Author";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPartNumberRefresh
            // 
            this.btnPartNumberRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPartNumberRefresh.BackgroundImage")));
            this.btnPartNumberRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartNumberRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartNumberRefresh.FlatAppearance.BorderSize = 0;
            this.btnPartNumberRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartNumberRefresh.Location = new System.Drawing.Point(307, 139);
            this.btnPartNumberRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartNumberRefresh.Name = "btnPartNumberRefresh";
            this.btnPartNumberRefresh.Size = new System.Drawing.Size(19, 20);
            this.btnPartNumberRefresh.TabIndex = 38;
            this.btnPartNumberRefresh.UseVisualStyleBackColor = true;
            this.btnPartNumberRefresh.Click += new System.EventHandler(this.btnPartNumberRefresh_Click);
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.ForeColor = System.Drawing.Color.White;
            this.lblPartNumber.Location = new System.Drawing.Point(125, 139);
            this.lblPartNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(121, 19);
            this.lblPartNumber.TabIndex = 37;
            this.lblPartNumber.Text = "Assembly Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Assembly Number";
            // 
            // btnCancelPart
            // 
            this.btnCancelPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btnCancelPart.FlatAppearance.BorderSize = 0;
            this.btnCancelPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPart.ForeColor = System.Drawing.Color.White;
            this.btnCancelPart.Location = new System.Drawing.Point(45, 233);
            this.btnCancelPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelPart.Name = "btnCancelPart";
            this.btnCancelPart.Size = new System.Drawing.Size(107, 46);
            this.btnCancelPart.TabIndex = 40;
            this.btnCancelPart.Text = "Cancel";
            this.btnCancelPart.UseVisualStyleBackColor = false;
            this.btnCancelPart.Click += new System.EventHandler(this.btnCancelPart_Click);
            // 
            // btnCreateAssembly
            // 
            this.btnCreateAssembly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.btnCreateAssembly.FlatAppearance.BorderSize = 0;
            this.btnCreateAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAssembly.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAssembly.ForeColor = System.Drawing.Color.White;
            this.btnCreateAssembly.Location = new System.Drawing.Point(194, 233);
            this.btnCreateAssembly.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAssembly.Name = "btnCreateAssembly";
            this.btnCreateAssembly.Size = new System.Drawing.Size(107, 46);
            this.btnCreateAssembly.TabIndex = 39;
            this.btnCreateAssembly.Text = "Create Assembly";
            this.btnCreateAssembly.UseVisualStyleBackColor = false;
            this.btnCreateAssembly.Click += new System.EventHandler(this.btnCreateAssembly_Click);
            // 
            // ssLabelHelper
            // 
            this.ssLabelHelper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.ssLabelHelper.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssLabelHelper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslHelper});
            this.ssLabelHelper.Location = new System.Drawing.Point(0, 288);
            this.ssLabelHelper.Name = "ssLabelHelper";
            this.ssLabelHelper.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssLabelHelper.Size = new System.Drawing.Size(334, 22);
            this.ssLabelHelper.TabIndex = 41;
            // 
            // tsslHelper
            // 
            this.tsslHelper.ForeColor = System.Drawing.Color.White;
            this.tsslHelper.Name = "tsslHelper";
            this.tsslHelper.Size = new System.Drawing.Size(0, 17);
            // 
            // cbbxProjectList
            // 
            this.cbbxProjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbbxProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxProjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbxProjectList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxProjectList.ForeColor = System.Drawing.Color.White;
            this.cbbxProjectList.FormattingEnabled = true;
            this.cbbxProjectList.Location = new System.Drawing.Point(129, 76);
            this.cbbxProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxProjectList.Name = "cbbxProjectList";
            this.cbbxProjectList.Size = new System.Drawing.Size(172, 27);
            this.cbbxProjectList.TabIndex = 43;
            this.cbbxProjectList.SelectedIndexChanged += new System.EventHandler(this.cbbxProjectList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(72, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbxAssyType
            // 
            this.cbbxAssyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbbxAssyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbxAssyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbxAssyType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxAssyType.ForeColor = System.Drawing.Color.White;
            this.cbbxAssyType.FormattingEnabled = true;
            this.cbbxAssyType.Items.AddRange(new object[] {
            "Weldment Assembly",
            "Normal Assembly",
            "Main Assembly"});
            this.cbbxAssyType.Location = new System.Drawing.Point(129, 107);
            this.cbbxAssyType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbxAssyType.Name = "cbbxAssyType";
            this.cbbxAssyType.Size = new System.Drawing.Size(172, 27);
            this.cbbxAssyType.TabIndex = 45;
            this.cbbxAssyType.SelectedIndexChanged += new System.EventHandler(this.cbbxAssyType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Assembly type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(41, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Prefix Name";
            // 
            // txtbxAssyName
            // 
            this.txtbxAssyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtbxAssyName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAssyName.ForeColor = System.Drawing.Color.White;
            this.txtbxAssyName.Location = new System.Drawing.Point(129, 195);
            this.txtbxAssyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxAssyName.Name = "txtbxAssyName";
            this.txtbxAssyName.Size = new System.Drawing.Size(172, 26);
            this.txtbxAssyName.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(49)))), ((int)(((byte)(47)))));
            this.label6.Location = new System.Drawing.Point(18, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Assembly Name";
            // 
            // lblPrefixAssyName
            // 
            this.lblPrefixAssyName.AutoSize = true;
            this.lblPrefixAssyName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefixAssyName.ForeColor = System.Drawing.Color.White;
            this.lblPrefixAssyName.Location = new System.Drawing.Point(127, 168);
            this.lblPrefixAssyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrefixAssyName.Name = "lblPrefixAssyName";
            this.lblPrefixAssyName.Size = new System.Drawing.Size(142, 19);
            this.lblPrefixAssyName.TabIndex = 50;
            this.lblPrefixAssyName.Text = "Assembly prefix name";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.White;
            this.lblAuthorName.Location = new System.Drawing.Point(127, 49);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(92, 19);
            this.lblAuthorName.TabIndex = 51;
            this.lblAuthorName.Text = "Author Name";
            // 
            // CreateAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(334, 310);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblPrefixAssyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxAssyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbxAssyType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbxProjectList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssLabelHelper);
            this.Controls.Add(this.btnCancelPart);
            this.Controls.Add(this.btnCreateAssembly);
            this.Controls.Add(this.btnPartNumberRefresh);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateAssembly";
            this.Text = "CreateAssembly";
            this.Load += new System.EventHandler(this.CreateAssembly_Load);
            this.ssLabelHelper.ResumeLayout(false);
            this.ssLabelHelper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPartNumberRefresh;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelPart;
        private System.Windows.Forms.Button btnCreateAssembly;
        private System.Windows.Forms.StatusStrip ssLabelHelper;
        private System.Windows.Forms.ToolStripStatusLabel tsslHelper;
        private System.Windows.Forms.ComboBox cbbxProjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbxAssyType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxAssyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrefixAssyName;
        private System.Windows.Forms.Label lblAuthorName;
    }
}