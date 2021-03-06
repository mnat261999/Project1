﻿namespace ManageProjectStudent_View
{
    partial class frmManageStudentInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageStudentInformation));
            this.LookUpEdit_Faculty = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.dteBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grpInformationStudent = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dteStartYear = new DevExpress.XtraEditors.DateEdit();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lkeFaculty = new DevExpress.XtraEditors.LookUpEdit();
            this.lkeClass = new DevExpress.XtraEditors.LookUpEdit();
            this.lbLFaculty = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.gcListStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudentList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExportList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageStudent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationStudent)).BeginInit();
            this.grpInformationStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpEdit_Faculty
            // 
            this.LookUpEdit_Faculty.AutoHeight = false;
            this.LookUpEdit_Faculty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LookUpEdit_Faculty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Faculty.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyName", "Tên khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Faculty.DisplayMember = "StrFacultyName";
            this.LookUpEdit_Faculty.Name = "LookUpEdit_Faculty";
            this.LookUpEdit_Faculty.ValueMember = "StrFacultyID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(789, 65);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 17);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Trạng thái";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(538, 119);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 21);
            this.txtAddress.TabIndex = 33;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddress.Location = new System.Drawing.Point(425, 124);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 17);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 65);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 21);
            this.txtEmail.TabIndex = 26;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(538, 36);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(187, 21);
            this.txtPhoneNumber.TabIndex = 25;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(538, 94);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(187, 21);
            this.txtIDCard.TabIndex = 27;
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // dteBirthday
            // 
            this.dteBirthday.EditValue = null;
            this.dteBirthday.Location = new System.Drawing.Point(135, 94);
            this.dteBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dteBirthday.Name = "dteBirthday";
            this.dteBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBirthday.Size = new System.Drawing.Size(188, 20);
            this.dteBirthday.TabIndex = 24;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(136, 65);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(187, 21);
            this.txtFullName.TabIndex = 21;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblClass.Location = new System.Drawing.Point(791, 121);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(34, 17);
            this.lblClass.TabIndex = 20;
            this.lblClass.Text = "Lớp";
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdCard.Location = new System.Drawing.Point(425, 94);
            this.lblIdCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(51, 17);
            this.lblIdCard.TabIndex = 19;
            this.lblIdCard.Text = "CMND";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMail.Location = new System.Drawing.Point(425, 67);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 17);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhone.Location = new System.Drawing.Point(422, 40);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(92, 17);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBirthDay.Location = new System.Drawing.Point(12, 94);
            this.lblBirthDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(72, 17);
            this.lblBirthDay.TabIndex = 16;
            this.lblBirthDay.Text = "Ngày sinh";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(12, 67);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Họ tên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 21);
            this.txtID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.Location = new System.Drawing.Point(14, 40);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 17);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Mã số";
            // 
            // grpInformationStudent
            // 
            this.grpInformationStudent.Controls.Add(this.panel2);
            this.grpInformationStudent.Controls.Add(this.panel1);
            this.grpInformationStudent.Controls.Add(this.dteStartYear);
            this.grpInformationStudent.Controls.Add(this.lblStartDay);
            this.grpInformationStudent.Controls.Add(this.btnSave);
            this.grpInformationStudent.Controls.Add(this.lkeFaculty);
            this.grpInformationStudent.Controls.Add(this.lkeClass);
            this.grpInformationStudent.Controls.Add(this.lbLFaculty);
            this.grpInformationStudent.Controls.Add(this.lblGender);
            this.grpInformationStudent.Controls.Add(this.lblStatus);
            this.grpInformationStudent.Controls.Add(this.txtAddress);
            this.grpInformationStudent.Controls.Add(this.lblAddress);
            this.grpInformationStudent.Controls.Add(this.txtIDCard);
            this.grpInformationStudent.Controls.Add(this.txtEmail);
            this.grpInformationStudent.Controls.Add(this.txtPhoneNumber);
            this.grpInformationStudent.Controls.Add(this.dteBirthday);
            this.grpInformationStudent.Controls.Add(this.txtFullName);
            this.grpInformationStudent.Controls.Add(this.lblClass);
            this.grpInformationStudent.Controls.Add(this.lblIdCard);
            this.grpInformationStudent.Controls.Add(this.lblMail);
            this.grpInformationStudent.Controls.Add(this.lblPhone);
            this.grpInformationStudent.Controls.Add(this.lblBirthDay);
            this.grpInformationStudent.Controls.Add(this.lblName);
            this.grpInformationStudent.Controls.Add(this.txtID);
            this.grpInformationStudent.Controls.Add(this.lblID);
            this.grpInformationStudent.Location = new System.Drawing.Point(182, 94);
            this.grpInformationStudent.Margin = new System.Windows.Forms.Padding(4);
            this.grpInformationStudent.Name = "grpInformationStudent";
            this.grpInformationStudent.Size = new System.Drawing.Size(1127, 218);
            this.grpInformationStudent.TabIndex = 43;
            this.grpInformationStudent.Text = "Thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radAvailable);
            this.panel2.Controls.Add(this.radUnavailable);
            this.panel2.Location = new System.Drawing.Point(875, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 24);
            this.panel2.TabIndex = 125;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radAvailable.Location = new System.Drawing.Point(21, 0);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(89, 21);
            this.radAvailable.TabIndex = 42;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Đang học";
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.CheckedChanged += new System.EventHandler(this.radAvailable_CheckedChanged);
            // 
            // radUnavailable
            // 
            this.radUnavailable.AutoSize = true;
            this.radUnavailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnavailable.Location = new System.Drawing.Point(159, 3);
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.Size = new System.Drawing.Size(55, 21);
            this.radUnavailable.TabIndex = 43;
            this.radUnavailable.TabStop = true;
            this.radUnavailable.Text = "Nghỉ";
            this.radUnavailable.UseVisualStyleBackColor = true;
            this.radUnavailable.CheckedChanged += new System.EventHandler(this.radUnavailable_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Location = new System.Drawing.Point(881, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 21);
            this.panel1.TabIndex = 124;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNam.Location = new System.Drawing.Point(15, 0);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 21);
            this.radNam.TabIndex = 39;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(153, -2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(44, 24);
            this.radNu.TabIndex = 40;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // dteStartYear
            // 
            this.dteStartYear.EditValue = null;
            this.dteStartYear.Location = new System.Drawing.Point(135, 121);
            this.dteStartYear.Margin = new System.Windows.Forms.Padding(4);
            this.dteStartYear.Name = "dteStartYear";
            this.dteStartYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartYear.Size = new System.Drawing.Size(188, 20);
            this.dteStartYear.TabIndex = 123;
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStartDay.Location = new System.Drawing.Point(12, 124);
            this.lblStartDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(93, 17);
            this.lblStartDay.TabIndex = 122;
            this.lblStartDay.Text = "Ngày bắt đầu";
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
            this.btnSave.Location = new System.Drawing.Point(487, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lkeFaculty
            // 
            this.lkeFaculty.Location = new System.Drawing.Point(896, 94);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeFaculty.Properties.NullText = "Khoa";
            this.lkeFaculty.Size = new System.Drawing.Size(187, 24);
            this.lkeFaculty.TabIndex = 115;
            this.lkeFaculty.EditValueChanged += new System.EventHandler(this.lkeFaculty_EditValueChanged);
            // 
            // lkeClass
            // 
            this.lkeClass.Location = new System.Drawing.Point(896, 124);
            this.lkeClass.Name = "lkeClass";
            this.lkeClass.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkeClass.Properties.Appearance.Options.UseFont = true;
            this.lkeClass.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeClass.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeClass.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeClass.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeClass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassName", "Tên lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassID", "Mã lớp")});
            this.lkeClass.Properties.NullText = "Lớp";
            this.lkeClass.Size = new System.Drawing.Size(187, 24);
            this.lkeClass.TabIndex = 113;
            // 
            // lbLFaculty
            // 
            this.lbLFaculty.AutoSize = true;
            this.lbLFaculty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLFaculty.Location = new System.Drawing.Point(791, 94);
            this.lbLFaculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLFaculty.Name = "lbLFaculty";
            this.lbLFaculty.Size = new System.Drawing.Size(42, 17);
            this.lbLFaculty.TabIndex = 41;
            this.lbLFaculty.Text = "Khoa";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGender.Location = new System.Drawing.Point(791, 40);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 17);
            this.lblGender.TabIndex = 38;
            this.lblGender.Text = "Giới tính";
            // 
            // gcListStudent
            // 
            this.gcListStudent.Location = new System.Drawing.Point(182, 319);
            this.gcListStudent.MainView = this.gvStudentList;
            this.gcListStudent.Name = "gcListStudent";
            this.gcListStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class});
            this.gcListStudent.Size = new System.Drawing.Size(1127, 224);
            this.gcListStudent.TabIndex = 44;
            this.gcListStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentList});
            // 
            // gvStudentList
            // 
            this.gvStudentList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvStudentList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.EvenRow.Options.UseFont = true;
            this.gvStudentList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvStudentList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvStudentList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.OddRow.Options.UseFont = true;
            this.gvStudentList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.Row.Options.UseFont = true;
            this.gvStudentList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvStudentList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.AppearancePrint.Row.Options.UseFont = true;
            this.gvStudentList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentID,
            this.colFullName,
            this.colBirthday,
            this.colStartYear,
            this.ColSex,
            this.colPhoneNumber,
            this.colEmail,
            this.colIDCard,
            this.colAddress,
            this.colStatus,
            this.colFaculty,
            this.colClass});
            this.gvStudentList.DetailHeight = 377;
            this.gvStudentList.GridControl = this.gcListStudent;
            this.gvStudentList.Name = "gvStudentList";
            this.gvStudentList.OptionsBehavior.Editable = false;
            this.gvStudentList.OptionsSelection.MultiSelect = true;
            this.gvStudentList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStudentList.OptionsView.EnableAppearanceOddRow = true;
            this.gvStudentList.OptionsView.ShowAutoFilterRow = true;
            this.gvStudentList.OptionsView.ShowGroupPanel = false;
            this.gvStudentList.OptionsView.ShowViewCaption = true;
            this.gvStudentList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStudentID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvStudentList.ViewCaption = "Danh sách sinh viên";
            this.gvStudentList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvStudentList_CustomDrawRowIndicator);
            this.gvStudentList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvStudentList_SelectionChanged);
            this.gvStudentList.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvStudentList_CustomColumnSort);
            this.gvStudentList.RowCountChanged += new System.EventHandler(this.gvStudentList_RowCountChanged);
            // 
            // colStudentID
            // 
            this.colStudentID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colStudentID.AppearanceCell.Options.UseFont = true;
            this.colStudentID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStudentID.AppearanceHeader.Options.UseFont = true;
            this.colStudentID.Caption = "Mã số";
            this.colStudentID.FieldName = "StrStudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colStudentID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colStudentID.Visible = true;
            this.colStudentID.VisibleIndex = 0;
            this.colStudentID.Width = 89;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.Caption = "Họ tên";
            this.colFullName.FieldName = "StrStudentName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 89;
            // 
            // colBirthday
            // 
            this.colBirthday.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBirthday.AppearanceCell.Options.UseFont = true;
            this.colBirthday.Caption = "Ngày sinh";
            this.colBirthday.FieldName = "DtBirthDay";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 2;
            this.colBirthday.Width = 89;
            // 
            // colStartYear
            // 
            this.colStartYear.Caption = "Ngày bắt đầu";
            this.colStartYear.FieldName = "DtStartYear";
            this.colStartYear.Name = "colStartYear";
            this.colStartYear.Visible = true;
            this.colStartYear.VisibleIndex = 3;
            this.colStartYear.Width = 98;
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
            this.ColSex.VisibleIndex = 4;
            this.ColSex.Width = 83;
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
            this.colPhoneNumber.Width = 112;
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
            this.colEmail.Width = 83;
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
            this.colIDCard.VisibleIndex = 7;
            this.colIDCard.Width = 89;
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
            this.colAddress.VisibleIndex = 8;
            this.colAddress.Width = 89;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStatus.AppearanceCell.Options.UseFont = true;
            this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colStatus.AppearanceHeader.Options.UseFont = true;
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "StrStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 9;
            this.colStatus.Width = 93;
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
            this.colFaculty.VisibleIndex = 10;
            this.colFaculty.Width = 94;
            // 
            // colClass
            // 
            this.colClass.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClass.AppearanceCell.Options.UseFont = true;
            this.colClass.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClass.AppearanceHeader.Options.UseFont = true;
            this.colClass.Caption = "Lớp";
            this.colClass.ColumnEdit = this.LookUpEdit_Class;
            this.colClass.FieldName = "StrClassID";
            this.colClass.Name = "colClass";
            this.colClass.Visible = true;
            this.colClass.VisibleIndex = 11;
            this.colClass.Width = 94;
            // 
            // LookUpEdit_Class
            // 
            this.LookUpEdit_Class.AutoHeight = false;
            this.LookUpEdit_Class.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Class.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassName", "Tên lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassID", "Mã Lớp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Class.DisplayMember = "StrClassName";
            this.LookUpEdit_Class.Name = "LookUpEdit_Class";
            this.LookUpEdit_Class.ValueMember = "StrClassID";
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
            this.panelMenu.Size = new System.Drawing.Size(174, 579);
            this.panelMenu.TabIndex = 45;
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
            this.btnExportList.Location = new System.Drawing.Point(0, 479);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(173, 54);
            this.btnExportList.TabIndex = 22;
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
            this.btnUpdate.Location = new System.Drawing.Point(1, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 59);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Sinh Viên";
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
            this.btnDelete.Location = new System.Drawing.Point(2, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 59);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Sinh Viên";
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
            this.btnAdd.Location = new System.Drawing.Point(0, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 59);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Sinh Viên";
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
            this.panelLogo.Size = new System.Drawing.Size(174, 87);
            this.panelLogo.TabIndex = 7;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageStudent);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1148, 87);
            this.panelTitleBar.TabIndex = 46;
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
            this.btnReLoad.TabIndex = 8;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExitFormManageStudent
            // 
            this.btnExitFormManageStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitFormManageStudent.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageStudent.Image")));
            this.btnExitFormManageStudent.Location = new System.Drawing.Point(1073, 0);
            this.btnExitFormManageStudent.Name = "btnExitFormManageStudent";
            this.btnExitFormManageStudent.Size = new System.Drawing.Size(75, 87);
            this.btnExitFormManageStudent.TabIndex = 1;
            this.btnExitFormManageStudent.UseVisualStyleBackColor = true;
            this.btnExitFormManageStudent.Click += new System.EventHandler(this.btnExitFormManageStudent_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(999, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnImport.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnImport.Appearance.Options.UseBackColor = true;
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnImport.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImport.AppearanceHovered.Options.UseBackColor = true;
            this.btnImport.AppearanceHovered.Options.UseFont = true;
            this.btnImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnImport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImport.Location = new System.Drawing.Point(1120, 384);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(189, 59);
            this.btnImport.TabIndex = 122;
            this.btnImport.TabStop = false;
            this.btnImport.Text = "Import";
            // 
            // frmManageStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 579);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gcListStudent);
            this.Controls.Add(this.grpInformationStudent);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageStudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageStudentInformation";
            this.Load += new System.EventHandler(this.frmManageStudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationStudent)).EndInit();
            this.grpInformationStudent.ResumeLayout(false);
            this.grpInformationStudent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIDCard;
        private DevExpress.XtraEditors.DateEdit dteBirthday;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.GroupControl grpInformationStudent;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbLFaculty;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private DevExpress.XtraEditors.LookUpEdit lkeFaculty;
        private DevExpress.XtraEditors.LookUpEdit lkeClass;
        private DevExpress.XtraGrid.GridControl gcListStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentList;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn ColSex;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnExitFormManageStudent;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Faculty;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private System.Windows.Forms.Button btnReLoad;
        private DevExpress.XtraEditors.DateEdit dteStartYear;
        private System.Windows.Forms.Label lblStartDay;
        private DevExpress.XtraGrid.Columns.GridColumn colStartYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnExportList;
    }
}