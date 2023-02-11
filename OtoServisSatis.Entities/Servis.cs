using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Servise Geliş Tarihi")]
        public DateTime ServiseGelisTarihi { get; set; }
        [Display(Name = "Araç Sorunu"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string AracSorunu { get; set; }
        [Display(Name = "Servis Ücreti"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public decimal ServisUcreti { get; set; }

        [Display(Name = "Servisden Çıkış Tarihi")]
        public DateTime ServistenCikisTarihi { get; set; }

        [Display(Name = "Yapilan İşlemler"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string YapilanIslemler { get; set; }
        [Display(Name = "Garanti Kapsamında Mı?")]
        public bool GarantiKapsamindaMi { get; set; }

        [StringLength(15), Display(Name = "Aracın Plakası"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string AracPlaka { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Marka { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [StringLength(50), Display(Name = "Kasa Tipi")]
        public string? KasaTipi { get; set; }
        [StringLength(50), Display(Name = "Şase No")]
        public string? SaseNo { get; set; }
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Notlar { get; set; }
    }
}
