using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.AccessControl;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using DevExpress.Data.Svg;

namespace ManageProjectStudent_View
{
    public partial class frmAddWordForLanguage : Form
    {
        public frmAddWordForLanguage()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;

        private LanguageWordModel _LanguageWordModelNow = null;
        private BindingList<LanguageWordModel> _lstLanguageWord = new BindingList<LanguageWordModel>();
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();

        private IForm _Form = Config.Container.Resolve<IForm>();
        BindingList<FormModel> _lstForm = new BindingList<FormModel>();

        private ILanguage _Lan = Config.Container.Resolve<ILanguage>();
        private BindingList<LanguageModel> _lstLan = new BindingList<LanguageModel>();

        private IWord _Word = Config.Container.Resolve<IWord>();
        BindingList<WordModel> _lstWord = new BindingList<WordModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;

        private LanguageModel Language = null;
        //private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWordModel = null;
        //private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        #endregion
        #region Method
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_WL.lstID());
            if (_STR_MAX == "1")
                return _STR_MAX;
            return _STR_MAX;
        }

        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0: // View
                    txtID.ReadOnly = true;
                    grpInformationWordLan.Enabled = false;
                    if (_LanguageWordModelNow != null)
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
                    break;
                case 1:
                    txtID.Text = getMaxID();
                    lkeLanguage.EditValue = null;
                    lkeWord.EditValue = null;
                    txtMean.Text = string.Empty;
                    lkeModule.EditValue = null;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationWordLan.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                case 2:
                    grpInformationWordLan.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LanguageWordModelNow == null)
            {
                txtID.Text = string.Empty;
                lkeLanguage.EditValue = null;
                lkeWord.EditValue = null;
                txtMean.Text = string.Empty;
                lkeModule.EditValue = null;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }
            else
            {
                txtID.Text = _LanguageWordModelNow.StrID;
                lkeLanguage.EditValue = _LanguageWordModelNow.StrLanguageID;
                lkeWord.EditValue = _LanguageWordModelNow.StrWordID;
                txtMean.Text = _LanguageWordModelNow.StrMean;
                lkeModule.EditValue = _LanguageWordModelNow.StrModule;
                if (_LanguageWordModelNow.StrStatus == "Sử dụng")
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
            if (_LanguageWordModelNow == null)
            {
                _LanguageWordModelNow = new LanguageWordModel();
            }
            _LanguageWordModelNow.StrID = txtID.Text;
            _LanguageWordModelNow.StrLanguageID = lkeLanguage.GetColumnValue("StrLanguageID").ToString();
            _LanguageWordModelNow.StrWordID = lkeWord.GetColumnValue("StrWordId").ToString();
            _LanguageWordModelNow.StrMean = txtMean.Text;
            _LanguageWordModelNow.StrModule = lkeModule.GetColumnValue("StrFormID").ToString();
            if (radAvailable.Checked)
            {
                _LanguageWordModelNow.StrStatus = radAvailable.Text;
            }
            else
            {
                _LanguageWordModelNow.StrStatus = radUnavailable.Text;
            }
        }

        private void _lstLoadListWordLan()
        {
            _lstLanguageWord = _WL.loadLanguageWord();
            gcListWordLan.DataSource = _lstLanguageWord;
        }
        #endregion
        #region Event
        private void frmAddWordForLanguage_Load(object sender, EventArgs e)
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
                    }
                }
            }
            #region Multi-lan
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
                    if (lblLan.Text == _wordModel.StrWordName)
                    {
                        lblLan.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblWord.Text == _wordModel.StrWordName)
                    {
                        lblWord.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblMean.Text == _wordModel.StrWordName)
                    {
                        lblMean.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblModule.Text == _wordModel.StrWordName)
                    {
                        lblModule.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
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
                    if (colID.Caption == _wordModel.StrWordName)
                    {
                        colID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colLanguage.Caption == _wordModel.StrWordName)
                    {
                        colLanguage.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colWord.Caption == _wordModel.StrWordName)
                    {
                        colWord.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colMean.Caption == _wordModel.StrWordName)
                    {
                        colMean.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colModule.Caption == _wordModel.StrWordName)
                    {
                        colModule.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colStatus.Caption == _wordModel.StrWordName)
                    {
                        colStatus.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeLanguage.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeLanguage.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeWord.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeWord.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }
            }    
                #endregion
                _lstLan = _Lan.loadLanguage();
            lkeLanguage.Properties.ValueMember = "StrLanguageID";
            lkeLanguage.Properties.DisplayMember = "StrLanguageName";
            lkeLanguage.Properties.DataSource = _lstLan;
            lkeLanguage.Properties.Columns["colLanguageID"].FieldName = "StrLanguageID";
            lkeLanguage.Properties.Columns["colLanguageName"].FieldName = "StrLanguageName";

            _lstWord = _Word.loadWord();
            lkeWord.Properties.ValueMember = "StrWordId";
            lkeWord.Properties.DisplayMember = "StrWordName";
            lkeWord.Properties.DataSource = _lstWord;
            lkeWord.Properties.Columns["colWordID"].FieldName = "StrWordId";
            lkeWord.Properties.Columns["colWordName"].FieldName = "StrWordName";

            _lstForm = _Form.loadForm();
            lkeModule.Properties.ValueMember = "StrFormID";
            lkeModule.Properties.DisplayMember = "StrFormName";
            lkeModule.Properties.DataSource = _lstForm;
            lkeModule.Properties.Columns["colFormID"].FieldName = "StrFormID";
            lkeModule.Properties.Columns["colFormName"].FieldName = "StrFormName";
            ///*GridView*/
            _lstLanguageWord = _WL.loadLanguageWord();

            LookUpEdit_Language.DataSource = _lstLan;
            LookUpEdit_Language.Columns["colLanguageID"].FieldName = "StrLanguageID";
            LookUpEdit_Language.Columns["colLanguageName"].FieldName = "StrLanguageName";

            LookUpEdit_Word.DataSource = _lstWord;
            LookUpEdit_Word.Columns["colWordID"].FieldName = "StrWordId";
            LookUpEdit_Word.Columns["colWordName"].FieldName = "StrWordName";

            gcListWordLan.DataSource = _lstLanguageWord;
            _setStatusForm();
        }

        private void gvWordLanList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvWordLanList.SelectedRowsCount > 0)
                _LanguageWordModelNow = (LanguageWordModel)gvWordLanList.GetRow(gvWordLanList.FocusedRowHandle);
            else
                _LanguageWordModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _LanguageWordModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtMean.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtMean.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_LanguageWordModelNow != null)
            {
                if (_WL.deleteCurrentWordLanguage(_LanguageWordModelNow))
                {
                    _lstLoadListWordLan();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLanguageWord.Count == 0)
                    {
                        _LanguageWordModelNow = null;
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
            if (lkeLanguage.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngôn ngữ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeWord.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Từ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMean.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Nghĩa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMean.Focus();
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
                    bresult = _WL.addNewWord(_LanguageWordModelNow);
                }
                else
                {
                    bresult = _WL.updateCurrentWord(_LanguageWordModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListWordLan();
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
            _lstLanguageWord = _WL.loadLanguageWord();
            gcListWordLan.DataSource = _lstLanguageWord;
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
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

        private void gvWordLanList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvWordLanList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        private void gvWordLanList_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName == "StrID")
            {
                e.Handled = true;
                int num1 = GarenaViewModel._seperateNumber((string)e.Value1);
                int num2 = GarenaViewModel._seperateNumber((string)e.Value2);
                e.Result = num1.CompareTo(num2);
            }
        }
        #endregion
    }
}
