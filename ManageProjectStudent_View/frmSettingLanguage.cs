using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native.Lines;

namespace ManageProjectStudent_View
{
    public partial class frmSettingLanguage : Form
    {
        public frmSettingLanguage()
        {
            InitializeComponent();
        }
        #region Properties
        private ILanguage _Lan = Config.Container.Resolve<ILanguage>();
        private IWordLanguage _WL = Config.Container.Resolve<IWordLanguage>();
        private BindingList<LanguageModel> _lstLan = new BindingList<LanguageModel>();
        public static BindingList<LanguageWordModel> _lstLanguageWord = new BindingList<LanguageWordModel>();
        public delegate void SettingLanguage(bool bCheck, LanguageModel language);
        public SettingLanguage setting = null;
        public static LanguageModel languageSelected = null;
        #endregion
        private void frmSettingLanguage_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Slide, 150, 180);
            _lstLan = _Lan.loadLanguage();
            lkeLanguage.Properties.ValueMember = "StrLanguageID";
            lkeLanguage.Properties.DisplayMember = "StrLanguageName";
            lkeLanguage.Properties.DataSource = _lstLan;
            lkeLanguage.Properties.Columns["colLanguageID"].FieldName = "StrLanguageID";
            lkeLanguage.Properties.Columns["colLanguageName"].FieldName = "StrLanguageName";
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            languageSelected = new LanguageModel();
            if(lkeLanguage.EditValue != null)
            {
                languageSelected = _Lan.getLanguageSelected(lkeLanguage.EditValue.ToString());
                if(setting != null)
                {
                    setting(true, languageSelected);
                }
                this.Close();
            }  
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn ngôn ngữ muốn thay đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }    
        }
    }
}
