﻿namespace ManageProjectStudent_View
{
    partial class frmManageLecturerInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLecturerInformation));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExportList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageLecturer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationLecturer = new DevExpress.XtraEditors.GroupControl();
            this.lkeStaffType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lkeFaculty = new DevExpress.XtraEditors.LookUpEdit();
            this.dteBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lbLFaculty = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gcListLecturer = new DevExpress.XtraGrid.GridControl();
            this.gvLecturerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLecturerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStaffType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_StaffType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Faculty = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLecturer)).BeginInit();
            this.grpInformationLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeStaffType.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_StaffType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnExportList);
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 579);
            this.panelMenu.TabIndex = 6;
            // 
            // btnExportList
            // 
            this.btnExportList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportList.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExportList.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportList.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExportList.Appearance.Options.UseBackColor = true;
            this.btnExportList.Appearance.Options.UseFont = true;
            this.btnExportList.Appearance.Options.UseForeColor = true;
            this.btnExportList.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnExportList.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportList.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnExportList.AppearanceHovered.Options.UseBackColor = true;
            this.btnExportList.AppearanceHovered.Options.UseFont = true;
            this.btnExportList.AppearanceHovered.Options.UseForeColor = true;
            this.btnExportList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExportList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportList.ImageOptions.Image")));
            this.btnExportList.Location = new System.Drawing.Point(0, 495);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(186, 54);
            this.btnExportList.TabIndex = 14;
            this.btnExportList.TabStop = false;
            this.btnExportList.Text = "Export Danh Sách";
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(0, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 54);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Nhân Viên";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(0, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Nhân Viên";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(0, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 54);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Nhân Viên";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(186, 87);
            this.panelLogo.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageLecturer);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(186, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1142, 87);
            this.panelTitleBar.TabIndex = 7;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReLoad.FlatAppearance.BorderSize = 0;
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReLoad.Location = new System.Drawing.Point(0, 0);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(70, 87);
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExitFormManageLecturer
            // 
            this.btnExitFormManageLecturer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitFormManageLecturer.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageLecturer.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageLecturer.Image")));
            this.btnExitFormManageLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageLecturer.Location = new System.Drawing.Point(1072, 0);
            this.btnExitFormManageLecturer.Name = "btnExitFormManageLecturer";
            this.btnExitFormManageLecturer.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormManageLecturer.TabIndex = 6;
            this.btnExitFormManageLecturer.UseVisualStyleBackColor = true;
            this.btnExitFormManageLecturer.Click += new System.EventHandler(this.btnExitFormManageLecturer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(54, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1012, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Thông Tin Nhân Viên ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInformationLecturer
            // 
            this.grpInformationLecturer.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpInformationLecturer.Appearance.Options.UseFont = true;
            this.grpInformationLecturer.AppearanceCaption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpInformationLecturer.AppearanceCaption.Options.UseFont = true;
            this.grpInformationLecturer.Controls.Add(this.lkeStaffType);
            this.grpInformationLecturer.Controls.Add(this.lblStaffType);
            this.grpInformationLecturer.Controls.Add(this.panel2);
            this.grpInformationLecturer.Controls.Add(this.panel1);
            this.grpInformationLecturer.Controls.Add(this.btnSave);
            this.grpInformationLecturer.Controls.Add(this.lblStatus);
            this.grpInformationLecturer.Controls.Add(this.lkeFaculty);
            this.grpInformationLecturer.Controls.Add(this.dteBirthday);
            this.grpInformationLecturer.Controls.Add(this.txtEmail);
            this.grpInformationLecturer.Controls.Add(this.txtPhoneNumber);
            this.grpInformationLecturer.Controls.Add(this.txtAddress);
            this.grpInformationLecturer.Controls.Add(this.txtIDCard);
            this.grpInformationLecturer.Controls.Add(this.txtFullName);
            this.grpInformationLecturer.Controls.Add(this.txtID);
            this.grpInformationLecturer.Controls.Add(this.lblGender);
            this.grpInformationLecturer.Controls.Add(this.lbLFaculty);
            this.grpInformationLecturer.Controls.Add(this.lblMail);
            this.grpInformationLecturer.Controls.Add(this.lblPhone);
            this.grpInformationLecturer.Controls.Add(this.lblAddress);
            this.grpInformationLecturer.Controls.Add(this.lblBirthDay);
            this.grpInformationLecturer.Controls.Add(this.lblIdCard);
            this.grpInformationLecturer.Controls.Add(this.lblName);
            this.grpInformationLecturer.Controls.Add(this.lblID);
            this.grpInformationLecturer.Location = new System.Drawing.Point(192, 93);
            this.grpInformationLecturer.Name = "grpInformationLecturer";
            this.grpInformationLecturer.Size = new System.Drawing.Size(1124, 199);
            this.grpInformationLecturer.TabIndex = 9;
            this.grpInformationLecturer.Text = "Thông Tin";
            // 
            // lkeStaffType
            // 
            this.lkeStaffType.Location = new System.Drawing.Point(522, 88);
            this.lkeStaffType.Name = "lkeStaffType";
            this.lkeStaffType.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkeStaffType.Properties.Appearance.Options.UseFont = true;
            this.lkeStaffType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeStaffType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeStaffType.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeStaffType.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeStaffType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeStaffType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeName", "Loại nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeID", "Mã loại nhân viên")});
            this.lkeStaffType.Properties.NullText = "Loại nhân viên";
            this.lkeStaffType.Size = new System.Drawing.Size(193, 24);
            this.lkeStaffType.TabIndex = 126;
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffType.Location = new System.Drawing.Point(394, 90);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(101, 17);
            this.lblStaffType.TabIndex = 125;
            this.lblStaffType.Text = "Loại nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radAvailable);
            this.panel2.Controls.Add(this.radUnavailable);
            this.panel2.Location = new System.Drawing.Point(522, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 22);
            this.panel2.TabIndex = 122;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radAvailable.Location = new System.Drawing.Point(0, 0);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(89, 21);
            this.radAvailable.TabIndex = 95;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Đang làm";
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.CheckedChanged += new System.EventHandler(this.radAvailable_CheckedChanged);
            // 
            // radUnavailable
            // 
            this.radUnavailable.AutoSize = true;
            this.radUnavailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnavailable.Location = new System.Drawing.Point(144, 0);
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.Size = new System.Drawing.Size(55, 21);
            this.radUnavailable.TabIndex = 96;
            this.radUnavailable.TabStop = true;
            this.radUnavailable.Text = "Nghỉ";
            this.radUnavailable.UseVisualStyleBackColor = true;
            this.radUnavailable.CheckedChanged += new System.EventHandler(this.radUnavailable_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Location = new System.Drawing.Point(183, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 24);
            this.panel1.TabIndex = 121;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(3, 0);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 21);
            this.radNam.TabIndex = 17;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(144, 0);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(46, 21);
            this.radNu.TabIndex = 18;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(522, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 120;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(394, 124);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 17);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lkeFaculty
            // 
            this.lkeFaculty.Location = new System.Drawing.Point(887, 88);
            this.lkeFaculty.Name = "lkeFaculty";
            this.lkeFaculty.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkeFaculty.Properties.Appearance.Options.UseFont = true;
            this.lkeFaculty.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeFaculty.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeFaculty.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeFaculty.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeFaculty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeFaculty.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyName", "Tên khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa")});
            this.lkeFaculty.Properties.NullText = "Khoa";
            this.lkeFaculty.Size = new System.Drawing.Size(193, 24);
            this.lkeFaculty.TabIndex = 93;
            // 
            // dteBirthday
            // 
            this.dteBirthday.EditValue = new System.DateTime(2020, 8, 5, 0, 0, 0, 0);
            this.dteBirthday.Location = new System.Drawing.Point(184, 57);
            this.dteBirthday.Name = "dteBirthday";
            this.dteBirthday.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteBirthday.Properties.Appearance.Options.UseFont = true;
            this.dteBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthday.Size = new System.Drawing.Size(193, 24);
            this.dteBirthday.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 25);
            this.txtEmail.TabIndex = 102;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(887, 57);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(193, 25);
            this.txtPhoneNumber.TabIndex = 101;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(522, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 25);
            this.txtAddress.TabIndex = 100;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(887, 26);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(193, 25);
            this.txtIDCard.TabIndex = 99;
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(522, 26);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(193, 25);
            this.txtFullName.TabIndex = 98;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(184, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 25);
            this.txtID.TabIndex = 97;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(61, 123);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 17);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Giới tính";
            // 
            // lbLFaculty
            // 
            this.lbLFaculty.AutoSize = true;
            this.lbLFaculty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLFaculty.Location = new System.Drawing.Point(755, 90);
            this.lbLFaculty.Name = "lbLFaculty";
            this.lbLFaculty.Size = new System.Drawing.Size(42, 17);
            this.lbLFaculty.TabIndex = 14;
            this.lbLFaculty.Text = "Khoa";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(61, 91);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 17);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(755, 60);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(394, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(61, 60);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(72, 17);
            this.lblBirthDay.TabIndex = 6;
            this.lblBirthDay.Text = "Ngày sinh";
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCard.Location = new System.Drawing.Point(755, 29);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(51, 17);
            this.lblIdCard.TabIndex = 4;
            this.lblIdCard.Text = "CMND";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(394, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(61, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã số";
            // 
            // gcListLecturer
            // 
            this.gcListLecturer.Location = new System.Drawing.Point(192, 298);
            this.gcListLecturer.MainView = this.gvLecturerList;
            this.gcListLecturer.Name = "gcListLecturer";
            this.gcListLecturer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Faculty,
            this.LookUpEdit_StaffType});
            this.gcListLecturer.Size = new System.Drawing.Size(1124, 274);
            this.gcListLecturer.TabIndex = 11;
            this.gcListLecturer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLecturerList});
            // 
            // gvLecturerList
            // 
            this.gvLecturerList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvLecturerList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLecturerList.Appearance.EvenRow.Options.UseFont = true;
            this.gvLecturerList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLecturerList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvLecturerList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLecturerList.Appearance.OddRow.Options.UseFont = true;
            this.gvLecturerList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.Appearance.Row.Options.UseFont = true;
            this.gvLecturerList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvLecturerList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvLecturerList.AppearancePrint.Row.Options.UseFont = true;
            this.gvLecturerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLecturerID,
            this.colFullName,
            this.colIDCard,
            this.colBirthday,
            this.colAddress,
            this.colPhoneNumber,
            this.colEmail,
            this.colStaffType,
            this.colFaculty,
            this.ColSex,
            this.colStatus});
            this.gvLecturerList.DetailHeight = 377;
            this.gvLecturerList.GridControl = this.gcListLecturer;
            this.gvLecturerList.Name = "gvLecturerList";
            this.gvLecturerList.OptionsBehavior.Editable = false;
            this.gvLecturerList.OptionsSelection.MultiSelect = true;
            this.gvLecturerList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLecturerList.OptionsView.EnableAppearanceOddRow = true;
            this.gvLecturerList.OptionsView.ShowAutoFilterRow = true;
            this.gvLecturerList.OptionsView.ShowGroupPanel = false;
            this.gvLecturerList.OptionsView.ShowViewCaption = true;
            this.gvLecturerList.ViewCaption = "Danh sách nhân viên";
            this.gvLecturerList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvLecturerList_CustomDrawRowIndicator);
            this.gvLecturerList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvLecturerList_SelectionChanged);
            this.gvLecturerList.RowCountChanged += new System.EventHandler(this.gvLecturerList_RowCountChanged);
            // 
            // colLecturerID
            // 
            this.colLecturerID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colLecturerID.AppearanceCell.Options.UseFont = true;
            this.colLecturerID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLecturerID.AppearanceHeader.Options.UseFont = true;
            this.colLecturerID.Caption = "Mã số";
            this.colLecturerID.FieldName = "StrStaffID";
            this.colLecturerID.Name = "colLecturerID";
            this.colLecturerID.Visible = true;
            this.colLecturerID.VisibleIndex = 0;
            this.colLecturerID.Width = 68;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.Caption = "Họ tên";
            this.colFullName.FieldName = "StrStaffName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 68;
            // 
            // colIDCard
            // 
            this.colIDCard.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colIDCard.AppearanceCell.Options.UseFont = true;
            this.colIDCard.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIDCard.AppearanceHeader.Options.UseFont = true;
            this.colIDCard.Caption = "CMND";
            this.colIDCard.FieldName = "StrCardID";
            this.colIDCard.Name = "colIDCard";
            this.colIDCard.Visible = true;
            this.colIDCard.VisibleIndex = 2;
            this.colIDCard.Width = 68;
            // 
            // colBirthday
            // 
            this.colBirthday.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBirthday.AppearanceCell.Options.UseFont = true;
            this.colBirthday.Caption = "Ngày sinh";
            this.colBirthday.FieldName = "DtBirthDay";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 3;
            this.colBirthday.Width = 68;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.Caption = "Địa chỉ";
            this.colAddress.FieldName = "StrAddress";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 68;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colPhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colPhoneNumber.Caption = "Số điện thoại";
            this.colPhoneNumber.FieldName = "StrPhone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 5;
            this.colPhoneNumber.Width = 85;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "StrEmail";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 63;
            // 
            // colStaffType
            // 
            this.colStaffType.Caption = "Loại nhân viên";
            this.colStaffType.ColumnEdit = this.LookUpEdit_StaffType;
            this.colStaffType.FieldName = "StrStaffTypeID";
            this.colStaffType.Name = "colStaffType";
            this.colStaffType.Visible = true;
            this.colStaffType.VisibleIndex = 7;
            // 
            // LookUpEdit_StaffType
            // 
            this.LookUpEdit_StaffType.AutoHeight = false;
            this.LookUpEdit_StaffType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_StaffType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeName", "Loại nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colStaffTypeID", "Mã loại nhân viên")});
            this.LookUpEdit_StaffType.DisplayMember = "StrStaffTypeName";
            this.LookUpEdit_StaffType.Name = "LookUpEdit_StaffType";
            this.LookUpEdit_StaffType.ValueMember = "StrStaffTypeID";
            // 
            // colFaculty
            // 
            this.colFaculty.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFaculty.AppearanceCell.Options.UseFont = true;
            this.colFaculty.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFaculty.AppearanceHeader.Options.UseFont = true;
            this.colFaculty.Caption = "Khoa";
            this.colFaculty.ColumnEdit = this.LookUpEdit_Faculty;
            this.colFaculty.FieldName = "StrFacultyID";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Visible = true;
            this.colFaculty.VisibleIndex = 8;
            this.colFaculty.Width = 63;
            // 
            // LookUpEdit_Faculty
            // 
            this.LookUpEdit_Faculty.AutoHeight = false;
            this.LookUpEdit_Faculty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Faculty.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyName", "Tên khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Faculty.DisplayMember = "StrFacultyName";
            this.LookUpEdit_Faculty.Name = "LookUpEdit_Faculty";
            this.LookUpEdit_Faculty.ValueMember = "StrFacultyID";
            // 
            // ColSex
            // 
            this.ColSex.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColSex.AppearanceCell.Options.UseFont = true;
            this.ColSex.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColSex.AppearanceHeader.Options.UseFont = true;
            this.ColSex.Caption = "Giới tính";
            this.ColSex.FieldName = "StrSex";
            this.ColSex.Name = "ColSex";
            this.ColSex.Visible = true;
            this.ColSex.VisibleIndex = 9;
            this.ColSex.Width = 63;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "StrStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            // 
            // frmManageLecturerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 579);
            this.Controls.Add(this.gcListLecturer);
            this.Controls.Add(this.grpInformationLecturer);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageLecturerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLecturerInformation";
            this.Load += new System.EventHandler(this.frmManageLecturerInformation_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLecturer)).EndInit();
            this.grpInformationLecturer.ResumeLayout(false);
            this.grpInformationLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeStaffType.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLecturerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_StaffType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnExitFormManageLecturer;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl grpInformationLecturer;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.LookUpEdit lkeFaculty;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DateEdit dteBirthday;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbLFaculty;
        private DevExpress.XtraGrid.GridControl gcListLecturer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLecturerList;
        private DevExpress.XtraGrid.Columns.GridColumn colLecturerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private DevExpress.XtraGrid.Columns.GridColumn ColSex;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Faculty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LookUpEdit lkeStaffType;
        private System.Windows.Forms.Label lblStaffType;
        private DevExpress.XtraGrid.Columns.GridColumn colStaffType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_StaffType;
        private DevExpress.XtraEditors.SimpleButton btnExportList;
    }
}