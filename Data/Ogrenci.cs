using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Ogrenci
    {
        [Key] //Key / Primary Key => By convention, a property named Id or <type name>Id will be configured as the primary key of an entity. Another way it needs to be marked with KEY annotation.
        public int OgrenciKimlik { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Email { get; set; }
        public string? Telefon  { get; set; }
    }
}