using ManageProjectStudent_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Data.Entity;
using ManageProjectStudent_Interface;



namespace ManageProjectStudent_ViewModel
{
    public class LanguageWordViewModel : INotifyPropertyChanged, IWordLanguage
    {
        #region by Phuoc
        private static readonly DBManageProjectStudentViewModel _Context = new DBManageProjectStudentViewModel();

        public BindingList<LanguageWordModel> loadLanguageWord()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = (from x in _Context.LanguageWordModels.AsEnumerable()
                              select new LanguageWordModel
                              {
                                  StrID = x.StrID,
                                  StrWordID = x.StrWordID,
                                  StrLanguageID = x.StrLanguageID,
                                  StrMean = x.StrMean,
                                  StrStatus = x.StrStatus
                              }).ToList();
                return new BindingList<LanguageWordModel>(Result);
            }
        }
        public BindingList<LanguageWordModel> getListLanguageWord(string LangID)
        {
            var result = _Context.LanguageWordModels.Where(x => x.StrLanguageID == LangID).ToList();
            return new BindingList<LanguageWordModel>(result);
        }

        public LanguageWordModel getWordLanguageSelectedByWordID(string StrWordID)
        {
            var WordLanguage = _Context.LanguageWordModels.SingleOrDefault
                   (x => x.StrWordID == StrWordID);
            return WordLanguage;
        }

        public LanguageWordModel getWordLanguageSelectedByLanguageID(string StrLanguageID)
        {
            var WordLanguage = _Context.LanguageWordModels.SingleOrDefault
                   (x => x.StrLanguageID == StrLanguageID);
            return WordLanguage;
        }
        public string getMean(string WordName, string LangID)
        {
            var Query = _Context.WordModels.SingleOrDefault(x => x.StrWordName == WordName);
            var Result = _Context.LanguageWordModels.Where(x => x.StrLanguageID == LangID).SingleOrDefault(x => x.StrWordID == Query.StrWordId);
            return Result.StrMean;
        }
        public List<string> lstID()
        {
            using (var _Context = new DBManageProjectStudentViewModel())
            {
                var Result = _Context.LanguageWordModels.Select(c => c.StrID).ToList();
                return Result;
            }
        }
        public bool addNewWord(LanguageWordModel WordLanguage)
        {
            try
            {
                _Context.LanguageWordModels.Add(WordLanguage);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public bool updateCurrentWord(LanguageWordModel WordLanguage)
        {
            try
            {
                var WordLanguageToUpdate = _Context.LanguageWordModels.SingleOrDefault
                 (x => x.StrID == WordLanguage.StrID);
                if (WordLanguageToUpdate != null)
                {
                    WordLanguageToUpdate.StrLanguageID = WordLanguage.StrLanguageID;
                    WordLanguageToUpdate.StrWordID = WordLanguage.StrWordID;
                    WordLanguageToUpdate.StrMean = WordLanguage.StrMean;
                    WordLanguageToUpdate.StrStatus = WordLanguage.StrStatus;
                    return (_Context.SaveChanges() != 0);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCurrentWordLanguage(LanguageWordModel WordLanguage)
        {
            try
            {
                var WordLanguageToDelete = _Context.LanguageWordModels.SingleOrDefault
                                      (x => x.StrID == WordLanguage.StrID);
                _Context.LanguageWordModels.Remove(WordLanguageToDelete);
                return (_Context.SaveChanges() != 0);
            }
            catch
            {
                return false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
