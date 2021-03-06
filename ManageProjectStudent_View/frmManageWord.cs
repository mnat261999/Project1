﻿using System;
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
using System.Text.RegularExpressions;

namespace ManageProjectStudent_View
{
    public partial class frmManageWord : Form
    {
        public frmManageWord()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private WordModel _WordModelNow = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        BindingList<WordModel> _lstWord = new BindingList<WordModel>();

        private IForm _Form = Config.Container.Resolve<IForm>();
        BindingList<FormModel> _lstForm = new BindingList<FormModel>();

        private StaffModel StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel Decentralize = null;

        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWordModel = null;
        //private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        #endregion
        #region Method
        private string getMaxID()
        {
            string _STR_MAX = GarenaViewModel.returnMaxCode(_Word.lstWordID());
            if (_STR_MAX == "1")
                return "T" + _STR_MAX;
            return _STR_MAX;
        }
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    txtID.ReadOnly = true;
                    grpInformationWord.Enabled = false;
                    if (_WordModelNow != null)
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
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    break;
                case 1:
                    txtID.Text = getMaxID();
                    txtName.Text = string.Empty;
                    //lkeModule.EditValue = null;

                    grpInformationWord.Enabled = true;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
                case 2:
                    grpInformationWord.Enabled = true;
                    break;
            }
        }
        private void _loadData()
        {
            if (_WordModelNow == null)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                //lkeModule.EditValue = null;
            }
            else
            {
                txtID.Text = _WordModelNow.StrWordId;
                txtName.Text = _WordModelNow.StrWordName;
               // lkeModule.EditValue = _WordModelNow.StrModule;
            }
        }
        private void _getData()
        {
            if (_WordModelNow == null)
            {
                _WordModelNow = new WordModel();
            }
            _WordModelNow.StrWordId = txtID.Text;
            _WordModelNow.StrWordName = txtName.Text;
           // _WordModelNow.StrModule = lkeModule.GetColumnValue("StrFormID").ToString();

        }
        private void _lstLoadListWord()
        {
            _lstWord = _Word.loadWord();
            gcListWord.DataSource = _lstWord;
        }
        #endregion
        #region Event
        private void frmManageWord_Load(object sender, EventArgs e)
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
            //_lstLanWord = _WL.getLstLanguageWord(Language.StrLanguageID, this.Name);
            if (frmHome.lstLanguageWord != null)
            {
                _lstLanWord = _WL.getLstLanguageWord(Language.StrLanguageID, this.Name);
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
                    if (colWordID.Caption == _wordModel.StrWordName)
                    {
                        colWordID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colWordName.Caption == _wordModel.StrWordName)
                    {
                        colWordName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (gvWordList.ViewCaption == _wordModel.StrWordName)
                    {
                        gvWordList.ViewCaption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (grpInformationWord.Text == _wordModel.StrWordName)
                    {
                        grpInformationWord.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }
            }
            #endregion
            //lookup-edit

            _lstWord = _Word.loadWord();
            //_lstForm = _Form.loadForm();
            //lkeModule.Properties.ValueMember = "StrFormID";
            //lkeModule.Properties.DisplayMember = "StrFormName";
            //lkeModule.Properties.DataSource = _lstForm;
            //lkeModule.Properties.Columns["colFormID"].FieldName = "StrFormID";
            //lkeModule.Properties.Columns["colFormName"].FieldName = "StrFormName";

            gcListWord.DataSource = _lstWord;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _WordModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_WordModelNow != null)
            {
                if (_Word.deleteCurrentWord(_WordModelNow))
                {
                    _lstLoadListWord();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstWord.Count == 0)
                    {
                        _WordModelNow = null;
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
            if (txtID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã từ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
            }
            else if (txtName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên từ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Word.addNewWord(_WordModelNow);
                }
                else
                {
                    bresult = _Word.updateCurrentWordf(_WordModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListWord();
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
            _lstWord = _Word.loadWord();
            gcListWord.DataSource = _lstWord;
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void gvWordList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvWordList.SelectedRowsCount > 0)
                _WordModelNow = (WordModel)gvWordList.GetRow(gvWordList.FocusedRowHandle);
            else
                _WordModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void gvWordList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvWordList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        private void gvWordList_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName == "StrWordId")
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
