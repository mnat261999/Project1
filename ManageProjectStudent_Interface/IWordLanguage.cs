using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_Interface
{
    public interface IWordLanguage
    {
        BindingList<LanguageWordModel> loadLanguageWord();
        LanguageWordModel getWordLanguageSelectedByWordID(string StrWordID);
        LanguageWordModel getWordLanguageSelectedByLanguageID(string StrWordID);
        bool addNewWord(LanguageWordModel WordLanguage);
        bool updateCurrentWord(LanguageWordModel WordLanguage);
        bool deleteCurrentWordLanguage(LanguageWordModel WordLanguage);
        List<string> lstID();
        BindingList<LanguageWordModel> getListLanguageWord(string LangID);
        string getMean(string WordName, string LangID);
        string getMeanByID(string ID, string LangID);
        BindingList<LanguageWordModel> getLstLanguageWord(string LangID, string Module);
        LanguageWordModel getWordLanguageSelectedByID(string StrID);
    }
}
