namespace ManageProjectStudent_View
{
    partial class frmManageWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWord));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationWord = new DevExpress.XtraEditors.GroupControl();
            this.lkeModule = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcListWord = new DevExpress.XtraGrid.GridControl();
            this.gvWordList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWordID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWordName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationWord)).BeginInit();
            this.grpInformationWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeModule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 539);
            this.panelMenu.TabIndex = 47;
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 41);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Từ";
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
            this.btnDelete.Location = new System.Drawing.Point(0, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa từ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.panelLogo.TabIndex = 5;
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
            this.btnAdd.Location = new System.Drawing.Point(0, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Từ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(770, 87);
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
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.FlatAppearance.BorderSize = 0;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitForm.ForeColor = System.Drawing.Color.White;
            this.btnExitForm.Image = ((System.Drawing.Image)(resources.GetObject("btnExitForm.Image")));
            this.btnExitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitForm.Location = new System.Drawing.Point(700, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(70, 87);
            this.btnExitForm.TabIndex = 6;
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(322, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý từ";
            // 
            // grpInformationWord
            // 
            this.grpInformationWord.Controls.Add(this.lkeModule);
            this.grpInformationWord.Controls.Add(this.label1);
            this.grpInformationWord.Controls.Add(this.txtName);
            this.grpInformationWord.Controls.Add(this.btnSave);
            this.grpInformationWord.Controls.Add(this.txtID);
            this.grpInformationWord.Controls.Add(this.label3);
            this.grpInformationWord.Controls.Add(this.label2);
            this.grpInformationWord.Location = new System.Drawing.Point(193, 102);
            this.grpInformationWord.Name = "grpInformationWord";
            this.grpInformationWord.Size = new System.Drawing.Size(733, 178);
            this.grpInformationWord.TabIndex = 49;
            this.grpInformationWord.Text = "Thông Tin";
            // 
            // lkeModule
            // 
            this.lkeModule.Location = new System.Drawing.Point(293, 90);
            this.lkeModule.Name = "lkeModule";
            this.lkeModule.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeModule.Properties.Appearance.Options.UseFont = true;
            this.lkeModule.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeModule.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeModule.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeModule.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeModule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeModule.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFormName", "Tên Module"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFormID", "Module")});
            this.lkeModule.Properties.NullText = "Module";
            this.lkeModule.Size = new System.Drawing.Size(209, 24);
            this.lkeModule.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "Module";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(293, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 21);
            this.txtName.TabIndex = 122;
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
            this.btnSave.Location = new System.Drawing.Point(285, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(293, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 21);
            this.txtID.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã từ";
            // 
            // gcListWord
            // 
            this.gcListWord.Location = new System.Drawing.Point(193, 286);
            this.gcListWord.MainView = this.gvWordList;
            this.gcListWord.Name = "gcListWord";
            this.gcListWord.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class});
            this.gcListWord.Size = new System.Drawing.Size(733, 240);
            this.gcListWord.TabIndex = 50;
            this.gcListWord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWordList});
            // 
            // gvWordList
            // 
            this.gvWordList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvWordList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvWordList.Appearance.EvenRow.Options.UseFont = true;
            this.gvWordList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWordList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvWordList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvWordList.Appearance.OddRow.Options.UseFont = true;
            this.gvWordList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.Row.Options.UseFont = true;
            this.gvWordList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvWordList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.AppearancePrint.Row.Options.UseFont = true;
            this.gvWordList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWordID,
            this.colWordName,
            this.colModule});
            this.gvWordList.DetailHeight = 377;
            this.gvWordList.GridControl = this.gcListWord;
            this.gvWordList.Name = "gvWordList";
            this.gvWordList.OptionsBehavior.Editable = false;
            this.gvWordList.OptionsSelection.MultiSelect = true;
            this.gvWordList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWordList.OptionsView.EnableAppearanceOddRow = true;
            this.gvWordList.OptionsView.ShowAutoFilterRow = true;
            this.gvWordList.OptionsView.ShowGroupPanel = false;
            this.gvWordList.OptionsView.ShowViewCaption = true;
            this.gvWordList.ViewCaption = "Danh sách từ";
            this.gvWordList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvWordList_CustomDrawRowIndicator);
            this.gvWordList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvWordList_SelectionChanged);
            this.gvWordList.RowCountChanged += new System.EventHandler(this.gvWordList_RowCountChanged);
            // 
            // colWordID
            // 
            this.colWordID.Caption = "Mã từ";
            this.colWordID.FieldName = "StrWordId";
            this.colWordID.Name = "colWordID";
            this.colWordID.Visible = true;
            this.colWordID.VisibleIndex = 0;
            // 
            // colWordName
            // 
            this.colWordName.Caption = "Tên từ";
            this.colWordName.FieldName = "StrWordName";
            this.colWordName.Name = "colWordName";
            this.colWordName.Visible = true;
            this.colWordName.VisibleIndex = 1;
            // 
            // colModule
            // 
            this.colModule.Caption = "Module";
            this.colModule.FieldName = "StrModule";
            this.colModule.Name = "colModule";
            this.colModule.Visible = true;
            this.colModule.VisibleIndex = 2;
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
            // frmManageWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 539);
            this.Controls.Add(this.gcListWord);
            this.Controls.Add(this.grpInformationWord);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageWord";
            this.Load += new System.EventHandler(this.frmManageWord_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationWord)).EndInit();
            this.grpInformationWord.ResumeLayout(false);
            this.grpInformationWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeModule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Panel panelLogo;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl grpInformationWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gcListWord;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWordList;
        private DevExpress.XtraGrid.Columns.GridColumn colWordID;
        private DevExpress.XtraGrid.Columns.GridColumn colWordName;
        private DevExpress.XtraGrid.Columns.GridColumn colModule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private DevExpress.XtraEditors.LookUpEdit lkeModule;
    }
}