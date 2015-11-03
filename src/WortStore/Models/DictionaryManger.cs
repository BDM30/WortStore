using System.Collections.Generic;
using System.Globalization;
using WortStore.Models.Entities;

namespace WortStore.Models
{
    public class DictionaryManger
    {
      private DataContext data;

      public DictionaryManger(DataContext d)
      {
        data = d;
      }

      public IEnumerable<Word> GetWords()
      {
        List<Word> words = new List<Word>(data.Words);
        words.Sort();
        return words;
      }

      public void AddWord(Word w)
      {
        data.Words.Add(w);
        data.SaveChanges();
      }
    }
}
