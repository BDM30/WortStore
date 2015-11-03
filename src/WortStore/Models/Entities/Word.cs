/*
Класс сущности используется для биекции с одноименной таблицей в базе данных ( с помощью Entity Framework)
Отношения всех сущностей смотрите в файле WortStore/relations.vsdx
*/
using System;
using System.Globalization;
using System.Threading;

#if DNX451
// Do something
#elif DNXCORE50
    // Do something
#else
#error No implementation for this target
#endif

namespace WortStore.Models.Entities
{
  public class Word : IComparable<Word>
  {
    public int WordID { get; set; }
    public int DescrioptionID { get; set; }
    public int LanguageFromID { get; set; }
    public int LanguageToID { get; set; }
    public string Inscription { get; set; }
    public string Meaning { get; set; }
    public string Image { get; set; }

    public int CompareTo(Word comparePart)
    {
      // A null value means that this object is greater.
      if (Inscription == null)
        return 1;
      else
        return Inscription.CompareTo(comparePart.Inscription);
      //return Inscription.CompareTo(comparePart.Inscription, new CultureInfo("en-US"));

    }
  }
}
