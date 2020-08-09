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

namespace ManageProjectStudent_View
{
    public partial class frmManageProjectTask : Form
    {
        public frmManageProjectTask()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private ProjectTaskModel _TaskModelNow = null;
        private IProjectTask _Task = Config.Container.Resolve<IProjectTask>();
        private BindingList<ProjectTaskModel> _lstTask = new BindingList<ProjectTaskModel>();
        private IProject _Project = Config.Container.Resolve<IProject>();
        private BindingList<ProjectModel> _lstProject = new BindingList<ProjectModel>();

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
        #region Mehthod
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    grpInformationTask.Enabled = false;
                    if(_TaskModelNow != null)
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
                    lkeProjectID.EditValue = null;
                    txtTaskID.Text = "";
                    txtTaskName.Text = "";
                    dteStartDay.EditValue = null;
                    dteEndDay.EditValue = null;
                    txtFileName.Text = "";
                    txtLinkFile.Text = "";

                    grpInformationTask.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2 :
                    grpInformationTask.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if(_TaskModelNow == null)
            {
                lkeProjectID.EditValue = null;
                txtTaskID.Text = "";
                txtTaskName.Text = "";
                dteStartDay.EditValue = null;
                dteEndDay.EditValue = null;
                txtFileName.Text = "";
                txtLinkFile.Text = "";
            }
            else
            {
                lkeProjectID.EditValue = _TaskModelNow.StrProjectID;
                txtTaskID.Text = _TaskModelNow.StrTaskID;
                txtTaskName.Text = _TaskModelNow.StrTaskName;
                dteStartDay.EditValue = _TaskModelNow.DtStartDay.Date;
                dteEndDay.EditValue = _TaskModelNow.DtStartDay.Date;
                txtFileName.Text = _TaskModelNow.StrFileName;
                txtLinkFile.Text = _TaskModelNow.StrLinkFile;
            }
        }

        private void _getData()
        {
            if (_TaskModelNow == null)
            {
                _TaskModelNow = new ProjectTaskModel();
            }
            _TaskModelNow.StrProjectID = lkeProjectID.GetColumnValue("StrProjectID").ToString();
            _TaskModelNow.StrTaskID = txtTaskID.Text;
            _TaskModelNow.StrTaskName = txtTaskName.Text;
            _TaskModelNow.DtStartDay = (DateTime)dteStartDay.EditValue;
            _TaskModelNow.DtEndDay = (DateTime)dteEndDay.EditValue;
            _TaskModelNow.StrFileName = txtFileName.Text;
            _TaskModelNow.StrLinkFile = txtLinkFile.Text;
        }

        private void _lstLoadListTask()
        {
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);
            gcListTask.DataSource = _lstTask;
        }
        #endregion
        #region Event
        private void frmManageProjectTask_Load(object sender, EventArgs e)
        {
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
                    if (btnExportList.Text == _wordModel.StrWordName)
                    {
                        btnExportList.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnSave.Text == _wordModel.StrWordName)
                    {
                        btnSave.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblIDProject.Text == _wordModel.StrWordName)
                    {
                        lblIDProject.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblID.Text == _wordModel.StrWordName)
                    {
                        lblID.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblName.Text == _wordModel.StrWordName)
                    {
                        lblName.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblStartDay.Text == _wordModel.StrWordName)
                    {
                        lblStartDay.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblEndDay.Text == _wordModel.StrWordName)
                    {
                        lblEndDay.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblFileName.Text == _wordModel.StrWordName)
                    {
                        lblFileName.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblLink.Text == _wordModel.StrWordName)
                    {
                        lblLink.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colProjectID.Caption == _wordModel.StrWordName)
                    {
                        colProjectID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colTaskID.Caption == _wordModel.StrWordName)
                    {
                        colTaskID.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colTaskName.Caption == _wordModel.StrWordName)
                    {
                        colTaskName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colStartDay.Caption == _wordModel.StrWordName)
                    {
                        colStartDay.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colEndDay.Caption == _wordModel.StrWordName)
                    {
                        colEndDay.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colFileName.Caption == _wordModel.StrWordName)
                    {
                        colFileName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colLinkFile.Caption == _wordModel.StrWordName)
                    {
                        colLinkFile.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (gvListTask.ViewCaption == _wordModel.StrWordName)
                    {
                        gvListTask.ViewCaption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (grpInformationTask.Text == _wordModel.StrWordName)
                    {
                        grpInformationTask.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }    
            }    
                #endregion

                dteStartDay.EditValue = DateTime.Now.Date;
            dteEndDay.EditValue = DateTime.Now.Date;

            _lstProject = _Project.loadProject();
            lkeProjectID.Properties.ValueMember = "StrProjectID";
            lkeProjectID.Properties.DisplayMember = "StrProjectID";
            lkeProjectID.Properties.DataSource = _lstProject;
            lkeProjectID.Properties.Columns["colProjectID"].FieldName = "StrProjectID";

            ///*GridView*/
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);

            LookUpEdit_Project.DataSource = _lstTask;
            LookUpEdit_Project.Columns["colProjectID"].FieldName = "StrProjectID";

            gcListTask.DataSource = _lstTask;
            _setStatusForm();
            
        }

        private void gvListTask_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (gvListTask.SelectedRowsCount > 0)
                _TaskModelNow = (ProjectTaskModel)gvListTask.GetRow(gvListTask.FocusedRowHandle);
            else
                _TaskModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _TaskModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtTaskID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtTaskID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_TaskModelNow != null)
            {
                if (_Task.deleteCurrentProjectTask(_TaskModelNow))
                {
                    _lstLoadListTask();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstTask.Count == 0)
                    {
                        _TaskModelNow = null;
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
            if (lkeProjectID.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Mã đồ án", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTaskID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã task", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTaskName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên task", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartDay.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày bắt đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndDay.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Ngày kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Task.addNewProjectTask(_TaskModelNow);
                }
                else
                {
                    bresult = _Task.addNewProjectTask(_TaskModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListTask();
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
            //_lstTask = _Task.loadProjectTask();
            _lstTask = _Task.getListProjectTaskForStaff(frmHome.staffModel.StrStaffID);
            gcListTask.DataSource = _lstTask;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmManageProjectMain frm = new frmManageProjectMain();
            //frm.ShowDialog();
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            this.Close();
        }

        private void gvListTask_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvListTask_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvListTask.RowCount > 0)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = @"Export file excel";
                    dialog.FileName = "";
                    dialog.Filter = @"Micrsoft Excel|*.xlsx";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gvListTask.ColumnPanelRowHeight = 40;
                        gvListTask.OptionsPrint.AutoWidth = AutoSize;
                        gvListTask.OptionsPrint.ShowPrintExportProgress = true;
                        gvListTask.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gvListTask.ExportToXlsx(dialog.FileName, options);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error" + ex, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
