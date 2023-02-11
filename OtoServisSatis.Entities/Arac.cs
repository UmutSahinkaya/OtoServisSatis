using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Arac:IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public int MarkaId { get; set; }
        [StringLength(50),Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Renk { get; set; }
        [Display(Name = "Fiyatı")]
        public decimal Fiyati { get; set; }

        [StringLength(50),Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Modeli { get; set; }

        [Display(Name = "Kasa Tipi"),StringLength(50), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string KasaTipi { get; set; }

        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }

        [Display(Name = "Satışta mı?")]
        public bool SatistaMi { get; set; }
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Notlar { get; set; }
        public virtual Marka? Marka { get; set; } //Araç sınıfı ile Marka sınıfı arasında bağlantı
    }
}
