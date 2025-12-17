using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class Referanslar
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
