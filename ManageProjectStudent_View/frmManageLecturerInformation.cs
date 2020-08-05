using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_ViewModel;
using ManageProjectStudent_Model;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace ManageProjectStudent_View
{
    public partial class frmManageLecturerInformation : Form
    {
        public frmManageLecturerInformation()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private IStaff _Staff = Config.Container.Resolve<IStaff>();
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();

        private BindingList<StaffTypeModel> _lstStaffType = new BindingList<StaffTypeModel>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();

        private int _IStatusForm = 0;
        private StaffModel _LecturerModelNow = null;
        private BindingList<StaffModel> _lstLecturer = new BindingList<StaffModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;

        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        #endregion
        #region Method
        private bool CheckBirthday()
        {
            int year = DateTime.Now.Year;
            string s1 = dteBirthday.EditValue.ToString();
            DateTime date = DateTime.Parse(s1);
            int year1 = date.Year;
            if ((year - year1) >= 23)
            {
                return true;
            }
            return false;
        }
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Staff.lstStaffID());
            if (_STR_MAX == "1")
                return "NV" + _STR_MAX;
            return _STR_MAX;
        }

        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationLecturer.Enabled = false;
                    txtID.ReadOnly = true;
                    //btnSave.Enabled = false;
                    dteBirthday.Enabled = true;
                    if (_LecturerModelNow != null)
                    {
                        if (Decentralize.BView == true)
                        {
                            if (Decentralize.BAdd == true)
                            {
                                btnAdd.Enabled = true;
                            }
                            else
                            {
                                btnAdd.Enabled = false;
                            }
                            if (Decentralize.BDelete == true)
                            {
                                btnDelete.Enabled = true;
                            }
                            else
                            {
                                btnDelete.Enabled = false;
                            }
                            if (Decentralize.BEdit == true)
                            {
                                btnUpdate.Enabled = true;
                            }
                            else
                            {
                                btnUpdate.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    //else
                    //{
                    //    btnUpdate.Enabled = true;
                    //    btnDelete.Enabled = true;
                    //}
                    break;
                case 1: // Add.
                    txtID.Text = getMaxID();
                    txtFullName.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    dteBirthday.EditValue = null;
                    txtAddress.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    lkeStaffType.EditValue = null;
                    lkeFaculty.EditValue = null;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationLecturer.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationLecturer.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LecturerModelNow == null)
            {
                txtID.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                dteBirthday.EditValue = null;
                txtAddress.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                lkeStaffType.EditValue = null;
                lkeFaculty.EditValue = null;
                radNam.Checked = false;
                radNu.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }
            else
            {
                txtID.Text = _LecturerModelNow.StrStaffID;
                txtFullName.Text = _LecturerModelNow.StrStaffName;
                txtIDCard.Text = _LecturerModelNow.StrCardID;
                dteBirthday.EditValue = _LecturerModelNow.DtBirthDay.Date;
                txtAddress.Text = _LecturerModelNow.StrAddress;
                txtPhoneNumber.Text = _LecturerModelNow.StrPhone;
                txtEmail.Text = _LecturerModelNow.StrEmail;
                lkeStaffType.EditValue = _LecturerModelNow.StrStaffTypeID;
                lkeFaculty.EditValue = _LecturerModelNow.StrFacultyID;
                if (_LecturerModelNow.StrSex == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                if (_LecturerModelNow.StrStatus == "Đang làm")
                {
                    radAvailable.Checked = true;
                    radUnavailable.Checked = false;
                }
                else
                {

                    radAvailable.Checked = false;
                    radUnavailable.Checked = true;
                }
            }
        }

        private void _getData()
        {
            if (_LecturerModelNow == null)
            {
                _LecturerModelNow = new StaffModel();
            }
            _LecturerModelNow.StrStaffID = txtID.Text;
            _LecturerModelNow.StrStaffName = txtFullName.Text;
            _LecturerModelNow.StrCardID = txtIDCard.Text;
            _LecturerModelNow.DtBirthDay = (DateTime)dteBirthday.EditValue;
            _LecturerModelNow.StrAddress = txtAddress.Text;
            _LecturerModelNow.StrPhone = txtPhoneNumber.Text;
            _LecturerModelNow.StrEmail = txtEmail.Text;
            _LecturerModelNow.StrStaffTypeID = lkeStaffType.GetColumnValue("StrStaffTypeID").ToString();
            _LecturerModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
            if (radNam.Checked)
            {
                _LecturerModelNow.StrSex = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _LecturerModelNow.StrSex = radNu.Text;
            }

            if (radAvailable.Checked)
            {
                _LecturerModelNow.StrStatus = radAvailable.Text;
            }
            else
            {
                _LecturerModelNow.StrStatus = radUnavailable.Text;
            }
        }

        private void _lstLoadListLecturer()
        {
            _lstLecturer = _Staff.loadStaff();
            //if(_lstLecturer.Count>0)
            //{
            //    foreach(StaffModel lt in _lstLecturer)
            //    {
            //        if (lt.StrStaffID == "LT1")
            //        {
            //            _lstLecturer.Remove(lt);
            //            break;
            //        }
            //    }
            //}
            foreach (StaffModel st in _lstLecturer)
            {
                if (st.StrStaffTypeID == "Adms")
                {
                    _lstLecturer.Remove(st);
                    break;
                    // _lstLecturer = _Staff.loadStaff();
                }
            }
            gcListLecturer.DataSource = _lstLecturer;
        }

        #endregion
        #region Event
        //load
        private void frmManageLecturerInformation_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            StaffModel = frmHome.staffModel;
            if (frmHome.lstDecent != null)
            {
                foreach (DecentralizeModel decen in frmHome.lstDecent)
                {
                    if (StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID, decen.StrFormID);
                        break;
                    }
                }
            }
            dteBirthday.EditValue = DateTime.Now.Date;

            _lstFaculty = _Faculty.loadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            _lstStaffType = _StaffType.loadStaffType();
            lkeStaffType.Properties.ValueMember = "StrStaffTypeID";
            lkeStaffType.Properties.DisplayMember = "StrStaffTypeName";
            lkeStaffType.Properties.DataSource = _lstStaffType;
            lkeStaffType.Properties.Columns["colStaffTypeID"].FieldName = "StrStaffTypeID";
            lkeStaffType.Properties.Columns["colStaffTypeName"].FieldName = "StrStaffTypeName";

            foreach (StaffTypeModel staff in _lstStaffType)
            {
                if (staff.StrStaffTypeID == StaffModel.StrStaffTypeID || staff.StrStaffTypeID == "Adms")
                {
                    _lstStaffType.Remove(staff);
                    _lstStaffType = _StaffType.loadStaffType();
                    break;
                }
            }
            #region Multi-Language
            Language = frmHome.languageModel;
            _lstLanWord = _WL.getLstLanguageWord(Language.StrLanguageID, this.Name);
            if (frmHome.lstLanguageWord != null)
            {
                foreach (LanguageWordModel lnword in _lstLanWord)
                {
                    _wordModel = _Word.getWordSelected(lnword.StrWordID);
                    if (lblTitle.Text == _wordModel.StrWordName)
                    {
                        lblTitle.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnAdd.Text == _wordModel.StrWordName)
                    {
                        btnAdd.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnUpdate.Text == _wordModel.StrWordName)
                    {
                        btnUpdate.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnDelete.Text == _wordModel.StrWordName)
                    {
                        btnDelete.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnExportList.Text == _wordModel.StrWordName)
                    {
                        btnExportList.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnSave.Text == _wordModel.StrWordName)
                    {
                        btnSave.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblID.Text == _wordModel.StrWordName)
                    {
                        lblID.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblName.Text == _wordModel.StrWordName)
                    {
                        lblName.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblBirthDay.Text == _wordModel.StrWordName)
                    {
                        lblBirthDay.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblPhone.Text == _wordModel.StrWordName)
                    {
                        lblPhone.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblMail.Text == _wordModel.StrWordName)
                    {
                        lblMail.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblIdCard.Text == _wordModel.StrWordName)
                    {
                        lblIdCard.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblAddress.Text == _wordModel.StrWordName)
                    {
                        lblAddress.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblGender.Text == _wordModel.StrWordName)
                    {
                        lblGender.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radNam.Text == _wordModel.StrWordName)
                    {
                        radNam.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radNu.Text == _wordModel.StrWordName)
                    {
                        radNu.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblStatus.Text == _wordModel.StrWordName)
                    {
                        lblStatus.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radAvailable.Text == _wordModel.StrWordName)
                    {
                        radAvailable.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radUnavailable.Text == _wordModel.StrWordName)
                    {
                        radUnavailable.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lbLFaculty.Text == _wordModel.StrWordName)
                    {
                        lbLFaculty.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeFaculty.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeFaculty.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblStaffType.Text == _wordModel.StrWordName)
                    {
                        lblStaffType.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeStaffType.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeStaffType.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colLecturerID.Caption == _wordModel.StrWordName)
                    {
                        colLecturerID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colFullName.Caption == _wordModel.StrWordName)
                    {
                        colFullName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colBirthday.Caption == _wordModel.StrWordName)
                    {
                        colBirthday.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (ColSex.Caption == _wordModel.StrWordName)
                    {
                        ColSex.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colPhoneNumber.Caption == _wordModel.StrWordName)
                    {
                        colPhoneNumber.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colEmail.Caption == _wordModel.StrWordName)
                    {
                        colEmail.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colIDCard.Caption == _wordModel.StrWordName)
                    {
                        colIDCard.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colAddress.Caption == _wordModel.StrWordName)
                    {
                        colAddress.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colStatus.Caption == _wordModel.StrWordName)
                    {
                        colStatus.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colFaculty.Caption == _wordModel.StrWordName)
                    {
                        colFaculty.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colStaffType.Caption == _wordModel.StrWordName)
                    {
                        colStaffType.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }
            }
            #endregion
            ///*GridView*/
            _lstLecturer = _Staff.loadStaff();
            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            LookUpEdit_StaffType.DataSource = _lstStaffType;
            LookUpEdit_StaffType.Columns["colStaffTypeID"].FieldName = "StrStaffTypeID";
            LookUpEdit_StaffType.Columns["colStaffTypeName"].FieldName = "StrStaffTypeName";

            foreach (StaffModel st in _lstLecturer)
            {
                if (st.StrStaffTypeID == "Adms")
                {
                    _lstLecturer.Remove(st);
                    break;
                    // _lstLecturer = _Staff.loadStaff();
                }
            }
            gcListLecturer.DataSource = _lstLecturer;
            _setStatusForm();
        }

        //selection changed
        private void gvLecturerList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gvLecturerList.SelectedRowsCount>0)
                _LecturerModelNow = (StaffModel)gvLecturerList.GetRow(gvLecturerList.FocusedRowHandle);
            else
                _LecturerModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }
        //stt
        private void gvLecturerList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvLecturerList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        //click

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _LecturerModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            //txtID.Text = StaffViewModel.GetByIDMaxLecturer();
            txtFullName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_LecturerModelNow != null)
            {
                if (_Staff.deleteCurrentStaff(_LecturerModelNow))
                {
                    _lstLoadListLecturer();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLecturer.Count == 0)
                    {
                        _LecturerModelNow = null;
                        _IStatusForm = 0;
                        _setStatusForm();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Giảng viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Chứng minh nhân dân", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if (_Staff.checkStaffID(txtID.Text) == true)
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show("Mã số nhân viên bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            else if (_Staff.checkCardID(txtID.Text) == true)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("CMND bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày sinh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhoneNumber.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                if (GarenaViewModel.checkPhoneNumber(_LecturerModelNow.StrPhone) == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số Điện Thoại Phải 10 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (GarenaViewModel.checkIDCard(_LecturerModelNow.StrCardID) == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("CMND Phải Trên 8 Số!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (GarenaViewModel.checkEmail(_LecturerModelNow.StrEmail) == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Email không đúng định dạng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CheckBirthday() == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Nhân viên phải trên 18 tuổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                else
                {
                    _getData();
                    bool bresult = false;
                    if (_IStatusForm == 1)
                    {
                        bresult = _Staff.addNewStaff(_LecturerModelNow);
                    }
                    else
                    {
                        bresult = _Staff.updateCurrentStaff(_LecturerModelNow);
                    }

                    if (!bresult)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _lstLoadListLecturer();
                        _IStatusForm = 0;
                        _setStatusForm();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    
            }
        }
        private void btnExitFormManageLecturer_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            //this.Hide();
            //frmHome frmHome = new frmHome();
            //frmHome.ShowDialog();
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstLecturer = _Staff.loadStaff();
            gcListLecturer.DataSource = _lstLecturer;

        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvLecturerList.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvLecturerList.ColumnPanelRowHeight = 40;
                        gvLecturerList.OptionsPrint.AutoWidth = AutoSize;
                        gvLecturerList.OptionsPrint.ShowPrintExportProgress = true;
                        gvLecturerList.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvLecturerList.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //key press

        //private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        ((TextBox)sender).Focus();
        //        string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
        //        MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterNumberStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự số, chỉ được nhập chữ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterCharStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự chữ, chỉ được nhập số.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_Staff._checkCharacterCharStaff(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                DevExpress.XtraEditors.XtraMessageBox.Show("Không được nhập ký tự chữ, chỉ được nhập số.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //checked changed
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                radNu.Checked = false;
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
            {
                radNam.Checked = false;
            }
        }

        private void radAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radAvailable.Checked)
            {
                radUnavailable.Checked = false;
            }
        }

        private void radUnavailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radUnavailable.Checked)
            {
                radAvailable.Checked = false;
            }
        }

     
        #endregion
        //Thu

    }
}
