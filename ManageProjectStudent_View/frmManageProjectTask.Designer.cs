namespace ManageProjectStudent_View
{
    partial class frmManageProjectTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProjectTask));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationTask = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtLinkFile = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dteEndDay = new DevExpress.XtraEditors.DateEdit();
            this.lblEndDay = new System.Windows.Forms.Label();
            this.dteStartDay = new DevExpress.XtraEditors.DateEdit();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lkeProjectID = new DevExpress.XtraEditors.LookUpEdit();
            this.lblIDProject = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gcListTask = new DevExpress.XtraGrid.GridControl();
            this.gvListTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Project = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTaskID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Lecturer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LookUpEdit_Subject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnExportList = new DevExpress.XtraEditors.SimpleButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationTask)).BeginInit();
            this.grpInformationTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(187, 517);
            this.panelMenu.TabIndex = 2;
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
            this.btnUpdate.Location = new System.Drawing.Point(-3, 312);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 64);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Task";
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
            this.btnDelete.Location = new System.Drawing.Point(-3, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 64);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Task";
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
            this.btnAdd.Location = new System.Drawing.Point(0, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 64);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Task";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 87);
            this.panelLogo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 639);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(187, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1005, 87);
            this.panelTitleBar.TabIndex = 3;
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
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(930, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(374, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Task Đồ Án";
            // 
            // grpInformationTask
            // 
            this.grpInformationTask.Controls.Add(this.btnSave);
            this.grpInformationTask.Controls.Add(this.txtLinkFile);
            this.grpInformationTask.Controls.Add(this.lblLink);
            this.grpInformationTask.Controls.Add(this.txtFileName);
            this.grpInformationTask.Controls.Add(this.lblFileName);
            this.grpInformationTask.Controls.Add(this.dteEndDay);
            this.grpInformationTask.Controls.Add(this.lblEndDay);
            this.grpInformationTask.Controls.Add(this.dteStartDay);
            this.grpInformationTask.Controls.Add(this.lblStartDay);
            this.grpInformationTask.Controls.Add(this.txtTaskName);
            this.grpInformationTask.Controls.Add(this.lblName);
            this.grpInformationTask.Controls.Add(this.txtTaskID);
            this.grpInformationTask.Controls.Add(this.lblID);
            this.grpInformationTask.Controls.Add(this.lkeProjectID);
            this.grpInformationTask.Controls.Add(this.lblIDProject);
            this.grpInformationTask.Location = new System.Drawing.Point(193, 93);
            this.grpInformationTask.Name = "grpInformationTask";
            this.grpInformationTask.Size = new System.Drawing.Size(987, 186);
            this.grpInformationTask.TabIndex = 4;
            this.grpInformationTask.Text = "Nhập Thông Tin Task";
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
            this.btnSave.Location = new System.Drawing.Point(428, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLinkFile
            // 
            this.txtLinkFile.Enabled = false;
            this.txtLinkFile.Location = new System.Drawing.Point(120, 121);
            this.txtLinkFile.Name = "txtLinkFile";
            this.txtLinkFile.Size = new System.Drawing.Size(168, 21);
            this.txtLinkFile.TabIndex = 112;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(7, 121);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(56, 17);
            this.lblLink.TabIndex = 111;
            this.lblLink.Text = "Link file";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(746, 81);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(168, 21);
            this.txtFileName.TabIndex = 110;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(657, 85);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(55, 17);
            this.lblFileName.TabIndex = 109;
            this.lblFileName.Text = "Tên file";
            // 
            // dteEndDay
            // 
            this.dteEndDay.EditValue = null;
            this.dteEndDay.Location = new System.Drawing.Point(442, 78);
            this.dteEndDay.Name = "dteEndDay";
            this.dteEndDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteEndDay.Properties.Appearance.Options.UseFont = true;
            this.dteEndDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndDay.Size = new System.Drawing.Size(168, 24);
            this.dteEndDay.TabIndex = 108;
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(314, 81);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(96, 17);
            this.lblEndDay.TabIndex = 107;
            this.lblEndDay.Text = "Ngày kết thúc";
            // 
            // dteStartDay
            // 
            this.dteStartDay.EditValue = null;
            this.dteStartDay.Location = new System.Drawing.Point(120, 78);
            this.dteStartDay.Name = "dteStartDay";
            this.dteStartDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dteStartDay.Properties.Appearance.Options.UseFont = true;
            this.dteStartDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDay.Size = new System.Drawing.Size(168, 24);
            this.dteStartDay.TabIndex = 106;
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(4, 81);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(93, 17);
            this.lblStartDay.TabIndex = 105;
            this.lblStartDay.Text = "Ngày bắt đầu";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(746, 44);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(168, 21);
            this.txtTaskName.TabIndex = 104;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(657, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 103;
            this.lblName.Text = "Tên task";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(441, 41);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(168, 21);
            this.txtTaskID.TabIndex = 102;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(314, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 17);
            this.lblID.TabIndex = 101;
            this.lblID.Text = "Mã task";
            // 
            // lkeProjectID
            // 
            this.lkeProjectID.Location = new System.Drawing.Point(120, 41);
            this.lkeProjectID.Name = "lkeProjectID";
            this.lkeProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectID", "Mã đồ án")});
            this.lkeProjectID.Properties.NullText = "";
            this.lkeProjectID.Size = new System.Drawing.Size(168, 20);
            this.lkeProjectID.TabIndex = 100;
            // 
            // lblIDProject
            // 
            this.lblIDProject.AutoSize = true;
            this.lblIDProject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProject.Location = new System.Drawing.Point(7, 41);
            this.lblIDProject.Name = "lblIDProject";
            this.lblIDProject.Size = new System.Drawing.Size(67, 17);
            this.lblIDProject.TabIndex = 98;
            this.lblIDProject.Text = "Mã đồ án";
            // 
            // gcListTask
            // 
            this.gcListTask.Location = new System.Drawing.Point(193, 285);
            this.gcListTask.MainView = this.gvListTask;
            this.gcListTask.Name = "gcListTask";
            this.gcListTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Lecturer,
            this.LookUpEdit_Subject,
            this.LookUpEdit_Project});
            this.gcListTask.Size = new System.Drawing.Size(987, 220);
            this.gcListTask.TabIndex = 25;
            this.gcListTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListTask});
            // 
            // gvListTask
            // 
            this.gvListTask.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListTask.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListTask.Appearance.EvenRow.Options.UseFont = true;
            this.gvListTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListTask.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListTask.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListTask.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListTask.Appearance.OddRow.Options.UseFont = true;
            this.gvListTask.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListTask.Appearance.Row.Options.UseFont = true;
            this.gvListTask.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListTask.Appearance.SelectedRow.Options.UseFont = true;
            this.gvListTask.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListTask.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjectID,
            this.colTaskID,
            this.colTaskName,
            this.colStartDay,
            this.colEndDay,
            this.colFileName,
            this.colLinkFile});
            this.gvListTask.GridControl = this.gcListTask;
            this.gvListTask.Name = "gvListTask";
            this.gvListTask.OptionsBehavior.Editable = false;
            this.gvListTask.OptionsSelection.MultiSelect = true;
            this.gvListTask.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListTask.OptionsView.EnableAppearanceOddRow = true;
            this.gvListTask.OptionsView.ShowAutoFilterRow = true;
            this.gvListTask.OptionsView.ShowGroupPanel = false;
            this.gvListTask.OptionsView.ShowViewCaption = true;
            this.gvListTask.ViewCaption = "Danh sách task";
            this.gvListTask.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvListTask_CustomDrawRowIndicator);
            this.gvListTask.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvListTask_SelectionChanged);
            this.gvListTask.RowCountChanged += new System.EventHandler(this.gvListTask_RowCountChanged);
            // 
            // colProjectID
            // 
            this.colProjectID.Caption = "Mã đồ án";
            this.colProjectID.ColumnEdit = this.LookUpEdit_Project;
            this.colProjectID.FieldName = "StrProjectID";
            this.colProjectID.Name = "colProjectID";
            this.colProjectID.Visible = true;
            this.colProjectID.VisibleIndex = 0;
            // 
            // LookUpEdit_Project
            // 
            this.LookUpEdit_Project.AutoHeight = false;
            this.LookUpEdit_Project.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Project.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colProjectID", "Mã đồ án")});
            this.LookUpEdit_Project.DisplayMember = "StrProjectID";
            this.LookUpEdit_Project.Name = "LookUpEdit_Project";
            this.LookUpEdit_Project.ValueMember = "StrProjectID";
            // 
            // colTaskID
            // 
            this.colTaskID.Caption = "Mã task";
            this.colTaskID.FieldName = "StrTaskID";
            this.colTaskID.Name = "colTaskID";
            this.colTaskID.Visible = true;
            this.colTaskID.VisibleIndex = 1;
            // 
            // colTaskName
            // 
            this.colTaskName.Caption = "Tên task";
            this.colTaskName.FieldName = "StrTaskName";
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.Visible = true;
            this.colTaskName.VisibleIndex = 2;
            // 
            // colStartDay
            // 
            this.colStartDay.Caption = "Ngày bắt đầu";
            this.colStartDay.FieldName = "DtStartDay";
            this.colStartDay.Name = "colStartDay";
            this.colStartDay.Visible = true;
            this.colStartDay.VisibleIndex = 3;
            // 
            // colEndDay
            // 
            this.colEndDay.Caption = "Ngày kết thúc";
            this.colEndDay.FieldName = "DtEndDay";
            this.colEndDay.Name = "colEndDay";
            this.colEndDay.Visible = true;
            this.colEndDay.VisibleIndex = 4;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Tên file";
            this.colFileName.FieldName = "StrFileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 5;
            // 
            // colLinkFile
            // 
            this.colLinkFile.Caption = "Link file";
            this.colLinkFile.FieldName = "StrFileName";
            this.colLinkFile.Name = "colLinkFile";
            this.colLinkFile.Visible = true;
            this.colLinkFile.VisibleIndex = 6;
            // 
            // LookUpEdit_Lecturer
            // 
            this.LookUpEdit_Lecturer.AutoHeight = false;
            this.LookUpEdit_Lecturer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Lecturer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerName", "Tên giảng viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerID", "Mã Giảng viên", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Lecturer.DisplayMember = "StrStaffName";
            this.LookUpEdit_Lecturer.Name = "LookUpEdit_Lecturer";
            this.LookUpEdit_Lecturer.ValueMember = "StrStaffID";
            // 
            // LookUpEdit_Subject
            // 
            this.LookUpEdit_Subject.AutoHeight = false;
            this.LookUpEdit_Subject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Subject.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectName", "Tên môn học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectID", "Mã môn học", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Subject.DisplayMember = "StrSubjectName";
            this.LookUpEdit_Subject.Name = "LookUpEdit_Subject";
            this.LookUpEdit_Subject.ValueMember = "StrSubjectID";
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
            this.btnExportList.Location = new System.Drawing.Point(-3, 451);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(196, 54);
            this.btnExportList.TabIndex = 24;
            this.btnExportList.TabStop = false;
            this.btnExportList.Text = "Export Danh Sách";
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // frmManageProjectTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 517);
            this.Controls.Add(this.gcListTask);
            this.Controls.Add(this.grpInformationTask);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProjectTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageProjectTask";
            this.Load += new System.EventHandler(this.frmManageProjectTask_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationTask)).EndInit();
            this.grpInformationTask.ResumeLayout(false);
            this.grpInformationTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl grpInformationTask;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.LookUpEdit lkeProjectID;
        private System.Windows.Forms.Label lblIDProject;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.TextBox txtLinkFile;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private DevExpress.XtraEditors.DateEdit dteEndDay;
        private System.Windows.Forms.Label lblEndDay;
        private DevExpress.XtraEditors.DateEdit dteStartDay;
        private System.Windows.Forms.Label lblStartDay;
        private DevExpress.XtraGrid.GridControl gcListTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Lecturer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Subject;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Button btnReLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskID;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDay;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDay;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Project;
        private DevExpress.XtraEditors.SimpleButton btnExportList;
    }
}