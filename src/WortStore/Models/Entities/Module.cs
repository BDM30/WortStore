/*
Класс сущности используется для биекции с одноименной таблицей в базе данных ( с помощью Entity Framework)
Отношения всех сущностей смотрите в файле WortStore/relations.vsdx
*/

namespace WortStore.Models.Entities
{
  public class Module
  {
    public int ModuleID { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
  }
}
