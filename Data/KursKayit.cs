using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }
        public int OgrenciKimlik { get; set; }
        public int KursId { get; set; }
        public DateTime KayitTarihi { get; set; }

    }
}