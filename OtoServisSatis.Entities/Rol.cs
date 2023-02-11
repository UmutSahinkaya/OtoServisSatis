using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Rol : IEntity
    {
        public int Id { get; set; }

        [StringLength(50), Display(Name = "Adı"), Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string Adi { get; set; }
    }
}