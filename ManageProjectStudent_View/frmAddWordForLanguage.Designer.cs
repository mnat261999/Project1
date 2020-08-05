namespace ManageProjectStudent_View
{
    partial class frmAddWordForLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWordForLanguage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationWordLan = new DevExpress.XtraEditors.GroupControl();
            this.lkeModule = new DevExpress.XtraEditors.LookUpEdit();
            this.lblModule = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lkeWord = new DevExpress.XtraEditors.LookUpEdit();
            this.lkeLanguage = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblLan = new System.Windows.Forms.Label();
            this.gcListWordLan = new DevExpress.XtraGrid.GridControl();
            this.gvWordLanList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Language = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Word = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMean = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LookUpEdit_Mean = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkeMean = new DevExpress.XtraEditors.LookUpEdit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationWordLan)).BeginInit();
            this.grpInformationWordLan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeModule.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListWordLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordLanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Language)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMean.Properties)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(174, 552);
            this.panelMenu.TabIndex = 48;
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
            this.btnUpdate.Size = new System.Drawing.Size(171, 54);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa";
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
            this.btnDelete.Size = new System.Drawing.Size(170, 54);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
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
            this.btnAdd.Size = new System.Drawing.Size(171, 54);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm ";
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
            this.panelTitleBar.Size = new System.Drawing.Size(764, 87);
            this.panelTitleBar.TabIndex = 49;
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
            this.btnExitForm.Location = new System.Drawing.Point(694, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(70, 87);
            this.btnExitForm.TabIndex = 6;
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(76, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(612, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm từ cho ngôn ngữ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInformationWordLan
            // 
            this.grpInformationWordLan.Controls.Add(this.lkeMean);
            this.grpInformationWordLan.Controls.Add(this.lkeModule);
            this.grpInformationWordLan.Controls.Add(this.lblModule);
            this.grpInformationWordLan.Controls.Add(this.panel2);
            this.grpInformationWordLan.Controls.Add(this.lblStatus);
            this.grpInformationWordLan.Controls.Add(this.txtID);
            this.grpInformationWordLan.Controls.Add(this.lblID);
            this.grpInformationWordLan.Controls.Add(this.lblMean);
            this.grpInformationWordLan.Controls.Add(this.lkeWord);
            this.grpInformationWordLan.Controls.Add(this.lkeLanguage);
            this.grpInformationWordLan.Controls.Add(this.btnSave);
            this.grpInformationWordLan.Controls.Add(this.lblWord);
            this.grpInformationWordLan.Controls.Add(this.lblLan);
            this.grpInformationWordLan.Location = new System.Drawing.Point(194, 103);
            this.grpInformationWordLan.Name = "grpInformationWordLan";
            this.grpInformationWordLan.Size = new System.Drawing.Size(732, 178);
            this.grpInformationWordLan.TabIndex = 50;
            this.grpInformationWordLan.Text = "Thông Tin";
            // 
            // lkeModule
            // 
            this.lkeModule.Location = new System.Drawing.Point(477, 63);
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
            this.lkeModule.Size = new System.Drawing.Size(169, 24);
            this.lkeModule.TabIndex = 132;
            this.lkeModule.Tag = "5";
            // 
            // lblModule
            // 
            this.lblModule.AccessibleDescription = "";
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(396, 66);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(54, 17);
            this.lblModule.TabIndex = 131;
            this.lblModule.Text = "Module";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radUnavailable);
            this.panel2.Controls.Add(this.radAvailable);
            this.panel2.Location = new System.Drawing.Point(477, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 31);
            this.panel2.TabIndex = 130;
            // 
            // radUnavailable
            // 
            this.radUnavailable.AutoSize = true;
            this.radUnavailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnavailable.Location = new System.Drawing.Point(98, 3);
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.Size = new System.Drawing.Size(68, 21);
            this.radUnavailable.TabIndex = 1;
            this.radUnavailable.TabStop = true;
            this.radUnavailable.Tag = "7";
            this.radUnavailable.Text = "Không";
            this.radUnavailable.UseVisualStyleBackColor = true;
            this.radUnavailable.CheckedChanged += new System.EventHandler(this.radUnavailable_CheckedChanged);
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAvailable.Location = new System.Drawing.Point(0, 3);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(82, 21);
            this.radAvailable.TabIndex = 0;
            this.radAvailable.TabStop = true;
            this.radAvailable.Tag = "6";
            this.radAvailable.Text = "Sử dụng";
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.CheckedChanged += new System.EventHandler(this.radAvailable_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(396, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 17);
            this.lblStatus.TabIndex = 129;
            this.lblStatus.Text = "Trạng thái";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 21);
            this.txtID.TabIndex = 128;
            this.txtID.Tag = "1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(59, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 17);
            this.lblID.TabIndex = 127;
            this.lblID.Text = "ID";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMean.Location = new System.Drawing.Point(396, 40);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(45, 17);
            this.lblMean.TabIndex = 125;
            this.lblMean.Text = "Nghĩa";
            // 
            // lkeWord
            // 
            this.lkeWord.Location = new System.Drawing.Point(154, 92);
            this.lkeWord.Name = "lkeWord";
            this.lkeWord.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeWord.Properties.Appearance.Options.UseFont = true;
            this.lkeWord.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeWord.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeWord.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeWord.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeWord.Properties.AutoSearchColumnIndex = 1;
            this.lkeWord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeWord.Properties.CaseSensitiveSearch = true;
            this.lkeWord.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordName", "Từ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordID", "Mã từ")});
            this.lkeWord.Properties.NullText = "Từ";
            this.lkeWord.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkeWord.Size = new System.Drawing.Size(169, 24);
            this.lkeWord.TabIndex = 124;
            this.lkeWord.Tag = "3";
            // 
            // lkeLanguage
            // 
            this.lkeLanguage.Location = new System.Drawing.Point(154, 62);
            this.lkeLanguage.Name = "lkeLanguage";
            this.lkeLanguage.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeLanguage.Properties.Appearance.Options.UseFont = true;
            this.lkeLanguage.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeLanguage.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeLanguage.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeLanguage.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeLanguage.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLanguageName", "Ngôn ngữ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLanguageID", "Mã ngôn ngữ", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkeLanguage.Properties.NullText = "Ngôn ngữ";
            this.lkeLanguage.Size = new System.Drawing.Size(169, 24);
            this.lkeLanguage.TabIndex = 123;
            this.lkeLanguage.Tag = "2";
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
            this.btnSave.Location = new System.Drawing.Point(278, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "8";
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(59, 95);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(27, 17);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Từ";
            // 
            // lblLan
            // 
            this.lblLan.AutoSize = true;
            this.lblLan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLan.Location = new System.Drawing.Point(59, 65);
            this.lblLan.Name = "lblLan";
            this.lblLan.Size = new System.Drawing.Size(74, 17);
            this.lblLan.TabIndex = 0;
            this.lblLan.Text = "Ngôn Ngữ";
            // 
            // gcListWordLan
            // 
            this.gcListWordLan.Location = new System.Drawing.Point(194, 287);
            this.gcListWordLan.MainView = this.gvWordLanList;
            this.gcListWordLan.Name = "gcListWordLan";
            this.gcListWordLan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class,
            this.LookUpEdit_Language,
            this.LookUpEdit_Word,
            this.LookUpEdit_Mean});
            this.gcListWordLan.Size = new System.Drawing.Size(732, 240);
            this.gcListWordLan.TabIndex = 51;
            this.gcListWordLan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWordLanList});
            // 
            // gvWordLanList
            // 
            this.gvWordLanList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvWordLanList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvWordLanList.Appearance.EvenRow.Options.UseFont = true;
            this.gvWordLanList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWordLanList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvWordLanList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvWordLanList.Appearance.OddRow.Options.UseFont = true;
            this.gvWordLanList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.Appearance.Row.Options.UseFont = true;
            this.gvWordLanList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvWordLanList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordLanList.AppearancePrint.Row.Options.UseFont = true;
            this.gvWordLanList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colLanguage,
            this.colWord,
            this.colMean,
            this.colModule,
            this.colStatus});
            this.gvWordLanList.DetailHeight = 377;
            this.gvWordLanList.GridControl = this.gcListWordLan;
            this.gvWordLanList.Name = "gvWordLanList";
            this.gvWordLanList.OptionsBehavior.Editable = false;
            this.gvWordLanList.OptionsSelection.MultiSelect = true;
            this.gvWordLanList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWordLanList.OptionsView.EnableAppearanceOddRow = true;
            this.gvWordLanList.OptionsView.ShowAutoFilterRow = true;
            this.gvWordLanList.OptionsView.ShowGroupPanel = false;
            this.gvWordLanList.OptionsView.ShowViewCaption = true;
            this.gvWordLanList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvWordLanList.ViewCaption = "Danh sách ngôn ngữ";
            this.gvWordLanList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvWordLanList_CustomDrawRowIndicator);
            this.gvWordLanList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvWordLanList_SelectionChanged);
            this.gvWordLanList.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvWordLanList_CustomColumnSort);
            this.gvWordLanList.RowCountChanged += new System.EventHandler(this.gvWordLanList_RowCountChanged);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "StrID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colLanguage
            // 
            this.colLanguage.Caption = "Ngôn ngữ";
            this.colLanguage.ColumnEdit = this.LookUpEdit_Language;
            this.colLanguage.FieldName = "StrLanguageID";
            this.colLanguage.Name = "colLanguage";
            this.colLanguage.Visible = true;
            this.colLanguage.VisibleIndex = 1;
            // 
            // LookUpEdit_Language
            // 
            this.LookUpEdit_Language.AutoHeight = false;
            this.LookUpEdit_Language.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Language.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLanguageName", "Ngôn ngữ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colLanguageID", "Mã ngôn ngữ")});
            this.LookUpEdit_Language.DisplayMember = "StrLanguageName";
            this.LookUpEdit_Language.Name = "LookUpEdit_Language";
            this.LookUpEdit_Language.ValueMember = "StrLanguageID";
            // 
            // colWord
            // 
            this.colWord.Caption = "Từ";
            this.colWord.ColumnEdit = this.LookUpEdit_Word;
            this.colWord.FieldName = "StrWordID";
            this.colWord.Name = "colWord";
            this.colWord.Visible = true;
            this.colWord.VisibleIndex = 2;
            // 
            // LookUpEdit_Word
            // 
            this.LookUpEdit_Word.AutoHeight = false;
            this.LookUpEdit_Word.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Word.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordName", "Từ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordID", "Mã từ")});
            this.LookUpEdit_Word.DisplayMember = "StrWordName";
            this.LookUpEdit_Word.Name = "LookUpEdit_Word";
            this.LookUpEdit_Word.ValueMember = "StrWordId";
            // 
            // colMean
            // 
            this.colMean.Caption = "Nghĩa";
            this.colMean.FieldName = "StrMean";
            this.colMean.Name = "colMean";
            this.colMean.Visible = true;
            this.colMean.VisibleIndex = 3;
            // 
            // colModule
            // 
            this.colModule.Caption = "Module";
            this.colModule.FieldName = "StrModule";
            this.colModule.Name = "colModule";
            this.colModule.Visible = true;
            this.colModule.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "StrStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
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
            // LookUpEdit_Mean
            // 
            this.LookUpEdit_Mean.AutoHeight = false;
            this.LookUpEdit_Mean.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Mean.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordName", "Nghĩa")});
            this.LookUpEdit_Mean.DisplayMember = "StrWordName";
            this.LookUpEdit_Mean.Name = "LookUpEdit_Mean";
            this.LookUpEdit_Mean.ValueMember = "StrWordName";
            // 
            // lkeMean
            // 
            this.lkeMean.Location = new System.Drawing.Point(477, 33);
            this.lkeMean.Name = "lkeMean";
            this.lkeMean.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeMean.Properties.Appearance.Options.UseFont = true;
            this.lkeMean.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeMean.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkeMean.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeMean.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lkeMean.Properties.AutoSearchColumnIndex = 1;
            this.lkeMean.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeMean.Properties.CaseSensitiveSearch = true;
            this.lkeMean.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colWordName", "Từ")});
            this.lkeMean.Properties.NullText = "Nghĩa";
            this.lkeMean.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkeMean.Size = new System.Drawing.Size(169, 24);
            this.lkeMean.TabIndex = 133;
            this.lkeMean.Tag = "3";
            // 
            // frmAddWordForLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.gcListWordLan);
            this.Controls.Add(this.grpInformationWordLan);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddWordForLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmAddWordForLanguage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationWordLan)).EndInit();
            this.grpInformationWordLan.ResumeLayout(false);
            this.grpInformationWordLan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeModule.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListWordLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordLanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Language)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMean.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl grpInformationWordLan;
        private System.Windows.Forms.Label lblMean;
        private DevExpress.XtraEditors.LookUpEdit lkeWord;
        private DevExpress.XtraEditors.LookUpEdit lkeLanguage;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblLan;
        private DevExpress.XtraGrid.GridControl gcListWordLan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWordLanList;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguage;
        private DevExpress.XtraGrid.Columns.GridColumn colWord;
        private DevExpress.XtraGrid.Columns.GridColumn colMean;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Language;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Word;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Mean;
        private DevExpress.XtraEditors.LookUpEdit lkeModule;
        private System.Windows.Forms.Label lblModule;
        private DevExpress.XtraGrid.Columns.GridColumn colModule;
        private DevExpress.XtraEditors.LookUpEdit lkeMean;
    }
}