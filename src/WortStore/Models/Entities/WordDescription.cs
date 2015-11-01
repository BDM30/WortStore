/*
Класс сущности используется для биекции с одноименной таблицей в базе данных ( с помощью Entity Framework)
Отношения всех сущностей смотрите в файле WortStore/relations.vsdx
*/

namespace WortStore.Models.Entities
{
    public class WordDescription
    {
      public int WordDescriptionID { get; set; }
      public string Additional { get; set; }
    }
}
