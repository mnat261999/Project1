using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_ViewModel;
using ManageProjectStudent_Model;
using System.IO;
using System.Drawing.Text;
namespace ManageProjectStudent_View
{
    public partial class frmSubmitProject : Form
    {
        // Thong
        private ISubmitProject ISP = Config.Container.Resolve<ISubmitProject>();
        // Thong
        public frmSubmitProject()
        {
            InitializeComponent();

        }
        #region Properties
        private BindingList<ProjectModel> _lstProject = new BindingList<ProjectModel>();
        private BindingList<ProjectTaskModel> _lstTask = new BindingList<ProjectTaskModel>();
        private IProject _Project = Config.Container.Resolve<IProject>();
        private IProjectTask _ProjectTk = Config.Container.Resolve<IProjectTask>();
        private ProjectTaskModel _ProjectTaskModelNow = null;
        private int _IStatusForm = 0;

        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        #endregion
        #region Method
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    grpSubmit.Enabled = false;
                    break;
                case 1:
                    grpSubmit.Enabled = true;
                    break;   
            }    
        }

        private void _loadData()
        {
            if(_ProjectTaskModelNow == null)
            {
                lkeTask.EditValue = string.Empty;
                lkeProject.EditValue = string.Empty;
                txtFileName.Text = string.Empty;
                txtFolderPath.Text = string.Empty;
            }    
            else
            {
                lkeTask.EditValue = _ProjectTaskModelNow.StrTaskID;
                lkeProject.EditValue = _ProjectTaskModelNow.StrProjectID;
                txtFileName.Text = _ProjectTaskModelNow.StrFileName;
                txtFolderPath.Text = _ProjectTaskModelNow.StrLinkFile;
            }    
        }

        private void _getData()
        {
            if(_ProjectTaskModelNow==null)
            {
                _ProjectTaskModelNow = new ProjectTaskModel();
            }
            //_ProjectTaskModelNow.StrTaskID = lkeTask.GetColumnValue("StrTaskID").ToString();
            //_ProjectTaskModelNow.StrProjectID = lkeProject.GetColumnValue("StrProjectID").ToString();
            _ProjectTaskModelNow.StrFileName = txtFileName.Text;
            _ProjectTaskModelNow.StrLinkFile = txtFolderPath.Text;
        }

        private void _lstLoadListTask()
        {
            //_lstTask = _ProjectTk.loadProjectTask();
            _lstTask = _ProjectTk.getListProjectTaskForStudent(frmHome.studentModel.StrStudentID);
            gcListTask.DataSource = _lstTask;
        }
        #endregion
        #region Event
        //load
        private void frmSubmitProject_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);

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
                    if (btnUpdate.Text == _wordModel.StrWordName)
                    {
                        btnUpdate.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblNoti.Text == _wordModel.StrWordName)
                    {
                        lblNoti.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblProject.Text == _wordModel.StrWordName)
                    {
                        lblProject.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblTask.Text == _wordModel.StrWordName)
                    {
                        lblTask.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblStorageFile.Text == _wordModel.StrWordName)
                    {
                        lblStorageFile.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblName.Text == _wordModel.StrWordName)
                    {
                        lblName.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lblSaveFile.Text == _wordModel.StrWordName)
                    {
                        lblSaveFile.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnChooseFolder.Text == _wordModel.StrWordName)
                    {
                        btnChooseFolder.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnSave.Text == _wordModel.StrWordName)
                    {
                        btnSave.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeProject.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeProject.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (lkeTask.Properties.NullText == _wordModel.StrWordName)
                    {
                        lkeTask.Properties.NullText = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colTaskName.Caption == _wordModel.StrWordName)
                    {
                        colTaskName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colProjectName.Caption == _wordModel.StrWordName)
                    {
                        colProjectName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colFileName.Caption == _wordModel.StrWordName)
                    {
                        colFileName.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (colLinkFile.Caption == _wordModel.StrWordName)
                    {
                        colLinkFile.Caption = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                }    
            }    
                #endregion

                //_lstTask = _ProjectTk.loadProjectTask();
                _lstTask = _ProjectTk.getListProjectTaskForStudent(frmHome.studentModel.StrStudentID);
            lkeTask.Properties.ValueMember = "StrTaskID";
            lkeTask.Properties.DisplayMember = "StrTaskName";
            lkeTask.Properties.DataSource = _lstTask;
            lkeTask.Properties.Columns["colTaskID"].FieldName = "StrTaskID";
            lkeTask.Properties.Columns["colTaskName"].FieldName = "StrTaskName";

            _lstProject = _Project.loadProject();
            lkeProject.Properties.ValueMember = "StrProjectID";
            lkeProject.Properties.DisplayMember = "StrProjectName";
            lkeProject.Properties.DataSource = _lstProject;
            lkeProject.Properties.Columns["colProjectID"].FieldName = "StrProjectID";
            lkeProject.Properties.Columns["colProjectName"].FieldName = "StrProjectName";

            ///*GridView*/
            //_lstTask = _ProjectTk.loadProjectTask();
            _lstTask = _ProjectTk.getListProjectTaskForStudent(frmHome.studentModel.StrStudentID);

            LookUpEdit_Task.DataSource = _lstTask;
            LookUpEdit_Task.Columns["colTaskID"].FieldName = "StrTaskID";
            LookUpEdit_Task.Columns["colTaskName"].FieldName = "StrTaskName";

            LookUpEdit_Project.DataSource = _lstProject;
            LookUpEdit_Project.Columns["colProjectID"].FieldName = "StrProjectID";
            LookUpEdit_Project.Columns["colProjectName"].FieldName = "StrProjectName";

            gcListTask.DataSource = _lstTask;
            _setStatusForm();

        }

        //selectionChanged
        private void gvListLink_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvListLink.SelectedRowsCount > 0)
                _ProjectTaskModelNow = (ProjectTaskModel)gvListLink.GetRow(gvListLink.FocusedRowHandle);
            else
                _ProjectTaskModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        //click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 1;
            _setStatusForm();
            txtFileName.Focus();
        }

        private void btnChoosFile_Click(object sender, EventArgs e)
        {
            txtFilePath.Clear();
            txtFileName.Clear();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Microsoft Word Document |*.docx";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                    txtFileName.Text = Path.GetFileName(txtFilePath.Text);
                }
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtFolderPath.Text = fbd.SelectedPath;
                Environment.SpecialFolder root = fbd.RootFolder;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn file", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFolderPath.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn đường dẫn lưu file", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFileName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng nhập tên file", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(txtFolderPath.Text);
                string readFile = File.ReadAllText(txtFilePath.Text);
                using (StreamWriter sw = new StreamWriter(txtFolderPath.Text + @"\" + txtFileName.Text))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine("----------------------");
                    sw.WriteLine(readFile);
                    sw.WriteLine("----------------------");
                    sw.WriteLine(DateTime.Now);
                }
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _ProjectTk.addLinkFile(_ProjectTaskModelNow);
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

        #endregion

        private void btnExitFormManageStudent_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }
    }
}
