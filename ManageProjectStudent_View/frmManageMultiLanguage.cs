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
    public partial class frmManageMultiLanguage : Form
    {
        public frmManageMultiLanguage()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private LanguageModel _LanguageModelNow = null;
        private ILanguage _Lan = Config.Container.Resolve<ILanguage>();
        private BindingList<LanguageModel> _lstLan = new BindingList<LanguageModel>();

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
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Lan.lstLanguageID());
            if (_STR_MAX == "1")
                return "NN" + _STR_MAX;
            return _STR_MAX;
        }

        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationLan.Enabled = false;
                    //txtID.ReadOnly = true;
                    if (_LanguageModelNow != null)
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
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    radDefault.Checked = false;
                    radNoneDefault.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationLan.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationLan.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LanguageModelNow == null)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                radDefault.Checked = false;
                radNoneDefault.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }
            else
            {
                txtID.Text = _LanguageModelNow.StrLanguageID;
                txtName.Text = _LanguageModelNow.StrLanguageName;
                if (_LanguageModelNow.StrDefault == "Có")
                {
                    radDefault.Checked = true;
                    radNoneDefault.Checked = false;
                }
                else
                {
                    radDefault.Checked = false;
                    radNoneDefault.Checked = true;
                }
                if (_LanguageModelNow.StrStatus == "Sử dụng")
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
            if (_LanguageModelNow == null)
            {
                _LanguageModelNow = new LanguageModel();
            }
            _LanguageModelNow.StrLanguageID = txtID.Text;
            _LanguageModelNow.StrLanguageName = txtName.Text;
            if (radDefault.Checked)
            {
                _LanguageModelNow.StrDefault = radDefault.Text;
            }
            else if (radNoneDefault.Checked)
            {
                _LanguageModelNow.StrDefault = radNoneDefault.Text;
            }

            if (radAvailable.Checked)
            {
                _LanguageModelNow.StrStatus = radAvailable.Text;
            }
            else
            {
                _LanguageModelNow.StrStatus = radUnavailable.Text;
            }
        }

        private void _lstLoadListLanguage()
        {
            _lstLan = _Lan.loadLanguage();
            gcListLan.DataSource = _lstLan;
        }
        #endregion
        #region Event
        private void frmManageMultiLanguage_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            #region Decen
            StaffModel = frmHome.staffModel;
            if (frmHome.lstDecent != null)
            {
                foreach (DecentralizeModel decen in frmHome.lstDecent)
                {
                    if (StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID, decen.StrFormID);
                    }
                }
            }
            #endregion

            #region Multi-Lan
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
                    if (lblDefault.Text == _wordModel.StrWordName)
                    {
                        lblDefault.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radDefault.Text == _wordModel.StrWordName)
                    {
                        radDefault.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (radNoneDefault.Text == _wordModel.StrWordName)
                    {
                        radNoneDefault.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
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
                    if (colLanguageID.Caption == _wordModel.StrWordName)
                    {
                        colLanguageID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colLanguageName.Caption == _wordModel.StrWordName)
                    {
                        colLanguageName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colDefault.Caption == _wordModel.StrWordName)
                    {
                        colDefault.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colStatus.Caption == _wordModel.StrWordName)
                    {
                        colStatus.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }    
            }    
            #endregion

            _lstLan = _Lan.loadLanguage();
            gcListLan.DataSource = _lstLan;
            _setStatusForm();
        }

        private void gvLanList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvLanList.SelectedRowsCount > 0)
                _LanguageModelNow = (LanguageModel)gvLanList.GetRow(gvLanList.FocusedRowHandle);
            else
                _LanguageModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _LanguageModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_LanguageModelNow != null)
            {
                if (_Lan.deleteCurrentLanguage(_LanguageModelNow))
                {
                    _lstLoadListLanguage();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLan.Count == 0)
                    {
                        _LanguageModelNow = null;
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
            if (txtName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tên Ngôn ngữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else if (!(radDefault.Checked) && !(radNoneDefault.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Mạc định", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Trạng thái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Lan.addNewLanguage(_LanguageModelNow);
                }
                else
                {
                    bresult = _Lan.updateCurrentLanguagef(_LanguageModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListLanguage();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            _IStatusForm = 0;
            _setStatusForm();
            _lstLan = _Lan.loadLanguage();
            gcListLan.DataSource = _lstLan;
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radDefault.Checked)
            {
                radNoneDefault.Checked = false;
            }
        }

        private void radNoneDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radNoneDefault.Checked)
            {
                radDefault.Checked = false;
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

        private void gvLanList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvLanList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        #endregion
    }
}
