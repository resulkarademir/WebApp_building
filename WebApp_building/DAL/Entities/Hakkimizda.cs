using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class Hakkimizda
    {
        [Key]
        public int id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
    }
}
