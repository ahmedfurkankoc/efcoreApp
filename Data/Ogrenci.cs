using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Ogrenci
    {
        [Key] //Key / Primary Key => By convention, a property named Id or <type name>Id will be configured as the primary key of an entity.
        public int OgrenciKimlik{ get; set; }
        public int MyProperty { get; set; }
    }
}
