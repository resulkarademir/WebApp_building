using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class Hizmetler
    {
        [Key]
        public int HizmetId { get; set; }
        public string Image { get; set; }
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }
    }
}
