using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using DevExpress.XtraPrinting.DataNodes;

namespace ManageProjectStudent_View
{
    public partial class frmDecentralization : Form
    {
        public frmDecentralization()
        {
            InitializeComponent();
        }
        #region Properties
        private BindingList<StaffTypeModel> _lstStaffType = new BindingList<StaffTypeModel>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();

        private BindingList<FormModel> _lstForm = new BindingList<FormModel>();
        private IForm _Form = Config.Container.Resolve<IForm>();

        private StaffModel _StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel _Decentralize = null;
        private BindingList<DecentralizeModel> _lstDecentralizeModels = new BindingList<DecentralizeModel>();

        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        bool _BAdd = true;
        bool _BDelete = true;
        bool _BEdit = true;
        bool _BView = true;

        #endregion
        #region Method
        private bool editDecen(BindingList<DecentralizeModel> _lstDecens)
        {
            bool BUpdate;
            foreach (DecentralizeModel decen in _lstDecens)
            {
                BUpdate = _Decen.updateCurrentDecentralizes(decen);
                if(BUpdate == true)
                {
                    break;
                }    
            }
            return true;
        }
        #endregion

        private void frmDecentralization_Load(object sender, EventArgs e)
        {
            _StaffModel = frmHome.staffModel;
            
                        //lookup-edit
                        _lstStaffType = _StaffType.loadStaffType();
                        lkeStaffType.Properties.ValueMember = "StrStaffTypeID";
                        lkeStaffType.Properties.DisplayMember = "StrStaffTypeName";
                        lkeStaffType.Properties.DataSource = _lstStaffType;
                        lkeStaffType.Properties.Columns["colStaffTypeID"].FieldName = "StrStaffTypeID";
                        lkeStaffType.Properties.Columns["colStaffTypeName"].FieldName = "StrStaffTypeName";

                        //Grid-view
                        _lstForm = _Form.loadForm();
                        LookUpEdit_Function.DataSource = _lstForm;
                        LookUpEdit_Function.Columns["colFormID"].FieldName = "StrFormID";
                        LookUpEdit_Function.Columns["colFormName"].FieldName = "StrFormName";
            foreach (StaffTypeModel staff in _lstStaffType)
            {
                if (staff.StrStaffTypeID == _StaffModel.StrStaffTypeID || staff.StrStaffTypeID == "Adms")
                {
                    _lstStaffType.Remove(staff);
                    _lstStaffType = _StaffType.loadStaffType();
                    break;
                }
            }

            Language = frmHome.languageModel;
            //_lstLanWord = _WL.getLstLanguageWord(Language.StrLanguageID, this.Name);
            if (frmHome.lstLanguageWord != null)
            {
                _lstLanWord = _WL.getLstLanguageWord(Language.StrLanguageID, this.Name);
                foreach (LanguageWordModel lnword in _lstLanWord)
                {
                    _wordModel = _Word.getWordSelected(lnword.StrWordID);
                    if (grpUsing.Text == _wordModel.StrWordName)
                    {
                        grpUsing.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeStaffType.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeStaffType.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (gvListFunction.ViewCaption == _wordModel.StrWordName)
                    {
                        gvListFunction.ViewCaption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colFunction.Caption == _wordModel.StrWordName)
                    {
                        colFunction.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colAdd.Caption == _wordModel.StrWordName)
                    {
                        colAdd.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colDelete.Caption == _wordModel.StrWordName)
                    {
                        colDelete.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colEdit.Caption == _wordModel.StrWordName)
                    {
                        colEdit.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colView.Caption == _wordModel.StrWordName)
                    {
                        colView.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }    
            }    

        }

        private void lkeStaffType_EditValueChanged(object sender, EventArgs e)
        {
            if (lkeStaffType.EditValue != null)
            {
                string _STR_StaffTypeID = lkeStaffType.EditValue.ToString();
                if (_STR_StaffTypeID == _StaffModel.StrStaffTypeID)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Cần Phân Quyền Cho Chính Mình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lkeStaffType.EditValue = null;
                }
                else
                {
                    _lstDecentralizeModels = _Decen.getListDecentralizeStaff(lkeStaffType.EditValue.ToString());

                    if (_lstDecentralizeModels != null && _StaffModel != null)
                    {
                        if (_StaffModel != null)
                        {
                            gcListFunction.DataSource = _lstDecentralizeModels;
                            for (int i = 0; i < gvListFunction.RowCount; i++)
                            {
                                if ((bool)gvListFunction.GetRowCellValue(i, "BAdd") == false)
                                {
                                    _BAdd = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BDelete") == false)
                                {
                                    _BDelete = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BEdit") == false)
                                {
                                    _BEdit = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BView") == false)
                                {
                                    _BView = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lkeStaffType.EditValue != null)
            {
                if (editDecen((BindingList<DecentralizeModel>)(gvListFunction.DataSource)))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công");
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại");
                }    
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lkeStaffType.Focus();
            }
        }

        private void btnExitFormManageLecturer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

