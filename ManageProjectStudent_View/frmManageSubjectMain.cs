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

namespace ManageProjectStudent_View
{
    public partial class frmManageSubjectMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int IStatus;
        private StaffModel StaffModel;

        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        private BindingList<LanguageWordModel> _lstLanWord = null;
        private WordModel _wordModel = null;
        public frmManageSubjectMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
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
                    currentButton.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 25, 77);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void btnViewDeadlineLecturer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageProjectStudent_View.frmViewDeadlineProject(), sender);
            lblTitle.Text = "Xem Hạn";
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Quản Lý Môn Học";
            panelTitleBar.BackColor = Color.FromArgb(0, 135, 137);
            panelLogo.BackColor = Color.FromArgb(24, 37, 60);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnManageInformationSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageSubject frmManageSubject = new frmManageSubject();
            frmManageSubject.ShowDialog();
            this.Close();
        }

        private void btnAddGroupSubject_Click(object sender, EventArgs e)
        {

            //OpenChildForm(new ManageProjectStudent_View.frmAddGroupForSubject(), sender);
            //lblTitle.Text = "Thêm Nhóm Cho Môn Học";
            //this.Hide();
            frmAddGroupForSubject frm = new frmAddGroupForSubject();
            frm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //this.Hide();
            //frmHome frmHome = new frmHome(IStatus, StaffModel) ;
            //frmHome.ShowDialog();
            this.Close();
        }

        private void btnAddStudentSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageProjectStudent_View.frmAddStudentSubject(), sender);
            lblTitle.Text = "Thêm Sinh Viên Vào Môn Học";
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void frmManageSubjectMain_Load(object sender, EventArgs e)
        {
            #region Multi-Language
            //string lan = Language.StrLanguageID;
            // _lstWord = _Word.getLstWord(this.Name);
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
                    if (btnManageInformationSubject.Text == _wordModel.StrWordName)
                    {
                        btnManageInformationSubject.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnAddStudentSubject.Text == _wordModel.StrWordName)
                    {
                        btnAddStudentSubject.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnAddGroup.Text == _wordModel.StrWordName)
                    {
                        btnAddGroup.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    if (btnReturn.Text == _wordModel.StrWordName)
                    {
                        btnReturn.Text = _WL.getMeanByID(lnword.StrID, Language.StrLanguageID);
                    }
                    #endregion
                }
            }
        }
    }
}
