/*
Класс сущности используется для биекции с одноименной таблицей в базе данных ( с помощью Entity Framework)
Отношения всех сущностей смотрите в файле WortStore/relations.vsdx
*/

namespace WortStore.Models.Entities
{
  public class Word
  {
    public int WordID { get; set; }
    public int DescrioptionID { get; set; }
    public int LanguageFromID { get; set; }
    public int LanguageToID { get; set; }
    public string Inscription { get; set; }
    public string Meaning { get; set; }
    public string Image { get; set; }
  }
}
