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
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;

namespace ManageProjectStudent_View
{
    public partial class frmManageLanguageMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int IStatus;  //1:student 2: Staff
        private StudentModel StudentModel;
        private StaffModel StaffModel;
        private LanguageModel Language = null;
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<WordModel> _lstWord = null;
        private IWord _Word = Config.Container.Resolve<IWord>();
        public frmManageLanguageMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }
        public frmManageLanguageMain(int IStatusLogin, StudentModel student)
        {
            InitializeComponent();
            random = new Random();
            IStatus = IStatusLogin;
            StudentModel = student;
            btnCloseChildForm.Visible = false;
        }

        public frmManageLanguageMain(int IStatusLogin, StaffModel staff)
        {
            InitializeComponent();
            random = new Random();
            IStatus = IStatusLogin;
            StaffModel = staff;
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
                    currentButton.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            btnExitForm.Visible = false;
            //lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Quản lý đa ngôn ngữ";
            panelTitleBar.BackColor = Color.FromArgb(0, 135, 137);
            panelLogo.BackColor = Color.FromArgb(24, 37, 60);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            btnExitForm.Visible = true;
        }

        private void btnManageLanguage_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmManageMultiLanguage frm = new frmManageMultiLanguage();
            frm.ShowDialog();
        }


        private void btnManageWord_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmManageWord frm = new frmManageWord();
            frm.ShowDialog();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            frmAddWordForLanguage frm = new frmAddWordForLanguage();
            frm.ShowDialog();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Util.EndAnimate(this, Util.Effect.Slide, 150, 30);
            this.Close();
        }

        private void frmManageLanguageMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            Language = frmHome.languageModel;
            //_lstWord = _Word.getLstWord(this.Name);

            if (frmHome.lstLanguageWord != null)
            {
                foreach (WordModel word in _lstWord)
                {
                    if (lblTitle.Text == word.StrWordName)
                    {
                        lblTitle.Text = _WL.getMeanByID(word.StrWordId, Language.StrLanguageID);
                    }
                    if (btnManageLanguage.Text == word.StrWordName)
                    {
                        btnManageLanguage.Text = _WL.getMeanByID(word.StrWordId, Language.StrLanguageID);
                    }
                    if (btnManageWord.Text == word.StrWordName)
                    {
                        btnManageWord.Text = _WL.getMeanByID(word.StrWordId, Language.StrLanguageID);
                    }
                    if (btnAddWord.Text == word.StrWordName)
                    {
                        btnAddWord.Text = _WL.getMean(btnAddWord.Text, Language.StrLanguageID);
                    }
                }
            }
        }
    }
}
