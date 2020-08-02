using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProjectStudent_Model
{
    [Table("Language")]
    public class LanguageModel
    {
        private string _StrLanguageID;
        private string _StrLanguageName;
        private string _StrDefault;
        private string _StrStatus;
        private int _ILang_Default;
        private int _IOdering;

        [Key]
        [Column("LanguageID", TypeName = "varchar", Order = 0)]
        [StringLength(10)]
        public string StrLanguageID { get => _StrLanguageID; set => _StrLanguageID = value; }
       
        [Column("LanguageName", TypeName = "nvarchar", Order = 1)]
        [StringLength(100)]
        public string StrLanguageName { get => _StrLanguageName; set => _StrLanguageName = value; }

        [Column("Default", TypeName = "nvarchar", Order = 2)]
        public string StrDefault { get => _StrDefault; set => _StrDefault = value; }

        [Column("Status", TypeName = "nvarchar", Order = 3 )]
        public string StrStatus { get => _StrStatus; set => _StrStatus = value; }

        [Column("Lang_Default", Order = 4)]
        public int ILang_Default { get => _ILang_Default; set => _ILang_Default = value; }

        [Column("Odering", Order = 5)]
        public int IOdering { get => _IOdering; set => _IOdering = value; }
        // Khai bao khoa ngoai.
        public ICollection<LanguageWordModel> LanguageWordModel { get; set; }

        public LanguageModel()
        {
            this.LanguageWordModel = new HashSet<LanguageWordModel>();
        }
    }
}
