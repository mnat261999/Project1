
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Model;
using ManageProjectStudent_Interface;
using Unity;
using DevExpress.XtraGrid.Views.Layout;

namespace ManageProjectStudent_View
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            random = new Random();
        }
        #region Properties
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private IStudent _Student = Config.Container.Resolve<IStudent>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        BindingList<StaffTypeModel> lstStaffType = new BindingList<StaffTypeModel>();
        public static StudentModel studentModel = null;
        public static StaffModel staffModel = null;
        private DecentralizeModel Decen = null;
        public static BindingList<DecentralizeModel> lstDecent = null;
        List<DecentralizeModel> _lstdecentralizeModels = new List<DecentralizeModel>();
        bool BStatusLogin = false;
        int ICheck;
        bool BCheckLan = false;

        public static LanguageModel languageModel = null;
        //private IWord _Word = Config.Container.Resolve<IWord>();
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<LanguageModel> _lstLanguage = null;
        private ILanguage _Lan = Config.Container.Resolve<ILanguage>();
        public static string DefaultLan;
        public static BindingList<LanguageWordModel> lstLanguageWord = null;
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        private WordModel _wordModel = null;
        private LanguageWordModel _languageModel = null;
        //public static string DefaultLan;
        #endregion
        #region Method
        private void setStatusLogin(bool bStatus, StudentModel student, StaffModel staff)
        {
            BStatusLogin = bStatus;
            studentModel = student;
            staffModel = staff;
            if (bStatus)
            {
                if (student != null)
                {
                    ICheck = 1;
                    btnSetLan.Visible = true;
                    lblDisplayName.Text = student.StrStudentName;
                    lblType.Text = "Sinh viên";
                }
                else
                {
                    btnSetLan.Visible = true;
                    lblDisplayName.Text = staff.StrStaffName;
                    if (lstStaffType == null)
                        lstStaffType = new BindingList<StaffTypeModel>();

                    lstStaffType = _StaffType.loadStaffType();

                    foreach (StaffTypeModel staffType in lstStaffType)
                    {
                        if (staff.StrStaffTypeID == staffType.StrStaffTypeID)
                        {
                            lblType.Text = staffType.StrStaffTypeName;
                            //lstDecent = _Decen.loadDecentralize();
                            break;
                        }
                    }
                    lstDecent = _Decen.getListDecentralizeStaff(staff.StrStaffTypeID);
                }
                btnLogin.Text = "Đăng Xuất";
            }
            else
            {
                btnLogin.Text = "Đăng Nhập";
                lblDisplayName.Text = "Họ tên";
                lblType.Text = "Chức danh";
                btnSetLan.Visible = false;
            }    
        }
        private void setLanguage (bool bCheck, LanguageModel language)
        {
            BCheckLan = bCheck;
            languageModel = language;
            if(bCheck)
            {
                if(language != null)
                {
                    if(language.StrLanguageID == DefaultLan)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Đây là ngôn ngữ mặc định bạn phải chọn ngôn ngữ khác để thay đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                    else
                    {
                        DefaultLan = language.StrLanguageID;
                        //_lstWord = _Word.getLstWord(this.Name);
                        _lstLanWord = _WL.getLstLanguageWord(DefaultLan, this.Name);
                        if (studentModel != null || staffModel != null)
                        {
                            foreach (LanguageWordModel lnword in _lstLanWord)
                            {
                                _wordModel = _Word.getWordSelected(lnword.StrWordID);
                                //_languageModel = _WL.getWordLanguageSelectedByID(lnword.StrID);
                                if (itemStatic.Text == _wordModel.StrWordName)
                                {
                                    itemStatic.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemMulLan.Text == _wordModel.StrWordName)
                                {
                                    itemMulLan.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (lblType.Text == _wordModel.StrWordName)
                                {
                                    lblType.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (btnSetLan.Text == _wordModel.StrWordName)
                                {
                                    btnSetLan.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (btnLogin.Text == _wordModel.StrWordName)
                                {
                                    btnLogin.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (btnInformation.Text == _wordModel.StrWordName)
                                {
                                    btnInformation.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (btnExit.Text == _wordModel.StrWordName)
                                {
                                    btnExit.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemDecentralization.Text == _wordModel.StrWordName)
                                {
                                    itemDecentralization.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemStatic.Text == _wordModel.StrWordName)
                                {
                                    itemStatic.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemMulLan.Text == _wordModel.StrWordName)
                                {
                                    itemMulLan.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageProject.Text == _wordModel.StrWordName)
                                {
                                    itemManageProject.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManagStaffType.Text == _wordModel.StrWordName)
                                {
                                    itemManagStaffType.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageLecturer.Text == _wordModel.StrWordName)
                                {
                                    itemManageLecturer.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageStudent.Text == _wordModel.StrWordName)
                                {
                                    itemManageStudent.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageStudent.Text == _wordModel.StrWordName)
                                {
                                    itemManageStudent.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageFaculty.Text == _wordModel.StrWordName)
                                {
                                    itemManageFaculty.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManageClass.Text == _wordModel.StrWordName)
                                {
                                    itemManageClass.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                                if (itemManagSubject.Text == _wordModel.StrWordName)
                                {
                                    itemManagSubject.Text = _WL.getMeanByID(lnword.StrID, languageModel.StrLanguageID);
                                }
                            }
                            //if(itemStatic.Text == word.StrWordName)
                            //{
                            //    itemStatic.Text = _WL.getMeanByID(word.StrWordId, languageModel.StrLanguageID);
                            //}
                            //if (itemMulLan.Text == word.StrWordName)
                            //{
                            //    itemMulLan.Text = _WL.getMeanByID(word.StrWordId, languageModel.StrLanguageID);
                            //}
                            //lblType.Text = _WL.getMean(lblType.Text, language.StrLanguageID);
                            //btnSetLan.Text = _WL.getMean(btnSetLan.Text, language.StrLanguageID);
                            //btnLogin.Text = _WL.getMean(btnLogin.Text, language.StrLanguageID);
                            //btnInformation.Text = _WL.getMean(btnInformation.Text, language.StrLanguageID);
                            //btnExit.Text = _WL.getMean(btnExit.Text, language.StrLanguageID);
                            //itemDecentralization.Text = _WL.getMean(itemDecentralization.Text, language.StrLanguageID);
                            //itemStatic.Text= _WL.getMean(itemStatic.Text, language.StrLanguageID);
                            //itemMulLan.Text = _WL.getMean(itemMulLan.Text, language.StrLanguageID);
                            //itemManageProject.Text = _WL.getMean(itemManageProject.Text, language.StrLanguageID);
                            //itemManagStaffType.Text = _WL.getMean(itemManagStaffType.Text, language.StrLanguageID);
                            //itemManageLecturer.Text = _WL.getMean(itemManageLecturer.Text, language.StrLanguageID);
                            //itemManageStudent.Text = _WL.getMean(itemManageStudent.Text, language.StrLanguageID);
                            //itemManageFaculty.Text = _WL.getMean(itemManageFaculty.Text, language.StrLanguageID);
                            //itemManageClass.Text = _WL.getMean(itemManageClass.Text, language.StrLanguageID);
                            //itemManagSubject.Text = _WL.getMean(itemManagSubject.Text, language.StrLanguageID);
                        }
                        lstLanguageWord = _WL.getListLanguageWord(language.StrLanguageID);
                    }
                }    
            }    
        }
        private void SettingDefaultLan()
        {
            _lstLanguage = new BindingList<LanguageModel>();
            _lstLanguage = _Lan.loadLanguage();
            foreach (LanguageModel language in _lstLanguage)
            {
                if (language.StrDefault == "Có")
                {
                    DefaultLan = language.StrLanguageID;
                    break;
                }
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuHome.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 25, 77);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion
        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (BStatusLogin == false)
            {
                frmLogin frm = new frmLogin();
                frm.login = setStatusLogin;
                frm.ShowDialog();
            }
            else
            {
                setStatusLogin(false, null, null);
            }
        }
        private void btnSetLan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if(BCheckLan == false)
            {
                frmSettingLanguage frm = new frmSettingLanguage();
                frm.setting = setLanguage;
                frm.ShowDialog();
            } 
            else
            {
                setLanguage(false, null);
            }    
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Application.Exit();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuHome.Size.Width == 56)
            {
                panelMenuHome.Size = new Size(250, 60);
                panUser.Visible = true;
                btnMenu.Text = "Menu";
            }
            else
            {
                panelMenuHome.Size = new Size(56, 60);
                panUser.Visible = false;
                btnMenu.Text = "";
            }
        }
        private void itemDecentralization_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmDecentralization frm = new frmDecentralization();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManageStudent_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageStudentInformation frm = new frmManageStudentInformation();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManageLecturer_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageLecturerInformation frm = new frmManageLecturerInformation();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManageFaculty_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageFaculty frm = new frmManageFaculty();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManageProject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                frmSubmitProject frm = new frmSubmitProject();
                frm.ShowDialog();
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageProjectMain frm = new frmManageProjectMain();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManagSubject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageSubjectMain frm = new frmManageSubjectMain();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            btnSetLan.Visible = false;
            SettingDefaultLan();
        }
        private void itemManageClass_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageClass frm = new frmManageClass();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemManagStaffType_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmStaffType frm = new frmStaffType();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemStatic_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmStatic frm = new frmStatic();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void itemMulLan_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (ICheck == 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lstDecent != null)
                {
                    frmManageLanguageMain frm = new frmManageLanguageMain();
                    foreach (DecentralizeModel decentralize in lstDecent)
                    {
                        if (staffModel.StrStaffTypeID == decentralize.StrStaffTypeID && frm.Name == decentralize.StrFormID)
                        {
                            if (decentralize.BAdd == true || decentralize.BEdit == true || decentralize.BDelete == true || decentralize.BView == true)
                            {
                                frm.ShowDialog();
                                break;
                            }
                            else
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn không được sử dụng chức năng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
