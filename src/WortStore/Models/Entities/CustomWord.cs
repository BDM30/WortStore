/*
Класс сущности используется для биекции с одноименной таблицей в базе данных ( с помощью Entity Framework)
Отношения всех сущностей смотрите в файле WortStore/relations.vsdx
*/

namespace WortStore.Models.Entities
{
    public class CustomWord
    {
      public int CustomWordID { get; set; }
      public int WordID { get; set; }
      public string AdditionalMeaning { get; set; }
      public string CustomImage { get; set; }

    }
}
