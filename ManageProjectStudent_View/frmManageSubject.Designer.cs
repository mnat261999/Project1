namespace ManageProjectStudent_View
{
    partial class frmManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubject));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdateSubject = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSubject = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSubject = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageStudent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationSubject = new DevExpress.XtraEditors.GroupControl();
            this.lkeFaculty = new DevExpress.XtraEditors.LookUpEdit();
            this.lblFacuty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dteEndTime = new DevExpress.XtraEditors.DateEdit();
            this.lblEndDay = new System.Windows.Forms.Label();
            this.dteStartTime = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.gcListSubject = new DevExpress.XtraGrid.GridControl();
            this.gvListSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Faculty = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationSubject)).BeginInit();
            this.grpInformationSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdateSubject);
            this.panelMenu.Controls.Add(this.btnDeleteSubject);
            this.panelMenu.Controls.Add(this.btnAddSubject);
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 552);
            this.panelMenu.TabIndex = 47;
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSubject.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateSubject.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSubject.Appearance.Options.UseBackColor = true;
            this.btnUpdateSubject.Appearance.Options.UseFont = true;
            this.btnUpdateSubject.Appearance.Options.UseForeColor = true;
            this.btnUpdateSubject.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnUpdateSubject.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateSubject.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdateSubject.AppearanceHovered.Options.UseFont = true;
            this.btnUpdateSubject.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdateSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSubject.ImageOptions.Image")));
            this.btnUpdateSubject.Location = new System.Drawing.Point(3, 385);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(171, 64);
            this.btnUpdateSubject.TabIndex = 21;
            this.btnUpdateSubject.TabStop = false;
            this.btnUpdateSubject.Text = "Sửa môn học";
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSubject.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteSubject.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSubject.Appearance.Options.UseBackColor = true;
            this.btnDeleteSubject.Appearance.Options.UseFont = true;
            this.btnDeleteSubject.Appearance.Options.UseForeColor = true;
            this.btnDeleteSubject.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnDeleteSubject.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteSubject.AppearanceHovered.Options.UseBackColor = true;
            this.btnDeleteSubject.AppearanceHovered.Options.UseFont = true;
            this.btnDeleteSubject.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDeleteSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSubject.ImageOptions.Image")));
            this.btnDeleteSubject.Location = new System.Drawing.Point(3, 471);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(170, 64);
            this.btnDeleteSubject.TabIndex = 20;
            this.btnDeleteSubject.TabStop = false;
            this.btnDeleteSubject.Text = "Xóa Môn Học";
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubject.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddSubject.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.Appearance.Options.UseBackColor = true;
            this.btnAddSubject.Appearance.Options.UseFont = true;
            this.btnAddSubject.Appearance.Options.UseForeColor = true;
            this.btnAddSubject.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnAddSubject.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddSubject.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddSubject.AppearanceHovered.Options.UseFont = true;
            this.btnAddSubject.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddSubject.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.ImageOptions.Image")));
            this.btnAddSubject.Location = new System.Drawing.Point(3, 299);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(171, 64);
            this.btnAddSubject.TabIndex = 19;
            this.btnAddSubject.TabStop = false;
            this.btnAddSubject.Text = "Thêm môn học";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 0);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Sinh Viên";
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
            this.btnDelete.Location = new System.Drawing.Point(0, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 0);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Sinh Viên";
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
            this.btnAdd.Location = new System.Drawing.Point(0, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 0);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Sinh Viên";
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
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageStudent);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(948, 87);
            this.panelTitleBar.TabIndex = 48;
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
            this.btnExitFormManageStudent.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageStudent.Image")));
            this.btnExitFormManageStudent.Location = new System.Drawing.Point(1073, 0);
            this.btnExitFormManageStudent.Name = "btnExitFormManageStudent";
            this.btnExitFormManageStudent.Size = new System.Drawing.Size(75, 87);
            this.btnExitFormManageStudent.TabIndex = 1;
            this.btnExitFormManageStudent.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(346, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lí Thông Tin Môn Học";
            // 
            // grpInformationSubject
            // 
            this.grpInformationSubject.Controls.Add(this.lkeFaculty);
            this.grpInformationSubject.Controls.Add(this.lblFacuty);
            this.grpInformationSubject.Controls.Add(this.txtName);
            this.grpInformationSubject.Controls.Add(this.txtID);
            this.grpInformationSubject.Controls.Add(this.dteEndTime);
            this.grpInformationSubject.Controls.Add(this.lblEndDay);
            this.grpInformationSubject.Controls.Add(this.dteStartTime);
            this.grpInformationSubject.Controls.Add(this.btnSave);
            this.grpInformationSubject.Controls.Add(this.textEdit5);
            this.grpInformationSubject.Controls.Add(this.label6);
            this.grpInformationSubject.Controls.Add(this.lblStartDay);
            this.grpInformationSubject.Controls.Add(this.lblSubjectName);
            this.grpInformationSubject.Controls.Add(this.lblSubjectID);
            this.grpInformationSubject.Location = new System.Drawing.Point(199, 102);
            this.grpInformationSubject.Name = "grpInformationSubject";
            this.grpInformationSubject.Size = new System.Drawing.Size(911, 221);
            this.grpInformationSubject.TabIndex = 50;
            this.grpInformationSubject.Text = "Thông Tin Môn Học";
            // 
            // lkeFaculty
            // 
            this.lkeFaculty.Location = new System.Drawing.Point(248, 128);
            this.lkeFaculty.Name = "lkeFaculty";
            this.lkeFaculty.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkeFaculty.Properties.Appearance.Options.UseFont = true;
            this.lkeFaculty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeFaculty.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyName", "Tên khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeFaculty.Properties.NullText = "Khoa";
            this.lkeFaculty.Size = new System.Drawing.Size(187, 24);
            this.lkeFaculty.TabIndex = 127;
            // 
            // lblFacuty
            // 
            this.lblFacuty.AutoSize = true;
            this.lblFacuty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFacuty.Location = new System.Drawing.Point(135, 131);
            this.lblFacuty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacuty.Name = "lblFacuty";
            this.lblFacuty.Size = new System.Drawing.Size(42, 17);
            this.lblFacuty.TabIndex = 126;
            this.lblFacuty.Text = "Khoa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 21);
            this.txtName.TabIndex = 102;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(248, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 21);
            this.txtID.TabIndex = 101;
            // 
            // dteEndTime
            // 
            this.dteEndTime.EditValue = new System.DateTime(2020, 8, 5, 0, 0, 0, 0);
            this.dteEndTime.Location = new System.Drawing.Point(672, 90);
            this.dteEndTime.Name = "dteEndTime";
            this.dteEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndTime.Size = new System.Drawing.Size(182, 20);
            this.dteEndTime.TabIndex = 46;
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(518, 87);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(135, 17);
            this.lblEndDay.TabIndex = 45;
            this.lblEndDay.Text = "Thời Gian Kết Thúc";
            // 
            // dteStartTime
            // 
            this.dteStartTime.EditValue = new System.DateTime(2020, 8, 5, 0, 0, 0, 0);
            this.dteStartTime.Location = new System.Drawing.Point(672, 47);
            this.dteStartTime.Name = "dteStartTime";
            this.dteStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartTime.Size = new System.Drawing.Size(182, 20);
            this.dteStartTime.TabIndex = 44;
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
            this.btnSave.Location = new System.Drawing.Point(412, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 125;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(97, 333);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(157, 20);
            this.textEdit5.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Place";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(524, 47);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(129, 17);
            this.lblStartDay.TabIndex = 23;
            this.lblStartDay.Text = "Thời Gian Bắt Đầu";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(83, 89);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(94, 17);
            this.lblSubjectName.TabIndex = 17;
            this.lblSubjectName.Text = "Tên Môn Học";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(94, 47);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(83, 17);
            this.lblSubjectID.TabIndex = 15;
            this.lblSubjectID.Text = "ID Môn Học";
            // 
            // gcListSubject
            // 
            this.gcListSubject.Location = new System.Drawing.Point(200, 350);
            this.gcListSubject.MainView = this.gvListSubject;
            this.gcListSubject.Name = "gcListSubject";
            this.gcListSubject.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class,
            this.LookUpEdit_Faculty});
            this.gcListSubject.Size = new System.Drawing.Size(910, 175);
            this.gcListSubject.TabIndex = 51;
            this.gcListSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListSubject});
            // 
            // gvListSubject
            // 
            this.gvListSubject.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvListSubject.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListSubject.Appearance.EvenRow.Options.UseFont = true;
            this.gvListSubject.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListSubject.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvListSubject.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListSubject.Appearance.OddRow.Options.UseFont = true;
            this.gvListSubject.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.Appearance.Row.Options.UseFont = true;
            this.gvListSubject.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListSubject.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListSubject.AppearancePrint.Row.Options.UseFont = true;
            this.gvListSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubjectID,
            this.colSubjectName,
            this.colFaculty,
            this.colStartTime,
            this.colEndTime});
            this.gvListSubject.DetailHeight = 377;
            this.gvListSubject.GridControl = this.gcListSubject;
            this.gvListSubject.Name = "gvListSubject";
            this.gvListSubject.OptionsBehavior.Editable = false;
            this.gvListSubject.OptionsSelection.MultiSelect = true;
            this.gvListSubject.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListSubject.OptionsView.EnableAppearanceOddRow = true;
            this.gvListSubject.OptionsView.ShowAutoFilterRow = true;
            this.gvListSubject.OptionsView.ShowGroupPanel = false;
            this.gvListSubject.OptionsView.ShowViewCaption = true;
            this.gvListSubject.ViewCaption = "Danh sách môn học";
            this.gvListSubject.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvListSubject_CustomDrawRowIndicator);
            this.gvListSubject.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvListSubject_SelectionChanged);
            this.gvListSubject.RowCountChanged += new System.EventHandler(this.gvListSubject_RowCountChanged);
            // 
            // colSubjectID
            // 
            this.colSubjectID.Caption = "Mã môn học";
            this.colSubjectID.FieldName = "StrSubjectID";
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.Visible = true;
            this.colSubjectID.VisibleIndex = 0;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "Tên môn học";
            this.colSubjectName.FieldName = "StrSubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 1;
            // 
            // colFaculty
            // 
            this.colFaculty.Caption = "Khoa";
            this.colFaculty.ColumnEdit = this.LookUpEdit_Faculty;
            this.colFaculty.FieldName = "StrFacultyID";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Visible = true;
            this.colFaculty.VisibleIndex = 2;
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
            // colStartTime
            // 
            this.colStartTime.Caption = "Ngày bắt đầu";
            this.colStartTime.FieldName = "DtStartDay";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 3;
            // 
            // colEndTime
            // 
            this.colEndTime.Caption = "Ngày kết thúc";
            this.colEndTime.FieldName = "DtEndDay";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 4;
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
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(873, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 87);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 552);
            this.Controls.Add(this.gcListSubject);
            this.Controls.Add(this.grpInformationSubject);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageSubject";
            this.Load += new System.EventHandler(this.frmManageSubject_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationSubject)).EndInit();
            this.grpInformationSubject.ResumeLayout(false);
            this.grpInformationSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraEditors.SimpleButton btnUpdateSubject;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSubject;
        private DevExpress.XtraEditors.SimpleButton btnAddSubject;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExitFormManageStudent;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl grpInformationSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.DateEdit dteEndTime;
        private System.Windows.Forms.Label lblEndDay;
        private DevExpress.XtraEditors.DateEdit dteStartTime;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblSubjectID;
        private DevExpress.XtraGrid.GridControl gcListSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private DevExpress.XtraEditors.LookUpEdit lkeFaculty;
        private System.Windows.Forms.Label lblFacuty;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Faculty;
        private System.Windows.Forms.Button btnExit;
    }
}