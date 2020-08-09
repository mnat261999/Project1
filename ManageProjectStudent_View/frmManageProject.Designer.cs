namespace ManageProjectStudent_View
{
    partial class frmManageProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProject));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExportList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gcListProject = new DevExpress.XtraGrid.GridControl();
            this.gvListProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Subject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLecturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Lecturer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStartDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpInformationProject = new DevExpress.XtraEditors.GroupControl();
            this.lkeLecturer = new DevExpress.XtraEditors.LookUpEdit();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.lkeSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dteStartDay = new DevExpress.XtraEditors.DateEdit();
            this.dteEndDay = new DevExpress.XtraEditors.DateEdit();
            this.lblEndDay = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationProject)).BeginInit();
            this.grpInformationProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLecturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(177, 502);
            this.panelMenu.TabIndex = 21;
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
            this.btnExportList.Location = new System.Drawing.Point(0, 434);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(177, 54);
            this.btnExportList.TabIndex = 23;
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
            this.btnUpdate.Location = new System.Drawing.Point(3, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 66);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Đồ Án";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 66);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa Đồ Án";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
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
            this.btnAdd.Location = new System.Drawing.Point(3, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 66);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Đồ Án";
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
            this.panelLogo.Size = new System.Drawing.Size(177, 87);
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
            this.panelTitleBar.Location = new System.Drawing.Point(177, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(930, 87);
            this.panelTitleBar.TabIndex = 22;
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
            this.btnReLoad.TabIndex = 9;
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
            this.btnCloseChildForm.Location = new System.Drawing.Point(855, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(72, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(782, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Đồ Án";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gcListProject
            // 
            this.gcListProject.Location = new System.Drawing.Point(183, 288);
            this.gcListProject.MainView = this.gvListProject;
            this.gcListProject.Name = "gcListProject";
            this.gcListProject.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Lecturer,
            this.LookUpEdit_Subject});
            this.gcListProject.Size = new System.Drawing.Size(912, 192);
            this.gcListProject.TabIndex = 24;
            this.gcListProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProject});
            // 
            // gvListProject
            // 
            this.gvListProject.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListProject.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvListProject.Appearance.EvenRow.Options.UseFont = true;
            this.gvListProject.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListProject.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListProject.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListProject.Appearance.OddRow.Options.UseBackColor = true;
            this.gvListProject.Appearance.OddRow.Options.UseFont = true;
            this.gvListProject.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListProject.Appearance.Row.Options.UseFont = true;
            this.gvListProject.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListProject.Appearance.SelectedRow.Options.UseFont = true;
            this.gvListProject.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListProject.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProject,
            this.colProjectName,
            this.colSubjectName,
            this.colLecturerName,
            this.colStartDay,
            this.colEndday});
            this.gvListProject.GridControl = this.gcListProject;
            this.gvListProject.Name = "gvListProject";
            this.gvListProject.OptionsBehavior.Editable = false;
            this.gvListProject.OptionsSelection.MultiSelect = true;
            this.gvListProject.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListProject.OptionsView.EnableAppearanceOddRow = true;
            this.gvListProject.OptionsView.ShowAutoFilterRow = true;
            this.gvListProject.OptionsView.ShowGroupPanel = false;
            this.gvListProject.OptionsView.ShowViewCaption = true;
            this.gvListProject.ViewCaption = "Danh sách đồ án";
            this.gvListProject.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvListProject_CustomDrawRowIndicator);
            this.gvListProject.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvListProject_SelectionChanged);
            this.gvListProject.RowCountChanged += new System.EventHandler(this.gvListProject_RowCountChanged);
            // 
            // colIDProject
            // 
            this.colIDProject.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colIDProject.AppearanceCell.Options.UseFont = true;
            this.colIDProject.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colIDProject.AppearanceHeader.Options.UseFont = true;
            this.colIDProject.Caption = "Mã đồ án";
            this.colIDProject.FieldName = "StrProjectID";
            this.colIDProject.MinWidth = 30;
            this.colIDProject.Name = "colIDProject";
            this.colIDProject.Visible = true;
            this.colIDProject.VisibleIndex = 0;
            this.colIDProject.Width = 114;
            // 
            // colProjectName
            // 
            this.colProjectName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colProjectName.AppearanceCell.Options.UseFont = true;
            this.colProjectName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colProjectName.AppearanceHeader.Options.UseFont = true;
            this.colProjectName.Caption = "Tên đồ án";
            this.colProjectName.FieldName = "StrProjectName";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Visible = true;
            this.colProjectName.VisibleIndex = 1;
            this.colProjectName.Width = 186;
            // 
            // colSubjectName
            // 
            this.colSubjectName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSubjectName.AppearanceCell.Options.UseFont = true;
            this.colSubjectName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colSubjectName.AppearanceHeader.Options.UseFont = true;
            this.colSubjectName.Caption = "Tên môn học";
            this.colSubjectName.ColumnEdit = this.LookUpEdit_Subject;
            this.colSubjectName.FieldName = "StrSubjectID";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 2;
            this.colSubjectName.Width = 143;
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
            // colLecturerName
            // 
            this.colLecturerName.Caption = "Giảng viên";
            this.colLecturerName.ColumnEdit = this.LookUpEdit_Lecturer;
            this.colLecturerName.FieldName = "StrStaffID";
            this.colLecturerName.Name = "colLecturerName";
            this.colLecturerName.Visible = true;
            this.colLecturerName.VisibleIndex = 3;
            this.colLecturerName.Width = 150;
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
            // colStartDay
            // 
            this.colStartDay.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colStartDay.AppearanceCell.Options.UseFont = true;
            this.colStartDay.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colStartDay.AppearanceHeader.Options.UseFont = true;
            this.colStartDay.Caption = "Ngày bắt đầu";
            this.colStartDay.FieldName = "DtStartDay";
            this.colStartDay.Name = "colStartDay";
            this.colStartDay.Visible = true;
            this.colStartDay.VisibleIndex = 4;
            this.colStartDay.Width = 167;
            // 
            // colEndday
            // 
            this.colEndday.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colEndday.AppearanceCell.Options.UseFont = true;
            this.colEndday.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colEndday.AppearanceHeader.Options.UseFont = true;
            this.colEndday.Caption = "Ngày kết thúc";
            this.colEndday.FieldName = "DtEndDay";
            this.colEndday.Name = "colEndday";
            this.colEndday.Visible = true;
            this.colEndday.VisibleIndex = 5;
            this.colEndday.Width = 179;
            // 
            // grpInformationProject
            // 
            this.grpInformationProject.Controls.Add(this.lkeLecturer);
            this.grpInformationProject.Controls.Add(this.lblLecturer);
            this.grpInformationProject.Controls.Add(this.lkeSubject);
            this.grpInformationProject.Controls.Add(this.txtProjectName);
            this.grpInformationProject.Controls.Add(this.txtID);
            this.grpInformationProject.Controls.Add(this.btnSave);
            this.grpInformationProject.Controls.Add(this.lblSubject);
            this.grpInformationProject.Controls.Add(this.dteStartDay);
            this.grpInformationProject.Controls.Add(this.dteEndDay);
            this.grpInformationProject.Controls.Add(this.lblEndDay);
            this.grpInformationProject.Controls.Add(this.lblStartDay);
            this.grpInformationProject.Controls.Add(this.lblName);
            this.grpInformationProject.Controls.Add(this.lblID);
            this.grpInformationProject.Location = new System.Drawing.Point(183, 93);
            this.grpInformationProject.Name = "grpInformationProject";
            this.grpInformationProject.Size = new System.Drawing.Size(912, 189);
            this.grpInformationProject.TabIndex = 23;
            this.grpInformationProject.Text = "Nhập thông tin đồ án";
            // 
            // lkeLecturer
            // 
            this.lkeLecturer.Location = new System.Drawing.Point(637, 31);
            this.lkeLecturer.Name = "lkeLecturer";
            this.lkeLecturer.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeLecturer.Properties.Appearance.Options.UseFont = true;
            this.lkeLecturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeLecturer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerName", "Tên giảng viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLecturerID", "Mã giảng viên", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeLecturer.Size = new System.Drawing.Size(168, 24);
            this.lkeLecturer.TabIndex = 125;
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.Location = new System.Drawing.Point(513, 34);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(76, 17);
            this.lblLecturer.TabIndex = 124;
            this.lblLecturer.Text = "Giảng viên";
            // 
            // lkeSubject
            // 
            this.lkeSubject.Location = new System.Drawing.Point(240, 94);
            this.lkeSubject.Name = "lkeSubject";
            this.lkeSubject.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeSubject.Properties.Appearance.Options.UseFont = true;
            this.lkeSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectName", "Tên môn học"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colSubjectID", "Mã môn học", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeSubject.Size = new System.Drawing.Size(168, 24);
            this.lkeSubject.TabIndex = 123;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Location = new System.Drawing.Point(240, 64);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(168, 25);
            this.txtProjectName.TabIndex = 122;
            this.txtProjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(240, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 25);
            this.txtID.TabIndex = 121;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave.Location = new System.Drawing.Point(372, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 37);
            this.btnSave.TabIndex = 120;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(111, 97);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(94, 17);
            this.lblSubject.TabIndex = 25;
            this.lblSubject.Text = "Tên môn học";
            // 
            // dteStartDay
            // 
            this.dteStartDay.EditValue = null;
            this.dteStartDay.Location = new System.Drawing.Point(637, 61);
            this.dteStartDay.Name = "dteStartDay";
            this.dteStartDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteStartDay.Properties.Appearance.Options.UseFont = true;
            this.dteStartDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteStartDay.Size = new System.Drawing.Size(168, 24);
            this.dteStartDay.TabIndex = 24;
            // 
            // dteEndDay
            // 
            this.dteEndDay.EditValue = null;
            this.dteEndDay.Location = new System.Drawing.Point(637, 91);
            this.dteEndDay.Name = "dteEndDay";
            this.dteEndDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteEndDay.Properties.Appearance.Options.UseFont = true;
            this.dteEndDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEndDay.Size = new System.Drawing.Size(168, 24);
            this.dteEndDay.TabIndex = 23;
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(513, 97);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(96, 17);
            this.lblEndDay.TabIndex = 22;
            this.lblEndDay.Text = "Ngày kết thúc";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(513, 64);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(93, 17);
            this.lblStartDay.TabIndex = 4;
            this.lblStartDay.Text = "Ngày bắt đầu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(111, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên đồ án";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(111, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã đồ án";
            // 
            // frmManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 502);
            this.Controls.Add(this.gcListProject);
            this.Controls.Add(this.grpInformationProject);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageProject";
            this.Load += new System.EventHandler(this.frmManageProject_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcListProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationProject)).EndInit();
            this.grpInformationProject.ResumeLayout(false);
            this.grpInformationProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLecturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEndDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraGrid.GridControl gcListProject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProject;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProject;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Subject;
        private DevExpress.XtraGrid.Columns.GridColumn colLecturerName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Lecturer;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDay;
        private DevExpress.XtraGrid.Columns.GridColumn colEndday;
        private DevExpress.XtraEditors.GroupControl grpInformationProject;
        private DevExpress.XtraEditors.LookUpEdit lkeLecturer;
        private System.Windows.Forms.Label lblLecturer;
        private DevExpress.XtraEditors.LookUpEdit lkeSubject;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblSubject;
        private DevExpress.XtraEditors.DateEdit dteStartDay;
        private DevExpress.XtraEditors.DateEdit dteEndDay;
        private System.Windows.Forms.Label lblEndDay;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExportList;
    }
}